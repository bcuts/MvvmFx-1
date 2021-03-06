﻿namespace MvvmFx.Controls.WinForms
{
    partial class BoundUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSourceRefresh = new MvvmFx.Controls.WinForms.BindingSourceRefresh(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh)).BeginInit();
            this.SuspendLayout();
            //
            // BoundUserControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BoundUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The binding source refresh component.
        /// </summary>
        protected BindingSourceRefresh bindingSourceRefresh;
    }
}
