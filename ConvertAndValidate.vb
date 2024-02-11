'Rahiel Rodriguez
'RCET0265
'Spring 2024
'ConvertAndValidate
'https://github.com/rahielrodriguez/ConvertAndValidate.git
Module ConvertAndValidate

    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
        Dim usernResponse As String

        Do
            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()
            aValidNumber = CInt(usernResponse)

            If ConversionValid(usernResponse, aValidNumber) = True Then

                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

            End If

        Loop Until ConversionValid(usernResponse, aValidNumber) = True

        Console.Read()

    End Sub

    'make this work


    Function ConversionValid(convertThisString, toThisInteger) As Boolean

        Dim status As Boolean

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try

        Return status

    End Function

End Module
