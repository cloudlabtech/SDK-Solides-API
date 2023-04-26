using System.Net.Http.Headers;
using CloudLab.SDK.Integration.Solides.Domain;
using Microsoft.Net.Http.Headers;

namespace CloudLab.SDK.Integration.Solides.Extensions;

/// <summary>
/// Representa os métodos de extensão da classe <see cref="HttpRequestHeaders"/>.
/// </summary>
public static class HttpRequestHeadersExtensions {

    /// <summary>
    /// Adiciona os headers de autenticação obrigatórios das requisições de API da Solides.
    /// </summary>
    /// <param name="headers"><see cref="HttpRequestHeaders"/> representando os HEADERS da requisição.</param>
    /// <param name="authHeader"><see cref="AuthenticationHeader"/> representando os HEADERS de autenticação
    /// obrigatórios das requisiçoes de API da Solides.</param>
    public static void AddAuthorizationHeaders(this HttpRequestHeaders headers, AuthenticationHeader authHeader) {
        headers.TryAddWithoutValidation(HeaderNames.Authorization, authHeader.Authorization);
        headers.TryAddWithoutValidation(HeaderNames.Accept, authHeader.Accept);
        headers.TryAddWithoutValidation(HeaderNames.ContentType, authHeader.ContentType);
    }

}
