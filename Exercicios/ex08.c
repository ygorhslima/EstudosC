#include <stdio.h>
#include <stdlib.h>
int main()
{
    float distancia, km,hm,dam,dm,cm,mm;
    printf("Digite uma distância em metros: ");
    scanf("%f", &distancia);
    km = distancia / 1000;
    hm = distancia / 100;
    dam = distancia / 10;
    dm = distancia * 10;
    cm = distancia * 100;
    mm = distancia * 1000;

    printf("%fkm\n", km);
    printf("%fhm\n", hm);
    printf("%fdam\n", dam);
    printf("%fdm\n", dm);
    printf("%fcm\n", cm);
    printf("%fmm\n", mm);

    return 0;
}