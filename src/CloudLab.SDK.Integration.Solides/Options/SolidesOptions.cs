namespace CloudLab.SDK.Integration.Solides.Options;

/// <summary>
/// Representa as opções de configuração para o consumo da API da Solides.
/// </summary>
public sealed class SolidesOptions {
    /// <summary>
    /// Representa o nome da seção (Json Property) onde estão localizadas as opções de configuração 
    /// para o consumo da API da Solides.
    /// </summary>
    public const string SectionName = "SolidesAPI";

    #region Properties / Configuration Options
    /// <summary>
    /// Retorna ou define o token de autenticação que deve ser enviado no header em todas as requisições.
    /// </summary>
    /// <remarks>Saiba como gerar o token de autenticação da API no link <see href="https://gestaoapidocs.solides.com.br/#section/Autenticacao"/></remarks>
    public required string? AuthenticationToken { get; init; } = null;
    #endregion
}
