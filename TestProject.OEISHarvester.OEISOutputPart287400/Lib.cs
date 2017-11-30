using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A232847
{
public static readonly long[] Value={ 1L,22L,17310L,20802L,23110L,24262L,25995L,26542L,29427L,31735L,33835L,38137L,39287L,39859L,40967L,13595040L,14285160L,15129504L,15378336L,15834528L,15912936L,16327008L,16555752L,16897896L,16908264L,17054388L,17145432L,17749044L,18013428L,20239146L,20713482L,21265578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232847Inst : IEnumerable<long>
{
public static readonly long[] Value=A232847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232847.Bytes);
public long this[int i]=>Value[i];

public static A232847Inst Instance=new A232847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233200
{
public static readonly BigInteger[] Value={ 236L,131328L,123551744L,123833679872L,127365174788096L,132364161848967168L,BigInteger.Parse("138127371171167993856"),BigInteger.Parse("144372294092575012290560"),BigInteger.Parse("150991906277433156745297920"),BigInteger.Parse("157951736213079507379343589376") };
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
public class A233200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233200Inst Instance=new A233200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233201
{
public static readonly BigInteger[] Value={ 1248L,2098176L,5496242176L,15635845218304L,46111939268444160L,BigInteger.Parse("138127371171167993856"),BigInteger.Parse("416547612309880393695232"),BigInteger.Parse("1259808519497450508966166528"),BigInteger.Parse("3814894993577338604838516162560") };
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
public class A233201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233201Inst Instance=new A233201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233202
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,11L,36L,36L,11L,48L,528L,1440L,528L,48L,236L,8256L,62720L,62720L,8256L,236L,1248L,131328L,2779136L,7802880L,2779136L,131328L,1248L,6896L,2098176L,123551744L,981532672L,981532672L,123551744L,2098176L,6896L,39168L,33558528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233202Inst : IEnumerable<long>
{
public static readonly long[] Value=A233202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233202.Bytes);
public long this[int i]=>Value[i];

public static A233202Inst Instance=new A233202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233203
{
public static readonly BigInteger[] Value={ 1L,0L,1L,3L,16L,97L,729L,6433L,65536L,756680L,9765625L,139312339L,2176782336L,36972058910L,678223072849L,13363461010158L,281474976710656L,6311342330065435L,150094635296999121L,3773536025353076151L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("2785962590401641140642"),BigInteger.Parse("81402749386839761113321") };
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
public class A233203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233203Inst Instance=new A233203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233204
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,3L,1L,4L,3L,2L,2L,2L,4L,3L,2L,6L,3L,2L,1L,8L,1L,2L,2L,4L,7L,2L,5L,6L,8L,5L,4L,4L,8L,3L,5L,2L,7L,5L,8L,5L,3L,4L,4L,4L,8L,6L,2L,4L,3L,7L,7L,3L,4L,7L,5L,3L,4L,6L,8L,4L,2L,6L,6L,4L,7L,7L,5L,7L,7L,6L,6L,2L,7L,8L,7L,7L,5L,11L,3L,4L,8L,2L,7L,8L,6L,9L,7L,6L,10L,11L,4L,5L,8L,4L,8L,8L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233204Inst : IEnumerable<long>
{
public static readonly long[] Value=A233204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233204.Bytes);
public long this[int i]=>Value[i];

public static A233204Inst Instance=new A233204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233205
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,16L,24L,32L,48L,64L,96L,128L,160L,192L,256L,320L,384L,512L,640L,768L,1024L,1280L,1536L,2048L,3072L,4096L,6144L,12288L,24576L,122880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233205Inst : IEnumerable<long>
{
public static readonly long[] Value=A233205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233205.Bytes);
public long this[int i]=>Value[i];

public static A233205Inst Instance=new A233205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233206
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,2L,2L,2L,3L,1L,5L,2L,3L,5L,3L,3L,4L,7L,4L,4L,6L,3L,3L,5L,6L,4L,5L,4L,4L,2L,4L,4L,7L,9L,4L,6L,5L,5L,5L,6L,8L,8L,7L,8L,6L,5L,5L,5L,7L,8L,7L,7L,8L,7L,9L,7L,6L,10L,6L,6L,9L,4L,7L,4L,9L,8L,8L,5L,9L,6L,2L,6L,7L,3L,8L,8L,9L,9L,7L,6L,10L,8L,8L,11L,7L,7L,4L,6L,8L,8L,5L,8L,5L,8L,14L,8L,7L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233206Inst : IEnumerable<long>
{
public static readonly long[] Value=A233206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233206.Bytes);
public long this[int i]=>Value[i];

public static A233206Inst Instance=new A233206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233207
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,4L,0L,10L,12L,6L,0L,14L,20L,18L,8L,0L,18L,28L,30L,24L,10L,0L,22L,36L,42L,40L,30L,12L,0L,26L,44L,54L,56L,50L,36L,14L,0L,30L,52L,66L,72L,70L,60L,42L,16L,0L,34L,60L,78L,88L,90L,84L,70L,48L,18L,0L,38L,68L,90L,104L,110L,108L,98L,80L,54L,20L,0L,42L,76L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233207Inst : IEnumerable<long>
{
public static readonly long[] Value=A233207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233207.Bytes);
public long this[int i]=>Value[i];

public static A233207Inst Instance=new A233207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233208
{
public static readonly long[] Value={ 3L,2L,6L,7L,2L,3L,35L,3L,2L,5L,10L,2L,2L,17L,4L,2L,4L,14L,2L,2L,11L,5L,2L,4L,23L,3L,2L,8L,5L,2L,3L,66L,3L,2L,7L,7L,2L,3L,76L,3L,2L,5L,8L,2L,3L,24L,4L,2L,5L,11L,2L,2L,14L,4L,2L,4L,17L,2L,2L,10L,5L,2L,3L,33L,3L,2L,8L,6L,2L,3L,502L,3L,2L,6L,7L,2L,3L,38L,3L,2L,5L,9L,2L,2L,18L,4L,2L,4L,13L,2L,2L,12L,5L,2L,4L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233208Inst : IEnumerable<long>
{
public static readonly long[] Value=A233208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233208.Bytes);
public long this[int i]=>Value[i];

public static A233208Inst Instance=new A233208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233209
{
public static readonly long[] Value={ 3L,6L,7L,35L,66L,76L,502L,952L,1063L,9067L,17347L,18996L,199826L,384870L,415618L,5202154L,10069003L,10762714L,156217515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233209Inst : IEnumerable<long>
{
public static readonly long[] Value=A233209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233209.Bytes);
public long this[int i]=>Value[i];

public static A233209Inst Instance=new A233209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233210
{
public static readonly BigInteger[] Value={ 1L,23L,35446L,1340889772L,919538740854193L,BigInteger.Parse("11130643973331790638169"),BigInteger.Parse("2376789549887845473135654118063"),BigInteger.Parse("8953226350132547895513770025061062694978") };
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
public class A233210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233210Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233210.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233210Inst Instance=new A233210Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233211
{
public static readonly BigInteger[] Value={ 2L,23L,452L,10313L,249062L,6147803L,152986472L,3818284493L,95399716682L,2384476356383L,59607259863692L,1490139655179473L,37253114806771502L,931324481014849763L,BigInteger.Parse("23283081522981304112"),BigInteger.Parse("582076763553023143253") };
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
public class A233211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233211Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233211.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233211Inst Instance=new A233211Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233212
{
public static readonly BigInteger[] Value={ 6L,376L,35446L,3638416L,380283286L,39892988056L,4187991850726L,439722934529296L,46170567719841766L,4847902462062966136L,BigInteger.Parse("509029608397682640406"),BigInteger.Parse("53448105729259172362576"),BigInteger.Parse("5612051035369765495590646") };
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
public class A233212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233212Inst Instance=new A233212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233213
{
public static readonly BigInteger[] Value={ 23L,7222L,3054973L,1340889772L,591021089923L,260625046992322L,114934898294104873L,BigInteger.Parse("50686253523654314872"),BigInteger.Parse("22352636009353302099823"),BigInteger.Parse("9857512392190471938857422"),BigInteger.Parse("4347162960647215744965074773") };
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
public class A233213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233213Inst Instance=new A233213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233214
{
public static readonly BigInteger[] Value={ 99L,147019L,268289572L,496475792293L,919538740854193L,1703198747507336644L,BigInteger.Parse("3154729081272072714436"),BigInteger.Parse("5843309615312787017886631"),BigInteger.Parse("10823201236481602133281929223"),BigInteger.Parse("20047146704348600802295758187282") };
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
public class A233214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233214Inst Instance=new A233214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233215
{
public static readonly BigInteger[] Value={ 452L,3054973L,23644611625L,183912498314536L,1430752433413485334L,BigInteger.Parse("11130643973331790638169"),BigInteger.Parse("86591682356567376541898371"),BigInteger.Parse("673646513468251754412792158962"),BigInteger.Parse("5240683780080621074089550798301976") };
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
public class A233215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233215Inst Instance=new A233215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233248
{
public static readonly long[] Value={ 1L,2L,7L,5L,17L,18L,16L,10L,22L,42L,10L,21L,28L,39L,32L,21L,36L,23L,18L,48L,16L,24L,48L,22L,84L,70L,66L,45L,14L,79L,30L,41L,36L,36L,66L,24L,76L,18L,53L,50L,40L,40L,88L,28L,93L,48L,32L,24L,110L,210L,68L,80L,108L,67L,20L,47L,66L,34L,58L,91L,60L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233248Inst : IEnumerable<long>
{
public static readonly long[] Value=A233248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233248.Bytes);
public long this[int i]=>Value[i];

public static A233248Inst Instance=new A233248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233249
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,10L,9L,16L,11L,32L,17L,18L,15L,64L,21L,128L,19L,34L,33L,256L,23L,36L,65L,42L,35L,512L,37L,1024L,31L,66L,129L,68L,43L,2048L,257L,130L,39L,4096L,69L,8192L,67L,74L,513L,16384L,47L,136L,73L,258L,131L,32768L,85L,132L,71L,514L,1025L,65536L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233249Inst : IEnumerable<long>
{
public static readonly long[] Value=A233249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233249.Bytes);
public long this[int i]=>Value[i];

public static A233249Inst Instance=new A233249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233250
{
public static readonly BigInteger[] Value={ 1L,10L,4672L,23896064L,1159192379392L,525597937107992576L,BigInteger.Parse("2242238966451009797226496"),BigInteger.Parse("90075874398562137894702244954112"),BigInteger.Parse("34144912055691090021767126315871433129984") };
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
public class A233250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233250Inst Instance=new A233250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233251
{
public static readonly BigInteger[] Value={ 3L,104L,4672L,221696L,10620928L,509640704L,24461443072L,1174138781696L,56358577635328L,2705211055407104L,129850125290831872L,6232805971010256896L,BigInteger.Parse("299174686264894947328"),BigInteger.Parse("14360384937966178402304"),BigInteger.Parse("689298477000386330755072") };
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
public class A233251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233251Inst Instance=new A233251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233252
{
public static readonly BigInteger[] Value={ 10L,1184L,166400L,23896064L,3439984640L,495341010944L,71328837140480L,10271348253261824L,1479074079750225920L,BigInteger.Parse("212986666384520904704"),BigInteger.Parse("30670079941778824232960"),BigInteger.Parse("4416491511334675712835584") };
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
public class A233252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233252Inst Instance=new A233252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233253
{
public static readonly BigInteger[] Value={ 36L,13952L,6049792L,2647261184L,1159192379392L,507618560835584L,222290692443996160L,BigInteger.Parse("97343107609552486400"),BigInteger.Parse("42627429627049642295296"),BigInteger.Parse("18666938062087506825838592"),BigInteger.Parse("8174421486934238668125110272") };
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
public class A233253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233253Inst Instance=new A233253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233254
{
public static readonly BigInteger[] Value={ 136L,166400L,220626944L,294517735424L,393427728465920L,525597937107992576L,BigInteger.Parse("702177183940808278016"),BigInteger.Parse("938080982436565861007360"),BigInteger.Parse("1253239344772433062871957504"),BigInteger.Parse("1674278572660580852636051308544") };
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
public class A233254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233254Inst Instance=new A233254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233255
{
public static readonly BigInteger[] Value={ 528L,1992704L,8050180096L,32835998056448L,134179300927602688L,BigInteger.Parse("548491734506604068864"),BigInteger.Parse("2242238966451009797226496"),BigInteger.Parse("9166394920089108387649814528"),BigInteger.Parse("37472795110784044637628292661248") };
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
public class A233255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233255Inst Instance=new A233255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233256
{
public static readonly long[] Value={ 1L,1L,3L,3L,10L,11L,10L,104L,136L,48L,36L,1184L,4672L,2080L,236L,136L,13952L,166400L,221696L,32896L,1248L,528L,166400L,6049792L,23896064L,10620928L,524800L,6896L,2080L,1992704L,220626944L,2647261184L,3439984640L,509640704L,8390656L,39168L,8256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233256Inst : IEnumerable<long>
{
public static readonly long[] Value=A233256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233256.Bytes);
public long this[int i]=>Value[i];

public static A233256Inst Instance=new A233256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233257
{
public static readonly long[] Value={ 3L,10L,104L,1184L,13952L,166400L,1992704L,23896064L,286687232L,3439984640L,41278767104L,495341010944L,5944075354112L,71328837140480L,855945777250304L,10271348253261824L,123256174744174592L,1479074079750225920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233257Inst : IEnumerable<long>
{
public static readonly long[] Value=A233257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233257.Bytes);
public long this[int i]=>Value[i];

public static A233257Inst Instance=new A233257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233258
{
public static readonly BigInteger[] Value={ 11L,136L,4672L,166400L,6049792L,220626944L,8050180096L,293762760704L,10720053821440L,391200251052032L,14275841005453312L,520959990903603200L,BigInteger.Parse("19011091850007150592"),BigInteger.Parse("693760794065113186304"),BigInteger.Parse("25317011997007519154176") };
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
public class A233258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233258Inst Instance=new A233258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233259
{
public static readonly BigInteger[] Value={ 48L,2080L,221696L,23896064L,2647261184L,294517735424L,32835998056448L,3662495243829248L,408547159030366208L,BigInteger.Parse("45573786789742641152"),BigInteger.Parse("5083813692357704941568"),BigInteger.Parse("567106285442412421578752") };
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
public class A233259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233259Inst Instance=new A233259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233260
{
public static readonly BigInteger[] Value={ 236L,32896L,10620928L,3439984640L,1159192379392L,393427728465920L,134179300927602688L,BigInteger.Parse("45829217084770353152"),BigInteger.Parse("15662712220567239393280"),BigInteger.Parse("5353914504847465071509504"),BigInteger.Parse("1830206096861520940880625664") };
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
public class A233260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233260Inst Instance=new A233260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233261
{
public static readonly BigInteger[] Value={ 1248L,524800L,509640704L,495341010944L,507618560835584L,525597937107992576L,BigInteger.Parse("548491734506604068864"),BigInteger.Parse("573981067569027897884672"),BigInteger.Parse("601558225688924228943872000"),BigInteger.Parse("630830989777808716060719841280") };
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
public class A233261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233261Inst Instance=new A233261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233262
{
public static readonly BigInteger[] Value={ 6896L,8390656L,24461443072L,71328837140480L,222290692443996160L,BigInteger.Parse("702177183940808278016"),BigInteger.Parse("2242238966451009797226496"),BigInteger.Parse("7190233079434838637629407232"),BigInteger.Parse("23116065100534863987420040265728") };
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
public class A233262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233262Inst Instance=new A233262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233263
{
public static readonly long[] Value={ 2L,157L,72673L,52472909L,85790059L,88573873L,16903607381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233263Inst : IEnumerable<long>
{
public static readonly long[] Value=A233263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233263.Bytes);
public long this[int i]=>Value[i];

public static A233263Inst Instance=new A233263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233312
{
public static readonly long[] Value={ 0L,3L,10L,15L,36L,43L,43L,63L,136L,147L,170L,175L,147L,175L,175L,255L,528L,547L,586L,591L,586L,683L,683L,703L,547L,591L,683L,703L,591L,703L,703L,1023L,2080L,2115L,2186L,2191L,2340L,2347L,2347L,2367L,2186L,2347L,2730L,2735L,2347L,2735L,2735L,2815L,2115L,2191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233312Inst : IEnumerable<long>
{
public static readonly long[] Value=A233312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233312.Bytes);
public long this[int i]=>Value[i];

public static A233312Inst Instance=new A233312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233313
{
public static readonly BigInteger[] Value={ 1L,4L,45L,717L,9787L,148414L,2282036L,34688229L,530613082L,8119995275L,124183342755L,1899899589557L,29066650643742L,444678773140018L,6803102237763707L,104079849391557116L,1592303310404361651L,BigInteger.Parse("24360457647669398381"),BigInteger.Parse("372687643806340329749"),BigInteger.Parse("5701702230014416236396") };
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
public class A233313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233313Inst Instance=new A233313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233314
{
public static readonly long[] Value={ 2L,3L,43L,79L,109L,113L,149L,163L,197L,241L,283L,293L,313L,317L,349L,359L,379L,401L,439L,463L,499L,521L,523L,547L,569L,577L,599L,617L,643L,659L,673L,683L,691L,701L,709L,719L,743L,769L,773L,787L,829L,839L,859L,863L,883L,887L,911L,919L,937L,953L,967L,983L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233314Inst : IEnumerable<long>
{
public static readonly long[] Value=A233314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233314.Bytes);
public long this[int i]=>Value[i];

public static A233314Inst Instance=new A233314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233315
{
public static readonly long[] Value={ 672L,768L,936L,1200L,10752L,12288L,14976L,19200L,34560L,40560L,48840L,54432L,57120L,62208L,75816L,97200L,138720L,154560L,172032L,196608L,239616L,307200L,420000L,480000L,552960L,585000L,648960L,750000L,781440L,870912L,913920L,995328L,1213056L,1555200L,2219520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233315Inst : IEnumerable<long>
{
public static readonly long[] Value=A233315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233315.Bytes);
public long this[int i]=>Value[i];

public static A233315Inst Instance=new A233315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233316
{
public static readonly BigInteger[] Value={ 0L,0L,1L,3L,1L,0L,-1L,0L,2L,0L,-3L,0L,5L,0L,-691L,0L,140L,0L,-10851L,0L,219335L,0L,-1222277L,0L,1709026L,0L,-1181820455L,0L,538845489L,0L,-23749461029L,0L,68926730208040L,0L,-84802531453387L,0L,270657225128535L,0L,BigInteger.Parse("-26315271553053477373"),0L,380899208799402670L,0L,BigInteger.Parse("-1827579029475143854357") };
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
public class A233316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233316Inst Instance=new A233316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233317
{
public static readonly long[] Value={ 108L,1728L,8748L,12348L,27648L,67500L,139968L,197568L,259308L,442368L,707472L,708588L,1000188L,1080000L,1581228L,2239488L,3084588L,3161088L,4148928L,5467500L,7077888L,7717500L,9020268L,11319552L,11337408L,14074668L,16003008L,17280000L,21003948L,25299648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233317Inst : IEnumerable<long>
{
public static readonly long[] Value=A233317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233317.Bytes);
public long this[int i]=>Value[i];

public static A233317Inst Instance=new A233317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233318
{
public static readonly long[] Value={ 2L,3L,197L,241L,283L,317L,359L,463L,499L,521L,547L,577L,617L,719L,773L,787L,829L,883L,887L,937L,967L,983L,1061L,1093L,1109L,1129L,1171L,1193L,1229L,1249L,1319L,1327L,1373L,1399L,1451L,1489L,1523L,1627L,1637L,1667L,1669L,1699L,1733L,1787L,1801L,1823L,1831L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233318Inst : IEnumerable<long>
{
public static readonly long[] Value=A233318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233318.Bytes);
public long this[int i]=>Value[i];

public static A233318Inst Instance=new A233318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233319
{
public static readonly BigInteger[] Value={ 1L,1L,3L,33L,726L,25236L,1229328L,78167484L,6193726506L,592068123054L,66673324219176L,8685890001564984L,1290531658541292252L,BigInteger.Parse("216188985806157611520"),BigInteger.Parse("40449991773179254230432"),BigInteger.Parse("8386998677130790903212000"),BigInteger.Parse("1914263814914709029067344724"),BigInteger.Parse("478208364783447353623777136772") };
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
public class A233319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233319Inst Instance=new A233319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233320
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,3L,3L,0L,1L,1L,0L,0L,10L,0L,0L,1L,1L,1L,0L,23L,23L,0L,1L,1L,1L,0L,11L,62L,0L,62L,11L,0L,1L,1L,0L,0L,170L,0L,0L,170L,0L,0L,1L,1L,1L,0L,441L,939L,0L,939L,441L,0L,1L,1L,1L,0L,41L,1173L,0L,8342L,8342L,0L,1173L,41L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233320Inst : IEnumerable<long>
{
public static readonly long[] Value=A233320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233320.Bytes);
public long this[int i]=>Value[i];

public static A233320Inst Instance=new A233320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233321
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,1L,0L,1L,1L,3L,1L,1L,0L,1L,1L,2L,2L,0L,1L,0L,1L,1L,4L,2L,3L,0L,1L,0L,1L,1L,2L,4L,1L,2L,0L,1L,0L,1L,1L,5L,3L,5L,1L,2L,0L,1L,0L,1L,1L,2L,6L,2L,4L,0L,2L,0L,1L,0L,1L,1L,6L,5L,8L,2L,4L,0L,2L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233321Inst : IEnumerable<long>
{
public static readonly long[] Value=A233321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233321.Bytes);
public long this[int i]=>Value[i];

public static A233321Inst Instance=new A233321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233322
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,3L,3L,4L,1L,2L,3L,3L,4L,1L,4L,5L,6L,6L,7L,1L,3L,5L,5L,6L,6L,7L,1L,5L,7L,10L,10L,11L,11L,12L,1L,3L,7L,8L,10L,10L,11L,11L,12L,1L,6L,9L,14L,15L,17L,17L,18L,18L,19L,1L,3L,9L,11L,15L,15L,17L,17L,18L,18L,19L,1L,7L,12L,20L,22L,26L,26L,28L,28L,29L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233322Inst : IEnumerable<long>
{
public static readonly long[] Value=A233322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233322.Bytes);
public long this[int i]=>Value[i];

public static A233322Inst Instance=new A233322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233323
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,1L,0L,1L,1L,4L,1L,1L,0L,1L,1L,2L,3L,0L,1L,0L,1L,1L,7L,3L,3L,0L,1L,0L,1L,1L,4L,6L,1L,2L,0L,1L,0L,1L,1L,12L,7L,7L,1L,2L,0L,1L,0L,1L,1L,7L,12L,3L,5L,0L,2L,0L,1L,0L,1L,1L,20L,16L,15L,3L,5L,0L,2L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233323Inst : IEnumerable<long>
{
public static readonly long[] Value=A233323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233323.Bytes);
public long this[int i]=>Value[i];

public static A233323Inst Instance=new A233323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233324
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,3L,3L,4L,1L,2L,3L,3L,4L,1L,5L,6L,7L,7L,8L,1L,3L,6L,6L,7L,7L,8L,1L,8L,11L,14L,14L,15L,15L,16L,1L,5L,11L,12L,14L,14L,15L,15L,16L,1L,13L,20L,27L,28L,30L,30L,31L,31L,32L,1L,8L,20L,23L,28L,28L,30L,30L,31L,31L,32L,1L,21L,37L,52L,55L,60L,60L,62L,62L,63L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233324Inst : IEnumerable<long>
{
public static readonly long[] Value=A233324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233324.Bytes);
public long this[int i]=>Value[i];

public static A233324Inst Instance=new A233324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233325
{
public static readonly long[] Value={ 1L,13L,85L,517L,3109L,18661L,111973L,671845L,4031077L,24186469L,145118821L,870712933L,5224277605L,31345665637L,188073993829L,1128443962981L,6770663777893L,40623982667365L,243743896004197L,1462463376025189L,8774780256151141L,52648681536906853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233325Inst : IEnumerable<long>
{
public static readonly long[] Value=A233325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233325.Bytes);
public long this[int i]=>Value[i];

public static A233325Inst Instance=new A233325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233326
{
public static readonly long[] Value={ 1L,15L,113L,799L,5601L,39215L,274513L,1921599L,13451201L,94158415L,659108913L,4613762399L,32296336801L,226074357615L,1582520503313L,11077643523199L,77543504662401L,542804532636815L,3799631728457713L,26597422099203999L,186181954694428001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233326Inst : IEnumerable<long>
{
public static readonly long[] Value=A233326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233326.Bytes);
public long this[int i]=>Value[i];

public static A233326Inst Instance=new A233326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233327
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,2L,8L,3L,16L,11L,32L,1L,64L,87L,128L,167L,256L,306L,512L,500L,1024L,552L,2048L,688L,4096L,3041L,8192L,579L,16384L,20854L,32768L,37075L,65536L,55618L,131072L,37108L,262144L,222296L,524288L,147729L,1048576L,891994L,2097152L,602155L,4194304L,3523022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233327Inst : IEnumerable<long>
{
public static readonly long[] Value=A233327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233327.Bytes);
public long this[int i]=>Value[i];

public static A233327Inst Instance=new A233327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233392
{
public static readonly BigInteger[] Value={ 152945L,598953097717325L,BigInteger.Parse("1310337508404654670607225"),BigInteger.Parse("2865540861056875339371758826727925"),BigInteger.Parse("6266570209938394667955255282885089143981505"),BigInteger.Parse("13704185035646603836490299749913940382257827996418525"),BigInteger.Parse("29969294398610683114309782005478125379415264317638704493811785") };
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
public class A233392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233392Inst Instance=new A233392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233393
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,41L,43L,47L,53L,61L,67L,71L,73L,79L,83L,101L,107L,109L,127L,131L,137L,139L,149L,157L,167L,173L,181L,191L,193L,199L,223L,229L,257L,263L,269L,271L,277L,293L,311L,331L,347L,349L,359L,383L,397L,421L,449L,463L,467L,479L,521L,523L,557L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233393Inst : IEnumerable<long>
{
public static readonly long[] Value=A233393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233393.Bytes);
public long this[int i]=>Value[i];

public static A233393Inst Instance=new A233393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233394
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,9L,11L,8L,14L,12L,22L,17L,27L,26L,26L,16L,26L,24L,36L,26L,39L,36L,52L,33L,51L,45L,68L,48L,73L,63L,57L,32L,50L,44L,64L,40L,67L,60L,82L,50L,77L,54L,96L,68L,94L,88L,114L,65L,99L,87L,124L,85L,124L,103L,153L,92L,139L,120L,170L,115L,171L,140L,120L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233394Inst : IEnumerable<long>
{
public static readonly long[] Value=A233394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233394.Bytes);
public long this[int i]=>Value[i];

public static A233394Inst Instance=new A233394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233395
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,10L,46L,236L,1422L,8856L,68868L,592164L,5421384L,54606168L,599176800L,7035165528L,89675702976L,1220188038816L,17545121203296L,266689148404032L,4300256707369056L,73151041156483104L,1307045473317495360L,BigInteger.Parse("24472776142475956800"),BigInteger.Parse("479965450319937538560"),BigInteger.Parse("9829149455867331588480") };
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
public class A233395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233395Inst Instance=new A233395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233396
{
public static readonly long[] Value={ 0L,2L,6L,34L,186L,1134L,7134L,46554L,310962L,2118502L,14657478L,102724802L,727695402L,5202222302L,37483252398L,271925724906L,1984561228386L,14560612258518L,107335786509078L,794597315522514L,5904817403594970L,44031888040118478L,329378395247260542L,2470999656320266746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233396Inst : IEnumerable<long>
{
public static readonly long[] Value=A233396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233396.Bytes);
public long this[int i]=>Value[i];

public static A233396Inst Instance=new A233396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233397
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,3L,12L,64L,376L,2557L,19683L,169350L,1610592L,16777216L,189970982L,2323244584L,30517578125L,428528437130L,6405755132013L,101559956668416L,1702215647540101L,30072865982171749L,558545864083284007L,10880062101736647492UL,BigInteger.Parse("221794805104450672070") };
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
public class A233397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233397Inst Instance=new A233397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233398
{
public static readonly long[] Value={ 0L,1L,4L,0L,13L,209L,0L,1231L,739L,0L,51850L,129587L,0L,657067L,868120L,0L,8400886L,91426058L,0L,859535812L,1483912651L,0L,30374372956L,68688648677L,0L,422259655777L,2129293909882L,0L,11623487749588L,44275834126985L,0L,329933248712302L,971441847750184L,0L,927342285792613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233398Inst : IEnumerable<long>
{
public static readonly long[] Value=A233398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233398.Bytes);
public long this[int i]=>Value[i];

public static A233398Inst Instance=new A233398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233399
{
public static readonly long[] Value={ 0L,0L,-2L,0L,-2L,3L,-7L,3L,-7L,10L,4L,10L,4L,23L,-13L,23L,-13L,42L,10L,42L,10L,71L,41L,71L,41L,108L,0L,108L,0L,151L,47L,151L,47L,204L,106L,204L,106L,265L,173L,265L,173L,194L,246L,194L,246L,115L,163L,115L,163L,26L,260L,26L,260L,127L,363L,127L,363L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233399Inst : IEnumerable<long>
{
public static readonly long[] Value=A233399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233399.Bytes);
public long this[int i]=>Value[i];

public static A233399Inst Instance=new A233399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233400
{
public static readonly long[] Value={ 0L,1L,2L,9L,12L,107L,109L,120L,244L,337L,381L,407L,565L,592L,937L,1209L,1224L,1341L,1717L,2032L,2402L,3280L,4957L,5149L,5265L,5644L,7065L,7240L,8181L,8820L,9712L,10732L,11901L,15059L,18300L,19120L,20436L,22672L,24516L,25139L,28044L,28550L,36145L,38221L,66201L,72335L,77100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233400Inst : IEnumerable<long>
{
public static readonly long[] Value=A233400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233400.Bytes);
public long this[int i]=>Value[i];

public static A233400Inst Instance=new A233400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233401
{
public static readonly long[] Value={ 1L,4L,8L,21L,37L,40L,56L,112L,113L,204L,280L,445L,481L,560L,688L,709L,1933L,1945L,3601L,3805L,3861L,4156L,4333L,4365L,7096L,8408L,8516L,11064L,12688L,13609L,13945L,16501L,17080L,18901L,21464L,23125L,27244L,27364L,28141L,45228L,45549L,58321L,60061L,66245L,70585L,78688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233401Inst : IEnumerable<long>
{
public static readonly long[] Value=A233401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233401.Bytes);
public long this[int i]=>Value[i];

public static A233401Inst Instance=new A233401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233402
{
public static readonly long[] Value={ 9L,11L,22L,24L,41L,42L,66L,65L,97L,93L,134L,126L,177L,164L,226L,207L,281L,255L,342L,308L,409L,366L,482L,429L,561L,497L,646L,570L,737L,648L,834L,731L,937L,819L,1046L,912L,1161L,1010L,1282L,1113L,1409L,1221L,1542L,1334L,1681L,1452L,1826L,1575L,1977L,1703L,2134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233402Inst : IEnumerable<long>
{
public static readonly long[] Value=A233402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233402.Bytes);
public long this[int i]=>Value[i];

public static A233402Inst Instance=new A233402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233403
{
public static readonly long[] Value={ 11L,37L,35L,100L,265L,293L,756L,1937L,2346L,5788L,14533L,18598L,44777L,110861L,147478L,349309L,854388L,1171388L,2739451L,6632534L,9314701L,21564727L,51751900L,74137387L,170211322L,405346970L,590489477L,1346189954L,3184156943L,4705761017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233403Inst : IEnumerable<long>
{
public static readonly long[] Value=A233403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233403.Bytes);
public long this[int i]=>Value[i];

public static A233403Inst Instance=new A233403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233404
{
public static readonly long[] Value={ 22L,35L,211L,360L,1461L,2543L,8732L,15431L,46953L,84143L,236070L,431533L,1139832L,2108530L,5322489L,9995589L,24398272L,46169416L,109661296L,209717615L,488266741L,937818172L,2145733905L,4151538574L,9381737335L,18189661542L,40631596581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233404Inst : IEnumerable<long>
{
public static readonly long[] Value=A233404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233404.Bytes);
public long this[int i]=>Value[i];

public static A233404Inst Instance=new A233404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233405
{
public static readonly long[] Value={ 24L,100L,360L,1907L,6931L,21765L,86233L,274628L,965494L,3146010L,10444724L,33097949L,108522965L,338311791L,1086568168L,3360254074L,10607088651L,32550672493L,101662193862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233405Inst : IEnumerable<long>
{
public static readonly long[] Value=A233405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233405.Bytes);
public long this[int i]=>Value[i];

public static A233405Inst Instance=new A233405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233406
{
public static readonly long[] Value={ 41L,265L,1461L,6931L,57941L,216088L,1661918L,6745563L,44238419L,186635795L,1129245723L,4833595607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233406Inst : IEnumerable<long>
{
public static readonly long[] Value=A233406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233406.Bytes);
public long this[int i]=>Value[i];

public static A233406Inst Instance=new A233406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233407
{
public static readonly long[] Value={ 42L,293L,2543L,21765L,216088L,1283251L,11808072L,70311171L,571963910L,3520539997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233407Inst : IEnumerable<long>
{
public static readonly long[] Value=A233407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233407.Bytes);
public long this[int i]=>Value[i];

public static A233407Inst Instance=new A233407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233440
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,0L,3L,0L,0L,3L,4L,0L,0L,16L,4L,5L,0L,0L,50L,25L,40L,6L,0L,0L,120L,90L,288L,216L,7L,0L,0L,245L,245L,1176L,1764L,1603L,8L,0L,0L,448L,560L,3584L,8064L,14656L,13000L,9L,0L,0L,756L,1134L,9072L,27216L,74196L,131625L,118872L,10L,0L,0L,1200L,2100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233440Inst : IEnumerable<long>
{
public static readonly long[] Value=A233440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233440.Bytes);
public long this[int i]=>Value[i];

public static A233440Inst Instance=new A233440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233441
{
public static readonly long[] Value={ 2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,3L,5L,9L,16L,26L,44L,76L,131L,226L,393L,689L,1213L,2147L,3818L,6818L,12228L,22012L,39768L,72084L,131072L,239027L,437102L,801393L,1472896L,2713342L,5009438L,9267786L,17179869L,31906432L,59362467L,110632938L,206519839L,386111079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233441Inst : IEnumerable<long>
{
public static readonly long[] Value=A233441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233441.Bytes);
public long this[int i]=>Value[i];

public static A233441Inst Instance=new A233441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233442
{
public static readonly long[] Value={ 0L,4L,8L,16L,32L,64L,128L,256L,512L,24L,717L,640L,1601L,2664L,2393L,0L,3334L,5536L,3004L,576L,4166L,9640L,5545L,8704L,7557L,3696L,19034L,6400L,20244L,5824L,29204L,0L,21293L,12176L,13493L,40960L,41146L,25008L,16154L,11776L,55680L,56008L,20642L,79040L,14957L,1016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233442Inst : IEnumerable<long>
{
public static readonly long[] Value=A233442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233442.Bytes);
public long this[int i]=>Value[i];

public static A233442Inst Instance=new A233442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233443
{
public static readonly long[] Value={ 2L,5L,23L,47L,193L,389L,1667L,8807L,9431L,10177L,10597L,10847L,11831L,13411L,17183L,22433L,29201L,33893L,36073L,38321L,40093L,42461L,48991L,50131L,54287L,54851L,57037L,63347L,65183L,67121L,71917L,87803L,88607L,91291L,94847L,104491L,108293L,112163L,116101L,117167L,122033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233443Inst : IEnumerable<long>
{
public static readonly long[] Value=A233443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233443.Bytes);
public long this[int i]=>Value[i];

public static A233443Inst Instance=new A233443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233444
{
public static readonly long[] Value={ 2203L,90863L,185477L,388573L,613607L,912349L,1293899L,1600919L,2146457L,30661333L,35608189L,81190429L,105823093L,122753857L,204341747L,338602837L,368601707L,374788121L,426958673L,498675409L,586371239L,656232799L,665360321L,674509487L,693132527L,1102304669L,1180942709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233444Inst : IEnumerable<long>
{
public static readonly long[] Value=A233444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233444.Bytes);
public long this[int i]=>Value[i];

public static A233444Inst Instance=new A233444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233445
{
public static readonly long[] Value={ 1L,2L,11L,17L,27L,140L,213L,1934L,13871L,38405L,171707L,200938L,389409L,1633357L,5460156L,8405437L,41983357L,68780189L,179376463L,130292951546L,393142151459L,2100234982892L,5942636062287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233445Inst : IEnumerable<long>
{
public static readonly long[] Value=A233445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233445.Bytes);
public long this[int i]=>Value[i];

public static A233445Inst Instance=new A233445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233446
{
public static readonly BigInteger[] Value={ 1L,23L,2637L,705259L,337390073L,252186614847L,271082082053317L,396049017137512403L,BigInteger.Parse("754792662169555947633"),BigInteger.Parse("1818644980834260579498343"),BigInteger.Parse("5405067064522549127719680701"),BigInteger.Parse("19423396040054801221090342470843"),BigInteger.Parse("83016890560608261435356904433668457"),BigInteger.Parse("416213066932582983199004231480676255119"),BigInteger.Parse("2419095491735191624607023665166934072373813") };
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
public class A233446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233446Inst Instance=new A233446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233447
{
public static readonly long[] Value={ 4L,12L,32L,72L,144L,288L,576L,1080L,1920L,3456L,6283L,10996L,18609L,31901L,53169L,86400L,137223L,213458L,337040L,539264L,847415L,1309642L,1992933L,2989400L,4543888L,6815833L,10097530L,15146295L,22980586L,34470879L,51150337L,76725506L,113925752L,167537870L,244126611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233447Inst : IEnumerable<long>
{
public static readonly long[] Value=A233447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233447.Bytes);
public long this[int i]=>Value[i];

public static A233447Inst Instance=new A233447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233448
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,25401600L,174182400L,1437004800L,46942156800L,301771008000L,0L,188305108992000L,5272543051776000L,30128817438720000L,964122158039040000L,BigInteger.Parse("24517325190758400000"),BigInteger.Parse("118315866081853440000"),BigInteger.Parse("16505063318418554880000"),BigInteger.Parse("283958078596448256000000") };
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
public class A233448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233448Inst Instance=new A233448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233449
{
public static readonly BigInteger[] Value={ 1L,3L,8L,22L,68L,256L,1232L,7504L,55328L,473536L,4575872L,49068544L,577138688L,7381298176L,101940887552L,1511556143104L,23945902174208L,403579232444416L,7209532170616832L,136064164750065664L,2705030337676771328L,BigInteger.Parse("56501002847062982656"),BigInteger.Parse("1237002733471733645312") };
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
public class A233449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233449Inst Instance=new A233449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233450
{
public static readonly long[] Value={ 0L,1L,6L,15L,64L,153L,638L,1519L,6320L,15041L,62566L,148895L,619344L,1473913L,6130878L,14590239L,60689440L,144428481L,600763526L,1429694575L,5946945824L,14152517273L,58868694718L,140095478159L,582740001360L,1386802264321L,5768531318886L,13727927165055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233450Inst : IEnumerable<long>
{
public static readonly long[] Value=A233450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233450.Bytes);
public long this[int i]=>Value[i];

public static A233450Inst Instance=new A233450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233451
{
public static readonly long[] Value={ 0L,1L,10L,18L,100L,178L,1000L,10000L,17783L,31623L,100000L,177828L,316228L,1000000L,10000000L,100000000L,1000000000L,5623413252L,10000000000L,100000000000L,177827941004L,316227766017L,1000000000000L,1778279410039L,10000000000000L,31622776601684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233451Inst : IEnumerable<long>
{
public static readonly long[] Value=A233451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233451.Bytes);
public long this[int i]=>Value[i];

public static A233451Inst Instance=new A233451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233452
{
public static readonly long[] Value={ 0L,1L,4L,10L,16L,40L,100L,631L,1000L,1585L,2512L,10000L,15849L,25119L,100000L,1000000L,10000000L,15848932L,100000000L,1000000000L,6309573445L,10000000000L,100000000000L,251188643151L,1000000000000L,3981071705535L,6309573444802L,10000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233452Inst : IEnumerable<long>
{
public static readonly long[] Value=A233452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233452.Bytes);
public long this[int i]=>Value[i];

public static A233452Inst Instance=new A233452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233453
{
public static readonly long[] Value={ 0L,1L,10L,100L,1000L,6813L,10000L,14678L,46416L,100000L,146780L,464159L,1000000L,4641589L,10000000L,21544347L,68129207L,100000000L,1000000000L,10000000000L,100000000000L,316227766017L,681292069058L,1000000000000L,2154434690032L,10000000000000L,21544346900319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233453Inst : IEnumerable<long>
{
public static readonly long[] Value=A233453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233453.Bytes);
public long this[int i]=>Value[i];

public static A233453Inst Instance=new A233453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233454
{
public static readonly long[] Value={ 0L,1L,2L,10L,14L,72L,100L,139L,518L,1000L,10000L,13895L,19307L,26827L,37276L,100000L,1000000L,10000000L,13894955L,26826958L,100000000L,193069773L,517947468L,1000000000L,1930697729L,10000000000L,100000000000L,268269579528L,1000000000000L,3727593720315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233454Inst : IEnumerable<long>
{
public static readonly long[] Value=A233454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233454.Bytes);
public long this[int i]=>Value[i];

public static A233454Inst Instance=new A233454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233455
{
public static readonly long[] Value={ 0L,1L,10L,75L,100L,750L,1000L,4217L,7499L,10000L,100000L,177828L,1000000L,10000000L,74989421L,100000000L,1000000000L,5623413252L,10000000000L,100000000000L,177827941004L,1000000000000L,1778279410039L,10000000000000L,56234132519035L,100000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233455Inst : IEnumerable<long>
{
public static readonly long[] Value=A233455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233455.Bytes);
public long this[int i]=>Value[i];

public static A233455Inst Instance=new A233455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233520
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,5L,4L,5L,5L,6L,4L,10L,7L,8L,9L,11L,5L,12L,9L,12L,10L,15L,9L,14L,12L,14L,12L,19L,11L,21L,19L,18L,16L,19L,12L,28L,18L,18L,18L,30L,13L,33L,20L,22L,23L,36L,18L,28L,20L,23L,27L,39L,17L,35L,24L,32L,30L,43L,20L,46L,33L,26L,37L,37L,22L,49L,34L,34L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233520Inst : IEnumerable<long>
{
public static readonly long[] Value=A233520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233520.Bytes);
public long this[int i]=>Value[i];

public static A233520Inst Instance=new A233520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233521
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,4L,3L,5L,1L,7L,2L,5L,7L,7L,3L,9L,2L,10L,8L,7L,3L,13L,5L,10L,5L,13L,3L,15L,4L,11L,9L,10L,9L,15L,2L,7L,12L,19L,6L,20L,4L,12L,15L,7L,4L,22L,11L,16L,12L,15L,2L,16L,14L,18L,10L,9L,1L,30L,7L,8L,22L,19L,16L,21L,4L,17L,9L,23L,4L,27L,5L,10L,19L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233521Inst : IEnumerable<long>
{
public static readonly long[] Value=A233521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233521.Bytes);
public long this[int i]=>Value[i];

public static A233521Inst Instance=new A233521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233522
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,9L,12L,16L,22L,29L,38L,50L,67L,89L,118L,156L,207L,274L,363L,481L,638L,845L,1119L,1482L,1964L,2602L,3447L,4566L,6049L,8013L,10615L,14062L,18629L,24678L,32691L,43306L,57369L,75998L,100676L,133367L,176674L,234043L,310041L,410717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233522Inst : IEnumerable<long>
{
public static readonly long[] Value=A233522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233522.Bytes);
public long this[int i]=>Value[i];

public static A233522Inst Instance=new A233522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233523
{
public static readonly long[] Value={ 2L,3L,13L,29L,71L,79L,107L,907L,3491L,4967L,7853L,61223L,80051L,81547L,90901L,211811L,381629L,1990007L,3220793L,4749637L,6725027L,6784937L,34463699L,143691323L,185831033L,213609173L,285336497L,442634651L,911588849L,953122843L,1548789581L,2153787017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233523Inst : IEnumerable<long>
{
public static readonly long[] Value=A233523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233523.Bytes);
public long this[int i]=>Value[i];

public static A233523Inst Instance=new A233523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233524
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233524Inst : IEnumerable<long>
{
public static readonly long[] Value=A233524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233524.Bytes);
public long this[int i]=>Value[i];

public static A233524Inst Instance=new A233524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233525
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,4L,11L,1L,32L,49L,47L,100L,41L,259L,110L,667L,323L,1678L,1229L,3805L,7256L,4159L,17609L,19822L,33005L,26461L,72554L,6829L,210833L,342316L,290183L,736765L,133784L,2076511L,1535657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233525Inst : IEnumerable<long>
{
public static readonly long[] Value=A233525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233525.Bytes);
public long this[int i]=>Value[i];

public static A233525Inst Instance=new A233525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233526
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,7L,5L,9L,1L,17L,15L,19L,11L,27L,17L,37L,31L,43L,19L,67L,9L,125L,19L,231L,73L,389L,195L,583L,197L,969L,607L,1331L,1097L,1565L,629L,2501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233526Inst : IEnumerable<long>
{
public static readonly long[] Value=A233526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233526.Bytes);
public long this[int i]=>Value[i];

public static A233526Inst Instance=new A233526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233527
{
public static readonly long[] Value={ 1L,5L,7L,8L,3L,1L,1L,9L,0L,2L,8L,8L,1L,5L,8L,8L,6L,0L,1L,6L,7L,6L,0L,8L,7L,4L,1L,7L,8L,2L,8L,1L,8L,9L,2L,3L,6L,0L,5L,0L,7L,1L,2L,4L,0L,5L,9L,9L,0L,5L,1L,0L,6L,0L,4L,1L,5L,5L,5L,7L,9L,6L,7L,2L,1L,3L,8L,2L,2L,1L,1L,9L,5L,6L,5L,1L,8L,2L,1L,0L,9L,1L,6L,0L,5L,8L,7L,1L,3L,9L,4L,4L,0L,8L,0L,3L,1L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233527Inst : IEnumerable<long>
{
public static readonly long[] Value=A233527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233527.Bytes);
public long this[int i]=>Value[i];

public static A233527Inst Instance=new A233527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233528
{
public static readonly long[] Value={ 1L,4L,1L,2L,9L,6L,5L,1L,3L,6L,5L,0L,6L,7L,3L,7L,7L,5L,9L,0L,6L,3L,7L,1L,2L,9L,4L,9L,8L,5L,6L,9L,3L,2L,5L,1L,8L,4L,9L,3L,5L,1L,3L,4L,5L,9L,0L,8L,8L,5L,0L,1L,8L,5L,0L,0L,7L,1L,9L,1L,4L,3L,2L,8L,9L,4L,0L,0L,8L,6L,0L,8L,3L,5L,7L,7L,9L,2L,2L,3L,9L,0L,1L,5L,3L,4L,3L,0L,2L,7L,3L,2L,3L,0L,2L,5L,5L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233528Inst : IEnumerable<long>
{
public static readonly long[] Value=A233528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233528.Bytes);
public long this[int i]=>Value[i];

public static A233528Inst Instance=new A233528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233529
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,2L,1L,3L,4L,1L,4L,5L,1L,5L,3L,2L,1L,2L,5L,5L,4L,5L,6L,5L,5L,4L,8L,5L,7L,4L,3L,6L,6L,4L,8L,6L,7L,7L,8L,7L,5L,5L,5L,7L,8L,6L,13L,9L,5L,3L,9L,6L,8L,11L,5L,9L,9L,10L,8L,9L,14L,9L,10L,13L,11L,6L,9L,12L,10L,12L,14L,10L,12L,7L,13L,9L,7L,7L,15L,12L,6L,10L,11L,12L,12L,9L,18L,15L,14L,11L,10L,10L,8L,13L,21L,9L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233529Inst : IEnumerable<long>
{
public static readonly long[] Value=A233529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233529.Bytes);
public long this[int i]=>Value[i];

public static A233529Inst Instance=new A233529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233530
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,3L,3L,1L,0L,8L,9L,4L,1L,0L,38L,40L,18L,5L,1L,0L,268L,264L,112L,30L,6L,1L,0L,2578L,2379L,953L,240L,45L,7L,1L,0L,31672L,27568L,10500L,2505L,440L,63L,8L,1L,0L,475120L,392895L,143308L,32686L,5445L,728L,84L,9L,1L,0L,8427696L,6663624L,2342284L,514660L,82176L,10423L,1120L,108L,10L,1L,0L,172607454L,131211423L,44677494L,9514570L,1467837L,178689L,18214L,1632L,135L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233530Inst : IEnumerable<long>
{
public static readonly long[] Value=A233530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233530.Bytes);
public long this[int i]=>Value[i];

public static A233530Inst Instance=new A233530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233531
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,6L,-18L,44L,-56L,-300L,2024L,-22022L,-130456L,-4241064L,-103538532L,-2893308780L,-88314189664L,-2924814872208L,-104538530634844L,-4010605941377292L,-164409679858874856L,-7172735079437282200L,BigInteger.Parse("-331847552362286195156"),BigInteger.Parse("-16229743737669369558956"),BigInteger.Parse("-836695536495554388520400") };
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
public class A233531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233531Inst Instance=new A233531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233532
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,38L,268L,2578L,31672L,475120L,8427696L,172607454L,4008441848L,104061288740L,2985810416824L,93812980749076L,3202899902480872L,118054380417848192L,4671653916923940952L,BigInteger.Parse("197528462484409468792"),BigInteger.Parse("8886812830338447522120"),BigInteger.Parse("423862241146246310158108"),BigInteger.Parse("21362480654281867734050272") };
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
public class A233532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233532Inst Instance=new A233532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233533
{
public static readonly BigInteger[] Value={ 1L,3L,9L,40L,264L,2379L,27568L,392895L,6663624L,131211423L,2943137604L,74087543634L,2068127523264L,63395972293650L,2116776180704988L,76462961271015326L,2970720383283042732L,BigInteger.Parse("123517218432709179030"),BigInteger.Parse("5472063213488927240290"),BigInteger.Parse("257315864404023900340860"),BigInteger.Parse("12799687840583182179921204") };
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
public class A233533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233533Inst Instance=new A233533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233534
{
public static readonly BigInteger[] Value={ 1L,4L,18L,112L,953L,10500L,143308L,2342284L,44677494L,974898636L,23957348188L,654735747960L,19696461781336L,646719936551000L,23011823302544368L,881974963187446672L,BigInteger.Parse("36221318006594087010"),BigInteger.Parse("1586737195260479665112"),BigInteger.Parse("73850241923431162931872"),BigInteger.Parse("3638980616346240786818936") };
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
public class A233534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233534Inst Instance=new A233534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233535
{
public static readonly BigInteger[] Value={ 1L,2L,3L,7L,22L,102L,681L,6203L,72757L,1050276L,18042102L,359677460L,8162936051L,207764278875L,5859801873585L,181362065062507L,6110186925475928L,222566852684792616L,8714776224549448369L,BigInteger.Parse("364990993734909935670"),BigInteger.Parse("16280201717192275756034"),BigInteger.Parse("770443051001734848973196"),BigInteger.Parse("38553687900969746513992234") };
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
public class A233535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A233535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233535Inst Instance=new A233535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233584
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,9L,17L,109L,260L,2909L,3072L,3310L,3678L,6715L,35175L,37269L,439792L,1400459L,1472451L,4643918L,5683171L,44850176L,62252861L,145631385L,154435765L,371056666L,1685980637L,11196453405L,14795372939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233584Inst : IEnumerable<long>
{
public static readonly long[] Value=A233584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233584.Bytes);
public long this[int i]=>Value[i];

public static A233584Inst Instance=new A233584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233585
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,4L,12L,39L,71L,83L,484L,1028L,1447L,9913L,31542L,526880L,685669L,1396494L,1534902L,2295194L,9521643L,9643315L,42421746L,183962859L,553915624L,557976754L,6111180351L,10671513549L,61650520975L,106532505646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233585Inst : IEnumerable<long>
{
public static readonly long[] Value=A233585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233585.Bytes);
public long this[int i]=>Value[i];

public static A233585Inst Instance=new A233585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233586
{
public static readonly long[] Value={ 1L,6L,12L,19L,63L,263L,856L,2632L,7714L,9683L,888970L,1200867L,1691244L,2350415L,3433770L,4482812L,17544235L,48509602L,53801529L,114221223L,124712727L,997393454L,16681741997L,17954856574L,105651203040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233586Inst : IEnumerable<long>
{
public static readonly long[] Value=A233586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233586.Bytes);
public long this[int i]=>Value[i];

public static A233586Inst Instance=new A233586Inst();

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