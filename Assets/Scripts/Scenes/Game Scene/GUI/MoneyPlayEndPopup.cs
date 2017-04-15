using UnityEngine.UI;

public class MoneyPlayEndPopup : Popup
{
    #region Private Variables

    public Text Message;
    public Text Subtext;

    #endregion

    #region  Public Methods

    /// <summary>
    /// Show the popup.
    /// </summary>
    public override void Display()
    {
        if (Message != null)
        {
            Message.text = string.Format("{0} wins the game!", BackgammonGame.Instance.Winner.Name, BackgammonGame.Instance.Winner.Score).ToUpper();
        }

        if (Subtext != null)
        {
            Subtext.text = string.Format("{0} wins {1} points.", BackgammonGame.Instance.Winner.Name, BackgammonGame.Instance.Winner.Score).ToUpper();
        }

        base.Display();
    }

    #endregion
}
