using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A068159
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,10L,1L,1L,0L,0L,0L,0L,0L,0L,0L,10L,2L,1L,1L,0L,0L,0L,0L,0L,0L,10L,2L,1L,1L,1L,0L,0L,0L,0L,0L,10L,3L,2L,1L,1L,1L,0L,0L,0L,0L,10L,3L,2L,1L,1L,1L,1L,0L,0L,0L,10L,4L,2L,1L,1L,1L,1L,1L,0L,0L,10L,4L,2L,2L,1L,1L,1L,1L,1L,0L,10L,4L,3L,2L,1L,1L,1L,1L,1L,1L };
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
public class A068159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068159Inst : IEnumerable<long>
{
public static readonly long[] Value=A068159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068159.Bytes);
public long this[int i]=>Value[i];

public static A068159Inst Instance=new A068159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068160
{
public static readonly BigInteger[] Value={ 101L,11311L,1114111L,111181111L,111110611111L,1111118111111L,111111151111111L,111111110911111111L,11111111128111111111UL,BigInteger.Parse("111111111161111111111"),BigInteger.Parse("111111111110911111111111"),BigInteger.Parse("11111111111104111111111111") };
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
public class A068160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068160Inst Instance=new A068160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068161
{
public static readonly BigInteger[] Value={ 3L,33533L,3331333L,3333133333L,333331033333L,33333362333333L,333333313333333L,333333332933333333L,BigInteger.Parse("33333333316333333333"),BigInteger.Parse("3333333333133333333333"),BigInteger.Parse("33333333333733333333333") };
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
public class A068161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068161Inst Instance=new A068161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068162
{
public static readonly BigInteger[] Value={ 727L,77377L,7772777L,777767777L,77777677777L,7777774777777L,777777727777777L,77777777677777777L,BigInteger.Parse("77777777704777777777"),BigInteger.Parse("777777777727777777777"),BigInteger.Parse("77777777777677777777777"),BigInteger.Parse("7777777777772777777777777"),BigInteger.Parse("777777777777757777777777777") };
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
public class A068162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068162Inst Instance=new A068162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068163
{
public static readonly BigInteger[] Value={ 919L,990599L,99901999L,9999049999L,99999199999L,99999901999999L,9999999239999999L,99999999299999999L,9999999992999999999UL,BigInteger.Parse("9999999999049999999999"),BigInteger.Parse("999999999990599999999999"),BigInteger.Parse("99999999999904999999999999") };
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
public class A068163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068163Inst Instance=new A068163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068244
{
public static readonly long[] Value={ 1L,176L,5490L,65600L,455875L,2239776L,8647716L,27962880L,78920325L,200002000L,464447126L,1003294656L,2039332295L,3935444800L,7261533000L,12884914176L,22089914121L,36733221360L,59442494650L,93866696000L,144987663051L,219503536736L,326295822700L,476993088000L };
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
public class A068244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068244Inst : IEnumerable<long>
{
public static readonly long[] Value=A068244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068244.Bytes);
public long this[int i]=>Value[i];

public static A068244Inst Instance=new A068244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068245
{
public static readonly long[] Value={ 1L,7616L,5141250L,552093440L,20631905875L,395001645696L,4771909547076L,41190314035200L,275192443300005L,1502690499112000L,6971521964029766L,28275884687022336L,102456840191225975L,337289521082456320L,1022310183284613000L,2883605488481550336L,7636012822945480521L };
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
public class A068245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068245Inst : IEnumerable<long>
{
public static readonly long[] Value=A068245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068245.Bytes);
public long this[int i]=>Value[i];

public static A068245Inst Instance=new A068245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068246
{
public static readonly BigInteger[] Value={ 1L,672384L,24673292910L,47694893373440L,16222878355401375L,1842996126472816896L,BigInteger.Parse("98798500424990038764"),BigInteger.Parse("3068393771393664491520"),BigInteger.Parse("62960689342002146953005"),BigInteger.Parse("933100311834971308336000"),BigInteger.Parse("10639781338324232990590266"),BigInteger.Parse("97779035968707368095801344"),BigInteger.Parse("750090455889142956720814955") };
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
public class A068246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068246Inst Instance=new A068246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068247
{
public static readonly BigInteger[] Value={ 1L,123273728L,606966551329230L,BigInteger.Parse("42294602754348892160"),BigInteger.Parse("221621345837018832499375"),BigInteger.Parse("227499859288036192921814016"),BigInteger.Parse("76749554391225308000690033388"),BigInteger.Parse("11559255542512176814494743592960"),BigInteger.Parse("945121787128699657370828476884045"),BigInteger.Parse("47886238054762718784097603771840000") };
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
public class A068247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068247Inst Instance=new A068247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068248
{
public static readonly BigInteger[] Value={ 1L,673072L,24674450670L,47695073906240L,16222886703881375L,1842996310592836896L,BigInteger.Parse("98798502888215704812"),BigInteger.Parse("3068393794369671728640"),BigInteger.Parse("62960689505171989129005"),BigInteger.Parse("933100312771109288146000"),BigInteger.Parse("10639781342848431789710266"),BigInteger.Parse("97779035987698387480546752"),BigInteger.Parse("750090455960001686602653035") };
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
public class A068248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068248Inst Instance=new A068248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068249
{
public static readonly BigInteger[] Value={ 1L,123933504L,607054532700510L,BigInteger.Parse("42295002762341131520"),BigInteger.Parse("221621606435023540827375"),BigInteger.Parse("227499908955471802467974016"),BigInteger.Parse("76749558468512064584917217484"),BigInteger.Parse("11559255724071428199019433809920"),BigInteger.Parse("945121792213234612017996840421965"),BigInteger.Parse("47886238153764555711259823337784000") };
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
public class A068249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068249Inst Instance=new A068249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068250
{
public static readonly long[] Value={ 3L,280L,5265L,47040L,271250L,1170288L,4105710L,12334080L,32837805L,79365000L,177200023L,370319040L,731732820L,1377981920L,2488927500L,4334174208L,7307669895L,11972250360L,19116135885L,29823640000L,45562619718L,68291480400L,100588847450L,145809331200L };
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
public class A068250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068250Inst : IEnumerable<long>
{
public static readonly long[] Value=A068250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068250.Bytes);
public long this[int i]=>Value[i];

public static A068250Inst Instance=new A068250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068251
{
public static readonly long[] Value={ 7L,38960L,11043135L,715016960L,19498281250L,301435761312L,3120392830170L,23965758136320L,146127409139745L,741378459250000L,3237913809747617L,12485709312410880L,43342515673364180L,137520873034108480L,403684061693062500L,1107133265664540672L,2859892150083272715L };
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
public class A068251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068251Inst : IEnumerable<long>
{
public static readonly long[] Value=A068251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068251.Bytes);
public long this[int i]=>Value[i];

public static A068251Inst Instance=new A068251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068252
{
public static readonly BigInteger[] Value={ 15L,13544240L,138446293905L,122914516488960L,25999554922206250L,2153128175383358880L,BigInteger.Parse("92188903926678792030"),BigInteger.Parse("2420834781123276840960"),BigInteger.Parse("43619102772258066624945"),BigInteger.Parse("582825001391348708850000"),BigInteger.Parse("6107144216640392108077895"),BigInteger.Parse("52317129545418639168933120") };
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
public class A068252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068252Inst Instance=new A068252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068253
{
public static readonly BigInteger[] Value={ 1L,6L,82L,2604L,193662L,33865632L,13956665236L,13574876544396L,31191658416342674L,BigInteger.Parse("169426507164530254380"),BigInteger.Parse("2176592549084872196370724"),BigInteger.Parse("66158464020552857153017287240"),BigInteger.Parse("4759146677426447759184119036493676"),BigInteger.Parse("810410082813497381147177065840601910384") };
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
public class A068253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068253Inst Instance=new A068253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068254
{
public static readonly BigInteger[] Value={ 1L,21L,2403L,1500183L,5110723191L,95013316876491L,9639473169171326643UL,BigInteger.Parse("5336900216006709884938623"),BigInteger.Parse("16124704040675904181778734982451"),BigInteger.Parse("265865038636937159336134567410478299051") };
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
public class A068254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068254Inst Instance=new A068254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068255
{
public static readonly BigInteger[] Value={ 1L,52L,28564L,165770032L,10164078082036L,6584229526795818280L,BigInteger.Parse("45062665956031451017237456"),BigInteger.Parse("3258395057698765483724093981321824"),BigInteger.Parse("2489232886416012985921659124731697904597044"),BigInteger.Parse("20091032492258710696689787524926465967570325433558752") };
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
public class A068255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068255Inst Instance=new A068255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068256
{
public static readonly BigInteger[] Value={ 1L,105L,194485L,6354787485L,3662978221194885L,BigInteger.Parse("37246546285522069805565"),BigInteger.Parse("6681224184095576349599961437005"),BigInteger.Parse("21141920893108925844961568245788270386085"),BigInteger.Parse("1180188030501408210062775052100916976604905321333565"),BigInteger.Parse("1162187850685436026547128866816039344195930156602955871508107885") };
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
public class A068256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068256Inst Instance=new A068256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068257
{
public static readonly BigInteger[] Value={ 1L,186L,923526L,122408393436L,433110977725751106L,BigInteger.Parse("40908457493732914322944536"),BigInteger.Parse("103146129375410533061371714364918916"),BigInteger.Parse("6942544711174164051575906086886643368922134556"),BigInteger.Parse("12474132532762777585883439690925675118905860580968258566406") };
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
public class A068257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068257Inst Instance=new A068257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068258
{
public static readonly BigInteger[] Value={ 1L,301L,3418807L,1465295106499L,BigInteger.Parse("23698346512668445387"),BigInteger.Parse("14462834689097706163375677127"),BigInteger.Parse("333066712033498255371201983520013525951"),BigInteger.Parse("289435280548175417311368841643540798029239265418611"),BigInteger.Parse("9491047284937011500293532002379383630495589849878668222747216079") };
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
public class A068258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068258Inst Instance=new A068258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068259
{
public static readonly BigInteger[] Value={ 1L,456L,10556008L,12405232610688L,BigInteger.Parse("740083033797732630216"),BigInteger.Parse("2241435875640746831506090496496"),BigInteger.Parse("344621623364019594715666338046505649098368"),BigInteger.Parse("2689856201334666341950387692094152693428585565204907488"),BigInteger.Parse("1065825084866806867830786487316472449826266534389338451645760215077416") };
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
public class A068259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068259Inst Instance=new A068259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068276
{
public static readonly BigInteger[] Value={ 1L,392L,5765144L,3181273031384L,BigInteger.Parse("65865666949993359176"),BigInteger.Parse("51166369594150205333793355592"),BigInteger.Parse("1491342760953091009621584639091222226600"),BigInteger.Parse("1630938910749494351643174313469316936138973479205208") };
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
public class A068276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068276Inst Instance=new A068276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068277
{
public static readonly BigInteger[] Value={ 1L,576L,16777728L,24714188421120L,BigInteger.Parse("1841036262836198694912"),BigInteger.Parse("6935553325507306088696846155776"),BigInteger.Parse("1321303757030716925589852391986906706673664"),BigInteger.Parse("12729959052897370321435414735439044407648771577838567424") };
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
public class A068277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068277Inst Instance=new A068277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068278
{
public static readonly BigInteger[] Value={ 1L,810L,43047450L,150104969072730L,BigInteger.Parse("34342194186546625610730"),BigInteger.Parse("515520974797472540384088260118570"),BigInteger.Parse("507750044609844563320250272016778947097815370"),BigInteger.Parse("32812470510724769634930013386228840033573943730279978702970") };
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
public class A068278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068278Inst Instance=new A068278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068279
{
public static readonly BigInteger[] Value={ 1L,1100L,100001000L,751345249556000L,BigInteger.Parse("466550155917485654168000"),BigInteger.Parse("23943119027381359392048801885920000"),BigInteger.Parse("101551583948290437017941221055210389140843072000"),BigInteger.Parse("35597235390075660655078813076577627044739757882304090775296000") };
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
public class A068279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068279Inst Instance=new A068279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068280
{
public static readonly BigInteger[] Value={ 1L,1452L,214360212L,3217625521859892L,BigInteger.Parse("4910668309995799841810892"),BigInteger.Parse("762007921240709867578673020749884172"),BigInteger.Parse("12022427131636998562079732651101772918046821260092"),BigInteger.Parse("19285841951971298297383495940474744273219471204301574972512789012") };
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
public class A068280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068280Inst Instance=new A068280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068281
{
public static readonly BigInteger[] Value={ 1L,1872L,429983424L,12118236294438144L,BigInteger.Parse("41905301129446014898200576"),BigInteger.Parse("17780352279236011016040115376770056192"),BigInteger.Parse("925664488474756221142848128240158691162017819238400"),BigInteger.Parse("5913011057048168843456253932545740404857450278470215562237034528768") };
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
public class A068281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068281Inst Instance=new A068281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068282
{
public static readonly BigInteger[] Value={ 1L,2366L,815732918L,40982736076490390L,BigInteger.Parse("300036182355657182688325982"),BigInteger.Parse("320085523640263850036240170626275000126"),BigInteger.Parse("49759746073476452859128357237174600753071750263576974"),BigInteger.Parse("1127223407032446992094203888014898257130328919220827996504247743755014") };
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
public class A068282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068282Inst Instance=new A068282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068283
{
public static readonly long[] Value={ 1L,12L,264L,11424L,1009608L,185900256L,71883991272L,58646051219616L,101273697848025960L };
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
public class A068283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068283Inst : IEnumerable<long>
{
public static readonly long[] Value=A068283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068283.Bytes);
public long this[int i]=>Value[i];

public static A068283Inst Instance=new A068283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068284
{
public static readonly BigInteger[] Value={ 1L,36L,6588L,6169500L,29609340804L,728465439240612L,BigInteger.Parse("91873868538291559236"),BigInteger.Parse("59398217444060775978706980"),BigInteger.Parse("196856852524443536659406407297548") };
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
public class A068284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068284Inst Instance=new A068284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068285
{
public static readonly BigInteger[] Value={ 1L,80L,65600L,552093440L,47695073906240L,BigInteger.Parse("42295002762341131520"),BigInteger.Parse("384997602083152626170331200"),BigInteger.Parse("35973286295593063089098993201626880"),BigInteger.Parse("34502872879799250159432202960093141227521600") };
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
public class A068285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068285.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068285Inst Instance=new A068285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068286
{
public static readonly BigInteger[] Value={ 1L,150L,390750L,17684490750L,13905331460469750L,BigInteger.Parse("189961376944305892137750"),BigInteger.Parse("45086270412704540409445089549750"),BigInteger.Parse("185916670055945278226619825124072763091750"),BigInteger.Parse("13319483009963134380534870853035913218901916338644750") };
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
public class A068286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068286Inst Instance=new A068286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068287
{
public static readonly BigInteger[] Value={ 1L,252L,1679832L,296251234272L,1382247232944627672L,BigInteger.Parse("170624931716603851850980512"),BigInteger.Parse("557224793178655263880694805929352312"),BigInteger.Parse("48144818121088035723665058177874441292104576992"),BigInteger.Parse("110052483236400191824645806778218519319800722550874233268152") };
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
public class A068287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068287Inst Instance=new A068287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068288
{
public static readonly BigInteger[] Value={ 1L,392L,5765144L,3181273031384L,BigInteger.Parse("65865668592143803208"),BigInteger.Parse("51166372312341376389944811656"),BigInteger.Parse("1491342882335672198457853495232503998152"),BigInteger.Parse("1630939089590623060636571472516037785233254346536136"),BigInteger.Parse("66921448813902442793929754551432219305219935812987218443538247160") };
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
public class A068288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068288Inst Instance=new A068288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068289
{
public static readonly BigInteger[] Value={ 1L,576L,16777728L,24714188421120L,BigInteger.Parse("1841036276621803037184"),BigInteger.Parse("6935553434442856919411660285952"),BigInteger.Parse("1321303788659476737000614691012213371920896"),BigInteger.Parse("12729959462391097361772684882480600791246770039196989440"),BigInteger.Parse("6202319628516337592369784708824005819049596658116953675819712797024768") };
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
public class A068289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068289Inst Instance=new A068289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068290
{
public static readonly BigInteger[] Value={ 1L,2940L,1475791800L,126483570405921120L,BigInteger.Parse("1850863560812354903891313720"),BigInteger.Parse("4624299555529247811516226596312142467360"),BigInteger.Parse("1972644284777133055191294794721562929045198175857072600"),BigInteger.Parse("143675548262637787606663854942059513336275448208739220399687693160870240") };
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
public class A068290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068290Inst Instance=new A068290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068291
{
public static readonly BigInteger[] Value={ 1L,3600L,2562894000L,360815358806334000L,BigInteger.Parse("10045362602062958738692122000"),BigInteger.Parse("55306025603886596990726445398427484458000"),BigInteger.Parse("60215114062840644498765447997163170597224027734057082000"),BigInteger.Parse("12964769707834768710147648104687020983960635308403660120749080257740506000") };
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
public class A068291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068291Inst Instance=new A068291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068292
{
public static readonly BigInteger[] Value={ 1L,4352L,4294971392L,961201829493850112L,BigInteger.Parse("48781126844255370222607142912"),BigInteger.Parse("561399464545957024370182236743498291167232"),BigInteger.Parse("1465126373454769055363011684465705776628549543645731295232"),BigInteger.Parse("867083863998912174882104147806181674429733314821142479758142332970286825472") };
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
public class A068292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068292Inst Instance=new A068292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068293
{
public static readonly long[] Value={ 1L,6L,18L,42L,90L,186L,378L,762L,1530L,3066L,6138L,12282L,24570L,49146L,98298L,196602L,393210L,786426L,1572858L,3145722L,6291450L,12582906L,25165818L,50331642L,100663290L,201326586L,402653178L,805306362L,1610612730L,3221225466L,6442450938L,12884901882L };
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
public class A068293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068293Inst : IEnumerable<long>
{
public static readonly long[] Value=A068293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068293.Bytes);
public long this[int i]=>Value[i];

public static A068293Inst Instance=new A068293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068294
{
public static readonly BigInteger[] Value={ 1L,24L,1344L,187008L,65012352L,56638464768L,123968096842368L,682463815024774272L,BigInteger.Parse("9455897825697924931968"),BigInteger.Parse("329835949030491781985964672"),BigInteger.Parse("28967729014957963606903092579840"),BigInteger.Parse("6405563550899359667890368716213003520"),BigInteger.Parse("3566277295414164369700428069692324488565760"),BigInteger.Parse("4998812913455162820842387241261713638306330756608") };
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
public class A068294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068294Inst Instance=new A068294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068295
{
public static readonly BigInteger[] Value={ 1L,60L,21060L,44172540L,553785175620L,41503847098683420L,BigInteger.Parse("18595665812583520041060"),BigInteger.Parse("49808667823922052573513153300"),BigInteger.Parse("797553247913411612275102392386088300"),BigInteger.Parse("76343133584713932892876357250654965547341140"),BigInteger.Parse("43684986787209742051887297631700585399912369700067860") };
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
public class A068295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068295Inst Instance=new A068295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068296
{
public static readonly BigInteger[] Value={ 1L,120L,161280L,2451486720L,421421199390720L,BigInteger.Parse("819296954885530030080"),BigInteger.Parse("18013654371239090908333148160"),BigInteger.Parse("4479149596637688119857975807616194560"),BigInteger.Parse("12595676735919821000208123310178819903753287680"),BigInteger.Parse("400570738126155220679966449710339235598075113573822617600") };
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
public class A068296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068296Inst Instance=new A068296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068297
{
public static readonly BigInteger[] Value={ 1L,210L,813750L,58494843750L,77998664766618750L,BigInteger.Parse("1929292299321647690193750"),BigInteger.Parse("885215793907124317300191394818750"),BigInteger.Parse("7534251364260636630211044759506294857668750") };
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
public class A068297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068297Inst Instance=new A068297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068298
{
public static readonly BigInteger[] Value={ 1L,336L,3120768L,803828696832L,5741675134355623680L,BigInteger.Parse("1137328489147110235271041536"),BigInteger.Parse("6247483084664157761011047760647844608"),BigInteger.Parse("951691164013203510495082805169876313498509196032") };
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
public class A068298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068298Inst Instance=new A068298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068299
{
public static readonly BigInteger[] Value={ 1L,504L,9853704L,7488942792408L,BigInteger.Parse("221253369424029100872"),BigInteger.Parse("254101505958294674877998194968"),BigInteger.Parse("11344162587174574603922830864958174183688"),BigInteger.Parse("19687269229964173171963421211996119947570831281276072") };
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
public class A068299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068299Inst Instance=new A068299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068300
{
public static readonly BigInteger[] Value={ 1L,720L,26910720L,52288926842880L,BigInteger.Parse("5281821340632604016640"),BigInteger.Parse("27736206226949123988070609059840"),BigInteger.Parse("7571810592000511584502349629565976352849920"),BigInteger.Parse("107458741981038717371365660998262273071288547237109760000") };
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
public class A068300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068300Inst Instance=new A068300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068301
{
public static readonly BigInteger[] Value={ 1L,990L,65675610L,292254818279490L,BigInteger.Parse("87238205544516133249890"),BigInteger.Parse("1746783780641161331912282302353810"),BigInteger.Parse("2346167125778415534349931707837063900925570370"),BigInteger.Parse("211381076411597878243848286563025939634200193105055412862370") };
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
public class A068301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068301Inst Instance=new A068301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068302
{
public static readonly BigInteger[] Value={ 1L,1320L,146520000L,1368698694000000L,BigInteger.Parse("1075984617953259154800000"),BigInteger.Parse("71185491858527630409715040263200000"),BigInteger.Parse("396336553255260873925931533264339353950473200000"),BigInteger.Parse("185705162149755607151153966767311643039842133737264420356400000") };
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
public class A068302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068302Inst Instance=new A068302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068303
{
public static readonly BigInteger[] Value={ 1L,1716L,303771468L,5550709388138772L,BigInteger.Parse("10469390085669243613847820"),BigInteger.Parse("2038288377309848857407579410051499636"),BigInteger.Parse("40962006853292026329447493002836988654168890167788"),BigInteger.Parse("84970500229420999013828420742335437041383054287385138553076248252") };
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
public class A068303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068303Inst Instance=new A068303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068304
{
public static readonly BigInteger[] Value={ 1L,2184L,592510464L,19977134899857408L,BigInteger.Parse("83707407272669822670292992"),BigInteger.Parse("43590120924896822733942257303419219968"),BigInteger.Parse("2821017309275220614373517914989957826683223925291008"),BigInteger.Parse("22689081840779777447950160850969786755578939429093239677401474639872") };
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
public class A068304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068304Inst Instance=new A068304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068305
{
public static readonly BigInteger[] Value={ 1L,2730L,1097599230L,65013773510046270L,BigInteger.Parse("567344965666217922692546310"),BigInteger.Parse("729405912578031916581095228654013174510"),BigInteger.Parse("138156586653036397048665899068285784224754055444205830"),BigInteger.Parse("3855264256604335001270711977271948484283006596889356139648293174199350") };
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
public class A068305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068305Inst Instance=new A068305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068306
{
public static readonly long[] Value={ 4L,8L,12L,16L,18L,20L,24L,27L,32L,36L,40L,48L,54L,56L,64L,72L,80L,81L,88L,96L,104L,108L,112L,128L,14L,4L,160L,162L,176L,192L,208L,216L,224L,243L,256L,272L,288L,304L,320L,324L,352L,368L,384L,416L,43L,2L,448L,464L,486L,512L,544L,576L,608L,640L,704L,729L,736L,768L,832L };
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
public class A068306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068306Inst : IEnumerable<long>
{
public static readonly long[] Value=A068306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068306.Bytes);
public long this[int i]=>Value[i];

public static A068306Inst Instance=new A068306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068307
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,2L,2L,2L,1L,3L,2L,4L,2L,3L,2L,5L,2L,5L,3L,5L,3L,7L,3L,7L,2L,6L,3L,9L,2L,8L,4L,9L,4L,10L,2L,11L,3L,10L,4L,12L,3L,13L,4L,12L,5L,15L,4L,16L,3L,14L,5L,17L,3L,16L,4L,16L,6L,19L,3L,21L,5L,20L,6L,20L,2L,22L,5L,21L,6L,22L,5L,28L,5L,24L,7L };
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
public class A068307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068307Inst : IEnumerable<long>
{
public static readonly long[] Value=A068307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068307.Bytes);
public long this[int i]=>Value[i];

public static A068307Inst Instance=new A068307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068740
{
public static readonly long[] Value={ 1L,1L,3L,833712928048000000L };
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
public class A068740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068740Inst : IEnumerable<long>
{
public static readonly long[] Value=A068740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068740.Bytes);
public long this[int i]=>Value[i];

public static A068740Inst Instance=new A068740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068741
{
public static readonly BigInteger[] Value={ 1L,1L,24L,BigInteger.Parse("10888869450418352160768000000") };
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
public class A068741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068741Inst Instance=new A068741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068742
{
public static readonly BigInteger[] Value={ 1L,1L,8L,13060694016L,BigInteger.Parse("2079483819621516594237312893208982470178235671604741236585936787960152492743230443701290222268785125031295963705114624") };
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
public class A068742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068742Inst Instance=new A068742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068743
{
public static readonly long[] Value={ 0L,1L,2L,11L,3L,21L,111L,4L,22L,31L,211L,1111L,5L,32L,41L,221L,311L,2111L,11111L,6L,33L,42L,51L,222L,321L,411L,2211L,3111L,21111L,111111L,7L,43L,52L,61L,322L,331L,421L,511L,2221L,3211L,4111L,22111L,31111L,211111L,1111111L,8L,44L,53L,62L,71L,332L,422L,431L,521L };
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
public class A068743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068743Inst : IEnumerable<long>
{
public static readonly long[] Value=A068743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068743.Bytes);
public long this[int i]=>Value[i];

public static A068743Inst Instance=new A068743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068744
{
public static readonly long[] Value={ 1L,1665L,87825L,1253329L,9230193L,45642289L,172989921L,542131425L,1473095713L,3582226465L,7970825457L,16492629297L,32119620625L,59427841617L,105227044417L,179360179905L,295700892993L,473379359425L,738268965841L };
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
public class A068744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068744Inst : IEnumerable<long>
{
public static readonly long[] Value=A068744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068744.Bytes);
public long this[int i]=>Value[i];

public static A068744Inst Instance=new A068744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068745
{
public static readonly long[] Value={ 1L,690437L,1133641543L,164185416899L,6913624013061L,138190481342321L,1678843050246451L,14285299502131463L,93044501704039945L,492225938556374973L,2204710243834695807L,8617480381892283531L };
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
public class A068745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068745Inst : IEnumerable<long>
{
public static readonly long[] Value=A068745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068745.Bytes);
public long this[int i]=>Value[i];

public static A068745Inst Instance=new A068745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068746
{
public static readonly BigInteger[] Value={ 1L,1366395515L,184422574177355L,523957519578572209L,BigInteger.Parse("207345516734034667209"),BigInteger.Parse("24953087551680958151267"),BigInteger.Parse("1354915464537160758459123") };
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
public class A068746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068746Inst Instance=new A068746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068747
{
public static readonly BigInteger[] Value={ 1L,12961320464027L,BigInteger.Parse("379827509377146575439"),BigInteger.Parse("40918963843906494595507077") };
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
public class A068747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068747Inst Instance=new A068747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068748
{
public static readonly BigInteger[] Value={ 1L,19L,1665L,690437L,1366395515L,12961320464027L,590771311004409091L,BigInteger.Parse("129585582154154757804255"),BigInteger.Parse("136932044780329080616264070553"),BigInteger.Parse("697547669137459516115242710064880165") };
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
public class A068748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068748Inst Instance=new A068748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068749
{
public static readonly BigInteger[] Value={ 1L,85L,87825L,1133641543L,184422574177355L,BigInteger.Parse("379827509377146575439"),BigInteger.Parse("9928923943603018785634645661") };
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
public class A068749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068749Inst Instance=new A068749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068750
{
public static readonly BigInteger[] Value={ 1L,231L,1253329L,164185416899L,523957519578572209L,BigInteger.Parse("40918963843906494595507077") };
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
public class A068750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068750Inst Instance=new A068750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068751
{
public static readonly BigInteger[] Value={ 1L,489L,9230193L,6913624013061L,BigInteger.Parse("207345516734034667209") };
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
public class A068751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068751Inst Instance=new A068751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068752
{
public static readonly BigInteger[] Value={ 1L,891L,45642289L,138190481342321L,BigInteger.Parse("24953087551680958151267") };
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
public class A068752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068752Inst Instance=new A068752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068753
{
public static readonly BigInteger[] Value={ 1L,1469L,172989921L,1678843050246451L,BigInteger.Parse("1354915464537160758459123") };
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
public class A068753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068753Inst Instance=new A068753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068754
{
public static readonly long[] Value={ 1L,2255L,542131425L,14285299502131463L };
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
public class A068754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068754Inst : IEnumerable<long>
{
public static readonly long[] Value=A068754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068754.Bytes);
public long this[int i]=>Value[i];

public static A068754Inst Instance=new A068754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068755
{
public static readonly long[] Value={ 1L,3281L,1473095713L,93044501704039945L };
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
public class A068755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068755Inst : IEnumerable<long>
{
public static readonly long[] Value=A068755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068755.Bytes);
public long this[int i]=>Value[i];

public static A068755Inst Instance=new A068755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068900
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,121L,132L,143L,154L,165L,176L,187L,198L,231L,242L,253L,264L,275L,286L,297L,341L,352L,363L,374L,385L,396L,451L,462L,473L,484L,495L,561L,572L,583L,594L,671L,682L,693L,781L,792L,891L,1111L,1122L,1133L,1144L,1155L,1166L };
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
public class A068900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068900Inst : IEnumerable<long>
{
public static readonly long[] Value=A068900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068900.Bytes);
public long this[int i]=>Value[i];

public static A068900Inst Instance=new A068900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068901
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,5L,4L,5L,4L,1L,2L,11L,11L,13L,13L,11L,9L,11L,9L,9L,11L,9L,9L,7L,3L,3L,5L,5L,7L,7L,28L,29L,28L,31L,26L,29L,28L,27L,28L,27L,26L,29L,24L,27L,28L,31L,24L,17L,18L,21L,22L,21L,24L,19L,18L,17L,16L,19L,18L,19L,22L,17L,8L,9L,12L,13L,4L,3L,67L,1L };
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
public class A068901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068901Inst : IEnumerable<long>
{
public static readonly long[] Value=A068901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068901.Bytes);
public long this[int i]=>Value[i];

public static A068901Inst Instance=new A068901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068902
{
public static readonly long[] Value={ 2L,4L,6L,8L,15L,18L,21L,24L,27L,30L,33L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,155L,160L,165L,170L,175L,180L,185L,190L,195L,200L,205L,210L,215L,220L,225L,230L,235L,240L,245L,250L,255L,260L };
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
public class A068902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068902Inst : IEnumerable<long>
{
public static readonly long[] Value=A068902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068902.Bytes);
public long this[int i]=>Value[i];

public static A068902Inst Instance=new A068902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068903
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,6L,2L,4L,3L,6L,2L,15L,2L,6L,6L,5L,2L,15L,2L,15L,6L,6L,2L,28L,3L,6L,4L,15L,2L,56L,2L,6L,6L,6L,6L,36L,2L,6L,6L,28L,2L,56L,2L,15L,15L,6L,2L,45L,3L,15L,6L,15L,2L,28L,6L,28L,6L,6L,2L,220L,2L,6L,15L,7L,6L,56L,2L,15L,6L,56L,2L,66L,2L,6L,15L,15L,6L,56L };
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
public class A068903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068903Inst : IEnumerable<long>
{
public static readonly long[] Value=A068903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068903.Bytes);
public long this[int i]=>Value[i];

public static A068903Inst Instance=new A068903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068904
{
public static readonly long[] Value={ 1L,3L,6L,35L,15L,495L,28L,1365L,286L,3060L,66L,376740L,91L,10626L,10626L,169911L,153L,3262623L,190L,5245786L,35960L,58905L,276L,2558620845L,4495L,111930L,91390L,32468436L,435L,11969016345L,496L,67945521L,194580L,316251L,194580L,783768050065L,703L,487635L };
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
public class A068904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068904Inst : IEnumerable<long>
{
public static readonly long[] Value=A068904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068904.Bytes);
public long this[int i]=>Value[i];

public static A068904Inst Instance=new A068904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068905
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,66L,8L,15L,13L,153L,12L,378L,14L,276L,276L,31L,18L,741L,20L,861L,496L,630L,24L,1770L,31L,861L,40L,1540L,30L,59640L,32L,63L,1128L,1431L,1128L,4095L,38L,1770L,1540L,4005L,42L,142880L,44L,3486L,3003L,2556L,48L,7626L };
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
public class A068905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068905Inst : IEnumerable<long>
{
public static readonly long[] Value=A068905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068905.Bytes);
public long this[int i]=>Value[i];

public static A068905Inst Instance=new A068905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068906
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,2L,1L,0L,1L,0L,2L,1L,0L,1L,2L,3L,2L,1L,0L,1L,1L,1L,3L,2L,1L,0L,1L,2L,3L,0L,3L,2L,1L,0L,0L,0L,3L,2L,5L,3L,2L,1L,0L,0L,1L,3L,1L,1L,5L,3L,2L,1L,0L,0L,0L,2L,0L,5L,0L,5L,3L,2L,1L,0L,0L,0L,2L,2L,3L,4L,7L,5L,3L,2L,1L,0L,1L,2L,2L,0L,4L,1L,3L,7L,5L,3L,2L,1L,0L,1L,2L,0L,2L,0L,1L,7L,2L,7L,5L,3L,2L,1L };
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
public class A068906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068906Inst : IEnumerable<long>
{
public static readonly long[] Value=A068906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068906.Bytes);
public long this[int i]=>Value[i];

public static A068906Inst Instance=new A068906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068907
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,1L,2L,0L,1L,0L,0L,2L,2L,2L,0L,2L,0L,0L,1L,1L,0L,0L,0L,1L,0L,2L,0L,1L,1L,2L,0L,2L,0L,0L,1L,0L,1L,1L,2L,0L,0L,0L,2L,0L,1L,1L,0L,2L,0L,2L,1L,0L,0L,0L,1L,1L,2L,0L,2L,1L,2L,0L,1L,0L,1L,2L,2L,2L,0L,2L,0L,0L,1L,1L,2L,0L,2L,1L,2L,2L,0L,1L,1L,2L,2L,2L,1L,2L,0L,1L,2L,1L,2L,2L,2L,1L,2L,0L,1L,1L,1L,2L,0L,2L,0L };
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
public class A068907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068907Inst : IEnumerable<long>
{
public static readonly long[] Value=A068907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068907.Bytes);
public long this[int i]=>Value[i];

public static A068907Inst Instance=new A068907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068908
{
public static readonly long[] Value={ 1L,1L,2L,3L,0L,2L,1L,0L,2L,0L,2L,1L,2L,1L,0L,1L,1L,2L,0L,0L,2L,2L,2L,0L,0L,3L,1L,0L,3L,0L,4L,2L,4L,3L,0L,3L,2L,2L,0L,0L,3L,3L,4L,1L,0L,4L,3L,4L,3L,0L,1L,3L,4L,1L,0L,1L,3L,4L,0L,0L,2L,0L,1L,4L,0L,3L,0L,4L,0L,0L,3L,0L,3L,4L,0L,4L,1L,3L,4L,0L,1L,2L,0L,4L,0L,2L,2L,3L,4L,0L,3L,4L,2L,2L,0L,4L,4L,0L,1L,0L,2L,1L,4L,0L,0L };
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
public class A068908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068908Inst : IEnumerable<long>
{
public static readonly long[] Value=A068908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068908.Bytes);
public long this[int i]=>Value[i];

public static A068908Inst Instance=new A068908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068909
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,0L,4L,1L,1L,2L,0L,0L,0L,3L,2L,1L,0L,3L,0L,0L,4L,1L,1L,2L,0L,5L,0L,0L,1L,1L,4L,3L,5L,0L,4L,1L,1L,0L,3L,0L,0L,0L,2L,2L,2L,3L,5L,0L,0L,2L,1L,4L,0L,0L,0L,0L,3L,2L,2L,3L,5L,0L,4L,2L,2L,2L,3L,5L,0L,4L,3L,2L,4L,6L,5L,0L,0L,2L,2L,4L,3L,5L,0L,0L,3L,3L,6L,6L,3L,0L,1L,3L,3L,4L,3L,5L,0L,0L,4L,3L,4L,6L,5L,0L,1L };
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
public class A068909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068909Inst : IEnumerable<long>
{
public static readonly long[] Value=A068909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068909.Bytes);
public long this[int i]=>Value[i];

public static A068909Inst Instance=new A068909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068910
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,10L,100L,120L,130L,140L,1000L,10000L,10100L,10200L,10300L,10400L,100000L,1000000L,1001000L,1002000L,1003000L,1004000L,10000000L,100000000L,100010000L,100020000L,100030000L,100040000L,1000000000L,10000000000L };
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
public class A068910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068910Inst : IEnumerable<long>
{
public static readonly long[] Value=A068910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068910.Bytes);
public long this[int i]=>Value[i];

public static A068910Inst Instance=new A068910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068911
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,18L,36L,54L,108L,162L,324L,486L,972L,1458L,2916L,4374L,8748L,13122L,26244L,39366L,78732L,118098L,236196L,354294L,708588L,1062882L,2125764L,3188646L,6377292L,9565938L,19131876L,28697814L,57395628L,86093442L,172186884L };
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
public class A068911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068911Inst : IEnumerable<long>
{
public static readonly long[] Value=A068911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068911.Bytes);
public long this[int i]=>Value[i];

public static A068911Inst Instance=new A068911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068912
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,28L,48L,96L,164L,328L,560L,1120L,1912L,3824L,6528L,13056L,22288L,44576L,76096L,152192L,259808L,519616L,887040L,1774080L,3028544L,6057088L,10340096L,20680192L,35303296L,70606592L,120532992L,241065984L,411525376L,823050752L,1405035520L,2810071040L };
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
public class A068912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068912Inst : IEnumerable<long>
{
public static readonly long[] Value=A068912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068912.Bytes);
public long this[int i]=>Value[i];

public static A068912Inst Instance=new A068912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068913
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,2L,2L,1L,0L,4L,4L,2L,1L,0L,4L,6L,4L,2L,1L,0L,8L,12L,8L,4L,2L,1L,0L,8L,18L,14L,8L,4L,2L,1L,0L,16L,36L,28L,16L,8L,4L,2L,1L,0L,16L,54L,48L,30L,16L,8L,4L,2L,1L,0L,32L,108L,96L,60L,32L,16L,8L,4L,2L,1L,0L,32L,162L,164L,110L,62L,32L,16L,8L,4L,2L,1L,0L,64L,324L,328L,220L,124L,64L,32L,16L,8L,4L,2L,1L };
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
public class A068913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068913Inst : IEnumerable<long>
{
public static readonly long[] Value=A068913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068913.Bytes);
public long this[int i]=>Value[i];

public static A068913Inst Instance=new A068913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068914
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,4L,3L,2L,1L,1L,0L,1L,4L,5L,3L,2L,1L,1L,0L,1L,8L,8L,6L,3L,2L,1L,1L,0L,1L,8L,13L,9L,6L,3L,2L,1L,1L,0L,1L,16L,21L,18L,10L,6L,3L,2L,1L,1L,0L,1L,16L,34L,27L,19L,10L,6L,3L,2L,1L,1L,0L,1L,32L,55L,54L,33L,20L,10L,6L,3L,2L,1L,1L,0L,1L,32L,89L };
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
public class A068914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068914Inst : IEnumerable<long>
{
public static readonly long[] Value=A068914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068914.Bytes);
public long this[int i]=>Value[i];

public static A068914Inst Instance=new A068914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068915
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,3L,1L,2L,2L,3L,3L,4L,2L,3L,1L,4L,0L,5L,1L,6L,0L,7L,1L,6L,2L,5L,1L,4L,2L,5L,3L,4L,4L,5L,5L,6L,4L,7L,5L,6L,6L,7L,7L,8L,6L,7L,5L,8L,4L,7L,3L,6L,4L,5L,3L,6L,2L,7L,3L,8L,2L,7L,1L,8L,0L,9L,1L,10L,0L,11L,1L,10L,2L,11L,3L,12L,2L,11L,1L,12L,0L,13L,1L,14L,0L,15L,1L,14L,2L,13L,1L,12L,2L,13L,3L,12L,4L,11L,3L,10L,4L,9L,3L,10L,2L,9L,1L,8L,2L,9L,3L,8L,4L,9L,5L,10L,4L,11L,5L,10L };
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
public class A068915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068915Inst : IEnumerable<long>
{
public static readonly long[] Value=A068915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068915.Bytes);
public long this[int i]=>Value[i];

public static A068915Inst Instance=new A068915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068932
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,2L,5L,4L,9L,7L,23L,18L,74L,106L,619L,2076L,22526L,112834L,4799825L,31138965L,4207943011L,115979718015L,13482672647959L };
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
public class A068932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068932Inst : IEnumerable<long>
{
public static readonly long[] Value=A068932.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068932.Bytes);
public long this[int i]=>Value[i];

public static A068932Inst Instance=new A068932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068933
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,2L,1L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,0L,1L,1L,4L,2L,1L,0L,0L,0L,0L,0L,1L,0L,5L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,8L,9L,3L,1L,0L,0L,0L,0L,0L,0L,1L,0L,9L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,12L,31L,25L,3L,1L,0L,0L,0L,0L,0L };
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
public class A068933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068933Inst : IEnumerable<long>
{
public static readonly long[] Value=A068933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068933.Bytes);
public long this[int i]=>Value[i];

public static A068933Inst Instance=new A068933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068934
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,2L,1L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,1L,5L,6L,3L,1L,1L,0L,0L,1L,0L,16L,0L,4L,0L,1L,0L,0L,1L,19L,59L,60L,21L,5L,1L,1L,0L,0L,1L,0L,265L,0L,266L,0L,6L,0L,1L,0L,0L,1L,85L,1544L,7848L,7849L,1547L,94L,9L,1L,1L,0L,0L,1L,0L,10778L,0L,367860L,0L };
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
public class A068934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068934Inst : IEnumerable<long>
{
public static readonly long[] Value=A068934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068934.Bytes);
public long this[int i]=>Value[i];

public static A068934Inst Instance=new A068934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068935
{
public static readonly long[] Value={ 8L,16L,32L,64L,81L,96L,128L,144L,192L,216L,243L,256L,288L,324L,384L,432L,486L,512L,576L,640L,648L,729L,768L,864L,972L,1024L,1152L,1280L,1296L,1458L,1536L,1600L,1728L,1944L,2048L,2187L,2304L,2560L,2592L,2916L,3072L,3200L,3456L,3584L,3888L,4000L,4096L,4374L,4608L };
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
public class A068935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068935Inst : IEnumerable<long>
{
public static readonly long[] Value=A068935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068935.Bytes);
public long this[int i]=>Value[i];

public static A068935Inst Instance=new A068935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068936
{
public static readonly long[] Value={ 1L,4L,8L,16L,27L,32L,48L,64L,72L,81L,96L,108L,128L,144L,162L,192L,216L,243L,256L,288L,320L,324L,384L,432L,486L,512L,576L,640L,648L,729L,768L,800L,864L,972L,1024L,1152L,1280L,1296L,1458L,1536L,1600L,1728L,1792L,1944L,2000L,2048L,2187L,2304L,2560L,2592L,2916L };
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
public class A068936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068936Inst : IEnumerable<long>
{
public static readonly long[] Value=A068936.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068936.Bytes);
public long this[int i]=>Value[i];

public static A068936Inst Instance=new A068936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068937
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L };
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
public class A068937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068937Inst : IEnumerable<long>
{
public static readonly long[] Value=A068937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068937.Bytes);
public long this[int i]=>Value[i];

public static A068937Inst Instance=new A068937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068938
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L };
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
public class A068938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068938Inst : IEnumerable<long>
{
public static readonly long[] Value=A068938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068938.Bytes);
public long this[int i]=>Value[i];

public static A068938Inst Instance=new A068938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068939
{
public static readonly BigInteger[] Value={ 1L,1L,15L,21147L,10480142147L,4638590332229999353L,BigInteger.Parse("3819714729894818339975525681317"),BigInteger.Parse("10726137154573358400342215518590002633917247281") };
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
public class A068939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068939Inst Instance=new A068939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068940
{
public static readonly long[] Value={ 1L,1L,4L,7L,13L,21L,32L,48L,67L,91L,121L,133L,169L };
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
public class A068940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068940Inst : IEnumerable<long>
{
public static readonly long[] Value=A068940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068940.Bytes);
public long this[int i]=>Value[i];

public static A068940Inst Instance=new A068940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068941
{
public static readonly long[] Value={ 1L,1L,6L,16L };
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
public class A068941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068941Inst : IEnumerable<long>
{
public static readonly long[] Value=A068941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068941.Bytes);
public long this[int i]=>Value[i];

public static A068941Inst Instance=new A068941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068942
{
public static readonly BigInteger[] Value={ 1L,1L,75L,7087261L,5315654681981355L,BigInteger.Parse("106697365438475775825583498141"),BigInteger.Parse("144199280951655469628360978109406917583513090155"),BigInteger.Parse("27656793065414932606012896651489726461435178241015434306518713649426461") };
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
public class A068942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068942Inst Instance=new A068942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068943
{
public static readonly BigInteger[] Value={ 1L,2L,24L,331776L,BigInteger.Parse("2524286414780230533120"),BigInteger.Parse("18356962141505758798331790171539976807981714702571497465907439808868887035904000000") };
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
public class A068943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A068943.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A068943Inst Instance=new A068943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068944
{
public static readonly long[] Value={ 0L,0L,0L,2L,7L,28L,108L,414L,1585L,6087L,23446L,90532L,350343L,1358437L,5276545L,20527950L,79976007L,311984922L,1218474389L,4763911699L,18643889114L,73029856058L,286302435505L,1123267533520L,4410123312095L,17326303720537L };
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
public class A068944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068944Inst : IEnumerable<long>
{
public static readonly long[] Value=A068944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068944.Bytes);
public long this[int i]=>Value[i];

public static A068944Inst Instance=new A068944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068945
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,13L,63L,199L,805L,3155L,12319L,48070L,186944L,727997L,2846645L,11109160L,43432775L,169958492L };
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
public class A068945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068945Inst : IEnumerable<long>
{
public static readonly long[] Value=A068945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068945.Bytes);
public long this[int i]=>Value[i];

public static A068945Inst Instance=new A068945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A068946
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,83L,316L,1213L,4667L,17992L,69509L,269058L,1043346L,4052518L,15764358L,61408219L,239510633L,935245088L,3655841616L,14304538696L,56021145629L,219579741115L,861327333405L,3381084681442L,13281106066320L };
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
public class A068946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A068946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A068946Inst : IEnumerable<long>
{
public static readonly long[] Value=A068946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A068946.Bytes);
public long this[int i]=>Value[i];

public static A068946Inst Instance=new A068946Inst();

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