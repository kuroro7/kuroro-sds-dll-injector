using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PeNet;

namespace KuroroDLLInjector {
    public partial class fMAIN : Form {
        public string filename = "";
        public string dllFilename = "";
        bool loaded = false;
        bool loadedDll = false;
        PeFile peFile;
        public fMAIN() {
            InitializeComponent();
            loaded = false;
        }

        private string getDestinationFileName() {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Filter = "Executable files (*.exe)|*.exe",
                FileName = "seiya-patched.exe"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private string createFunctionName(string dllName) {
            // Remove the file extension
            var nameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(dllName);

            // Replace any non-alphanumeric characters with an underscore or any other character you want.
            var validName = System.Text.RegularExpressions.Regex.Replace(nameWithoutExtension, @"[^a-zA-Z0-9_]", string.Empty);

            // Ensure the first character is a letter (may be unnecessary if all your DLLs start with a letter)
            if (!char.IsLetter(validName[0])) {
                validName = "A" + validName;
            }

            // Append "DummyFunction" to the end of the name
            return validName + "DummyFunction";
        }

        private void btInject_Click(object sender, EventArgs e) {
            string dstPath = getDestinationFileName();
            if (dstPath.Length == 0)
                return;

            string executablePath = filename;
            string shortFilename = Path.GetFileName(filename);
            string dllName = Path.GetFileName(dllFilename);
            string functionName = createFunctionName(dllName);

            peFile = new PeFile(executablePath);

            foreach (var imp in peFile.ImportedFunctions) {
                if (imp.DLL == dllName) {
                    MessageBox.Show($"DLL {dllName} is already injected on {shortFilename}!");
                    return;
                }

                if (imp.Name == functionName) {
                    MessageBox.Show($"Dummy function {functionName} is already injected on {shortFilename}!");
                    return;
                }
            }

            peFile.AddImport(dllName, functionName);
            File.WriteAllBytes(dstPath, peFile.RawFile.ToArray());


            MessageBox.Show($"DLL {dllName} successuly injected on {shortFilename}!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        public void loadFile() {
            grid.Rows.Clear();
            peFile = new PeFile(filename);

            foreach (var imp in peFile.ImportedFunctions) {
                grid.Rows.Add(
                    imp.DLL,
                    imp.Name,
                    imp.IATOffset.ToHexString()
                );
            }
        }

        private void btSelectFile_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Executable files (*.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;

                this.filename = filePath;
                edtFilename.Text = filePath;

                loadFile();
                refreshInjectButton();
            }
        }

        private void btSelectDll_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Executable files (*.dll)|*.dll";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;

                this.dllFilename = filePath;
                edtDllPath.Text = filePath;

                refreshInjectButton();
            }
        }

        private void refreshInjectButton() {
            btInject.Enabled = filename.Length > 0 && dllFilename.Length > 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
