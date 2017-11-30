using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141285
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,4L,3L,6L,5L,4L,8L,3L,5L,4L,7L,3L,6L,5L,9L,2L,4L,3L,6L,5L,4L,8L,4L,7L,6L,5L,10L,3L,5L,4L,7L,3L,6L,5L,9L,5L,4L,8L,7L,6L,11L,2L,4L,3L,6L,5L,4L,8L,4L,7L,6L,5L,10L,3L,6L,5L,9L,4L,8L,7L,6L,12L };
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
public class A141285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141285Inst : IEnumerable<long>
{
public static readonly long[] Value=A141285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141285.Bytes);
public long this[int i]=>Value[i];

public static A141285Inst Instance=new A141285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141286
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,6L,7L,16L,18L,10L,11L,12L,13L,14L,30L,16L,17L,18L,19L,40L,42L,22L,23L,24L,75L,26L,27L,56L,29L,30L,31L,96L,66L,34L,105L,36L,37L,38L,78L,40L,41L,42L,43L,88L,45L,46L,47L,96L,147L,100L,102L,104L,53L,216L,165L,56L,114L,58L,59L,60L,61L,62L,63L,256L,195L,66L,67L,136L,138L };
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
public class A141286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141286Inst : IEnumerable<long>
{
public static readonly long[] Value=A141286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141286.Bytes);
public long this[int i]=>Value[i];

public static A141286Inst Instance=new A141286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141287
{
public static readonly long[] Value={ 1760L,1788L,1828L,1856L,1884L,1924L,1952L,1980L,2008L,2036L,2064L,2092L,2104L,2132L,2160L,2188L,2228L,2256L,2284L,2324L,2352L,2380L,2408L,2436L,2464L,2492L,2504L,2532L,2560L,2588L,2628L,2656L,2684L,2724L,2752L,2780L,2808L,2836L,2864L,2892L,2904L,2932L };
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
public class A141287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141287Inst : IEnumerable<long>
{
public static readonly long[] Value=A141287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141287.Bytes);
public long this[int i]=>Value[i];

public static A141287Inst Instance=new A141287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141352
{
public static readonly long[] Value={ 1L,-1L,-6L,-11L,-15L,-25L,-35L,-41L,-56L,-71L,-79L,-99L,-119L,-129L,-154L,-179L,-191L,-221L,-251L,-265L,-300L,-335L,-351L,-391L,-431L,-449L,-494L,-539L,-559L,-609L,-659L,-681L,-736L,-791L,-815L,-875L,-935L,-961L,-1026L,-1091L,-1119L };
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
public class A141352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141352Inst : IEnumerable<long>
{
public static readonly long[] Value=A141352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141352.Bytes);
public long this[int i]=>Value[i];

public static A141352Inst Instance=new A141352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141353
{
public static readonly long[] Value={ 1L,3L,6L,13L,30L,74L,196L,557L,1686L,5374L,17820L,60834L,212108L,751092L,2690824L,9727613L,35423206L,129775862L,477900844L,1767787478L,6565168996L,24468364172L,91486757944L,343068002258L,1289920924540L,4861979955884L };
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
public class A141353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141353Inst : IEnumerable<long>
{
public static readonly long[] Value=A141353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141353.Bytes);
public long this[int i]=>Value[i];

public static A141353Inst Instance=new A141353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141354
{
public static readonly long[] Value={ 1L,-3L,-7L,-15L,-23L,-35L,-47L,-63L,-79L,-99L,-119L,-143L,-167L,-195L,-223L,-255L,-287L,-323L,-359L,-399L,-439L,-483L,-527L,-575L,-623L,-675L,-727L,-783L,-839L,-899L,-959L,-1023L,-1087L,-1155L,-1223L,-1295L,-1367L,-1443L,-1519L,-1599L,-1679L,-1763L,-1847L };
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
public class A141354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141354Inst : IEnumerable<long>
{
public static readonly long[] Value=A141354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141354.Bytes);
public long this[int i]=>Value[i];

public static A141354Inst Instance=new A141354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141355
{
public static readonly long[] Value={ 1L,1L,5L,11L,43L,85L,341L,683L,2731L,5461L,21845L,43691L,174763L,349525L,1398101L,2796203L,11184811L,22369621L,89478485L,178956971L,715827883L,1431655765L,5726623061L,11453246123L,45812984491L,91625968981L,366503875925L,733007751851L };
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
public class A141355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141355Inst : IEnumerable<long>
{
public static readonly long[] Value=A141355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141355.Bytes);
public long this[int i]=>Value[i];

public static A141355Inst Instance=new A141355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141356
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,245L,3516L,63727L,1405384L,36336393L,1077150160L,36056947931L,1345603208544L,55390366280317L,2493292939893952L,121840258072947975L,6423982984221479296L,BigInteger.Parse("363498003830522845073"),BigInteger.Parse("21972216426996693494016") };
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
public class A141356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141356Inst Instance=new A141356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141357
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,945L,21961L,645013L,22948815L,959764865L,46147888945L,2508384505221L,152103283527559L,10179988876061425L,745421842821798585L,BigInteger.Parse("59279676127816345685"),BigInteger.Parse("5087948349956406532831"),BigInteger.Parse("468789320770224531664257") };
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
public class A141357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141357Inst Instance=new A141357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141358
{
public static readonly BigInteger[] Value={ 1L,1L,7L,106L,2509L,80956L,3313579L,164514904L,9608077945L,645470256592L,49038954301711L,4157529546929056L,389125813949115973L,BigInteger.Parse("39853422352958799040"),BigInteger.Parse("4433527105413108692851"),BigInteger.Parse("532370587431255626482816") };
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
public class A141358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141358Inst Instance=new A141358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141359
{
public static readonly BigInteger[] Value={ 1L,1L,9L,175L,5321L,221001L,11659345L,746678311L,56273809905L,4879911980017L,478663176441401L,52401160551586815L,6333742154439370489L,BigInteger.Parse("837795219321504405625"),BigInteger.Parse("120379591345300309348929") };
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
public class A141359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141359Inst Instance=new A141359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141360
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,281L,5276L,132577L,4209766L,162569969L,7430664952L,393986044961L,23861309117834L,1630730511310441L,124533452791281028L,10541716135649976929UL,BigInteger.Parse("982527040998772635286"),BigInteger.Parse("100258434765654907227233") };
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
public class A141360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141360Inst Instance=new A141360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141361
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,981L,24621L,803143L,32390247L,1560845289L,87688371385L,5637912173451L,408922311037659L,33077570245035517L,2956347175261764597L,BigInteger.Parse("289716070585295689455"),BigInteger.Parse("30931475430329804121871") };
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
public class A141361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141361Inst Instance=new A141361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141362
{
public static readonly BigInteger[] Value={ 1L,1L,7L,106L,2545L,84516L,3599869L,187549426L,11569862497L,825476139784L,66913201813141L,6077199111018366L,611543851953714673L,BigInteger.Parse("67563014389049920924"),BigInteger.Parse("8132697862579447135021"),BigInteger.Parse("1059750845948899631017906") };
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
public class A141362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141362Inst Instance=new A141362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141363
{
public static readonly BigInteger[] Value={ 1L,1L,9L,175L,5357L,225461L,12112675L,792855043L,61249418585L,5456747990665L,550924441708031L,62176714054787135L,7758184127489208517L,BigInteger.Parse("1060631125759075562797"),BigInteger.Parse("157674821045525700085499") };
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
public class A141363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141363Inst Instance=new A141363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141364
{
public static readonly long[] Value={ 1L,0L,1L,4L,13L,41L,131L,428L,1429L,4861L,16795L,58785L,208011L,742899L,2674439L,9694844L,35357669L,129644789L,477638699L,1767263189L,6564120419L,24466267019L,91482563639L,343059613649L,1289904147323L,4861946401451L,18367353072151L };
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
public class A141364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141364Inst : IEnumerable<long>
{
public static readonly long[] Value=A141364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141364.Bytes);
public long this[int i]=>Value[i];

public static A141364Inst Instance=new A141364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141365
{
public static readonly long[] Value={ 1L,1L,-4L,-9L,-11L,-21L,-31L,-35L,-50L,-65L,-71L,-91L,-111L,-119L,-144L,-169L,-179L,-209L,-239L,-251L,-286L,-321L,-335L,-375L,-415L,-431L,-476L,-521L,-539L,-589L,-639L,-659L,-714L,-769L,-791L,-851L,-911L,-935L,-1000L,-1065L,-1091L,-1161L,-1231L };
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
public class A141365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141365Inst : IEnumerable<long>
{
public static readonly long[] Value=A141365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141365.Bytes);
public long this[int i]=>Value[i];

public static A141365Inst Instance=new A141365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141366
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,32L,65L,138L,316L,792L,2142L,6052L,17316L,49160L,137108L,374632L,1004668L,2656872L,6974510L,18310220L,48416528L,129637152L,352339898L,971336204L,2707410220L,7596357720L,21363062480L,60019857952L,168132717792L };
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
public class A141366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141366Inst : IEnumerable<long>
{
public static readonly long[] Value=A141366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141366.Bytes);
public long this[int i]=>Value[i];

public static A141366Inst Instance=new A141366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141367
{
public static readonly BigInteger[] Value={ 1L,4L,128L,43680L,178946048L,9382409745280L,6558834518571089920L,BigInteger.Parse("62879485860387254833099776"),BigInteger.Parse("8439542720341303996200869198561280"),BigInteger.Parse("16110026846830031883594370688522189192189952") };
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
public class A141367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141367Inst Instance=new A141367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141400
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,13L,17L,19L,23L,34L,38L,43L,49L,50L,53L,55L,59L,64L,74L,77L,79L,85L,94L,109L,115L,121L,127L,128L,136L,137L,145L,146L,151L,157L,163L,166L,169L,181L,187L,188L,194L,200L,203L,205L,214L,217L,223L,227L,232L,239L,244L,265L,283L,302L,314L,316L,319L,331L };
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
public class A141400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141400Inst : IEnumerable<long>
{
public static readonly long[] Value=A141400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141400.Bytes);
public long this[int i]=>Value[i];

public static A141400Inst Instance=new A141400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141401
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,9L,16L,17L,21L,23L,24L,27L,36L,42L,52L,53L,57L,58L,64L,66L,67L,77L,78L,81L,84L,86L,87L,92L,93L,94L,104L,106L,111L,123L,132L,138L,143L,146L,152L,159L,172L,176L,179L,183L,188L,189L,191L,196L,198L,202L,212L,217L,227L,232L,234L,236L,239L,246L,253L,256L,272L };
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
public class A141401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141401Inst : IEnumerable<long>
{
public static readonly long[] Value=A141401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141401.Bytes);
public long this[int i]=>Value[i];

public static A141401Inst Instance=new A141401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141402
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,4L,9L,25L,25L,9L,16L,52L,80L,52L,16L,25L,89L,169L,169L,89L,25L,36L,136L,292L,360L,292L,136L,36L,49L,193L,449L,625L,625L,449L,193L,49L,64L,260L,640L,964L,1088L,964L,640L,260L,64L,81L,337L,865L,1377L,1681L,1681L,1377L,865L,337L,81L,100L,424L,1124L,1864L };
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
public class A141402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141402Inst : IEnumerable<long>
{
public static readonly long[] Value=A141402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141402.Bytes);
public long this[int i]=>Value[i];

public static A141402Inst Instance=new A141402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141403
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,12L,13L,15L,16L,17L,18L,25L,29L,34L,36L,37L,46L,48L,52L,55L,59L,64L,80L,81L,83L,88L,89L,97L,100L,101L,103L,104L,107L,114L,122L,123L,134L,135L,137L,144L,145L,152L,157L,158L,167L,183L,188L,202L,206L,209L,216L,219L,226L,229L,230L,233L,235L,237L,240L,246L };
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
public class A141403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141403Inst : IEnumerable<long>
{
public static readonly long[] Value=A141403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141403.Bytes);
public long this[int i]=>Value[i];

public static A141403Inst Instance=new A141403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141404
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,1L,7L,8L,9L,2L,3L,11L,3L,1L,13L,2L,5L,3L,2L,16L,17L,2L,7L,19L,4L,1L,3L,4L,2L,9L,23L,3L,5L,25L,2L,11L,27L,4L,3L,29L,2L,1L,2L,31L,32L,3L,8L,2L,15L,5L,2L,4L,5L,37L,2L,17L,3L,10L,5L,3L,41L,2L,1L,4L,43L,4L,7L,5L,4L,2L,21L,47L,3L,13L,49L,2L,23L,3L,14L,4L,9L,53L,2L,25L,5L,6L,7L,1L,3L,16L,2L };
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
public class A141404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141404Inst : IEnumerable<long>
{
public static readonly long[] Value=A141404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141404.Bytes);
public long this[int i]=>Value[i];

public static A141404Inst Instance=new A141404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141405
{
public static readonly long[] Value={ 2L,23L,101L,1423L,10243L,102043L,1234657L,10243567L,100234657L,1123465789L,10123457689L,100123456789L,1001233458679L,10011223456879L,100122334546789L,1001122334546879L };
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
public class A141405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141405Inst : IEnumerable<long>
{
public static readonly long[] Value=A141405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141405.Bytes);
public long this[int i]=>Value[i];

public static A141405Inst Instance=new A141405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141406
{
public static readonly long[] Value={ 1L,2L,6L,12L,20L,24L,30L,40L,48L,60L,72L,90L,120L,168L,180L,240L,336L,360L,420L,480L,504L,600L,630L,672L,720L,840L,1080L,1260L,1440L,1680L,2160L,2520L,3360L,3780L,3960L,4200L,4320L,4620L,5040L,6720L,7560L,9240L,10080L,12600L,13860L,15120L,18480L,20160L };
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
public class A141406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141406Inst : IEnumerable<long>
{
public static readonly long[] Value=A141406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141406.Bytes);
public long this[int i]=>Value[i];

public static A141406Inst Instance=new A141406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141407
{
public static readonly long[] Value={ 1L,48L,1296L,25920L,427680L,6158592L,80061696L,960740352L,10808328960L,115288842240L,1175946190848L,11545653510144L,109683708346368L,1012465000120320L,9112185001082880L,80187228009529344L,691614841582190592L };
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
public class A141407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141407Inst : IEnumerable<long>
{
public static readonly long[] Value=A141407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141407.Bytes);
public long this[int i]=>Value[i];

public static A141407Inst Instance=new A141407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141408
{
public static readonly long[] Value={ 5L,13L,37L,41L,61L,73L,101L,157L,173L,193L,257L,277L,353L,373L,433L,457L,461L,541L,601L,613L,641L,653L,677L,733L };
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
public class A141408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141408Inst : IEnumerable<long>
{
public static readonly long[] Value=A141408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141408.Bytes);
public long this[int i]=>Value[i];

public static A141408Inst Instance=new A141408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141409
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,29L,31L,41L,43L,47L,59L,61L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,127L,131L,139L,149L,151L,157L,163L,167L,179L,181L,191L,199L,223L,227L,233L,239L,251L,257L,263L,269L,277L,281L,307L,337L,349L,353L,373L,401L,409L,419L,421L,431L,439L,443L,449L,457L,461L };
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
public class A141409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141409Inst : IEnumerable<long>
{
public static readonly long[] Value=A141409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141409.Bytes);
public long this[int i]=>Value[i];

public static A141409Inst Instance=new A141409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141410
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,7L,4L,3L,5L,11L,6L,13L,7L,1L,8L,17L,9L,19L,10L,7L,11L,23L,12L,25L,13L,9L,14L,29L,15L,31L,16L,11L,17L,1L,18L,37L,19L,13L,20L,41L,21L,43L,22L,15L,23L,47L,24L,49L,25L,17L,26L,53L,27L,11L,28L,19L,29L,59L,30L,61L };
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
public class A141410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141410Inst : IEnumerable<long>
{
public static readonly long[] Value=A141410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141410.Bytes);
public long this[int i]=>Value[i];

public static A141410Inst Instance=new A141410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141411
{
public static readonly long[] Value={ 3L,1L,31L,28L,365L,514L,4388L,8220L,53871L,122284L,673222L,1748055L,8535397L,24383499L,109449848L,334783855L,1415768769L,4548229589L,18434398665L,61345927764L,241210652738L,823296868656L,3167642169823L,11010462627756L,41708741708554L,146886286090602L };
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
public class A141411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141411Inst : IEnumerable<long>
{
public static readonly long[] Value=A141411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141411.Bytes);
public long this[int i]=>Value[i];

public static A141411Inst Instance=new A141411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141412
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,4L,12L,2L,1L,5L,6L,4L,1L,1L,6L,180L,8L,6L,2L,1L,7L,10L,15L,2L,6L,1L,1L,8L,560L,240L,240L,6L,4L,2L,1L,9L,1260L,15120L,20L,144L,1L,12L,1L,1L,10L,12600L,672L,945L,32L,240L,8L,3L,2L,1L,11L,1260L,8400L,1512L,3024L,48L,240L,3L,1L,1L,1L,12L,166320L,100800L,64800L,12096L,12096L };
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
public class A141412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141412Inst : IEnumerable<long>
{
public static readonly long[] Value=A141412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141412.Bytes);
public long this[int i]=>Value[i];

public static A141412Inst Instance=new A141412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141413
{
public static readonly long[] Value={ 0L,-1L,1L,-3L,9L,-27L,81L,-243L,729L,-2187L,6561L,-19683L,59049L,-177147L,531441L,-1594323L,4782969L,-14348907L,43046721L,-129140163L,387420489L,-1162261467L,3486784401L,-10460353203L,31381059609L,-94143178827L,282429536481L,-847288609443L };
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
public class A141413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141413Inst : IEnumerable<long>
{
public static readonly long[] Value=A141413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141413.Bytes);
public long this[int i]=>Value[i];

public static A141413Inst Instance=new A141413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141414
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,41L,113L,311L,1821L,10267L,74587L,1015453L,12550793L };
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
public class A141414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141414Inst : IEnumerable<long>
{
public static readonly long[] Value=A141414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141414.Bytes);
public long this[int i]=>Value[i];

public static A141414Inst Instance=new A141414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141415
{
public static readonly long[] Value={ 1L,0L,0L,2L,26L };
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
public class A141415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141415Inst : IEnumerable<long>
{
public static readonly long[] Value=A141415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141415.Bytes);
public long this[int i]=>Value[i];

public static A141415Inst Instance=new A141415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141448
{
public static readonly long[] Value={ 0L,1L,2L,5L,13L,34L,89L,232L,605L,1578L,4116L,10736L,28003L,73041L,190515L,496926L,1296147L,3380779L,8818187L,23000741L,59993521L,156482896L,408159020L,1064613385L,2776862948L,7242974718L,18892067685L,49276745441L,128530009618L };
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
public class A141448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141448Inst : IEnumerable<long>
{
public static readonly long[] Value=A141448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141448.Bytes);
public long this[int i]=>Value[i];

public static A141448Inst Instance=new A141448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141449
{
public static readonly long[] Value={ 1L,2L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L,2L,5L,8L };
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
public class A141449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141449Inst : IEnumerable<long>
{
public static readonly long[] Value=A141449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141449.Bytes);
public long this[int i]=>Value[i];

public static A141449Inst Instance=new A141449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141450
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,4L,1L,1L,3L,7L,1L,1L,2L,4L,12L,1L,1L,2L,4L,8L,19L,1L,1L,2L,3L,6L,11L,30L,1L,1L,2L,3L,6L,9L,19L,45L,1L,1L,2L,3L,5L,8L,15L,26L,67L,1L,1L,2L,3L,5L,8L,13L,21L,41L,97L,1L,1L,2L,3L,5L,7L,12L,18L,31L,56L,139L,1L,1L,2L,3L,5L,7L,12L,17L,28L,45L,83L,195L,1L,1L,2L,3L,5L,7L,11L,16L,25L,38L,63L };
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
public class A141450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141450Inst : IEnumerable<long>
{
public static readonly long[] Value=A141450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141450.Bytes);
public long this[int i]=>Value[i];

public static A141450Inst Instance=new A141450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141451
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,20L,22L,23L,24L,27L,30L,31L,32L,35L,36L,38L,39L,40L,42L,43L,44L,46L,47L,48L,52L,54L,57L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,78L,79L,80L,84L,86L,87L,88L,90L,92L,94L,95L,96L,100L,102L,103L,104L,105L,106L,107L,108L,114L,115L };
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
public class A141451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141451Inst : IEnumerable<long>
{
public static readonly long[] Value=A141451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141451.Bytes);
public long this[int i]=>Value[i];

public static A141451Inst Instance=new A141451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141452
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,18L,24L,32L,36L,45L,48L,50L,54L,56L,64L,70L,72L,84L,96L,108L,120L,128L,136L,144L,150L,156L,168L,176L,180L,198L,204L,216L,224L,228L,240L,260L,264L,272L,280L,288L,306L,312L,320L,322L,328L,336L,340L,348L,360L,384L,400L,405L,410L,416L,420L,432L,440L };
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
public class A141452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141452Inst : IEnumerable<long>
{
public static readonly long[] Value=A141452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141452.Bytes);
public long this[int i]=>Value[i];

public static A141452Inst Instance=new A141452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141453
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,17L,31L,127L,257L,8191L,65537L,131071L,524287L,2147483647L,2305843009213693951L,BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127"),BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A141453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141453Inst Instance=new A141453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141454
{
public static readonly long[] Value={ 0L,2L,0L,-2L,1L,2L,-2L,-1L,2L,-1L,1L,-2L,1L,2L,-2L,2L,-1L,1L,-2L,1L,2L,-1L,2L,-1L,-2L,1L,2L,-2L,-1L,2L,-2L,1L,-2L,-1L,-1L,1L,-2L,2L,-2L,2L,-1L,1L,1L,2L,-2L,-1L,1L,2L,-2L,-1L,2L,-1L,1L,1L,-2L,2L,-1L,1L,-2L,1L,2L,2L,-2L,1L,2L,-2L,1L,-2L,-2L,-1L,2L,-1L,-2L,2L,-1L,2L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,2L,-1L,-2L,1L,2L,-2L,-1L,-2L,1L,-1L,2L,-1L,1L,2L,1L };
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
public class A141454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141454Inst : IEnumerable<long>
{
public static readonly long[] Value=A141454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141454.Bytes);
public long this[int i]=>Value[i];

public static A141454Inst Instance=new A141454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141455
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,5L,0L,1L,2L,3L,4L,5L,6L,1L,2L,3L,5L,7L,1L,2L,3L,4L,5L,7L,8L,1L,2L,3L,5L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,5L,7L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,2L,3L,5L,7L,9L,11L,13L,1L,2L,3L,4L,5L,7L,8L,11L,13L,14L,1L,2L,3L,5L,7L,9L,11L,13L,15L };
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
public class A141455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141455Inst : IEnumerable<long>
{
public static readonly long[] Value=A141455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141455.Bytes);
public long this[int i]=>Value[i];

public static A141455Inst Instance=new A141455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141456
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,2L,8L,10L,4L,17L,52L,33L,29L,141L,250L };
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
public class A141456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141456Inst : IEnumerable<long>
{
public static readonly long[] Value=A141456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141456.Bytes);
public long this[int i]=>Value[i];

public static A141456Inst Instance=new A141456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141457
{
public static readonly long[] Value={ 61L,73L,181L,241L,421L,433L,577L,601L,829L,997L,1033L,1069L,1153L,1621L,1657L,1753L,1861L,2017L,2089L,2113L,2521L,2593L,2917L,3049L,3121L,3373L,3517L,3637L,3709L,3967L,4093L,4201L,4357L,4561L,4861L,5119L,5179L,5323L,5443L,5623L };
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
public class A141457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141457Inst : IEnumerable<long>
{
public static readonly long[] Value=A141457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141457.Bytes);
public long this[int i]=>Value[i];

public static A141457Inst Instance=new A141457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141458
{
public static readonly BigInteger[] Value={ 2L,3L,21L,333L,9321L,404313L,25071021L,2103118293L,229256855121L,31493764788273L,5321869241361621L,1084772760899990253L,BigInteger.Parse("262436014353765070521"),BigInteger.Parse("74338674113237083780233"),BigInteger.Parse("24371443829213227706941821"),BigInteger.Parse("9155506650374192400724494213"),BigInteger.Parse("3906927095300068860534174415521") };
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
public class A141458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141458Inst Instance=new A141458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141459
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,1L,21L,1L,15L,1L,33L,1L,1365L,1L,3L,1L,255L,1L,399L,1L,165L,1L,69L,1L,1365L,1L,3L,1L,435L,1L,7161L,1L,255L,1L,3L,1L,959595L,1L,3L,1L,6765L,1L,903L,1L,345L,1L,141L,1L,23205L,1L,33L,1L,795L,1L,399L,1L,435L,1L,177L,1L,28393365L,1L,3L,1L,255L,1L,32361L,1L,15L,1L,2343L,1L,70050435L };
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
public class A141459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141459Inst : IEnumerable<long>
{
public static readonly long[] Value=A141459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141459.Bytes);
public long this[int i]=>Value[i];

public static A141459Inst Instance=new A141459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141460
{
public static readonly long[] Value={ 23L,23L,23L,115L,23L,10787L,23L,10235L,23L,2783L,23L,701155L,23L,23L,23L,173995L,23L,40785647L,23L,69575L,23L,16721L,24863L,62402795L,23L,23L,23L,3335L,23L,13392934247L,23L,61420235L,23L,23L,1633L,2842731249875335L,23L,9637L,23L,253879175L };
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
public class A141460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141460Inst : IEnumerable<long>
{
public static readonly long[] Value=A141460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141460.Bytes);
public long this[int i]=>Value[i];

public static A141460Inst Instance=new A141460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141461
{
public static readonly long[] Value={ 909287L,909289L,909299L,909301L,909317L,909319L,909329L,909331L,909341L,909343L,2596619L,2596621L,2596637L,2596639L,2596661L,2596663L,2596667L,2596669L,2596679L,2596681L };
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
public class A141461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141461Inst : IEnumerable<long>
{
public static readonly long[] Value=A141461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141461.Bytes);
public long this[int i]=>Value[i];

public static A141461Inst Instance=new A141461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141462
{
public static readonly long[] Value={ 0L,1L,0L,6L,0L,6L,10L,9L,4L,12L,6L,10L,9L,0L,18L,15L,20L,6L,22L,12L,15L,18L,18L,21L,8L,30L,15L,30L,22L,9L,36L,20L,34L,27L,18L,30L,0L,44L,27L,30L,42L,25L,12L,35L,30L,34L,54L,33L,24L,18L,39L,30L,60L,54L,36L,27L,66L,42L,58L,45L,68L,16L,35L,54L,30L,45L,44L,50L,51L,18L,45L,70L,40L,51L,84L };
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
public class A141462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141462Inst : IEnumerable<long>
{
public static readonly long[] Value=A141462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141462.Bytes);
public long this[int i]=>Value[i];

public static A141462Inst Instance=new A141462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141463
{
public static readonly long[] Value={ 1L,3L,10L,15L,16L,21L,33L,39L,43L,66L,108L,109L,111L,126L,153L,195L,339L,1359L };
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
public class A141463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141463Inst : IEnumerable<long>
{
public static readonly long[] Value=A141463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141463.Bytes);
public long this[int i]=>Value[i];

public static A141463Inst Instance=new A141463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141512
{
public static readonly long[] Value={ 1L,2L,1L,7L,4L,49L,21L,648L,245L,16475L,5184L,801489L,214175L,74700792L,16831269L,13333992705L,2539826928L,4558747755857L,733369598775L,2985167883475040L,405728550271273L,3743977846899435969L,429864175220405760L };
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
public class A141512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141512Inst : IEnumerable<long>
{
public static readonly long[] Value=A141512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141512.Bytes);
public long this[int i]=>Value[i];

public static A141512Inst Instance=new A141512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141513
{
public static readonly BigInteger[] Value={ 1L,2L,1L,7L,8L,101L,207L,5120L,20417L,961969L,7321136L,661511545L,9650955373L,1669696876968L,46646811310045L,15458287165896835L,827194455797432320L,BigInteger.Parse("525025121630724209885"),BigInteger.Parse("53809855627730048960875") };
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
public class A141513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141513Inst Instance=new A141513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141514
{
public static readonly BigInteger[] Value={ 1L,2L,3L,29L,176L,5621L,122557L,14694960L,1181467639L,516777127561L,152237306877120L,244601068560037129L,BigInteger.Parse("264412894413046723521"),BigInteger.Parse("1557984885076079288613088"),BigInteger.Parse("6177872087977594821120364739") };
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
public class A141514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141514Inst Instance=new A141514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141515
{
public static readonly long[] Value={ 1L,6L,12L,18L,22L,30L,36L,42L,46L,52L,60L,66L,72L,78L,82L,88L,96L,102L,108L,112L,126L,130L,138L,150L,156L,162L,166L,172L,180L,192L,198L,210L,222L,228L,232L,240L,250L,256L,262L,270L,276L,282L,292L,306L,312L,316L,330L,336L,348L,352L,358L,366L,372L,378L,382L,388L };
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
public class A141515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141515Inst : IEnumerable<long>
{
public static readonly long[] Value=A141515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141515.Bytes);
public long this[int i]=>Value[i];

public static A141515Inst Instance=new A141515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141516
{
public static readonly long[] Value={ 1L,2L,1L,-7L,-23L,-1L,7L,-103L,-251L,-133L,-149L,-1387L,-3143L,-3001L,-4913L,-19663L,-42611L,-55693L,-101549L,-291667L,-612863L,-960001L,-1831433L,-4460023L,-9185771L,-15980053L,-31162949L,-69500347L,-141392183L,-261261001L };
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
public class A141516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141516Inst : IEnumerable<long>
{
public static readonly long[] Value=A141516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141516.Bytes);
public long this[int i]=>Value[i];

public static A141516Inst Instance=new A141516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141517
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,23L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,47L,1L,1L,1L,1L,1L,1L,1L,1L,1L,23L,1L,71L,73L,1L,1L,1L,5L,1L,7L,431L,1L,1L,1L,1L,97L,1L,1L,1L,1L,1L,1L,23L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,47L,1L,1L,1L,1L,1L,601L,1L,23L,1L,1L,5L,1L,1L,167L,7L,1L,431L,1L,1L,1L,1L,1L,1L,1L,1L,191L,193L,1L };
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
public class A141517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141517Inst : IEnumerable<long>
{
public static readonly long[] Value=A141517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141517.Bytes);
public long this[int i]=>Value[i];

public static A141517Inst Instance=new A141517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141518
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L,1L,3L,5L,7L,9L };
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
public class A141518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141518Inst : IEnumerable<long>
{
public static readonly long[] Value=A141518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141518.Bytes);
public long this[int i]=>Value[i];

public static A141518Inst Instance=new A141518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141519
{
public static readonly long[] Value={ -1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L,7L,-5L,3L,-7L,9L,-9L,5L,-1L,1L,-3L };
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
public class A141519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141519Inst : IEnumerable<long>
{
public static readonly long[] Value=A141519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141519.Bytes);
public long this[int i]=>Value[i];

public static A141519Inst Instance=new A141519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141520
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,2L,3L,8L,30L,264L,8160L,2162160L,17645379840L,38152152118080000L,BigInteger.Parse("673209215875134265982054400"),BigInteger.Parse("25684380411361480419900838705211915059200000") };
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
public class A141520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141520Inst Instance=new A141520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141521
{
public static readonly long[] Value={ 23L,37L,53L,73L,257L,523L };
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
public class A141521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141521Inst : IEnumerable<long>
{
public static readonly long[] Value=A141521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141521.Bytes);
public long this[int i]=>Value[i];

public static A141521Inst Instance=new A141521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141522
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,2L,4L,12L,72L,1152L,96768L,118444032L,11598039613440L,BigInteger.Parse("1374840894208868352000"),BigInteger.Parse("15945621994910596019667697926144000"),BigInteger.Parse("21922693387137438627357958684974264478793362424463360000") };
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
public class A141522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141522Inst Instance=new A141522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141523
{
public static readonly long[] Value={ 3L,1L,1L,5L,7L,13L,25L,45L,83L,153L,281L,517L,951L,1749L,3217L,5917L,10883L,20017L,36817L,67717L,124551L,229085L,421353L,774989L,1425427L,2621769L,4822185L,8869381L,16313335L,30004901L,55187617L,101505853L,186698371L,343391841L };
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
public class A141523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141523Inst : IEnumerable<long>
{
public static readonly long[] Value=A141523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141523.Bytes);
public long this[int i]=>Value[i];

public static A141523Inst Instance=new A141523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141524
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,2L,4L,3L,4L,4L,4L,1L,1L,5L,5L,5L,5L,1L,1L,6L,3L,2L,3L,6L,6L,6L,3L,4L,6L,6L,6L,6L,3L,4L,6L,6L,3L,6L,6L,2L,3L,6L,6L,6L,3L,4L,6L,6L,2L,6L,6L,6L,6L,6L,6L,6L,3L,4L,6L,6L,4L,6L,6L,2L,6L,6L,4L,6L,3L,2L,3L,6L,6L,6L,3L,4L,3L,6L,3L,6L,3L,4L,6L,6L,2L,6L,3L,6L,3L,6L,1L,1L,7L,7L,7L,7L,7L,7L,1L };
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
public class A141524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141524Inst : IEnumerable<long>
{
public static readonly long[] Value=A141524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141524.Bytes);
public long this[int i]=>Value[i];

public static A141524Inst Instance=new A141524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141525
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,2L,3L,4L,4L,4L,8L,8L,8L,16L,24L,24L,40L,40L,64L,80L,80L,80L,160L,160L,160L,320L,480L,480L,800L,800L,1280L,1600L,1600L,1600L,3200L,3200L,3200L,6400L,9600L };
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
public class A141525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141525Inst : IEnumerable<long>
{
public static readonly long[] Value=A141525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141525.Bytes);
public long this[int i]=>Value[i];

public static A141525Inst Instance=new A141525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141526
{
public static readonly long[] Value={ 1L,2L,4L,6L,24L,34L,36L,66L,78L,86L,96L,100L,104L,114L,116L,120L,130L,144L,152L,156L,162L,182L,204L,228L,230L,258L,264L,276L,324L,356L,386L,394L,402L,416L,420L,428L,434L,444L,480L,520L,552L,582L,584L,606L,612L,632L,666L,678L,680L,696L,726L,728L,730L,732L,794L };
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
public class A141526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141526Inst : IEnumerable<long>
{
public static readonly long[] Value=A141526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141526.Bytes);
public long this[int i]=>Value[i];

public static A141526Inst Instance=new A141526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141527
{
public static readonly long[] Value={ 2L,-1L,-81L,122L,3199L,-8201L,-122958L,459199L,4582079L,-23409238L,-164456001L,1124234759L,5618461282L,-51712086401L,-178644826161L,2298840368602L,5025597503999L,-99278052616681L,-106771445047278L,4177171602331199L,200457644607199L,-171464493340186358L };
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
public class A141527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141527Inst : IEnumerable<long>
{
public static readonly long[] Value=A141527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141527.Bytes);
public long this[int i]=>Value[i];

public static A141527Inst Instance=new A141527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141560
{
public static readonly long[] Value={ 1L,1L,4L,9L,14L,15L,21L,22L,25L,34L,35L,40L,50L,55L,62L,65L,65L,68L,69L,86L,91L,91L,100L,106L,111L,118L,123L,124L,133L,133L,135L,136L,147L,158L,161L,161L,164L,169L,169L,177L,182L,187L,192L,200L,201L,209L,222L,225L,226L,246L,255L,256L,259L,264L,275L,280L,287L,296L };
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
public class A141560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141560Inst : IEnumerable<long>
{
public static readonly long[] Value=A141560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141560.Bytes);
public long this[int i]=>Value[i];

public static A141560Inst Instance=new A141560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141561
{
public static readonly long[] Value={ 5L,11L,29L,37L,41L,47L,59L,79L,89L,97L,101L,103L,107L,113L,113L,127L,139L,137L,139L,149L,149L,151L,167L,167L,157L,163L,179L,179L,181L,181L,181L,181L,181L,179L,173L,181L,179L,191L,181L,179L,181L,179L,179L,191L,191L,193L,193L,179L,181L,179L,173L,179L,173L,179L };
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
public class A141561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141561Inst : IEnumerable<long>
{
public static readonly long[] Value=A141561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141561.Bytes);
public long this[int i]=>Value[i];

public static A141561Inst Instance=new A141561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141562
{
public static readonly long[] Value={ 13L,19L,29L,59L,73L,83L,89L,97L,101L,103L,103L,107L,113L,127L,127L,131L,137L,139L,149L,163L,181L,193L,199L,197L,211L,211L,227L,227L,229L,233L,239L,241L,251L,257L,257L,257L,263L,269L,263L,269L,271L,269L,271L,281L,283L,293L,293L,307L,307L,307L,307L,307L,313L };
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
public class A141562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141562Inst : IEnumerable<long>
{
public static readonly long[] Value=A141562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141562.Bytes);
public long this[int i]=>Value[i];

public static A141562Inst Instance=new A141562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141563
{
public static readonly long[] Value={ 79L,499L,709L,919L,1129L,1549L,1759L,2179L,2389L,3019L,3229L,4909L,5119L,5749L,6379L,7219L,7639L,8059L,8269L,8689L,9109L,9319L,9739L,9949L,10159L,10369L,10789L,11839L,12049L,12889L,13099L,13309L,13729L,14149L,14779L,15199L,15619L,16249L,16879L };
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
public class A141563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141563Inst : IEnumerable<long>
{
public static readonly long[] Value=A141563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141563.Bytes);
public long this[int i]=>Value[i];

public static A141563Inst Instance=new A141563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141564
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,2L,6L,1L,2L,4L,10L,2L,12L,6L,8L,1L,16L,2L,18L,4L,12L,10L,22L,2L,4L,12L,4L,6L,28L,8L,30L,1L,20L,16L,24L,2L,36L,18L,24L,4L,40L,12L,42L,10L,8L,22L,46L,2L,6L,4L,32L,12L,52L,4L,40L,6L,36L,28L,58L,8L,60L,30L,12L,1L,48L,20L,66L,16L,44L,24L,70L,2L,72L,36L,8L,18L,60L,24L,78L,4L,8L };
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
public class A141564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141564Inst : IEnumerable<long>
{
public static readonly long[] Value=A141564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141564.Bytes);
public long this[int i]=>Value[i];

public static A141564Inst Instance=new A141564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141565
{
public static readonly long[] Value={ 2L,3L,4L,27L,6L,12L,8L,81L,64L,18L,12L,108L,14L,24L,24L,243L,18L,192L,20L,162L,32L,36L,24L,324L,216L,42L,256L,216L,30L,72L,32L,729L,48L,54L,48L,1728L,38L,60L,56L,486L,42L,96L,44L,324L,384L,72L,48L,972L,512L,648L,72L,378L,54L,768L,72L,648L,80L,90L,60L,648L,62L,96L,512L };
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
public class A141565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141565Inst : IEnumerable<long>
{
public static readonly long[] Value=A141565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141565.Bytes);
public long this[int i]=>Value[i];

public static A141565Inst Instance=new A141565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141566
{
public static readonly long[] Value={ 2L,3L,5L,27L,11L,15L,17L,243L,125L,33L,31L,135L,41L,51L,55L,2187L,59L,375L,67L,297L,85L,93L,83L,1215L,1331L,123L,3125L,459L,109L,165L,127L,177147L,155L,177L,187L,3375L,157L,201L,205L,2673L,179L,255L,191L,837L,1375L,249L,211L,10935L,4913L,3993L,295L,1107L,241L };
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
public class A141566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141566Inst : IEnumerable<long>
{
public static readonly long[] Value=A141566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141566.Bytes);
public long this[int i]=>Value[i];

public static A141566Inst Instance=new A141566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141567
{
public static readonly long[] Value={ 0L,1L,4L,1L,8L,4L,10L,1L,4L,8L,16L,4L,20L,10L,32L,1L,25L,4L,27L,8L,40L,16L,33L,4L,8L,20L,256L,10L,40L,32L,44L,1L,64L,25L,80L,4L,51L,27L,80L,8L,56L,40L,58L,16L,32L,33L,64L,4L,10L,8L,100L,20L,72L,256L,128L,10L,108L,40L,80L,32L,82L,44L,40L,1L,160L,64L,90L,25L,132L,80L,94L,4L,96L,51L,32L };
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
public class A141567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141567Inst : IEnumerable<long>
{
public static readonly long[] Value=A141567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141567.Bytes);
public long this[int i]=>Value[i];

public static A141567Inst Instance=new A141567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141568
{
public static readonly long[] Value={ 1L,4L,6L,256L,9L,24L,12L,4096L,1296L,36L,18L,1536L,21L,48L,54L,65536L,26L,5184L,28L,2304L,72L,72L,34L,24576L,6561L,84L,46656L,3072L,42L,216L,45L,262144L,108L,104L,108L,331776L,52L,112L,126L,36864L,57L,288L,60L,4608L,11664L,136L,65L,393216L,20736L,26244L,156L };
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
public class A141568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141568Inst : IEnumerable<long>
{
public static readonly long[] Value=A141568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141568.Bytes);
public long this[int i]=>Value[i];

public static A141568Inst Instance=new A141568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141569
{
public static readonly long[] Value={ 4L,6L,8L,46656L,10L,48L,14L,1679616L,262144L,60L,20L,373248L,22L,84L,80L,10077696L,27L,1572864L,30L,466560L,112L,120L,35L,13436928L,1000000L,132L,16777216L,653184L,44L,480L,46L,60466176L,160L,162L,140L,12230590464L,54L,180L,176L,16796160L,58L,672L,62L };
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
public class A141569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141569Inst : IEnumerable<long>
{
public static readonly long[] Value=A141569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141569.Bytes);
public long this[int i]=>Value[i];

public static A141569Inst Instance=new A141569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141570
{
public static readonly long[] Value={ 83L,293L,503L,1553L,1973L,2393L,3023L,3863L,4073L,4283L,4493L,4703L,5333L,6173L,6803L,7013L,7433L,7643L,7853L,8273L,8693L,9323L,9533L,9743L,10163L,11003L,11213L,11423L,11633L,12263L,12473L,12893L,13103L,13313L,13523L,14153L,14783L,15413L,16253L };
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
public class A141570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141570Inst : IEnumerable<long>
{
public static readonly long[] Value=A141570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141570.Bytes);
public long this[int i]=>Value[i];

public static A141570Inst Instance=new A141570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141571
{
public static readonly long[] Value={ 1L,2L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L };
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
public class A141571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141571Inst : IEnumerable<long>
{
public static readonly long[] Value=A141571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141571.Bytes);
public long this[int i]=>Value[i];

public static A141571Inst Instance=new A141571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141572
{
public static readonly long[] Value={ 2L,6L,10L,6L,14L,4L,9L,10L,22L,6L,26L,21L,10L,4L,34L,6L,57L,4L,15L,14L,253L,4L,6L,25L,26L,9L,6L,14L,58L,15L,62L,4L,4L,33L,34L,35L,4L,9L,74L,57L,26L,4L,205L,6L,301L,4L,33L,15L,46L,94L,4L,6L,49L,10L,15L,34L,26L,106L,9L,15L,22L,4L,21L,38L,1711L,4L,15L,122L,93L,21L,4L,4L,4L,65L,6L,737L,4L };
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
public class A141572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141572Inst : IEnumerable<long>
{
public static readonly long[] Value=A141572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141572.Bytes);
public long this[int i]=>Value[i];

public static A141572Inst Instance=new A141572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141573
{
public static readonly BigInteger[] Value={ 1L,9L,32L,8L,49L,4L,27L,32L,121L,8L,169L,343L,25L,4L,131072L,8L,1162261467L,4L,125L,49L,BigInteger.Parse("895430243255237372246531"),4L,8L,3125L,8192L,27L,9L,128L,841L,243L,961L,4L,4L,177147L,131072L,78125L,4L,27L,1369L,6859L,169L,4L,BigInteger.Parse("45474735088646411895751953125"),8L };
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
public class A141573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141573Inst Instance=new A141573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141574
{
public static readonly long[] Value={ 3L,5L,7L,5L,9L,4L,6L,7L,13L,5L,15L,10L,7L,4L,19L,5L,22L,4L,8L,9L,34L,4L,5L,10L,15L,6L,5L,9L,31L,8L,33L,4L,4L,14L,19L,12L,4L,6L,39L,22L,15L,4L,46L,5L,50L,4L,14L,8L,25L,49L,4L,5L,14L,7L,8L,19L,15L,55L,6L,8L,13L,4L,10L,21L,88L,4L,8L,63L,34L,10L,4L,4L,4L,18L,5L,78L,4L,20L,25L,12L,73L,4L,6L,75L };
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
public class A141574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141574Inst : IEnumerable<long>
{
public static readonly long[] Value=A141574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141574.Bytes);
public long this[int i]=>Value[i];

public static A141574Inst Instance=new A141574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141575
{
public static readonly long[] Value={ 1L,2L,2L,13L,17L,21L,185L,245L,305L,425L,7361L,12833L,18817L,32321L,47873L,215171L,271051L,328691L,449251L,576851L,853171L,12334505L,21164697L,31341961L,55836009L,86013257L,164203785L,212610281L,532365557L,659940697L,793109789L,1076412613L };
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
public class A141575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141575Inst : IEnumerable<long>
{
public static readonly long[] Value=A141575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141575.Bytes);
public long this[int i]=>Value[i];

public static A141575Inst Instance=new A141575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141592
{
public static readonly long[] Value={ 1308498L,3042492L,3042702L,7445310L,20031102L,31572522L,44687988L,54266292L };
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
public class A141592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141592Inst : IEnumerable<long>
{
public static readonly long[] Value=A141592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141592.Bytes);
public long this[int i]=>Value[i];

public static A141592Inst Instance=new A141592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141593
{
public static readonly long[] Value={ 1932L,14592L,122598L,377370L,2137548L,16134048L,18132978L,34083432L,43175478L,46683060L,64938702L };
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
public class A141593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141593Inst : IEnumerable<long>
{
public static readonly long[] Value=A141593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141593.Bytes);
public long this[int i]=>Value[i];

public static A141593Inst Instance=new A141593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141594
{
public static readonly long[] Value={ 6341442L,6837222L,11285508L,15315720L,174710022L,326603400L,434021520L,508246812L,711829818L };
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
public class A141594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141594Inst : IEnumerable<long>
{
public static readonly long[] Value=A141594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141594.Bytes);
public long this[int i]=>Value[i];

public static A141594Inst Instance=new A141594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141595
{
public static readonly long[] Value={ 3L,11L,24L,57L,137L,310L,672L,1445L };
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
public class A141595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141595Inst : IEnumerable<long>
{
public static readonly long[] Value=A141595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141595.Bytes);
public long this[int i]=>Value[i];

public static A141595Inst Instance=new A141595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141596
{
public static readonly long[] Value={ 1L,1L,1L,1L,13L,1L,1L,33L,33L,1L,1L,61L,141L,61L,1L,1L,97L,397L,397L,97L,1L,1L,141L,897L,1597L,897L,141L,1L,1L,193L,1761L,4897L,4897L,1761L,193L,1L,1L,253L,3133L,12541L,19597L,12541L,3133L,253L,1L,1L,321L,5181L,28221L,63501L,63501L,28221L,5181L,321L,1L,1L,397L,8097L };
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
public class A141596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141596Inst : IEnumerable<long>
{
public static readonly long[] Value=A141596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141596.Bytes);
public long this[int i]=>Value[i];

public static A141596Inst Instance=new A141596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141597
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,17L,17L,1L,1L,31L,71L,31L,1L,1L,49L,199L,199L,49L,1L,1L,71L,449L,799L,449L,71L,1L,1L,97L,881L,2449L,2449L,881L,97L,1L,1L,127L,1567L,6271L,9799L,6271L,1567L,127L,1L,1L,161L,2591L,14111L,31751L,31751L,14111L,2591L,161L,1L,1L,199L,4049L,28799L,88199L };
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
public class A141597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141597Inst : IEnumerable<long>
{
public static readonly long[] Value=A141597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141597.Bytes);
public long this[int i]=>Value[i];

public static A141597Inst Instance=new A141597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141598
{
public static readonly long[] Value={ 2L,8L,24L,192L,2880L,46272L,1250592L,44095488L };
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
public class A141598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141598Inst : IEnumerable<long>
{
public static readonly long[] Value=A141598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141598.Bytes);
public long this[int i]=>Value[i];

public static A141598Inst Instance=new A141598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141599
{
public static readonly long[] Value={ 1L,2L,4L,24L,288L,3856L,89328L,2755968L };
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
public class A141599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141599Inst : IEnumerable<long>
{
public static readonly long[] Value=A141599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141599.Bytes);
public long this[int i]=>Value[i];

public static A141599Inst Instance=new A141599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141600
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,8L,8L,1L,1L,8L,10L,8L,1L,1L,8L,10L,10L,8L,1L,1L,9L,12L,11L,12L,9L,1L,1L,10L,14L,14L,14L,14L,10L,1L,1L,10L,17L,18L,20L,18L,17L,10L,1L,1L,11L,20L,24L,28L,28L,24L,20L,11L,1L,1L,12L,24L,31L,40L,43L,40L,31L,24L,12L,1L };
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
public class A141600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141600Inst : IEnumerable<long>
{
public static readonly long[] Value=A141600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141600.Bytes);
public long this[int i]=>Value[i];

public static A141600Inst Instance=new A141600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141601
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,9L,9L,1L,1L,8L,36L,8L,1L,1L,8L,33L,33L,8L,1L,1L,9L,38L,33L,38L,9L,1L,1L,10L,44L,41L,41L,44L,10L,1L,1L,11L,52L,52L,54L,52L,52L,11L,1L,1L,12L,62L,67L,76L,76L,67L,62L,12L,1L,1L,12L,72L,86L,105L,113L,105L,86L,72L,12L,1L };
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
public class A141601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141601Inst : IEnumerable<long>
{
public static readonly long[] Value=A141601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141601.Bytes);
public long this[int i]=>Value[i];

public static A141601Inst Instance=new A141601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141602
{
public static readonly long[] Value={ 2L,2L,3L,5L,9L,15L,26L,46L,82L,147L,268L,492L,909L,1688L,3151L,5909L,11123L,21010L,39809L,75638L,144073L,275050L,526182L,1008516L,1936352L,3723754L,7171675L,13831089L,26708310L,51636066L,99940774L,193635250L,375535031L,728979766L,1416303547L };
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
public class A141602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141602Inst : IEnumerable<long>
{
public static readonly long[] Value=A141602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141602.Bytes);
public long this[int i]=>Value[i];

public static A141602Inst Instance=new A141602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141603
{
public static readonly long[] Value={ 9L,21L,25L,27L,33L,63L,77L,81L,93L,105L,125L,143L,147L,153L,165L,171L,175L,185L,235L,243L,247L,249L,255L,273L,285L,301L,321L,335L,345L,363L,405L,437L,473L,475L,483L,517L,529L,533L,559L,567L,579L,585L,591L,603L,627L,671L,689L,711L,767L,789L,793L,825L,861L,873L,891L,897L };
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
public class A141603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141603Inst : IEnumerable<long>
{
public static readonly long[] Value=A141603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141603.Bytes);
public long this[int i]=>Value[i];

public static A141603Inst Instance=new A141603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141604
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,4L,7L,4L,2L,1L,1L,3L,8L,12L,12L,8L,3L,1L,1L,3L,8L,20L,15L,20L,8L,3L,1L,1L,5L,14L,45L,52L,52L,45L,14L,5L,1L,1L,5L,26L,66L,109L,170L,109L,66L,26L,5L,1L };
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
public class A141604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141604Inst : IEnumerable<long>
{
public static readonly long[] Value=A141604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141604.Bytes);
public long this[int i]=>Value[i];

public static A141604Inst Instance=new A141604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141605
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,3L,3L,3L,1L,1L,2L,5L,5L,5L,5L,2L,1L,1L,2L,3L,9L,9L,9L,3L,2L,1L,1L,3L,5L,8L,23L,23L,8L,5L,3L,1L,1L,3L,8L,15L,25L,75L,25L,15L,8L,3L,1L };
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
public class A141605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141605Inst : IEnumerable<long>
{
public static readonly long[] Value=A141605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141605.Bytes);
public long this[int i]=>Value[i];

public static A141605Inst Instance=new A141605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141606
{
public static readonly long[] Value={ 1L,5L,7L,8L,4L,4L,6L,9L,1L,4L,1L,9L,1L,2L,7L,6L,1L,8L,6L,9L,1L,1L,4L,7L,1L,4L,5L,7L,2L,5L,0L,5L,8L,8L,7L,1L,8L,6L,2L,5L,0L,8L,5L,8L,8L,1L,7L,2L,6L,9L,7L,2L,6L,3L,7L,0L,9L,1L,7L,8L,2L,9L,6L,2L,5L,7L,9L,8L,3L,1L,3L,1L,3L,0L,2L,9L,8L,6L,4L,6L,0L,1L,8L,7L,1L,0L,0L,5L,1L,8L,5L,6L,3L,8L,8L,6L,3L,7L,3L,7L,1L,0L,5L,5L,5L };
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
public class A141606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141606Inst : IEnumerable<long>
{
public static readonly long[] Value=A141606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141606.Bytes);
public long this[int i]=>Value[i];

public static A141606Inst Instance=new A141606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141607
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,9L,10L,12L,15L,20L,21L,22L,24L,25L,26L,27L,33L,35L,36L,44L,45L,48L,50L,51L,57L,60L,62L,63L,68L,69L,72L,74L,75L,82L,84L,85L,90L,93L,98L,105L,110L,111L,115L,121L,122L,126L,129L,134L,135L,136L,138L,142L,143L,144L,145L,147L,148L,158L,165L,166L,169L,170L,172L,174L,176L };
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
public class A141607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141607Inst : IEnumerable<long>
{
public static readonly long[] Value=A141607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141607.Bytes);
public long this[int i]=>Value[i];

public static A141607Inst Instance=new A141607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141640
{
public static readonly long[] Value={ 1L,9L,10L,18L,27L,36L,45L,54L,63L,69L,72L,78L,81L,87L,90L,96L,100L,108L,117L,126L,135L,144L,153L,159L,162L,168L,171L,177L,180L,186L,195L,207L,216L,225L,234L,243L,249L,252L,258L,261L,267L,270L,276L,285L,294L,306L,315L,324L,333L,339L,342L,348L,351L,357L,360L,366L };
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
public class A141640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141640Inst : IEnumerable<long>
{
public static readonly long[] Value=A141640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141640.Bytes);
public long this[int i]=>Value[i];

public static A141640Inst Instance=new A141640Inst();

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