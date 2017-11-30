using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A261282
{
public static readonly long[] Value={ 14L,60L,135L,41L,199L,2L,2L,2L,61L,2L,183L,25L,15L,12L,47L,143L,110L,294L,117L,88L,22L,402L,26L,269L,116L,145L,164L,6L,10L,488L,2L,44L,120L,4L,127L,144L,119L,704L,1058L,368L,104L,2L,6L,214L,4L,129L,2L,3L,301L,2L,2L,466L,20L,107L,280L,14L,337L,12L,22L,12L,242L,1705L,415L,10L,115L,50L,2L,420L,4L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261282Inst : IEnumerable<long>
{
public static readonly long[] Value=A261282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261282.Bytes);
public long this[int i]=>Value[i];

public static A261282Inst Instance=new A261282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261283
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,2L,1L,0L,4L,5L,6L,7L,7L,6L,5L,4L,5L,4L,7L,6L,6L,7L,4L,5L,1L,0L,3L,2L,2L,3L,0L,1L,6L,7L,4L,5L,5L,4L,7L,6L,2L,3L,0L,1L,1L,0L,3L,2L,3L,2L,1L,0L,0L,1L,2L,3L,7L,6L,5L,4L,4L,5L,6L,7L,7L,6L,5L,4L,4L,5L,6L,7L,3L,2L,1L,0L,0L,1L,2L,3L,2L,3L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261283Inst : IEnumerable<long>
{
public static readonly long[] Value=A261283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261283.Bytes);
public long this[int i]=>Value[i];

public static A261283Inst Instance=new A261283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261284
{
public static readonly BigInteger[] Value={ 36L,77L,271L,1147L,6996L,51268L,561724L,6295926L,107865659L,2065840014L,57883274521L,1752577624054L,80161163488540L,3993898268151118L,295206710031036849L,BigInteger.Parse("23800415351857927140"),BigInteger.Parse("2870471520849798820514") };
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
public class A261284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261284Inst Instance=new A261284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261285
{
public static readonly long[] Value={ 36L,50L,96L,166L,307L,540L,1015L,1786L,3304L,5862L,10877L,19316L,35609L,63526L,116992L,209094L,383787L,687684L,1260543L,2262114L,4138240L,7439142L,13591813L,24462924L,44638225L,80433102L,146628424L,264446262L,481653251L,869371260L,1582318631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261285Inst : IEnumerable<long>
{
public static readonly long[] Value=A261285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261285.Bytes);
public long this[int i]=>Value[i];

public static A261285Inst Instance=new A261285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261286
{
public static readonly long[] Value={ 50L,77L,133L,233L,409L,743L,1361L,2469L,4485L,8183L,14901L,27091L,49293L,89729L,163277L,297055L,540549L,983737L,1790089L,3257319L,5927571L,10786801L,19628869L,35719195L,65000021L,118283183L,215243755L,391687275L,712769639L,1297054417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261286Inst : IEnumerable<long>
{
public static readonly long[] Value=A261286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261286.Bytes);
public long this[int i]=>Value[i];

public static A261286Inst Instance=new A261286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261287
{
public static readonly long[] Value={ 96L,133L,271L,504L,1086L,2104L,4715L,9080L,20093L,38864L,86229L,166296L,368773L,712284L,1579561L,3049076L,6762309L,13056148L,28953755L,55898492L,123967937L,239336000L,530772749L,1024728804L,2272547259L,4387441960L,9730031919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261287Inst : IEnumerable<long>
{
public static readonly long[] Value=A261287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261287.Bytes);
public long this[int i]=>Value[i];

public static A261287Inst Instance=new A261287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261288
{
public static readonly long[] Value={ 166L,233L,504L,1147L,2586L,6034L,14106L,32496L,75202L,175008L,405940L,940390L,2182098L,5064284L,11745648L,27244774L,63209588L,146635614L,340152614L,789099398L,1830590414L,4246594798L,9851282946L,22853254768L,53015328992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261288Inst : IEnumerable<long>
{
public static readonly long[] Value=A261288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261288.Bytes);
public long this[int i]=>Value[i];

public static A261288Inst Instance=new A261288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261289
{
public static readonly long[] Value={ 307L,409L,1086L,2586L,6996L,17094L,48435L,115722L,323733L,784568L,2200256L,5297320L,14860295L,35870866L,100565666L,242543592L,680254258L,1640988402L,4601509246L,11100042154L,31128297887L,75088246466L,210566880369L,507941745824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261289Inst : IEnumerable<long>
{
public static readonly long[] Value=A261289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261289.Bytes);
public long this[int i]=>Value[i];

public static A261289Inst Instance=new A261289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261290
{
public static readonly long[] Value={ 540L,743L,2104L,6034L,17094L,51268L,153144L,446786L,1313726L,3893926L,11482268L,33790756L,99697166L,294209526L,867275046L,2557044420L,7542082102L,22241722888L,65583553668L,193403914160L,570355004810L,1681918109826L,4959816097134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261290Inst : IEnumerable<long>
{
public static readonly long[] Value=A261290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261290.Bytes);
public long this[int i]=>Value[i];

public static A261290Inst Instance=new A261290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261291
{
public static readonly long[] Value={ 1015L,1361L,4715L,14106L,48435L,153144L,561724L,1703644L,6132232L,19020918L,68690527L,210960310L,762494362L,2350497978L,8485691418L,26128594224L,94398007523L,290731525710L,1049987329395L,3233854822566L,11680868423504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261291Inst : IEnumerable<long>
{
public static readonly long[] Value=A261291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261291.Bytes);
public long this[int i]=>Value[i];

public static A261291Inst Instance=new A261291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261292
{
public static readonly long[] Value={ 36L,50L,50L,96L,77L,96L,166L,133L,133L,166L,307L,233L,271L,233L,307L,540L,409L,504L,504L,409L,540L,1015L,743L,1086L,1147L,1086L,743L,1015L,1786L,1361L,2104L,2586L,2586L,2104L,1361L,1786L,3304L,2469L,4715L,6034L,6996L,6034L,4715L,2469L,3304L,5862L,4485L,9080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261292Inst : IEnumerable<long>
{
public static readonly long[] Value=A261292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261292.Bytes);
public long this[int i]=>Value[i];

public static A261292Inst Instance=new A261292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261293
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,15L,20L,25L,21L,30L,31L,35L,41L,40L,12L,45L,51L,50L,13L,115L,61L,60L,14L,81L,71L,32L,165L,92L,43L,103L,16L,54L,91L,114L,17L,65L,101L,125L,18L,76L,111L,126L,19L,121L,22L,26L,70L,131L,87L,36L,141L,46L,42L,151L,52L,56L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261293Inst : IEnumerable<long>
{
public static readonly long[] Value=A261293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261293.Bytes);
public long this[int i]=>Value[i];

public static A261293Inst Instance=new A261293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261294
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,21L,25L,29L,12L,37L,41L,45L,49L,13L,15L,51L,65L,69L,14L,52L,81L,85L,89L,16L,17L,32L,91L,109L,18L,56L,92L,125L,129L,20L,19L,59L,35L,131L,22L,58L,96L,132L,169L,24L,23L,61L,72L,38L,171L,62L,100L,136L,172L,28L,27L,63L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261294Inst : IEnumerable<long>
{
public static readonly long[] Value=A261294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261294.Bytes);
public long this[int i]=>Value[i];

public static A261294Inst Instance=new A261294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261295
{
public static readonly long[] Value={ 3L,3L,6L,578L,18L,3L,6L,90L,1868L,374L,4L,674L,278L,3L,6L,114L,3534L,110L,6L,354L,4L,14L,28464L,2790L,84L,4452L,2802L,3L,6L,3L,90L,2820L,354L,110L,4080L,278L,44L,3L,2712L,18L,3012L,90L,14L,12672L,44L,14L,1572L,1124L,720L,42L,114L,44L,84L,2790L,42L,90L,42L,3L,6L,84L,44L,1572L,3068L,1742L,2394L,174L,110L,744L,3020L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261295Inst : IEnumerable<long>
{
public static readonly long[] Value=A261295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261295.Bytes);
public long this[int i]=>Value[i];

public static A261295Inst Instance=new A261295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261296
{
public static readonly long[] Value={ 6L,384L,4374L,5687L,24576L,17576L,27783L,64350L,93750L,354375L,279936L,113750L,363968L,166972L,370656L,705894L,263736L,1572864L,1124864L,1778112L,3187744L,4225760L,4118400L,3795000L,3188646L,4145823L,4697550L,1111158L,730575L,6000000L,8171316L,2413071L,8573750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261296Inst : IEnumerable<long>
{
public static readonly long[] Value=A261296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261296.Bytes);
public long this[int i]=>Value[i];

public static A261296Inst Instance=new A261296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261297
{
public static readonly long[] Value={ 2L,1L,4L,4L,6L,8L,2L,3L,5L,7L,4L,6L,8L,9L,10L,3L,5L,7L,11L,13L,17L,4L,6L,8L,9L,10L,12L,14L,3L,5L,7L,11L,13L,17L,19L,23L,5L,7L,11L,13L,17L,19L,23L,29L,31L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261297Inst : IEnumerable<long>
{
public static readonly long[] Value=A261297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261297.Bytes);
public long this[int i]=>Value[i];

public static A261297Inst Instance=new A261297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261298
{
public static readonly long[] Value={ 2L,4L,8L,7L,10L,17L,14L,23L,31L,37L,21L,47L,24L,59L,67L,71L,28L,79L,33L,89L,97L,103L,38L,109L,127L,131L,137L,139L,48L,157L,50L,167L,173L,181L,191L,193L,58L,199L,223L,227L,65L,233L,68L,241L,251L,257L,74L,269L,277L,281L,293L,307L,82L,313L,317L,331L,337L,347L,90L,359L,93L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261298Inst : IEnumerable<long>
{
public static readonly long[] Value=A261298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261298.Bytes);
public long this[int i]=>Value[i];

public static A261298Inst Instance=new A261298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261299
{
public static readonly ulong[] Value={ 1L,11L,110L,1101L,11011L,110111L,1101110L,11011100L,110111001L,1101110011L,11011100110L,110111001100L,1101110011000L,11011100110001L,110111001100010L,1101110011000101L,11011100110001011L,110111001100010110L,1101110011000101100L,11011100110001011001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261299Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A261299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261299.Bytes);
public ulong this[int i]=>Value[i];

public static A261299Inst Instance=new A261299Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261300
{
public static readonly long[] Value={ 0L,1L,2L,11L,3L,21L,12L,111L,4L,31L,22L,211L,13L,121L,112L,1111L,5L,41L,32L,311L,23L,221L,212L,2111L,14L,131L,122L,1211L,113L,1121L,1112L,11111L,6L,51L,42L,411L,33L,321L,312L,3111L,24L,231L,222L,2211L,213L,2121L,2112L,21111L,15L,141L,132L,1311L,123L,1221L,1212L,12111L,114L,1131L,1122L,11211L,1113L,11121L,11112L,111111L,7L,61L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261300Inst : IEnumerable<long>
{
public static readonly long[] Value=A261300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261300.Bytes);
public long this[int i]=>Value[i];

public static A261300Inst Instance=new A261300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261301
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,5L,4L,3L,2L,1L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,47L,46L,45L,40L,39L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,79L,78L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261301Inst : IEnumerable<long>
{
public static readonly long[] Value=A261301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261301.Bytes);
public long this[int i]=>Value[i];

public static A261301Inst Instance=new A261301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261302
{
public static readonly long[] Value={ 1L,0L,5L,4L,3L,2L,1L,0L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,53L,52L,51L,50L,49L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,149L,148L,147L,146L,145L,144L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261302Inst : IEnumerable<long>
{
public static readonly long[] Value=A261302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261302.Bytes);
public long this[int i]=>Value[i];

public static A261302Inst Instance=new A261302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261303
{
public static readonly long[] Value={ 1L,0L,8L,7L,0L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,71L,70L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261303Inst : IEnumerable<long>
{
public static readonly long[] Value=A261303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261303.Bytes);
public long this[int i]=>Value[i];

public static A261303Inst Instance=new A261303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261304
{
public static readonly long[] Value={ 1L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,59L,58L,57L,56L,55L,54L,53L,52L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,251L,250L,249L,248L,247L,246L,245L,244L,243L,242L,241L,240L,239L,238L,237L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261304Inst : IEnumerable<long>
{
public static readonly long[] Value=A261304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261304.Bytes);
public long this[int i]=>Value[i];

public static A261304Inst Instance=new A261304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261305
{
public static readonly long[] Value={ 1L,0L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,89L,88L,77L,76L,75L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261305Inst : IEnumerable<long>
{
public static readonly long[] Value=A261305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261305.Bytes);
public long this[int i]=>Value[i];

public static A261305Inst Instance=new A261305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261306
{
public static readonly long[] Value={ 1L,0L,17L,16L,15L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,101L,100L,99L,98L,97L,96L,95L,94L,93L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,461L,460L,459L,458L,457L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261306Inst : IEnumerable<long>
{
public static readonly long[] Value=A261306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261306.Bytes);
public long this[int i]=>Value[i];

public static A261306Inst Instance=new A261306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261307
{
public static readonly long[] Value={ 1L,0L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,167L,166L,165L,164L,163L,162L,161L,160L,159L,158L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261307Inst : IEnumerable<long>
{
public static readonly long[] Value=A261307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261307.Bytes);
public long this[int i]=>Value[i];

public static A261307Inst Instance=new A261307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261308
{
public static readonly long[] Value={ 1L,0L,23L,22L,21L,20L,15L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,167L,166L,165L,164L,163L,162L,161L,160L,159L,158L,157L,156L,155L,154L,153L,152L,151L,150L,149L,148L,147L,146L,145L,144L,143L,142L,141L,140L,139L,138L,137L,136L,135L,134L,133L,132L,131L,130L,129L,128L,127L,126L,125L,124L,123L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261308Inst : IEnumerable<long>
{
public static readonly long[] Value=A261308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261308.Bytes);
public long this[int i]=>Value[i];

public static A261308Inst Instance=new A261308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261309
{
public static readonly long[] Value={ 1L,0L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,269L,268L,267L,266L,265L,264L,263L,262L,261L,260L,259L,258L,257L,256L,255L,254L,253L,252L,251L,250L,249L,248L,247L,246L,245L,244L,243L,242L,241L,240L,239L,238L,237L,236L,235L,234L,233L,232L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261309Inst : IEnumerable<long>
{
public static readonly long[] Value=A261309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261309.Bytes);
public long this[int i]=>Value[i];

public static A261309Inst Instance=new A261309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261310
{
public static readonly long[] Value={ 1L,0L,29L,28L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,269L,268L,267L,266L,265L,264L,263L,262L,261L,260L,259L,258L,257L,256L,255L,254L,253L,252L,251L,250L,249L,248L,247L,246L,245L,244L,243L,242L,241L,240L,239L,238L,237L,236L,235L,234L,233L,232L,231L,230L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261310Inst : IEnumerable<long>
{
public static readonly long[] Value=A261310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261310.Bytes);
public long this[int i]=>Value[i];

public static A261310Inst Instance=new A261310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261311
{
public static readonly long[] Value={ 19L,23L,31L,43L,59L,79L,103L,163L,179L,199L,227L,239L,251L,283L,331L,347L,383L,431L,439L,463L,467L,479L,487L,499L,523L,547L,587L,607L,631L,647L,683L,727L,827L,883L,907L,911L,919L,967L,991L,1019L,1031L,1051L,1087L,1123L,1171L,1303L,1327L,1423L,1499L,1511L,1523L,1531L,1567L,1571L,1667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261311Inst : IEnumerable<long>
{
public static readonly long[] Value=A261311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261311.Bytes);
public long this[int i]=>Value[i];

public static A261311Inst Instance=new A261311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261312
{
public static readonly long[] Value={ 1L,2L,19L,31L,37L,38L,41L,53L,59L,61L,62L,67L,71L,73L,74L,79L,82L,89L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,134L,139L,142L,146L,149L,151L,157L,158L,163L,167L,173L,178L,179L,181L,191L,193L,194L,197L,199L,202L,206L,211L,214L,218L,223L,226L,227L,229L,233L,239L,241L,251L,254L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261312Inst : IEnumerable<long>
{
public static readonly long[] Value=A261312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261312.Bytes);
public long this[int i]=>Value[i];

public static A261312Inst Instance=new A261312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261313
{
public static readonly long[] Value={ 9L,0L,2L,6L,1L,1L,6L,5L,6L,9L,0L,6L,2L,4L,4L,2L,7L,1L,7L,9L,2L,8L,0L,2L,6L,8L,4L,5L,6L,0L,8L,0L,0L,2L,4L,7L,0L,2L,0L,4L,0L,8L,2L,7L,6L,6L,5L,9L,9L,1L,6L,6L,0L,7L,9L,5L,1L,8L,2L,5L,8L,6L,7L,3L,9L,6L,6L,6L,2L,1L,5L,2L,5L,0L,4L,4L,3L,3L,8L,5L,2L,7L,6L,6L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261313Inst : IEnumerable<long>
{
public static readonly long[] Value=A261313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261313.Bytes);
public long this[int i]=>Value[i];

public static A261313Inst Instance=new A261313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261314
{
public static readonly long[] Value={ 34L,59L,44L,79L,56L,107L,75L,54L,103L,72L,151L,102L,233L,153L,104L,239L,156L,397L,253L,165L,112L,263L,171L,116L,271L,176L,457L,290L,829L,512L,1619L,974L,3469L,2044L,8123L,4696L,20879L,11861L,6807L,3952L,17159L,9786L,47459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261314Inst : IEnumerable<long>
{
public static readonly long[] Value=A261314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261314.Bytes);
public long this[int i]=>Value[i];

public static A261314Inst Instance=new A261314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261315
{
public static readonly BigInteger[] Value={ 9L,90L,657L,4788L,27225L,146619L,544329L,2112084L,3447369L,28995255L,9L,1488185631L,9L,73556822205L,38222232057L,3321970172244L,9L,138479121435807L,9L,2209806802214163L,19711054740199689L,28570005L,9L,15574715941421647071UL,141378216540777225L,421224309L,BigInteger.Parse("9724427617362202602009") };
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
public class A261315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261315Inst Instance=new A261315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261316
{
public static readonly long[] Value={ 68L,88L,91L,118L,131L,151L,157L,194L,203L,424L,602L,772L,832L,884L,947L,1309L,1463L,2246L,3304L,4043L,5725L,6683L,9344L,10969L,11026L,11735L,13664L,14857L,18529L,21676L,28217L,28793L,29605L,33206L,41182L,43777L,49936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261316Inst : IEnumerable<long>
{
public static readonly long[] Value=A261316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261316.Bytes);
public long this[int i]=>Value[i];

public static A261316Inst Instance=new A261316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261317
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,3L,20L,175L,210L,4585L,24920L,101745L,1266650L,13562395L,48588540L,1082015935L,9135376250L,63098660625L,1069777108400L,13628391601825L,88520971388850L,2134604966569075L,23945393042070500L,236084869688242575L,4893567386193135650L,BigInteger.Parse("72576130763294383225") };
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
public class A261317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261317Inst Instance=new A261317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261318
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,0L,0L,3L,1L,0L,1L,10L,8L,1L,0L,0L,30L,50L,15L,1L,0L,1L,91L,280L,155L,24L,1L,0L,0L,273L,1491L,1365L,371L,35L,1L,0L,1L,820L,7728L,11046L,4704L,756L,48L,1L,0L,0L,2460L,39460L,85050L,53382L,13020L,1380L,63L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261318Inst : IEnumerable<long>
{
public static readonly long[] Value=A261318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261318.Bytes);
public long this[int i]=>Value[i];

public static A261318Inst Instance=new A261318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261319
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,0L,0L,3L,4L,0L,1L,11L,19L,20L,0L,0L,30L,80L,95L,96L,0L,1L,92L,372L,527L,551L,552L,0L,0L,273L,1764L,3129L,3500L,3535L,3536L,0L,1L,821L,8549L,19595L,24299L,25055L,25103L,25104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261319Inst : IEnumerable<long>
{
public static readonly long[] Value=A261319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261319.Bytes);
public long this[int i]=>Value[i];

public static A261319Inst Instance=new A261319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261320
{
public static readonly long[] Value={ 1L,-4L,12L,-28L,60L,-120L,228L,-416L,732L,-1252L,2088L,-3408L,5460L,-8600L,13344L,-20424L,30876L,-46152L,68268L,-100016L,145224L,-209120L,298800L,-423840L,597108L,-835804L,1162824L,-1608508L,2212896L,-3028632L,4124664L,-5590976L,7544604L,-10137264L,13565016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261320Inst : IEnumerable<long>
{
public static readonly long[] Value=A261320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261320.Bytes);
public long this[int i]=>Value[i];

public static A261320Inst Instance=new A261320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261321
{
public static readonly long[] Value={ 1L,4L,4L,-4L,-12L,-8L,12L,32L,20L,-28L,-72L,-48L,60L,152L,96L,-120L,-300L,-184L,228L,560L,344L,-416L,-1008L,-608L,732L,1756L,1048L,-1252L,-2976L,-1768L,2088L,4928L,2900L,-3408L,-7992L,-4672L,5460L,12728L,7408L,-8600L,-19944L,-11544L,13344L,30800L,17744L,-20424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261321Inst : IEnumerable<long>
{
public static readonly long[] Value=A261321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261321.Bytes);
public long this[int i]=>Value[i];

public static A261321Inst Instance=new A261321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261322
{
public static readonly long[] Value={ 21L,31L,41L,51L,61L,71L,81L,91L,421L,931L,3311L,5111L,5511L,7711L,8421L,9731L,9911L,311111L,444111L,711111L,777111L,993311L,8811111L,51111111L,55551111L,91111111L,93333311L,99311111L,99991111L,441111111L,6666611111L,7111111111L,9333311111L,411111111111L,555111111111L,771111111111L,777777111111L,911111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261322Inst : IEnumerable<long>
{
public static readonly long[] Value=A261322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261322.Bytes);
public long this[int i]=>Value[i];

public static A261322Inst Instance=new A261322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261323
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,5L,4L,3L,3L,5L,5L,5L,5L,4L,6L,6L,6L,10L,10L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261323Inst : IEnumerable<long>
{
public static readonly long[] Value=A261323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261323.Bytes);
public long this[int i]=>Value[i];

public static A261323Inst Instance=new A261323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261324
{
public static readonly long[] Value={ 2L,3L,5L,3L,5L,7L,11L,11L,7L,5L,5L,11L,11L,11L,11L,7L,13L,13L,13L,29L,29L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261324Inst : IEnumerable<long>
{
public static readonly long[] Value=A261324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261324.Bytes);
public long this[int i]=>Value[i];

public static A261324Inst Instance=new A261324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261325
{
public static readonly long[] Value={ 1L,-3L,8L,-18L,38L,-75L,140L,-252L,439L,-744L,1232L,-1998L,3182L,-4986L,7700L,-11736L,17673L,-26322L,38808L,-56682L,82070L,-117867L,167996L,-237744L,334202L,-466836L,648224L,-895014L,1229148L,-1679436L,2283568L,-3090672L,4164578L,-5587941L,7467464L,-9940482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261325Inst : IEnumerable<long>
{
public static readonly long[] Value=A261325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261325.Bytes);
public long this[int i]=>Value[i];

public static A261325Inst Instance=new A261325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261326
{
public static readonly long[] Value={ 1L,1L,-2L,-4L,-3L,4L,12L,8L,-10L,-28L,-18L,24L,60L,38L,-48L,-120L,-75L,92L,228L,140L,-172L,-416L,-252L,304L,732L,439L,-524L,-1252L,-744L,884L,2088L,1232L,-1450L,-3408L,-1998L,2336L,5460L,3182L,-3704L,-8600L,-4986L,5772L,13344L,7700L,-8872L,-20424L,-11736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261326Inst : IEnumerable<long>
{
public static readonly long[] Value=A261326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261326.Bytes);
public long this[int i]=>Value[i];

public static A261326Inst Instance=new A261326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261327
{
public static readonly long[] Value={ 1L,5L,2L,13L,5L,29L,10L,53L,17L,85L,26L,125L,37L,173L,50L,229L,65L,293L,82L,365L,101L,445L,122L,533L,145L,629L,170L,733L,197L,845L,226L,965L,257L,1093L,290L,1229L,325L,1373L,362L,1525L,401L,1685L,442L,1853L,485L,2029L,530L,2213L,577L,2405L,626L,2605L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261327Inst : IEnumerable<long>
{
public static readonly long[] Value=A261327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261327.Bytes);
public long this[int i]=>Value[i];

public static A261327Inst Instance=new A261327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261328
{
public static readonly long[] Value={ 10L,640L,7290L,8954L,40960L,52728L,55566L,70434L,156250L,405000L,466560L,536250L,573056L,960089L,997920L,1176490L,2037960L,2621440L,3374592L,3556224L,3748745L,4379424L,4507776L,5005000L,5314410L,6527466L,6742450L,7778106L,8938800L,10000000L,10214145L,12065355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261328Inst : IEnumerable<long>
{
public static readonly long[] Value=A261328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261328.Bytes);
public long this[int i]=>Value[i];

public static A261328Inst Instance=new A261328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261329
{
public static readonly long[] Value={ 1L,1L,3L,8L,23L,62L,175L,477L,1319L,3602L,9851L,26779L,72726L,196724L,531157L,1430144L,3842911L,10303055L,27570786L,73637306L,196333303L,522584286L,1388786089L,3685169795L,9764703347L,25838430572L,68282175170L,180221449469L,475102410065L,1251038486529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261329Inst : IEnumerable<long>
{
public static readonly long[] Value=A261329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261329.Bytes);
public long this[int i]=>Value[i];

public static A261329Inst Instance=new A261329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261330
{
public static readonly long[] Value={ 1L,2L,9L,30L,106L,348L,1153L,3698L,11798L,37034L,115294L,355202L,1086080L,3294912L,9931019L,29745296L,88597104L,262508288L,774073787L,2272321666L,6642701371L,19342768210L,56117550874L,162247236638L,467563212923L,1343273262184L,3847866714452L,10991864363660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261330Inst : IEnumerable<long>
{
public static readonly long[] Value=A261330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261330.Bytes);
public long this[int i]=>Value[i];

public static A261330Inst Instance=new A261330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261331
{
public static readonly long[] Value={ 1L,1L,2L,7L,18L,52L,143L,396L,1083L,2971L,8087L,21981L,59533L,160857L,433467L,1165542L,3126951L,8372451L,22374172L,59684669L,158941356L,422582925L,1121814072L,2973703449L,7871754065L,20809918535L,54943916547L,144891525408L,381647503607L,1004149670985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261331Inst : IEnumerable<long>
{
public static readonly long[] Value=A261331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261331.Bytes);
public long this[int i]=>Value[i];

public static A261331Inst Instance=new A261331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261332
{
public static readonly long[] Value={ 1L,2L,7L,26L,83L,278L,894L,2848L,8947L,27844L,85774L,262090L,794802L,2393874L,7165622L,21327412L,63146545L,186063052L,545783103L,1594268778L,4638773567L,13447773510L,38850645513L,111874844146L,321166890522L,919314145044L,2624198013317L,7471158542418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261332Inst : IEnumerable<long>
{
public static readonly long[] Value=A261332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261332.Bytes);
public long this[int i]=>Value[i];

public static A261332Inst Instance=new A261332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261333
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,0L,21L,31L,41L,12L,51L,13L,61L,14L,71L,15L,81L,16L,91L,17L,101L,18L,111L,19L,22L,10L,32L,121L,42L,52L,62L,23L,72L,24L,82L,25L,92L,26L,102L,27L,112L,28L,122L,29L,33L,20L,43L,131L,53L,132L,63L,73L,83L,34L,93L,35L,103L,36L,113L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261333Inst : IEnumerable<long>
{
public static readonly long[] Value=A261333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261333.Bytes);
public long this[int i]=>Value[i];

public static A261333Inst Instance=new A261333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261334
{
public static readonly long[] Value={ 10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,30L,9L,14L,16L,18L,20L,22L,24L,26L,28L,50L,11L,29L,36L,38L,40L,42L,44L,46L,48L,70L,12L,31L,49L,58L,60L,62L,64L,66L,68L,90L,13L,33L,51L,69L,80L,82L,84L,86L,88L,110L,15L,34L,53L,71L,89L,102L,104L,106L,108L,130L,17L,35L,55L,73L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261334Inst : IEnumerable<long>
{
public static readonly long[] Value=A261334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261334.Bytes);
public long this[int i]=>Value[i];

public static A261334Inst Instance=new A261334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261335
{
public static readonly long[] Value={ 53L,334L,522L,1194L,2869L,3036L,20825L,29757L,38649L,42376L,206634L,779484L,2501844L,3179745L,6144896L,7489482L,71814716L,74518733L,114518733L,427670705L,821804556L,826199354L,851684546L,1276199354L,4825184535L,9444444445L,9592618243L,14592618243L,592213913815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261335Inst : IEnumerable<long>
{
public static readonly long[] Value=A261335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261335.Bytes);
public long this[int i]=>Value[i];

public static A261335Inst Instance=new A261335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261336
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,10L,30L,88L,255L,742L,2157L,6312L,18563L,54932L,163479L,489264L,1471692L,4447896L,13500689L,41140608L,125818217L,386050543L,1188093392L,3666547089L,11344058829L,35180323336L,109339097119L,340508394528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261336Inst : IEnumerable<long>
{
public static readonly long[] Value=A261336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261336.Bytes);
public long this[int i]=>Value[i];

public static A261336Inst Instance=new A261336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261337
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,2L,1L,3L,3L,4L,2L,3L,2L,4L,1L,5L,3L,2L,3L,5L,4L,6L,2L,3L,3L,3L,2L,7L,4L,4L,1L,4L,5L,4L,3L,3L,2L,5L,3L,5L,5L,4L,4L,6L,6L,6L,2L,5L,3L,4L,3L,7L,3L,2L,2L,5L,7L,8L,4L,5L,4L,6L,1L,5L,4L,6L,5L,7L,4L,6L,3L,3L,3L,5L,2L,7L,5L,3L,3L,6L,5L,8L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261337Inst : IEnumerable<long>
{
public static readonly long[] Value=A261337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261337.Bytes);
public long this[int i]=>Value[i];

public static A261337Inst Instance=new A261337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261338
{
public static readonly long[] Value={ 7L,19L,29L,37L,47L,59L,67L,79L,89L,97L,109L,127L,149L,157L,167L,179L,199L,229L,239L,257L,269L,277L,293L,307L,317L,349L,359L,367L,379L,389L,397L,419L,439L,449L,457L,479L,487L,499L,509L,557L,569L,587L,599L,607L,619L,647L,659L,677L,683L,691L,719L,727L,739L,743L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261338Inst : IEnumerable<long>
{
public static readonly long[] Value=A261338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261338.Bytes);
public long this[int i]=>Value[i];

public static A261338Inst Instance=new A261338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261339
{
public static readonly long[] Value={ 1L,1L,47500L,20440L,2L,124560L,17850L,2730L,185550L,1L,518910L,429180L,10L,687480L,81030L,36L,1568340L,2L,1165750L,7410L,10L,6780L,481140L,10L,10L,5430L,240L,2730L,72660L,2080L,18700L,291720L,295080L,52860L,5430L,1L,81030L,56400L,12490L,43590L,124560L,40030L,5170L,278700L,2091850L,131320L,184110L,11206510L,12910L,1245780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261339Inst : IEnumerable<long>
{
public static readonly long[] Value=A261339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261339.Bytes);
public long this[int i]=>Value[i];

public static A261339Inst Instance=new A261339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261340
{
public static readonly long[] Value={ 3L,5L,5L,1L,8L,1L,7L,4L,2L,3L,1L,4L,3L,7L,7L,3L,9L,2L,8L,8L,2L,2L,4L,4L,4L,7L,3L,6L,4L,7L,6L,3L,2L,6L,3L,6L,7L,0L,8L,7L,4L,6L,9L,5L,4L,1L,7L,5L,3L,2L,2L,1L,3L,4L,2L,3L,8L,1L,2L,9L,4L,9L,9L,7L,1L,2L,8L,0L,0L,1L,8L,0L,5L,7L,5L,5L,5L,7L,8L,2L,8L,8L,6L,7L,9L,8L,1L,3L,8L,1L,0L,8L,2L,4L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261340Inst : IEnumerable<long>
{
public static readonly long[] Value=A261340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261340.Bytes);
public long this[int i]=>Value[i];

public static A261340Inst Instance=new A261340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261341
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,30L,36L,42L,72L,240L,420L,600L,900L,1560L,1764L,3600L,6084L,8100L,46440L,1742400L,4062240L,35814240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261341Inst : IEnumerable<long>
{
public static readonly long[] Value=A261341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261341.Bytes);
public long this[int i]=>Value[i];

public static A261341Inst Instance=new A261341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261342
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,15L,16L,20L,24L,30L,36L,42L,48L,56L,63L,64L,72L,80L,90L,100L,120L,132L,144L,156L,168L,195L,210L,224L,240L,288L,324L,360L,400L,420L,440L,528L,552L,576L,600L,624L,675L,702L,756L,840L,870L,900L,930L,960L,1056L,1155L,1260L,1332L,1368L,1560L,1680L,1764L,1848L,1980L,2352L,2600L,2704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261342Inst : IEnumerable<long>
{
public static readonly long[] Value=A261342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261342.Bytes);
public long this[int i]=>Value[i];

public static A261342Inst Instance=new A261342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261343
{
public static readonly long[] Value={ 0L,1L,50L,147L,292L,485L,726L,1015L,1352L,1737L,2170L,2651L,3180L,3757L,4382L,5055L,5776L,6545L,7362L,8227L,9140L,10101L,11110L,12167L,13272L,14425L,15626L,16875L,18172L,19517L,20910L,22351L,23840L,25377L,26962L,28595L,30276L,32005L,33782L,35607L,37480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261343Inst : IEnumerable<long>
{
public static readonly long[] Value=A261343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261343.Bytes);
public long this[int i]=>Value[i];

public static A261343Inst Instance=new A261343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261344
{
public static readonly long[] Value={ 16L,17L,20L,25L,26L,35L,37L,47L,88L,94L,125L,127L,134L,326L,328L,368L,398L,425L,698L,700L,734L,1303L,1427L,2011L,2542L,2699L,3938L,4214L,5137L,6314L,8669L,9041L,12494L,13520L,14609L,23732L,41399L,43867L,49471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261344Inst : IEnumerable<long>
{
public static readonly long[] Value=A261344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261344.Bytes);
public long this[int i]=>Value[i];

public static A261344Inst Instance=new A261344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261345
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,5L,5L,6L,7L,8L,9L,9L,10L,11L,12L,12L,12L,13L,14L,14L,15L,16L,17L,18L,19L,20L,21L,22L,22L,22L,22L,23L,24L,25L,26L,27L,27L,28L,29L,29L,30L,30L,31L,32L,32L,32L,33L,34L,34L,35L,36L,37L,38L,38L,39L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261345Inst : IEnumerable<long>
{
public static readonly long[] Value=A261345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261345.Bytes);
public long this[int i]=>Value[i];

public static A261345Inst Instance=new A261345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261346
{
public static readonly long[] Value={ 5L,5L,4L,8L,2L,0L,3L,9L,1L,8L,8L,7L,8L,4L,4L,5L,2L,7L,7L,6L,4L,4L,2L,9L,9L,7L,1L,8L,2L,1L,6L,9L,8L,8L,4L,9L,8L,9L,5L,0L,1L,4L,1L,1L,7L,0L,6L,4L,9L,4L,6L,9L,9L,7L,5L,2L,3L,7L,3L,2L,3L,3L,8L,4L,0L,7L,7L,0L,2L,5L,5L,2L,3L,4L,8L,6L,1L,5L,2L,8L,6L,1L,4L,0L,7L,4L,4L,9L,4L,7L,0L,0L,1L,6L,0L,6L,5L,6L,7L,0L,3L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261346Inst : IEnumerable<long>
{
public static readonly long[] Value=A261346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261346.Bytes);
public long this[int i]=>Value[i];

public static A261346Inst Instance=new A261346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261347
{
public static readonly long[] Value={ 0L,0L,5L,26L,84L,222L,488L,946L,1664L,2723L,4227L,6277L,8993L,12514L,16976L,22538L,29364L,37649L,47563L,59321L,73149L,89254L,107892L,129308L,153764L,181547L,212931L,248223L,287747L,331780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261347Inst : IEnumerable<long>
{
public static readonly long[] Value=A261347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261347.Bytes);
public long this[int i]=>Value[i];

public static A261347Inst Instance=new A261347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261348
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,5L,6L,5L,6L,6L,6L,6L,7L,6L,7L,7L,7L,7L,8L,7L,8L,8L,8L,8L,9L,8L,9L,9L,9L,9L,10L,9L,10L,10L,10L,10L,11L,10L,11L,11L,11L,11L,12L,11L,12L,12L,12L,12L,13L,12L,13L,13L,13L,13L,14L,13L,14L,14L,14L,14L,15L,14L,15L,15L,15L,15L,16L,15L,16L,16L,16L,16L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261348Inst : IEnumerable<long>
{
public static readonly long[] Value=A261348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261348.Bytes);
public long this[int i]=>Value[i];

public static A261348Inst Instance=new A261348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261349
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,2L,0L,7L,1L,6L,3L,4L,2L,5L,0L,15L,1L,14L,3L,12L,2L,13L,6L,9L,7L,8L,5L,10L,4L,11L,0L,31L,1L,30L,3L,28L,2L,29L,6L,25L,7L,24L,5L,26L,4L,27L,12L,19L,13L,18L,15L,16L,14L,17L,10L,21L,11L,20L,9L,22L,8L,23L,0L,63L,1L,62L,3L,60L,2L,61L,6L,57L,7L,56L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261349Inst : IEnumerable<long>
{
public static readonly long[] Value=A261349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261349.Bytes);
public long this[int i]=>Value[i];

public static A261349Inst Instance=new A261349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261350
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,3L,1L,1L,4L,1L,2L,4L,1L,2L,5L,2L,2L,5L,1L,1L,2L,6L,1L,1L,3L,6L,1L,2L,2L,7L,1L,2L,3L,7L,2L,1L,3L,8L,1L,1L,2L,3L,8L,1L,1L,2L,3L,9L,1L,1L,2L,4L,9L,1L,2L,2L,3L,10L,1L,2L,2L,4L,10L,2L,1L,2L,4L,11L,1L,1L,1L,3L,4L,11L,1L,1L,2L,2L,4L,12L,1L,1L,2L,2L,5L,12L,1L,1L,2L,3L,4L,13L,1L,2L,1L,3L,5L,13L,1L,2L,2L,2L,5L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261350Inst : IEnumerable<long>
{
public static readonly long[] Value=A261350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261350.Bytes);
public long this[int i]=>Value[i];

public static A261350Inst Instance=new A261350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261351
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,9L,7L,12L,10L,13L,11L,16L,14L,17L,15L,20L,18L,21L,19L,24L,22L,25L,23L,28L,26L,29L,27L,32L,30L,33L,31L,36L,34L,37L,35L,40L,38L,41L,39L,44L,42L,45L,43L,48L,46L,49L,47L,52L,50L,53L,51L,56L,54L,57L,55L,60L,58L,61L,59L,64L,62L,65L,63L,68L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261351Inst : IEnumerable<long>
{
public static readonly long[] Value=A261351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261351.Bytes);
public long this[int i]=>Value[i];

public static A261351Inst Instance=new A261351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261352
{
public static readonly long[] Value={ 11L,23L,167L,197L,223L,317L,359L,461L,593L,619L,859L,1283L,1289L,1327L,1487L,1759L,1879L,2557L,2579L,2749L,2879L,3617L,4159L,4783L,5081L,5333L,5531L,5689L,5783L,5867L,6427L,6521L,7589L,7681L,7727L,7753L,9041L,9157L,9283L,9479L,10111L,10289L,10853L,11261L,11779L,11867L,12541L,13309L,13399L,13687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261352Inst : IEnumerable<long>
{
public static readonly long[] Value=A261352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261352.Bytes);
public long this[int i]=>Value[i];

public static A261352Inst Instance=new A261352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261353
{
public static readonly long[] Value={ 11L,2L,1L,606L,350L,166L,53L,1865L,7L,45L,1308L,68L,215L,61L,256L,13L,248L,90L,1L,1779L,796L,1L,4L,444L,650L,55L,157L,303L,82L,84L,25L,3L,1912L,621L,128L,205L,164L,1091L,61L,12L,337L,1L,303L,15L,23L,418L,212L,23L,2494L,1L,472L,771L,1L,36L,8L,46L,8L,18L,264L,22L,725L,85L,65L,231L,606L,3L,1L,43L,144L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261353Inst : IEnumerable<long>
{
public static readonly long[] Value=A261353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261353.Bytes);
public long this[int i]=>Value[i];

public static A261353Inst Instance=new A261353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261354
{
public static readonly long[] Value={ 31L,191L,541L,809L,1153L,1301L,2221L,3037L,3847L,4049L,4159L,5441L,8243L,10177L,12277L,13681L,14783L,15619L,17903L,19463L,20897L,22697L,24517L,25163L,25847L,25849L,26633L,26647L,27329L,27407L,28051L,32653L,35059L,35747L,36341L,36527L,37369L,37811L,38609L,40949L,42737L,46679L,51061L,51607L,54443L,54679L,56113L,57637L,60887L,61493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261354Inst : IEnumerable<long>
{
public static readonly long[] Value=A261354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261354.Bytes);
public long this[int i]=>Value[i];

public static A261354Inst Instance=new A261354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261355
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,46L,47L,48L,49L,51L,53L,54L,55L,56L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,77L,78L,79L,80L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261355Inst : IEnumerable<long>
{
public static readonly long[] Value=A261355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261355.Bytes);
public long this[int i]=>Value[i];

public static A261355Inst Instance=new A261355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261356
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,1L,4L,4L,1L,3L,6L,3L,12L,12L,1L,6L,12L,8L,1L,4L,8L,6L,24L,24L,4L,24L,48L,32L,1L,8L,24L,32L,16L,1L,5L,10L,10L,40L,40L,10L,60L,120L,80L,5L,40L,120L,160L,80L,1L,10L,40L,80L,80L,32L,1L,6L,12L,15L,60L,60L,20L,120L,240L,160L,15L,120L,360L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261356Inst : IEnumerable<long>
{
public static readonly long[] Value=A261356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261356.Bytes);
public long this[int i]=>Value[i];

public static A261356Inst Instance=new A261356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261357
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,4L,4L,8L,4L,1L,6L,6L,12L,24L,12L,8L,24L,24L,8L,1L,8L,8L,24L,48L,24L,32L,96L,96L,32L,16L,64L,96L,64L,16L,1L,10L,10L,40L,80L,40L,80L,240L,240L,80L,80L,320L,480L,320L,80L,32L,160L,320L,320L,160L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261357Inst : IEnumerable<long>
{
public static readonly long[] Value=A261357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261357.Bytes);
public long this[int i]=>Value[i];

public static A261357Inst Instance=new A261357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261358
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,4L,1L,4L,4L,1L,3L,3L,6L,3L,6L,12L,3L,12L,12L,1L,3L,6L,3L,12L,12L,1L,6L,12L,8L,1L,4L,4L,8L,6L,12L,24L,6L,24L,24L,4L,12L,24L,12L,48L,48L,4L,24L,48L,32L,1L,4L,8L,6L,24L,24L,4L,24L,48L,32L,1L,8L,24L,32L,16L,1L,5L,5L,10L,10L,20L,40L,10L,40L,40L,10L,30L,60L,30L,120L,120L,30L,120L,240L,160L,5L,40L,120L,160L,80L,1L,5L,10L,10L,40L,40L,10L,60L,120L,80L,5L,40L,120L,160L,80L,1L,10L,40L,80L,80L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261358Inst : IEnumerable<long>
{
public static readonly long[] Value=A261358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261358.Bytes);
public long this[int i]=>Value[i];

public static A261358Inst Instance=new A261358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261359
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,4L,4L,1L,4L,4L,4L,8L,4L,1L,3L,6L,6L,3L,12L,12L,12L,24L,12L,1L,6L,6L,12L,24L,12L,8L,24L,24L,8L,1L,4L,8L,8L,6L,24L,24L,24L,48L,24L,4L,24L,24L,48L,96L,48L,32L,96L,96L,32L,1L,8L,8L,24L,48L,24L,32L,96L,96L,32L,16L,64L,96L,64L,16L,1L,5L,10L,10L,10L,40L,40L,40L,80L,40L,10L,60L,60L,120L,240L,120L,80L,240L,240L,80L,5L,40L,40L,120L,240L,120L,160L,480L,480L,160L,80L,320L,480L,320L,80L,1L,10L,10L,40L,80L,40L,80L,240L,240L,80L,80L,320L,480L,320L,80L,32L,160L,320L,320L,160L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261359Inst : IEnumerable<long>
{
public static readonly long[] Value=A261359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261359.Bytes);
public long this[int i]=>Value[i];

public static A261359Inst Instance=new A261359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261360
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,4L,4L,4L,4L,8L,8L,4L,8L,4L,1L,6L,6L,6L,12L,24L,24L,12L,24L,12L,8L,24L,24L,24L,48L,24L,8L,24L,24L,8L,1L,8L,8L,8L,24L,48L,48L,24L,48L,24L,32L,96L,96L,96L,192L,96L,32L,96L,96L,32L,16L,64L,64L,96L,192L,96L,64L,192L,192L,64L,16L,64L,96L,64L,96L,1L,10L,10L,10L,40L,80L,80L,40L,80L,40L,80L,240L,240L,240L,480L,240L,80L,240L,240L,80L,80L,320L,320L,480L,960L,480L,320L,960L,960L,320L,80L,320L,480L,320L,80L,32L,160L,160L,320L,640L,320L,320L,960L,960L,320L,160L,640L,960L,640L,160L,32L,160L,320L,320L,160L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261360Inst : IEnumerable<long>
{
public static readonly long[] Value=A261360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261360.Bytes);
public long this[int i]=>Value[i];

public static A261360Inst Instance=new A261360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261361
{
public static readonly long[] Value={ 3L,13L,173L,463L,523L,823L,971L,991L,1291L,1543L,2113L,4003L,4019L,4649L,5923L,6037L,6101L,7649L,10103L,12539L,12841L,17203L,17569L,18013L,21193L,22093L,23321L,25111L,27197L,31231L,32009L,32117L,33349L,34687L,35423L,35449L,37747L,39619L,41729L,41759L,42017L,43237L,43331L,44741L,45841L,50021L,51437L,52489L,55921L,56891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261361Inst : IEnumerable<long>
{
public static readonly long[] Value=A261361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261361.Bytes);
public long this[int i]=>Value[i];

public static A261361Inst Instance=new A261361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261362
{
public static readonly long[] Value={ 2L,21531L,2L,35434L,11107L,35175L,24674L,64624L,127943L,1981L,155709L,50657L,74313L,11479L,6L,1981L,43405L,40859L,74229L,2L,154292L,51711L,29460L,29011L,42001L,28352L,2979L,85836L,6936L,186608L,3705L,14402L,25525L,96192L,6L,113433L,164L,787L,71873L,3365L,93169L,47219L,43128L,184740L,2L,78329L,13656L,6936L,139469L,26713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261362Inst : IEnumerable<long>
{
public static readonly long[] Value=A261362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261362.Bytes);
public long this[int i]=>Value[i];

public static A261362Inst Instance=new A261362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261363
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,2L,3L,4L,1L,1L,1L,1L,2L,1L,2L,2L,2L,3L,4L,1L,1L,2L,2L,3L,3L,4L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,4L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,1L,2L,3L,4L,4L,4L,4L,4L,5L,6L,7L,8L,1L,1L,1L,1L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261363Inst : IEnumerable<long>
{
public static readonly long[] Value=A261363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261363.Bytes);
public long this[int i]=>Value[i];

public static A261363Inst Instance=new A261363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261364
{
public static readonly BigInteger[] Value={ 121L,1118111L,1111161111L,11111164111111L,BigInteger.Parse("111111111512111111111"),BigInteger.Parse("1111111111114096111111111111"),BigInteger.Parse("111111111111181921111111111111"),BigInteger.Parse("111111111111111638411111111111111"),BigInteger.Parse("111111111111111111262144111111111111111111"),BigInteger.Parse("11111111111111111111104857611111111111111111111") };
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
public class A261364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261364Inst Instance=new A261364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261365
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,3L,1L,1L,5L,10L,10L,5L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,1L,13L,78L,286L,715L,1287L,1716L,1716L,1287L,715L,286L,78L,13L,1L,1L,17L,136L,680L,2380L,6188L,12376L,19448L,24310L,24310L,19448L,12376L,6188L,2380L,680L,136L,17L,1L,1L,19L,171L,969L,3876L,11628L,27132L,50388L,75582L,92378L,92378L,75582L,50388L,27132L,11628L,3876L,969L,171L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261365Inst : IEnumerable<long>
{
public static readonly long[] Value=A261365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261365.Bytes);
public long this[int i]=>Value[i];

public static A261365Inst Instance=new A261365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261366
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,3L,4L,1L,8L,7L,8L,5L,10L,7L,8L,1L,16L,15L,16L,13L,18L,15L,16L,9L,22L,19L,20L,13L,22L,15L,16L,1L,32L,31L,32L,29L,34L,31L,32L,25L,38L,35L,36L,29L,38L,31L,32L,17L,46L,43L,44L,37L,46L,39L,40L,25L,50L,43L,44L,29L,46L,31L,32L,1L,64L,63L,64L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261366Inst : IEnumerable<long>
{
public static readonly long[] Value=A261366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261366.Bytes);
public long this[int i]=>Value[i];

public static A261366Inst Instance=new A261366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261367
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,9L,24L,52L,165L,555L,2020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261367Inst : IEnumerable<long>
{
public static readonly long[] Value=A261367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261367.Bytes);
public long this[int i]=>Value[i];

public static A261367Inst Instance=new A261367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261368
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,7L,10L,12L,13L,14L,18L,17L,22L,22L,23L,25L,28L,29L,31L,32L,36L,35L,40L,38L,41L,44L,44L,47L,51L,48L,53L,53L,56L,59L,59L,60L,64L,65L,66L,66L,71L,71L,74L,75L,77L,78L,83L,81L,84L,86L,87L,88L,94L,91L,97L,96L,97L,101L,102L,103L,107L,106L,110L,109L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261368Inst : IEnumerable<long>
{
public static readonly long[] Value=A261368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261368.Bytes);
public long this[int i]=>Value[i];

public static A261368Inst Instance=new A261368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261369
{
public static readonly long[] Value={ 1L,-2L,5L,-12L,24L,-46L,86L,-152L,262L,-442L,725L,-1168L,1852L,-2886L,4436L,-6736L,10103L,-14994L,22040L,-32092L,46336L,-66380L,94378L,-133256L,186926L,-260576L,361126L,-497716L,682340L,-930774L,1263624L,-1707672L,2297737L,-3078850L,4109022L,-5462924L,7236280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261369Inst : IEnumerable<long>
{
public static readonly long[] Value=A261369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261369.Bytes);
public long this[int i]=>Value[i];

public static A261369Inst Instance=new A261369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261370
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,21L,13L,31L,14L,41L,15L,51L,16L,61L,17L,71L,18L,81L,19L,91L,20L,22L,23L,32L,24L,42L,25L,52L,26L,62L,27L,72L,28L,82L,29L,92L,30L,33L,34L,43L,35L,53L,36L,63L,37L,73L,38L,83L,39L,93L,40L,44L,45L,54L,46L,64L,47L,74L,48L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261370Inst : IEnumerable<long>
{
public static readonly long[] Value=A261370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261370.Bytes);
public long this[int i]=>Value[i];

public static A261370Inst Instance=new A261370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261371
{
public static readonly long[] Value={ 11L,13L,29L,53L,67L,71L,89L,101L,103L,137L,191L,193L,227L,229L,233L,269L,281L,359L,431L,449L,461L,463L,499L,569L,593L,641L,643L,659L,683L,701L,719L,769L,821L,823L,857L,859L,877L,967L,1019L,1061L,1091L,1093L,1223L,1289L,1439L,1451L,1487L,1489L,1579L,1597L,1601L,1619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261371Inst : IEnumerable<long>
{
public static readonly long[] Value=A261371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261371.Bytes);
public long this[int i]=>Value[i];

public static A261371Inst Instance=new A261371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261372
{
public static readonly BigInteger[] Value={ 36L,41L,202L,1040L,5633L,42302L,461576L,5441268L,87288274L,1757770516L,47269754142L,1497418790742L,65202132975489L,3410709440318090L,240487233522340499L,BigInteger.Parse("20318813275802198468"),BigInteger.Parse("2337266627779577763890") };
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
public class A261372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261372Inst Instance=new A261372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261373
{
public static readonly long[] Value={ 36L,39L,60L,97L,154L,247L,392L,618L,977L,1548L,2461L,3894L,6176L,9774L,15513L,24552L,38963L,61662L,97854L,154866L,245769L,388956L,617257L,976878L,1550272L,2453478L,3893581L,6162024L,9778911L,15476214L,24560198L,38869242L,61684093L,97621932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261373Inst : IEnumerable<long>
{
public static readonly long[] Value=A261373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261373.Bytes);
public long this[int i]=>Value[i];

public static A261373Inst Instance=new A261373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261374
{
public static readonly long[] Value={ 39L,41L,82L,157L,266L,470L,864L,1553L,2758L,4960L,8924L,16001L,28662L,51503L,92374L,165796L,297284L,533858L,957252L,1718645L,3081790L,5533474L,9922064L,17814980L,31944528L,57356546L,102846820L,184661677L,331120454L,594527399L,1066057422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261374Inst : IEnumerable<long>
{
public static readonly long[] Value=A261374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261374.Bytes);
public long this[int i]=>Value[i];

public static A261374Inst Instance=new A261374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261375
{
public static readonly long[] Value={ 60L,82L,202L,424L,869L,1714L,3778L,7462L,15888L,31618L,68245L,135058L,290195L,575938L,1238957L,2455954L,5282429L,10475722L,22530337L,44674906L,96090169L,190539730L,409810129L,812624530L,1747814377L,3465775738L,7454228289L,14781184618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261375Inst : IEnumerable<long>
{
public static readonly long[] Value=A261375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261375.Bytes);
public long this[int i]=>Value[i];

public static A261375Inst Instance=new A261375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261376
{
public static readonly long[] Value={ 97L,157L,424L,1040L,2282L,5254L,12500L,28885L,66332L,154413L,358786L,830309L,1923846L,4465820L,10349526L,23993883L,55620850L,129004265L,298983410L,693371845L,1607151330L,3727183505L,8638778942L,20034575762L,46436324264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261376Inst : IEnumerable<long>
{
public static readonly long[] Value=A261376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261376.Bytes);
public long this[int i]=>Value[i];

public static A261376Inst Instance=new A261376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261377
{
public static readonly long[] Value={ 154L,266L,869L,2282L,5633L,14312L,39494L,99168L,261501L,666722L,1785513L,4510376L,12029879L,30520850L,81445076L,206279050L,550615794L,1395355514L,3723483907L,9434612056L,25180483084L,63803504988L,170274449783L,431455039974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261377Inst : IEnumerable<long>
{
public static readonly long[] Value=A261377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261377.Bytes);
public long this[int i]=>Value[i];

public static A261377Inst Instance=new A261377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261378
{
public static readonly long[] Value={ 247L,470L,1714L,5254L,14312L,42302L,128998L,377183L,1099308L,3261560L,9647696L,28358158L,83587624L,246835566L,727709732L,2144744412L,6325797274L,18656814748L,55007382412L,162201500248L,478326263928L,1410502041960L,4159149074114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261378Inst : IEnumerable<long>
{
public static readonly long[] Value=A261378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261378.Bytes);
public long this[int i]=>Value[i];

public static A261378Inst Instance=new A261378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261379
{
public static readonly long[] Value={ 392L,864L,3778L,12500L,39494L,128998L,461576L,1468008L,5004588L,16267396L,56289594L,180787146L,623643757L,2013680076L,6945409809L,22381289794L,77243050853L,249062829770L,859199611263L,2770077481724L,9558157038040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261379Inst : IEnumerable<long>
{
public static readonly long[] Value=A261379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261379.Bytes);
public long this[int i]=>Value[i];

public static A261379Inst Instance=new A261379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261380
{
public static readonly long[] Value={ 36L,39L,39L,60L,41L,60L,97L,82L,82L,97L,154L,157L,202L,157L,154L,247L,266L,424L,424L,266L,247L,392L,470L,869L,1040L,869L,470L,392L,618L,864L,1714L,2282L,2282L,1714L,864L,618L,977L,1553L,3778L,5254L,5633L,5254L,3778L,1553L,977L,1548L,2758L,7462L,12500L,14312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A261380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261380Inst : IEnumerable<long>
{
public static readonly long[] Value=A261380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261380.Bytes);
public long this[int i]=>Value[i];

public static A261380Inst Instance=new A261380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A261381
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,3L,24L,15L,504L,105L,9072L,436401L,166320L,28750491L,3243240L,1307809503L,27965161224L,52309001745L,3795543015264L,2000776242465L,324424646818272L,17268536366932851L,22708075360010040L,3974396337125445231L,1436250980764880280L,BigInteger.Parse("548178165969608527353") };
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
public class A261381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A261381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A261381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A261381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A261381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A261381Inst Instance=new A261381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}