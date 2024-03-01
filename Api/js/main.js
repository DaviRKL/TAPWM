document.querySelectorAll('.card').forEach(function(card) {
    card.addEventListener('click', function() {
    
      var cardText = card.getAttribute('data-text');
      var cardId = card.getAttribute('data-id');
      var cardTitle = card.getAttribute('data-title');
      var cardImage = card.getAttribute('data-image');
      switch(cardId) {
          case "SOAP":
          cardText = "Essas APIs usam o Simple Object Access Protocol (Protocolo de Acesso a Objetos Simples). Cliente e servidor trocam mensagens usando XML.";
          break;
          case "RPC":
          cardText = "Essas APIs são conhecidas como Remote Procedure Calls (Chamadas de Procedimento Remoto). O cliente conclui uma função (ou um procedimento) no servidor e o servidor envia a saída de volta ao cliente.";
          break;
          case "WEB":
          cardText = "A API de WebSocket é outro desenvolvimento de API da Web moderno que usa objetos JSON para transmitir dados. Uma API WebSocket oferece suporte à comunicação bidirecional entre aplicativos cliente e o servidor. O servidor pode enviar mensagens de retorno de chamada a clientes conectados, tornando-o mais eficiente que a API REST.";
          break;
          case "REST":
          cardText="Essas são as APIs mais populares e flexíveis encontradas na Web atualmente. O cliente envia solicitações ao servidor como dados. O servidor usa essa entrada do cliente para iniciar funções internas e retorna os dados de saída ao cliente."
          break;
          case "POSTMAN":
          cardText = "Postman é um ambiente de desenvolvimento de API amplamente utilizado que simplifica o processo de construção, teste e documentação de APIs. Ele oferece suporte ao design, simulação, depuração e monitoramento de APIs, fornecendo aos desenvolvedores um conjunto de ferramentas abrangente para criar e manter APIs com mais eficiência. Postman também possui ferramentas de colaboração, permitindo que as equipes trabalhem perfeitamente em projetos de API. Além disso, ele oferece suporte a uma ampla variedade de formatos de API, incluindo REST, GraphQL e SOAP."
          break;
          case "SWAGGER":
          cardText = "Swagger Editor e Swaggerhub são ferramentas da estrutura Swagger que facilitam o design e a documentação da API. Swagger Editor é um editor de código aberto baseado em navegador para projetar e documentar APIs usando a especificação OpenAPI Ele fornece validação em tempo real e recursos de preenchimento automático, ajudando os desenvolvedores a criar especificações de API precisas e compatíveis. Swaggerhub, por outro lado, é uma plataforma colaborativa que oferece recursos avançados como controle de versão, controle de acesso e gerenciamento do ciclo de vida da API. Ambas as ferramentas suportam a geração de SDKs de cliente e stubs de servidor em várias linguagens, permitindo rápido desenvolvimento e teste de API.  "
          break;
          case "APPMASTER":
          cardText = "AppMaster é uma ferramenta no-code com uma função de design de API que ajuda os desenvolvedores a criar endpoints cruciais para aplicativos de servidor interagirem com interfaces de usuário e sistemas externos. A criação de um endpoint no AppMaster envolve navegar até a seção Endpoints e iniciar um novo endpoint do tipo REST API. Este endpoint segue os princípios RESTful e usa JSON para transmissão de dados."
          break;
          case "RAPID":
          cardText = "RapidAPI é uma plataforma de API abrangente que permite aos desenvolvedores descobrir, conectar e gerenciar APIs. Oferece um mercado onde os desenvolvedores podem acessar milhares de APIs de vários provedores, simplificando o processo de integração de APIs em aplicativos. RapidAPI também fornece ferramentas para projetar, construir e gerenciar APIs, incluindo recursos como documentação de API, controle de versão e controle de acesso. Suporta vários formatos de API, como REST, GraphQL e SOAP."
          break;
          

      }
    document.getElementById('modalBodyText').innerText = cardText;
    document.getElementById('modalTitleText').innerText = cardTitle;
    document.getElementById('modalImage').src = cardImage;
    });
  })