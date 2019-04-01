namespace Zentropy.View
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._timerValidation = new System.Windows.Forms.Timer(this.components);
            this._timerAutoCheck = new System.Windows.Forms.Timer(this.components);
            this._splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._splitContainerMain = new System.Windows.Forms.SplitContainer();
            this._splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._panelLeft = new System.Windows.Forms.Panel();
            this._tableLayoutPanelEngineMatch = new System.Windows.Forms.TableLayoutPanel();
            this._labelEngine0LOS = new System.Windows.Forms.Label();
            this._labelEngine0WinPercent = new System.Windows.Forms.Label();
            this._labelEngine0Points = new System.Windows.Forms.Label();
            this._labelEngine0Wins = new System.Windows.Forms.Label();
            this._labelEngine0Draws = new System.Windows.Forms.Label();
            this._labelEngine0Losses = new System.Windows.Forms.Label();
            this._labelEngine0Name = new System.Windows.Forms.Label();
            this._labelEngine1Name = new System.Windows.Forms.Label();
            this._labelEngine1WinPercent = new System.Windows.Forms.Label();
            this._labelEngine1Points = new System.Windows.Forms.Label();
            this._labelEngine1Wins = new System.Windows.Forms.Label();
            this._labelEngine1Draws = new System.Windows.Forms.Label();
            this._labelEngine1Losses = new System.Windows.Forms.Label();
            this._emptycell = new System.Windows.Forms.Label();
            this._labelWin = new System.Windows.Forms.Label();
            this._labelDraw = new System.Windows.Forms.Label();
            this._labelLoss = new System.Windows.Forms.Label();
            this._labelPoints = new System.Windows.Forms.Label();
            this._labelWinPercent = new System.Windows.Forms.Label();
            this._labelLos = new System.Windows.Forms.Label();
            this._labelEngine1LOS = new System.Windows.Forms.Label();
            this._panelMatchInfo = new System.Windows.Forms.Panel();
            this._tableLayoutPanelMatchInfo = new System.Windows.Forms.TableLayoutPanel();
            this._labelOrderText = new System.Windows.Forms.Label();
            this._labelRound = new System.Windows.Forms.Label();
            this._labelBook = new System.Windows.Forms.Label();
            this._labelOrder = new System.Windows.Forms.Label();
            this._labelPositionText = new System.Windows.Forms.Label();
            this._labelPosition = new System.Windows.Forms.Label();
            this._labelBookText = new System.Windows.Forms.Label();
            this._labelRoundText = new System.Windows.Forms.Label();
            this._panel1MatchResults = new System.Windows.Forms.Panel();
            this._panelButtons = new System.Windows.Forms.Panel();
            this._buttonSound = new System.Windows.Forms.Button();
            this._buttonPasteFEN = new System.Windows.Forms.Button();
            this._buttonFlipBoard = new System.Windows.Forms.Button();
            this._buttonCopyFEN = new System.Windows.Forms.Button();
            this._buttonExit = new System.Windows.Forms.Button();
            this._buttonAutoPlay = new System.Windows.Forms.Button();
            this._buttonMoveNow = new System.Windows.Forms.Button();
            this._buttonNewGame = new System.Windows.Forms.Button();
            this._splitContainerBoard = new System.Windows.Forms.SplitContainer();
            this._panelResultBox = new System.Windows.Forms.Panel();
            this._panelTermination = new System.Windows.Forms.Panel();
            this._labelGameTermination = new System.Windows.Forms.Label();
            this._panelResult = new System.Windows.Forms.Panel();
            this._labelGameResult = new System.Windows.Forms.Label();
            this._panelWhiteSide = new System.Windows.Forms.Panel();
            this._panelEngine0Logo = new System.Windows.Forms.Panel();
            this._labelEngine0Logo = new System.Windows.Forms.Label();
            this._panelWhiteTime = new System.Windows.Forms.Panel();
            this._labelWhiteTime = new System.Windows.Forms.Label();
            this._labelEngine0 = new System.Windows.Forms.Label();
            this._panelBlackSide = new System.Windows.Forms.Panel();
            this._panelEngine1Logo = new System.Windows.Forms.Panel();
            this._labelEngine1Logo = new System.Windows.Forms.Label();
            this._panelBlackTime = new System.Windows.Forms.Panel();
            this._labelBlackTime = new System.Windows.Forms.Label();
            this._labelEngine1 = new System.Windows.Forms.Label();
            this._panelRight = new System.Windows.Forms.Panel();
            this._panelEvalTable = new System.Windows.Forms.Panel();
            this._tableLayoutPanelEvalInfo = new System.Windows.Forms.TableLayoutPanel();
            this._labelScoreText = new System.Windows.Forms.Label();
            this._labelScore = new System.Windows.Forms.Label();
            this._labelDepthText = new System.Windows.Forms.Label();
            this._labelNodesText = new System.Windows.Forms.Label();
            this._labelNPSText = new System.Windows.Forms.Label();
            this._labelTimeText = new System.Windows.Forms.Label();
            this._labelDepth = new System.Windows.Forms.Label();
            this._labelNodes = new System.Windows.Forms.Label();
            this._labelNPS = new System.Windows.Forms.Label();
            this._labelTime = new System.Windows.Forms.Label();
            this._tableEvaluationChart = new System.Windows.Forms.TableLayoutPanel();
            this._panelEvaluationChart = new System.Windows.Forms.Panel();
            this._dataGridViewMoves = new System.Windows.Forms.DataGridView();
            this._whiteMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._blackMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelNavButtons = new System.Windows.Forms.Panel();
            this._buttonGoToStart = new System.Windows.Forms.Button();
            this._buttonGoToEnd = new System.Windows.Forms.Button();
            this._buttonGoForward = new System.Windows.Forms.Button();
            this._buttonGoBack = new System.Windows.Forms.Button();
            this._dataGridViewEvaluation = new System.Windows.Forms.DataGridView();
            this._menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemGameOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemBoard = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemBoardSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemFlipBoard = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemOutlines = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemCoordinates = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemBorder = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemDisplayLegalMoves = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPieces = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPieceSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemHideArrows = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemHideOutputPanel = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemHideControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemHideEvalPanel = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemShowExtendedMoveInfo = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemSound = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEngine = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemEngineManagement = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemComputerMove = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemAutoPlay = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemTimeControl = new System.Windows.Forms.ToolStripMenuItem();
            this._menuStripMain = new System.Windows.Forms.MenuStrip();
            this._menuItemPGN = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemPgnOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemMatch = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemMatchNew = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemMatchOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemBook = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemBookOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._menuItemAboutZentropy = new System.Windows.Forms.ToolStripMenuItem();
            this._toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipMoveNow = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipNewGame = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipGoToStart = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipGoToEnd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGoBack = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipGoForward = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipCopyFEN = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipPasteFEN = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipSound = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipFlipBoard = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer1)).BeginInit();
            this._splitContainer1.Panel1.SuspendLayout();
            this._splitContainer1.Panel2.SuspendLayout();
            this._splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).BeginInit();
            this._splitContainerMain.Panel1.SuspendLayout();
            this._splitContainerMain.Panel2.SuspendLayout();
            this._splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer2)).BeginInit();
            this._splitContainer2.Panel1.SuspendLayout();
            this._splitContainer2.Panel2.SuspendLayout();
            this._splitContainer2.SuspendLayout();
            this._panelLeft.SuspendLayout();
            this._tableLayoutPanelEngineMatch.SuspendLayout();
            this._panelMatchInfo.SuspendLayout();
            this._tableLayoutPanelMatchInfo.SuspendLayout();
            this._panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBoard)).BeginInit();
            this._splitContainerBoard.Panel2.SuspendLayout();
            this._splitContainerBoard.SuspendLayout();
            this._panelResultBox.SuspendLayout();
            this._panelTermination.SuspendLayout();
            this._panelResult.SuspendLayout();
            this._panelWhiteSide.SuspendLayout();
            this._panelEngine0Logo.SuspendLayout();
            this._panelWhiteTime.SuspendLayout();
            this._panelBlackSide.SuspendLayout();
            this._panelEngine1Logo.SuspendLayout();
            this._panelBlackTime.SuspendLayout();
            this._panelRight.SuspendLayout();
            this._panelEvalTable.SuspendLayout();
            this._tableLayoutPanelEvalInfo.SuspendLayout();
            this._tableEvaluationChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMoves)).BeginInit();
            this._panelNavButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEvaluation)).BeginInit();
            this._menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _timerValidation
            // 
            this._timerValidation.Enabled = true;
            this._timerValidation.Interval = 50;
            this._timerValidation.Tick += new System.EventHandler(this.OnTimerValidationTick);
            // 
            // _timerAutoCheck
            // 
            this._timerAutoCheck.Enabled = true;
            this._timerAutoCheck.Interval = 40;
            this._timerAutoCheck.Tick += new System.EventHandler(this.OnTimerAutoCheckTick);
            // 
            // _splitContainer1
            // 
            this._splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer1.Location = new System.Drawing.Point(16, 42);
            this._splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this._splitContainer1.Name = "_splitContainer1";
            this._splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainer1.Panel1
            // 
            this._splitContainer1.Panel1.Controls.Add(this._splitContainerMain);
            // 
            // _splitContainer1.Panel2
            // 
            this._splitContainer1.Panel2.Controls.Add(this._dataGridViewEvaluation);
            this._splitContainer1.Size = new System.Drawing.Size(1152, 703);
            this._splitContainer1.SplitterDistance = 644;
            this._splitContainer1.TabIndex = 2;
            // 
            // _splitContainerMain
            // 
            this._splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this._splitContainerMain.Margin = new System.Windows.Forms.Padding(0);
            this._splitContainerMain.Name = "_splitContainerMain";
            // 
            // _splitContainerMain.Panel1
            // 
            this._splitContainerMain.Panel1.Controls.Add(this._splitContainer2);
            // 
            // _splitContainerMain.Panel2
            // 
            this._splitContainerMain.Panel2.Controls.Add(this._panelRight);
            this._splitContainerMain.Size = new System.Drawing.Size(1152, 644);
            this._splitContainerMain.SplitterDistance = 799;
            this._splitContainerMain.TabIndex = 3;
            // 
            // _splitContainer2
            // 
            this._splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer2.Location = new System.Drawing.Point(0, 0);
            this._splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this._splitContainer2.Name = "_splitContainer2";
            // 
            // _splitContainer2.Panel1
            // 
            this._splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this._splitContainer2.Panel1.Controls.Add(this._panelLeft);
            // 
            // _splitContainer2.Panel2
            // 
            this._splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this._splitContainer2.Panel2.Controls.Add(this._splitContainerBoard);
            this._splitContainer2.Panel2.Controls.Add(this._panelWhiteSide);
            this._splitContainer2.Panel2.Controls.Add(this._panelBlackSide);
            this._splitContainer2.Size = new System.Drawing.Size(799, 644);
            this._splitContainer2.SplitterDistance = 279;
            this._splitContainer2.TabIndex = 0;
            // 
            // _panelLeft
            // 
            this._panelLeft.AutoSize = true;
            this._panelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this._panelLeft.Controls.Add(this._tableLayoutPanelEngineMatch);
            this._panelLeft.Controls.Add(this._panelMatchInfo);
            this._panelLeft.Controls.Add(this._panel1MatchResults);
            this._panelLeft.Controls.Add(this._panelButtons);
            this._panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelLeft.Font = new System.Drawing.Font("Verdana", 9F);
            this._panelLeft.Location = new System.Drawing.Point(0, 0);
            this._panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this._panelLeft.Name = "_panelLeft";
            this._panelLeft.Size = new System.Drawing.Size(277, 642);
            this._panelLeft.TabIndex = 5;
            // 
            // _tableLayoutPanelEngineMatch
            // 
            this._tableLayoutPanelEngineMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._tableLayoutPanelEngineMatch.BackColor = System.Drawing.Color.White;
            this._tableLayoutPanelEngineMatch.ColumnCount = 3;
            this._tableLayoutPanelEngineMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this._tableLayoutPanelEngineMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this._tableLayoutPanelEngineMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0LOS, 1, 6);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0WinPercent, 1, 5);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0Points, 1, 4);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0Wins, 1, 1);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0Draws, 1, 2);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0Losses, 1, 3);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine0Name, 1, 0);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1Name, 2, 0);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1WinPercent, 2, 5);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1Points, 2, 4);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1Wins, 2, 1);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1Draws, 2, 2);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1Losses, 2, 3);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._emptycell, 0, 0);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelWin, 0, 1);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelDraw, 0, 2);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelLoss, 0, 3);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelPoints, 0, 4);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelWinPercent, 0, 5);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelLos, 0, 6);
            this._tableLayoutPanelEngineMatch.Controls.Add(this._labelEngine1LOS, 2, 6);
            this._tableLayoutPanelEngineMatch.Font = new System.Drawing.Font("Verdana", 10F);
            this._tableLayoutPanelEngineMatch.Location = new System.Drawing.Point(22, 449);
            this._tableLayoutPanelEngineMatch.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelEngineMatch.Name = "_tableLayoutPanelEngineMatch";
            this._tableLayoutPanelEngineMatch.RowCount = 7;
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this._tableLayoutPanelEngineMatch.Size = new System.Drawing.Size(235, 175);
            this._tableLayoutPanelEngineMatch.TabIndex = 14;
            // 
            // _labelEngine0LOS
            // 
            this._labelEngine0LOS.BackColor = System.Drawing.Color.White;
            this._labelEngine0LOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0LOS.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0LOS.Location = new System.Drawing.Point(56, 150);
            this._labelEngine0LOS.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0LOS.Name = "_labelEngine0LOS";
            this._labelEngine0LOS.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0LOS.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0LOS.TabIndex = 7;
            this._labelEngine0LOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0WinPercent
            // 
            this._labelEngine0WinPercent.BackColor = System.Drawing.Color.White;
            this._labelEngine0WinPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0WinPercent.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0WinPercent.Location = new System.Drawing.Point(56, 125);
            this._labelEngine0WinPercent.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0WinPercent.Name = "_labelEngine0WinPercent";
            this._labelEngine0WinPercent.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0WinPercent.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0WinPercent.TabIndex = 5;
            this._labelEngine0WinPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0Points
            // 
            this._labelEngine0Points.BackColor = System.Drawing.Color.White;
            this._labelEngine0Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Points.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0Points.Location = new System.Drawing.Point(56, 100);
            this._labelEngine0Points.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Points.Name = "_labelEngine0Points";
            this._labelEngine0Points.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0Points.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0Points.TabIndex = 3;
            this._labelEngine0Points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0Wins
            // 
            this._labelEngine0Wins.BackColor = System.Drawing.Color.White;
            this._labelEngine0Wins.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Wins.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0Wins.Location = new System.Drawing.Point(56, 25);
            this._labelEngine0Wins.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Wins.Name = "_labelEngine0Wins";
            this._labelEngine0Wins.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0Wins.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0Wins.TabIndex = 2;
            this._labelEngine0Wins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0Draws
            // 
            this._labelEngine0Draws.BackColor = System.Drawing.Color.White;
            this._labelEngine0Draws.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Draws.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0Draws.Location = new System.Drawing.Point(56, 50);
            this._labelEngine0Draws.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Draws.Name = "_labelEngine0Draws";
            this._labelEngine0Draws.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0Draws.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0Draws.TabIndex = 4;
            this._labelEngine0Draws.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0Losses
            // 
            this._labelEngine0Losses.BackColor = System.Drawing.Color.White;
            this._labelEngine0Losses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Losses.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0Losses.Location = new System.Drawing.Point(56, 75);
            this._labelEngine0Losses.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Losses.Name = "_labelEngine0Losses";
            this._labelEngine0Losses.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0Losses.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0Losses.TabIndex = 6;
            this._labelEngine0Losses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine0Name
            // 
            this._labelEngine0Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Name.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine0Name.Location = new System.Drawing.Point(56, 0);
            this._labelEngine0Name.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Name.Name = "_labelEngine0Name";
            this._labelEngine0Name.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine0Name.Size = new System.Drawing.Size(89, 25);
            this._labelEngine0Name.TabIndex = 0;
            this._labelEngine0Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1Name
            // 
            this._labelEngine1Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Name.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1Name.Location = new System.Drawing.Point(145, 0);
            this._labelEngine1Name.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Name.Name = "_labelEngine1Name";
            this._labelEngine1Name.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1Name.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1Name.TabIndex = 0;
            this._labelEngine1Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1WinPercent
            // 
            this._labelEngine1WinPercent.BackColor = System.Drawing.Color.White;
            this._labelEngine1WinPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1WinPercent.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1WinPercent.Location = new System.Drawing.Point(145, 125);
            this._labelEngine1WinPercent.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1WinPercent.Name = "_labelEngine1WinPercent";
            this._labelEngine1WinPercent.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1WinPercent.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1WinPercent.TabIndex = 5;
            this._labelEngine1WinPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1Points
            // 
            this._labelEngine1Points.BackColor = System.Drawing.Color.White;
            this._labelEngine1Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Points.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1Points.Location = new System.Drawing.Point(145, 100);
            this._labelEngine1Points.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Points.Name = "_labelEngine1Points";
            this._labelEngine1Points.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1Points.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1Points.TabIndex = 3;
            this._labelEngine1Points.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1Wins
            // 
            this._labelEngine1Wins.BackColor = System.Drawing.Color.White;
            this._labelEngine1Wins.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Wins.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1Wins.Location = new System.Drawing.Point(145, 25);
            this._labelEngine1Wins.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Wins.Name = "_labelEngine1Wins";
            this._labelEngine1Wins.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1Wins.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1Wins.TabIndex = 2;
            this._labelEngine1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1Draws
            // 
            this._labelEngine1Draws.BackColor = System.Drawing.Color.White;
            this._labelEngine1Draws.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Draws.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1Draws.Location = new System.Drawing.Point(145, 50);
            this._labelEngine1Draws.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Draws.Name = "_labelEngine1Draws";
            this._labelEngine1Draws.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1Draws.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1Draws.TabIndex = 4;
            this._labelEngine1Draws.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelEngine1Losses
            // 
            this._labelEngine1Losses.BackColor = System.Drawing.Color.White;
            this._labelEngine1Losses.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Losses.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1Losses.Location = new System.Drawing.Point(145, 75);
            this._labelEngine1Losses.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Losses.Name = "_labelEngine1Losses";
            this._labelEngine1Losses.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1Losses.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1Losses.TabIndex = 6;
            this._labelEngine1Losses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _emptycell
            // 
            this._emptycell.AutoSize = true;
            this._emptycell.Location = new System.Drawing.Point(3, 0);
            this._emptycell.Name = "_emptycell";
            this._emptycell.Size = new System.Drawing.Size(0, 17);
            this._emptycell.TabIndex = 8;
            // 
            // _labelWin
            // 
            this._labelWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelWin.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelWin.Location = new System.Drawing.Point(0, 25);
            this._labelWin.Margin = new System.Windows.Forms.Padding(0);
            this._labelWin.Name = "_labelWin";
            this._labelWin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelWin.Size = new System.Drawing.Size(56, 25);
            this._labelWin.TabIndex = 9;
            this._labelWin.Text = "Win";
            this._labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelDraw
            // 
            this._labelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelDraw.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelDraw.Location = new System.Drawing.Point(0, 50);
            this._labelDraw.Margin = new System.Windows.Forms.Padding(0);
            this._labelDraw.Name = "_labelDraw";
            this._labelDraw.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelDraw.Size = new System.Drawing.Size(56, 25);
            this._labelDraw.TabIndex = 10;
            this._labelDraw.Text = "Draw";
            this._labelDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelLoss
            // 
            this._labelLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelLoss.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelLoss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelLoss.Location = new System.Drawing.Point(0, 75);
            this._labelLoss.Margin = new System.Windows.Forms.Padding(0);
            this._labelLoss.Name = "_labelLoss";
            this._labelLoss.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelLoss.Size = new System.Drawing.Size(56, 25);
            this._labelLoss.TabIndex = 11;
            this._labelLoss.Text = "Loss";
            this._labelLoss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelPoints
            // 
            this._labelPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelPoints.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelPoints.Location = new System.Drawing.Point(0, 100);
            this._labelPoints.Margin = new System.Windows.Forms.Padding(0);
            this._labelPoints.Name = "_labelPoints";
            this._labelPoints.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelPoints.Size = new System.Drawing.Size(56, 25);
            this._labelPoints.TabIndex = 12;
            this._labelPoints.Text = "Score";
            this._labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelWinPercent
            // 
            this._labelWinPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelWinPercent.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelWinPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelWinPercent.Location = new System.Drawing.Point(0, 125);
            this._labelWinPercent.Margin = new System.Windows.Forms.Padding(0);
            this._labelWinPercent.Name = "_labelWinPercent";
            this._labelWinPercent.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelWinPercent.Size = new System.Drawing.Size(56, 25);
            this._labelWinPercent.TabIndex = 13;
            this._labelWinPercent.Text = "Win%";
            this._labelWinPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelLos
            // 
            this._labelLos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelLos.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelLos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._labelLos.Location = new System.Drawing.Point(0, 150);
            this._labelLos.Margin = new System.Windows.Forms.Padding(0);
            this._labelLos.Name = "_labelLos";
            this._labelLos.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelLos.Size = new System.Drawing.Size(56, 25);
            this._labelLos.TabIndex = 14;
            this._labelLos.Text = "LOS";
            this._labelLos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelEngine1LOS
            // 
            this._labelEngine1LOS.BackColor = System.Drawing.Color.White;
            this._labelEngine1LOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1LOS.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelEngine1LOS.Location = new System.Drawing.Point(145, 150);
            this._labelEngine1LOS.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1LOS.Name = "_labelEngine1LOS";
            this._labelEngine1LOS.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this._labelEngine1LOS.Size = new System.Drawing.Size(90, 25);
            this._labelEngine1LOS.TabIndex = 7;
            this._labelEngine1LOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _panelMatchInfo
            // 
            this._panelMatchInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._panelMatchInfo.BackColor = System.Drawing.Color.White;
            this._panelMatchInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMatchInfo.Controls.Add(this._tableLayoutPanelMatchInfo);
            this._panelMatchInfo.Location = new System.Drawing.Point(20, 270);
            this._panelMatchInfo.Margin = new System.Windows.Forms.Padding(0);
            this._panelMatchInfo.Name = "_panelMatchInfo";
            this._panelMatchInfo.Size = new System.Drawing.Size(237, 102);
            this._panelMatchInfo.TabIndex = 20;
            // 
            // _tableLayoutPanelMatchInfo
            // 
            this._tableLayoutPanelMatchInfo.ColumnCount = 2;
            this._tableLayoutPanelMatchInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelMatchInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelOrderText, 0, 2);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelRound, 1, 0);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelBook, 1, 1);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelOrder, 1, 2);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelPositionText, 0, 3);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelPosition, 1, 3);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelBookText, 0, 1);
            this._tableLayoutPanelMatchInfo.Controls.Add(this._labelRoundText, 0, 0);
            this._tableLayoutPanelMatchInfo.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMatchInfo.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelMatchInfo.Name = "_tableLayoutPanelMatchInfo";
            this._tableLayoutPanelMatchInfo.RowCount = 4;
            this._tableLayoutPanelMatchInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelMatchInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelMatchInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelMatchInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelMatchInfo.Size = new System.Drawing.Size(235, 100);
            this._tableLayoutPanelMatchInfo.TabIndex = 0;
            // 
            // _labelOrderText
            // 
            this._labelOrderText.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelOrderText.Location = new System.Drawing.Point(0, 50);
            this._labelOrderText.Margin = new System.Windows.Forms.Padding(0);
            this._labelOrderText.Name = "_labelOrderText";
            this._labelOrderText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelOrderText.Size = new System.Drawing.Size(117, 25);
            this._labelOrderText.TabIndex = 2;
            this._labelOrderText.Text = "Order";
            this._labelOrderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelRound
            // 
            this._labelRound.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelRound.Location = new System.Drawing.Point(117, 0);
            this._labelRound.Margin = new System.Windows.Forms.Padding(0);
            this._labelRound.Name = "_labelRound";
            this._labelRound.Size = new System.Drawing.Size(118, 25);
            this._labelRound.TabIndex = 3;
            this._labelRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelBook
            // 
            this._labelBook.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelBook.Location = new System.Drawing.Point(117, 25);
            this._labelBook.Margin = new System.Windows.Forms.Padding(0);
            this._labelBook.Name = "_labelBook";
            this._labelBook.Size = new System.Drawing.Size(118, 25);
            this._labelBook.TabIndex = 4;
            this._labelBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelOrder
            // 
            this._labelOrder.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelOrder.Location = new System.Drawing.Point(117, 50);
            this._labelOrder.Margin = new System.Windows.Forms.Padding(0);
            this._labelOrder.Name = "_labelOrder";
            this._labelOrder.Size = new System.Drawing.Size(118, 25);
            this._labelOrder.TabIndex = 5;
            this._labelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelPositionText
            // 
            this._labelPositionText.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelPositionText.Location = new System.Drawing.Point(0, 75);
            this._labelPositionText.Margin = new System.Windows.Forms.Padding(0);
            this._labelPositionText.Name = "_labelPositionText";
            this._labelPositionText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelPositionText.Size = new System.Drawing.Size(117, 25);
            this._labelPositionText.TabIndex = 6;
            this._labelPositionText.Text = "Position";
            this._labelPositionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelPosition
            // 
            this._labelPosition.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelPosition.Location = new System.Drawing.Point(117, 75);
            this._labelPosition.Margin = new System.Windows.Forms.Padding(0);
            this._labelPosition.Name = "_labelPosition";
            this._labelPosition.Size = new System.Drawing.Size(118, 25);
            this._labelPosition.TabIndex = 7;
            this._labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelBookText
            // 
            this._labelBookText.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelBookText.Location = new System.Drawing.Point(0, 25);
            this._labelBookText.Margin = new System.Windows.Forms.Padding(0);
            this._labelBookText.Name = "_labelBookText";
            this._labelBookText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelBookText.Size = new System.Drawing.Size(117, 25);
            this._labelBookText.TabIndex = 0;
            this._labelBookText.Text = "Book";
            this._labelBookText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelRoundText
            // 
            this._labelRoundText.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelRoundText.Location = new System.Drawing.Point(0, 0);
            this._labelRoundText.Margin = new System.Windows.Forms.Padding(0);
            this._labelRoundText.Name = "_labelRoundText";
            this._labelRoundText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelRoundText.Size = new System.Drawing.Size(117, 25);
            this._labelRoundText.TabIndex = 1;
            this._labelRoundText.Text = "Round";
            this._labelRoundText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _panel1MatchResults
            // 
            this._panel1MatchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._panel1MatchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panel1MatchResults.Font = new System.Drawing.Font("Verdana", 10F);
            this._panel1MatchResults.Location = new System.Drawing.Point(21, 448);
            this._panel1MatchResults.Margin = new System.Windows.Forms.Padding(0);
            this._panel1MatchResults.Name = "_panel1MatchResults";
            this._panel1MatchResults.Size = new System.Drawing.Size(237, 177);
            this._panel1MatchResults.TabIndex = 19;
            // 
            // _panelButtons
            // 
            this._panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelButtons.Controls.Add(this._buttonSound);
            this._panelButtons.Controls.Add(this._buttonPasteFEN);
            this._panelButtons.Controls.Add(this._buttonFlipBoard);
            this._panelButtons.Controls.Add(this._buttonCopyFEN);
            this._panelButtons.Controls.Add(this._buttonExit);
            this._panelButtons.Controls.Add(this._buttonAutoPlay);
            this._panelButtons.Controls.Add(this._buttonMoveNow);
            this._panelButtons.Controls.Add(this._buttonNewGame);
            this._panelButtons.Location = new System.Drawing.Point(19, 18);
            this._panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this._panelButtons.Name = "_panelButtons";
            this._panelButtons.Size = new System.Drawing.Size(239, 105);
            this._panelButtons.TabIndex = 18;
            // 
            // _buttonSound
            // 
            this._buttonSound.BackColor = System.Drawing.Color.Transparent;
            this._buttonSound.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonSound.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonSound.FlatAppearance.BorderSize = 0;
            this._buttonSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._buttonSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonSound.ForeColor = System.Drawing.Color.White;
            this._buttonSound.Location = new System.Drawing.Point(61, 53);
            this._buttonSound.Margin = new System.Windows.Forms.Padding(0);
            this._buttonSound.Name = "_buttonSound";
            this._buttonSound.Size = new System.Drawing.Size(58, 50);
            this._buttonSound.TabIndex = 21;
            this._buttonSound.Text = "Sound";
            this._toolTipSound.SetToolTip(this._buttonSound, "Toggle move sounds on/off");
            this._buttonSound.UseVisualStyleBackColor = false;
            this._buttonSound.Click += new System.EventHandler(this.OnButtonSoundClick);
            // 
            // _buttonPasteFEN
            // 
            this._buttonPasteFEN.BackColor = System.Drawing.Color.Transparent;
            this._buttonPasteFEN.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonPasteFEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonPasteFEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonPasteFEN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonPasteFEN.FlatAppearance.BorderSize = 0;
            this._buttonPasteFEN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonPasteFEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonPasteFEN.ForeColor = System.Drawing.Color.White;
            this._buttonPasteFEN.Location = new System.Drawing.Point(120, 2);
            this._buttonPasteFEN.Margin = new System.Windows.Forms.Padding(0);
            this._buttonPasteFEN.Name = "_buttonPasteFEN";
            this._buttonPasteFEN.Size = new System.Drawing.Size(58, 50);
            this._buttonPasteFEN.TabIndex = 20;
            this._buttonPasteFEN.TabStop = false;
            this._buttonPasteFEN.Text = "Paste FEN";
            this._toolTipPasteFEN.SetToolTip(this._buttonPasteFEN, "Paste a position to the board");
            this._buttonPasteFEN.UseVisualStyleBackColor = false;
            this._buttonPasteFEN.Click += new System.EventHandler(this.OnbuttonPasteFENClick);
            // 
            // _buttonFlipBoard
            // 
            this._buttonFlipBoard.BackColor = System.Drawing.Color.Transparent;
            this._buttonFlipBoard.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonFlipBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonFlipBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonFlipBoard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonFlipBoard.FlatAppearance.BorderSize = 0;
            this._buttonFlipBoard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._buttonFlipBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonFlipBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._buttonFlipBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonFlipBoard.ForeColor = System.Drawing.Color.White;
            this._buttonFlipBoard.Location = new System.Drawing.Point(120, 53);
            this._buttonFlipBoard.Margin = new System.Windows.Forms.Padding(0);
            this._buttonFlipBoard.Name = "_buttonFlipBoard";
            this._buttonFlipBoard.Size = new System.Drawing.Size(58, 50);
            this._buttonFlipBoard.TabIndex = 20;
            this._buttonFlipBoard.Text = "Flip Board";
            this._toolTipFlipBoard.SetToolTip(this._buttonFlipBoard, "Rotate the chessboard 180°");
            this._buttonFlipBoard.UseVisualStyleBackColor = false;
            this._buttonFlipBoard.Click += new System.EventHandler(this.OnButtonFlipBoardClick);
            // 
            // _buttonCopyFEN
            // 
            this._buttonCopyFEN.BackColor = System.Drawing.Color.Transparent;
            this._buttonCopyFEN.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonCopyFEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonCopyFEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonCopyFEN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonCopyFEN.FlatAppearance.BorderSize = 0;
            this._buttonCopyFEN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonCopyFEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonCopyFEN.ForeColor = System.Drawing.Color.White;
            this._buttonCopyFEN.Location = new System.Drawing.Point(61, 2);
            this._buttonCopyFEN.Margin = new System.Windows.Forms.Padding(0);
            this._buttonCopyFEN.Name = "_buttonCopyFEN";
            this._buttonCopyFEN.Size = new System.Drawing.Size(58, 50);
            this._buttonCopyFEN.TabIndex = 21;
            this._buttonCopyFEN.TabStop = false;
            this._buttonCopyFEN.Text = "Copy FEN";
            this._toolTipCopyFEN.SetToolTip(this._buttonCopyFEN, "Copy the current board position");
            this._buttonCopyFEN.UseVisualStyleBackColor = false;
            this._buttonCopyFEN.Click += new System.EventHandler(this.OnbuttonCopyFENClick);
            // 
            // _buttonExit
            // 
            this._buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonExit.BackColor = System.Drawing.Color.Transparent;
            this._buttonExit.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonExit.FlatAppearance.BorderSize = 0;
            this._buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonExit.ForeColor = System.Drawing.Color.White;
            this._buttonExit.Location = new System.Drawing.Point(2, 53);
            this._buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this._buttonExit.Name = "_buttonExit";
            this._buttonExit.Size = new System.Drawing.Size(58, 50);
            this._buttonExit.TabIndex = 17;
            this._buttonExit.TabStop = false;
            this._buttonExit.Text = "Exit";
            this._toolTipExit.SetToolTip(this._buttonExit, "Close and exit the application");
            this._buttonExit.UseVisualStyleBackColor = false;
            this._buttonExit.Click += new System.EventHandler(this.OnButtonExitClick);
            // 
            // _buttonAutoPlay
            // 
            this._buttonAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonAutoPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonAutoPlay.BackColor = System.Drawing.Color.Transparent;
            this._buttonAutoPlay.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonAutoPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonAutoPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonAutoPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonAutoPlay.FlatAppearance.BorderSize = 0;
            this._buttonAutoPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonAutoPlay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAutoPlay.ForeColor = System.Drawing.Color.White;
            this._buttonAutoPlay.Location = new System.Drawing.Point(179, 2);
            this._buttonAutoPlay.Margin = new System.Windows.Forms.Padding(0);
            this._buttonAutoPlay.Name = "_buttonAutoPlay";
            this._buttonAutoPlay.Size = new System.Drawing.Size(58, 50);
            this._buttonAutoPlay.TabIndex = 0;
            this._buttonAutoPlay.TabStop = false;
            this._buttonAutoPlay.Text = "Start";
            this._toolTipStart.SetToolTip(this._buttonAutoPlay, "Toggle engine autoplay \'on/off \'");
            this._buttonAutoPlay.UseVisualStyleBackColor = false;
            this._buttonAutoPlay.Click += new System.EventHandler(this.OnMenuItemAutoPlayClick);
            // 
            // _buttonMoveNow
            // 
            this._buttonMoveNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonMoveNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonMoveNow.BackColor = System.Drawing.Color.Transparent;
            this._buttonMoveNow.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonMoveNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonMoveNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonMoveNow.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonMoveNow.FlatAppearance.BorderSize = 0;
            this._buttonMoveNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonMoveNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonMoveNow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonMoveNow.ForeColor = System.Drawing.Color.White;
            this._buttonMoveNow.Location = new System.Drawing.Point(179, 53);
            this._buttonMoveNow.Margin = new System.Windows.Forms.Padding(0);
            this._buttonMoveNow.Name = "_buttonMoveNow";
            this._buttonMoveNow.Size = new System.Drawing.Size(58, 50);
            this._buttonMoveNow.TabIndex = 2;
            this._buttonMoveNow.TabStop = false;
            this._buttonMoveNow.Text = "Move Now";
            this._toolTipMoveNow.SetToolTip(this._buttonMoveNow, "Play engine\'s best move immediately");
            this._buttonMoveNow.UseVisualStyleBackColor = false;
            this._buttonMoveNow.Click += new System.EventHandler(this.OnMenuItemComputerMoveClick);
            // 
            // _buttonNewGame
            // 
            this._buttonNewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this._buttonNewGame.BackgroundImage = global::Zentropy.Properties.Resources.Button;
            this._buttonNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonNewGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonNewGame.FlatAppearance.BorderSize = 0;
            this._buttonNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonNewGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonNewGame.ForeColor = System.Drawing.Color.White;
            this._buttonNewGame.Location = new System.Drawing.Point(2, 2);
            this._buttonNewGame.Margin = new System.Windows.Forms.Padding(0);
            this._buttonNewGame.Name = "_buttonNewGame";
            this._buttonNewGame.Size = new System.Drawing.Size(58, 50);
            this._buttonNewGame.TabIndex = 1;
            this._buttonNewGame.TabStop = false;
            this._buttonNewGame.Text = "New Game";
            this._toolTipNewGame.SetToolTip(this._buttonNewGame, "Reset the board and start a new game\r\n");
            this._buttonNewGame.UseVisualStyleBackColor = false;
            this._buttonNewGame.Click += new System.EventHandler(this.OnMenuItemNewGameClick);
            // 
            // _splitContainerBoard
            // 
            this._splitContainerBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerBoard.ForeColor = System.Drawing.Color.Black;
            this._splitContainerBoard.Location = new System.Drawing.Point(0, 84);
            this._splitContainerBoard.Margin = new System.Windows.Forms.Padding(0);
            this._splitContainerBoard.Name = "_splitContainerBoard";
            this._splitContainerBoard.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this._splitContainerBoard.Panel1Collapsed = true;
            // 
            // _splitContainerBoard.Panel2
            // 
            this._splitContainerBoard.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this._splitContainerBoard.Panel2.Controls.Add(this._panelResultBox);
            this._splitContainerBoard.Panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolTipExit.SetToolTip(this._splitContainerBoard.Panel2, "Close and exit the application");
            this._splitContainerBoard.Size = new System.Drawing.Size(514, 474);
            this._splitContainerBoard.SplitterDistance = 38;
            this._splitContainerBoard.SplitterWidth = 3;
            this._splitContainerBoard.TabIndex = 2;
            this._splitContainerBoard.TabStop = false;
            // 
            // _panelResultBox
            // 
            this._panelResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._panelResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelResultBox.Controls.Add(this._panelTermination);
            this._panelResultBox.Controls.Add(this._panelResult);
            this._panelResultBox.Location = new System.Drawing.Point(164, 211);
            this._panelResultBox.Margin = new System.Windows.Forms.Padding(0);
            this._panelResultBox.Name = "_panelResultBox";
            this._panelResultBox.Size = new System.Drawing.Size(186, 53);
            this._panelResultBox.TabIndex = 13;
            // 
            // _panelTermination
            // 
            this._panelTermination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelTermination.Controls.Add(this._labelGameTermination);
            this._panelTermination.Location = new System.Drawing.Point(0, 0);
            this._panelTermination.Margin = new System.Windows.Forms.Padding(0);
            this._panelTermination.Name = "_panelTermination";
            this._panelTermination.Size = new System.Drawing.Size(184, 27);
            this._panelTermination.TabIndex = 11;
            // 
            // _labelGameTermination
            // 
            this._labelGameTermination.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameTermination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelGameTermination.ForeColor = System.Drawing.Color.Black;
            this._labelGameTermination.Location = new System.Drawing.Point(0, 0);
            this._labelGameTermination.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameTermination.Name = "_labelGameTermination";
            this._labelGameTermination.Size = new System.Drawing.Size(184, 27);
            this._labelGameTermination.TabIndex = 9;
            this._labelGameTermination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _panelResult
            // 
            this._panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelResult.Controls.Add(this._labelGameResult);
            this._panelResult.Location = new System.Drawing.Point(0, 24);
            this._panelResult.Margin = new System.Windows.Forms.Padding(0);
            this._panelResult.Name = "_panelResult";
            this._panelResult.Size = new System.Drawing.Size(184, 27);
            this._panelResult.TabIndex = 12;
            // 
            // _labelGameResult
            // 
            this._labelGameResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameResult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelGameResult.ForeColor = System.Drawing.Color.Black;
            this._labelGameResult.Location = new System.Drawing.Point(0, 0);
            this._labelGameResult.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameResult.Name = "_labelGameResult";
            this._labelGameResult.Size = new System.Drawing.Size(184, 27);
            this._labelGameResult.TabIndex = 10;
            this._labelGameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _panelWhiteSide
            // 
            this._panelWhiteSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelWhiteSide.Controls.Add(this._panelEngine0Logo);
            this._panelWhiteSide.Controls.Add(this._panelWhiteTime);
            this._panelWhiteSide.Controls.Add(this._labelEngine0);
            this._panelWhiteSide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelWhiteSide.Location = new System.Drawing.Point(0, 558);
            this._panelWhiteSide.Margin = new System.Windows.Forms.Padding(0);
            this._panelWhiteSide.Name = "_panelWhiteSide";
            this._panelWhiteSide.Size = new System.Drawing.Size(514, 84);
            this._panelWhiteSide.TabIndex = 1;
            // 
            // _panelEngine0Logo
            // 
            this._panelEngine0Logo.BackColor = System.Drawing.Color.White;
            this._panelEngine0Logo.Controls.Add(this._labelEngine0Logo);
            this._panelEngine0Logo.Location = new System.Drawing.Point(19, 17);
            this._panelEngine0Logo.Margin = new System.Windows.Forms.Padding(0);
            this._panelEngine0Logo.Name = "_panelEngine0Logo";
            this._panelEngine0Logo.Size = new System.Drawing.Size(100, 50);
            this._panelEngine0Logo.TabIndex = 9;
            // 
            // _labelEngine0Logo
            // 
            this._labelEngine0Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelEngine0Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine0Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._labelEngine0Logo.Location = new System.Drawing.Point(0, 0);
            this._labelEngine0Logo.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0Logo.Name = "_labelEngine0Logo";
            this._labelEngine0Logo.Size = new System.Drawing.Size(100, 50);
            this._labelEngine0Logo.TabIndex = 0;
            // 
            // _panelWhiteTime
            // 
            this._panelWhiteTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._panelWhiteTime.Controls.Add(this._labelWhiteTime);
            this._panelWhiteTime.ForeColor = System.Drawing.Color.Black;
            this._panelWhiteTime.Location = new System.Drawing.Point(396, 17);
            this._panelWhiteTime.Margin = new System.Windows.Forms.Padding(0);
            this._panelWhiteTime.Name = "_panelWhiteTime";
            this._panelWhiteTime.Size = new System.Drawing.Size(100, 50);
            this._panelWhiteTime.TabIndex = 0;
            // 
            // _labelWhiteTime
            // 
            this._labelWhiteTime.BackColor = System.Drawing.Color.White;
            this._labelWhiteTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelWhiteTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelWhiteTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelWhiteTime.ForeColor = System.Drawing.Color.Black;
            this._labelWhiteTime.Location = new System.Drawing.Point(0, 0);
            this._labelWhiteTime.Margin = new System.Windows.Forms.Padding(0);
            this._labelWhiteTime.Name = "_labelWhiteTime";
            this._labelWhiteTime.Size = new System.Drawing.Size(100, 50);
            this._labelWhiteTime.TabIndex = 0;
            this._labelWhiteTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelEngine0
            // 
            this._labelEngine0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelEngine0.BackColor = System.Drawing.Color.White;
            this._labelEngine0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelEngine0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEngine0.ForeColor = System.Drawing.Color.Black;
            this._labelEngine0.Location = new System.Drawing.Point(119, 17);
            this._labelEngine0.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine0.Name = "_labelEngine0";
            this._labelEngine0.Size = new System.Drawing.Size(277, 50);
            this._labelEngine0.TabIndex = 8;
            this._labelEngine0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _panelBlackSide
            // 
            this._panelBlackSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelBlackSide.Controls.Add(this._panelEngine1Logo);
            this._panelBlackSide.Controls.Add(this._panelBlackTime);
            this._panelBlackSide.Controls.Add(this._labelEngine1);
            this._panelBlackSide.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBlackSide.Location = new System.Drawing.Point(0, 0);
            this._panelBlackSide.Margin = new System.Windows.Forms.Padding(0);
            this._panelBlackSide.Name = "_panelBlackSide";
            this._panelBlackSide.Size = new System.Drawing.Size(514, 84);
            this._panelBlackSide.TabIndex = 0;
            // 
            // _panelEngine1Logo
            // 
            this._panelEngine1Logo.BackColor = System.Drawing.Color.White;
            this._panelEngine1Logo.Controls.Add(this._labelEngine1Logo);
            this._panelEngine1Logo.Location = new System.Drawing.Point(19, 18);
            this._panelEngine1Logo.Margin = new System.Windows.Forms.Padding(0);
            this._panelEngine1Logo.Name = "_panelEngine1Logo";
            this._panelEngine1Logo.Size = new System.Drawing.Size(100, 50);
            this._panelEngine1Logo.TabIndex = 9;
            // 
            // _labelEngine1Logo
            // 
            this._labelEngine1Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelEngine1Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelEngine1Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._labelEngine1Logo.Location = new System.Drawing.Point(0, 0);
            this._labelEngine1Logo.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1Logo.Name = "_labelEngine1Logo";
            this._labelEngine1Logo.Size = new System.Drawing.Size(100, 50);
            this._labelEngine1Logo.TabIndex = 0;
            // 
            // _panelBlackTime
            // 
            this._panelBlackTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._panelBlackTime.BackColor = System.Drawing.SystemColors.Control;
            this._panelBlackTime.Controls.Add(this._labelBlackTime);
            this._panelBlackTime.ForeColor = System.Drawing.Color.Black;
            this._panelBlackTime.Location = new System.Drawing.Point(394, 18);
            this._panelBlackTime.Margin = new System.Windows.Forms.Padding(0);
            this._panelBlackTime.Name = "_panelBlackTime";
            this._panelBlackTime.Size = new System.Drawing.Size(100, 50);
            this._panelBlackTime.TabIndex = 8;
            // 
            // _labelBlackTime
            // 
            this._labelBlackTime.BackColor = System.Drawing.Color.White;
            this._labelBlackTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelBlackTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelBlackTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._labelBlackTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBlackTime.ForeColor = System.Drawing.Color.Black;
            this._labelBlackTime.Location = new System.Drawing.Point(0, 0);
            this._labelBlackTime.Margin = new System.Windows.Forms.Padding(0);
            this._labelBlackTime.Name = "_labelBlackTime";
            this._labelBlackTime.Size = new System.Drawing.Size(100, 50);
            this._labelBlackTime.TabIndex = 0;
            this._labelBlackTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelEngine1
            // 
            this._labelEngine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelEngine1.BackColor = System.Drawing.Color.White;
            this._labelEngine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._labelEngine1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEngine1.ForeColor = System.Drawing.Color.Black;
            this._labelEngine1.Location = new System.Drawing.Point(119, 18);
            this._labelEngine1.Margin = new System.Windows.Forms.Padding(0);
            this._labelEngine1.Name = "_labelEngine1";
            this._labelEngine1.Size = new System.Drawing.Size(275, 50);
            this._labelEngine1.TabIndex = 7;
            this._labelEngine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _panelRight
            // 
            this._panelRight.AutoSize = true;
            this._panelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelRight.BackColor = System.Drawing.SystemColors.Control;
            this._panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelRight.Controls.Add(this._panelEvalTable);
            this._panelRight.Controls.Add(this._tableEvaluationChart);
            this._panelRight.Controls.Add(this._dataGridViewMoves);
            this._panelRight.Controls.Add(this._panelNavButtons);
            this._panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelRight.Font = new System.Drawing.Font("Verdana", 8F);
            this._panelRight.Location = new System.Drawing.Point(0, 0);
            this._panelRight.Margin = new System.Windows.Forms.Padding(0);
            this._panelRight.Name = "_panelRight";
            this._panelRight.Size = new System.Drawing.Size(349, 644);
            this._panelRight.TabIndex = 5;
            // 
            // _panelEvalTable
            // 
            this._panelEvalTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._panelEvalTable.BackColor = System.Drawing.Color.White;
            this._panelEvalTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelEvalTable.Controls.Add(this._tableLayoutPanelEvalInfo);
            this._panelEvalTable.Location = new System.Drawing.Point(99, 257);
            this._panelEvalTable.Margin = new System.Windows.Forms.Padding(0);
            this._panelEvalTable.Name = "_panelEvalTable";
            this._panelEvalTable.Size = new System.Drawing.Size(149, 127);
            this._panelEvalTable.TabIndex = 9;
            // 
            // _tableLayoutPanelEvalInfo
            // 
            this._tableLayoutPanelEvalInfo.BackColor = System.Drawing.Color.White;
            this._tableLayoutPanelEvalInfo.ColumnCount = 2;
            this._tableLayoutPanelEvalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelEvalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelScoreText, 0, 0);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelScore, 1, 0);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelDepthText, 0, 1);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelNodesText, 0, 2);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelNPSText, 0, 3);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelTimeText, 0, 4);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelDepth, 1, 1);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelNodes, 1, 2);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelNPS, 1, 3);
            this._tableLayoutPanelEvalInfo.Controls.Add(this._labelTime, 1, 4);
            this._tableLayoutPanelEvalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelEvalInfo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tableLayoutPanelEvalInfo.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelEvalInfo.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanelEvalInfo.Name = "_tableLayoutPanelEvalInfo";
            this._tableLayoutPanelEvalInfo.RowCount = 5;
            this._tableLayoutPanelEvalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelEvalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelEvalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelEvalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelEvalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanelEvalInfo.Size = new System.Drawing.Size(147, 125);
            this._tableLayoutPanelEvalInfo.TabIndex = 8;
            // 
            // _labelScoreText
            // 
            this._labelScoreText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelScoreText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelScoreText.Location = new System.Drawing.Point(0, 0);
            this._labelScoreText.Margin = new System.Windows.Forms.Padding(0);
            this._labelScoreText.Name = "_labelScoreText";
            this._labelScoreText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelScoreText.Size = new System.Drawing.Size(73, 25);
            this._labelScoreText.TabIndex = 15;
            this._labelScoreText.Text = "Score";
            this._labelScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelScore
            // 
            this._labelScore.BackColor = System.Drawing.Color.White;
            this._labelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelScore.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this._labelScore.Location = new System.Drawing.Point(73, 0);
            this._labelScore.Margin = new System.Windows.Forms.Padding(0);
            this._labelScore.Name = "_labelScore";
            this._labelScore.Size = new System.Drawing.Size(74, 25);
            this._labelScore.TabIndex = 14;
            this._labelScore.Text = "+0.00";
            this._labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelDepthText
            // 
            this._labelDepthText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelDepthText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDepthText.Location = new System.Drawing.Point(0, 25);
            this._labelDepthText.Margin = new System.Windows.Forms.Padding(0);
            this._labelDepthText.Name = "_labelDepthText";
            this._labelDepthText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelDepthText.Size = new System.Drawing.Size(73, 25);
            this._labelDepthText.TabIndex = 16;
            this._labelDepthText.Text = "Depth";
            this._labelDepthText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelNodesText
            // 
            this._labelNodesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelNodesText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNodesText.Location = new System.Drawing.Point(0, 50);
            this._labelNodesText.Margin = new System.Windows.Forms.Padding(0);
            this._labelNodesText.Name = "_labelNodesText";
            this._labelNodesText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelNodesText.Size = new System.Drawing.Size(73, 25);
            this._labelNodesText.TabIndex = 17;
            this._labelNodesText.Text = "Nodes";
            this._labelNodesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelNPSText
            // 
            this._labelNPSText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelNPSText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNPSText.Location = new System.Drawing.Point(0, 75);
            this._labelNPSText.Margin = new System.Windows.Forms.Padding(0);
            this._labelNPSText.Name = "_labelNPSText";
            this._labelNPSText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelNPSText.Size = new System.Drawing.Size(73, 25);
            this._labelNPSText.TabIndex = 18;
            this._labelNPSText.Text = "NPS";
            this._labelNPSText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelTimeText
            // 
            this._labelTimeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTimeText.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTimeText.Location = new System.Drawing.Point(0, 100);
            this._labelTimeText.Margin = new System.Windows.Forms.Padding(0);
            this._labelTimeText.Name = "_labelTimeText";
            this._labelTimeText.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this._labelTimeText.Size = new System.Drawing.Size(73, 25);
            this._labelTimeText.TabIndex = 19;
            this._labelTimeText.Text = "Time";
            this._labelTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelDepth
            // 
            this._labelDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelDepth.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDepth.Location = new System.Drawing.Point(73, 25);
            this._labelDepth.Margin = new System.Windows.Forms.Padding(0);
            this._labelDepth.Name = "_labelDepth";
            this._labelDepth.Size = new System.Drawing.Size(74, 25);
            this._labelDepth.TabIndex = 20;
            this._labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelNodes
            // 
            this._labelNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelNodes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNodes.Location = new System.Drawing.Point(73, 50);
            this._labelNodes.Margin = new System.Windows.Forms.Padding(0);
            this._labelNodes.Name = "_labelNodes";
            this._labelNodes.Size = new System.Drawing.Size(74, 25);
            this._labelNodes.TabIndex = 21;
            this._labelNodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelNPS
            // 
            this._labelNPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelNPS.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNPS.Location = new System.Drawing.Point(73, 75);
            this._labelNPS.Margin = new System.Windows.Forms.Padding(0);
            this._labelNPS.Name = "_labelNPS";
            this._labelNPS.Size = new System.Drawing.Size(74, 25);
            this._labelNPS.TabIndex = 22;
            this._labelNPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelTime
            // 
            this._labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTime.Location = new System.Drawing.Point(73, 100);
            this._labelTime.Margin = new System.Windows.Forms.Padding(0);
            this._labelTime.Name = "_labelTime";
            this._labelTime.Size = new System.Drawing.Size(74, 25);
            this._labelTime.TabIndex = 23;
            this._labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tableEvaluationChart
            // 
            this._tableEvaluationChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._tableEvaluationChart.BackColor = System.Drawing.Color.White;
            this._tableEvaluationChart.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._tableEvaluationChart.ColumnCount = 1;
            this._tableEvaluationChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableEvaluationChart.Controls.Add(this._panelEvaluationChart, 0, 0);
            this._tableEvaluationChart.Location = new System.Drawing.Point(17, 451);
            this._tableEvaluationChart.Margin = new System.Windows.Forms.Padding(0);
            this._tableEvaluationChart.Name = "_tableEvaluationChart";
            this._tableEvaluationChart.RowCount = 1;
            this._tableEvaluationChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.41675F));
            this._tableEvaluationChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this._tableEvaluationChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this._tableEvaluationChart.Size = new System.Drawing.Size(313, 176);
            this._tableEvaluationChart.TabIndex = 7;
            // 
            // _panelEvaluationChart
            // 
            this._panelEvaluationChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._panelEvaluationChart.BackColor = System.Drawing.Color.White;
            this._panelEvaluationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelEvaluationChart.ForeColor = System.Drawing.Color.Black;
            this._panelEvaluationChart.Location = new System.Drawing.Point(1, 1);
            this._panelEvaluationChart.Margin = new System.Windows.Forms.Padding(0);
            this._panelEvaluationChart.Name = "_panelEvaluationChart";
            this._panelEvaluationChart.Size = new System.Drawing.Size(311, 174);
            this._panelEvaluationChart.TabIndex = 6;
            this._panelEvaluationChart.Tag = "";
            this._panelEvaluationChart.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelEvaluationChartPaint);
            this._panelEvaluationChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPanelEvaluationChartMouseClick);
            // 
            // _dataGridViewMoves
            // 
            this._dataGridViewMoves.AllowUserToAddRows = false;
            this._dataGridViewMoves.AllowUserToDeleteRows = false;
            this._dataGridViewMoves.AllowUserToResizeColumns = false;
            this._dataGridViewMoves.AllowUserToResizeRows = false;
            this._dataGridViewMoves.BackgroundColor = System.Drawing.Color.White;
            this._dataGridViewMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewMoves.ColumnHeadersVisible = false;
            this._dataGridViewMoves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._whiteMove,
            this._blackMove});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridViewMoves.DefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridViewMoves.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridViewMoves.GridColor = System.Drawing.SystemColors.Control;
            this._dataGridViewMoves.Location = new System.Drawing.Point(17, 17);
            this._dataGridViewMoves.Margin = new System.Windows.Forms.Padding(0);
            this._dataGridViewMoves.MultiSelect = false;
            this._dataGridViewMoves.Name = "_dataGridViewMoves";
            this._dataGridViewMoves.RowHeadersVisible = false;
            this._dataGridViewMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._dataGridViewMoves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._dataGridViewMoves.ShowCellErrors = false;
            this._dataGridViewMoves.ShowEditingIcon = false;
            this._dataGridViewMoves.ShowRowErrors = false;
            this._dataGridViewMoves.Size = new System.Drawing.Size(312, 179);
            this._dataGridViewMoves.TabIndex = 7;
            // 
            // _whiteMove
            // 
            this._whiteMove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._whiteMove.FillWeight = 53F;
            this._whiteMove.HeaderText = "White Move";
            this._whiteMove.Name = "_whiteMove";
            // 
            // _blackMove
            // 
            this._blackMove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._blackMove.FillWeight = 47F;
            this._blackMove.HeaderText = "Black Move";
            this._blackMove.Name = "_blackMove";
            // 
            // _panelNavButtons
            // 
            this._panelNavButtons.Controls.Add(this._buttonGoToStart);
            this._panelNavButtons.Controls.Add(this._buttonGoToEnd);
            this._panelNavButtons.Controls.Add(this._buttonGoForward);
            this._panelNavButtons.Controls.Add(this._buttonGoBack);
            this._panelNavButtons.Location = new System.Drawing.Point(16, 205);
            this._panelNavButtons.Margin = new System.Windows.Forms.Padding(0);
            this._panelNavButtons.Name = "_panelNavButtons";
            this._panelNavButtons.Size = new System.Drawing.Size(314, 30);
            this._panelNavButtons.TabIndex = 19;
            // 
            // _buttonGoToStart
            // 
            this._buttonGoToStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonGoToStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonGoToStart.BackColor = System.Drawing.Color.Transparent;
            this._buttonGoToStart.BackgroundImage = global::Zentropy.Properties.Resources.Start;
            this._buttonGoToStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonGoToStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonGoToStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonGoToStart.FlatAppearance.BorderSize = 0;
            this._buttonGoToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonGoToStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonGoToStart.Location = new System.Drawing.Point(77, 1);
            this._buttonGoToStart.Margin = new System.Windows.Forms.Padding(0);
            this._buttonGoToStart.Name = "_buttonGoToStart";
            this._buttonGoToStart.Size = new System.Drawing.Size(40, 28);
            this._buttonGoToStart.TabIndex = 3;
            this._buttonGoToStart.TabStop = false;
            this._toolTipStart.SetToolTip(this._buttonGoToStart, "Go to start");
            this._buttonGoToStart.UseVisualStyleBackColor = false;
            this._buttonGoToStart.Click += new System.EventHandler(this.OnButtonStartClick);
            // 
            // _buttonGoToEnd
            // 
            this._buttonGoToEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonGoToEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonGoToEnd.BackColor = System.Drawing.Color.Transparent;
            this._buttonGoToEnd.BackgroundImage = global::Zentropy.Properties.Resources.End;
            this._buttonGoToEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonGoToEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonGoToEnd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonGoToEnd.FlatAppearance.BorderSize = 0;
            this._buttonGoToEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonGoToEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonGoToEnd.Location = new System.Drawing.Point(197, 1);
            this._buttonGoToEnd.Margin = new System.Windows.Forms.Padding(0);
            this._buttonGoToEnd.Name = "_buttonGoToEnd";
            this._buttonGoToEnd.Size = new System.Drawing.Size(40, 28);
            this._buttonGoToEnd.TabIndex = 6;
            this._buttonGoToEnd.TabStop = false;
            this._toolTipGoToEnd.SetToolTip(this._buttonGoToEnd, "Go to end");
            this._buttonGoToEnd.UseVisualStyleBackColor = false;
            this._buttonGoToEnd.Click += new System.EventHandler(this.OnButtonEndClick);
            // 
            // _buttonGoForward
            // 
            this._buttonGoForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonGoForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonGoForward.BackColor = System.Drawing.Color.Transparent;
            this._buttonGoForward.BackgroundImage = global::Zentropy.Properties.Resources.Forward;
            this._buttonGoForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonGoForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonGoForward.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonGoForward.FlatAppearance.BorderSize = 0;
            this._buttonGoForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonGoForward.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonGoForward.Location = new System.Drawing.Point(161, 1);
            this._buttonGoForward.Margin = new System.Windows.Forms.Padding(0);
            this._buttonGoForward.Name = "_buttonGoForward";
            this._buttonGoForward.Size = new System.Drawing.Size(28, 28);
            this._buttonGoForward.TabIndex = 4;
            this._buttonGoForward.TabStop = false;
            this._toolTipGoForward.SetToolTip(this._buttonGoForward, "Go forward one move");
            this._buttonGoForward.UseVisualStyleBackColor = false;
            this._buttonGoForward.Click += new System.EventHandler(this.OnButtonForwardClick);
            // 
            // _buttonGoBack
            // 
            this._buttonGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonGoBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._buttonGoBack.BackColor = System.Drawing.Color.Transparent;
            this._buttonGoBack.BackgroundImage = global::Zentropy.Properties.Resources.Back;
            this._buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._buttonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this._buttonGoBack.FlatAppearance.BorderSize = 0;
            this._buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonGoBack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonGoBack.Location = new System.Drawing.Point(125, 1);
            this._buttonGoBack.Margin = new System.Windows.Forms.Padding(0);
            this._buttonGoBack.Name = "_buttonGoBack";
            this._buttonGoBack.Size = new System.Drawing.Size(28, 28);
            this._buttonGoBack.TabIndex = 5;
            this._buttonGoBack.TabStop = false;
            this.toolTipGoBack.SetToolTip(this._buttonGoBack, "Go back one move");
            this._buttonGoBack.UseVisualStyleBackColor = false;
            this._buttonGoBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // _dataGridViewEvaluation
            // 
            this._dataGridViewEvaluation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._dataGridViewEvaluation.BackgroundColor = System.Drawing.SystemColors.Control;
            this._dataGridViewEvaluation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridViewEvaluation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._dataGridViewEvaluation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridViewEvaluation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridViewEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridViewEvaluation.DefaultCellStyle = dataGridViewCellStyle3;
            this._dataGridViewEvaluation.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewEvaluation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridViewEvaluation.GridColor = System.Drawing.SystemColors.Control;
            this._dataGridViewEvaluation.Location = new System.Drawing.Point(0, 0);
            this._dataGridViewEvaluation.Margin = new System.Windows.Forms.Padding(0);
            this._dataGridViewEvaluation.MultiSelect = false;
            this._dataGridViewEvaluation.Name = "_dataGridViewEvaluation";
            this._dataGridViewEvaluation.ReadOnly = true;
            this._dataGridViewEvaluation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._dataGridViewEvaluation.RowHeadersVisible = false;
            this._dataGridViewEvaluation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._dataGridViewEvaluation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewEvaluation.ShowEditingIcon = false;
            this._dataGridViewEvaluation.ShowRowErrors = false;
            this._dataGridViewEvaluation.Size = new System.Drawing.Size(1152, 55);
            this._dataGridViewEvaluation.TabIndex = 1;
            // 
            // _menuItemGame
            // 
            this._menuItemGame.BackColor = System.Drawing.Color.LightGray;
            this._menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemGameNew,
            this._menuItemGameOptions});
            this._menuItemGame.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemGame.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemGame.Name = "_menuItemGame";
            this._menuItemGame.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemGame.Size = new System.Drawing.Size(57, 26);
            this._menuItemGame.Text = "Game";
            // 
            // _menuItemGameNew
            // 
            this._menuItemGameNew.Name = "_menuItemGameNew";
            this._menuItemGameNew.Size = new System.Drawing.Size(133, 22);
            this._menuItemGameNew.Tag = "";
            this._menuItemGameNew.Text = "New";
            this._menuItemGameNew.Click += new System.EventHandler(this.OnMenuItemNewGameClick);
            // 
            // _menuItemGameOptions
            // 
            this._menuItemGameOptions.Name = "_menuItemGameOptions";
            this._menuItemGameOptions.Size = new System.Drawing.Size(133, 22);
            this._menuItemGameOptions.Text = "Options";
            this._menuItemGameOptions.Click += new System.EventHandler(this.OnMenuItemGameOptionsClick);
            // 
            // _menuItemBoard
            // 
            this._menuItemBoard.BackColor = System.Drawing.Color.LightGray;
            this._menuItemBoard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemBoardSettings,
            this._menuItemFlipBoard,
            this._menuItemOutlines,
            this._menuItemCoordinates,
            this._menuItemBorder});
            this._menuItemBoard.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemBoard.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemBoard.Name = "_menuItemBoard";
            this._menuItemBoard.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemBoard.Size = new System.Drawing.Size(56, 26);
            this._menuItemBoard.Text = "Board";
            // 
            // _menuItemBoardSettings
            // 
            this._menuItemBoardSettings.Name = "_menuItemBoardSettings";
            this._menuItemBoardSettings.Size = new System.Drawing.Size(166, 22);
            this._menuItemBoardSettings.Text = "Settings";
            this._menuItemBoardSettings.Click += new System.EventHandler(this.OnMenuItemAlterBoardClick);
            // 
            // _menuItemFlipBoard
            // 
            this._menuItemFlipBoard.CheckOnClick = true;
            this._menuItemFlipBoard.Name = "_menuItemFlipBoard";
            this._menuItemFlipBoard.Size = new System.Drawing.Size(166, 22);
            this._menuItemFlipBoard.Text = "Flip Board";
            this._menuItemFlipBoard.CheckedChanged += new System.EventHandler(this.OnMenuItemFlipBoardCheckedChanged);
            // 
            // _menuItemOutlines
            // 
            this._menuItemOutlines.CheckOnClick = true;
            this._menuItemOutlines.Name = "_menuItemOutlines";
            this._menuItemOutlines.Size = new System.Drawing.Size(166, 22);
            this._menuItemOutlines.Text = "Outlines";
            this._menuItemOutlines.CheckedChanged += new System.EventHandler(this.OnMenuItemSquareOutlineCheckedChanged);
            // 
            // _menuItemCoordinates
            // 
            this._menuItemCoordinates.CheckOnClick = true;
            this._menuItemCoordinates.Name = "_menuItemCoordinates";
            this._menuItemCoordinates.Size = new System.Drawing.Size(166, 22);
            this._menuItemCoordinates.Text = "Coordinates";
            this._menuItemCoordinates.CheckedChanged += new System.EventHandler(this.OnMenuItemCoordinatesCheckedChanged);
            // 
            // _menuItemBorder
            // 
            this._menuItemBorder.CheckOnClick = true;
            this._menuItemBorder.Name = "_menuItemBorder";
            this._menuItemBorder.Size = new System.Drawing.Size(166, 22);
            this._menuItemBorder.Text = "Border";
            this._menuItemBorder.CheckedChanged += new System.EventHandler(this.OnMenuItemBoardBorderCheckedChanged);
            // 
            // _menuItemDisplayLegalMoves
            // 
            this._menuItemDisplayLegalMoves.CheckOnClick = true;
            this._menuItemDisplayLegalMoves.Name = "_menuItemDisplayLegalMoves";
            this._menuItemDisplayLegalMoves.Size = new System.Drawing.Size(225, 22);
            this._menuItemDisplayLegalMoves.Text = "Display Legal Moves";
            this._menuItemDisplayLegalMoves.CheckedChanged += new System.EventHandler(this.OnMenuItemDisplayLegalMovesCheckedChanged);
            // 
            // _menuItemPieces
            // 
            this._menuItemPieces.BackColor = System.Drawing.Color.LightGray;
            this._menuItemPieces.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemPieceSettings});
            this._menuItemPieces.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemPieces.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemPieces.Name = "_menuItemPieces";
            this._menuItemPieces.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemPieces.Size = new System.Drawing.Size(50, 26);
            this._menuItemPieces.Text = "Piece";
            // 
            // _menuItemPieceSettings
            // 
            this._menuItemPieceSettings.Name = "_menuItemPieceSettings";
            this._menuItemPieceSettings.Size = new System.Drawing.Size(136, 22);
            this._menuItemPieceSettings.Text = "Settings";
            this._menuItemPieceSettings.Click += new System.EventHandler(this.OnMenuItemAlterPiecesClick);
            // 
            // _menuItemOptions
            // 
            this._menuItemOptions.BackColor = System.Drawing.Color.LightGray;
            this._menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemHideArrows,
            this._menuItemHideOutputPanel,
            this._menuItemHideControlPanel,
            this._menuItemHideEvalPanel,
            this._menuItemShowExtendedMoveInfo,
            this._menuItemDisplayLegalMoves,
            this._menuItemDarkMode,
            this._menuItemSound});
            this._menuItemOptions.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemOptions.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemOptions.Name = "_menuItemOptions";
            this._menuItemOptions.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemOptions.Size = new System.Drawing.Size(69, 26);
            this._menuItemOptions.Text = "Options";
            // 
            // _menuItemHideArrows
            // 
            this._menuItemHideArrows.CheckOnClick = true;
            this._menuItemHideArrows.Name = "_menuItemHideArrows";
            this._menuItemHideArrows.Size = new System.Drawing.Size(225, 22);
            this._menuItemHideArrows.Text = "Hide Arrows";
            // 
            // _menuItemHideOutputPanel
            // 
            this._menuItemHideOutputPanel.CheckOnClick = true;
            this._menuItemHideOutputPanel.Name = "_menuItemHideOutputPanel";
            this._menuItemHideOutputPanel.Size = new System.Drawing.Size(225, 22);
            this._menuItemHideOutputPanel.Text = "Hide Output Panel";
            this._menuItemHideOutputPanel.CheckedChanged += new System.EventHandler(this.OnMenuItemHideBottomPanelCheckedChanged);
            // 
            // _menuItemHideControlPanel
            // 
            this._menuItemHideControlPanel.CheckOnClick = true;
            this._menuItemHideControlPanel.Name = "_menuItemHideControlPanel";
            this._menuItemHideControlPanel.Size = new System.Drawing.Size(225, 22);
            this._menuItemHideControlPanel.Text = "Hide Control Panel";
            this._menuItemHideControlPanel.CheckedChanged += new System.EventHandler(this.OnMenuItemHideLeftPanelCheckedChanged);
            // 
            // _menuItemHideEvalPanel
            // 
            this._menuItemHideEvalPanel.CheckOnClick = true;
            this._menuItemHideEvalPanel.Name = "_menuItemHideEvalPanel";
            this._menuItemHideEvalPanel.Size = new System.Drawing.Size(225, 22);
            this._menuItemHideEvalPanel.Text = "Hide Eval Panel";
            this._menuItemHideEvalPanel.CheckedChanged += new System.EventHandler(this.OnMenuItemHideRightPanelCheckedChanged);
            // 
            // _menuItemShowExtendedMoveInfo
            // 
            this._menuItemShowExtendedMoveInfo.CheckOnClick = true;
            this._menuItemShowExtendedMoveInfo.Name = "_menuItemShowExtendedMoveInfo";
            this._menuItemShowExtendedMoveInfo.Size = new System.Drawing.Size(225, 22);
            this._menuItemShowExtendedMoveInfo.Text = "Extended Move Info";
            // 
            // _menuItemDarkMode
            // 
            this._menuItemDarkMode.CheckOnClick = true;
            this._menuItemDarkMode.Name = "_menuItemDarkMode";
            this._menuItemDarkMode.Size = new System.Drawing.Size(225, 22);
            this._menuItemDarkMode.Text = "Dark Mode";
            this._menuItemDarkMode.CheckedChanged += new System.EventHandler(this.OnMenuItemDarkModeClick);
            // 
            // _menuItemSound
            // 
            this._menuItemSound.CheckOnClick = true;
            this._menuItemSound.Name = "_menuItemSound";
            this._menuItemSound.Size = new System.Drawing.Size(225, 22);
            this._menuItemSound.Text = "Sound";
            // 
            // _menuItemEngine
            // 
            this._menuItemEngine.BackColor = System.Drawing.Color.LightGray;
            this._menuItemEngine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemEngineManagement,
            this._menuItemComputerMove,
            this._menuItemAutoPlay});
            this._menuItemEngine.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemEngine.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemEngine.Name = "_menuItemEngine";
            this._menuItemEngine.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemEngine.Size = new System.Drawing.Size(60, 26);
            this._menuItemEngine.Text = "Engine";
            // 
            // _menuItemEngineManagement
            // 
            this._menuItemEngineManagement.Name = "_menuItemEngineManagement";
            this._menuItemEngineManagement.Size = new System.Drawing.Size(173, 22);
            this._menuItemEngineManagement.Text = "Management";
            this._menuItemEngineManagement.Click += new System.EventHandler(this.OnMenuItemEngineManagementClick);
            // 
            // _menuItemComputerMove
            // 
            this._menuItemComputerMove.Name = "_menuItemComputerMove";
            this._menuItemComputerMove.Size = new System.Drawing.Size(173, 22);
            this._menuItemComputerMove.Text = "Move Now";
            this._menuItemComputerMove.Click += new System.EventHandler(this.OnMenuItemComputerMoveClick);
            // 
            // _menuItemAutoPlay
            // 
            this._menuItemAutoPlay.Name = "_menuItemAutoPlay";
            this._menuItemAutoPlay.Size = new System.Drawing.Size(173, 22);
            this._menuItemAutoPlay.Text = "Auto Play";
            this._menuItemAutoPlay.Click += new System.EventHandler(this.OnMenuItemAutoPlayClick);
            // 
            // _menuItemTime
            // 
            this._menuItemTime.BackColor = System.Drawing.Color.LightGray;
            this._menuItemTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemTimeControl});
            this._menuItemTime.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuItemTime.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemTime.Name = "_menuItemTime";
            this._menuItemTime.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemTime.Size = new System.Drawing.Size(48, 26);
            this._menuItemTime.Text = "Time";
            // 
            // _menuItemTimeControl
            // 
            this._menuItemTimeControl.Name = "_menuItemTimeControl";
            this._menuItemTimeControl.Size = new System.Drawing.Size(131, 22);
            this._menuItemTimeControl.Text = "Control";
            this._menuItemTimeControl.Click += new System.EventHandler(this.OnMenuItemAlterTimeControlClick);
            // 
            // _menuStripMain
            // 
            this._menuStripMain.AutoSize = false;
            this._menuStripMain.BackColor = System.Drawing.Color.LightGray;
            this._menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._menuStripMain.Font = new System.Drawing.Font("Verdana", 11F);
            this._menuStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this._menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemGame,
            this._menuItemPGN,
            this._menuItemBoard,
            this._menuItemPieces,
            this._menuItemOptions,
            this._menuItemEngine,
            this._menuItemMatch,
            this._menuItemTime,
            this._menuItemBook,
            this._menuItemAbout});
            this._menuStripMain.Location = new System.Drawing.Point(16, 0);
            this._menuStripMain.Margin = new System.Windows.Forms.Padding(0, 16, 0, 8);
            this._menuStripMain.Name = "_menuStripMain";
            this._menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            this._menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._menuStripMain.Size = new System.Drawing.Size(1152, 42);
            this._menuStripMain.TabIndex = 1;
            // 
            // _menuItemPGN
            // 
            this._menuItemPGN.BackColor = System.Drawing.Color.LightGray;
            this._menuItemPGN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemPgnOptions});
            this._menuItemPGN.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemPGN.Name = "_menuItemPGN";
            this._menuItemPGN.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemPGN.Size = new System.Drawing.Size(44, 26);
            this._menuItemPGN.Text = "PGN";
            // 
            // _menuItemPgnOptions
            // 
            this._menuItemPgnOptions.Name = "_menuItemPgnOptions";
            this._menuItemPgnOptions.Size = new System.Drawing.Size(133, 22);
            this._menuItemPgnOptions.Text = "Options";
            this._menuItemPgnOptions.Click += new System.EventHandler(this.OnMenuItemPgnOptionsClick);
            // 
            // _menuItemMatch
            // 
            this._menuItemMatch.BackColor = System.Drawing.Color.LightGray;
            this._menuItemMatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemMatchNew,
            this._menuItemMatchOptions});
            this._menuItemMatch.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemMatch.Name = "_menuItemMatch";
            this._menuItemMatch.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemMatch.Size = new System.Drawing.Size(57, 26);
            this._menuItemMatch.Text = "Match";
            // 
            // _menuItemMatchNew
            // 
            this._menuItemMatchNew.Name = "_menuItemMatchNew";
            this._menuItemMatchNew.Size = new System.Drawing.Size(133, 22);
            this._menuItemMatchNew.Text = "New";
            this._menuItemMatchNew.Click += new System.EventHandler(this.OnMenuItemMatchNewClick);
            // 
            // _menuItemMatchOptions
            // 
            this._menuItemMatchOptions.Name = "_menuItemMatchOptions";
            this._menuItemMatchOptions.Size = new System.Drawing.Size(133, 22);
            this._menuItemMatchOptions.Text = "Options";
            this._menuItemMatchOptions.Click += new System.EventHandler(this.OnMenuItemMatchOptionsClick);
            // 
            // _menuItemBook
            // 
            this._menuItemBook.BackColor = System.Drawing.Color.LightGray;
            this._menuItemBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemBookOptions});
            this._menuItemBook.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemBook.Name = "_menuItemBook";
            this._menuItemBook.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemBook.Size = new System.Drawing.Size(51, 26);
            this._menuItemBook.Text = "Book";
            // 
            // _menuItemBookOptions
            // 
            this._menuItemBookOptions.Name = "_menuItemBookOptions";
            this._menuItemBookOptions.Size = new System.Drawing.Size(133, 22);
            this._menuItemBookOptions.Text = "Options";
            this._menuItemBookOptions.Click += new System.EventHandler(this.OnMenuItemBookOptionsClick);
            // 
            // _menuItemAbout
            // 
            this._menuItemAbout.BackColor = System.Drawing.Color.LightGray;
            this._menuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemAboutZentropy});
            this._menuItemAbout.Margin = new System.Windows.Forms.Padding(0, 8, 4, 8);
            this._menuItemAbout.Name = "_menuItemAbout";
            this._menuItemAbout.Padding = new System.Windows.Forms.Padding(0);
            this._menuItemAbout.Size = new System.Drawing.Size(56, 26);
            this._menuItemAbout.Text = "About";
            // 
            // _menuItemAboutZentropy
            // 
            this._menuItemAboutZentropy.Name = "_menuItemAboutZentropy";
            this._menuItemAboutZentropy.Size = new System.Drawing.Size(144, 22);
            this._menuItemAboutZentropy.Text = "Zentropy";
            this._menuItemAboutZentropy.Click += new System.EventHandler(this.OnMenuItemAboutZentropyClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this._splitContainer1);
            this.Controls.Add(this._menuStripMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this._menuStripMain;
            this.MinimumSize = new System.Drawing.Size(512, 320);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(16, 0, 16, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zentropy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormMainClosing);
            this.Load += new System.EventHandler(this.OnFormMainLoad);
            this._splitContainer1.Panel1.ResumeLayout(false);
            this._splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer1)).EndInit();
            this._splitContainer1.ResumeLayout(false);
            this._splitContainerMain.Panel1.ResumeLayout(false);
            this._splitContainerMain.Panel2.ResumeLayout(false);
            this._splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerMain)).EndInit();
            this._splitContainerMain.ResumeLayout(false);
            this._splitContainer2.Panel1.ResumeLayout(false);
            this._splitContainer2.Panel1.PerformLayout();
            this._splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer2)).EndInit();
            this._splitContainer2.ResumeLayout(false);
            this._panelLeft.ResumeLayout(false);
            this._tableLayoutPanelEngineMatch.ResumeLayout(false);
            this._tableLayoutPanelEngineMatch.PerformLayout();
            this._panelMatchInfo.ResumeLayout(false);
            this._tableLayoutPanelMatchInfo.ResumeLayout(false);
            this._panelButtons.ResumeLayout(false);
            this._splitContainerBoard.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerBoard)).EndInit();
            this._splitContainerBoard.ResumeLayout(false);
            this._panelResultBox.ResumeLayout(false);
            this._panelTermination.ResumeLayout(false);
            this._panelResult.ResumeLayout(false);
            this._panelWhiteSide.ResumeLayout(false);
            this._panelEngine0Logo.ResumeLayout(false);
            this._panelWhiteTime.ResumeLayout(false);
            this._panelBlackSide.ResumeLayout(false);
            this._panelEngine1Logo.ResumeLayout(false);
            this._panelBlackTime.ResumeLayout(false);
            this._panelRight.ResumeLayout(false);
            this._panelEvalTable.ResumeLayout(false);
            this._tableLayoutPanelEvalInfo.ResumeLayout(false);
            this._tableEvaluationChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMoves)).EndInit();
            this._panelNavButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewEvaluation)).EndInit();
            this._menuStripMain.ResumeLayout(false);
            this._menuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer _timerValidation;
        private System.Windows.Forms.Timer _timerAutoCheck;
        private System.Windows.Forms.SplitContainer _splitContainer1;
        private System.Windows.Forms.SplitContainer _splitContainerMain;
        private System.Windows.Forms.SplitContainer _splitContainer2;
        private System.Windows.Forms.Panel _panelLeft;
        private System.Windows.Forms.DataGridView _dataGridViewMoves;
        private System.Windows.Forms.DataGridView _dataGridViewEvaluation;
        private System.Windows.Forms.Panel _panelRight;
        private System.Windows.Forms.TableLayoutPanel _tableEvaluationChart;
        private System.Windows.Forms.Panel _panelEvaluationChart;
        private System.Windows.Forms.Label _labelScore;
        private System.Windows.Forms.Panel _panelWhiteSide;
        private System.Windows.Forms.Panel _panelBlackSide;
        private System.Windows.Forms.SplitContainer _splitContainerBoard;
        private System.Windows.Forms.Label _labelEngine1;
        private System.Windows.Forms.Label _labelEngine0;
        private System.Windows.Forms.Button _buttonGoToEnd;
        private System.Windows.Forms.Button _buttonGoToStart;
        private System.Windows.Forms.Button _buttonGoForward;
        private System.Windows.Forms.Button _buttonGoBack;
        private System.Windows.Forms.Button _buttonNewGame;
        private System.Windows.Forms.Button _buttonMoveNow;
        private System.Windows.Forms.Button _buttonAutoPlay;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGame;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGameNew;
        private System.Windows.Forms.ToolStripMenuItem _menuItemBoard;
        private System.Windows.Forms.ToolStripMenuItem _menuItemBoardSettings;
        private System.Windows.Forms.ToolStripMenuItem _menuItemFlipBoard;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOutlines;
        private System.Windows.Forms.ToolStripMenuItem _menuItemCoordinates;
        private System.Windows.Forms.ToolStripMenuItem _menuItemBorder;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPieces;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPieceSettings;
        private System.Windows.Forms.ToolStripMenuItem _menuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideArrows;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideOutputPanel;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideControlPanel;
        private System.Windows.Forms.ToolStripMenuItem _menuItemHideEvalPanel;
        private System.Windows.Forms.ToolStripMenuItem _menuItemShowExtendedMoveInfo;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDisplayLegalMoves;
        private System.Windows.Forms.ToolStripMenuItem _menuItemSound;
        private System.Windows.Forms.ToolStripMenuItem _menuItemDarkMode;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEngine;
        private System.Windows.Forms.ToolStripMenuItem _menuItemEngineManagement;
        private System.Windows.Forms.ToolStripMenuItem _menuItemComputerMove;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAutoPlay;
        private System.Windows.Forms.ToolStripMenuItem _menuItemTime;
        private System.Windows.Forms.ToolStripMenuItem _menuItemTimeControl;
        private System.Windows.Forms.Label _labelBlackTime;
        private System.Windows.Forms.Label _labelWhiteTime;
        private System.Windows.Forms.MenuStrip _menuStripMain;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelEvalInfo;
        private System.Windows.Forms.Label _labelScoreText;
        private System.Windows.Forms.Label _labelDepthText;
        private System.Windows.Forms.Label _labelNodesText;
        private System.Windows.Forms.Label _labelNPSText;
        private System.Windows.Forms.Label _labelTimeText;
        private System.Windows.Forms.Label _labelDepth;
        private System.Windows.Forms.Label _labelNodes;
        private System.Windows.Forms.Label _labelNPS;
        private System.Windows.Forms.Label _labelTime;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelEngineMatch;
        private System.Windows.Forms.Label _labelEngine1Name;
        private System.Windows.Forms.Label _labelEngine1LOS;
        private System.Windows.Forms.Label _labelEngine1WinPercent;
        private System.Windows.Forms.Label _labelEngine1Points;
        private System.Windows.Forms.Label _labelEngine1Wins;
        private System.Windows.Forms.Label _labelEngine1Draws;
        private System.Windows.Forms.Label _labelEngine1Losses;
        private System.Windows.Forms.Label _labelEngine0LOS;
        private System.Windows.Forms.Label _labelEngine0WinPercent;
        private System.Windows.Forms.Label _labelEngine0Points;
        private System.Windows.Forms.Label _labelEngine0Wins;
        private System.Windows.Forms.Label _labelEngine0Draws;
        private System.Windows.Forms.Label _labelEngine0Losses;
        private System.Windows.Forms.Label _labelEngine0Name;
        private System.Windows.Forms.Label _emptycell;
        private System.Windows.Forms.Label _labelWin;
        private System.Windows.Forms.Label _labelDraw;
        private System.Windows.Forms.Label _labelLoss;
        private System.Windows.Forms.Label _labelPoints;
        private System.Windows.Forms.Label _labelWinPercent;
        private System.Windows.Forms.Label _labelLos;
        private System.Windows.Forms.DataGridViewTextBoxColumn _whiteMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn _blackMove;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPGN;
        private System.Windows.Forms.ToolStripMenuItem _menuItemPgnOptions;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMatch;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMatchOptions;
        private System.Windows.Forms.Label _labelGameTermination;
        private System.Windows.Forms.Label _labelGameResult;
        private System.Windows.Forms.Panel _panelResult;
        private System.Windows.Forms.Panel _panelTermination;
        private System.Windows.Forms.Panel _panelResultBox;
        private System.Windows.Forms.Panel _panelEvalTable;
        private System.Windows.Forms.ToolStripMenuItem _menuItemBook;
        private System.Windows.Forms.ToolStripMenuItem _menuItemBookOptions;
        private System.Windows.Forms.Panel _panelWhiteTime;
        private System.Windows.Forms.Panel _panelBlackTime;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem _menuItemAboutZentropy;
        private System.Windows.Forms.Button _buttonExit;
        private System.Windows.Forms.Panel _panelButtons;
        private System.Windows.Forms.Panel _panelNavButtons;
        private System.Windows.Forms.Panel _panel1MatchResults;
        private System.Windows.Forms.Panel _panelEngine0Logo;
        private System.Windows.Forms.Panel _panelEngine1Logo;
        private System.Windows.Forms.Label _labelEngine0Logo;
        private System.Windows.Forms.Label _labelEngine1Logo;
        private System.Windows.Forms.ToolStripMenuItem _menuItemMatchNew;
        private System.Windows.Forms.ToolStripMenuItem _menuItemGameOptions;
        private System.Windows.Forms.ToolTip _toolTipExit;
        private System.Windows.Forms.ToolTip _toolTipStart;
        private System.Windows.Forms.ToolTip _toolTipMoveNow;
        private System.Windows.Forms.ToolTip _toolTipNewGame;
        private System.Windows.Forms.ToolTip _toolTipGoToEnd;
        private System.Windows.Forms.ToolTip _toolTipGoToStart;
        private System.Windows.Forms.ToolTip toolTipGoBack;
        private System.Windows.Forms.ToolTip _toolTipGoForward;
        private System.Windows.Forms.Button _buttonPasteFEN;
        private System.Windows.Forms.Button _buttonCopyFEN;
        private System.Windows.Forms.Button _buttonSound;
        private System.Windows.Forms.Button _buttonFlipBoard;
        private System.Windows.Forms.ToolTip _toolTipSound;
        private System.Windows.Forms.ToolTip _toolTipPasteFEN;
        private System.Windows.Forms.ToolTip _toolTipFlipBoard;
        private System.Windows.Forms.ToolTip _toolTipCopyFEN;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMatchInfo;
        private System.Windows.Forms.Label _labelBookText;
        private System.Windows.Forms.Label _labelRoundText;
        private System.Windows.Forms.Label _labelOrderText;
        private System.Windows.Forms.Panel _panelMatchInfo;
        private System.Windows.Forms.Label _labelRound;
        private System.Windows.Forms.Label _labelBook;
        private System.Windows.Forms.Label _labelOrder;
        private System.Windows.Forms.Label _labelPositionText;
        private System.Windows.Forms.Label _labelPosition;
    }
}

