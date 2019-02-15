using UnityEngine;
using System.Collections;

public class PositionPen : MonoBehaviour 
{

    public HersheyFontRenderer fontHeading;
    public HersheyFontRenderer fontDrawingText;
    public Transform Camera;
    public Transform feather;
	int idx = 0;
	int total = 1;
	string[] fonts = { "ASTROLOGY", "CURSIVE", "CYRILC 1", "CYRILLIC", "FUTURAL", "FUTURAM", "GOTHGBT", "GOTHGRT", "GOTHICENG", "GOTHICGER", "GOTHICITA", "GOTHITT", "GREEK", "GREEKC", "GREEKS", "MARKERS", "MATHLOW", "MATHUPP", "METEOROLOGY", "MUSIC", "ROWMAND", "ROWMANS", "ROWMANT", "SCRIPTC", "SCRIPTS", "SYMBOLIC", "TIMESG", "TIMESI", "TIMESIB", "TIMESR", "TIMESRB" };

	// Use this for initialization
	void Start () 
    {
		total = fonts.Length;
		fontHeading.PrintString("Hershey Font " + fonts[idx], HersheyFontRenderer.HERSHEY.astrology);
		fontDrawingText.DrawString("Unity3D                                                     ",HersheyFontRenderer.HERSHEY.astrology, Finish);
	}

    void Finish()
    {
		idx++;
		if(idx>=total)
			idx=0;
		fontHeading.PrintString("Hershey Font " + fonts[idx]);
		fontDrawingText.DrawString("Unity3D                                                     ", (HersheyFontRenderer.HERSHEY)idx, Finish);
    }

	// Update is called once per frame
	void Update ()
	{
		feather.position = fontDrawingText.GetCursorPosition();
	}
}
