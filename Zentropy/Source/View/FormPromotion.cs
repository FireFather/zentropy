using Zentropy.Properties;
using ChessDotNet;
using System;
using System.Windows.Forms;

namespace Zentropy.View
{
    public partial class FormPromotion : Form
    {
        #region Fields

        private const int CP_NOCLOSE_BUTTON = 0x200;

        #endregion

        #region Properties

        public char PromotionCharacter { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        #endregion

        #region Constructors

        public FormPromotion(ChessPlayer owner)
        {
            InitializeComponent();
            Icon = Resources.ZentropyIcon;

            switch (owner)
            {
                case ChessPlayer.Black:
                     
                    _buttonQueen.BackgroundImage =  PieceImageProvider.GetFromFEN('q');
                    _buttonRook.BackgroundImage =   PieceImageProvider.GetFromFEN('r');
                    _buttonBishop.BackgroundImage = PieceImageProvider.GetFromFEN('b');
                    _buttonKnight.BackgroundImage = PieceImageProvider.GetFromFEN('n');
                    break;                          
                                                    
                case ChessPlayer.None:              
                case ChessPlayer.White:             
                                                    
                    _buttonQueen.BackgroundImage =  PieceImageProvider.GetFromFEN('Q');
                    _buttonRook.BackgroundImage =   PieceImageProvider.GetFromFEN('R');
                    _buttonBishop.BackgroundImage = PieceImageProvider.GetFromFEN('B');
                    _buttonKnight.BackgroundImage = PieceImageProvider.GetFromFEN('N');
                    break;
            }
        }

        #endregion

        #region Event Methods

        private void OnButtonClick(object sender, EventArgs e)
        {
            PromotionCharacter = char.Parse((string)((Control)sender).Tag);
            DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
