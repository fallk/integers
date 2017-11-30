using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A143404
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,135L,10065L,547965L,24336312L,934863930L,32189799070L,1017281878470L,30001945084683L,835898091070185L,22206607023852615L,566594907018764715L,13964270139973201114UL,BigInteger.Parse("333991935681805199700"),BigInteger.Parse("7781827783346875932300") };
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
public class A143404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143404Inst Instance=new A143404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143403
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,108L,6510L,289080L,10550067L,335170836L,9597839680L,253489991040L,6275077781973L,147318890173884L,3309320153700210L,71623038281001480L,1501654449863348119L,BigInteger.Parse("30633757929391948452"),BigInteger.Parse("610246760750629071300"),BigInteger.Parse("11906371167306982146000") };
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
public class A143403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143403Inst Instance=new A143403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143402
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,84L,3990L,141120L,4138827L,106469748L,2484848080L,53791898160L,1096912870053L,21307466872692L,397605494092170L,7173885616672320L,125794299357058879L,2152559266567924116L,BigInteger.Parse("36065247772657686660"),BigInteger.Parse("593280221500152370800") };
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
public class A143402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143402Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143402.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143402Inst Instance=new A143402Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143401
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,1L,63L,2282L,62370L,1428987L,28979181L,537306484L,9302333040L,152587968533L,2396472657579L,36320866824606L,534421447961310L,7670116319449039L,107781064078390857L,1487396442778796648L,BigInteger.Parse("20208696810429799980"),BigInteger.Parse("270879169288278532905") };
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
public class A143401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143401Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143401.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143401Inst Instance=new A143401Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143400
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,1L,45L,1190L,24150L,416451L,6427575L,91549480L,1227283200L,15695180501L,193333245105L,2310273772170L,26927270656650L,307413790470151L,3449088814306635L,38132767214613260L,416342920938136500L,4497187699884973401L,BigInteger.Parse("48129773048982636165") };
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
public class A143400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143400Inst Instance=new A143400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143383
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,40L,240L,560L,13440L,120960L,241920L,887040L,394240L,138378240L,276756480L,593049600L,66421555200L,4136140800L,173717913600L,14302774886400L,171633298636800L,144171970854912L,7208598542745600L,283414985441280L };
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
public class A143383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143383Inst : IEnumerable<long>
{
public static readonly long[] Value=A143383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143383.Bytes);
public long this[int i]=>Value[i];

public static A143383Inst Instance=new A143383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143382
{
public static readonly long[] Value={ 1L,2L,5L,17L,71L,121L,731L,1711L,41099L,370019L,740101L,2713789L,1206137L,423355111L,846710651L,1814380259L,203210595443L,12654139763L,531473870981L,43758015399281L,525096184837561L,441080795274037L,22054039763790029L };
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
public class A143382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143382Inst : IEnumerable<long>
{
public static readonly long[] Value=A143382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143382.Bytes);
public long this[int i]=>Value[i];

public static A143382Inst Instance=new A143382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143381
{
public static readonly long[] Value={ 0L,2L,0L,6L,2L,0L,14L,30L,2L,0L,78L,230L,174L,2L,0L,230L,14094L,4834L,1092L,2L,0L,1902L,187106L,3785126L,114442L,7188L,2L,0L,6902L,26185806L,250560122L,1225289412L,2908990L,48852L,2L,0L,76110L,557115782L,682502468094L,423419180642L };
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
public class A143381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143381Inst : IEnumerable<long>
{
public static readonly long[] Value=A143381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143381.Bytes);
public long this[int i]=>Value[i];

public static A143381Inst Instance=new A143381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143380
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,-2L,0L,0L,-3L,0L,0L,0L,-2L,-2L,0L,0L,2L,-2L,0L,0L,-1L,2L,0L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,-2L,0L,0L,4L,2L,0L,0L,-2L,0L,0L,0L,0L,2L,0L,0L,-1L,0L,0L,0L,-2L,0L,0L,0L,2L,-4L,0L,0L,-1L,-2L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,-2L,-2L,0L,0L,-2L,2L,0L,0L,0L };
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
public class A143380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143380Inst : IEnumerable<long>
{
public static readonly long[] Value=A143380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143380.Bytes);
public long this[int i]=>Value[i];

public static A143380Inst Instance=new A143380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143379
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,-1L,1L,1L,1L,-1L,1L,0L,1L,0L,0L,-2L,-1L,0L,0L,-1L,1L,1L,-2L,0L,0L,0L,1L,1L,0L,2L,0L,1L,-1L,-1L,0L,1L,-1L,0L,0L,1L,0L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,-1L,-1L,2L,0L,-1L,1L,-1L,1L,0L,3L,1L,-1L,0L,0L,0L,1L,-2L,0L,0L,-1L,-1L,0L,-1L,0L,1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,0L,0L,-1L,0L,-2L,0L,1L,2L,1L,-1L,0L,2L,1L,0L,0L,0L,0L,1L };
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
public class A143379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143379Inst : IEnumerable<long>
{
public static readonly long[] Value=A143379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143379.Bytes);
public long this[int i]=>Value[i];

public static A143379Inst Instance=new A143379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143378
{
public static readonly long[] Value={ 1L,1L,-3L,-2L,2L,-1L,0L,1L,2L,4L,-2L,0L,-1L,-2L,2L,-1L,0L,-2L,-2L,-2L,0L,0L,1L,4L,-2L,2L,1L,0L,-2L,0L,4L,0L,2L,0L,0L,1L,0L,-4L,0L,-2L,-3L,0L,2L,2L,-4L,0L,0L,2L,-2L,0L,-2L,-3L,2L,0L,2L,2L,0L,1L,4L,0L,0L,0L,2L,0L,0L,-4L,0L,2L,0L,2L,-1L,0L,0L,2L,-2L,2L,-2L,-1L,-2L,-4L,0L,0L,0L,-2L,-2L,0L,0L,2L,2L,-2L,2L,0L,1L,0L,0L,-2L,0L,0L,0L,-2L,5L,2L,-4L,2L,0L };
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
public class A143378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143378Inst : IEnumerable<long>
{
public static readonly long[] Value=A143378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143378.Bytes);
public long this[int i]=>Value[i];

public static A143378Inst Instance=new A143378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143377
{
public static readonly long[] Value={ 1L,-2L,0L,0L,1L,2L,0L,0L,-3L,0L,0L,0L,-2L,2L,0L,0L,2L,2L,0L,0L,-1L,-2L,0L,0L,0L,-2L,0L,0L,1L,-2L,0L,0L,2L,2L,0L,0L,4L,-2L,0L,0L,-2L,0L,0L,0L,0L,-2L,0L,0L,-1L,0L,0L,0L,-2L,0L,0L,0L,2L,4L,0L,0L,-1L,2L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,-2L,2L,0L,0L,-2L,-2L,0L,0L,0L,-2L,0L,0L,0L,4L,0L,0L,1L,0L,0L,0L,4L,0L,0L,0L,-2L,0L,0L,0L,2L,-2L,0L,0L,1L };
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
public class A143377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143377Inst : IEnumerable<long>
{
public static readonly long[] Value=A143377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143377.Bytes);
public long this[int i]=>Value[i];

public static A143377Inst Instance=new A143377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143376
{
public static readonly long[] Value={ 1L,4L,2L,12L,12L,4L,32L,48L,32L,8L,80L,160L,160L,80L,16L,192L,480L,640L,480L,192L,32L,448L,1344L,2240L,2240L,1344L,448L,64L,1024L,3584L,7168L,8960L,7168L,3584L,1024L,128L,2304L,9216L,21504L,32256L,32256L,21504L,9216L,2304L,256L,5120L,23040L,61440L,107520L };
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
public class A143376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143376Inst : IEnumerable<long>
{
public static readonly long[] Value=A143376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143376.Bytes);
public long this[int i]=>Value[i];

public static A143376Inst Instance=new A143376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143375
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,4L,2L,6L,8L,8L,19L,14L,34L,36L,54L,86L,93L,172L,194L,308L,427L,552L,878L,1076L,1675L,2224L,3120L,4546L,5986L,8928L,11933L,17104L,24005L,32928L,47534L,64640L,92523L,128348L,179418L,253994L,350622L,498000L,690790L,971508L,1362840L };
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
public class A143375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143375Inst : IEnumerable<long>
{
public static readonly long[] Value=A143375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143375.Bytes);
public long this[int i]=>Value[i];

public static A143375Inst Instance=new A143375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143374
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,1L,2L,-1L,2L,0L,-1L,0L,0L,0L,-2L,-2L,2L,-3L,-1L,1L,2L,3L,4L,1L,-3L,0L,-2L,3L,-4L,2L,0L,-1L,-1L,-2L,-1L,0L,-2L,-2L,2L,2L,-1L,0L,5L,-1L,5L,0L,2L,-3L,-3L,-3L,1L,3L,2L,2L,-2L,4L,-6L,-4L,2L,-2L,-1L,2L,-6L,0L,8L,-4L,-3L,2L,5L,1L,-6L,3L,6L,-1L,1L,-4L,-10L,1L,2L,-1L,2L,-5L,-2L,6L,13L,4L,1L,-1L,2L,1L,4L,-4L,-1L };
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
public class A143374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143374Inst : IEnumerable<long>
{
public static readonly long[] Value=A143374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143374.Bytes);
public long this[int i]=>Value[i];

public static A143374Inst Instance=new A143374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143373
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,30L,55L,100L,181L,330L,599L,1088L,1978L,3593L,6529L,11864L,21556L,39169L,71171L,129319L,234978L,426961L,775801L,1409655L,2561384L,4654113L,8456664L,15366012L,27920509L };
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
public class A143373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143373Inst : IEnumerable<long>
{
public static readonly long[] Value=A143373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143373.Bytes);
public long this[int i]=>Value[i];

public static A143373Inst Instance=new A143373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143372
{
public static readonly long[] Value={ 1L,-1L,3L,-4L,10L,-13L,27L,-38L,70L,-99L,173L,-242L,400L,-548L,869L,-1136L,1718L,-2088L,2936L,-3033L,3615L,-1763L,-513L,10082L,-24172L,58958L,-111749L,220258L,-385285L,693194L,-1157154L };
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
public class A143372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143372Inst : IEnumerable<long>
{
public static readonly long[] Value=A143372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143372.Bytes);
public long this[int i]=>Value[i];

public static A143372Inst Instance=new A143372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143371
{
public static readonly long[] Value={ 1L,8L,25L,56L,105L,176L,273L,400L,561L,760L,1001L,1288L,1625L,2016L,2465L,2976L,3553L,4200L,4921L,5720L,6601L,7568L,8625L,9776L,11025L,12376L,13833L,15400L,17081L,18880L,20801L,22848L,25025L,27336L,29785L,32376L,35113L,38000L,41041L,44240L,47601L };
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
public class A143371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143371Inst : IEnumerable<long>
{
public static readonly long[] Value=A143371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143371.Bytes);
public long this[int i]=>Value[i];

public static A143371Inst Instance=new A143371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143370
{
public static readonly long[] Value={ 1L,4L,2L,7L,6L,2L,10L,10L,6L,2L,13L,14L,10L,6L,2L,16L,18L,14L,10L,6L,2L,19L,22L,18L,14L,10L,6L,2L,22L,26L,22L,18L,14L,10L,6L,2L,25L,30L,26L,22L,18L,14L,10L,6L,2L,28L,34L,30L,26L,22L,18L,14L,10L,6L,2L,31L,38L,34L,30L,26L,22L,18L,14L,10L,6L,2L,34L,42L,38L,34L,30L,26L,22L,18L,14L,10L,6L,2L };
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
public class A143370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143370Inst : IEnumerable<long>
{
public static readonly long[] Value=A143370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143370.Bytes);
public long this[int i]=>Value[i];

public static A143370Inst Instance=new A143370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143369
{
public static readonly long[] Value={ 36604L,304804L,2137492L,13143988L,73561204L,385003252L,1919944180L,9239885812L,43293991924L,198728338420L,897605155828L,4002258869236L,17658743397364L,77238940933108L,335382756072436L,1447262942927860L,6212030751579124L,26540148350000116L,112928927250390004L };
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
public class A143369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143369Inst : IEnumerable<long>
{
public static readonly long[] Value=A143369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143369.Bytes);
public long this[int i]=>Value[i];

public static A143369Inst Instance=new A143369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143368
{
public static readonly long[] Value={ 0L,1L,8L,4L,25L,72L,10L,56L,154L,320L,20L,105L,280L,570L,1000L,35L,176L,459L,920L,1595L,2520L,56L,273L,700L,1386L,2380L,3731L,5488L,84L,400L,1012L,1984L,3380L,5264L,7700L,10752L,120L,561L,1404L,2730L,4620L,7155L,10416L,14484L,19440L };
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
public class A143368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143368Inst : IEnumerable<long>
{
public static readonly long[] Value=A143368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143368.Bytes);
public long this[int i]=>Value[i];

public static A143368Inst Instance=new A143368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143303
{
public static readonly long[] Value={ 1L,3L,5L,1L,1L,3L,1L,5L,7L,4L,4L,9L,1L,6L,5L,9L,0L,0L,1L,7L,9L,3L,8L,6L,8L,0L,0L,5L,2L,5L,6L,5L,2L,1L };
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
public class A143303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143303Inst : IEnumerable<long>
{
public static readonly long[] Value=A143303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143303.Bytes);
public long this[int i]=>Value[i];

public static A143303Inst Instance=new A143303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143302
{
public static readonly long[] Value={ 1L,9L,9L,4L,5L,8L,8L,1L,8L };
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
public class A143302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143302Inst : IEnumerable<long>
{
public static readonly long[] Value=A143302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143302.Bytes);
public long this[int i]=>Value[i];

public static A143302Inst Instance=new A143302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143301
{
public static readonly long[] Value={ 1L,7L,1L,5L,0L,0L,4L,9L,3L,1L,4L,1L,5L,3L,6L,0L,6L,5L,8L,6L,0L,4L,3L,9L,9L,7L,1L,5L,5L,5L,2L,1L,2L,1L,0L,9L,6L,2L,2L,2L,6L,2L,9L,0L,4L,2L,2L,9L,5L,5L,0L,8L,4L,1L,7L,1L,4L,2L,1L,1L,0L,9L,1L,8L,2L,3L,6L,9L,8L,6L,0L,5L,5L,9L,4L,3L,0L,8L,5L,7L,7L,9L,8L,7L,9L,7L,1L,1L,9L,8L,0L,8L,6L,8L,0L,0L,8L,1L,7L,3L,0L,6L,4L,2L,3L };
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
public class A143301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143301Inst : IEnumerable<long>
{
public static readonly long[] Value=A143301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143301.Bytes);
public long this[int i]=>Value[i];

public static A143301Inst Instance=new A143301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143300
{
public static readonly long[] Value={ 1L,1L,1L,7L,8L,6L,4L,1L,5L,1L,1L,8L,9L,9L,4L,4L,9L,7L,3L,1L,4L,0L,4L,0L,9L,9L,6L,2L,0L,2L,6L,5L,6L,5L,4L,4L,4L,1L,6L,3L,1L,1L,5L,5L,1L,2L,0L,4L,1L,2L,8L,8L,4L,2L,6L,5L,0L,6L,2L,8L,6L,5L,1L,4L,0L,1L,6L,0L,5L,4L,5L,5L,1L,8L,4L,2L,0L,3L,8L,5L,9L,1L,8L,1L,4L,8L,8L,0L,0L,7L,3L,5L,6L,5L,0L,0L,5L,2L,7L,1L,2L,9L,1L,2L,7L };
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
public class A143300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143300Inst : IEnumerable<long>
{
public static readonly long[] Value=A143300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143300.Bytes);
public long this[int i]=>Value[i];

public static A143300Inst Instance=new A143300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143299
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,4L,2L,3L,3L,3L,4L,3L,4L,4L,2L,3L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,5L,2L,3L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,5L,3L,4L,4L,4L,5L,4L,5L,5L,2L,3L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,5L,3L,4L,4L,4L,5L,4L,5L,5L,3L,4L,4L,4L,5L,4L,5L,5L,4L,5L,5L,5L,6L,2L,3L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,5L,3L,4L,4L };
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
public class A143299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143299Inst : IEnumerable<long>
{
public static readonly long[] Value=A143299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143299.Bytes);
public long this[int i]=>Value[i];

public static A143299Inst Instance=new A143299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143298
{
public static readonly long[] Value={ 1L,0L,1L,4L,9L,4L,1L,6L,0L,6L,4L,0L,9L,6L,5L,3L,6L,2L,5L,0L,2L,1L,2L,0L,2L,5L,5L,4L,2L,7L,4L,5L,2L,0L,2L,8L,5L,9L,4L,1L,6L,8L,9L,3L,0L,7L,5L,3L,0L,2L,9L,9L,7L,9L,2L,0L,1L,7L,4L,8L,9L,1L,0L,6L,7L,7L,6L,5L,9L,7L,4L,7L,6L,2L,5L,8L,2L,4L,4L,0L,2L,2L,1L,3L,6L,4L,7L,0L,3L,5L,4L,2L,2L,8L,2L,5L,6L,6L,9L,4L,9L,4L,5L,8L,6L };
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
public class A143298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143298Inst : IEnumerable<long>
{
public static readonly long[] Value=A143298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143298.Bytes);
public long this[int i]=>Value[i];

public static A143298Inst Instance=new A143298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143297
{
public static readonly long[] Value={ 7L,5L,7L,8L,2L,3L,0L,1L,1L,2L,6L,8L,4L,9L,2L,8L,3L,7L,7L,4L,2L,1L,7L,5L,6L,8L,3L,9L,8L,0L,0L,9L,9L,7L,8L,2L,5L,2L,3L,6L,5L,8L,5L,8L,5L,6L,4L,6L,0L,8L,0L,1L,9L,7L,0L,2L,7L,0L,9L,5L,5L,5L,8L,6L,5L,4L,2L,4L,1L,4L,3L,9L,0L,0L,4L,6L,6L,0L,6L,9L,0L,0L,6L,6L,8L,6L,8L,9L,4L,3L,4L,6L,2L,3L,8L,8L,6L,0L,6L,1L,3L,2L,1L,7L,0L };
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
public class A143297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143297Inst : IEnumerable<long>
{
public static readonly long[] Value=A143297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143297.Bytes);
public long this[int i]=>Value[i];

public static A143297Inst Instance=new A143297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143296
{
public static readonly long[] Value={ 9L,1L,5L,5L,0L,2L,0L,5L,5L,3L,8L,9L,6L,7L,6L,3L,9L,6L,3L,0L,5L,5L,2L,4L,0L,3L,6L,4L,0L,1L,6L,6L,2L,2L,8L,9L,6L,5L,4L,3L,1L,2L,9L,4L,2L,2L,8L,8L,4L,6L,0L,7L,6L,6L,7L,5L,0L,1L,7L,7L,6L,3L,4L,0L,0L,3L,9L,7L,8L,8L,0L,2L,7L,5L,4L,6L,1L,2L,2L,1L,6L,7L,9L,7L,9L,2L,3L,7L,7L,4L,4L,8L,3L,0L,9L,6L,9L,2L,8L,1L,8L,8L,5L,8L,0L };
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
public class A143296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143296Inst : IEnumerable<long>
{
public static readonly long[] Value=A143296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143296.Bytes);
public long this[int i]=>Value[i];

public static A143296Inst Instance=new A143296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143295
{
public static readonly long[] Value={ 3L,1L,1L,0L,7L,8L,8L,6L,6L,7L,0L,4L,8L,1L,9L,2L,0L,9L,0L,2L,7L,5L,4L,6L,9L,5L,9L,0L,9L,1L,4L,2L,1L,8L,0L,2L,6L,4L,8L,9L,5L,7L,1L,5L,8L,4L,3L,2L,8L,5L,8L,6L,7L,4L,5L,4L,9L,4L,9L,4L,9L,1L,7L,0L,6L,7L,9L,5L,7L,5L,2L,8L,3L,1L,9L,2L,0L,2L,7L,5L,3L,3L,0L,7L,1L,2L,0L,5L,2L,7L,1L,6L,3L,8L,4L,9L,5L,1L,7L,1L,5L,8L,7L,0L,3L };
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
public class A143295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143295Inst : IEnumerable<long>
{
public static readonly long[] Value=A143295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143295.Bytes);
public long this[int i]=>Value[i];

public static A143295Inst Instance=new A143295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143294
{
public static readonly long[] Value={ 1L,1L,1L,53L,7L,11L,43L,11L,13L,43L,11L,17L,1L,53L,43L,67L,1L,197L,227L,157L,11L,53L,31L,1L,17L,1L,53L,49L,23L,73L,17L,1L,13L,179L,19L,269L,47L,311L,97L,67L,13L,17L,67L,11L,157L,59L,41L,11L,253L,53L,187L,79L,137L,157L,67L,133L,211L,11L,83L,67L,53L,13L,59L,7L,17L,703L,47L,17L,109L };
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
public class A143294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143294Inst : IEnumerable<long>
{
public static readonly long[] Value=A143294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143294.Bytes);
public long this[int i]=>Value[i];

public static A143294Inst Instance=new A143294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143293
{
public static readonly BigInteger[] Value={ 1L,3L,9L,39L,249L,2559L,32589L,543099L,10242789L,233335659L,6703028889L,207263519019L,7628001653829L,311878265181039L,13394639596851069L,628284422185342479L,BigInteger.Parse("33217442899375387209"),BigInteger.Parse("1955977793053588026279"),BigInteger.Parse("119244359152460559009549") };
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
public class A143293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143293Inst Instance=new A143293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143292
{
public static readonly long[] Value={ 3L,2L,7L,4L,14L,11L,25L,26L,28L,19L,16L,55L,61L,62L,56L,47L,38L,35L,98L,100L,109L,104L,122L,117L,81L,87L,84L,94L,91L,73L,64L,194L,205L,206L,223L,220L,211L,242L,244L,251L,234L,239L,224L,161L,167L,164L,186L,176L,146L,151L,157L,152L,137L,134L,385L,388L,395L,392L,415L };
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
public class A143292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143292Inst : IEnumerable<long>
{
public static readonly long[] Value=A143292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143292.Bytes);
public long this[int i]=>Value[i];

public static A143292Inst Instance=new A143292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143291
{
public static readonly long[] Value={ 1L,3L,1L,8L,2L,1L,19L,4L,2L,1L,43L,8L,3L,2L,1L,94L,15L,5L,3L,2L,1L,201L,27L,9L,4L,3L,2L,1L,423L,48L,15L,6L,4L,3L,2L,1L,880L,84L,24L,10L,5L,4L,3L,2L,1L,1815L,145L,38L,16L,7L,5L,4L,3L,2L,1L,3719L,248L,60L,24L,11L,6L,5L,4L,3L,2L,1L,7582L,421L,94L,35L,17L,8L,6L,5L,4L,3L,2L,1L,15397L,710L,146L,51L,25L,12L,7L,6L,5L,4L,3L,2L,1L };
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
public class A143291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143291Inst : IEnumerable<long>
{
public static readonly long[] Value=A143291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143291.Bytes);
public long this[int i]=>Value[i];

public static A143291Inst Instance=new A143291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143290
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,17L,23L,31L,41L,53L,67L,83L,101L,121L,143L,168L,198L,236L,285L,348L,428L,528L,651L,800L,978L,1188L,1434L,1722L,2061L,2464L,2948L,3534L,4247L,5116L,6174L,7458L,9009L,10873L,13103L,15762L,18927L };
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
public class A143290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143290Inst : IEnumerable<long>
{
public static readonly long[] Value=A143290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143290.Bytes);
public long this[int i]=>Value[i];

public static A143290Inst Instance=new A143290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143289
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,16L,22L,30L,40L,52L,66L,82L,100L,120L,143L,171L,207L,254L,315L,393L,491L,612L,759L,935L,1144L,1392L,1688L,2045L,2480L,3014L,3672L,4483L,5480L,6700L,8185L,9984L,12156L,14774L,17930L,21740L,26349L,31936L };
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
public class A143289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143289Inst : IEnumerable<long>
{
public static readonly long[] Value=A143289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143289.Bytes);
public long this[int i]=>Value[i];

public static A143289Inst Instance=new A143289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143288
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,15L,21L,29L,39L,51L,65L,81L,99L,120L,146L,180L,225L,284L,360L,456L,575L,720L,895L,1106L,1362L,1676L,2065L,2550L,3156L,3912L,4851L,6011L,7437L,9184L,11321L,13936L,17141L,21077L,25919L,31881L,39222L,48254L };
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
public class A143288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143288Inst : IEnumerable<long>
{
public static readonly long[] Value=A143288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143288.Bytes);
public long this[int i]=>Value[i];

public static A143288Inst Instance=new A143288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143271
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,6L,3L,6L,9L,12L,2L,4L,6L,8L,10L,4L,8L,12L,16L,20L,24L,2L,4L,6L,8L,10L,12L,14L,4L,8L,12L,16L,20L,24L,28L,32L,3L,6L,9L,12L,15L,18L,21L,24L,27L,4L,8L,12L,16L,20L,24L,28L,32L,36L,40L,2L,4L,6L,8L,10L,12L,146L,16L,18L,20L,22L,6L,12L,18L,24L,30L,36L,42L,48L,54L,60L,66L,72L };
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
public class A143271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143271Inst : IEnumerable<long>
{
public static readonly long[] Value=A143271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143271.Bytes);
public long this[int i]=>Value[i];

public static A143271Inst Instance=new A143271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143270
{
public static readonly long[] Value={ 1L,4L,12L,24L,50L,72L,126L,176L,252L,320L,462L,552L,754L,896L,1080L,1280L,1632L,1836L,2280L,2560L,2940L,3300L,3956L,4320L,5000L,5512L,6210L,6776L,7830L,8340L,9548L,10368L,11352L,12240L,13440L,14256L,15984L,17100L,18486L,19600L,21730L,22764L,25112L };
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
public class A143270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143270Inst : IEnumerable<long>
{
public static readonly long[] Value=A143270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143270.Bytes);
public long this[int i]=>Value[i];

public static A143270Inst Instance=new A143270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143269
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,6L,4L,4L,8L,8L,5L,5L,10L,10L,20L,6L,6L,12L,12L,24L,12L,7L,7L,14L,14L,28L,14L,42L,8L,8L,16L,16L,32L,16L,48L,32L,9L,9L,18L,18L,36L,18L,54L,36L,54L,10L,10L,20L,20L,40L,20L,60L,40L,60L,40L,11L,11L,22L,22L,44L,22L,66L,44L,66L,44L,110L };
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
public class A143269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143269Inst : IEnumerable<long>
{
public static readonly long[] Value=A143269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143269.Bytes);
public long this[int i]=>Value[i];

public static A143269Inst Instance=new A143269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143268
{
public static readonly long[] Value={ 1L,3L,12L,20L,60L,42L,168L,144L,270L,220L,660L,312L,1092L,630L,960L,1088L,2448L,1026L,3420L,1680L,2772L,2530L,6072L,2400L,6500L,4212L,6804L,4872L,12180L,3720L,14880L,8448L,11220L,9520L,15120L,7992L,25308L,13338L,18720L,13120L,34440L,10836L,39732L };
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
public class A143268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143268Inst : IEnumerable<long>
{
public static readonly long[] Value=A143268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143268.Bytes);
public long this[int i]=>Value[i];

public static A143268Inst Instance=new A143268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143267
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,2L,4L,6L,8L,4L,8L,12L,16L,20L,2L,4L,6L,8L,10L,12L,6L,12L,18L,24L,30L,36L,42L,4L,8L,12L,16L,20L,24L,28L,32L,6L,12L,18L,24L,30L,36L,42L,48L,54L,4L,8L,12L,16L,20L,24L,28L,32L,36L,40L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L };
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
public class A143267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143267Inst : IEnumerable<long>
{
public static readonly long[] Value=A143267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143267.Bytes);
public long this[int i]=>Value[i];

public static A143267Inst Instance=new A143267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143266
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,4L,4L,0L,0L,4L,28L,28L,0L,0L,0L,76L,550L,550L,0L,0L,0L,0L,4465L,28456L,28456L,0L,0L,0L,0L,1L,828038L,4134861L,4134861L,0L,0L,0L,0L,0L,4205L,473635054L,1781622569L,1781622569L };
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
public class A143266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143266Inst : IEnumerable<long>
{
public static readonly long[] Value=A143266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143266.Bytes);
public long this[int i]=>Value[i];

public static A143266Inst Instance=new A143266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143265
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,11L,12L,13L,15L,15L,16L,17L,18L,19L,21L,25L,105L,23L,24L,25L,1155L,27L,30L,29L,30L,31L,32L,35L,15015L,35L,36L,37L,255255L,385L,42L,41L,45L,43L,105L,45L,4849845L,47L,48L,49L,51L,5005L,1155L,53L,54L,56L,60L,85085L,111546435L,59L,60L,61L };
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
public class A143265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143265Inst : IEnumerable<long>
{
public static readonly long[] Value=A143265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143265.Bytes);
public long this[int i]=>Value[i];

public static A143265Inst Instance=new A143265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143264
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,10L,14L,15L,16L,18L,20L,21L,22L,26L,27L,30L,31L,32L,42L,46L,48L,54L,55L,58L,62L,63L,64L,68L,72L,75L,78L,84L,85L,86L,87L,90L,91L,93L,94L,95L,102L,105L,106L,110L,111L,112L,114L,118L,119L,120L,122L,123L,125L,126L,127L,132L,144L,147L,148L,150L,154L,160L,164L };
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
public class A143264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143264Inst : IEnumerable<long>
{
public static readonly long[] Value=A143264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143264.Bytes);
public long this[int i]=>Value[i];

public static A143264Inst Instance=new A143264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143263
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,12L,13L,17L,19L,23L,24L,25L,28L,29L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,47L,49L,50L,51L,52L,53L,56L,57L,59L,60L,61L,65L,66L,67L,69L,70L,71L,73L,74L,76L,77L,79L,80L,81L,82L,83L,88L,89L,92L,96L,97L,98L,99L,100L,101L,103L,104L,107L,108L,109L,113L,115L };
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
public class A143263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143263Inst : IEnumerable<long>
{
public static readonly long[] Value=A143263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143263.Bytes);
public long this[int i]=>Value[i];

public static A143263Inst Instance=new A143263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143262
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,0L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,2L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,0L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,2L,0L,1L,1L,0L };
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
public class A143262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143262Inst : IEnumerable<long>
{
public static readonly long[] Value=A143262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143262.Bytes);
public long this[int i]=>Value[i];

public static A143262Inst Instance=new A143262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143261
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,3L,5L,3L,1L,1L,7L,15L,15L,7L,1L,1L,5L,1L,15L,1L,5L,1L,1L,1L,31L,19L,19L,31L,1L,1L,1L,3L,9L,9L,83L,9L,9L,3L,1L,1L,11L,27L,63L,65L,65L,63L,27L,11L,1L,1L,15L,55L,17L,221L,65L,221L,17L,55L,15L,1L,1L,7L,13L,239L,495L,297L,297L,495L,239L,13L,7L,1L };
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
public class A143261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143261Inst : IEnumerable<long>
{
public static readonly long[] Value=A143261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143261.Bytes);
public long this[int i]=>Value[i];

public static A143261Inst Instance=new A143261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143260
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,101L,103L,109L,127L,131L,137L,139L,151L,163L,173L,181L,191L,193L,197L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,313L,317L,331L,349L,353L,367L,373L,379L,383L };
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
public class A143260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143260Inst : IEnumerable<long>
{
public static readonly long[] Value=A143260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143260.Bytes);
public long this[int i]=>Value[i];

public static A143260Inst Instance=new A143260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143259
{
public static readonly long[] Value={ 1L,-1L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L };
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
public class A143259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143259Inst : IEnumerable<long>
{
public static readonly long[] Value=A143259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143259.Bytes);
public long this[int i]=>Value[i];

public static A143259Inst Instance=new A143259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143258
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,4L,2L,1L,1L,1L,1L,1L,1L,6L,2L,2L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,3L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A143258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143258Inst : IEnumerable<long>
{
public static readonly long[] Value=A143258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143258.Bytes);
public long this[int i]=>Value[i];

public static A143258Inst Instance=new A143258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143257
{
public static readonly long[] Value={ 1L,1L,3L,3L,15L,45L,441L,441L,3213L,16059L,172569L,517671L,6695325L,43746885L,903732249L,903732249L,14611840389L,110769926061L,1248788195355L,12439562858721L,154437141889677L,1902100636851663L,51339101124195573L };
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
public class A143257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143257Inst : IEnumerable<long>
{
public static readonly long[] Value=A143257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143257.Bytes);
public long this[int i]=>Value[i];

public static A143257Inst Instance=new A143257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143256
{
public static readonly long[] Value={ 1L,1L,-2L,1L,0L,-3L,1L,-2L,0L,0L,1L,0L,0L,0L,-5L,1L,-2L,-3L,0L,0L,6L,1L,0L,0L,0L,0L,0L,-7L,1L,-2L,0L,0L,0L,0L,0L,0L,1L,0L,-3L,0L,0L,0L,0L,0L,0L,1L,-2L,0L,0L,-5L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-11L,1L,-2L,-3L,0L,0L,6L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-13L,1L,-2L,0L,0L,0L,0L,-7L,0L,0L,0L,0L,0L,0L,14L };
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
public class A143256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143256Inst : IEnumerable<long>
{
public static readonly long[] Value=A143256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143256.Bytes);
public long this[int i]=>Value[i];

public static A143256Inst Instance=new A143256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143207
{
public static readonly long[] Value={ 30L,60L,90L,120L,150L,180L,240L,270L,300L,360L,450L,480L,540L,600L,720L,750L,810L,900L,960L,1080L,1200L,1350L,1440L,1500L,1620L,1800L,1920L,2160L,2250L,2400L,2430L,2700L,2880L,3000L,3240L,3600L,3750L,3840L,4050L,4320L,4500L,4800L,4860L };
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
public class A143207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143207Inst : IEnumerable<long>
{
public static readonly long[] Value=A143207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143207.Bytes);
public long this[int i]=>Value[i];

public static A143207Inst Instance=new A143207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143206
{
public static readonly long[] Value={ 21L,77L,221L,437L,1517L,2021L,4757L,6557L,9797L,11021L,12317L,16637L,27221L,38021L,50621L,53357L,77837L,95477L,99221L,123197L,145157L,159197L,194477L,210677L,216221L,239117L,250997L,378221L,416021L,455621L,549077L,576077L,594437L,680621L };
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
public class A143206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143206Inst : IEnumerable<long>
{
public static readonly long[] Value=A143206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143206.Bytes);
public long this[int i]=>Value[i];

public static A143206Inst Instance=new A143206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143205
{
public static readonly long[] Value={ 55L,91L,187L,247L,275L,391L,605L,637L,667L,1147L,1183L,1375L,1591L,1927L,2057L,2491L,3025L,3127L,3179L,3211L,4087L,4459L,4693L,4891L,5767L,6647L,6655L,6875L,7387L,8281L,8993L,9991L,10807L,11227L,12091L,15125L,15341L,15379L,17947L,19343L,22627L,23707L };
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
public class A143205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143205Inst : IEnumerable<long>
{
public static readonly long[] Value=A143205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143205.Bytes);
public long this[int i]=>Value[i];

public static A143205Inst Instance=new A143205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143204
{
public static readonly long[] Value={ 14L,28L,30L,56L,60L,90L,98L,112L,120L,150L,180L,196L,224L,240L,270L,300L,360L,392L,448L,450L,480L,540L,600L,686L,720L,750L,784L,810L,896L,900L,960L,1080L,1200L,1350L,1372L,1440L,1500L,1568L,1620L,1792L,1800L,1920L,2160L,2250L,2400L,2430L,2700L,2744L,2880L };
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
public class A143204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143204Inst : IEnumerable<long>
{
public static readonly long[] Value=A143204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143204.Bytes);
public long this[int i]=>Value[i];

public static A143204Inst Instance=new A143204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143203
{
public static readonly long[] Value={ 21L,63L,77L,147L,189L,221L,437L,441L,539L,567L,847L,1029L,1323L,1517L,1701L,2021L,2873L,3087L,3757L,3773L,3969L,4757L,5103L,5929L,6557L,7203L,8303L,9261L,9317L,9797L,10051L,11021L,11907L,12317L,15309L,16637L,21609L };
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
public class A143203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143203Inst : IEnumerable<long>
{
public static readonly long[] Value=A143203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143203.Bytes);
public long this[int i]=>Value[i];

public static A143203Inst Instance=new A143203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143202
{
public static readonly long[] Value={ 15L,35L,45L,75L,135L,143L,175L,225L,245L,323L,375L,405L,675L,875L,899L,1125L,1215L,1225L,1573L,1715L,1763L,1859L,1875L,2025L,3375L,3599L,3645L,4375L,5183L,5491L,5625L,6075L,6125L,6137L,8575L,9375L,10125L,10403L,10935L,11663L,12005L,16875L,17303L,18225L };
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
public class A143202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143202Inst : IEnumerable<long>
{
public static readonly long[] Value=A143202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143202.Bytes);
public long this[int i]=>Value[i];

public static A143202Inst Instance=new A143202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143201
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,6L,3L,1L,1L,2L,1L,4L,5L,10L,1L,2L,1L,12L,1L,6L,1L,6L,1L,1L,9L,16L,3L,2L,1L,18L,11L,4L,1L,10L,1L,10L,3L,22L,1L,2L,1L,4L,15L,12L,1L,2L,7L,6L,17L,28L,1L,6L,1L,30L,5L,1L,9L,18L,1L,16L,21L,12L,1L,2L,1L,36L,3L,18L,5L,22L,1L,4L,1L,40L,1L,10L,13L,42L,27L,10L,1L,6L,7L,22L };
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
public class A143201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143201Inst : IEnumerable<long>
{
public static readonly long[] Value=A143201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143201.Bytes);
public long this[int i]=>Value[i];

public static A143201Inst Instance=new A143201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143200
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-1L,-1L,1L,1L,0L,0L,0L,1L,1L,-1L,0L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,1L };
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
public class A143200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143200Inst : IEnumerable<long>
{
public static readonly long[] Value=A143200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143200.Bytes);
public long this[int i]=>Value[i];

public static A143200Inst Instance=new A143200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143199
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,2L,-1L,-1L,3L,3L,-1L,-1L,4L,14L,4L,-1L,-1L,5L,17L,17L,5L,-1L,-1L,6L,20L,41L,20L,6L,-1L,-1L,7L,23L,47L,47L,23L,7L,-1L,-1L,8L,26L,53L,89L,53L,26L,8L,-1L,-1L,9L,29L,59L,99L,99L,59L,29L,9L,-1L,-1L,10L,32L,65L,109L,164L,109L,65L,32L,10L,-1L };
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
public class A143199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143199Inst : IEnumerable<long>
{
public static readonly long[] Value=A143199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143199.Bytes);
public long this[int i]=>Value[i];

public static A143199Inst Instance=new A143199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143198
{
public static readonly long[] Value={ -1L,-1L,1L,-1L,2L,8L,-1L,3L,11L,23L,-1L,4L,14L,29L,49L,-1L,5L,17L,35L,59L,89L,-1L,6L,20L,41L,69L,104L,146L,-1L,7L,23L,47L,79L,119L,167L,223L,-1L,8L,26L,53L,89L,134L,188L,251L,323L,-1L,9L,29L,59L,99L,149L,209L,279L,359L,449L,-1L,10L,32L,65L,109L,164L,230L,307L,395L,494L,604L };
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
public class A143198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143198Inst : IEnumerable<long>
{
public static readonly long[] Value=A143198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143198.Bytes);
public long this[int i]=>Value[i];

public static A143198Inst Instance=new A143198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143197
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,1L,0L,-23L,0L,1L,0L,-230L,0L,1L,1L,0L,-1682L,0L,237L,0L,1L,0L,-10543L,0L,10543L,0L,-1L,1L,0L,-60657L,0L,259723L,0L,-2179L,0L,1L,0L,-331612L,0L,4675014L,0L,-331612L,0L,1L,1L,0L,-1756340L,0L,69413294L,0L,-21707972L,0L,19673L,0L,1L,0L,-9116141L,0L,906923282L,0L,-906923282L,0L,9116141L,0L,-1L };
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
public class A143197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143197Inst : IEnumerable<long>
{
public static readonly long[] Value=A143197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143197.Bytes);
public long this[int i]=>Value[i];

public static A143197Inst Instance=new A143197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143196
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,1L,0L,-23L,0L,1L,0L,-230L,0L,1L,1L,0L,-1682L,0L,237L,0L,1L,0L,-10543L,0L,10543L,0L,-1L,1L,0L,-60657L,0L,259723L,0L,-2179L,0L,1L,0L,-331612L,0L,4675014L,0L,-331612L,0L,1L,1L,0L,-1756340L,0L,69413294L,0L,-21707972L,0L,19673L,0L,1L,0L,-9116141L,0L,906923282L,0L,-906923282L,0L,9116141L,0L,-1L };
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
public class A143196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143196Inst : IEnumerable<long>
{
public static readonly long[] Value=A143196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143196.Bytes);
public long this[int i]=>Value[i];

public static A143196Inst Instance=new A143196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143195
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,12L,12L,5L,14L,56L,110L,136L,110L,56L,14L,42L,240L,702L,1382L,2020L,2284L,2020L,1382L,702L,240L,42L,132L,990L,3850L,10274L,20986L,34690L,47846L,55984L,55984L,47846L,34690L,20986L,10274L,3850L,990L,132L,429L,4004L,19448L,65221L,169052L,359517L,650225L,1023273L,1422297L };
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
public class A143195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143195Inst : IEnumerable<long>
{
public static readonly long[] Value=A143195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143195.Bytes);
public long this[int i]=>Value[i];

public static A143195Inst Instance=new A143195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143194
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,4L,4L,2L,5L,17L,29L,39L,46L,46L,39L,29L,17L,5L,14L,70L,180L,330L,496L,662L,812L,922L,964L,922L,812L,662L,496L,330L,180L,70L,14L,42L,282L,984L,2408L,4668L,7696L,11338L,15442L,19810L,24090L,27798L,30478L,31860L,31860L,30478L,27798L,24090L,19810L,15442L,11338L,7696L,4668L,2408L };
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
public class A143194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143194Inst : IEnumerable<long>
{
public static readonly long[] Value=A143194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143194.Bytes);
public long this[int i]=>Value[i];

public static A143194Inst Instance=new A143194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143193
{
public static readonly long[] Value={ 7187L,38103L,54251L,114358L,168673L,264111L,319699L,456061L,588847L,812092L,1005321L,1222630L,445059L,499063L,600907L,706847L,820609L,929113L,1048137L,1269847L,1049291L,1113439L,1252843L,1411942L,1588841L,456206L,462382L,464357L,479894L };
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
public class A143193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143193Inst : IEnumerable<long>
{
public static readonly long[] Value=A143193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143193.Bytes);
public long this[int i]=>Value[i];

public static A143193Inst Instance=new A143193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143192
{
public static readonly long[] Value={ 1413L,7187L,12421L,22751L,28862L,48046L,36094L,46372L,54214L,72845L,88119L,107246L,125589L,104153L,43838L,45893L,55054L,62090L,66226L,70187L,69638L,74941L,85303L,81913L,68891L,77237L,37997L,48758L,42827L,45554L,22217L,26617L,29422L,29099L };
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
public class A143192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143192Inst : IEnumerable<long>
{
public static readonly long[] Value=A143192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143192.Bytes);
public long this[int i]=>Value[i];

public static A143192Inst Instance=new A143192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143143
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,1L,0L,1L,4L,0L,5L,2L,0L,0L,6L,1L,7L,0L,1L,3L,8L,1L,0L,4L,2L,1L,9L,0L,10L,2L,2L,5L,0L,0L,11L,6L,3L,1L,12L,0L,13L,2L,1L,7L,14L,1L,0L,1L,4L,3L,15L,1L,1L,0L,5L,8L,16L,1L,17L,9L,0L,0L,2L,1L,18L,4L,6L,0L,19L,0L,20L,10L,3L,5L,0L,2L,21L,0L,0L,11L,22L,1L,3L,12L,7L,0L,23L,0L,1L,6L,8L,13L,4L };
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
public class A143143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143143Inst : IEnumerable<long>
{
public static readonly long[] Value=A143143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143143.Bytes);
public long this[int i]=>Value[i];

public static A143143Inst Instance=new A143143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143142
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,1L,0L,0L,0L,1L,-1L,-1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,-1L,-1L,0L,1L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
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
public class A143142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143142Inst : IEnumerable<long>
{
public static readonly long[] Value=A143142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143142.Bytes);
public long this[int i]=>Value[i];

public static A143142Inst Instance=new A143142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143141
{
public static readonly long[] Value={ 1L,2L,5L,14L,37L,101L,271L,733L,1976L,5334L,14390L,38833L,104779L,282734L,762903L,2058571L,5554692L,14988400L,40443620L,109130216L,294469216L,794574883L,2144024501L,5785283758L,15610599502L,42122535067L,113660462337L,306693333868L,827559549428L,2233028019698L };
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
public class A143141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143141Inst : IEnumerable<long>
{
public static readonly long[] Value=A143141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143141.Bytes);
public long this[int i]=>Value[i];

public static A143141Inst Instance=new A143141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143140
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,83L,787L,8965L,119170L,1810450L,30942699L,587606593L,12274606775L,279715819531L,6905395692990L,183588212652382L,5229549060414223L,158895798308201987L,5129671140284343035L,BigInteger.Parse("175343720698891809337"),BigInteger.Parse("6326623756471457351814"),BigInteger.Parse("240286954202031694593966") };
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
public class A143140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143140Inst Instance=new A143140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143139
{
public static readonly BigInteger[] Value={ 1L,3L,25L,351L,6901L,174483L,5392465L,196967991L,8301682141L,396555037803L,21171512707225L,1249311005445231L,80742309245690821L,5672134436846492163L,BigInteger.Parse("430345858647623635105"),BigInteger.Parse("35069095795843414698471"),BigInteger.Parse("3054896437732455928549741"),BigInteger.Parse("283283784773408059496473563") };
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
public class A143139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143139Inst Instance=new A143139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143138
{
public static readonly BigInteger[] Value={ 1L,2L,18L,254L,5010L,126902L,3926538L,143539454L,6053432130L,289293272102L,15450565342938L,911991586990574L,58955877533817810L,4142488437549926102L,BigInteger.Parse("314346159031755778218"),BigInteger.Parse("25620077133245941688414") };
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
public class A143138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143138Inst Instance=new A143138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143137
{
public static readonly BigInteger[] Value={ 1L,2L,13L,140L,2101L,40502L,954073L,26557400L,852911401L,31042592042L,1262704455013L,56767589130980L,2795116027239901L,149590982933830622L,8646295934108179633L,BigInteger.Parse("536766403519254357680"),BigInteger.Parse("35620604244949591333201") };
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
public class A143137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143137Inst Instance=new A143137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143136
{
public static readonly BigInteger[] Value={ 1L,2L,12L,128L,1920L,36992L,870912L,24232448L,777999360L,28309164032L,1151292628992L,51750540443648L,2547747292446720L,136336755956252672L,7879446478581399552L,BigInteger.Parse("489119124160488931328"),BigInteger.Parse("32456290094449950720000") };
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
public class A143136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143136Inst Instance=new A143136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143135
{
public static readonly BigInteger[] Value={ 1L,2L,11L,100L,1261L,20342L,399671L,9256840L,246907321L,7452534122L,251099460611L,9341422237420L,380293239870181L,16815919738248542L,802553031266952431L,BigInteger.Parse("41117164304824602640"),BigInteger.Parse("2250747364089063475441") };
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
public class A143135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143135Inst Instance=new A143135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143134
{
public static readonly BigInteger[] Value={ 1L,2L,12L,112L,1440L,23552L,467712L,10926592L,293544960L,8914583552L,301957742592L,11285975498752L,461367611228160L,20477098870833152L,980591931131953152L,BigInteger.Parse("50393637174029320192"),BigInteger.Parse("2766350676943951626240") };
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
public class A143134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A143134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143134Inst Instance=new A143134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143133
{
public static readonly long[] Value={ 1025024L,101376L,2843456L,510528L,2874672L,704208L,1787376L,754144L,1118048L,353352L,375208L,42112L,308480L,15232L,87436L,8576L,57272L,11192L,2248L,0L,7828L,2472L,444L,356L,3680L,0L,0L,0L,76L,4L };
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
public class A143133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143133Inst : IEnumerable<long>
{
public static readonly long[] Value=A143133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143133.Bytes);
public long this[int i]=>Value[i];

public static A143133Inst Instance=new A143133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143132
{
public static readonly long[] Value={ 1L,6L,26L,96L,321L,876L,2006L,4026L,7321L,12346L,19626L,29756L,43401L,61296L,84246L,113126L,148881L,192526L,245146L,307896L,382001L,468756L,569526L,685746L,818921L,970626L,1142506L,1336276L,1553721L,1796696L,2067126L,2367006L,2698401L,3063446L };
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
public class A143132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143132Inst : IEnumerable<long>
{
public static readonly long[] Value=A143132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143132.Bytes);
public long this[int i]=>Value[i];

public static A143132Inst Instance=new A143132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143131
{
public static readonly long[] Value={ 1L,5L,19L,63L,157L,321L,575L,939L,1433L,2077L,2891L,3895L,5109L,6553L,8247L,10211L,12465L,15029L,17923L,21167L,24781L,28785L,33199L,38043L,43337L,49101L,55355L,62119L,69413L,77257L,85671L,94675L,104289L,114533L,125427L,136991L,149245L };
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
public class A143131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143131Inst : IEnumerable<long>
{
public static readonly long[] Value=A143131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143131.Bytes);
public long this[int i]=>Value[i];

public static A143131Inst Instance=new A143131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143130
{
public static readonly long[] Value={ 1L,6L,5L,21L,20L,15L,56L,55L,50L,35L,126L,125L,120L,105L,70L,252L,251L,246L,231L,196L,126L,462L,461L,456L,441L,406L,336L,210L,792L,791L,786L,771L,736L,666L,540L,330L,1287L,1286L,1281L,1266L,1231L,1161L,1035L,825L,495L,2002L,2001L,1996L,1981L,1946L,1876L,1750L };
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
public class A143130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143130Inst : IEnumerable<long>
{
public static readonly long[] Value=A143130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143130.Bytes);
public long this[int i]=>Value[i];

public static A143130Inst Instance=new A143130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143129
{
public static readonly long[] Value={ 1L,5L,4L,15L,14L,10L,35L,34L,30L,20L,70L,69L,65L,55L,35L,126L,125L,121L,111L,91L,56L,210L,209L,205L,195L,175L,140L,84L,330L,329L,325L,315L,295L,260L,204L,120L,495L,494L,490L,480L,460L,425L,369L,285L,165L,715L,714L,710L,700L,680L,645L,589L,505L,385L,220L,1001L,1000L };
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
public class A143129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143129Inst : IEnumerable<long>
{
public static readonly long[] Value=A143129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143129.Bytes);
public long this[int i]=>Value[i];

public static A143129Inst Instance=new A143129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143128
{
public static readonly long[] Value={ 1L,7L,19L,47L,77L,149L,205L,325L,442L,622L,754L,1090L,1272L,1608L,1968L,2464L,2770L,3472L,3852L,4692L,5364L,6156L,6708L,8148L,8923L,10015L,11095L,12663L,13533L,15693L,16685L,18701L,20285L,22121L,23801L,27077L,28483L,30763L,32947L,36547L };
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
public class A143128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143128Inst : IEnumerable<long>
{
public static readonly long[] Value=A143128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143128.Bytes);
public long this[int i]=>Value[i];

public static A143128Inst Instance=new A143128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143095
{
public static readonly long[] Value={ 1L,4L,2L,8L,4L,16L,8L,32L,16L,64L,32L,128L,64L,256L,128L,512L,256L,1024L,512L,2048L,1024L,4096L,2048L,8192L,4096L,16384L,8192L,32768L,16384L,65536L,32768L,131072L,65536L,262144L,131072L,524288L,262144L,1048576L,524288L,2097152L,1048576L,4194304L };
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
public class A143095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143095Inst : IEnumerable<long>
{
public static readonly long[] Value=A143095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143095.Bytes);
public long this[int i]=>Value[i];

public static A143095Inst Instance=new A143095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143094
{
public static readonly long[] Value={ 1L,2L,5L,15L,47L,145L,470L };
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
public class A143094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143094Inst : IEnumerable<long>
{
public static readonly long[] Value=A143094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143094.Bytes);
public long this[int i]=>Value[i];

public static A143094Inst Instance=new A143094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143093
{
public static readonly long[] Value={ 1L,3L,6L,17L,51L,155L,492L };
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
public class A143093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143093Inst : IEnumerable<long>
{
public static readonly long[] Value=A143093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143093.Bytes);
public long this[int i]=>Value[i];

public static A143093Inst Instance=new A143093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143092
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,6L,7L,5L,8L,7L,11L,8L,9L,11L,12L,11L,13L,11L,12L,10L,16L,13L,18L,17L,12L,19L,13L,19L,18L,19L,16L,23L,19L,20L,25L,24L,20L,22L,24L,22L,20L,21L,24L,23L,26L,21L,31L,25L,30L,21L,30L,25L,36L,28L,31L,24L,31L,29L,37L,36L,28L,32L,28L,34L,34L,41L,32L,36L,31L,34L,39L,38L };
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
public class A143092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143092Inst : IEnumerable<long>
{
public static readonly long[] Value=A143092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143092.Bytes);
public long this[int i]=>Value[i];

public static A143092Inst Instance=new A143092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143091
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,5L,6L,8L,8L,8L,9L,9L,11L,12L,12L,12L,14L,14L,14L,16L,16L,17L,18L,18L,18L,22L,22L,22L,22L,22L,24L,24L,24L,25L,27L,27L,27L,27L,27L,31L,33L,33L,33L,34L,34L,34L,36L,36L,36L,36L,36L,37L,41L,41L,41L,41L,41L,41L,41L,41L,45L,49L,49L,49L,49L,49L,50L,51L,51L,51L,54L,54L };
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
public class A143091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143091Inst : IEnumerable<long>
{
public static readonly long[] Value=A143091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143091.Bytes);
public long this[int i]=>Value[i];

public static A143091Inst Instance=new A143091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143090
{
public static readonly long[] Value={ 12L,16L,15L,9L,4L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A143090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143090Inst : IEnumerable<long>
{
public static readonly long[] Value=A143090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143090.Bytes);
public long this[int i]=>Value[i];

public static A143090Inst Instance=new A143090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143089
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,6L,7L,6L,7L,9L,10L,10L,9L,11L,12L,14L,13L,14L,14L,15L,15L,18L,16L,18L,21L,17L,22L,20L,21L,21L,24L,21L,25L,25L,25L,26L,28L,30L,28L,27L,33L,29L,31L,30L,33L,30L,37L,34L,33L,38L,34L,39L,36L,39L,40L,42L,40L,44L,40L,43L,41L,48L,45L,43L,49L,44L,46L,51L,47L,46L,58L,48L };
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
public class A143089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143089Inst : IEnumerable<long>
{
public static readonly long[] Value=A143089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143089.Bytes);
public long this[int i]=>Value[i];

public static A143089Inst Instance=new A143089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143088
{
public static readonly long[] Value={ 1L,3L,3L,7L,9L,7L,15L,21L,21L,15L,31L,45L,49L,45L,31L,63L,93L,105L,105L,93L,63L,127L,189L,217L,225L,217L,189L,127L,255L,381L,441L,465L,465L,441L,381L,255L,511L,765L,889L,945L,961L,945L,889L,765L,511L,1023L,1533L,1785L,1905L,1953L,1953L,1905L,1785L,1533L,1023L,2047L };
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
public class A143088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143088Inst : IEnumerable<long>
{
public static readonly long[] Value=A143088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143088.Bytes);
public long this[int i]=>Value[i];

public static A143088Inst Instance=new A143088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143087
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,9L,9L,1L,1L,12L,42L,12L,1L,1L,15L,70L,70L,15L,1L,1L,18L,105L,300L,105L,18L,1L,1L,21L,147L,525L,525L,147L,21L,1L,1L,24L,196L,840L,2170L,840L,196L,24L,1L,1L,27L,252L,1260L,3906L,3906L,1260L,252L,27L,1L,1L,30L,315L,1800L,6510L,15876L,6510L,1800L,315L,30L,1L };
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
public class A143087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143087Inst : IEnumerable<long>
{
public static readonly long[] Value=A143087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143087.Bytes);
public long this[int i]=>Value[i];

public static A143087Inst Instance=new A143087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143086
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,3L,7L,3L,1L,1L,3L,7L,7L,3L,1L,1L,3L,7L,15L,7L,3L,1L,1L,3L,7L,15L,15L,7L,3L,1L,1L,3L,7L,15L,31L,15L,7L,3L,1L,1L,3L,7L,15L,31L,31L,15L,7L,3L,1L,1L,3L,7L,15L,31L,63L,31L,15L,7L,3L,1L };
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
public class A143086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143086Inst : IEnumerable<long>
{
public static readonly long[] Value=A143086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143086.Bytes);
public long this[int i]=>Value[i];

public static A143086Inst Instance=new A143086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143085
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L,72L,24L,96L,480L,2880L,120L,600L,3600L,25200L,201600L,720L,4320L,30240L,241920L,2177280L,21772800L,5040L,35280L,282240L,2540160L,25401600L,279417600L,3353011200L,40320L,322560L,2903040L,29030400L,319334400L,3832012800L };
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
public class A143085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143085Inst : IEnumerable<long>
{
public static readonly long[] Value=A143085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143085.Bytes);
public long this[int i]=>Value[i];

public static A143085Inst Instance=new A143085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143084
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,24L,6L,24L,120L,720L,24L,120L,720L,5040L,40320L,120L,720L,5040L,40320L,362880L,3628800L,720L,5040L,40320L,362880L,3628800L,39916800L,479001600L,5040L,40320L,362880L,3628800L,39916800L,479001600L,6227020800L,87178291200L,40320L };
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
public class A143084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143084Inst : IEnumerable<long>
{
public static readonly long[] Value=A143084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143084.Bytes);
public long this[int i]=>Value[i];

public static A143084Inst Instance=new A143084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143083
{
public static readonly long[] Value={ 3L,10L,70L,21L,252L,1386L,36L,660L,5148L,25740L,55L,1430L,15015L,97240L,461890L,78L,2730L,37128L,302328L,1763580L,8112468L,105L,4760L,81396L,813960L,5720330L,31201800L,140408100L,136L,7752L,162792L,1961256L,16343800L,104303160L,542911320L,2404321560L };
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
public class A143083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143083Inst : IEnumerable<long>
{
public static readonly long[] Value=A143083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143083.Bytes);
public long this[int i]=>Value[i];

public static A143083Inst Instance=new A143083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143082
{
public static readonly long[] Value={ 3L,5L,5L,6L,5L,6L,7L,7L,8L,7L,9L,8L,7L,9L,8L,10L,9L,9L,10L,10L,9L,11L,11L,10L,9L,11L,11L,10L,12L,12L,11L,11L,13L,12L,12L,11L,13L,13L,13L,12L,11L,14L,13L,13L,12L,15L,14L,14L,13L,13L,15L,15L,17L,14L,13L,16L,15L,15L,15L,14L,13L,16L,16L,15L,15L,14L,17L,17L,16L,16L,15L,15L,17L,17L,17L,16L };
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
public class A143082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143082Inst : IEnumerable<long>
{
public static readonly long[] Value=A143082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143082.Bytes);
public long this[int i]=>Value[i];

public static A143082Inst Instance=new A143082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143081
{
public static readonly long[] Value={ -1L,1L,1L,1L,3L,1L,3L,15L,15L,3L,15L,105L,175L,105L,15L,105L,945L,2205L,2205L,945L,105L,945L,10395L,31185L,43659L,31185L,10395L,945L,10395L,135135L,495495L,891891L,891891L,495495L,135135L,10395L,135135L,2027025L,8783775L,19324305L,24845535L,19324305L,8783775L,2027025L,135135L,2027025L,34459425L };
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
public class A143081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143081Inst : IEnumerable<long>
{
public static readonly long[] Value=A143081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143081.Bytes);
public long this[int i]=>Value[i];

public static A143081Inst Instance=new A143081Inst();

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