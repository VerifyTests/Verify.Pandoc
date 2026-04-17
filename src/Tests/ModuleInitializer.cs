public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Initialize() =>
        VerifyPandoc.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitializeOther()
    {
        VerifyDiffPlex.Initialize();
        VerifierSettings.UseSsimForPng();
    }
}