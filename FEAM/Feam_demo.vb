Imports System.Net ' acessar recursos da net
Imports System.IO ' acessar recursos do arquivo de configuração onde pse pretende guardar token e chave
Imports Newtonsoft.Json.Linq

'para fazer criptografia de chaves quando necessário
Imports System.Text

'se for trabalhar com a referencia JWT
' se for trabalhar com esta extenção muito utilizada pelos ensiders
Imports Newtonsoft.Json
Imports System.Configuration


Public Class Feamdemo

#Region "Construtor"

    ''' <summary>
    ''' Método construtor inicializar p pegar token e chave
    ''' </summary>
    Public Sub New()
        My.Settings.Reload()
    End Sub
#End Region

#Region "Nota: Formas possíveis para armazenar o token"

    '    //Armazenando o token com localstorage
    'localStorage.setItem('nomedotoken', token);

    '//Obtendo token com localstorage
    'var token = localStorage.getItem("nomedotoken");

    '//Armazenando o token com sessionStorage
    'sessionStorage.setItem('chave', 'valor');

    '//Obtendo token com sessionStorage
    'var data = sessionStorage.getItem('chave');
    'sessionStorage permite acessar um objeto tipo session Storage. A sessionStorage é similar ao localStorage, A única diferença 
    'é que enquanto os dados armazenados no localStorage não expiram, os dados no sessionstorage tem os seus dados limpos ao expirar a 
    'sessão da página
    '_______________________________________________________________________________________________

#End Region

#Region "propriedades da classe Login"
    'propriedades da classe
    ''' <summary>
    '''Pessoa código é o Código da Unidade do usuário, integer tamanho variavel, necessario para dar um GetToken
    ''' </summary>
    Public Property PessoaCodigo As Integer
    '_____________________________________________________________________________________________________________
    ''' <summary>
    ''' Se for uma empresa entre com o CNPJ, deve ser string com 14 digitos
    ''' </summary>
    Public Property PessoaCnpj As String
    '______________________________________________________________________________________________________________

    ''' <summary>
    ''' Entre com o CPF de usuario de 11 digitos sem pontuação
    ''' </summary>
    Public Property UsuarioCpf As String

    ''' <summary>
    ''' entre com a senha de login
    ''' </summary>
    Public Property Senha As String

#End Region

#Region "Propriedade da URL API Feam"

    Private URL_API As Uri

    ''' <summary>
    ''' Setar String  que representa base da API
    ''' </summary>
    ''' <param name="Url_da_Api_"></param>
    ''' <returns></returns>
    Public Property URL_da_api(ByVal Url_da_Api_ As String)
        Get
            Return CType(URL_API, Uri)
        End Get
        Set(value)
            URL_API = value
        End Set
    End Property

#End Region


#Region "Enumerações"

    ''' <summary>
    ''' Situações possível do Manifesto de {"situacaoManifestoCodigo"}
    '''  Salvo=1  MTR_Recebido=3  Cancelado=4  Em_Armazenamento_Temporario=9
    '''  Mostra qual a situação do manifesto atualmente: se foi apenas salvo ou recebido ou cancelado ou em armazenamento temporario
    ''' </summary>  
    Public Enum E_situacaoManifestoCodigo_Retorno As Integer

        Salvo = 1
        MTR_Recebido = 3
        Cancelado = 4
        Em_Armazenamento_Temporario = 9

    End Enum

    ''' <summary>
    ''' Retornar a Enumeração da descrição do codigo de acondicionamento
    ''' </summary>
    Public Enum E_codigoAcondicionamento_descricao As Integer
        Tambor = 1
        Caçamba_Aberta '= 2
        Caçamba_Fechada '= 3
        Bombona_Plástica '= 4
        Granel '= 5
        Caixa '= 6
        BigBag '= 7
        Fardo '= 8
        E08_Caixa_de_papelão
        E08_Balde
        E04_Tanque
        E08_Palete
        E08_Outros
        Saco_Plástico '14
        Caixa_RSS_perfurocortante = 31
        Cofre = 32
        IBC
        Recipiente_Pressurizado
        Tambor_metálico
        Cilindro_ou_outro_recipiente_pressurizado_para_acondicionamento_de_gases
        Contêiner_ou_Contentor
        IBC___contentor_intermediário_rígido_para_carga_a_granel = 38
        FIBC__contentor_intermediário_flexível_para_carga_a_granel = 39

    End Enum

    Public Enum E_Lista_de_Tecnologias_Descricao As Integer
        Reciclagem = 1
        Recuperação_energética = 3
        Coprocessamento = 4
        Incineração = 6
        Blendagem_para_Coprocessamento = 8
        Tratamento_Térmico = 9
        Compostagem = 10
        Tratamento_de_Efluentes = 11
        Uso_Agrícola = 12
        Autoclave = 13
        Gaseificação = 14
        Microondas = 15
        Rerrefino = 16
        Descontaminação_de_Lâmpadas = 17
        Aterro_Classe_I = 31
        Aterro_Classe_IIA_e_IIB = 32
        AterrodeReservação_RCC = 33
        Barragem_de_Rejeitos = 34
        Biometanização = 35
        Desmontagem_REE_e_Veículos = 36
        Disposição_em_Cava_de_Mineração = 37
        Pilha_de_Estéril = 38
        Pirólise = 39
        Triagem_e_Transbordo = 40
        Uso_Alimentação_Animal = 41
        Sistema_de_logística_reversa_formalmente_instituído = 42
        Utilização_de_biomassa_em_caldeira = 43
        Reutilização = 44
        Remediação_ex_situ = 50
        Uso_em_vias_para_pavimentação_ou_manutenção = 51

    End Enum

    Public Enum E_retornaListaResiduo_Descricao As Integer

        'ESTRUTURA DE RETORNO

        '"tpre1Codigo" 4,
        '"tpre2Codigo": 15,
        '"tpre3Codigo": 93,
        '"tpre1Descricao": "Resíduos da indústria do couro e produtos de couro e da indústria têxtil", AQUI É REFERENTE AO CAPITULO
        '"tpre2Descricao": "Resíduos das industrias do couro e produtos de couro ", REF ao SUBCAPITULO DO CAPITULO
        '"tpre3Descricao": "Outros resíduos não anteriormente especificados", Apenas complementa a info
        '"tpre1Numero": "04",  AQUI É O CAPITULO
        '"tpre2Numero": "0401",  AQUI É O SUBCAPITULO
        '"tpre3Numero": "040199", AQUI É COD RESIDUO
        '"retornoCodigo": null,
        '"retorno": null

        _040199 = 40199
        _010309 = 10309
        _110501 = 110501
        _110502 = 110502 '110502(*)
        _110503 = 110503 '110503(*)
        _110504 = 110504 '110504(*)
        _110599 = 110599
        _130201 = 130201
        _130299 = 130299 '130299(*)
        _060699 = 60699
        _170502 = 170502 '170502(*)
        _160605 = 160605
        _020110 = 20110
        _040110 = 40110
        _010306 = 10306
        _101401 = 101401 '101401(*)
        _010308 = 10308 '010308
        _010408 = 10408
        _020301 = 20301
        _010410 = 10410
        _010412 = 10412
        _050702 = 50702
        _010413 = 10413
        _060103 = 60103 '060103(*)
        _060104 = 60104 '060104(*)
        _60105 = 60105 '060105(*)
        _060106 = 60106 '060106(*)
        _060199 = 60199
        _060201 = 60201 '060201(*)
        _010507 = 10507
        _130402 = 130402 '130402(*)
        _160602 = 160602 '160602(*)
        _160120 = 160120
        _010101 = 10101
        _010102 = 10102
        _010304 = 10304 '010304(*)
        _010305 = 10305 '010305(*)
        _010307 = 10307 '010307(*)
        _010399 = 10399
        _010407 = 10407 '010407(*)
        _010409 = 10409
        _010499 = 10499
        _010504 = 10504
        _010505 = 10505 '010505(*)
        _010506 = 10506 '010506(*)
        _191208 = 191208
        _010599 = 10599
        _020101 = 20101
        _020102 = 20102
        _020103 = 20103
        _020104 = 20104
        _020106 = 20106
        _020107 = 20107
        _020108 = 20108 '020108(*)
        _020199 = 20199
        _020201 = 20201
        _020202 = 20202
        _020203 = 20203
        _020204 = 20204
        _020299 = 20299
        _020302 = 20302
        _020303 = 20303
        _020304 = 20304
        _020305 = 20305
        _020399 = 20399
        _020403 = 20403
        _020404 = 20404
        _020405 = 20405
        _020499 = 20499
        _020501 = 20501
        _020502 = 20502
        _020599 = 20599
        _020601 = 20601
        _020602 = 20602
        _020603 = 20603
        _020699 = 20699
        _020701 = 20701
        _020702 = 20702
        _020703 = 20703
        _020704 = 20704
        _020705 = 20705
        _020799 = 20799
        _030101 = 30101
        _030104 = 30104 '030104(*)
        _030199 = 30199
        _030201 = 30201 '030201(*)
        _030202 = 30202 '030202(*)
        _030203 = 30203 '030203(*)
        _030204 = 30204 '030204(*)
        _030205 = 30205 '030205(*)
        _030206 = 30206 '030206(*)
        _030207 = 30207 '030207(*)
        _191205 = 191205
        _030208 = 30208 '030208(*)
        _030299 = 30299
        _030301 = 30301
        _030302 = 30302
        _030305 = 30305
        _030307 = 30307
        _030308 = 30308
        _030309 = 30309
        _030310 = 30310
        _030311 = 30311
        _030399 = 30399
        _040101 = 40101
        _040102 = 40102
        _040103 = 40103 '040103(*)
        _040104 = 40104
        _040105 = 40105
        _040106 = 40106
        _040107 = 40107
        _040108 = 40108
        _040109 = 40109
        _040111 = 40111 '040111(*)
        '_040199 = 40199 'repetido p teste na mtr
        _040209 = 40209
        _040210 = 40210
        _040214 = 40214 '040214(*)
        _040216 = 40216 '040216(*)
        _040219 = 40219 '040219(*)
        _040221 = 40221
        _040222 = 40222
        _040299 = 40299
        _050102 = 50102 '050102(*)
        _050103 = 50103 '050103(*)
        _050104 = 50104 '050104(*)
        _050105 = 50105 '050105(*)
        _010508 = 10508
        _050106 = 50106 '050106(*)
        _050107 = 50107 '050107(*)
        _050108 = 50108 '050108(*)
        _050109 = 50109 '050109(*)
        _050111 = 50111 '050111(*)
        _050112 = 50112 '050112(*)
        _050113 = 50113
        _050114 = 50114
        _050115 = 50115 '050115(*)
        _050116 = 50116
        _050117 = 50117
        _050118 = 50118 '050118(*)
        _050199 = 50199
        _050601 = 50601 '050601(*)
        _050603 = 50603 '050603(*)
        _050604 = 50604
        _050605 = 50605 '050605(*)
        _050606 = 50606 '050606(*)
        _050607 = 50607 '050607(*)
        _050608 = 50608 '050608(*)
        _050699 = 50699
        _050701 = 50701 '050701(*)
        _050799 = 50799
        _060101 = 60101 '060101(*)
        _060102 = 60102 '060102(*)
        _060203 = 60203 '060203(*)
        _060204 = 60204 '060204(*)
        _060205 = 60205 '060205(*)
        _060299 = 60299 '060299(*)
        _060313 = 60313 '060313(*)
        _060315 = 60315 '060315(*)
        _060399 = 60399
        _060403 = 60403 '060403(*)
        _020109 = 20109
        _060405 = 60405 '060405(*)
        _060499 = 60499
        _060502 = 60502 '060502(*)
        _030105 = 30105
        _040215 = 40215
        _040217 = 40217
        _040220 = 40220
        _060602 = 60602 '060602(*)
        _050110 = 50110
        _060316 = 60316
        _060503 = 60503
        _060603 = 60603
        _070217 = 70217
        _070312 = 70312
        _070412 = 70412
        _070512 = 70512
        _070514 = 70514
        _070612 = 70612
        _070712 = 70712
        _080112 = 80112
        _080114 = 80114
        _080116 = 80116
        _080118 = 80118
        _080120 = 80120
        _080313 = 80313
        _080315 = 80315
        _080318 = 80318
        _080410 = 80410
        _080412 = 80412
        _060701 = 60701 '060701(*)
        _080414 = 80414
        _080416 = 80416
        _060311 = 60311 '060311(*)
        _060314 = 60314 '060314(*)
        _070215 = 70215
        _100208 = 100208
        _100212 = 100212
        _100214 = 100214
        _100318 = 100318
        _100320 = 100320
        _100322 = 100322
        _100324 = 100324
        _100326 = 100326
        _100328 = 100328
        _100330 = 100330
        _100410 = 100410
        _100509 = 100509
        _100511 = 100511
        _100610 = 100610
        _100708 = 100708
        _100811 = 100811
        _100813 = 100813
        _100816 = 100816
        _100818 = 100818
        _100820 = 100820
        _100906 = 100906
        _100908 = 100908
        _100910 = 100910
        _100912 = 100912
        _100914 = 100914
        _100916 = 100916
        _101006 = 101006
        _101008 = 101008
        _101010 = 101010
        _101012 = 101012
        _101014 = 101014
        _101016 = 101016
        _101110 = 101110
        _101112 = 101112
        _101114 = 101114
        _101116 = 101116
        _101118 = 101118
        _101120 = 101120
        _101210 = 101210
        _101212 = 101212
        _101306 = 101306
        _101310 = 101310
        _101311 = 101311
        _101313 = 101313
        _110110 = 110110
        _110112 = 110112
        _110114 = 110114
        _110206 = 110206
        _120302 = 120302 '*
        _150111 = 150111 '*
        _150202 = 150202 '*
        _150203 = 150203
        _160104 = 160104
        _160112 = 160112
        _160115 = 160115
        _160121 = 160121 '*
        _160210 = 160210 '*
        _160213 = 160213 '*
        _160214 = 160214
        _160304 = 160304
        _160306 = 160306
        _160505 = 160505
        _160509 = 160509
        _090113 = 90113 '*
        _100101 = 100101
        _100115 = 100115
        _100117 = 100117
        _100119 = 100119
        _100121 = 100121
        _100123 = 100123
        _160801 = 160801
        _160804 = 160804
        _161002 = 161002
        _161004 = 161004
        _161102 = 161102
        _161104 = 161104
        _161106 = 161106
        _170107 = 170107
        _170302 = 170302
        _170411 = 170411
        _170504 = 170504
        _170506 = 170506
        _170508 = 170508
        _170604 = 170604
        _170802 = 170802
        _170904 = 170904
        _200136 = 200136
        _080501 = 80501 '*
        _090101 = 90101 '*
        _090102 = 90102 '*
        _090103 = 90103 '*
        _090104 = 90104 '*
        _090105 = 90105 '*
        _090106 = 90106 '*
        _090107 = 90107
        _090108 = 90108
        _090199 = 90199
        _100102 = 100102
        _100103 = 100103
        _100104 = 100104 '*
        _100105 = 100105
        _100107 = 100107
        _100109 = 100109 '*
        _100113 = 100113 '*
        _100114 = 100114 '*
        _100116 = 100116 '*
        _100118 = 100118 '*
        _100120 = 100120 '*
        _100122 = 100122 '*
        _100124 = 100124
        _100125 = 100125
        _100126 = 100126
        _100199 = 100199
        _190112 = 190112
        _190114 = 190114
        _190116 = 190116
        _190118 = 190118
        _190206 = 190206
        _190210 = 190210
        _190305 = 190305
        _190307 = 190307
        _190703 = 190703
        _190810 = 190810 '*
        _190812 = 190812
        _190814 = 190814
        _191004 = 191004
        _191006 = 191006
        _191106 = 191106
        _191207 = 191207
        _191213 = 191213
        _191302 = 191302
        _191304 = 191304
        _191306 = 191306
        _191308 = 191308
        _200128 = 200128
        _200130 = 200130
        _200133 = 200133 '*
        _200134 = 200134
        _200135 = 200135 '*
        _200138 = 200138
        _130502 = 130502 '*
        _100809 = 100809
        _130306 = 130306 '*
        _130307 = 130307 '*
        _130308 = 130308 '*
        _191204 = 191204
        _130309 = 130309 '*
        _130310 = 130310 '*
        _130401 = 130401 '*
        _130403 = 130403 '*
        _130501 = 130501 '*
        _130503 = 130503 '*
        _130506 = 130506 '*
        _130507 = 130507 '*
        _130508 = 130508 '*
        _130701 = 130701 '*
        _130702 = 130702 '*
        _130703 = 130703 '*
        _130801 = 130801 '*
        _130802 = 130802 '*
        _130899 = 130899 '*
        _140601 = 140601 '*
        _140602 = 140602 '*
        _140603 = 140603 '*
        _140604 = 140604 '*
        _140605 = 140605 '*
        _150101 = 150101
        _150102 = 150102
        _150103 = 150103
        _150104 = 150104
        _150105 = 150105
        _150106 = 150106
        _150107 = 150107
        _150109 = 150109
        _150110 = 150110 '*
        _160103 = 160103 '*
        _160106 = 160106 '*
        _160108 = 160108 '*
        _160109 = 160109 '*
        _160107 = 160107 '*
        _160110 = 160110 '*
        _160111 = 160111 '*
        _160113 = 160113 '*
        _160114 = 160114 '*
        _160116 = 160116
        _160117 = 160117
        _160118 = 160118
        _160119 = 160119
        _160122 = 160122
        _160123 = 160123
        _160124 = 160124
        _160125 = 160125
        _160126 = 160126
        _160127 = 160127
        _160128 = 160128
        _160129 = 160129
        _160199 = 160199
        _160209 = 160209 '*
        _160211 = 160211 '*
        _160212 = 160212 '*
        _160215 = 160215 '*
        _160303 = 160303 '*
        _160305 = 160305 '*
        _160401 = 160401 '*
        _160402 = 160402 '*
        _160403 = 160403 '*
        _160405 = 160405 '*
        _160406 = 160406 '*
        _160499 = 160499 '*
        _160504 = 160504 '*
        _160506 = 160506 '*
        _160507 = 160507 '*
        _160508 = 160508 '*
        _160601 = 160601 '*
        _160603 = 160603 '*
        _160606 = 160606 '*
        _160708 = 160708 '*
        _160709 = 160709 '*
        _160799 = 160799
        _160802 = 160802 '*
        _160803 = 160803
        _120113 = 120113
        _160805 = 160805 '*
        _160806 = 160806 '*
        _190606 = 190606
        _160807 = 160807 '*
        _160808 = 160808 '*
        _160899 = 160899 '*
        _160901 = 160901 '*
        _160902 = 160902 '*
        _160903 = 160903 '*
        _160904 = 160904 '*
        _161001 = 161001 '*
        _161003 = 161003 '*
        _161101 = 161101 '*
        _161103 = 161103 '*
        _161105 = 161105 '*
        _170101 = 170101
        _170102 = 170102
        _170103 = 170103
        _170106 = 170106 '*
        _170201 = 170201 '*
        _170202 = 170202
        _170203 = 170203
        _170204 = 170204 '*
        _170301 = 170301 '*
        _170303 = 170303 '*
        _170401 = 170401
        _170402 = 170402
        _170403 = 170403
        _170404 = 170404
        _170405 = 170405
        _170406 = 170406
        _170407 = 170407
        _170409 = 170409 '*
        _170410 = 170410 '*
        _170412 = 170412
        _170413 = 170413
        _170503 = 170503 '*
        _170505 = 170505 '*
        _170507 = 170507 '*
        _170509 = 170509 '*
        _170601 = 170601 '*
        _170603 = 170603 '*
        _170605 = 170605 '*
        _170801 = 170801 '*
        _170901 = 170901 '*
        _170902 = 170902 '*
        _170903 = 170903 '*
        _190306 = 190306 '*
        _190808 = 190808 '*
        _190102 = 190102
        _190105 = 190105 '*
        _190106 = 190106 '*
        _190107 = 190107 '*
        _190110 = 190110 '*
        _190111 = 190111 '*
        _190113 = 190113 '*
        _190115 = 190115 '*
        _190117 = 190117 '*
        _190119 = 190119
        _190199 = 190199
        _190203 = 190203
        _190204 = 190204 '*
        _190205 = 190205 '*
        _190207 = 190207 '*
        _190208 = 190208 '*
        _190209 = 190209 '*
        _190211 = 190211 '*
        _190299 = 190299
        _190304 = 190304 '*
        _190401 = 190401
        _190402 = 190402 '*
        _190403 = 190403 '*
        _190404 = 190404
        _190501 = 190501
        _190502 = 190502
        _190503 = 190503
        _190599 = 190599
        _190603 = 190603
        _190604 = 190604
        _190605 = 190605
        _200137 = 200137 '*
        _190699 = 190699
        _190702 = 190702 '*
        _190801 = 190801
        _190802 = 190802
        _190805 = 190805
        _190806 = 190806 '*
        _190807 = 190807 '*
        _190809 = 190809
        _190811 = 190811 '*
        _190813 = 190813 '*
        _190899 = 190899
        _190901 = 190901
        _190902 = 190902
        _190903 = 190903
        _190904 = 190904
        _190905 = 190905
        _190906 = 190906
        _190999 = 190999
        _191001 = 191001
        _191002 = 191002
        _191003 = 191003 '*
        _191005 = 191005 '*
        _191101 = 191101 '*
        _191102 = 191102 '*
        _191103 = 191103 '*
        _191104 = 191104 '*
        _191105 = 191105 '*
        _191107 = 191107 '*
        _191199 = 191199
        _191201 = 191201
        _191202 = 191202
        _191203 = 191203
        _191206 = 191206 '*
        _191209 = 191209
        _191210 = 191210
        _191211 = 191211
        _191212 = 191212 '*
        _191301 = 191301 '*
        _191303 = 191303 '*
        _191307 = 191307 '*
        _200101 = 200101
        _200102 = 200102 '*
        _200108 = 200108
        _200110 = 200110
        _200111 = 200111
        _200113 = 200113 '*
        _200114 = 200114 '*
        _200115 = 200115 '*
        _200117 = 200117 '*
        _200119 = 200119 '*
        _200121 = 200121 '*
        _200123 = 200123 '*
        _200125 = 200125
        _200126 = 200126 '*
        _200127 = 200127 '*
        _200129 = 200129 '*
        _200139 = 200139
        _200140 = 200140
        _200141 = 200141
        _200199 = 200199
        _200201 = 200201
        _200202 = 200202
        _200203 = 200203
        _200301 = 200301
        _200302 = 200302
        _200303 = 200303
        _200304 = 200304
        _200306 = 200306
        _200399 = 200399
        _060904 = 60904
        _061302 = 61302 '*
        _130301 = 130301 '*
        _060702 = 60702 '*
        _060703 = 60703 '*
        _060704 = 60704 '*
        _060705 = 60705 '*
        _060799 = 60799
        _060902 = 60902
        _060903 = 60903 '*
        _060999 = 60999
        _061002 = 61002 '*
        _061099 = 61099
        _061101 = 61101
        _061102 = 61102 '*
        _061103 = 61103 '*
        _061104 = 61104 '*
        _061199 = 61199
        _061301 = 61301 '*
        _061303 = 61303
        _061304 = 61304 '*
        _061305 = 61305 '*
        _061399 = 61399
        _070107 = 70107 '*
        _070101 = 70101 '*
        _070103 = 70103 '*
        _070104 = 70104 '*
        _070108 = 70108 '*
        _070109 = 70109 '*
        _070110 = 70110 '*
        _070111 = 70111 '*
        _070199 = 70199
        _070201 = 70201 '*
        _070203 = 70203 '*
        _070204 = 70204 '*
        _070207 = 70207 '*
        _070208 = 70208 '*
        _070209 = 70209 '*
        _070210 = 70210 '*
        _070211 = 70211 '*
        _070213 = 70213 '*
        _070214 = 70214 '*
        _070216 = 70216 '*
        _070112 = 70112
        _070212 = 70212
        _060404 = 60404 '*
        _070299 = 70299
        _070301 = 70301 '*
        _070303 = 70303 '*
        _070304 = 70304 '*
        _070307 = 70307 '*
        _070308 = 70308 '*
        _070309 = 70309 '*
        _070310 = 70310 '*
        _070311 = 70311 '*
        _070399 = 70399
        _070401 = 70401 '*
        _070403 = 70403 '*
        _070404 = 70404 '*
        _070407 = 70407 '*
        _070408 = 70408 '*
        _070409 = 70409 '*
        _070410 = 70410 '*
        _070411 = 70411 '*
        _070413 = 70413 '*
        _070499 = 70499
        _070501 = 70501 '*
        _070503 = 70503 '*
        _070504 = 70504 '*
        _070507 = 70507 '*
        _070508 = 70508 '*
        _070509 = 70509 '*
        _070510 = 70510 '*
        _070511 = 70511 '*
        _070513 = 70513 '*
        _070599 = 70599 '*
        _070505 = 70505 '*
        _070506 = 70506 '*
        _070699 = 70699
        _070601 = 70601 '*
        _070603 = 70603 '*
        _070604 = 70604 '*
        _070607 = 70607 '*
        _070608 = 70608 '*
        _070609 = 70609 '*
        _070610 = 70610 '*
        _070611 = 70611 '*
        '_191209 = 191209
        _070701 = 70701 '*
        _070703 = 70703 '*
        _070704 = 70704 '*
        _070707 = 70707 '*
        _070708 = 70708 '*
        _070709 = 70709 '*
        _070710 = 70710 '*
        _070711 = 70711 '*
        _080111 = 80111 '*
        _080113 = 80113 '*
        _080115 = 80115 '*
        _080119 = 80119 '*
        _080121 = 80121 '*
        _080122 = 80122 '*
        _080199 = 80199
        _080117 = 80117 '*
        _080201 = 80201
        _080202 = 80202
        _080203 = 80203
        _080204 = 80204 '*
        _080299 = 80299
        _080307 = 80307
        _080308 = 80308
        _080312 = 80312 '*
        _080314 = 80314 '*
        _080316 = 80316
        _080317 = 80317 '*
        _080319 = 80319 '*
        _080399 = 80399
        _080409 = 80409 '*
        _080411 = 80411 '*
        _080413 = 80413 '*
        _080415 = 80415 '*
        _080417 = 80417 '*
        _080499 = 80499
        _100201 = 100201
        _100202 = 100202
        _100203 = 100203 '*
        _100207 = 100207 '*
        _100210 = 100210
        _100211 = 100211 '*
        _100213 = 100213 '*
        _100215 = 100215
        _100216 = 100216 '*
        _100299 = 100299
        _100302 = 100302
        _100303 = 100303 '*
        _100304 = 100304 '*
        _100305 = 100305 '*
        _100306 = 100306
        _100308 = 100308 '*
        _100309 = 100309 '*
        _100315 = 100315 '*
        _100317 = 100317 '*
        _100319 = 100319 '*
        _100321 = 100321 '*
        _100323 = 100323 '*
        _100325 = 100325 '*
        _100327 = 100327 '*
        _100329 = 100329 '*
        _100399 = 100399
        _100401 = 100401 '*
        _100402 = 100402 '*
        _100403 = 100403 '*
        _100404 = 100404 '*
        _100405 = 100405 '*
        _100407 = 100407 '*
        _100409 = 100409 '*
        _100316 = 100316
        _100499 = 100499
        _100406 = 100406 '*
        _100501 = 100501
        _100502 = 100502 '*
        _100503 = 100503 '*
        _100504 = 100504
        _100505 = 100505 '*
        _100506 = 100506 '*
        _100507 = 100507 '*
        _100508 = 100508 '*
        _100510 = 100510 '*
        _100599 = 100599
        _100601 = 100601
        _100602 = 100602
        _100603 = 100603 '*
        _100604 = 100604
        _100606 = 100606 '*
        _100607 = 100607 '*
        _100609 = 100609 '*
        _100699 = 100699
        _100701 = 100701
        _100702 = 100702
        _100703 = 100703
        _100704 = 100704
        _100705 = 100705
        _100707 = 100707 '*
        _100799 = 100799
        _100804 = 100804
        _100808 = 100808 '*
        _100810 = 100810 '*
        _100812 = 100812 '*
        _100814 = 100814
        _100815 = 100815 '*
        _100817 = 100817 '*
        _100819 = 100819 '*
        _100899 = 100899 '*
        _100903 = 100903
        _100905 = 100905 '*
        _100907 = 100907 '*
        _100909 = 100909 '*
        _100911 = 100911 '*
        _100913 = 100913 '*
        _100915 = 100915 '*
        _100999 = 100999
        _101003 = 101003
        _101005 = 101005 '*
        _101007 = 101007 '*
        _101009 = 101009 '*
        _101011 = 101011 '*
        _101013 = 101013 '*
        _101015 = 101015 '*
        _120112 = 120112 '*
        _101099 = 101099
        _101103 = 101103
        _101105 = 101105
        _101109 = 101109 '*
        _101111 = 101111 '*
        _101113 = 101113 '*
        _101115 = 101115 '*
        _101117 = 101117 '*
        _101119 = 101119 '*
        _101199 = 101199
        _101201 = 101201
        _101203 = 101203
        _101205 = 101205
        _101206 = 101206
        _101208 = 101208
        _101209 = 101209 '*
        _101211 = 101211 '*
        _101213 = 101213
        _101299 = 101299
        _101301 = 101301
        _101304 = 101304
        _101307 = 101307
        _101309 = 101309 '*
        _101312 = 101312 '*
        _101314 = 101314
        _101399 = 101399
        _110104 = 110104 '*
        _110105 = 110105 '*
        _110106 = 110106 '*
        _110107 = 110107 '*
        _110108 = 110108 '*
        _110109 = 110109 '*
        _110111 = 110111 '*
        _110113 = 110113 '*
        _110115 = 110115 '*
        _110116 = 110116 '*
        _110198 = 110198 '*
        _110199 = 110199
        _110202 = 110202 '*
        _110203 = 110203
        _110205 = 110205 '*
        _110207 = 110207 '*
        _110299 = 110299
        _110301 = 110301 '*
        _110302 = 110302 '*
        _110303 = 110303 '*
        _120101 = 120101
        _120102 = 120102
        _120103 = 120103
        _120104 = 120104
        _120105 = 120105
        _120106 = 120106 '*
        _120107 = 120107 '*
        _120108 = 120108 '*
        _120109 = 120109 '*
        _120110 = 120110 '*
        _120114 = 120114 '*
        _120116 = 120116 '*
        _120118 = 120118 '*
        _120119 = 120119 '*
        _120120 = 120120 '*
        _120199 = 120199
        _130101 = 130101 '*
        _130104 = 130104 '*
        _130105 = 130105 '*
        _130109 = 130109 '*
        _130110 = 130110 '*
        _130111 = 130111 '*
        _130112 = 130112 '*
        _130113 = 130113 '*
        _120115 = 120115
        _120117 = 120117
        _120121 = 120121
        _120301 = 120301 '*
        _010103 = 10103
        _010104 = 10104
        _010105 = 10105
        _200132 = 200132
        _200131 = 200131
        _180401 = 180401 '*
        _180301 = 180301 '*
        _180205 = 180205 '*
        _180204 = 180204 '*
        _180203 = 180203 '*
        _180202 = 180202 '*
        '_GrupoB = Grupo_B
        _180201 = 180201 '*
        _180115 = 180115 '*
        _180114 = 180114 '*
        _180113 = 180113 '*
        _180112 = 180112 '*
        _180111 = 180111 '*
        _180110 = 180110 '*
        _180109 = 180109 '*
        _180108 = 180108 '*
        _180107 = 180107 '*
        _180106 = 180106 '*
        _180105 = 180105 '*
        _180104 = 180104 '*
        _180103 = 180103 '*
        _180102 = 180102 '*
        _180101 = 180101 '*
        ' _ClasseA = Classe_A
        ' _SubgrupoA1 = Subgrupo_A1
        ' _ClasseB = Classe_B
        ' _ClasseC = Classe_C
        _160216 = 160216
        _160604 = 160604
        _160130 = 160130
        ' _ClasseD = ClasseD '*
        _150112 = 150112 '*
        '_GrupoA = Grupo_A
        '  _GrupoC = Grupo_C
        ' _GrupoE = Grupo_E
        '  _GrupoD = Grupo_D
        '  _SubgrupoA2 = Subgrupo_A2
        '  _SubgrupoA4 = Subgrupo_A4
        ' _SubgrupoA5 = Subgrupo_A5
        '  _SubgrupoA3 = Subgrupo_A3




    End Enum


    ''' <summary>
    ''' Ao mandar a requisição o servidor pode retornar as seguintes respostas: Sucesso = 0,  Codigo_de_Barras_Invalido = 901, Manifesto_Invalido_ou_não_encontrado
    ''' Erro_Não_Identificado
    ''' 
    ''' </summary>
    Public Enum E_retornaManifesto_Retorno As Integer
        Sucesso = 0
        Codigo_de_Barras_Invalido = 901
        Manifesto_Invalido_ou_não_encontrado
        Erro_Não_Identificado

    End Enum


#End Region

#Region "Propriedades de Retorno da MTR"


    Private _manifestoCodigo As String
    ''' <summary>
    ''' retornar o manifesto com 10 dig
    ''' </summary>
    ''' <returns></returns>
    <Newtonsoft.Json.JsonProperty()>
    Public Property manifestoCodigo
        Get
            Return _manifestoCodigo
        End Get
        Set(value)
            _manifestoCodigo = value
        End Set
    End Property

    Private _seuCodigoReferencia As Integer
    Public Property seuCodigoReferencia

        Get
            Return CInt(_seuCodigoReferencia)
        End Get
        Set(value)
            _seuCodigoReferencia = value
        End Set
    End Property


    Private _retornoCodigo As Integer
    ''' <summary>
    ''' Se retornar 0 é porque a requisição teve sucesso,
    ''' 901 Código de Barras Inválido,
    ''' 902 Manifesto Inválido ou não encontrado,
    ''' 903 Erro Não Identificado
    ''' </summary>
    ''' <returns></returns>
    Public Property retornoCodigo
        Get

            Select Case _retornoCodigo
                Case E_retornaManifesto_Retorno.Sucesso
                    MsgBox("Servidor retornou 'Sucesso'", vbInformation, "Análise")
                Case E_retornaManifesto_Retorno.Manifesto_Invalido_ou_não_encontrado
                    MsgBox("Servidor retornou 'Manifesto_Invalido_ou_não_encontrado'", vbInformation, "Análise")
                Case E_retornaManifesto_Retorno.Codigo_de_Barras_Invalido
                    MsgBox("Servidor retornou 'Codigo_de_Barras_Invalido'", vbInformation, "Análise")
                Case E_retornaManifesto_Retorno.Erro_Não_Identificado
                    MsgBox("Servidor retornou 'Erro_Não_Identificado'", vbInformation, "Análise")
            End Select

            Return _retornoCodigo
        End Get
        Set(value)
            _retornoCodigo = value
        End Set
    End Property

    Private _cnpGerador As String
    Public Property cnpGerador
        Get
            Return _cnpGerador
        End Get
        Set(value)
            _cnpGerador = value
        End Set
    End Property

    Private _codUnidadeGerador As String
    Public Property codUnidadeGerador
        Get
            Return _codUnidadeGerador
        End Get
        Set(value)
            _codUnidadeGerador = value
        End Set
    End Property

    Private _cnpTransportador As String
    Public Property cnpTransportador
        Get
            Return _cnpTransportador
        End Get
        Set(value)
            _cnpTransportador = value
        End Set
    End Property

    Private _codUnidadeTransportador As String
    Public Property codUnidadeTransportador
        Get
            Return _codUnidadeTransportador
        End Get
        Set(value)
            _codUnidadeTransportador = value
        End Set
    End Property

    Private _cnpDestinador As String
    Public Property cnpDestinador
        Get
            Return _cnpDestinador
        End Get
        Set(value)
            _cnpDestinador = value
        End Set
    End Property

    Private _codUnidadeDestinador As String
    Public Property codUnidadeDestinador
        Get
            Return _codUnidadeDestinador
        End Get
        Set(value)
            _codUnidadeDestinador = value
        End Set
    End Property

    Private _cnpArmazenador As String
    Public Property cnpArmazenador
        Get
            If _cnpArmazenador Is Nothing Then
                _cnpArmazenador = "NULO"
            End If

            Return _cnpArmazenador
        End Get
        Set(value)
            _cnpArmazenador = value
        End Set
    End Property

    Private _codUnidadeArmazenador As String
    Public Property codUnidadeArmazenador
        Get
            If _codUnidadeArmazenador Is Nothing Then
                _codUnidadeArmazenador = "NULO"
            End If

            Return _codUnidadeArmazenador

        End Get
        Set(value)
            _codUnidadeArmazenador = value
        End Set
    End Property


    Private _situacaoManifestoCodigo As String
    ''' <summary>
    ''' Exibe a situação atual do estado do manifesto. Temos 4 possíveis situações de estado, a saber:
    ''' Salvo,
    ''' Recebido,
    ''' Cancelado,
    ''' Em armazenamento temporario.
    ''' </summary>
    ''' <returns></returns>
    Public Property situacaoManifestoCodigo
        Get
            Select Case _situacaoManifestoCodigo

                Case E_situacaoManifestoCodigo_Retorno.Salvo
                    _situacaoManifestoCodigo = "Salvo"

                Case E_situacaoManifestoCodigo_Retorno.MTR_Recebido
                    _situacaoManifestoCodigo = "Recebido"

                Case E_situacaoManifestoCodigo_Retorno.Cancelado
                    _situacaoManifestoCodigo = "Cancelado"

                Case E_situacaoManifestoCodigo_Retorno.Em_Armazenamento_Temporario

                    _situacaoManifestoCodigo = "Em_Armazenamento_Temporario"

            End Select

            Return _situacaoManifestoCodigo
        End Get
        Set(value)
            _situacaoManifestoCodigo = value
        End Set
    End Property


    Private _manifData As String
    Public Property manifData
        Get
            Return _manifData
        End Get
        Set(value)
            _manifData = value
        End Set
    End Property


    Private _manifDataExpedicao As String
    Public Property manifDataExpedicao
        Get
            Return _manifDataExpedicao
        End Get
        Set(value)
            _manifDataExpedicao = value
        End Set
    End Property

    Private _manifObservacao As String
    ''' <summary>
    ''' Observações do Gerador
    ''' </summary>
    ''' <returns></returns>
    Public Property manifObservacao
        Get
            If _manifObservacao = Nothing Then
                _manifObservacao = "NULO"
            End If

            Return UCase(_manifObservacao)

        End Get
        Set(value)
            _manifObservacao = value
        End Set
    End Property

    Private _manifDataRecebimento As String
    Public Property manifDataRecebimento
        Get
            If _manifDataRecebimento = Nothing Then
                _manifDataRecebimento = "NULO"
            End If

            Return UCase(_manifDataRecebimento)
        End Get
        Set(value)
            _manifDataRecebimento = value
        End Set
    End Property

    Private _manifGeradorNomeResponsavel As String
    Public Property manifGeradorNomeResponsavel
        Get

            Return UCase(_manifGeradorNomeResponsavel)

        End Get
        Set(value)
            _manifGeradorNomeResponsavel = value
        End Set
    End Property

    Private _manifGeradorCargoResponsavel As String
    Public Property manifGeradorCargoResponsavel
        Get
            Return UCase(_manifGeradorCargoResponsavel)
        End Get
        Set(value)
            _manifGeradorCargoResponsavel = value
        End Set
    End Property

    Private _manifTransportadorNomeMotorista As String
    Public Property manifTransportadorNomeMotorista
        Get
            If _manifTransportadorNomeMotorista Is Nothing Then
                _manifTransportadorNomeMotorista = "NULO"
            End If

            Return UCase(_manifTransportadorNomeMotorista)

        End Get
        Set(value)
            _manifTransportadorNomeMotorista = value
        End Set
    End Property

    Private _manifTransportadorPlacaVeiculo As String
    Public Property manifTransportadorPlacaVeiculo
        Get
            If _manifTransportadorPlacaVeiculo Is Nothing Then
                _manifTransportadorPlacaVeiculo = "NULO"
            End If

            Return UCase(_manifTransportadorPlacaVeiculo)
        End Get
        Set(value)
            _manifTransportadorPlacaVeiculo = value
        End Set
    End Property


    Private _manifTransportadorDataExpedicao As String
    ''' <summary>
    ''' Data em quea transportadora expediu o Manifesto
    ''' </summary>
    ''' <returns></returns>
    Public Property manifTransportadorDataExpedicao
        Get
            If _manifTransportadorDataExpedicao Is Nothing Then
                _manifTransportadorDataExpedicao = "NULO"
            End If

            Return _manifTransportadorDataExpedicao

        End Get

        Set(value)
            _manifTransportadorDataExpedicao = value
        End Set
    End Property

    Private _retorno As String
    ''' <summary>
    ''' Se o retorno foi com : Sucesso, Não autorizado
    ''' </summary>
    ''' <returns></returns>
    Public Property retorno
        Get
            Return UCase(_retorno)
        End Get

        Set(value)
            _retorno = value
        End Set
    End Property

    'Private _itemManifestoJSONs As String = "{""itemManifestoJSONs"":[{""codigoSequencial:""" & codigoSequencial & "," &
    '                                                           """justificativa:""" & justificativa & "," &
    '                                                           """codigoInterno:" & codigoInterno & "," &
    '                                                           """quantidade:" & quantidade & "," &
    '                                                           """quantidadeRecebida:" & quantidadeRecebida & "," &
    '                                                           """residuo:" & residuo & "," &
    '                                                           """codigoAcondicionamento:" & codigoAcondicionamento & "," &
    '                                                           """codigoClasse:" & codigoClasse & "," &
    '                                                           """codigoTecnologia:" & codigoTecnologia & "," &
    '                                                           """codigoTipoEstado:" & codigoTipoEstado & "," &
    '                                                           """codigoUnidade:" & codigoUnidade & "," &
    '                                                           """manifestoItemObservacao:" & manifestoItemObservacao & "," &
    '                                                           """manifestoItemCodInterno:" & manifestoItemCodInterno & "," &
    '                                                           """manifestoItemCodInternoDestinador:" & manifestoItemCodInternoDestinador & "," &
    '                                                           """tipoDensidadeValor:" & tipoDensidadeValor & "," &
    '                                                           """tipoDensidadeUnidade:" & tipoDensidadeUnidade & "," &
    '                                                           """numeroONU:" & numeroONU & "," &
    '                                                           """classeDeRisco:" & classeDeRisco & "," &
    '                                                           """nomeEmbarque:" & nomeEmbarque & "," &
    '                                                           """grupoEmbalagem:" & grupoEmbalagem & "," & "}]}"

    Private _codigoSequencial As String

    Public Property codigoSequencial
        Get
            Return _codigoSequencial
        End Get
        Set(value)
            _codigoSequencial = value
        End Set
    End Property

    Private _justificativa As String
    Public Property justificativa
        Get
            If _justificativa Is Nothing Then
                _justificativa = "NULO"
            End If
            Return UCase(_justificativa)
        End Get
        Set(value)
            _justificativa = value
        End Set
    End Property

    Private _codigoInterno As Integer
    Public Property codigoInterno
        Get
            Return _codigoInterno
        End Get
        Set(value)
            _codigoInterno = value
        End Set
    End Property


    Private _quantidade As String
    Public Property quantidade
        Get
            Return _quantidade
        End Get
        Set(value)
            _quantidade = value
        End Set
    End Property

    Private _quantidadeRecebida As String
    Public Property quantidadeRecebida
        Get
            Return _quantidadeRecebida
        End Get
        Set(value)
            _quantidadeRecebida = value
        End Set
    End Property

    Private _residuo
    ''' <summary>
    ''' Retornar a Identificação do Residuo
    ''' </summary>
    ''' <returns></returns>
    Public Property residuo
        Get
            'ESTRUTURA DE RETORNO

            '"tpre1Codigo" 4,
            '"tpre2Codigo": 15,
            '"tpre3Codigo": 93,
            '"tpre1Descricao": "Resíduos da indústria do couro e produtos de couro e da indústria têxtil", AQUI É REFERENTE AO CAPITULO
            '"tpre2Descricao": "Resíduos das industrias do couro e produtos de couro ", REF ao SUBCAPITULO DO CAPITULO
            '"tpre3Descricao": "Outros resíduos não anteriormente especificados", Apenas complementa a info
            '"tpre1Numero": "04",  AQUI É O CAPITULO
            '"tpre2Numero": "0401",  AQUI É O SUBCAPITULO
            '"tpre3Numero": "040199", AQUI É COD RESIDUO
            '"retornoCodigo": null,
            '"retorno": null

            Select Case _residuo


                Case E_retornaListaResiduo_Descricao._190802 '2012000028000969420009277900030686

                    _residuo += " Resíduos de desarenamento"

            End Select

            Return _residuo


        End Get

        Set(value)
            _residuo = value
        End Set
    End Property

    Private _codigoAcondicionamento As String
    ''' <summary>
    ''' Retornar a descrição do tipo de acodicionamento
    ''' </summary>
    ''' <returns></returns>
    Public Property codigoAcondicionamento
        Get
            Select Case _codigoAcondicionamento
                Case E_codigoAcondicionamento_descricao.Tambor
                    _codigoAcondicionamento = "Tambor"

                Case E_codigoAcondicionamento_descricao.Caçamba_Aberta
                    _codigoAcondicionamento = "Caçamba Aberta"

                Case E_codigoAcondicionamento_descricao.Caçamba_Fechada
                    _codigoAcondicionamento = "Caçamba Fechada"

                Case E_codigoAcondicionamento_descricao.Bombona_Plástica
                    _codigoAcondicionamento = "Bombona Plástica"

                Case E_codigoAcondicionamento_descricao.Granel
                    _codigoAcondicionamento = "Granel"

                Case E_codigoAcondicionamento_descricao.Caixa
                    _codigoAcondicionamento = "Caixa"

                Case E_codigoAcondicionamento_descricao.BigBag
                    _codigoAcondicionamento = "BigBag"

                Case E_codigoAcondicionamento_descricao.Fardo
                    _codigoAcondicionamento = "Fardo"

                Case E_codigoAcondicionamento_descricao.E08_Caixa_de_papelão
                    _codigoAcondicionamento = "E08 - Caixa de papelão"

                Case E_codigoAcondicionamento_descricao.E08_Balde
                    _codigoAcondicionamento = "E08 - Balde"

                Case E_codigoAcondicionamento_descricao.E04_Tanque
                    _codigoAcondicionamento = "E04 - Tanque"

                Case E_codigoAcondicionamento_descricao.E08_Palete
                    _codigoAcondicionamento = "E08 - Palete"

                Case E_codigoAcondicionamento_descricao.E08_Outros
                    _codigoAcondicionamento = "E08 - Outros"

                Case E_codigoAcondicionamento_descricao.Saco_Plástico
                    _codigoAcondicionamento = "Saco Plástico"

                Case E_codigoAcondicionamento_descricao.Caixa_RSS_perfurocortante
                    _codigoAcondicionamento = "Caixa RSS perfurocortante"

                Case E_codigoAcondicionamento_descricao.Cofre
                    _codigoAcondicionamento = "Cofre"

                Case E_codigoAcondicionamento_descricao.IBC
                    _codigoAcondicionamento = "IBC"

                Case E_codigoAcondicionamento_descricao.Recipiente_Pressurizado
                    _codigoAcondicionamento = "Recipiente Pressurizado"

                Case E_codigoAcondicionamento_descricao.Tambor_metálico
                    _codigoAcondicionamento = "Tambor metálico"

                Case E_codigoAcondicionamento_descricao.Cilindro_ou_outro_recipiente_pressurizado_para_acondicionamento_de_gases
                    _codigoAcondicionamento = "Cilindro ou outro recipiente pressurizado para acondicionamento de gases"

                Case E_codigoAcondicionamento_descricao.Contêiner_ou_Contentor
                    _codigoAcondicionamento = "Contêiner/ Contentor"

                Case E_codigoAcondicionamento_descricao.IBC___contentor_intermediário_rígido_para_carga_a_granel
                    _codigoAcondicionamento = "IBC (contentor intermediário rígido para carga a granel)"

                Case E_codigoAcondicionamento_descricao.FIBC__contentor_intermediário_flexível_para_carga_a_granel
                    _codigoAcondicionamento = "FIBC (contentor intermediário flexível para carga a granel)"


            End Select

            Return _codigoAcondicionamento

        End Get
        Set(value)
            _codigoAcondicionamento = value
        End Set
    End Property




    Private _codigoClasse As String
    Public Property codigoClasse
        Get
            Return _codigoClasse
        End Get
        Set(value)
            _codigoClasse = value
        End Set
    End Property


    Private _codigoTecnologia As String
    ''' <summary>
    ''' Retorna o tipo de Tecnologia
    ''' </summary>
    ''' <returns></returns>
    Public Property codigoTecnologia

        Get

            Select Case _codigoTecnologia

                Case E_Lista_de_Tecnologias_Descricao.Reciclagem
                    _codigoTecnologia = "Reciclagem"


                Case E_Lista_de_Tecnologias_Descricao.Recuperação_energética
                    _codigoTecnologia = "Recuperação energética"

                Case E_Lista_de_Tecnologias_Descricao.Coprocessamento
                    _codigoTecnologia = "Coprocessamento"

                Case E_Lista_de_Tecnologias_Descricao.Incineração
                    _codigoTecnologia = "Incineração"

                Case E_Lista_de_Tecnologias_Descricao.Blendagem_para_Coprocessamento
                    _codigoTecnologia = "Blendagem para Coprocessamento"

                Case E_Lista_de_Tecnologias_Descricao.Tratamento_Térmico
                    _codigoTecnologia = "Tratamento Térmico"

                Case E_Lista_de_Tecnologias_Descricao.Compostagem

                    _codigoTecnologia = "Compostagem"

                Case E_Lista_de_Tecnologias_Descricao.Tratamento_de_Efluentes
                    _codigoTecnologia = "Tratamento de Efluentes"

                Case E_Lista_de_Tecnologias_Descricao.Uso_Agrícola
                    _codigoTecnologia = "Uso_Agrícola"

                Case E_Lista_de_Tecnologias_Descricao.Autoclave
                    _codigoTecnologia = "Autoclave"

                Case E_Lista_de_Tecnologias_Descricao.Gaseificação
                    _codigoTecnologia = "Gaseificação"

                Case E_Lista_de_Tecnologias_Descricao.Microondas
                    _codigoTecnologia = "Microondas"

                Case E_Lista_de_Tecnologias_Descricao.Rerrefino
                    _codigoTecnologia = "Rerrefino"

                Case E_Lista_de_Tecnologias_Descricao.Descontaminação_de_Lâmpadas
                    _codigoTecnologia = "Descontaminação de Lâmpadas"

                Case E_Lista_de_Tecnologias_Descricao.Aterro_Classe_I
                    _codigoTecnologia = "Aterro Classe I"

                Case E_Lista_de_Tecnologias_Descricao.Aterro_Classe_IIA_e_IIB
                    _codigoTecnologia = "Aterro_Classe IIA e IIB"

                Case E_Lista_de_Tecnologias_Descricao.AterrodeReservação_RCC
                    _codigoTecnologia = "Aterro de Reservação RCC"

                Case E_Lista_de_Tecnologias_Descricao.Barragem_de_Rejeitos
                    _codigoTecnologia = "Barragem de Rejeitos"

                Case E_Lista_de_Tecnologias_Descricao.Biometanização
                    _codigoTecnologia = "Biometanização"

                Case E_Lista_de_Tecnologias_Descricao.Desmontagem_REE_e_Veículos
                    _codigoTecnologia = "Desmontagem REE e Veículos"

                Case E_Lista_de_Tecnologias_Descricao.Disposição_em_Cava_de_Mineração
                    _codigoTecnologia = "Disposição em Cava de Mineração"

                Case E_Lista_de_Tecnologias_Descricao.Pilha_de_Estéril
                    _codigoTecnologia = "Pilha de Estéril"

                Case E_Lista_de_Tecnologias_Descricao.Pirólise
                    _codigoTecnologia = "Pirólise"

                Case E_Lista_de_Tecnologias_Descricao.Triagem_e_Transbordo
                    _codigoTecnologia = "Triagem e Transbordo"

                Case E_Lista_de_Tecnologias_Descricao.Uso_Alimentação_Animal
                    _codigoTecnologia = "Uso Alimentação Animal"

                Case E_Lista_de_Tecnologias_Descricao.Sistema_de_logística_reversa_formalmente_instituído
                    _codigoTecnologia = "Sistema de logística reversa formalmente instituído "

                Case E_Lista_de_Tecnologias_Descricao.Utilização_de_biomassa_em_caldeira
                    _codigoTecnologia = "Utilização_de biomassa em caldeira"

                Case E_Lista_de_Tecnologias_Descricao.Reutilização
                    _codigoTecnologia = "Reutilização"

                Case E_Lista_de_Tecnologias_Descricao.Remediação_ex_situ
                    _codigoTecnologia = "Remediação ex situ"

                Case E_Lista_de_Tecnologias_Descricao.Uso_em_vias_para_pavimentação_ou_manutenção
                    _codigoTecnologia = "Uso em vias para pavimentação ou manutenção"

            End Select

            Return _codigoTecnologia

        End Get
        Set(value)
            _codigoTecnologia = value
        End Set
    End Property


    Private _codigoTipoEstado As String
    Public Property codigoTipoEstado
        Get
            Return _codigoTipoEstado
        End Get
        Set(value)
            _codigoTipoEstado = value
        End Set
    End Property


    Private _codigoUnidade As String
    Public Property codigoUnidade
        Get
            Return _codigoUnidade
        End Get
        Set(value)
            _codigoUnidade = value
        End Set
    End Property







    Private _manifestoItemObservacao As String
    Public Property manifestoItemObservacao
        Get
            Return UCase(_manifestoItemObservacao)
        End Get
        Set(value)
            _manifestoItemObservacao = value
        End Set
    End Property

    Private _manifestoItemCodInterno As String
    Public Property manifestoItemCodInterno
        Get
            Return _manifestoItemCodInterno
        End Get
        Set(value)
            _manifestoItemCodInterno = value
        End Set
    End Property


    Private _manifestoItemCodInternoDestinador As String
    Public Property manifestoItemCodInternoDestinador
        Get
            Return _manifestoItemCodInternoDestinador
        End Get
        Set(value)
            _manifestoItemCodInternoDestinador = value
        End Set
    End Property

    Private _tipoDensidadeValor As String
    Public Property tipoDensidadeValor
        Get
            Return _tipoDensidadeValor
        End Get
        Set(value)
            _tipoDensidadeValor = value
        End Set
    End Property

    Private _tipoDensidadeUnidade As String
    Public Property tipoDensidadeUnidade
        Get
            Return _tipoDensidadeUnidade
        End Get
        Set(value)
            _tipoDensidadeUnidade = value
        End Set
    End Property

    Private _numeroONU As String
    Public Property numeroONU
        Get
            Return _numeroONU
        End Get
        Set(value)
            _numeroONU = value
        End Set
    End Property

    Private _classeDeRisco As String
    Public Property classeDeRisco
        Get
            Return _classeDeRisco
        End Get
        Set(value)
            _classeDeRisco = value
        End Set
    End Property

    Private _nomeEmbarque As String
    Public Property nomeEmbarque
        Get
            Return _nomeEmbarque
        End Get
        Set(value)
            _nomeEmbarque = value
        End Set
    End Property

    Private _grupoEmbalagem As String
    Public Property grupoEmbalagem
        Get
            Return _grupoEmbalagem
        End Get
        Set(value)
            _grupoEmbalagem = value
        End Set
    End Property

    Dim _FormatarDataFeam As String
    Public Property FormatarDataFeam(UmaDataString)
        Get
            _FormatarDataFeam = UmaDataString
            If Not _FormatarDataFeam = Nothing Then
                Dim Data_ As String = Trim(_FormatarDataFeam.Substring(6, 2) & "/" & 'pega o valor da 4ª casa e conta apartir dai 2 dig apenas
            _FormatarDataFeam.Substring(4, 2) & "/" &
            _FormatarDataFeam.Substring(0, 4))

                Return Data_
            End If
            Return Nothing
        End Get

        Set(value)
            _FormatarDataFeam = value
        End Set
    End Property

#End Region

#Region "Variáveis e propriedades do Token"

    Public Property Token_de_Acesso As String
    Public Property chave_feam As String


    ''' <summary>
    ''' 'iat(issued at) = este recurso representa um Timestamp de quando o token foi criado
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property iat() As Long
        Get
            Dim StartDate As Date = CDate("1/1/1970")
            Dim EndDate As Date = Now.ToUniversalTime
            Dim val As Long = DateDiff(DateInterval.Second, StartDate, EndDate)
            Return val
        End Get
    End Property

    ''' <summary>
    ''' Representa um recurso de quando o Timestamp do token irá expirar
    ''' </summary>
    ''' <param name="ExpirationSeconds"></param>
    ''' <returns></returns>
    ReadOnly Property exp(ExpirationSeconds As Integer) As Long
        Get
            Return iat() + ExpirationSeconds
        End Get
    End Property

#End Region

#Region "Metodos e ou funçoes da classe"


    Public Property Numero_da_MTR_34_dig As String

#Region "Função para Transformar para Base64 URL do site"
    ''' <summary>
    ''' Função para converter para base 64 a URL base
    ''' </summary>
    ''' <param name="byt"></param>
    ''' <returns></returns>
    Private Function ToBase64url(byt As Byte()) As String
        Dim Result As String = Convert.ToBase64String(byt)
        'tornar url amigável
        Result = Result.Replace("+", "-").Replace("/", "_")

        Do While Result.Chars(Result.Length - 1) = "="
            Result = Strings.Left(Result, Result.Length - 1)
        Loop
        Return Result

    End Function


    Private Function ToBase64url(Text As String) As String
        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(Text)
        Return ToBase64url(b)
    End Function


#End Region

#Region "criando token"

    Private Aspas As Char = Chr(34)    'Aspas
    Private Virgula As Char = Chr(44) 'virgula

    Public Function GerarToken()

        Try
            Dim Request As HttpWebRequest
            Dim address As Uri

            'System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

            'montando o body
            Dim Dic As New Dictionary(Of String, String)

            Dic.Add("pessoaCodigo", PessoaCodigo)
            Dic.Add("pessoaCnpj", PessoaCnpj)
            Dic.Add("usuarioCpf", UsuarioCpf)
            Dic.Add("senha", Senha)

            Dim parameters As String = JsonConvert.SerializeObject(Dic, Formatting.Indented)

            address = New Uri("https://homologa.mtr.meioambiente.mg.gov.br/api/gettoken?")

            '----------------Setar propriedades da requisição------------------
            Request = DirectCast(WebRequest.Create(address), HttpWebRequest)
            Request.Method = "POST"
            'Request.Headers.Set("Authorization", String.Format("Bearer {0}", Token_de_Acesso)) 'ou assim '.Headers.Add("Authorization", "Bearer Key_Token")
            Dim Dados_para_Postar = parameters
            Dim ByteDados_para_Postar = System.Text.Encoding.UTF8.GetBytes(Dados_para_Postar)
            Request.ContentType = "application/json"
            Request.ContentLength = ByteDados_para_Postar.Length



            'postar os dados encodados em utf8 para o site usando um stream
            Using Postar As Stream = Request.GetRequestStream()
                Postar.Write(ByteDados_para_Postar, 0, ByteDados_para_Postar.Length)

                Dim RespostaTemporariadoServidor = ""
                Using resposta As HttpWebResponse = Request.GetResponse 'espere o cliente retornar a resposta assicronamente
                    Dim reader As New StreamReader(resposta.GetResponseStream())
                    RespostaTemporariadoServidor = reader.ReadToEnd 'reader.ReadToEnd()
                    Dim ObjToken As Object = JObject.Parse(RespostaTemporariadoServidor).SelectToken("token")
                    Dim ObjChave As Object = JObject.Parse(RespostaTemporariadoServidor).SelectToken("chave")

                    Token_de_Acesso = ObjToken
                    chave_feam = ObjChave

                    My.Settings.Token_de_Acesso = Token_de_Acesso 'faz a alteração via código no AppSettings
                    My.Settings.chave_feam = chave_feam
                    My.Settings.Save()

                    'faz a alteração fisicamente no appsettings onde cria a cópiac nome de  Principal.exe.config na saída do debug
                    Mysettings_CriandoParesChaves()

                    'método Get para recuperar as informações gravadas nas chaves: No caso o token e a chave!
                    MsgBox(ConfigurationManager.AppSettings.Get("token") & Chr(13) & ConfigurationManager.AppSettings.Get("chave"), vbInformation, "Análisando..")

                    'Request.Headers.Set("Authorization", String.Format("Bearer {0}", Token_de_Acesso)) 'ou assim '.Headers.Add("Authorization", "Bearer Key_Token")
                    'Request.Headers.Set("chave_feam", String.Format("", chave_feam))

                    My.Settings.Reload() 'para carregar a chave sem ter que fechar e abrir o programa de novo
                    Return True
                End Using
            End Using
        Catch ex As Exception
            ex.Message.ToString()
            Return False

        End Try

#Region "Exemplo adicional de pegar a resposta asycronamente"

        ''ClientSettingsSection()
        '' Pegar a resposta de retorno assicronamente
        'Using Client = New Http.HttpClient

        '    Using resposta = Await Client.GetAsync(address) 'espere o cliente retornar a resposta assicronamente

        '        If resposta.IsSuccessStatusCode Then     ' se o status for ok vou criar uma variavel para ler o conteudo do status da mensagem

        '            Dim Resp_JSON = Await resposta.Content.ReadAsStringAsync()
        '            MsgBox(JsonConvert.DeserializeObject(Resp_JSON))

        '        Else
        '            MessageBox.Show("Não foi possível pegar o token: " & " " & resposta.StatusCode)
        '        End If


        '    End Using
        'End Using
#End Region


    End Function

    ' If F.retornaManifesto(F.URL_da_api("https://homologa.mtr.meioambiente.mg.gov.br/api/retornaManifesto/" & F.Numero_da_MTR_34_dig)) = True Then 'True Then
    Public Function retornaManifesto(ByVal URL_da_api) As Boolean

        Dim _Boleano As Boolean = False

        Try
            'Faça um pedido ao URI POST
            'DirectCast(WebRequest.Create(address), HttpWebRequest)
            Dim RestPOSTRequest = DirectCast(WebRequest.CreateHttp("https://homologa.mtr.meioambiente.mg.gov.br/api/retornaManifesto/" & Numero_da_MTR_34_dig), HttpWebRequest)

            'Converter a entrada JSON em bytes por meio da codificação UTF8
            Dim JsonEncoding As New UTF8Encoding()
            Dim JsonBytes As Byte() = JsonEncoding.GetBytes(RestPOSTRequest.ToString)

            'Definir os parâmetros do pedido
            RestPOSTRequest.Method = "POST"

            RestPOSTRequest.ContentLength = JsonBytes.Length

            Token_de_Acesso = ConfigurationManager.AppSettings.Get("token")
            chave_feam = ConfigurationManager.AppSettings.Get("chave")


            RestPOSTRequest.Headers.Add("Authorization", String.Format("Bearer {0}", Token_de_Acesso)) 'ou assim '.Headers.Add("Authorization", "Bearer Key_Token")
            RestPOSTRequest.Headers.Add("chave_feam", chave_feam)
            RestPOSTRequest.ContentType = "application/json"
            My.Settings.Reload()

            '______________________________________________________________________________________________________________

            'Crie o fluxo de entrada para o URI
            Using RestPOSTRequestStream As Stream = RestPOSTRequest.GetRequestStream()

                'Grave os dados JSON de entrada no fluxo
                RestPOSTRequestStream.Write(JsonBytes, 0, JsonBytes.Length)

                'Resposta do servidorde acesso
                Dim RestPOSTResponse = RestPOSTRequest.GetResponse()

                Dim RespostaTemporariadoServidor = ""

                'Criar fluxo para a resposta
                Using RestPOSTResponseStream As Stream = RestPOSTResponse.GetResponseStream()

                    'Criar um leitor para o fluxo de resposta
                    Using RestPOSTResponseStreamReader As New StreamReader(RestPOSTResponseStream)

                        Dim ResponseData = RestPOSTResponseStreamReader.ReadToEnd()
                        RespostaTemporariadoServidor = ResponseData

                        manifestoCodigo = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifestoCodigo")

                        seuCodigoReferencia = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("seuCodigoReferencia") Is Nothing, seuCodigoReferencia = "null", _seuCodigoReferencia)

                        retornoCodigo = JObject.Parse(RespostaTemporariadoServidor).SelectToken("retornoCodigo")
                        cnpGerador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("cnpGerador")
                        codUnidadeGerador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("codUnidadeGerador")
                        cnpTransportador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("cnpTransportador")
                        codUnidadeTransportador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("codUnidadeTransportador")
                        cnpDestinador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("cnpDestinador")
                        codUnidadeDestinador = JObject.Parse(RespostaTemporariadoServidor).SelectToken("codUnidadeDestinador")

                        cnpArmazenador = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("cnpArmazenador") Is Nothing, cnpArmazenador = "null", _cnpArmazenador)

                        codUnidadeArmazenador = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("codUnidadeArmazenador") Is Nothing, codUnidadeArmazenador = "null", _codUnidadeArmazenador)

                        situacaoManifestoCodigo = JObject.Parse(RespostaTemporariadoServidor).SelectToken("situacaoManifestoCodigo")
                        manifData = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifData")
                        manifDataExpedicao = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifDataExpedicao")
                        manifObservacao = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifObservacao")

                        manifDataRecebimento = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifDataRecebimento") Is Nothing, manifDataRecebimento = "null", _manifDataRecebimento)

                        manifGeradorNomeResponsavel = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifGeradorNomeResponsavel")
                        manifGeradorCargoResponsavel = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifGeradorCargoResponsavel")
                        manifTransportadorNomeMotorista = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifTransportadorNomeMotorista")
                        manifTransportadorPlacaVeiculo = JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifTransportadorPlacaVeiculo")

                        manifTransportadorDataExpedicao = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("manifTransportadorDataExpedicao") Is Nothing, manifTransportadorDataExpedicao = "null", _manifTransportadorDataExpedicao)

                        retorno = JObject.Parse(RespostaTemporariadoServidor).SelectToken("retorno")

                        codigoSequencial = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoSequencial")
                        justificativa = JObject.Parse(RespostaTemporariadoServidor).SelectToken("justificativa.[0].justificativa")
                        codigoInterno = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoInterno") Is Nothing, codigoInterno = "null", _codigoInterno)
                        quantidade = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].quantidade")
                        quantidadeRecebida = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].quantidadeRecebida") Is Nothing, quantidadeRecebida = "null", _quantidadeRecebida)


                        'ESTE É O COD DO RESIDUO, TRATAR A SUA DESCRIÇÃO
                        residuo = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].residuo") 'ok




                        codigoAcondicionamento = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoAcondicionamento")
                        codigoClasse = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoClasse")

                        codigoTecnologia = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoTecnologia")

                        codigoTipoEstado = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoTipoEstado")
                        codigoUnidade = JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].codigoUnidade")
                        manifestoItemObservacao = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].manifestoItemObservacao") Is Nothing, manifestoItemObservacao = "null", _manifestoItemObservacao)
                        manifestoItemCodInterno = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].manifestoItemCodInterno") Is Nothing, manifestoItemCodInterno = "null", _manifestoItemCodInterno)
                        manifestoItemCodInternoDestinador = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].manifestoItemCodInternoDestinador") Is Nothing, manifestoItemCodInternoDestinador = "null", _manifestoItemCodInternoDestinador)
                        tipoDensidadeValor = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].tipoDensidadeValor") Is Nothing, tipoDensidadeValor = "null", _tipoDensidadeValor)
                        tipoDensidadeUnidade = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].tipoDensidadeUnidade") Is Nothing, tipoDensidadeUnidade = "null", _tipoDensidadeUnidade)
                        numeroONU = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].numeroONU") Is Nothing, numeroONU = "null", _numeroONU)
                        classeDeRisco = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].classeDeRisco") Is Nothing, classeDeRisco = "null", _classeDeRisco)
                        nomeEmbarque = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].nomeEmbarque") Is Nothing, nomeEmbarque = "null", _nomeEmbarque)
                        grupoEmbalagem = If(JObject.Parse(RespostaTemporariadoServidor).SelectToken("itemManifestoJSONs.[0].grupoEmbalagem") Is Nothing, grupoEmbalagem = "null", _grupoEmbalagem)

                        'Posteriormente, utilize a variável "ResponseData" conforme sua necessidade
                        _Boleano = True

                        'Feche o leitor
                        RestPOSTResponseStreamReader.Close()
                    End Using
                    RestPOSTResponseStream.Close()
                End Using
                RestPOSTRequestStream.Close()
            End Using
        Catch ex As Exception
            MsgBox("Detalhes: " & ex.Message, vbCritical, "Informação Auxiliar de status de erro!")
        End Try


        Return _Boleano

    End Function

#End Region

#Region "Notas: definiçoes a respeito do Token "

    '____________________ASSINATURA____________
    '(a assinatura, para verificar se o token é válido, aqui o importante é o "segredo" com o qual assinamos )

    '___________________'Agora crie as declarações JWT (também conhecidas como carga útil (Payload))___________________________

    'É o componente onde se encontram os dados referentes à própria autenticação. ex
    '{
    '"email" "aylan@boscarino.com",
    '"password": "ya0gsqhy4wzvuvb4"
    '}

    '(dados do usuário / declarações, data de criação / expiração de token e o que nossa API precisa para validar a solicitação,
    'podemos incluir todos os atributos se quiser)

    '- Key é uma string secreta que é usada para assinatura do token;
    '- Issuer - Indica a parte que esta emitindo o JWT;
    '- Audience - Indica os destinatários do JWT

    'Sub (subject) = Entidade à quem o token pertence, normalmente o ID Do usuário;
    'iss(issuer) = Emissor Do token;
    'exp(expiration) = Timestamp de quando o token irá expirar;
    'iat(issued at) = Timestamp de quando o token foi criado;
    'aud(audience) = Destinatário Do token, representa a aplicação que irá usá-lo.

#End Region

#Region "ValidarToken"


#End Region

#Region "AppSettings_Seção Fazendo adição do token e chave recebidos pela requisição de Post em AppSettings"
    Public Sub Mysettings_CriandoParesChaves()


        'Instanciando e utilizando o app.conf default da aplicação
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location)


        config.AppSettings.Settings.Remove("token")
        config.AppSettings.Settings.Remove("chave")

        'adicionado a chave e valor 'token'
        config.AppSettings.Settings.Add("token", My.Settings.Token_de_Acesso) '.Add("Key", "value")
        'adicionando chave e valior 'chave'
        config.AppSettings.Settings.Add("chave", My.Settings.chave_feam)


        'salvando as configurações
        config.Save(ConfigurationSaveMode.Modified)

        ConfigurationManager.OpenExeConfiguration(Application.StartupPath & "\Principal.exe.config")  '("C:\Users\mmarc\source\repos\VBnet\MF\Nova pasta_MTR\MTR\Principal\bin\Debug\Principal.exe.config")

        My.Settings.Reload()

        'para recuperar as informações exe,plo:
        'E para recuperar do arquivo as informações
        'comboBox_configuracao_horario.Text = ConfigurationManager.AppSettings.Get("nome da key");
        'txt_servidor_banco_dados.Text = ConfigurationManager.AppSettings.Get("IP_Servidor");
        'exemplo: (ConfigurationManager.AppSettings.Get("token") 
        '       'ConfigurationManager.AppSettings.Get("chave"))


    End Sub
#End Region

#Region "Conceito JWT"
#Disable Warning BC42312 ' O comentário da documentação XML deve preceder as declarações de membro ou tipo
    ''' <summary>
    ''' O JWT possui palavras reservadas e recomendadas para serem colocadas dentro do payload. São elas:
    ''' “iss” - O domínio da aplicação geradora do token
    ''' “sub” - É o assunto do token, mas é muito utilizado para guarda o ID do usuário
    ''' “aud” - Define quem pode usar o token
    ''' “exp” - Data para expiração do token
    ''' “nbf” - Define uma data para qual o token não pode ser aceito antes dela
    ''' “iat” - Data de criação do token
    ''' “jti” - O id do token
    ''' 
    ''' Header ou Cabeçalho -  É composto por duas partes:  o tipo do token, que é JWT, e o algoritmo de assinatura que está sendo usado,
    ''' como HMAC SHA256 ou RSA.Exemplo:   {   "alg": "HS256" ,  "typ" : "JWT" }    >Iisto é um cabeçario ou header
    ''' PayLoad ou Carga útil  - É o corpo do JWT e contém as claims. Claims são declarações sobre uma entidade (normalmente, o usuário) e dados adicionais. Existem três tipos de claims: claims registradas, públicas e privadas.
    '''Exemplo:   { "sub": "1234567890", "name": "Macoratti", "admin": true } esta é a 2 parte
    '''Signature ou Assinatura - Para criar a parte da assinatura, você precisa pegar o cabeçalho codificado, a carga codificada, um segredo, 
    '''o algoritmo especificado no cabeçalho e sinalizar isso.
    '''Exemplo:  HMACSHA256( base64UrlEncode(header) + "." + base64UrlEncode(payload), secret)
    ''' </summary>
    ''' <returns></returns>
#End Region

#End Region

End Class
#Enable Warning BC42312 ' O comentário da documentação XML deve preceder as declarações de membro ou tipo
