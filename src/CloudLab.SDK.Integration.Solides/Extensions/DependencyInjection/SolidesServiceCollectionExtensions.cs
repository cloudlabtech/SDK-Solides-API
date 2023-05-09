using CloudLab.SDK.Integration.Solides.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CloudLab.SDK.Integration.Solides.Extensions.DependencyInjection;

/// <summary>
/// Representa a classe de extensão para as configuração e injeção de dependência necessárias 
/// para a comunicação com a API da Solides.
/// </summary>
public static class SolidesServiceCollectionExtensions {

    #region Options Dependency Injection (appsettings DI)
    /// <summary>
    /// Adiciona as opções de configuração da API da Solides no <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> representando a coleção de serviços da aplicação.</param>
    /// <param name="configuration"><see cref="IConfiguration"/> representando as propriedades de configuração da aplicação.</param>
    /// <returns>Retorna o <see cref="IServiceCollection"/> representando a coleção de serviços da aplicação já contendo
    /// as opções de configuração da API da Solides.</returns>
    public static IServiceCollection AddSolidesAPIOptions(this IServiceCollection services, IConfiguration configuration) {
        services
            .AddOptions<SolidesOptions>()
            .Bind(configuration.GetRequiredSection(SolidesOptions.SectionName));

        return services;
    }
    #endregion

}
