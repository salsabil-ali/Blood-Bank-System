using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagmentSystem.Presentation_Layer
{
    
    public static class AppNavigator
    {
        private const double FadeStep = 0.12;
        private const int FadeDelayMs = 12;

        // Called from the main menu (Form1) when opening a feature page.
        // The menu is hidden (not closed) so it can be re-shown later.
        public static async void OpenPage(Form menu, Form page)
        {
            await FadeOutAsync(menu);
            menu.Hide();

            page.Opacity = 0;
            page.Show();
            await FadeInAsync(page);
        }

        // Called from any feature page's "Back to Menu" button.
        public static async void ReturnToMenu(Form currentPage)
        {
            Form1 menu = null;
            foreach (Form f in Application.OpenForms)
            {
                Form1 existing = f as Form1;
                if (existing != null)
                {
                    menu = existing;
                    break;
                }
            }
            if (menu == null)
            {
                menu = new Form1();
            }

            await FadeOutAsync(currentPage);
            currentPage.Hide();

            menu.Opacity = 0;
            menu.Show();
            await FadeInAsync(menu);

            currentPage.Close();
        }

        private static async Task FadeOutAsync(Form form)
        {
            if (form == null || form.IsDisposed) return;
            for (double o = form.Opacity; o > 0; o -= FadeStep)
            {
                form.Opacity = Math.Max(o, 0);
                await Task.Delay(FadeDelayMs);
            }
            form.Opacity = 0;
        }

        private static async Task FadeInAsync(Form form)
        {
            if (form == null || form.IsDisposed) return;
            for (double o = 0; o < 1; o += FadeStep)
            {
                form.Opacity = Math.Min(o, 1);
                await Task.Delay(FadeDelayMs);
            }
            form.Opacity = 1;
        }
    }
}