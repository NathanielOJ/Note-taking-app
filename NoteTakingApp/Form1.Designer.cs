﻿namespace Notetakingapp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleBox = new TextBox();
            noteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            newNoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(381, 43);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(482, 23);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(381, 100);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(482, 464);
            noteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(482, 23);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(381, 74);
            label2.Name = "label2";
            label2.Size = new Size(482, 23);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(3, 9);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(372, 455);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.White;
            loadButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(5, 469);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(175, 41);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(200, 470);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(175, 41);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(3, 523);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(175, 41);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.White;
            newNoteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            newNoteButton.Location = new Point(200, 523);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(175, 41);
            newNoteButton.TabIndex = 8;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(865, 569);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newNoteButton;
    }
}