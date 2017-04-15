using UnityEngine.UI;

public class MatchPlayEndPopup : Popup
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
            Message.text = string.Format("{0} wins the match!", BackgammonGame.Instance.Winner.Name).ToUpper();
        }

        if (Subtext != null)
        {
            Subtext.text = string.Format("{0} has reached the match score.", BackgammonGame.Instance.Winner.Name).ToUpper();
        }

        base.Display();
    }

    #endregion
}