namespace CloudLab.SDK.Integration.Solides.Domain;

/// <summary>
/// Representa o HEADER de autenticação enviado em todas as requisições de API da Solides.
/// </summary>
public sealed record AuthenticationHeader {
    /// <summary>
    /// Field interno de armazenamento do valor da propriedade <see cref="Authorization"/>.
    /// </summary>
    private string _authorization = string.Empty;

    /// <summary>
    /// Representa o mime-type padrão para conteúdos no formato Json.
    /// </summary>
    private const string MIME_APPLICATION_JSON = "application/json";

    /// <summary>
    /// Retorna o token de autorização de acesso à plataforma Solides.
    /// </summary>
    /// <remarks>O valor retornado corresponde ao valor do header já formatado
    /// como <c>Authorization: Token token=VALOR_DO_TOKEN</c>.</remarks>
    public string Authorization {
        get => $"Token token={_authorization}";
        set => _authorization = value;
    }

    /// <summary>
    /// Retorna o tipo de conteúdo aceito nas requisições, definido como MIME type.
    /// </summary>
    /// <remarks>O padrão é <c>application/json</c>.</remarks>
    public string Accept { get; } = MIME_APPLICATION_JSON;

    /// <summary>
    /// Retorna o tipo de conteúdo utilizado nas requisições, definido como MIME type.
    /// </summary>
    /// <remarks>O padrão é <c>application/json</c>.</remarks>
    public string ContentType { get; init; } = MIME_APPLICATION_JSON;

}