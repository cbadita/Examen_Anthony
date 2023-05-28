
public class ButtonCount : ButtonMain
{
    public override void Click()
    {
        ScoreMain.instance.Increment(score);
    }
}
