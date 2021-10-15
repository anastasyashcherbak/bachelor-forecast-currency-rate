function predict=forecast(factors,rate)
k=readfis('Fuzzy_Logic_Exchange_Rate_Rules');
r=evalfis(factors,k);
if r<0
    predict=rate-rate*(r/100);
else 
     predict=-rate*(r/100)+rate;
end
end