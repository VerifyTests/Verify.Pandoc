namespace VerifyTests;

public static class VerifyPandoc
{
    public static bool Initialized { get; private set; }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();

        EmptyFiles.FileExtensions.RemoveTextExtension("rtf");
        AddConverter<DocxIn>("docx");
        AddConverter<RtfIn>("rtf");
    }

    static void AddConverter<T>(string extension)
        where T : InOptions, new()
        => VerifierSettings.RegisterStreamConverter(
            extension, async (_, stream, _) =>
            {
                var markdown = await PandocInstance.ConvertToText<T, CommonMarkOut>(stream);
                return new(null, "md", markdown);
            });
}