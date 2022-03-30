# Proje-1-Insertıon-Sort

## 1.Soru
1. Dizinin sort türüne göre aşamaları
- 22|,27,16,2,18,6
- 22,27|,16,2,18,6
- 16,22,27|,2,18,6
- 2,16,22,27|,18,6
- 2,16,18,22,27|,6
- 2,6,16,18,22,27|
2. BigO Gösterimi
- O(n^2) 
3. Time Complexity:
- Average case::O(n^2)
- Worst case:O(n^2)
- Best case:O(n)
4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer?
- Average case::O(n^2)
## 2.Soru
1. Dizinin Insertion Sort'a göre ilk 4 adımını yazınız.
- 7|,3,5,8,2,9,4,15,6
- 3,7|,5,8,2,9,4,15,6
- 3,5,7|,8,2,9,4,15,6
- 3,5,7,8|,2,9,4,15,6

## C# Kod Parçası

```           int swap =0;
            int i=0,j=0;
            for (i = 0; i < n; i++)
            {
                depo=dizi[i];
                for ( j = i; j >0&&dizi[j-1]>depo; j--)
                {
                    dizi[j]=dizi[j-1];
                }
                dizi[j]=swap;
                
            }```
