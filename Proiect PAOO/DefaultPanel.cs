using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public class DefaultPanel : UserControl
    {

        virtual public void FillPanel() { 
        
        }


        virtual public void addNewCell()
        {

        }

        virtual public void refresh()
        {

        }

        virtual public void update()
        {

        }

        virtual public void insert()
        {

        }

        virtual public void deleteCurrentCell()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DefaultPanel
            // 
            this.Name = "DefaultPanel";
            this.ResumeLayout(false);
        }
    }
}
