namespace CKAN
{
    partial class EditLabelsDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(EditLabelsDialog));
            this.ToolTip = new System.Windows.Forms.ToolTip();
            this.LabelSelectionTree = new System.Windows.Forms.TreeView();
            this.SelectOrCreateLabel = new System.Windows.Forms.Label();
            this.EditDetailsPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.InstanceNameLabel = new System.Windows.Forms.Label();
            this.InstanceNameComboBox = new System.Windows.Forms.ComboBox();
            this.HideFromOtherFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.NotifyOnChangesCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveOnChangesCheckBox = new System.Windows.Forms.CheckBox();
            this.AlertOnInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveOnInstallCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 250;
            this.ToolTip.ShowAlways = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.CreateButton.Location = new System.Drawing.Point(10, 10);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            resources.ApplyResources(this.CreateButton, "CreateButton");
            // 
            // LabelSelectionTree
            // 
            this.LabelSelectionTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left))));
            this.LabelSelectionTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSelectionTree.FullRowSelect = true;
            this.LabelSelectionTree.HideSelection = false;
            this.LabelSelectionTree.Indent = 16;
            this.LabelSelectionTree.ItemHeight = 24;
            this.LabelSelectionTree.Location = new System.Drawing.Point(10, 43);
            this.LabelSelectionTree.Name = "LabelSelectionTree";
            this.LabelSelectionTree.Size = new System.Drawing.Size(125, 320);
            this.LabelSelectionTree.ShowPlusMinus = false;
            this.LabelSelectionTree.ShowRootLines = false;
            this.LabelSelectionTree.ShowLines = false;
            this.LabelSelectionTree.TabIndex = 0;
            this.LabelSelectionTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(LabelSelectionTree_BeforeSelect);
            this.LabelSelectionTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(LabelSelectionTree_BeforeCollapse);
            // 
            // SelectOrCreateLabel
            // 
            this.SelectOrCreateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.SelectOrCreateLabel.Location = new System.Drawing.Point(160, 50);
            this.SelectOrCreateLabel.Name = "SelectOrCreateLabel";
            this.SelectOrCreateLabel.Size = new System.Drawing.Size(300, 23);
            resources.ApplyResources(this.SelectOrCreateLabel, "SelectOrCreateLabel");
            // 
            // EditDetailsPanel
            // 
            this.EditDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditDetailsPanel.Controls.Add(this.NameLabel);
            this.EditDetailsPanel.Controls.Add(this.NameTextBox);
            this.EditDetailsPanel.Controls.Add(this.ColorLabel);
            this.EditDetailsPanel.Controls.Add(this.ColorButton);
            this.EditDetailsPanel.Controls.Add(this.InstanceNameLabel);
            this.EditDetailsPanel.Controls.Add(this.InstanceNameComboBox);
            this.EditDetailsPanel.Controls.Add(this.HideFromOtherFiltersCheckBox);
            this.EditDetailsPanel.Controls.Add(this.NotifyOnChangesCheckBox);
            this.EditDetailsPanel.Controls.Add(this.RemoveOnChangesCheckBox);
            this.EditDetailsPanel.Controls.Add(this.AlertOnInstallCheckBox);
            this.EditDetailsPanel.Controls.Add(this.RemoveOnInstallCheckBox);
            this.EditDetailsPanel.Controls.Add(this.SaveButton);
            this.EditDetailsPanel.Controls.Add(this.CancelEditButton);
            this.EditDetailsPanel.Controls.Add(this.DeleteButton);
            this.EditDetailsPanel.Location = new System.Drawing.Point(135, 43);
            this.EditDetailsPanel.Name = "EditDetailsPanel";
            this.EditDetailsPanel.Size = new System.Drawing.Size(350, 320);
            this.EditDetailsPanel.TabIndex = 1;
            this.EditDetailsPanel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.NameLabel.Location = new System.Drawing.Point(10, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 23);
            resources.ApplyResources(this.NameLabel, "NameLabel");
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.NameTextBox.Location = new System.Drawing.Point(90, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(125, 23);
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.ColorLabel.Location = new System.Drawing.Point(10, 43);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(75, 23);
            resources.ApplyResources(this.ColorLabel, "ColorLabel");
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(90, 40);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(50, 20);
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            resources.ApplyResources(this.ColorButton, "ColorButton");
            // 
            // InstanceNameLabel
            // 
            this.InstanceNameLabel.AutoSize = true;
            this.InstanceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.InstanceNameLabel.Location = new System.Drawing.Point(10, 73);
            this.InstanceNameLabel.Name = "InstanceNameLabel";
            this.InstanceNameLabel.Size = new System.Drawing.Size(75, 23);
            resources.ApplyResources(this.InstanceNameLabel, "InstanceNameLabel");
            // 
            // InstanceNameComboBox
            // 
            this.InstanceNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.InstanceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstanceNameComboBox.Location = new System.Drawing.Point(90, 70);
            this.InstanceNameComboBox.Name = "InstanceNameComboBox";
            this.InstanceNameComboBox.Size = new System.Drawing.Size(125, 23);
            resources.ApplyResources(this.InstanceNameComboBox, "InstanceNameComboBox");
            // 
            // HideFromOtherFiltersCheckBox
            // 
            this.HideFromOtherFiltersCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.HideFromOtherFiltersCheckBox.Location = new System.Drawing.Point(90, 100);
            this.HideFromOtherFiltersCheckBox.Name = "HideFromOtherFiltersCheckBox";
            this.HideFromOtherFiltersCheckBox.Size = new System.Drawing.Size(200, 23);
            resources.ApplyResources(this.HideFromOtherFiltersCheckBox, "HideFromOtherFiltersCheckBox");
            // 
            // NotifyOnChangesCheckBox
            // 
            this.NotifyOnChangesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.NotifyOnChangesCheckBox.Location = new System.Drawing.Point(90, 130);
            this.NotifyOnChangesCheckBox.Name = "NotifyOnChangesCheckBox";
            this.NotifyOnChangesCheckBox.Size = new System.Drawing.Size(200, 23);
            resources.ApplyResources(this.NotifyOnChangesCheckBox, "NotifyOnChangesCheckBox");
            // 
            // RemoveOnChangesCheckBox
            // 
            this.RemoveOnChangesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.RemoveOnChangesCheckBox.Location = new System.Drawing.Point(90, 160);
            this.RemoveOnChangesCheckBox.Name = "RemoveOnChangesCheckBox";
            this.RemoveOnChangesCheckBox.Size = new System.Drawing.Size(200, 23);
            resources.ApplyResources(this.RemoveOnChangesCheckBox, "RemoveOnChangesCheckBox");
            // 
            // AlertOnInstallCheckBox
            // 
            this.AlertOnInstallCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.AlertOnInstallCheckBox.Location = new System.Drawing.Point(90, 190);
            this.AlertOnInstallCheckBox.Name = "AlertOnInstallCheckBox";
            this.AlertOnInstallCheckBox.Size = new System.Drawing.Size(200, 23);
            resources.ApplyResources(this.AlertOnInstallCheckBox, "AlertOnInstallCheckBox");
            // 
            // RemoveOnInstallCheckBox
            // 
            this.RemoveOnInstallCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.RemoveOnInstallCheckBox.Location = new System.Drawing.Point(90, 220);
            this.RemoveOnInstallCheckBox.Name = "RemoveOnInstallCheckBox";
            this.RemoveOnInstallCheckBox.Size = new System.Drawing.Size(200, 23);
            resources.ApplyResources(this.RemoveOnInstallCheckBox, "RemoveOnInstallCheckBox");
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.SaveButton.Location = new System.Drawing.Point(10, 290);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            resources.ApplyResources(this.SaveButton, "SaveButton");
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.CancelEditButton.Location = new System.Drawing.Point(90, 290);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEditButton.TabIndex = 0;
            this.CancelEditButton.UseVisualStyleBackColor = true;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            resources.ApplyResources(this.CancelEditButton, "CancelEditButton");
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.DeleteButton.Location = new System.Drawing.Point(170, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.CloseButton.Location = new System.Drawing.Point(10, 367);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            resources.ApplyResources(this.CloseButton, "CloseButton");
            // 
            // EditLabelsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LabelSelectionTree);
            this.Controls.Add(this.SelectOrCreateLabel);
            this.Controls.Add(this.EditDetailsPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLabelsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            resources.ApplyResources(this, "$this");
            this.EditDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TreeView LabelSelectionTree;
        private System.Windows.Forms.Label SelectOrCreateLabel;
        private System.Windows.Forms.Panel EditDetailsPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label InstanceNameLabel;
        private System.Windows.Forms.ComboBox InstanceNameComboBox;
        private System.Windows.Forms.CheckBox HideFromOtherFiltersCheckBox;
        private System.Windows.Forms.CheckBox NotifyOnChangesCheckBox;
        private System.Windows.Forms.CheckBox RemoveOnChangesCheckBox;
        private System.Windows.Forms.CheckBox AlertOnInstallCheckBox;
        private System.Windows.Forms.CheckBox RemoveOnInstallCheckBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelEditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
