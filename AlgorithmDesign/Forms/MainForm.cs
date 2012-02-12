using System;
using System.Windows.Forms;

namespace AlgorithmDesign.Forms
{
    public partial class MainForm : BaseForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private SubSet _frmSubSet;
        private void OpenSubSet(object sender, EventArgs e)
        {
            _frmSubSet = new SubSet();
            _frmSubSet.FormClosed += FrmSubSetClosed;
            _frmSubSet.Show();
            Hide();
        }
        void FrmSubSetClosed(object sender, FormClosedEventArgs e)
        {
            _frmSubSet.Dispose();
            _frmSubSet = null;
            Show();
        }

        private FrmProduction _frmProduction;
        private void OpenProduction(object sender, EventArgs e)
        {
            _frmProduction = new FrmProduction();
            _frmProduction.FormClosed += FrmProductionClosed;
            _frmProduction.Show();
            Hide();

        }
        void FrmProductionClosed(object sender, FormClosedEventArgs e)
        {
            _frmProduction.Dispose();
            _frmProduction = null;
            Show();
        }

        private Sum2String _frmsumstrings;
        private void BtnSum2StringClick(object sender, EventArgs e)
        {
            _frmsumstrings = new Sum2String();
            _frmsumstrings.FormClosed += Sum2StringClosed;
            _frmsumstrings.Show();
            Hide();
        }
        void Sum2StringClosed(object sender, FormClosedEventArgs e)
        {
            _frmsumstrings.Dispose();
            _frmsumstrings = null;
            Show();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void LblAuthorNoteClick(object sender, EventArgs e)
        {
            Animatedtimer.Enabled = true;
        }

        private MobileKeypad _frmkeypad;
        private void BtnKeypadClick(object sender, EventArgs e)
        {
            _frmkeypad = new MobileKeypad();
            _frmkeypad.FormClosed += FrmKeypadClosed;
            _frmkeypad.Show();
            Hide();
        }
        void FrmKeypadClosed(object sender, FormClosedEventArgs e)
        {
            _frmkeypad.Dispose();
            _frmkeypad = null;
            Show();
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            Close();
        }

        //----------------------------------   for timer   -------------------------------------//
        static int _index;
        private const string Authortxt =
            "این برنامه ها توسط جواد عوض زاده برای درس طراحی الگوریتم نوشته شده است.  ";
        private void AnimatedtimerTick(object sender, EventArgs e)
        {
            lblAuthorNote.Text =  @"." + Authortxt.Substring(0, _index);
            _index++;
            //Animatedtimer.Interval += 1;
            if (_index == Authortxt.Length + 1)
            {
                _index = 0;
                //Animatedtimer.Interval = 100;
                Animatedtimer.Enabled = false;
            }
        }
        //----------------------------------   for timer   -------------------------------------//

        private void LblDescClick(object sender, EventArgs e)
        {
            MessageBox.Show(@"جواد عوض زاده کاکرودی - 87143100028" + Environment.NewLine
                            + @"http://www.Evazzadeh.com" + Environment.NewLine
                            + @"0935-726-9759", @"Javad Evazzadeh kakroudi");
        }
    }
}
