# Proje-1-Insertıon-Sort

## C# Kod Parçası

`           int swap =0;
            int i=0,j=0;
            for (i = 0; i < n; i++)
            {
                depo=dizi[i];
                for ( j = i; j >0&&dizi[j-1]>depo; j--)
                {
                    dizi[j]=dizi[j-1];
                }
                dizi[j]=swap;
                
            }`