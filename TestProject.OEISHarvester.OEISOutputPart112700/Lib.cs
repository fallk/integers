using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A237629
{
public static readonly long[] Value={ 81L,636L,1310L,2012L,4622L,9368L,18344L,44292L,102536L,211268L,402152L,1015572L,2337608L,4914788L,9150632L,23921652L,54827528L,116999108L,214315112L,574558932L,1312885448L,2831048228L,5126666792L,13988255412L,31897292168L,69273334148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237629Inst : IEnumerable<long>
{
public static readonly long[] Value=A237629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237629.Bytes);
public long this[int i]=>Value[i];

public static A237629Inst Instance=new A237629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237630
{
public static readonly long[] Value={ 81L,260L,702L,1786L,4621L,11936L,30656L,77576L,200452L,515424L,1325424L,3365664L,8687760L,22278912L,57336960L,145904256L,376379712L,963592704L,2481143040L,6321940992L,16301843712L,41692741632L,107387375616L,273842325504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237630Inst : IEnumerable<long>
{
public static readonly long[] Value=A237630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237630.Bytes);
public long this[int i]=>Value[i];

public static A237630Inst Instance=new A237630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237631
{
public static readonly long[] Value={ 260L,636L,1220L,2356L,4500L,8594L,16448L,31672L,60362L,116180L,223768L,429680L,822032L,1584164L,3047968L,5848520L,11216480L,21603248L,41526472L,79692176L,153032384L,294531296L,565871200L,1086330032L,2087379872L,4014989408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237631Inst : IEnumerable<long>
{
public static readonly long[] Value=A237631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237631.Bytes);
public long this[int i]=>Value[i];

public static A237631Inst Instance=new A237631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237648
{
public static readonly long[] Value={ 1L,1L,5L,4L,30L,26L,106L,80L,459L,379L,1451L,1072L,5210L,4138L,14894L,10756L,47617L,36861L,127949L,91088L,376264L,285176L,957336L,672160L,2640964L,1968804L,6452260L,4483456L,16921416L,12437960L,39873688L,27435728L,100259070L,72823342L,229410006L,156586664L,556880812L,400294148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237648Inst : IEnumerable<long>
{
public static readonly long[] Value=A237648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237648.Bytes);
public long this[int i]=>Value[i];

public static A237648Inst Instance=new A237648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237649
{
public static readonly long[] Value={ 1L,15L,-2L,127L,1L,-30L,1L,1023L,-2L,15L,1L,-254L,1L,15L,-2L,8191L,1L,-30L,1L,127L,-2L,15L,1L,-2046L,1L,15L,-2L,127L,1L,-30L,1L,65535L,-2L,15L,1L,-254L,1L,15L,-2L,1023L,1L,-30L,1L,127L,-2L,15L,1L,-16382L,1L,15L,-2L,127L,1L,-30L,1L,1023L,-2L,15L,1L,-254L,1L,15L,-2L,524287L,1L,-30L,1L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237649Inst : IEnumerable<long>
{
public static readonly long[] Value=A237649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237649.Bytes);
public long this[int i]=>Value[i];

public static A237649Inst Instance=new A237649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237650
{
public static readonly long[] Value={ 1L,3L,12L,25L,75L,144L,357L,615L,1380L,2285L,4767L,7488L,14817L,22707L,43068L,63769L,116667L,169584L,301589L,427815L,741396L,1037149L,1761087L,2418432L,4025153L,5465955L,8956716L,11986009L,19330347L,25633296L,40835973L,53508711L,84129156L,109392269L,170278047L,219206976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237650Inst : IEnumerable<long>
{
public static readonly long[] Value=A237650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237650.Bytes);
public long this[int i]=>Value[i];

public static A237650Inst Instance=new A237650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237651
{
public static readonly long[] Value={ 1L,1L,3L,2L,9L,7L,17L,10L,41L,31L,75L,44L,150L,106L,238L,132L,445L,313L,711L,398L,1251L,853L,1859L,1006L,3135L,2129L,4677L,2548L,7590L,5042L,10734L,5692L,16865L,11173L,23979L,12806L,36911L,24105L,50551L,26446L,75985L,49539L,104683L,55144L,155140L,99996L,207188L,107192L,300766L,193574L,403994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237651Inst : IEnumerable<long>
{
public static readonly long[] Value=A237651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237651.Bytes);
public long this[int i]=>Value[i];

public static A237651Inst Instance=new A237651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237652
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,20L,-245L,4290L,-114422L,4086800L,-203647509L,12920587070L,-1053926397590L,105178069321944L,-12765014959365682L,1838898931467398164L,BigInteger.Parse("-311221726754896488780"),BigInteger.Parse("61047560951879121055296"),BigInteger.Parse("-13747598006865584455353165"),BigInteger.Parse("3521759025274977423306328182"),BigInteger.Parse("-1018406456608128511401443183654") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237652Inst Instance=new A237652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237653
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,36L,176L,1030L,7039L,55098L,486346L,4780445L,51787405L,613045468L,7873065045L,109021348618L,1619197654575L,25675094145535L,432908683794379L,7733991639921585L,145933532935469016L,2900112108790279902L,BigInteger.Parse("60543749629794205640"),BigInteger.Parse("1324677739541613767983"),BigInteger.Parse("30312375400027348522996") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237653Inst Instance=new A237653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237654
{
public static readonly long[] Value={ 1L,0L,5L,5L,25L,49L,150L,365L,990L,2550L,6726L,17550L,46015L,120390L,315275L,825299L,2160775L,5656855L,14809980L,38772875L,101508876L,265753500L,695751900L,1821501900L,4768754125L,12484760124L,32685526625L,85571819345L,224029931845L,586517975725L,1535523995826L,4020054011225L,10524638038410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237654Inst : IEnumerable<long>
{
public static readonly long[] Value=A237654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237654.Bytes);
public long this[int i]=>Value[i];

public static A237654Inst Instance=new A237654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237655
{
public static readonly long[] Value={ 1L,10L,50L,175L,510L,1376L,3625L,9500L,24875L,65125L,170500L,446375L,1168625L,3059500L,8009875L,20970125L,54900500L,143731375L,376293625L,985149500L,2579154875L,6752315125L,17677790500L,46281056375L,121165378625L,317215079500L,830479859875L,2174224500125L,5692193640500L,14902356421375L,39014875623625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237655Inst : IEnumerable<long>
{
public static readonly long[] Value=A237655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237655.Bytes);
public long this[int i]=>Value[i];

public static A237655Inst Instance=new A237655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237656
{
public static readonly long[] Value={ 1L,5L,3L,6L,8L,10L,18L,17L,30L,41L,28L,43L,29L,33L,43L,27L,66L,47L,98L,105L,155L,114L,113L,100L,49L,62L,118L,146L,85L,125L,80L,117L,74L,101L,167L,137L,168L,282L,176L,287L,129L,178L,151L,140L,163L,139L,262L,267L,277L,234L,285L,188L,203L,163L,192L,239L,188L,241L,252L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237656Inst : IEnumerable<long>
{
public static readonly long[] Value=A237656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237656.Bytes);
public long this[int i]=>Value[i];

public static A237656Inst Instance=new A237656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237657
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,5L,4L,3L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,6L,6L,6L,5L,4L,4L,4L,4L,5L,5L,5L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237657Inst : IEnumerable<long>
{
public static readonly long[] Value=A237657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237657.Bytes);
public long this[int i]=>Value[i];

public static A237657Inst Instance=new A237657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237658
{
public static readonly long[] Value={ 6L,17L,33L,34L,41L,59L,60L,69L,109L,110L,111L,127L,157L,161L,246L,287L,335L,353L,367L,368L,404L,600L,709L,711L,713L,718L,740L,779L,804L,1153L,1162L,1175L,1437L,1472L,1500L,1526L,1527L,1679L,1729L,1742L,1787L,1826L,2028L,2082L,2104L,2223L,2422L,2616L,2649L,2651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237658Inst : IEnumerable<long>
{
public static readonly long[] Value=A237658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237658.Bytes);
public long this[int i]=>Value[i];

public static A237658Inst Instance=new A237658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237659
{
public static readonly long[] Value={ 17L,41L,59L,109L,127L,157L,353L,367L,709L,1153L,1787L,3319L,3407L,3911L,5851L,6037L,6217L,6469L,8389L,9103L,9319L,10663L,13709L,14107L,14591L,15683L,18433L,19463L,19577L,20107L,21727L,23209L,27809L,29383L,32797L,35023L,36251L,36599L,38351L,39239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237659Inst : IEnumerable<long>
{
public static readonly long[] Value=A237659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237659.Bytes);
public long this[int i]=>Value[i];

public static A237659Inst Instance=new A237659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237660
{
public static readonly long[] Value={ 0L,0L,5L,0L,0L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,21L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,85L,5L,5L,5L,5L,5L,5L,5L,5L,21L,0L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237660Inst : IEnumerable<long>
{
public static readonly long[] Value=A237660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237660.Bytes);
public long this[int i]=>Value[i];

public static A237660Inst Instance=new A237660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237661
{
public static readonly long[] Value={ 3L,42L,75L,151L,2730L,7281L,14563L,174762L,184111L,932067L,11184810L,13256071L,26512143L,715827882L,1908874353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237661Inst : IEnumerable<long>
{
public static readonly long[] Value=A237661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237661.Bytes);
public long this[int i]=>Value[i];

public static A237661Inst Instance=new A237661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237662
{
public static readonly long[] Value={ 3L,7L,11L,17L,23L,31L,37L,47L,59L,67L,73L,101L,127L,131L,191L,223L,229L,239L,251L,257L,383L,401L,457L,479L,503L,521L,577L,991L,997L,1019L,1031L,1153L,1601L,1993L,2039L,2053L,2069L,3583L,3593L,3851L,3967L,4079L,4091L,4099L,4111L,4133L,6143L,6211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237662Inst : IEnumerable<long>
{
public static readonly long[] Value=A237662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237662.Bytes);
public long this[int i]=>Value[i];

public static A237662Inst Instance=new A237662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237663
{
public static readonly long[] Value={ 57L,111L,219L,285L,327L,399L,489L,505L,543L,555L,597L,627L,741L,777L,813L,969L,1083L,1095L,1137L,1221L,1255L,1299L,1311L,1379L,1425L,1443L,1461L,1467L,1515L,1533L,1569L,1623L,1635L,1653L,1731L,1767L,1839L,1887L,1893L,1995L,2005L,2109L,2271L,2289L,2337L,2409L,2433L,2445L,2451L,2487L,2553L,2649L,2679L,2715L,2757L,2775L,2793L,2811L,2847L,2973L,2985L,3005L,3021L,3027L,3135L,3189L,3219L,3351L,3363L,3423L,3437L,3441L,3459L,3477L,3505L,3513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237663Inst : IEnumerable<long>
{
public static readonly long[] Value=A237663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237663.Bytes);
public long this[int i]=>Value[i];

public static A237663Inst Instance=new A237663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237696
{
public static readonly long[] Value={ 81L,310L,1186L,4700L,18612L,73176L,287924L,1136084L,4482952L,17653056L,69546776L,274191240L,1081253560L,4259811632L,16788534672L,66170693936L,260880060656L,1027965311952L,4051919616000L,15968658702496L,62951672360256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237696Inst : IEnumerable<long>
{
public static readonly long[] Value=A237696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237696.Bytes);
public long this[int i]=>Value[i];

public static A237696Inst Instance=new A237696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237697
{
public static readonly long[] Value={ 310L,1524L,7562L,39236L,201754L,1033140L,5302002L,27377802L,140907656L,723464076L,3719653604L,19172131806L,98659238520L,507065229134L,2608372320890L,13432072024666L,69112775082390L,355397881712346L,1828490598631476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237697Inst : IEnumerable<long>
{
public static readonly long[] Value=A237697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237697.Bytes);
public long this[int i]=>Value[i];

public static A237697Inst Instance=new A237697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237698
{
public static readonly long[] Value={ 1186L,7562L,49152L,333508L,2234136L,14991412L,100790676L,681668756L,4585208960L,30833533736L,207687511796L,1402048789416L,9438312729002L,63517027029228L,427982336753074L,2886242240243372L,19435769390492458L,130855004505569972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237698Inst : IEnumerable<long>
{
public static readonly long[] Value=A237698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237698.Bytes);
public long this[int i]=>Value[i];

public static A237698Inst Instance=new A237698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237699
{
public static readonly long[] Value={ 4700L,39236L,333508L,3004030L,26578184L,236841050L,2109752772L,18967505282L,169027123272L,1509396722124L,13489906100708L,120997556161304L,1080200848895788L,9651096798463826L,86312065065972436L,773073801408693908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237699Inst : IEnumerable<long>
{
public static readonly long[] Value=A237699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237699.Bytes);
public long this[int i]=>Value[i];

public static A237699Inst Instance=new A237699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237700
{
public static readonly long[] Value={ 18612L,201754L,2234136L,26578184L,308509816L,3627304236L,42553713552L,505071086000L,5922294787728L,69775606782180L,822108559391386L,9728658246648940L,114398520024339750L,1348134815340411936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237700Inst : IEnumerable<long>
{
public static readonly long[] Value=A237700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237700.Bytes);
public long this[int i]=>Value[i];

public static A237700Inst Instance=new A237700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237701
{
public static readonly BigInteger[] Value={ 73176L,1033140L,14991412L,236841050L,3627304236L,56673321434L,881109625356L,13907965601602L,216097927856396L,3384176215220754L,52921486936618048L,832567114578029430L,12987848880359805692UL,BigInteger.Parse("203379886226033532072") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237701Inst Instance=new A237701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237702
{
public static readonly BigInteger[] Value={ 287924L,5302002L,100790676L,2109752772L,42553713552L,881109625356L,18113650467498L,378973936629084L,7780773084215402L,161441676035494768L,3342181810494114220L,BigInteger.Parse("69664489815908574204"),BigInteger.Parse("1437448142252037789754") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237702Inst Instance=new A237702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237703
{
public static readonly long[] Value={ 81L,310L,310L,1186L,1524L,1186L,4700L,7562L,7562L,4700L,18612L,39236L,49152L,39236L,18612L,73176L,201754L,333508L,333508L,201754L,73176L,287924L,1033140L,2234136L,3004030L,2234136L,1033140L,287924L,1136084L,5302002L,14991412L,26578184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237703Inst : IEnumerable<long>
{
public static readonly long[] Value=A237703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237703.Bytes);
public long this[int i]=>Value[i];

public static A237703Inst Instance=new A237703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237704
{
public static readonly long[] Value={ 2L,6L,12L,30L,32L,40L,42L,72L,90L,132L,152L,192L,210L,240L,312L,342L,408L,420L,462L,480L,552L,560L,592L,672L,702L,792L,870L,880L,888L,912L,930L,1122L,1152L,1260L,1272L,1320L,1332L,1560L,1584L,1722L,1752L,1792L,1980L,2352L,2520L,2550L,2652L,2712L,2862L,2952L,2970L,3192L,3560L,3640L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237704Inst : IEnumerable<long>
{
public static readonly long[] Value=A237704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237704.Bytes);
public long this[int i]=>Value[i];

public static A237704Inst Instance=new A237704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237705
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,3L,2L,2L,2L,1L,2L,3L,2L,3L,3L,2L,3L,3L,2L,4L,4L,3L,3L,1L,1L,3L,3L,2L,2L,1L,2L,6L,6L,5L,5L,4L,3L,5L,5L,4L,5L,5L,4L,6L,6L,6L,6L,3L,3L,5L,5L,5L,5L,2L,2L,5L,5L,3L,4L,5L,4L,8L,8L,3L,3L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237705Inst : IEnumerable<long>
{
public static readonly long[] Value=A237705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237705.Bytes);
public long this[int i]=>Value[i];

public static A237705Inst Instance=new A237705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237706
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,1L,1L,2L,2L,2L,4L,3L,3L,3L,1L,1L,2L,2L,3L,3L,1L,1L,2L,3L,4L,4L,4L,4L,6L,5L,4L,4L,2L,2L,3L,3L,5L,5L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,2L,2L,4L,5L,5L,5L,4L,4L,7L,6L,5L,5L,4L,4L,5L,5L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237706Inst : IEnumerable<long>
{
public static readonly long[] Value=A237706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237706.Bytes);
public long this[int i]=>Value[i];

public static A237706Inst Instance=new A237706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237707
{
public static readonly long[] Value={ 1L,4L,7L,10L,11L,17L,20L,23L,26L,32L,35L,38L,44L,48L,54L,60L,66L,69L,75L,78L,87L,96L,102L,105L,108L,114L,120L,121L,127L,133L,139L,145L,157L,163L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237707Inst : IEnumerable<long>
{
public static readonly long[] Value=A237707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237707.Bytes);
public long this[int i]=>Value[i];

public static A237707Inst Instance=new A237707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237708
{
public static readonly long[] Value={ 0L,1L,1L,4L,4L,7L,6L,7L,7L,10L,10L,16L,13L,16L,16L,19L,16L,22L,22L,28L,25L,28L,27L,28L,28L,34L,28L,34L,34L,37L,34L,43L,40L,46L,43L,46L,46L,52L,46L,52L,49L,52L,49L,52L,52L,61L,55L,67L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237708Inst : IEnumerable<long>
{
public static readonly long[] Value=A237708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237708.Bytes);
public long this[int i]=>Value[i];

public static A237708Inst Instance=new A237708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237709
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,2L,4L,4L,6L,2L,4L,8L,4L,4L,4L,4L,2L,10L,8L,4L,8L,4L,8L,12L,4L,6L,6L,8L,4L,12L,4L,4L,12L,16L,8L,4L,8L,4L,8L,16L,8L,4L,2L,6L,12L,4L,20L,4L,12L,12L,8L,4L,8L,12L,4L,20L,4L,8L,4L,24L,24L,8L,4L,8L,12L,4L,4L,16L,10L,2L,12L,12L,4L,12L,8L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237709Inst : IEnumerable<long>
{
public static readonly long[] Value=A237709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237709.Bytes);
public long this[int i]=>Value[i];

public static A237709Inst Instance=new A237709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237710
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,5L,5L,7L,2L,2L,2L,2L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L,13L,17L,2L,2L,2L,2L,2L,2L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L,13L,17L,17L,17L,17L,19L,19L,23L,23L,23L,23L,29L,29L,29L,2L,2L,2L,2L,2L,2L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237710Inst : IEnumerable<long>
{
public static readonly long[] Value=A237710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237710.Bytes);
public long this[int i]=>Value[i];

public static A237710Inst Instance=new A237710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237711
{
public static readonly long[] Value={ 1L,6L,7L,36L,13L,42L,43L,216L,49L,78L,55L,252L,85L,258L,259L,1296L,265L,294L,127L,468L,133L,330L,307L,1512L,337L,510L,343L,1548L,517L,1554L,1555L,7776L,1561L,1590L,559L,1764L,421L,762L,595L,2808L,601L,798L,463L,1980L,637L,1842L,1819L,9072L,1849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237711Inst : IEnumerable<long>
{
public static readonly long[] Value=A237711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237711.Bytes);
public long this[int i]=>Value[i];

public static A237711Inst Instance=new A237711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237824
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,7L,10L,11L,13L,14L,19L,18L,23L,25L,29L,30L,38L,37L,46L,48L,54L,57L,70L,69L,80L,85L,97L,100L,118L,118L,137L,144L,159L,168L,193L,195L,220L,233L,259L,268L,303L,311L,348L,367L,399L,419L,469L,483L,532L,560L,610L,639L,704L,732L,801L,841L,908L,954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237824Inst : IEnumerable<long>
{
public static readonly long[] Value=A237824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237824.Bytes);
public long this[int i]=>Value[i];

public static A237824Inst Instance=new A237824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237825
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,5L,5L,8L,9L,13L,14L,18L,20L,27L,28L,35L,38L,49L,51L,61L,66L,81L,86L,102L,109L,130L,136L,161L,172L,202L,214L,245L,264L,305L,323L,369L,395L,452L,480L,544L,580L,657L,703L,786L,842L,947L,1008L,1124L,1205L,1340L,1432L,1589L,1702L,1886L,2014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237825Inst : IEnumerable<long>
{
public static readonly long[] Value=A237825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237825.Bytes);
public long this[int i]=>Value[i];

public static A237825Inst Instance=new A237825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237826
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,5L,7L,9L,12L,16L,20L,26L,31L,38L,47L,55L,67L,78L,92L,106L,126L,145L,167L,190L,219L,247L,288L,320L,366L,410L,466L,520L,591L,654L,739L,820L,924L,1018L,1148L,1263L,1415L,1562L,1740L,1911L,2136L,2342L,2607L,2859L,3169L,3469L,3849L,4208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237826Inst : IEnumerable<long>
{
public static readonly long[] Value=A237826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237826.Bytes);
public long this[int i]=>Value[i];

public static A237826Inst Instance=new A237826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237827
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,3L,5L,7L,11L,13L,19L,24L,32L,39L,52L,61L,77L,93L,114L,133L,164L,188L,226L,261L,309L,353L,417L,471L,549L,622L,717L,808L,933L,1042L,1191L,1334L,1516L,1690L,1921L,2131L,2407L,2674L,3006L,3330L,3744L,4135L,4628L,5116L,5708L,6294L,7020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237827Inst : IEnumerable<long>
{
public static readonly long[] Value=A237827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237827.Bytes);
public long this[int i]=>Value[i];

public static A237827Inst Instance=new A237827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237828
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,4L,6L,9L,10L,12L,17L,18L,22L,27L,31L,34L,42L,45L,53L,61L,66L,72L,86L,92L,103L,113L,125L,135L,154L,163L,180L,197L,213L,229L,257L,271L,294L,318L,346L,368L,404L,426L,463L,497L,532L,564L,616L,651L,700L,747L,798L,844L,912L,962L,1033L,1097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237828Inst : IEnumerable<long>
{
public static readonly long[] Value=A237828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237828.Bytes);
public long this[int i]=>Value[i];

public static A237828Inst Instance=new A237828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237829
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,5L,3L,4L,5L,5L,6L,8L,6L,8L,10L,10L,10L,15L,12L,14L,17L,18L,20L,23L,21L,26L,29L,30L,31L,39L,38L,42L,46L,49L,52L,61L,60L,68L,74L,77L,83L,94L,95L,104L,112L,122L,128L,143L,144L,159L,172L,181L,192L,212L,219L,237L,253L,271L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237829Inst : IEnumerable<long>
{
public static readonly long[] Value=A237829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237829.Bytes);
public long this[int i]=>Value[i];

public static A237829Inst Instance=new A237829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237830
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,15L,20L,27L,36L,47L,62L,81L,105L,135L,174L,222L,282L,357L,450L,565L,707L,880L,1093L,1353L,1669L,2052L,2517L,3077L,3753L,4565L,5539L,6704L,8097L,9755L,11730L,14075L,16854L,20142L,24029L,28611L,34009L,40355L,47807L,56542L,66772L,78728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237830Inst : IEnumerable<long>
{
public static readonly long[] Value=A237830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237830.Bytes);
public long this[int i]=>Value[i];

public static A237830Inst Instance=new A237830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237831
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,12L,18L,23L,32L,40L,57L,70L,94L,120L,157L,196L,256L,318L,408L,508L,640L,792L,996L,1223L,1518L,1863L,2296L,2798L,3432L,4162L,5070L,6130L,7422L,8936L,10777L,12916L,15500L,18522L,22136L,26348L,31376L,37222L,44160L,52236L,61756L,72824L,85847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237831Inst : IEnumerable<long>
{
public static readonly long[] Value=A237831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237831.Bytes);
public long this[int i]=>Value[i];

public static A237831Inst Instance=new A237831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237832
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,3L,3L,5L,4L,10L,8L,13L,15L,22L,22L,34L,36L,51L,58L,75L,85L,116L,130L,165L,194L,244L,281L,355L,409L,505L,591L,718L,839L,1022L,1186L,1425L,1668L,1994L,2319L,2765L,3213L,3805L,4429L,5214L,6052L,7119L,8243L,9645L,11169L,13026L,15046L,17511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237832Inst : IEnumerable<long>
{
public static readonly long[] Value=A237832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237832.Bytes);
public long this[int i]=>Value[i];

public static A237832Inst Instance=new A237832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237833
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,3L,4L,7L,10L,16L,20L,31L,41L,56L,74L,101L,129L,172L,219L,284L,362L,463L,579L,735L,918L,1147L,1422L,1767L,2172L,2680L,3279L,4013L,4888L,5947L,7200L,8721L,10515L,12663L,15202L,18235L,21798L,26039L,31015L,36898L,43802L,51930L,61426L,72590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237833Inst : IEnumerable<long>
{
public static readonly long[] Value=A237833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237833.Bytes);
public long this[int i]=>Value[i];

public static A237833Inst Instance=new A237833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237834
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,4L,7L,10L,15L,20L,30L,39L,54L,71L,96L,123L,163L,208L,270L,342L,437L,548L,695L,865L,1083L,1341L,1666L,2048L,2527L,3089L,3784L,4604L,5606L,6786L,8222L,9907L,11940L,14331L,17196L,20554L,24563L,29252L,34820L,41327L,49016L,57982L,68545L,80833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237834Inst : IEnumerable<long>
{
public static readonly long[] Value=A237834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237834.Bytes);
public long this[int i]=>Value[i];

public static A237834Inst Instance=new A237834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237835
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,1L,1L,1L,2L,1L,12L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,6L,1L,2L,1L,4L,1L,6L,1L,1L,1L,2L,1L,4L,1L,2L,1L,1L,1L,6L,1L,1L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,1L,4L,3L,2L,1L,12L,1L,2L,1L,1L,1L,6L,1L,2L,3L,2L,1L,2L,1L,2L,1L,1L,1L,6L,1L,1L,1L,2L,1L,12L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237835Inst : IEnumerable<long>
{
public static readonly long[] Value=A237835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237835.Bytes);
public long this[int i]=>Value[i];

public static A237835Inst Instance=new A237835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237836
{
public static readonly long[] Value={ 1L,6L,24L,24L,100L,24L,112L,96L,216L,300L,110L,24L,364L,336L,600L,384L,612L,216L,342L,600L,336L,330L,1104L,96L,2500L,1092L,1944L,336L,406L,600L,930L,1536L,1320L,612L,2800L,216L,2812L,342L,2184L,2400L,1640L,336L,3784L,1320L,5400L,1104L,1504L,384L,5488L,7500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237836Inst : IEnumerable<long>
{
public static readonly long[] Value=A237836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237836.Bytes);
public long this[int i]=>Value[i];

public static A237836Inst Instance=new A237836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237837
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,2L,2L,2L,3L,3L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237837Inst : IEnumerable<long>
{
public static readonly long[] Value=A237837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237837.Bytes);
public long this[int i]=>Value[i];

public static A237837Inst Instance=new A237837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237838
{
public static readonly long[] Value={ 0L,1L,3L,2L,3L,2L,2L,2L,2L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,3L,2L,3L,2L,1L,2L,1L,2L,1L,2L,3L,2L,2L,1L,3L,3L,4L,4L,4L,3L,4L,1L,1L,3L,3L,2L,3L,1L,1L,2L,2L,4L,1L,4L,3L,5L,4L,5L,4L,3L,4L,3L,4L,3L,2L,1L,4L,3L,4L,6L,1L,3L,3L,3L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237838Inst : IEnumerable<long>
{
public static readonly long[] Value=A237838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237838.Bytes);
public long this[int i]=>Value[i];

public static A237838Inst Instance=new A237838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237839
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,3L,2L,3L,1L,2L,2L,3L,3L,2L,2L,5L,2L,3L,3L,4L,2L,2L,2L,3L,1L,2L,2L,3L,3L,2L,3L,2L,2L,3L,6L,7L,5L,5L,3L,4L,3L,3L,4L,3L,3L,4L,4L,4L,5L,4L,5L,3L,3L,4L,3L,2L,2L,3L,4L,3L,4L,3L,3L,6L,6L,5L,5L,4L,5L,3L,5L,8L,4L,3L,3L,4L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237839Inst : IEnumerable<long>
{
public static readonly long[] Value=A237839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237839.Bytes);
public long this[int i]=>Value[i];

public static A237839Inst Instance=new A237839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237872
{
public static readonly BigInteger[] Value={ 1L,4L,33L,292L,10085L,48756L,2827293L,257063528L,13779684369L,70889442280L,72634140523901L,314690934778068L,140915129117772841L,5533416685634616884L,BigInteger.Parse("251767541303505518145"),BigInteger.Parse("55644156684309383260624"),BigInteger.Parse("7481965178603932789388755") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237872Inst Instance=new A237872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237873
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,5L,20L,105L,280L,63L,2520L,385L,5544L,6435L,8008L,45045L,144144L,85085L,116688L,2909907L,739024L,146965L,232792560L,37182145L,356948592L,128707425L,2974571600L,717084225L,80313433200L,215656441L,30247916400L,4512611027925L,486207248800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237873Inst : IEnumerable<long>
{
public static readonly long[] Value=A237873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237873.Bytes);
public long this[int i]=>Value[i];

public static A237873Inst Instance=new A237873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237874
{
public static readonly long[] Value={ 8688L,545004L,27056160L,1569462504L,74688648384L,4226663427372L,187073313101280L,10432303205684856L,442700713763856576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237874Inst : IEnumerable<long>
{
public static readonly long[] Value=A237874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237874.Bytes);
public long this[int i]=>Value[i];

public static A237874Inst Instance=new A237874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237875
{
public static readonly long[] Value={ 8688L,160116L,545004L,2555616L,33010248L,27056160L,51445400L,3553300428L,9104981940L,1569462504L,812946240L,217951919352L,2518253444304L,1912276362868L,74688648384L,17003002820L,27580184157228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237875Inst : IEnumerable<long>
{
public static readonly long[] Value=A237875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237875.Bytes);
public long this[int i]=>Value[i];

public static A237875Inst Instance=new A237875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237876
{
public static readonly BigInteger[] Value={ 8688L,160116L,2555616L,51445400L,812946240L,17003002820L,268858480800L,5729218802184L,91097806323648L,1961386312726824L,31409027107915584L,680566352758997424L,10976337867131545728UL,BigInteger.Parse("238840537990803754692") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237876Inst Instance=new A237876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237877
{
public static readonly long[] Value={ 1L,2L,9L,11L,17L,48L,57L,427L,533L,1661L,2161L,4441L,5428L,41628L,171441L,411735L,555716L,1278525L,4292829L,5174373L,8758407L,680133057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237877Inst : IEnumerable<long>
{
public static readonly long[] Value=A237877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237877.Bytes);
public long this[int i]=>Value[i];

public static A237877Inst Instance=new A237877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237878
{
public static readonly long[] Value={ 4L,16L,22L,34L,108L,121L,187L,232L,289L,300L,372L,2230L,4322L,8882L,23771L,36737L,48851L,50946L,67650L,75497L,424689L,482998L,581765L,4669921L,7374225L,9597001L,19722481L,110714642L,416101557L,1478286411L,1773582750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237878Inst : IEnumerable<long>
{
public static readonly long[] Value=A237878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237878.Bytes);
public long this[int i]=>Value[i];

public static A237878Inst Instance=new A237878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237879
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,3L,3L,2L,2L,2L,2L,2L,2L,15L,14L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,17L,17L,7L,7L,3L,3L,15L,14L,6L,6L,13L,13L,13L,12L,12L,5L,5L,5L,11L,11L,11L,2L,2L,2L,10L,10L,10L,4L,4L,4L,9L,9L,9L,16L,46L,8L,8L,8L,8L,8L,8L,65L,14L,52L,7L,7L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237879Inst : IEnumerable<long>
{
public static readonly long[] Value=A237879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237879.Bytes);
public long this[int i]=>Value[i];

public static A237879Inst Instance=new A237879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237880
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,16L,134L,1345L,13420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237880Inst : IEnumerable<long>
{
public static readonly long[] Value=A237880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237880.Bytes);
public long this[int i]=>Value[i];

public static A237880Inst Instance=new A237880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237881
{
public static readonly long[] Value={ 0L,3L,2L,1L,3L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,4L,3L,7L,1L,4L,3L,1L,2L,1L,1L,2L,1L,3L,1L,4L,1L,2L,2L,5L,2L,2L,6L,1L,2L,5L,3L,2L,7L,1L,2L,1L,1L,1L,3L,1L,3L,5L,2L,2L,3L,2L,2L,2L,1L,2L,6L,3L,1L,4L,1L,3L,2L,2L,3L,1L,3L,1L,2L,4L,1L,2L,1L,1L,1L,2L,3L,2L,5L,3L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,3L,6L,4L,5L,2L,2L,2L,2L,2L,3L,4L,3L,2L,1L,2L,1L,3L,2L,1L,2L,5L,3L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237881Inst : IEnumerable<long>
{
public static readonly long[] Value=A237881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237881.Bytes);
public long this[int i]=>Value[i];

public static A237881Inst Instance=new A237881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237882
{
public static readonly long[] Value={ 0L,4L,8L,9L,16L,17L,18L,20L,24L,32L,33L,34L,35L,36L,37L,40L,41L,48L,49L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,80L,81L,82L,84L,88L,96L,97L,98L,99L,104L,112L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,141L,144L,145L,146L,148L,149L,152L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237882Inst : IEnumerable<long>
{
public static readonly long[] Value=A237882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237882.Bytes);
public long this[int i]=>Value[i];

public static A237882Inst Instance=new A237882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237883
{
public static readonly long[] Value={ 1L,3L,6L,7L,11L,13L,14L,15L,22L,23L,26L,27L,28L,29L,30L,31L,39L,43L,45L,46L,47L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,78L,79L,86L,87L,90L,91L,92L,93L,94L,95L,103L,106L,107L,109L,110L,111L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237883Inst : IEnumerable<long>
{
public static readonly long[] Value=A237883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237883.Bytes);
public long this[int i]=>Value[i];

public static A237883Inst Instance=new A237883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237884
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,20L,15L,105L,56L,504L,210L,2310L,792L,10296L,3003L,45045L,11440L,194480L,43758L,831402L,167960L,3527160L,646646L,14872858L,2496144L,62403600L,9657700L,260757900L,37442160L,1085822640L,145422675L,4508102925L,565722720L,18668849760L,2203961430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237884Inst : IEnumerable<long>
{
public static readonly long[] Value=A237884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237884.Bytes);
public long this[int i]=>Value[i];

public static A237884Inst Instance=new A237884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237885
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,1L,1L,0L,4L,0L,0L,2L,0L,1L,1L,0L,1L,2L,0L,0L,2L,0L,0L,3L,0L,0L,2L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,0L,5L,0L,0L,3L,0L,0L,1L,0L,0L,0L,0L,0L,4L,0L,0L,3L,0L,0L,2L,0L,1L,3L,0L,0L,3L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237885Inst : IEnumerable<long>
{
public static readonly long[] Value=A237885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237885.Bytes);
public long this[int i]=>Value[i];

public static A237885Inst Instance=new A237885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237886
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,11L,14L,17L,21L,24L,28L,32L,37L,41L,46L,50L,55L,60L,66L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237886Inst : IEnumerable<long>
{
public static readonly long[] Value=A237886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237886.Bytes);
public long this[int i]=>Value[i];

public static A237886Inst Instance=new A237886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A237887
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,65L,8621L,149184857L,44551677001092773L,BigInteger.Parse("3970578415163336458099984005568433"),BigInteger.Parse("31532720313075764582758396083530822599715967108537469217279098897853") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A237887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A237887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A237887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A237887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A237887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A237887Inst Instance=new A237887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238224
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,3L,5L,5L,3L,3L,8L,4L,3L,5L,2L,1L,8L,2L,2L,5L,3L,4L,3L,6L,4L,6L,7L,6L,6L,4L,8L,2L,7L,5L,9L,6L,7L,5L,4L,5L,4L,8L,5L,9L,4L,5L,6L,1L,9L,2L,7L,6L,4L,9L,7L,4L,8L,6L,1L,7L,8L,10L,4L,4L,4L,8L,6L,5L,4L,7L,7L,7L,3L,9L,4L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238224Inst : IEnumerable<long>
{
public static readonly long[] Value=A238224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238224.Bytes);
public long this[int i]=>Value[i];

public static A238224Inst Instance=new A238224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238225
{
public static readonly long[] Value={ 12L,42L,1242L,2010L,2358L,57990L,65802L,1782198L,1890738L,2504920L,2733880L,3286128L,4181968L,6137440L,7861200L,8233134L,11208018L,15228688L,21445340L,24563812L,33714690L,38928126L,185154858L,207494658L,221604534L,247017798L,341398422L,366777018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238225Inst : IEnumerable<long>
{
public static readonly long[] Value=A238225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238225.Bytes);
public long this[int i]=>Value[i];

public static A238225Inst Instance=new A238225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238226
{
public static readonly long[] Value={ 1L,3L,14L,52L,130L,144L,184L,274L,300L,586L,656L,8648L,10434L,11470L,12008L,15774L,17034L,18802L,19270L,21032L,22088L,22184L,23288L,34688L,35394L,36872L,38744L,39790L,65324L,65392L,67628L,68476L,153868L,163676L,188468L,198628L,254526L,263890L,379026L,463390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238226Inst : IEnumerable<long>
{
public static readonly long[] Value=A238226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238226.Bytes);
public long this[int i]=>Value[i];

public static A238226Inst Instance=new A238226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238227
{
public static readonly long[] Value={ 1L,56L,66L,70L,992L,1012L,2260L,2516L,6042L,6902L,7192L,7210L,7232L,7750L,7912L,8178L,9086L,10792L,12198L,13706L,17272L,30592L,32778L,33352L,35032L,40166L,44034L,45010L,46670L,47710L,55374L,62296L,63688L,65570L,114256L,132916L,133892L,138244L,141236L,146804L,155572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238227Inst : IEnumerable<long>
{
public static readonly long[] Value=A238227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238227.Bytes);
public long this[int i]=>Value[i];

public static A238227Inst Instance=new A238227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238228
{
public static readonly long[] Value={ 12L,14L,27L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238228Inst : IEnumerable<long>
{
public static readonly long[] Value=A238228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238228.Bytes);
public long this[int i]=>Value[i];

public static A238228Inst Instance=new A238228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238229
{
public static readonly long[] Value={ 2L,4L,20L,66L,342L,34092L,40842L,41922L,46242L,55422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238229Inst : IEnumerable<long>
{
public static readonly long[] Value=A238229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238229.Bytes);
public long this[int i]=>Value[i];

public static A238229Inst Instance=new A238229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238230
{
public static readonly long[] Value={ 198L,294L,16008L,22232L,150030L,195320L,200274L,3038720L,12190720L,124904790L,167179722L,347943288L,426853240L,528995656L,646186568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238230Inst : IEnumerable<long>
{
public static readonly long[] Value=A238230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238230.Bytes);
public long this[int i]=>Value[i];

public static A238230Inst Instance=new A238230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238231
{
public static readonly long[] Value={ 376L,594L,846L,1178L,1222L,46498L,65198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238231Inst : IEnumerable<long>
{
public static readonly long[] Value=A238231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238231.Bytes);
public long this[int i]=>Value[i];

public static A238231Inst Instance=new A238231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238232
{
public static readonly long[] Value={ 15L,35L,95L,119L,143L,209L,255L,287L,319L,323L,377L,527L,559L,779L,899L,923L,989L,1007L,1189L,1199L,1295L,1343L,1349L,1763L,1919L,2159L,2507L,2759L,2911L,3239L,3599L,3827L,4031L,4607L,5183L,5207L,5249L,5459L,5543L,6439L,6479L,6887L,7067L,7279L,7739L,8159L,8639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238232Inst : IEnumerable<long>
{
public static readonly long[] Value=A238232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238232.Bytes);
public long this[int i]=>Value[i];

public static A238232Inst Instance=new A238232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238233
{
public static readonly long[] Value={ 132496L,1052576L,5656464L,12936992L,19230208L,187545888L,1740340368L,163150299648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238233Inst : IEnumerable<long>
{
public static readonly long[] Value=A238233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238233.Bytes);
public long this[int i]=>Value[i];

public static A238233Inst Instance=new A238233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238234
{
public static readonly long[] Value={ 4L,3L,4L,3L,2L,7L,7L,0L,3L,1L,9L,6L,9L,3L,8L,1L,0L,2L,2L,9L,6L,1L,5L,7L,5L,1L,3L,0L,2L,4L,8L,3L,7L,2L,3L,6L,7L,4L,2L,7L,9L,1L,3L,8L,9L,2L,7L,7L,1L,9L,6L,7L,7L,9L,3L,8L,5L,5L,2L,6L,0L,1L,4L,1L,4L,4L,2L,1L,1L,5L,0L,5L,4L,1L,6L,0L,9L,4L,6L,8L,0L,4L,0L,7L,3L,8L,9L,6L,1L,9L,8L,6L,8L,6L,1L,4L,2L,9L,1L,5L,2L,7L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238234Inst : IEnumerable<long>
{
public static readonly long[] Value=A238234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238234.Bytes);
public long this[int i]=>Value[i];

public static A238234Inst Instance=new A238234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238235
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,1L,1L,-1L,-17L,17L,31L,-31L,-691L,691L,5461L,-5461L,-929569L,929569L,3202291L,-3202291L,-221930581L,221930581L,4722116521L,-4722116521L,-968383680827L,968383680827L,14717667114151L,-14717667114151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238235Inst : IEnumerable<long>
{
public static readonly long[] Value=A238235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238235.Bytes);
public long this[int i]=>Value[i];

public static A238235Inst Instance=new A238235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238236
{
public static readonly long[] Value={ 1L,2L,6L,18L,55L,169L,520L,1601L,4930L,15182L,46754L,143983L,443409L,1365520L,4205249L,12950466L,39882198L,122821042L,378239143L,1164823609L,3587185688L,11047081345L,34020543362L,104769516446L,322647744322L,993624581343L,3059961912097L,9423445312544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238236Inst : IEnumerable<long>
{
public static readonly long[] Value=A238236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238236.Bytes);
public long this[int i]=>Value[i];

public static A238236Inst Instance=new A238236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238237
{
public static readonly long[] Value={ 81L,2025L,3025L,9801L,494209L,998001L,24502500L,25502500L,52881984L,60481729L,99980001L,6049417284L,6832014336L,9048004641L,9999800001L,101558217124L,108878221089L,123448227904L,127194229449L,152344237969L,213018248521L,217930248900L,249500250000L,250500250000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238237Inst : IEnumerable<long>
{
public static readonly long[] Value=A238237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238237.Bytes);
public long this[int i]=>Value[i];

public static A238237Inst Instance=new A238237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238238
{
public static readonly long[] Value={ 1L,3L,3L,2L,4L,7L,8L,8L,6L,4L,9L,8L,5L,0L,3L,0L,5L,1L,0L,2L,0L,8L,0L,0L,9L,7L,9L,1L,9L,5L,5L,5L,8L,5L,4L,4L,1L,3L,3L,4L,9L,8L,0L,2L,7L,7L,4L,5L,1L,8L,9L,5L,6L,8L,5L,6L,6L,2L,9L,4L,7L,6L,8L,5L,6L,0L,7L,9L,5L,7L,9L,7L,8L,7L,5L,8L,1L,1L,8L,5L,6L,3L,4L,1L,5L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238238Inst : IEnumerable<long>
{
public static readonly long[] Value=A238238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238238.Bytes);
public long this[int i]=>Value[i];

public static A238238Inst Instance=new A238238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238239
{
public static readonly long[] Value={ 7L,6L,3L,4L,5L,4L,1L,5L,2L,5L,4L,0L,2L,4L,4L,9L,4L,9L,8L,6L,9L,3L,6L,6L,0L,2L,6L,6L,5L,7L,0L,0L,4L,7L,0L,2L,2L,8L,6L,6L,5L,3L,2L,9L,3L,8L,0L,3L,3L,8L,4L,2L,5L,5L,3L,9L,9L,4L,2L,7L,3L,3L,6L,1L,5L,0L,4L,0L,0L,6L,1L,9L,2L,0L,7L,4L,1L,3L,1L,9L,4L,1L,2L,7L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238239Inst : IEnumerable<long>
{
public static readonly long[] Value=A238239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238239.Bytes);
public long this[int i]=>Value[i];

public static A238239Inst Instance=new A238239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238272
{
public static readonly long[] Value={ 8L,8L,9L,9L,0L,9L,0L,0L,0L,8L,9L,9L,1L,0L,9L,8L,9L,9L,0L,1L,0L,9L,0L,0L,0L,9L,9L,8L,8L,9L,0L,1L,1L,0L,9L,9L,1L,0L,9L,8L,8L,9L,0L,0L,0L,9L,0L,0L,0L,0L,9L,9L,0L,1L,0L,1L,0L,8L,9L,9L,1L,0L,0L,0L,8L,9L,0L,0L,8L,8L,9L,9L,1L,0L,0L,0L,8L,9L,0L,0L,0L,9L,0L,1L,1L,0L,9L,9L,0L,1L,0L,1L,1L,0L,9L,8L,9L,9L,9L,8L,8L,8L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238272Inst : IEnumerable<long>
{
public static readonly long[] Value=A238272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238272.Bytes);
public long this[int i]=>Value[i];

public static A238272Inst Instance=new A238272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238273
{
public static readonly long[] Value={ 7L,1L,2L,6L,6L,3L,1L,8L,2L,2L,6L,4L,2L,8L,3L,4L,5L,7L,1L,2L,1L,6L,0L,4L,1L,6L,8L,3L,2L,1L,8L,6L,1L,2L,5L,0L,6L,0L,5L,3L,0L,7L,0L,2L,1L,7L,4L,7L,1L,6L,1L,3L,6L,9L,0L,7L,0L,3L,5L,0L,5L,0L,6L,3L,2L,9L,5L,5L,5L,6L,6L,1L,2L,1L,0L,4L,4L,7L,0L,6L,1L,4L,3L,6L,4L,1L,1L,4L,6L,2L,7L,0L,5L,9L,4L,3L,6L,2L,7L,6L,2L,1L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238273Inst : IEnumerable<long>
{
public static readonly long[] Value=A238273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238273.Bytes);
public long this[int i]=>Value[i];

public static A238273Inst Instance=new A238273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238274
{
public static readonly long[] Value={ 1L,3L,7L,4L,5L,5L,7L,0L,1L,0L,7L,4L,3L,7L,0L,7L,4L,8L,6L,5L,3L,0L,0L,9L,3L,0L,5L,6L,7L,6L,9L,6L,6L,2L,6L,7L,2L,3L,4L,4L,2L,9L,7L,6L,3L,6L,5L,3L,7L,6L,2L,6L,5L,0L,0L,1L,0L,9L,6L,5L,7L,1L,0L,6L,3L,2L,4L,2L,1L,6L,6L,9L,5L,6L,5L,6L,4L,8L,7L,1L,5L,1L,7L,1L,3L,8L,3L,6L,7L,0L,0L,6L,4L,1L,9L,6L,4L,9L,4L,0L,0L,6L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238274Inst : IEnumerable<long>
{
public static readonly long[] Value=A238274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238274.Bytes);
public long this[int i]=>Value[i];

public static A238274Inst Instance=new A238274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238275
{
public static readonly long[] Value={ 1L,9L,65L,457L,3201L,22409L,156865L,1098057L,7686401L,53804809L,376633665L,2636435657L,18455049601L,129185347209L,904297430465L,6330082013257L,44310574092801L,310174018649609L,2171218130547265L,15198526913830857L,106389688396816001L,744727818777712009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238275Inst : IEnumerable<long>
{
public static readonly long[] Value=A238275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238275.Bytes);
public long this[int i]=>Value[i];

public static A238275Inst Instance=new A238275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238276
{
public static readonly long[] Value={ 1L,10L,82L,658L,5266L,42130L,337042L,2696338L,21570706L,172565650L,1380525202L,11044201618L,88353612946L,706828903570L,5654631228562L,45237049828498L,361896398627986L,2895171189023890L,23161369512191122L,185290956097528978L,1482327648780231826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238276Inst : IEnumerable<long>
{
public static readonly long[] Value=A238276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238276.Bytes);
public long this[int i]=>Value[i];

public static A238276Inst Instance=new A238276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238277
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,3L,1L,3L,2L,4L,1L,5L,3L,3L,10L,11L,8L,7L,10L,6L,13L,11L,13L,8L,12L,10L,8L,7L,7L,6L,4L,5L,5L,6L,3L,4L,7L,3L,7L,7L,8L,7L,7L,9L,8L,12L,8L,5L,12L,11L,14L,11L,14L,11L,8L,11L,9L,9L,13L,12L,5L,14L,15L,12L,15L,12L,15L,14L,15L,16L,13L,10L,18L,20L,12L,7L,17L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238277Inst : IEnumerable<long>
{
public static readonly long[] Value=A238277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238277.Bytes);
public long this[int i]=>Value[i];

public static A238277Inst Instance=new A238277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238278
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,3L,2L,7L,6L,8L,4L,9L,4L,9L,8L,1L,1L,3L,5L,4L,6L,3L,4L,4L,6L,3L,11L,8L,8L,7L,7L,12L,9L,4L,8L,9L,12L,8L,12L,8L,7L,6L,7L,7L,9L,4L,8L,9L,11L,5L,6L,3L,11L,2L,5L,14L,8L,8L,11L,2L,1L,11L,4L,6L,4L,5L,4L,1L,9L,5L,2L,10L,5L,4L,9L,10L,11L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238278Inst : IEnumerable<long>
{
public static readonly long[] Value=A238278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238278.Bytes);
public long this[int i]=>Value[i];

public static A238278Inst Instance=new A238278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238279
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,1L,2L,10L,4L,4L,12L,14L,2L,2L,22L,29L,10L,1L,4L,26L,56L,36L,6L,3L,34L,100L,86L,31L,2L,4L,44L,148L,200L,99L,16L,1L,2L,54L,230L,374L,278L,78L,8L,6L,58L,322L,680L,654L,274L,52L,2L,2L,74L,446L,1122L,1390L,814L,225L,22L,1L,4L,88L,573L,1796L,2714L,2058L,813L,136L,10L,4L,88L,778L,2694L,4927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238279Inst : IEnumerable<long>
{
public static readonly long[] Value=A238279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238279.Bytes);
public long this[int i]=>Value[i];

public static A238279Inst Instance=new A238279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238280
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,1L,1L,3L,0L,3L,4L,4L,1L,4L,2L,5L,2L,2L,3L,6L,0L,4L,6L,7L,5L,4L,3L,7L,5L,6L,3L,7L,2L,6L,8L,4L,2L,6L,5L,9L,2L,3L,5L,9L,4L,3L,5L,6L,4L,8L,2L,6L,4L,5L,7L,6L,1L,5L,7L,8L,1L,5L,4L,8L,6L,2L,4L,8L,3L,7L,4L,5L,3L,7L,6L,5L,3L,4L,6L,10L,0L,5L,8L,10L,9L,9L,3L,8L,7L,9L,7L,12L,2L,7L,10L,7L,6L,11L,5L,10L,4L,6L,9L,14L,4L,4L,7L,9L,8L,13L,2L,7L,6L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238280Inst : IEnumerable<long>
{
public static readonly long[] Value=A238280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238280.Bytes);
public long this[int i]=>Value[i];

public static A238280Inst Instance=new A238280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238281
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,3L,1L,5L,2L,4L,4L,8L,3L,7L,4L,4L,4L,2L,3L,7L,3L,10L,4L,12L,7L,7L,15L,7L,9L,8L,5L,8L,9L,11L,8L,8L,10L,8L,4L,10L,10L,10L,11L,7L,10L,8L,11L,8L,8L,9L,9L,8L,11L,7L,8L,13L,10L,8L,14L,13L,4L,14L,8L,11L,12L,14L,12L,8L,10L,16L,12L,16L,12L,14L,19L,11L,14L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238281Inst : IEnumerable<long>
{
public static readonly long[] Value=A238281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238281.Bytes);
public long this[int i]=>Value[i];

public static A238281Inst Instance=new A238281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238282
{
public static readonly long[] Value={ 16L,204L,1844L,13948L,105862L,850420L,6953993L,56279542L,451637564L,3624058880L,29149448933L,234656231134L,1888292962943L,15189590878387L,122183775722351L,982931386549726L,7907698617955660L,63616689428833346L,511782089100478490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238282Inst : IEnumerable<long>
{
public static readonly long[] Value=A238282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238282.Bytes);
public long this[int i]=>Value[i];

public static A238282Inst Instance=new A238282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238283
{
public static readonly BigInteger[] Value={ 50L,1844L,42084L,737366L,12926271L,245920800L,4810332239L,92790334588L,1767175335274L,33631393265283L,642245437813719L,12282485000914102L,234784249649799771L,4485361687341554225L,BigInteger.Parse("85682498512887615932") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238283Inst Instance=new A238283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238284
{
public static readonly BigInteger[] Value={ 144L,13948L,737366L,27913368L,1058583000L,44441926832L,1931022884277L,82508389421874L,3470891253761820L,145872518046542058L,6155861335428543193L,BigInteger.Parse("260232903353528638680"),BigInteger.Parse("10995149731230961462745"),BigInteger.Parse("464237140754455444786421") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238284Inst Instance=new A238284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238285
{
public static readonly BigInteger[] Value={ 422L,105862L,12926271L,1058583000L,87389474502L,8155057418133L,790756782942944L,75089860262272452L,7004416705370946171L,BigInteger.Parse("653041012099727601632"),BigInteger.Parse("61178043367269083858961"),BigInteger.Parse("5741681272912802081072135") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238285Inst Instance=new A238285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238286
{
public static readonly BigInteger[] Value={ 1268L,850420L,245920800L,44441926832L,8155057418133L,1730677620863096L,383234474966286275L,BigInteger.Parse("82717973078216789142"),BigInteger.Parse("17493177554060762019050"),BigInteger.Parse("3699163393647454115175243"),BigInteger.Parse("786647310980989762790259895") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238286Inst Instance=new A238286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238287
{
public static readonly long[] Value={ 4L,16L,16L,50L,204L,50L,144L,1844L,1844L,144L,422L,13948L,42084L,13948L,422L,1268L,105862L,737366L,737366L,105862L,1268L,3823L,850420L,12926271L,27913368L,12926271L,850420L,3823L,11472L,6953993L,245920800L,1058583000L,1058583000L,245920800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238287Inst : IEnumerable<long>
{
public static readonly long[] Value=A238287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238287.Bytes);
public long this[int i]=>Value[i];

public static A238287Inst Instance=new A238287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238304
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,0L,0L,2L,1L,0L,1L,1L,2L,1L,0L,0L,2L,1L,1L,2L,1L,0L,2L,0L,2L,2L,0L,1L,1L,1L,1L,1L,3L,0L,2L,0L,1L,2L,1L,1L,4L,1L,1L,1L,1L,0L,2L,2L,2L,2L,0L,1L,3L,1L,0L,1L,3L,1L,2L,0L,2L,2L,2L,1L,4L,1L,0L,3L,1L,0L,1L,0L,5L,2L,3L,1L,2L,2L,0L,2L,1L,1L,3L,1L,2L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238304Inst : IEnumerable<long>
{
public static readonly long[] Value=A238304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238304.Bytes);
public long this[int i]=>Value[i];

public static A238304Inst Instance=new A238304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}