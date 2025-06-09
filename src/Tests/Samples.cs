[TestFixture]
public class Samples
{
    #region VerifyRtf

    [Test]
    public Task VerifyRtf() =>
        VerifyFile("sample.rtf");

    #endregion

    #region VerifyRtfStream

    [Test]
    public Task VerifyRtfStream()
    {
        var stream = new MemoryStream(File.ReadAllBytes("sample.rtf"));
        return Verify(stream, "rtf");
    }

    #endregion

    #region VerifyWord

    [Test]
    public Task VerifyWord() =>
        VerifyFile("sample.docx");

    #endregion

    #region VerifyWordStream

    [Test]
    public Task VerifyWordStream()
    {
        var stream = new MemoryStream(File.ReadAllBytes("sample.docx"));
        return Verify(stream, "docx");
    }

    #endregion
}