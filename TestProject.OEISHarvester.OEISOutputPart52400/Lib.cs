using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A059945
{
public static readonly long[] Value={ 0L,0L,4L,39L,280L,1815L,11284L,68859L,416560L,2509455L,15086764L,90610179L,543928840L,3264374295L,19588645444L,117539063499L,705255937120L,4231600258335L,25389795391324L,152339353740819L,914037866361400L,5484232429393575L,32905410268988404L,197432508689714139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059945Inst : IEnumerable<long>
{
public static readonly long[] Value=A059945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059945.Bytes);
public long this[int i]=>Value[i];

public static A059945Inst Instance=new A059945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059946
{
public static readonly BigInteger[] Value={ 0L,0L,0L,25L,472L,6185L,70700L,759045L,7894992L,80736625L,817897300L,8241325565L,82783813112L,830046591465L,8313655213500L,83215436364085L,832626645756832L,8329096006484705L,83307920631515300L,833180902353754605L,8332418928963358152L,BigInteger.Parse("83327847634888960345") };
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
public class A059946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059946Inst Instance=new A059946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059947
{
public static readonly BigInteger[] Value={ 0L,0L,0L,3L,256L,7255L,149660L,2681063L,44659776L,714287535L,11154475420L,171673613023L,2618246526896L,39701554817015L,599773397512380L,9038881598035383L,136004367641775616L,2044264589908169695L,BigInteger.Parse("30705868769902628540"),BigInteger.Parse("461006369270166660143"),BigInteger.Parse("6919274132365824549936") };
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
public class A059947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059947Inst Instance=new A059947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059948
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,40L,3306L,131876L,3961356L,103290096L,2488179582L,57162274972L,1274774473632L,27887396866472L,602352276704178L,12899161619186388L,274612697648135028L,5822592730060070368L,BigInteger.Parse("123107330974129584294") };
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
public class A059948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059948Inst Instance=new A059948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059949
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,535L,51640L,2771685L,114713760L,4127125695L,136631722920L,4292250804985L,130278290187760L,3863262740532195L,112733098867629240L,3252644718804860925L,BigInteger.Parse("93093809127731630400"),BigInteger.Parse("2649006256251644780935") };
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
public class A059949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059949Inst Instance=new A059949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059950
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,15L,8456L,954213L,66253552L,3622342095L,172672602432L,7557346901841L,312733696544984L,12456923582109435L,483124650731622328L,18383758048494864909UL,BigInteger.Parse("689931203330381971296"),BigInteger.Parse("25630900118611348761735"),BigInteger.Parse("945025181750878420241744"),BigInteger.Parse("34647077709586498046291817") };
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
public class A059950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059950Inst Instance=new A059950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059951
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,420L,154637L,20368816L,1775801814L,124151410020L,7596257673279L,426319554841752L,22564352299016528L,1146221298547133380L,BigInteger.Parse("56531610963314602401"),BigInteger.Parse("2728475248127447671008"),BigInteger.Parse("129586638359127411410442"),BigInteger.Parse("6080467290450346517206500"),BigInteger.Parse("282689089820505452872162403") };
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
public class A059951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059951Inst Instance=new A059951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059952
{
public static readonly long[] Value={ 27L,1L,28L,2L,29L,3L,30L,4L,31L,5L,32L,6L,33L,7L,34L,8L,35L,9L,36L,10L,37L,11L,38L,12L,39L,13L,40L,14L,41L,15L,42L,16L,43L,17L,44L,18L,45L,19L,46L,20L,47L,21L,48L,22L,49L,23L,50L,24L,51L,25L,52L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059952Inst : IEnumerable<long>
{
public static readonly long[] Value=A059952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059952.Bytes);
public long this[int i]=>Value[i];

public static A059952Inst Instance=new A059952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059953
{
public static readonly long[] Value={ 1L,27L,2L,28L,3L,29L,4L,30L,5L,31L,6L,32L,7L,33L,8L,34L,9L,35L,10L,36L,11L,37L,12L,38L,13L,39L,14L,40L,15L,41L,16L,42L,17L,43L,18L,44L,19L,45L,20L,46L,21L,47L,22L,48L,23L,49L,24L,50L,25L,51L,26L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059953Inst : IEnumerable<long>
{
public static readonly long[] Value=A059953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059953.Bytes);
public long this[int i]=>Value[i];

public static A059953Inst Instance=new A059953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059954
{
public static readonly long[] Value={ 6L,14L,60L,72L,106L,150L,240L,360L,598L,902L,1308L,1812L,2378L,3146L,4080L,4140L,4270L,4346L,4500L,4592L,4754L,4910L,5144L,5308L,5558L,5802L,6140L,6440L,6826L,7206L,7680L,8168L,8702L,9322L,9996L,10676L,11418L,12278L,13208L,14152L,15158L,16306L,17540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059954Inst : IEnumerable<long>
{
public static readonly long[] Value=A059954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059954.Bytes);
public long this[int i]=>Value[i];

public static A059954Inst Instance=new A059954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059955
{
public static readonly long[] Value={ 1L,2L,5L,10L,3L,10L,4L,3L,28L,17L,18L,30L,20L,41L,42L,14L,19L,30L,37L,63L,50L,7L,12L,83L,30L,91L,19L,69L,91L,97L,56L,22L,80L,39L,137L,44L,9L,154L,19L,37L,141L,141L,168L,126L,183L,200L,205L,136L,55L,95L,204L,126L,213L,230L,68L,63L,158L,202L,162L,102L,182L,104L,38L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059955Inst : IEnumerable<long>
{
public static readonly long[] Value=A059955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059955.Bytes);
public long this[int i]=>Value[i];

public static A059955Inst Instance=new A059955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059956
{
public static readonly long[] Value={ 6L,0L,7L,9L,2L,7L,1L,0L,1L,8L,5L,4L,0L,2L,6L,6L,2L,8L,6L,6L,3L,2L,7L,6L,7L,7L,9L,2L,5L,8L,3L,6L,5L,8L,3L,3L,4L,2L,6L,1L,5L,2L,6L,4L,8L,0L,3L,3L,4L,7L,9L,2L,9L,3L,0L,7L,3L,6L,5L,4L,1L,9L,1L,3L,6L,5L,0L,3L,8L,7L,2L,5L,7L,7L,3L,4L,1L,2L,6L,4L,7L,1L,4L,7L,2L,5L,5L,6L,4L,3L,5L,5L,3L,7L,3L,1L,0L,2L,5L,6L,8L,1L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059956Inst : IEnumerable<long>
{
public static readonly long[] Value=A059956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059956.Bytes);
public long this[int i]=>Value[i];

public static A059956Inst Instance=new A059956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059957
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,2L,2L,3L,3L,3L,3L,3L,4L,3L,2L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,3L,3L,4L,4L,2L,3L,4L,4L,4L,3L,3L,4L,4L,3L,4L,4L,3L,4L,4L,3L,3L,3L,3L,4L,4L,3L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,3L,3L,5L,4L,3L,4L,5L,4L,3L,3L,3L,4L,4L,4L,5L,4L,3L,3L,3L,3L,4L,5L,4L,4L,4L,3L,4L,5L,4L,4L,4L,4L,4L,3L,3L,4L,4L,3L,4L,4L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059957Inst : IEnumerable<long>
{
public static readonly long[] Value=A059957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059957.Bytes);
public long this[int i]=>Value[i];

public static A059957Inst Instance=new A059957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059958
{
public static readonly long[] Value={ 1L,2L,5L,14L,65L,209L,714L,7314L,38570L,254540L,728364L,11243154L,58524465L,812646120L,5163068910L,58720148850L,555409903685L,4339149420605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059958Inst : IEnumerable<long>
{
public static readonly long[] Value=A059958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059958.Bytes);
public long this[int i]=>Value[i];

public static A059958Inst Instance=new A059958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059959
{
public static readonly long[] Value={ -1L,0L,1L,1L,-1L,1L,3L,1L,-1L,3L,3L,-5L,3L,1L,3L,-3L,-1L,1L,-3L,1L,3L,9L,3L,-9L,3L,-35L,5L,-29L,-3L,3L,-3L,1L,5L,9L,-25L,31L,5L,-9L,-7L,7L,-15L,21L,11L,-29L,-7L,55L,-15L,-5L,-21L,-69L,27L,-21L,-21L,-5L,33L,-3L,5L,-9L,27L,55L,-33L,1L,57L,25L,-13L,49L,5L,-3L,23L,19L,-25L,-11L,-15L,-29L,35L,-33L,15L,-11L,-7L,-23L,-13L,-17L,-9L,55L,-3L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059959Inst : IEnumerable<long>
{
public static readonly long[] Value=A059959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059959.Bytes);
public long this[int i]=>Value[i];

public static A059959Inst Instance=new A059959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059960
{
public static readonly long[] Value={ 5L,11L,17L,71L,107L,191L,431L,1151L,2591L,139967L,472391L,786431L,995327L,57395627L,63700991L,169869311L,4076863487L,10871635967L,2348273369087L,56358560858111L,79164837199871L,84537841287167L,150289495621631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059960Inst : IEnumerable<long>
{
public static readonly long[] Value=A059960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059960.Bytes);
public long this[int i]=>Value[i];

public static A059960Inst Instance=new A059960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059961
{
public static readonly long[] Value={ 4L,6L,12L,18L,72L,108L,192L,432L,1152L,2592L,139968L,472392L,786432L,995328L,57395628L,63700992L,169869312L,4076863488L,10871635968L,2348273369088L,56358560858112L,79164837199872L,84537841287168L,150289495621632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059961Inst : IEnumerable<long>
{
public static readonly long[] Value=A059961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059961.Bytes);
public long this[int i]=>Value[i];

public static A059961Inst Instance=new A059961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059962
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,24L,25L,27L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059962Inst : IEnumerable<long>
{
public static readonly long[] Value=A059962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059962.Bytes);
public long this[int i]=>Value[i];

public static A059962Inst Instance=new A059962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059963
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,2L,2L,2L,2L,0L,1L,1L,1L,1L,0L,4L,7L,6L,6L,6L,7L,4L,4L,8L,16L,18L,18L,16L,8L,4L,28L,30L,47L,44L,54L,44L,47L,30L,28L,64L,48L,65L,93L,92L,92L,93L,65L,48L,64L,96L,219L,209L,295L,346L,350L,346L,295L,209L,219L,96L,500L,806L,1165L,1359L,1631L,1639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059963Inst : IEnumerable<long>
{
public static readonly long[] Value=A059963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059963.Bytes);
public long this[int i]=>Value[i];

public static A059963Inst Instance=new A059963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059964
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,3L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,2L,3L,4L,5L,5L,5L,2L,3L,2L,3L,4L,5L,5L,5L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,2L,3L,4L,5L,5L,5L,2L,3L,4L,5L,5L,5L,2L,3L,2L,3L,4L,5L,5L,5L,2L,3L,4L,5L,2L,3L,2L,3L,4L,5L,5L,5L,2L,3L,4L,5L,2L,3L,4L,5L,5L,5L,2L,3L,4L,5L,5L,5L,5L,5L,2L,3L,4L,5L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059964Inst : IEnumerable<long>
{
public static readonly long[] Value=A059964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059964.Bytes);
public long this[int i]=>Value[i];

public static A059964Inst Instance=new A059964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059965
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,7L,7L,6L,7L,6L,7L,6L,5L,5L,7L,6L,7L,6L,5L,5L,7L,6L,7L,6L,5L,4L,7L,6L,5L,4L,5L,5L,7L,6L,7L,6L,5L,4L,3L,3L,7L,6L,5L,5L,7L,6L,7L,6L,5L,4L,7L,6L,5L,4L,5L,4L,7L,6L,5L,4L,5L,5L,7L,6L,7L,6L,5L,4L,3L,3L,7L,6L,5L,5L,7L,6L,7L,6L,5L,4L,3L,3L,7L,6L,5L,4L,7L,6L,5L,4L,5L,4L,7L,6L,5L,4L,5L,4L,3L,3L,7L,6L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059965Inst : IEnumerable<long>
{
public static readonly long[] Value=A059965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059965.Bytes);
public long this[int i]=>Value[i];

public static A059965Inst Instance=new A059965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059966
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,18L,30L,56L,99L,186L,335L,630L,1161L,2182L,4080L,7710L,14532L,27594L,52377L,99858L,190557L,364722L,698870L,1342176L,2580795L,4971008L,9586395L,18512790L,35790267L,69273666L,134215680L,260300986L,505286415L,981706806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059966Inst : IEnumerable<long>
{
public static readonly long[] Value=A059966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059966.Bytes);
public long this[int i]=>Value[i];

public static A059966Inst Instance=new A059966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059967
{
public static readonly BigInteger[] Value={ 1L,9L,117L,1785L,29799L,527085L,9706503L,184138713L,3573805950L,70625252863L,1416298046436L,28748759731965L,589546754316126L,12195537924351375L,254184908607118800L,5332692942907262361L,BigInteger.Parse("112524941404978156215") };
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
public class A059967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059967Inst Instance=new A059967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059968
{
public static readonly BigInteger[] Value={ 1L,10L,145L,2470L,46060L,910252L,18730855L,397089550L,8612835715L,190223180840L,4263421511271L,96723482198980L,2216905597676000L,51256802757808320L,1194060413809070710L,BigInteger.Parse("27999654303202465310"),BigInteger.Parse("660370070571422998410") };
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
public class A059968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059968Inst Instance=new A059968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059969
{
public static readonly long[] Value={ 0L,3L,6L,15L,16L,20L,18L,35L,40L,36L,30L,66L,72L,104L,112L,105L,112L,153L,144L,152L,120L,189L,198L,253L,240L,250L,234L,297L,308L,290L,180L,279L,288L,363L,340L,350L,324L,407L,418L,390L,200L,328L,336L,430L,396L,405L,368L,470L,480L,441L,250L,408L,416L,530L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059969Inst : IEnumerable<long>
{
public static readonly long[] Value=A059969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059969.Bytes);
public long this[int i]=>Value[i];

public static A059969Inst Instance=new A059969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059970
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,11L,1L,8L,5L,9L,2L,4L,9L,4L,1L,16L,8L,140L,5L,82L,9L,145L,2L,44L,6L,108L,9L,154L,13L,209L,1L,32L,20L,132L,10L,243L,172L,123L,4L,139L,68L,62L,11L,222L,182L,92L,2L,16L,36L,224L,5L,242L,91L,24L,11L,105L,178L,56L,5L,241L,92L,205L,1L,64L,39L,20L,23L,161L,225L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059970Inst : IEnumerable<long>
{
public static readonly long[] Value=A059970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059970.Bytes);
public long this[int i]=>Value[i];

public static A059970Inst Instance=new A059970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059971
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,13L,12L,14L,13L,1L,6L,13L,8L,13L,1L,17L,8L,158L,155L,72L,170L,198L,48L,145L,208L,165L,25L,55L,205L,171L,206L,55L,158L,6L,140L,151L,53L,113L,252L,191L,254L,228L,26L,116L,130L,146L,243L,145L,118L,72L,14L,75L,115L,20L,69L,60L,177L,121L,99L,171L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059971Inst : IEnumerable<long>
{
public static readonly long[] Value=A059971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059971.Bytes);
public long this[int i]=>Value[i];

public static A059971Inst Instance=new A059971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059972
{
public static readonly long[] Value={ 2L,3L,4L,9L,30L,81L,4096L,531441L,16777216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059972Inst : IEnumerable<long>
{
public static readonly long[] Value=A059972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059972.Bytes);
public long this[int i]=>Value[i];

public static A059972Inst Instance=new A059972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059973
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,9L,17L,38L,72L,161L,305L,682L,1292L,2889L,5473L,12238L,23184L,51841L,98209L,219602L,416020L,930249L,1762289L,3940598L,7465176L,16692641L,31622993L,70711162L,133957148L,299537289L,567451585L,1268860318L,2403763488L,5374978561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059973Inst : IEnumerable<long>
{
public static readonly long[] Value=A059973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059973.Bytes);
public long this[int i]=>Value[i];

public static A059973Inst Instance=new A059973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059974
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,5L,5L,5L,5L,8L,8L,13L,13L,13L,13L,21L,21L,34L,34L,34L,34L,55L,55L,55L,55L,55L,55L,89L,89L,144L,144L,144L,144L,144L,144L,233L,233L,233L,233L,377L,377L,610L,610L,610L,610L,987L,987L,987L,987L,987L,987L,1597L,1597L,1597L,1597L,1597L,1597L,2584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059974Inst : IEnumerable<long>
{
public static readonly long[] Value=A059974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059974.Bytes);
public long this[int i]=>Value[i];

public static A059974Inst Instance=new A059974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059975
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,3L,4L,5L,10L,4L,12L,7L,6L,4L,16L,5L,18L,6L,8L,11L,22L,5L,8L,13L,6L,8L,28L,7L,30L,5L,12L,17L,10L,6L,36L,19L,14L,7L,40L,9L,42L,12L,8L,23L,46L,6L,12L,9L,18L,14L,52L,7L,14L,9L,20L,29L,58L,8L,60L,31L,10L,6L,16L,13L,66L,18L,24L,11L,70L,7L,72L,37L,10L,20L,16L,15L,78L,8L,8L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059975Inst : IEnumerable<long>
{
public static readonly long[] Value=A059975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059975.Bytes);
public long this[int i]=>Value[i];

public static A059975Inst Instance=new A059975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059976
{
public static readonly long[] Value={ 1L,338L,6891L,49246L,228737L,716214L,2110081L,4663844L,10289331L,19945864L,37518971L,61582884L,109478509L,165518210L,259500567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059976Inst : IEnumerable<long>
{
public static readonly long[] Value=A059976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059976.Bytes);
public long this[int i]=>Value[i];

public static A059976Inst Instance=new A059976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059977
{
public static readonly long[] Value={ 1L,81L,1296L,10000L,50625L,194481L,614656L,1679616L,4100625L,9150625L,18974736L,37015056L,68574961L,121550625L,207360000L,342102016L,547981281L,855036081L,1303210000L,1944810000L,2847396321L,4097152081L,5802782976L,8100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059977Inst : IEnumerable<long>
{
public static readonly long[] Value=A059977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059977.Bytes);
public long this[int i]=>Value[i];

public static A059977Inst Instance=new A059977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059978
{
public static readonly long[] Value={ 1L,729L,46656L,1000000L,11390625L,85766121L,481890304L,2176782336L,8303765625L,27680640625L,82653950016L,225199600704L,567869252041L,1340095640625L,2985984000000L,6327518887936L,12827693806929L,25002110044521L,47045881000000L,85766121000000L,151939915084881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059978Inst : IEnumerable<long>
{
public static readonly long[] Value=A059978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059978.Bytes);
public long this[int i]=>Value[i];

public static A059978Inst Instance=new A059978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059979
{
public static readonly long[] Value={ 1L,2187L,279936L,10000000L,170859375L,1801088541L,13492928512L,78364164096L,373669453125L,1522435234375L,5455160701056L,17565568854912L,51676101935731L,140710042265625L,358318080000000L,860542568759296L,1962637152460137L,4275360817613091L,8938717390000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059979Inst : IEnumerable<long>
{
public static readonly long[] Value=A059979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059979.Bytes);
public long this[int i]=>Value[i];

public static A059979Inst Instance=new A059979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059980
{
public static readonly long[] Value={ 1L,6561L,1679616L,100000000L,2562890625L,37822859361L,377801998336L,2821109907456L,16815125390625L,83733937890625L,360040606269696L,1370114370683136L,4702525276151521L,14774554437890625L,42998169600000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059980Inst : IEnumerable<long>
{
public static readonly long[] Value=A059980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059980.Bytes);
public long this[int i]=>Value[i];

public static A059980Inst Instance=new A059980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059981
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,3L,1L,2L,3L,4L,1L,3L,1L,2L,4L,2L,1L,3L,4L,5L,2L,4L,1L,2L,1L,3L,5L,3L,2L,4L,1L,5L,6L,3L,1L,5L,1L,2L,3L,2L,1L,4L,6L,4L,3L,5L,1L,2L,6L,7L,4L,2L,1L,6L,1L,2L,3L,4L,3L,2L,1L,5L,7L,5L,1L,4L,1L,6L,2L,3L,7L,8L,1L,5L,3L,2L,1L,7L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059981Inst : IEnumerable<long>
{
public static readonly long[] Value=A059981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059981.Bytes);
public long this[int i]=>Value[i];

public static A059981Inst Instance=new A059981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059982
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,3L,2L,1L,3L,5L,3L,1L,1L,5L,7L,5L,1L,2L,7L,11L,7L,2L,3L,11L,15L,11L,3L,5L,15L,22L,15L,5L,1L,7L,22L,30L,22L,7L,1L,1L,11L,30L,42L,30L,11L,1L,2L,15L,42L,56L,42L,15L,2L,3L,22L,56L,77L,56L,22L,3L,5L,30L,77L,101L,77L,30L,5L,7L,42L,101L,135L,101L,42L,7L,11L,56L,135L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059982Inst : IEnumerable<long>
{
public static readonly long[] Value=A059982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059982.Bytes);
public long this[int i]=>Value[i];

public static A059982Inst Instance=new A059982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059983
{
public static readonly long[] Value={ 1L,0L,6L,7L,8L,9L,12L,13L,14L,15L,18L,19L,22L,23L,24L,25L,28L,29L,32L,33L,36L,37L,40L,41L,42L,43L,46L,47L,50L,51L,54L,55L,58L,59L,62L,63L,66L,67L,70L,71L,74L,75L,76L,77L,80L,81L,84L,85L,88L,89L,92L,93L,96L,97L,100L,101L,104L,105L,108L,109L,112L,113L,116L,117L,120L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059983Inst : IEnumerable<long>
{
public static readonly long[] Value=A059983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059983.Bytes);
public long this[int i]=>Value[i];

public static A059983Inst Instance=new A059983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059984
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,1L,0L,0L,2L,1L,0L,1L,0L,2L,0L,0L,1L,2L,0L,0L,0L,3L,0L,1L,1L,1L,1L,0L,0L,2L,1L,1L,0L,1L,0L,2L,1L,0L,0L,1L,2L,1L,0L,0L,0L,3L,1L,0L,1L,1L,0L,2L,0L,0L,2L,0L,2L,0L,1L,0L,1L,2L,0L,0L,1L,1L,2L,0L,0L,0L,2L,2L,0L,1L,0L,0L,3L,0L,0L,1L,0L,3L,0L,0L,0L,1L,3L,0L,0L,0L,0L,4L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059984Inst : IEnumerable<long>
{
public static readonly long[] Value=A059984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059984.Bytes);
public long this[int i]=>Value[i];

public static A059984Inst Instance=new A059984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059985
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,13L,14L,18L,33L,34L,37L,38L,42L,51L,52L,55L,56L,60L,73L,74L,78L,96L,153L,154L,157L,158L,162L,171L,172L,175L,176L,180L,193L,194L,198L,216L,249L,250L,253L,254L,258L,267L,268L,271L,272L,276L,289L,290L,294L,312L,363L,364L,367L,368L,372L,385L,386L,390L,408L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059985Inst : IEnumerable<long>
{
public static readonly long[] Value=A059985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059985.Bytes);
public long this[int i]=>Value[i];

public static A059985Inst Instance=new A059985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059986
{
public static readonly long[] Value={ 0L,12L,54L,144L,300L,540L,882L,1344L,1944L,2700L,3630L,4752L,6084L,7644L,9450L,11520L,13872L,16524L,19494L,22800L,26460L,30492L,34914L,39744L,45000L,50700L,56862L,63504L,70644L,78300L,86490L,95232L,104544L,114444L,124950L,136080L,147852L,160284L,173394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059986Inst : IEnumerable<long>
{
public static readonly long[] Value=A059986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059986.Bytes);
public long this[int i]=>Value[i];

public static A059986Inst Instance=new A059986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059987
{
public static readonly long[] Value={ 2L,5L,11L,17L,31L,41L,47L,59L,73L,83L,103L,127L,137L,149L,157L,179L,197L,211L,233L,257L,269L,283L,307L,313L,331L,353L,367L,379L,389L,431L,449L,487L,499L,509L,547L,563L,571L,607L,617L,631L,661L,677L,691L,709L,739L,751L,823L,829L,853L,877L,883L,907L,919L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059987Inst : IEnumerable<long>
{
public static readonly long[] Value=A059987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059987.Bytes);
public long this[int i]=>Value[i];

public static A059987Inst Instance=new A059987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059988
{
public static readonly BigInteger[] Value={ 0L,81L,9801L,998001L,99980001L,9999800001L,999998000001L,99999980000001L,9999999800000001L,999999998000000001L,BigInteger.Parse("99999999980000000001"),BigInteger.Parse("9999999999800000000001"),BigInteger.Parse("999999999998000000000001") };
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
public class A059988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059988Inst Instance=new A059988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059989
{
public static readonly BigInteger[] Value={ 0L,56L,10920L,2118480L,410974256L,79726887240L,15466605150360L,3000441672282656L,582070217817684960L,BigInteger.Parse("112918621814958599640"),BigInteger.Parse("21905630561884150645256"),BigInteger.Parse("4249579410383710266580080"),BigInteger.Parse("824396499983877907565890320"),BigInteger.Parse("159928671417461930357516142056") };
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
public class A059989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059989.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059989Inst Instance=new A059989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059990
{
public static readonly long[] Value={ 1L,1L,7L,5L,31L,7L,127L,85L,511L,341L,2047L,455L,8191L,5461L,32767L,21845L,131071L,9709L,524287L,349525L,2097151L,1398101L,8388607L,1864135L,33554431L,22369621L,134217727L,89478485L,536870911L,119304647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059990Inst : IEnumerable<long>
{
public static readonly long[] Value=A059990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059990.Bytes);
public long this[int i]=>Value[i];

public static A059990Inst Instance=new A059990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059991
{
public static readonly long[] Value={ 1L,1L,4L,1L,16L,16L,64L,1L,256L,256L,1024L,256L,4096L,4096L,16384L,1L,65536L,65536L,262144L,65536L,1048576L,1048576L,4194304L,65536L,16777216L,16777216L,67108864L,16777216L,268435456L,268435456L,1073741824L,1L,4294967296L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059991Inst : IEnumerable<long>
{
public static readonly long[] Value=A059991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059991.Bytes);
public long this[int i]=>Value[i];

public static A059991Inst Instance=new A059991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059992
{
public static readonly long[] Value={ 1L,4L,8L,12L,24L,36L,48L,60L,72L,120L,180L,240L,360L,720L,840L,1080L,1260L,1440L,1680L,2160L,2520L,4320L,5040L,7560L,10080L,15120L,20160L,25200L,27720L,30240L,45360L,50400L,55440L,75600L,83160L,110880L,151200L,166320L,221760L,277200L,332640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059992Inst : IEnumerable<long>
{
public static readonly long[] Value=A059992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059992.Bytes);
public long this[int i]=>Value[i];

public static A059992Inst Instance=new A059992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059993
{
public static readonly long[] Value={ 1L,9L,21L,37L,57L,81L,109L,141L,177L,217L,261L,309L,361L,417L,477L,541L,609L,681L,757L,837L,921L,1009L,1101L,1197L,1297L,1401L,1509L,1621L,1737L,1857L,1981L,2109L,2241L,2377L,2517L,2661L,2809L,2961L,3117L,3277L,3441L,3609L,3781L,3957L,4137L,4321L,4509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059993Inst : IEnumerable<long>
{
public static readonly long[] Value=A059993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059993.Bytes);
public long this[int i]=>Value[i];

public static A059993Inst Instance=new A059993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059994
{
public static readonly long[] Value={ 2L,4L,5L,10L,16L,17L,31L,48L,79L,87L,111L,185L,187L,254L,259L,425L,432L,557L,627L,875L,922L,1173L,1232L,1262L,1776L,1927L,2446L,2592L,3485L,3881L,4655L,4775L,5122L,6657L,7399L,8843L,9068L,9794L,12546L,13738L,16439L,16876L,18398L,22522L,25136L,29546L,30842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059994Inst : IEnumerable<long>
{
public static readonly long[] Value=A059994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059994.Bytes);
public long this[int i]=>Value[i];

public static A059994Inst Instance=new A059994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059995
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059995Inst : IEnumerable<long>
{
public static readonly long[] Value=A059995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059995.Bytes);
public long this[int i]=>Value[i];

public static A059995Inst Instance=new A059995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059996
{
public static readonly BigInteger[] Value={ 1L,11L,112L,1125L,112514L,11251442L,11251442132L,11251442132429L,112514421324291430L,BigInteger.Parse("1125144213242914304862"),BigInteger.Parse("112514421324291430486216796"),BigInteger.Parse("11251442132429143048621679658786") };
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
public class A059996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A059996.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A059996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A059996Inst Instance=new A059996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059997
{
public static readonly long[] Value={ 14L,51L,120L,230L,390L,609L,896L,1260L,1710L,2255L,2904L,3666L,4550L,5565L,6720L,8024L,9486L,11115L,12920L,14910L,17094L,19481L,22080L,24900L,27950L,31239L,34776L,38570L,42630L,46965L,51584L,56496L,61710L,67235L,73080L,79254L,85766L,92625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059997Inst : IEnumerable<long>
{
public static readonly long[] Value=A059997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059997.Bytes);
public long this[int i]=>Value[i];

public static A059997Inst Instance=new A059997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059998
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,2L,3L,3L,4L,4L,3L,3L,5L,4L,6L,5L,5L,5L,7L,5L,8L,6L,7L,7L,9L,6L,8L,5L,8L,7L,10L,5L,11L,8L,10L,9L,10L,4L,12L,7L,11L,9L,13L,7L,14L,8L,13L,11L,15L,9L,14L,7L,14L,11L,16L,7L,15L,8L,15L,13L,17L,6L,18L,11L,17L,13L,17L,5L,19L,11L,18L,13L,20L,10L,21L,11L,20L,15L,20L,9L,22L,10L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059998Inst : IEnumerable<long>
{
public static readonly long[] Value=A059998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059998.Bytes);
public long this[int i]=>Value[i];

public static A059998Inst Instance=new A059998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A059999
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,42L,168L,520L,1312L,2861L,5607L,10133L,17185L,27692L,42786L,63822L,92398L,130375L,179897L,243411L,323687L,423838L,547340L,698052L,880236L,1098577L,1358203L,1664705L,2024157L,2443136L,2928742L,3488618L,4130970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A059999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A059999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A059999Inst : IEnumerable<long>
{
public static readonly long[] Value=A059999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A059999.Bytes);
public long this[int i]=>Value[i];

public static A059999Inst Instance=new A059999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060000
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,6L,7L,8L,15L,10L,11L,12L,13L,14L,27L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,51L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,99L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060000Inst : IEnumerable<long>
{
public static readonly long[] Value=A060000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060000.Bytes);
public long this[int i]=>Value[i];

public static A060000Inst Instance=new A060000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060001
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,120L,40320L,6227020800L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("295232799039604140847618609643520000000"),BigInteger.Parse("12696403353658275925965100847566516959580321051449436762275840000000000000") };
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
public class A060001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060001Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A060001.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A060001.Bytes);
public BigInteger this[int i]=>Value[i];

public static A060001Inst Instance=new A060001Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060002
{
public static readonly long[] Value={ 0L,1L,2L,11L,3L,12L,111L,4L,13L,22L,112L,1111L,5L,14L,23L,113L,122L,1112L,11111L,6L,15L,24L,33L,114L,123L,222L,1113L,1122L,11112L,111111L,7L,16L,25L,34L,115L,124L,133L,223L,1114L,1123L,1222L,11113L,11122L,111112L,1111111L,8L,17L,26L,35L,44L,116L,125L,134L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060002Inst : IEnumerable<long>
{
public static readonly long[] Value=A060002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060002.Bytes);
public long this[int i]=>Value[i];

public static A060002Inst Instance=new A060002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060003
{
public static readonly long[] Value={ 1L,3L,17L,137L,227L,977L,1187L,1493L,5777L,5993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060003Inst : IEnumerable<long>
{
public static readonly long[] Value=A060003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060003.Bytes);
public long this[int i]=>Value[i];

public static A060003Inst Instance=new A060003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060004
{
public static readonly long[] Value={ 1L,5L,13L,21L,49L,55L,91L,139L,259L,181L,301L,391L,481L,559L,619L,829L,859L,1069L,1111L,1081L,1489L,1609L,1741L,1951L,2029L,2971L,2341L,3379L,3769L,3331L,3589L,3961L,4525L,4189L,5281L,4801L,4975L,6361L,7579L,5911L,6439L,7111L,6319L,9931L,11059L,8869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060004Inst : IEnumerable<long>
{
public static readonly long[] Value=A060004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060004.Bytes);
public long this[int i]=>Value[i];

public static A060004Inst Instance=new A060004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060005
{
public static readonly long[] Value={ 1L,1L,7L,62L,657L,7636L,93846L,1199892L,15796439L,212681976L,2915017360L,40536016030L,570497115729L,8110661588734L,116307527411482L,1680341334827514L,24435006625667338L,357366669614512168L,5253165510907071170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060005Inst : IEnumerable<long>
{
public static readonly long[] Value=A060005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060005.Bytes);
public long this[int i]=>Value[i];

public static A060005Inst Instance=new A060005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060006
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,1L,7L,9L,5L,7L,2L,4L,4L,7L,4L,6L,0L,2L,5L,9L,6L,0L,9L,0L,8L,8L,5L,4L,4L,7L,8L,0L,9L,7L,3L,4L,0L,7L,3L,4L,4L,0L,4L,0L,5L,6L,9L,0L,1L,7L,3L,3L,3L,6L,4L,5L,3L,4L,0L,1L,5L,0L,5L,0L,3L,0L,2L,8L,2L,7L,8L,5L,1L,2L,4L,5L,5L,4L,7L,5L,9L,4L,0L,5L,4L,6L,9L,9L,3L,4L,7L,9L,8L,1L,7L,8L,7L,2L,8L,0L,3L,2L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060006Inst : IEnumerable<long>
{
public static readonly long[] Value=A060006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060006.Bytes);
public long this[int i]=>Value[i];

public static A060006Inst Instance=new A060006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060007
{
public static readonly long[] Value={ 1L,2L,2L,0L,7L,4L,4L,0L,8L,4L,6L,0L,5L,7L,5L,9L,4L,7L,5L,3L,6L,1L,6L,8L,5L,3L,4L,9L,1L,0L,8L,8L,3L,1L,9L,1L,4L,4L,3L,2L,4L,8L,9L,0L,8L,6L,2L,4L,8L,6L,3L,5L,2L,1L,4L,2L,8L,8L,2L,4L,4L,4L,5L,3L,0L,4L,9L,7L,1L,0L,0L,0L,8L,5L,2L,2L,5L,9L,1L,3L,5L,0L,2L,5L,3L,0L,9L,5L,5L,2L,1L,8L,6L,9L,9L,6L,2L,8L,6L,2L,5L,7L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060007Inst : IEnumerable<long>
{
public static readonly long[] Value=A060007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060007.Bytes);
public long this[int i]=>Value[i];

public static A060007Inst Instance=new A060007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060008
{
public static readonly long[] Value={ 0L,0L,0L,0L,9L,45L,135L,315L,630L,1134L,1890L,2970L,4455L,6435L,9009L,12285L,16380L,21420L,27540L,34884L,43605L,53865L,65835L,79695L,95634L,113850L,134550L,157950L,184275L,213759L,246645L,283185L,323640L,368280L,417384L,471240L,530145L,594405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060008Inst : IEnumerable<long>
{
public static readonly long[] Value=A060008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060008.Bytes);
public long this[int i]=>Value[i];

public static A060008Inst Instance=new A060008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060009
{
public static readonly long[] Value={ 1L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,36L,38L,39L,40L,41L,42L,43L,44L,46L,66L,67L,68L,69L,70L,71L,72L,73L,92L,101L,121L,122L,123L,124L,125L,126L,127L,146L,155L,174L,182L,201L,211L,229L,230L,237L,256L,284L,285L,286L,287L,288L,289L,290L,291L,311L,348L,365L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060009Inst : IEnumerable<long>
{
public static readonly long[] Value=A060009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060009.Bytes);
public long this[int i]=>Value[i];

public static A060009Inst Instance=new A060009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060010
{
public static readonly long[] Value={ 1L,12L,312L,10464L,398208L,16323072L,702465024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060010Inst : IEnumerable<long>
{
public static readonly long[] Value=A060010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060010.Bytes);
public long this[int i]=>Value[i];

public static A060010Inst Instance=new A060010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060011
{
public static readonly long[] Value={ 1L,5L,6L,2L,4L,9L,6L,3L,9L,2L,1L,3L,7L,5L,9L,9L,9L,9L,6L,3L,9L,3L,6L,9L,9L,9L,9L,2L,1L,3L,4L,8L,9L,3L,6L,9L,7L,8L,6L,2L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060011Inst : IEnumerable<long>
{
public static readonly long[] Value=A060011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060011.Bytes);
public long this[int i]=>Value[i];

public static A060011Inst Instance=new A060011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060012
{
public static readonly long[] Value={ 101L,461L,617L,809L,1151L,1619L,1787L,1877L,2381L,2789L,3581L,3851L,4001L,4049L,4259L,4637L,5099L,5441L,5477L,5639L,6449L,6569L,7211L,7487L,7949L,8087L,8219L,8597L,8627L,8837L,9011L,9041L,9431L,10427L,11117L,11351L,11777L,12239L,13217L,13709L,13721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060012Inst : IEnumerable<long>
{
public static readonly long[] Value=A060012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060012.Bytes);
public long this[int i]=>Value[i];

public static A060012Inst Instance=new A060012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060013
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,15L,27L,51L,99L,195L,387L,771L,1539L,3075L,6147L,12291L,24579L,49155L,98307L,196611L,393219L,786435L,1572867L,3145731L,6291459L,12582915L,25165827L,50331651L,100663299L,201326595L,402653187L,805306371L,1610612739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060013Inst : IEnumerable<long>
{
public static readonly long[] Value=A060013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060013.Bytes);
public long this[int i]=>Value[i];

public static A060013Inst Instance=new A060013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060014
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,67L,471L,3271L,31333L,299223L,3291487L,39020911L,543960561L,7466726983L,118551513523L,1917378505407L,32405299019941L,608246253790591L,12219834139189263L,253767339725277823L,5591088918313739017L,BigInteger.Parse("126036990829657056711"),BigInteger.Parse("2956563745611392385211") };
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
public class A060014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A060014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A060014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A060014Inst Instance=new A060014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060015
{
public static readonly long[] Value={ 1L,1L,7L,31L,211L,1411L,12601L,137047L,1516831L,18111751L,223179001L,2973194071L,46287964867L,835826439631L,15722804528341L,292673102609791L,5177400032329231L,102538737981192607L,2284570602107946601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060015Inst : IEnumerable<long>
{
public static readonly long[] Value=A060015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060015.Bytes);
public long this[int i]=>Value[i];

public static A060015Inst Instance=new A060015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060016
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,1L,0L,0L,0L,1L,3L,1L,0L,0L,0L,0L,1L,3L,2L,0L,0L,0L,0L,0L,1L,4L,3L,0L,0L,0L,0L,0L,0L,1L,4L,4L,1L,0L,0L,0L,0L,0L,0L,1L,5L,5L,1L,0L,0L,0L,0L,0L,0L,0L,1L,5L,7L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,8L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,10L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060016Inst : IEnumerable<long>
{
public static readonly long[] Value=A060016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060016.Bytes);
public long this[int i]=>Value[i];

public static A060016Inst Instance=new A060016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060017
{
public static readonly long[] Value={ 2L,7L,27L,120L,642L,3767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060017Inst : IEnumerable<long>
{
public static readonly long[] Value=A060017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060017.Bytes);
public long this[int i]=>Value[i];

public static A060017Inst Instance=new A060017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060018
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060018Inst : IEnumerable<long>
{
public static readonly long[] Value=A060018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060018.Bytes);
public long this[int i]=>Value[i];

public static A060018Inst Instance=new A060018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060019
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,6L,7L,8L,9L,10L,10L,11L,12L,12L,13L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,19L,20L,20L,20L,21L,22L,22L,23L,23L,24L,24L,24L,25L,25L,26L,26L,26L,27L,27L,27L,28L,28L,29L,30L,30L,30L,30L,30L,31L,31L,32L,32L,32L,33L,33L,33L,34L,34L,35L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060019Inst : IEnumerable<long>
{
public static readonly long[] Value=A060019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060019.Bytes);
public long this[int i]=>Value[i];

public static A060019Inst Instance=new A060019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060020
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,8L,7L,9L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060020Inst : IEnumerable<long>
{
public static readonly long[] Value=A060020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060020.Bytes);
public long this[int i]=>Value[i];

public static A060020Inst Instance=new A060020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060021
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060021Inst : IEnumerable<long>
{
public static readonly long[] Value=A060021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060021.Bytes);
public long this[int i]=>Value[i];

public static A060021Inst Instance=new A060021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060022
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,-1L,-1L,-3L,-3L,-5L,-6L,-8L,-9L,-12L,-13L,-16L,-18L,-21L,-23L,-27L,-29L,-33L,-36L,-40L,-43L,-48L,-51L,-56L,-60L,-65L,-69L,-75L,-79L,-85L,-90L,-96L,-101L,-108L,-113L,-120L,-126L,-133L,-139L,-147L,-153L,-161L,-168L,-176L,-183L,-192L,-199L,-208L,-216L,-225L,-233L,-243L,-251L,-261L,-270L,-280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060022Inst : IEnumerable<long>
{
public static readonly long[] Value=A060022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060022.Bytes);
public long this[int i]=>Value[i];

public static A060022Inst Instance=new A060022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060023
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,-1L,-1L,-3L,-4L,-7L,-8L,-13L,-15L,-20L,-24L,-31L,-35L,-44L,-50L,-60L,-68L,-80L,-89L,-104L,-115L,-131L,-145L,-164L,-179L,-201L,-219L,-243L,-264L,-291L,-314L,-345L,-371L,-404L,-434L,-471L,-503L,-544L,-580L,-624L,-664L,-712L,-755L,-808L,-855L,-911L,-963L,-1024L,-1079L,-1145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060023Inst : IEnumerable<long>
{
public static readonly long[] Value=A060023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060023.Bytes);
public long this[int i]=>Value[i];

public static A060023Inst Instance=new A060023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060024
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,2L,1L,2L,0L,0L,-3L,-3L,-8L,-10L,-16L,-20L,-29L,-35L,-47L,-56L,-72L,-85L,-105L,-122L,-148L,-171L,-202L,-231L,-270L,-306L,-353L,-397L,-453L,-507L,-573L,-637L,-715L,-791L,-881L,-970L,-1075L,-1178L,-1298L,-1417L,-1554L,-1691L,-1846L,-2001L,-2177L,-2353L,-2550L,-2748L,-2969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060024Inst : IEnumerable<long>
{
public static readonly long[] Value=A060024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060024.Bytes);
public long this[int i]=>Value[i];

public static A060024Inst Instance=new A060024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060025
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,2L,4L,3L,4L,2L,3L,-1L,-1L,-6L,-9L,-17L,-22L,-35L,-43L,-61L,-76L,-100L,-121L,-155L,-185L,-229L,-271L,-328L,-383L,-458L,-529L,-622L,-715L,-830L,-946L,-1090L,-1233L,-1407L,-1584L,-1794L,-2008L,-2261L,-2517L,-2816L,-3124L,-3476L,-3838L,-4253L,-4677L,-5159L,-5656L,-6213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060025Inst : IEnumerable<long>
{
public static readonly long[] Value=A060025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060025.Bytes);
public long this[int i]=>Value[i];

public static A060025Inst Instance=new A060025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060026
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,3L,5L,5L,7L,6L,9L,6L,8L,5L,5L,-1L,-2L,-13L,-18L,-33L,-45L,-68L,-86L,-121L,-151L,-198L,-244L,-310L,-373L,-464L,-553L,-671L,-793L,-948L,-1107L,-1309L,-1517L,-1771L,-2039L,-2360L,-2696L,-3098L,-3519L,-4011L,-4534L,-5137L,-5774L,-6508L,-7283L,-8163L,-9099L,-10153L,-11269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060026Inst : IEnumerable<long>
{
public static readonly long[] Value=A060026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060026.Bytes);
public long this[int i]=>Value[i];

public static A060026Inst Instance=new A060026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060027
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,6L,6L,9L,9L,13L,12L,16L,15L,18L,15L,18L,12L,12L,2L,-3L,-20L,-31L,-59L,-81L,-122L,-160L,-222L,-280L,-369L,-457L,-581L,-708L,-878L,-1055L,-1286L,-1528L,-1833L,-2158L,-2559L,-2985L,-3504L,-4059L,-4721L,-5433L,-6271L,-7172L,-8224L,-9355L,-10660L,-12067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060027Inst : IEnumerable<long>
{
public static readonly long[] Value=A060027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060027.Bytes);
public long this[int i]=>Value[i];

public static A060027Inst Instance=new A060027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060028
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,7L,10L,11L,16L,16L,22L,23L,29L,29L,36L,34L,41L,37L,40L,32L,32L,14L,6L,-22L,-44L,-90L,-130L,-203L,-270L,-378L,-487L,-642L,-803L,-1027L,-1260L,-1568L,-1899L,-2320L,-2774L,-3342L,-3955L,-4706L,-5526L,-6507L,-7579L,-8854L,-10243L,-11872L,-13656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060028Inst : IEnumerable<long>
{
public static readonly long[] Value=A060028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060028.Bytes);
public long this[int i]=>Value[i];

public static A060028Inst Instance=new A060028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060029
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,4L,4L,7L,8L,11L,12L,18L,19L,26L,29L,37L,40L,51L,53L,65L,68L,79L,80L,92L,87L,94L,84L,82L,58L,45L,-1L,-36L,-109L,-180L,-297L,-413L,-594L,-780L,-1042L,-1325L,-1704L,-2112L,-2647L,-3228L,-3961L,-4772L,-5769L,-6867L,-8206L,-9682L,-11446L,-13402L,-15710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060029Inst : IEnumerable<long>
{
public static readonly long[] Value=A060029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060029.Bytes);
public long this[int i]=>Value[i];

public static A060029Inst Instance=new A060029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060030
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,8L,7L,6L,13L,12L,11L,10L,21L,20L,19L,18L,17L,16L,15L,14L,29L,28L,27L,26L,25L,24L,23L,22L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,93L,92L,91L,90L,89L,88L,87L,86L,85L,84L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060030Inst : IEnumerable<long>
{
public static readonly long[] Value=A060030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060030.Bytes);
public long this[int i]=>Value[i];

public static A060030Inst Instance=new A060030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060031
{
public static readonly long[] Value={ 1L,4L,10L,14L,22L,30L,35L,46L,62L,72L,77L,94L,105L,126L,146L,156L,161L,190L,212L,217L,252L,254L,294L,314L,324L,329L,382L,426L,436L,441L,506L,510L,511L,546L,590L,630L,650L,660L,665L,742L,766L,854L,874L,884L,889L,1014L,1022L,1024L,1029L,1094L,1099L,1134L,1182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060031Inst : IEnumerable<long>
{
public static readonly long[] Value=A060031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060031.Bytes);
public long this[int i]=>Value[i];

public static A060031Inst Instance=new A060031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060032
{
public static readonly BigInteger[] Value={ 1L,121L,121122121L,BigInteger.Parse("121122121121122122121122121"),BigInteger.Parse("121122121121122122121122121121122121121122122121122122121122121121122122121122121") };
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
public class A060032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A060032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A060032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A060032Inst Instance=new A060032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060033
{
public static readonly long[] Value={ 51L,55L,57L,58L,59L,60L,76L,80L,82L,82L,99L,104L,110L,112L,115L,117L,122L,123L,126L,127L,132L,135L,138L,144L,147L,149L,151L,152L,154L,157L,158L,159L,159L,166L,179L,184L,185L,188L,189L,191L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060033Inst : IEnumerable<long>
{
public static readonly long[] Value=A060033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060033.Bytes);
public long this[int i]=>Value[i];

public static A060033Inst Instance=new A060033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,4L,0L,9L,3L,12L,0L,22L,0L,28L,9L,43L,0L,63L,3L,82L,19L,107L,0L,170L,0L,189L,43L,258L,12L,372L,0L,435L,82L,557L,0L,808L,0L,900L,162L,1150L,0L,1599L,9L,1836L,258L,2252L,0L,3111L,46L,3476L,435L,4308L,0L,5827L,0L,6501L,727L,7917L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060034Inst : IEnumerable<long>
{
public static readonly long[] Value=A060034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060034.Bytes);
public long this[int i]=>Value[i];

public static A060034Inst Instance=new A060034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060035
{
public static readonly long[] Value={ 0L,1L,3L,12L,9L,16L,15L,19L,27L,30L,44L,40L,55L,52L,65L,60L,51L,75L,73L,80L,86L,82L,81L,77L,98L,85L,95L,79L,118L,141L,162L,107L,129L,105L,158L,145L,155L,143L,138L,152L,203L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060035Inst : IEnumerable<long>
{
public static readonly long[] Value=A060035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060035.Bytes);
public long this[int i]=>Value[i];

public static A060035Inst Instance=new A060035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060036
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,4L,4L,1L,1L,4L,3L,4L,1L,1L,4L,2L,2L,4L,1L,1L,4L,1L,0L,1L,4L,1L,1L,4L,0L,7L,7L,0L,4L,1L,1L,4L,9L,6L,5L,6L,9L,4L,1L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060036Inst : IEnumerable<long>
{
public static readonly long[] Value=A060036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060036.Bytes);
public long this[int i]=>Value[i];

public static A060036Inst Instance=new A060036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060037
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,4L,1L,4L,3L,1L,4L,2L,1L,4L,1L,0L,1L,4L,0L,7L,1L,4L,9L,6L,5L,1L,4L,9L,5L,3L,1L,4L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,1L,4L,9L,2L,11L,8L,7L,1L,4L,9L,1L,10L,6L,4L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,16L,8L,2L,15L,13L,1L,4L,9L,16L,7L,0L,13L,10L,9L,1L,4L,9L,16L,6L,17L,11L,7L,5L,1L,4L,9L,16L,5L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060037Inst : IEnumerable<long>
{
public static readonly long[] Value=A060037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060037.Bytes);
public long this[int i]=>Value[i];

public static A060037Inst Instance=new A060037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060038
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060038Inst : IEnumerable<long>
{
public static readonly long[] Value=A060038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060038.Bytes);
public long this[int i]=>Value[i];

public static A060038Inst Instance=new A060038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060039
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060039Inst : IEnumerable<long>
{
public static readonly long[] Value=A060039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060039.Bytes);
public long this[int i]=>Value[i];

public static A060039Inst Instance=new A060039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060040
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,5L,1L,2L,3L,4L,9L,1L,2L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060040Inst : IEnumerable<long>
{
public static readonly long[] Value=A060040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060040.Bytes);
public long this[int i]=>Value[i];

public static A060040Inst Instance=new A060040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060041
{
public static readonly BigInteger[] Value={ 5L,2875L,609250L,317206375L,242467530000L,229305888887625L,248249742118022000L,BigInteger.Parse("295091050570845659250"),BigInteger.Parse("375632160937476603550000"),BigInteger.Parse("503840510416985243645106250"),BigInteger.Parse("704288164978454686113488249750"),BigInteger.Parse("1017913203569692432490203659468875"),BigInteger.Parse("1512323901934139334751675234074638000") };
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
public class A060041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A060041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A060041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A060041Inst Instance=new A060041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060042
{
public static readonly long[] Value={ 1L,2L,30L,420L,5766L,79356L,1105868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060042Inst : IEnumerable<long>
{
public static readonly long[] Value=A060042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060042.Bytes);
public long this[int i]=>Value[i];

public static A060042Inst Instance=new A060042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060043
{
public static readonly long[] Value={ 1L,3L,1L,4L,3L,7L,9L,6L,1L,15L,12L,3L,30L,8L,9L,45L,15L,22L,67L,13L,1L,42L,99L,18L,3L,81L,135L,12L,9L,140L,175L,28L,22L,231L,231L,14L,51L,351L,306L,24L,1L,97L,551L,354L,24L,3L,188L,783L,465L,31L,9L,330L,1134L,540L,18L,22L,568L,1546L,681L,39L,51L,918L,2142L,765L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060043Inst : IEnumerable<long>
{
public static readonly long[] Value=A060043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060043.Bytes);
public long this[int i]=>Value[i];

public static A060043Inst Instance=new A060043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A060044
{
public static readonly long[] Value={ 1L,-1L,1L,4L,-1L,-5L,1L,6L,1L,3L,-4L,-1L,-2L,8L,1L,1L,-13L,-2L,-5L,13L,1L,10L,23L,-6L,-1L,-11L,-25L,12L,1L,12L,27L,-20L,-2L,-21L,-49L,14L,3L,31L,74L,-8L,1L,5L,-13L,-62L,24L,-1L,-4L,23L,85L,-29L,1L,2L,-42L,-132L,18L,-2L,-8L,42L,165L,-13L,3L,14L,-42L,-195L,20L,-4L,-20L,43L,229L,-30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A060044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A060044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A060044Inst : IEnumerable<long>
{
public static readonly long[] Value=A060044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A060044.Bytes);
public long this[int i]=>Value[i];

public static A060044Inst Instance=new A060044Inst();

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