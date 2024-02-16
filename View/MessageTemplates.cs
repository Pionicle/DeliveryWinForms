namespace DeliveryWinForms.View;

internal static class MessageTemplates
{
    public static void ShowInfoMessage(string message)
    {
        MessageBox.Show(message, "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
