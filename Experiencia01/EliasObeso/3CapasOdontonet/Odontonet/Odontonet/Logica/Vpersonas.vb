Public Class Vpersonas
    Dim dni, nom, ape, cod_usr, pwd_usu As String
    Dim fec As Date
    Dim tip As Integer
    Dim fot As Object

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property

    Public Property gnom
        Get
            Return nom
        End Get
        Set(ByVal value)
            nom = value
        End Set
    End Property

    Public Property gape
        Get
            Return ape
        End Get
        Set(ByVal value)
            ape = value
        End Set
    End Property

    Public Property gcod
        Get
            Return cod_usr
        End Get
        Set(ByVal value)
            cod_usr = value
        End Set
    End Property

    Public Property gpwd
        Get
            Return pwd_usu
        End Get
        Set(ByVal value)
            pwd_usu = value
        End Set
    End Property

    Public Property gfec
        Get
            Return fec
        End Get
        Set(ByVal value)
            fec = value
        End Set
    End Property

    Public Property gtip
        Get
            Return tip
        End Get
        Set(ByVal value)
            tip = value
        End Set
    End Property

    Public Property gfot
        Get
            Return fot
        End Get
        Set(ByVal value)
            fot = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal dni As String, ByVal nom As String, ByVal ape As String, ByVal fec As Date, ByVal tip As Integer, ByVal fot As Object, ByVal cod_usr As String, ByVal pwd_usu As String)
        gdni = dni
        gnom = nom
        gape = ape
        gfec = fec
        gtip = tip
        gfot = fot
        gcod = cod_usr
        gpwd = pwd_usu
    End Sub


End Class
