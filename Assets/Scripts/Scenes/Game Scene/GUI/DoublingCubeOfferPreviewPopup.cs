using UnityEngine.UI;

public class DoublingCubeOfferPreviewPopup : Popup
{
    #region Private Variables

    /// <summary>
    /// The message.
    /// </summary>
    public Text Message;

    /// <summary>
    /// The subtext message.
    /// </summary>
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
            Message.text = string.Format("{0}, offer doubling cube?", BackgammonGame.Instance.CurrentPlayer.Name).ToUpper();
        }

        if (Subtext != null)
        {
            Subtext.text = string.Format("The stakes for this game will be increased to {0}.", BackgammonGame.Instance.Stakes * 2).ToUpper();
        }

        base.Display();
    }

    #endregion
}