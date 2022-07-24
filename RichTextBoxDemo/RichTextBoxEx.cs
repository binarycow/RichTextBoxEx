using System.ComponentModel;

namespace SampleInputApp;

public class RichTextBoxEx : RichTextBox
{
    public RichTextBoxEx()
    {
        Selectable = true;
    }
    // ReSharper disable once InconsistentNaming
    private const int WM_SETFOCUS = 0x0007;
    // ReSharper disable once InconsistentNaming
    private const int WM_KILLFOCUS = 0x0008;


    protected override void OnReadOnlyChanged(EventArgs e)
    {
        base.OnReadOnlyChanged(e);
        this.OnBackColorChanged(EventArgs.Empty);
    }

    ///<summary>
    /// Enables or disables selection highlight. 
    /// If you set `Selectable` to `false` then the selection highlight
    /// will be disabled. 
    /// It's enabled by default.
    ///</summary>
    [DefaultValue(true)]
    public bool Selectable { get; set; }

    public override Cursor? Cursor
    {
        get => Selectable ? (Cursor?)base.Cursor : Cursors.Default;
        set => base.Cursor = value;
    }
    
        
    protected override void WndProc(ref Message m)
    {

        switch (m.Msg)
        {
            case WM_SETFOCUS when Selectable is false:
                m.Msg = WM_KILLFOCUS;
                base.WndProc(ref m);
                break;
            default:
                base.WndProc(ref m);
                break;
        }
    }
}