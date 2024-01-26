O projeto se trata de um serviço web de uma loja de discos de vinil e foi desenvolvido entre novembro e dezembro de 2023.
Esse projeto foi o trabalho da disciplina **Desenvolvimento Web com .NET e Bases de Dados** do curso de ADS no INFNET.
Abaixo segue a transcrição dos enunciados do trabalho para melhor entendimento.

**Neste TP1 você deve criar um aplicativo web para uma loja de venda de produtos. O contexto da loja (tipos de produtos oferecidos) é determinado através do tema escolhido pelo aluno nas primeiras aulas da disciplina. 
**
Requisitos:

    Neste aplicativo, você deve desenvolver uma nova página web com informações gerais sobre a sua loja. Sugestão de nome para esta página: “QuemSomos”;
    Na página web “QuemSomos”, deve ser exibido pelo menos uma imagem que represente a sua loja;
    Neste aplicativo, você deve também desenvolver uma nova página web com os termos de privacidade da sua loja; Sugestão de nome para esta página: “Privacidade”;
    Neste aplicativo, você deve adicionar um link para as páginas “QuemSomos” e “Privacidade” em um menu principal (header), que fique visível durante toda a navegação do usuário;
    Aplique um tema personalizado no arquivo de layout razor com cores e fontes e especifique o nome da sua loja na barra de navegação do aplicativo.

Requisitos técnicos:

    Crie um projeto web ASP.NET Core e utilize o template de exemplo com Razor Pages com uma das opções abaixo:
        Template do Visual Studio Community: “ASP.NET Core Web App”
        Template CLI dotnet: dotnet new razor
    Crie as duas páginas (quem somos e privacidade) usando apenas página de conteúdo (Page Content). Não utilize classe modelo de página (Page Model) para estes cenários;
    No template de exemplo utilizado foi gerado uma página padrão de layout do Razor Page. Aplique um tema personalizado no layout (folha de estilo, script do bootstrap e menu principal);
        Algumas folhas de estilos disponíveis
        Última versão do bootstrap
    No template de exemplo utilizado foi gerado automaticamente uma pequena página contendo os termos de privacidade. Se preferir, utilize esta página e realize as adaptações textuais para a página de privacidade;


**Neste TP2 você deve evoluir o aplicativo web da sua loja de venda de produtos/serviços criado na avaliação anterior. Lembrando que o tema da loja deve seguir de acordo com a escolha do aluno na postagem do professor no Teams da turma.
**
Requisitos:

    Neste aplicativo, você deve desenvolver duas páginas de consulta: listagem de produtos/serviços e detalhe do produto/serviço;
    Neste aplicativo, você deve desenvolver uma página para inclusão de produto/serviço;
    Neste aplicativo, você deve desenvolver uma página para alteração e exclusão de produto/serviço;
    A página inicial do seu aplicativo web deve ser a página de listagem de produto/serviço;
    Desenvolva links ou botões para permitir o acesso do usuário a todas as operações (detalhe, inclusão, alteração e exclusão).

Requisitos técnicos:

    Crie todas as páginas web do CRUD (listagem, detalhe, inclusão, alteração/exclusão) com Página de Conteúdo e a classe PageModel correspondente;
    Crie uma classe modelo com pelo menos cinco propriedades diferentes com os seguintes tipos: int, string, bool, double e DateTime;
    Para cada produto/serviço da sua loja, forneça uma imagem correspondente, armazenando-a na pasta wwwroot;
    Implemente uma classe de serviço como banco de dados da aplicação, usando injeção de dependência;
    Utilize Data Annotations na classe modelo para exibição e validação das informações;
    Utilize tag helpers nas páginas de conteúdo para exibir e validar as informações;
    Desenvolva e utilize o recurso de roteamento amigável no formato de slug na página de detalhe;

**Neste TP3 você deve evoluir o aplicativo web da sua loja de venda de produtos/serviços a partir da avaliação anterior. Lembrando que o tema da loja deve seguir de acordo com a escolha do aluno na postagem do professor no Teams da turma.
**
Requisitos:

    Neste aplicativo, você deve evoluir o cadastro (CRUD) de produto/serviço para armazenar as informações em banco de dados;
    Neste aplicativo, você deve associar cada produto/serviço a uma marca, de acordo com uma lista de marcas existente;
    Ao executar o aplicativo pela primeira vez, deve ser realizado uma carga inicial de dados tanto de produtos/serviços quanto também de marcas no banco de dados;
    Realize as adaptações nas telas de inclusão, alteração e detalhe para exibição/edição do campo Marca.

OBS.: De acordo com o tema da sua loja, a marca pode ser substituída por outra coisa, desde que seja possível associar produto/serviço com relacionamento um para muitos.

Requisitos técnicos:

    Crie a classe DbContext contendo os modelos, e não esqueça de realizar as configurações de string de conexão no seu aplicativo web;
    Implemente uma classe de serviço que utilize o DbContext para acessar o banco de dados da aplicação nas operações CRUD de produto/serviço (listagem, detalhe, inclusão, alteração/exclusão);
    Crie as classes de migração no seu aplicativo web, através da CLI do dotnet;
    Adicione um campo do tipo <select> nas páginas de inclusão e alteração para edição da Marca do produto/serviço;
    Adicione também a informação da marca (somente exibição) na página de detalhe;

**Neste Assessment, você deve evoluir o aplicativo web da sua loja de venda de produtos/serviços a partir da avaliação anterior. Lembre-se que o tema da loja deve seguir de acordo com a escolha do aluno na postagem do professor no Teams da turma.
**
Requisitos:

    Neste aplicativo, você deve criar as páginas web de cadastro (CRUD) de marca, armazenando as informações em banco de dados;
    Neste aplicativo, você deve criar páginas web de login, logout e cadastro (registro) na loja;
    Neste aplicativo, você deve permitir que usuários não logados acessem apenas as páginas web de consulta da loja (listagem e detalhe de produto/serviço);
    Neste aplicativo, você deve proteger o acesso às páginas web e links de manutenção do produto/serviço (inclusão, alteração e exclusão) e todas as páginas de marca (consulta, inclusão, alteração e exclusão), de modo que apenas usuários registrados acessem essas páginas.


