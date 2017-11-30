using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286349
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,1L,0L,-1L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286349Inst : IEnumerable<long>
{
public static readonly long[] Value=A286349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286349.Bytes);
public long this[int i]=>Value[i];

public static A286349Inst Instance=new A286349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286350
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,7L,12L,20L,32L,51L,82L,133L,216L,350L,566L,915L,1480L,2395L,3876L,6272L,10148L,16419L,26566L,42985L,69552L,112538L,182090L,294627L,476716L,771343L,1248060L,2019404L,3267464L,5286867L,8554330L,13841197L,22395528L,36236726L,58632254L,94868979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286350Inst : IEnumerable<long>
{
public static readonly long[] Value=A286350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286350.Bytes);
public long this[int i]=>Value[i];

public static A286350Inst Instance=new A286350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286351
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,6L,3L,0L,1L,1L,3L,0L,4L,1L,2L,1L,2L,2L,8L,0L,0L,0L,7L,3L,10L,1L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286351Inst : IEnumerable<long>
{
public static readonly long[] Value=A286351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286351.Bytes);
public long this[int i]=>Value[i];

public static A286351Inst Instance=new A286351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286352
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,0L,0L,1L,-3L,1L,-1L,0L,1L,-4L,3L,-2L,1L,0L,1L,-5L,6L,-4L,4L,-1L,0L,1L,-6L,10L,-8L,9L,-4L,1L,0L,1L,-7L,15L,-15L,17L,-12L,5L,-1L,0L,1L,-8L,21L,-26L,30L,-28L,15L,-6L,2L,0L,1L,-9L,28L,-42L,51L,-56L,38L,-21L,9L,-2L,0L,1L,-10L,36L,-64L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286352Inst : IEnumerable<long>
{
public static readonly long[] Value=A286352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286352.Bytes);
public long this[int i]=>Value[i];

public static A286352Inst Instance=new A286352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286353
{
public static readonly long[] Value={ 75L,92L,696L,794L,921L,6946L,9211L,9418L,67365L,69446L,73515L,92111L,92592L,584799L,653597L,694446L,921111L,5793295L,6693466L,6944446L,7145554L,7694443L,9211111L,58788989L,61728398L,66733665L,69444446L,72175395L,76445374L,88183426L,89245679L,91721145L,92111111L,92592592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286353Inst : IEnumerable<long>
{
public static readonly long[] Value=A286353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286353.Bytes);
public long this[int i]=>Value[i];

public static A286353Inst Instance=new A286353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286354
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,-1L,0L,1L,-3L,-1L,0L,0L,1L,-4L,0L,2L,0L,0L,1L,-5L,2L,5L,1L,1L,0L,1L,-6L,5L,8L,0L,2L,0L,0L,1L,-7L,9L,10L,-5L,0L,-2L,1L,0L,1L,-8L,14L,10L,-15L,-4L,-7L,0L,0L,0L,1L,-9L,20L,7L,-30L,-6L,-10L,0L,-2L,0L,0L,1L,-10L,27L,0L,-49L,0L,-5L,8L,0L,-2L,0L,0L,1L,-11L,35L,-12L,-70L,21L,11L,25L,9L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286354Inst : IEnumerable<long>
{
public static readonly long[] Value=A286354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286354.Bytes);
public long this[int i]=>Value[i];

public static A286354Inst Instance=new A286354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286355
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,59L,61L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L,92L,93L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286355Inst : IEnumerable<long>
{
public static readonly long[] Value=A286355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286355.Bytes);
public long this[int i]=>Value[i];

public static A286355Inst Instance=new A286355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286356
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,23L,14L,29L,12L,31L,20L,80L,27L,40L,31L,121L,35L,80L,44L,94L,40L,50L,54L,302L,18L,61L,38L,109L,65L,499L,77L,497L,50L,73L,40L,668L,90L,86L,61L,328L,104L,532L,119L,125L,94L,100L,135L,1178L,25L,94L,73L,142L,152L,302L,50L,355L,86L,115L,170L,1894L,189L,131L,109L,2017L,61L,566L,209L,160L,100L,532L,230L,2630L,252L,148L,94L,179L,50L,601L,275L,1228L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286356Inst : IEnumerable<long>
{
public static readonly long[] Value=A286356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286356.Bytes);
public long this[int i]=>Value[i];

public static A286356Inst Instance=new A286356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286357
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,3L,4L,1L,1L,2L,3L,3L,2L,4L,4L,1L,2L,1L,3L,2L,6L,3L,4L,3L,1L,2L,4L,4L,2L,4L,6L,1L,5L,2L,5L,1L,2L,3L,4L,2L,2L,6L,3L,3L,2L,4L,5L,3L,1L,1L,4L,2L,2L,4L,4L,4L,5L,2L,3L,4L,2L,6L,4L,1L,3L,5L,3L,2L,6L,5L,4L,1L,2L,2L,3L,3L,6L,4L,5L,2L,1L,2L,3L,6L,3L,3L,4L,3L,2L,2L,5L,4L,8L,5L,4L,3L,2L,1L,3L,1L,2L,4L,4L,2L,7L,2L,3L,4L,2L,4L,4L,4L,2L,5L,5L,2L,2L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286357Inst : IEnumerable<long>
{
public static readonly long[] Value=A286357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286357.Bytes);
public long this[int i]=>Value[i];

public static A286357Inst Instance=new A286357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286358
{
public static readonly long[] Value={ 1L,4L,6L,22L,8L,13L,10L,106L,79L,47L,13L,39L,30L,19L,19L,466L,47L,742L,24L,233L,21L,58L,19L,139L,466L,233L,32L,49L,122L,70L,21L,1954L,26L,380L,26L,4096L,192L,139L,49L,1037L,233L,34L,81L,256L,782L,70L,26L,531L,1597L,4279L,70L,1227L,380L,157L,70L,157L,41L,1037L,139L,280L,498L,34L,124L,8002L,256L,83L,174L,2018L,34L,83L,70L,18916L,705L,1655L,531L,669L,34L,280L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286358Inst : IEnumerable<long>
{
public static readonly long[] Value=A286358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286358.Bytes);
public long this[int i]=>Value[i];

public static A286358Inst Instance=new A286358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286439
{
public static readonly long[] Value={ 0L,1L,25L,747L,7459L,42983L,176373L,575775L,1595487L,3908979L,8701313L,17936083L,34713675L,63739327L,111921149L,189119943L,309074343L,490526475L,758575017L,1146284219L,1696579123L,2464458903L,3519561925L,4949117807L,6861323439L,9389181603L,12694842513L,16974490275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286439Inst : IEnumerable<long>
{
public static readonly long[] Value=A286439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286439.Bytes);
public long this[int i]=>Value[i];

public static A286439Inst Instance=new A286439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286440
{
public static readonly long[] Value={ 0L,546L,14064L,157248L,1056516L,5086902L,19399860L,62311740L,175452816L,445146906L,1037833944L,2255992584L,4622997276L,9007684494L,16802136156L,30169344996L,52381036968L,88270019922L,144826036032L,231969248016L,363541216308L,558559556262L,842789431428L,1250692671180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286440Inst : IEnumerable<long>
{
public static readonly long[] Value=A286440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286440.Bytes);
public long this[int i]=>Value[i];

public static A286440Inst Instance=new A286440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286441
{
public static readonly long[] Value={ 0L,219L,15160L,369787L,4366982L,32450843L,175628996L,755759531L,2734928266L,8643796747L,24503068784L,63522668395L,152816062222L,345005930315L,737473609532L,1503178571195L,2938515130514L,5535661080283L,10089397100584L,17851538034587L,30750030827926L,51694565135803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286441Inst : IEnumerable<long>
{
public static readonly long[] Value=A286441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286441.Bytes);
public long this[int i]=>Value[i];

public static A286441Inst Instance=new A286441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286442
{
public static readonly long[] Value={ 0L,57L,9233L,563287L,12649059L,152516103L,1211235921L,7147857411L,33812251267L,134823778299L,469266000129L,1462057867743L,4154650828483L,10922915001087L,26867398129329L,62381437357035L,137705497065315L,290721776912275L,589883390417697L,1155073034088999L,2190429436721571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286442Inst : IEnumerable<long>
{
public static readonly long[] Value=A286442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286442.Bytes);
public long this[int i]=>Value[i];

public static A286442Inst Instance=new A286442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286443
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,3L,2L,1L,1L,4L,10L,14L,6L,1L,6L,32L,97L,142L,105L,46L,14L,3L,1L,1L,8L,70L,398L,1280L,2386L,2574L,1569L,524L,87L,3L,1L,11L,143L,1290L,7301L,26471L,62067L,94423L,93358L,60287L,25881L,7697L,1678L,281L,40L,5L,1L,1L,13L,252L,3366L,29603L,176591L,728868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286443Inst : IEnumerable<long>
{
public static readonly long[] Value=A286443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286443.Bytes);
public long this[int i]=>Value[i];

public static A286443Inst Instance=new A286443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286444
{
public static readonly long[] Value={ 0L,3L,10L,32L,70L,143L,252L,424L,660L,995L,1430L,2008L,2730L,3647L,4760L,6128L,7752L,9699L,11970L,14640L,17710L,21263L,25300L,29912L,35100L,40963L,47502L,54824L,62930L,71935L,81840L,92768L,104720L,117827L,132090L,147648L,164502L,182799L,202540L,223880L,246820L,271523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286444Inst : IEnumerable<long>
{
public static readonly long[] Value=A286444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286444.Bytes);
public long this[int i]=>Value[i];

public static A286444Inst Instance=new A286444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286445
{
public static readonly long[] Value={ 0L,2L,14L,97L,398L,1290L,3366L,7731L,15888L,30248L,53850L,91147L,147496L,230290L,348148L,512457L,736204L,1035986L,1430420L,1942691L,2598470L,3429064L,4468784L,5758755L,7343670L,9276330L,11613714L,14422313L,17773458L,21749506L,26438362L,31940587L,38363044L,45826992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286445Inst : IEnumerable<long>
{
public static readonly long[] Value=A286445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286445.Bytes);
public long this[int i]=>Value[i];

public static A286445Inst Instance=new A286445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286446
{
public static readonly long[] Value={ 0L,1L,6L,142L,1280L,7301L,29603L,96485L,266636L,652908L,1452054L,2992513L,5789499L,10629381L,18660890L,31530854L,51525116L,81772345L,126449707L,191075297L,282794784L,410784700L,586640186L,824912741L,1143620051L,1564946921L,2115898646L,2829194838L,3744093216L,4907506597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286446Inst : IEnumerable<long>
{
public static readonly long[] Value=A286446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286446.Bytes);
public long this[int i]=>Value[i];

public static A286446Inst Instance=new A286446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286447
{
public static readonly BigInteger[] Value={ 1L,1L,2L,228L,252642L,3286762710L,423091508279496L,BigInteger.Parse("488322998306377824150"),BigInteger.Parse("5405955851967092442258037800"),BigInteger.Parse("561273297862912365721571649672300480"),BigInteger.Parse("524055990531978935668322776302483856990581000") };
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
public class A286447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286447Inst Instance=new A286447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286448
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,3L,5L,6L,2L,7L,8L,7L,9L,9L,10L,11L,12L,11L,13L,14L,15L,16L,17L,1L,1L,18L,19L,20L,21L,22L,23L,1L,24L,6L,25L,26L,27L,6L,28L,29L,30L,29L,31L,32L,15L,33L,34L,13L,35L,27L,10L,36L,37L,38L,39L,2L,40L,41L,42L,43L,44L,45L,46L,24L,47L,48L,49L,6L,50L,51L,52L,53L,22L,54L,55L,24L,56L,57L,58L,59L,60L,61L,62L,63L,64L,38L,65L,66L,67L,9L,68L,1L,69L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286448Inst : IEnumerable<long>
{
public static readonly long[] Value=A286448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286448.Bytes);
public long this[int i]=>Value[i];

public static A286448Inst Instance=new A286448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286449
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,5L,1L,6L,2L,7L,8L,9L,3L,5L,1L,10L,11L,12L,13L,7L,14L,15L,16L,17L,7L,18L,4L,19L,16L,20L,1L,12L,18L,15L,21L,22L,10L,15L,23L,24L,16L,25L,3L,9L,26L,27L,28L,29L,30L,20L,5L,31L,16L,32L,33L,34L,35L,36L,37L,38L,19L,15L,1L,27L,16L,39L,7L,25L,8L,40L,41L,42L,34L,35L,9L,36L,16L,43L,44L,29L,32L,45L,46L,47L,24L,48L,8L,49L,50L,40L,10L,36L,51L,40L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286449Inst : IEnumerable<long>
{
public static readonly long[] Value=A286449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286449.Bytes);
public long this[int i]=>Value[i];

public static A286449Inst Instance=new A286449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286450
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,3L,2L,7L,8L,1L,9L,10L,11L,12L,7L,13L,14L,5L,15L,16L,17L,14L,18L,19L,20L,21L,22L,23L,24L,12L,25L,1L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,1L,5L,56L,31L,57L,58L,59L,7L,60L,61L,62L,17L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286450Inst : IEnumerable<long>
{
public static readonly long[] Value=A286450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286450.Bytes);
public long this[int i]=>Value[i];

public static A286450Inst Instance=new A286450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286451
{
public static readonly long[] Value={ 0L,2L,6L,4L,3L,9L,10L,7L,1L,5L,6L,13L,3L,14L,10L,11L,3L,2L,6L,8L,21L,9L,10L,18L,1L,5L,10L,19L,3L,14L,21L,16L,15L,5L,15L,4L,3L,9L,10L,12L,3L,27L,6L,13L,3L,14L,15L,24L,1L,2L,10L,8L,3L,14L,10L,25L,15L,5L,6L,19L,3L,27L,10L,22L,6L,20L,6L,8L,21L,20L,10L,7L,3L,5L,6L,13L,21L,14L,15L,17L,1L,5L,6L,34L,6L,9L,10L,18L,3L,5L,15L,19L,36L,20L,10L,31L,3L,2L,6L,4L,3L,14L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286451Inst : IEnumerable<long>
{
public static readonly long[] Value=A286451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286451.Bytes);
public long this[int i]=>Value[i];

public static A286451Inst Instance=new A286451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286452
{
public static readonly long[] Value={ 0L,2L,5L,2L,18L,5L,14L,16L,5L,9L,50L,5L,42L,59L,9L,2L,73L,23L,44L,31L,14L,20L,199L,5L,18L,61L,5L,40L,115L,9L,77L,67L,50L,35L,40L,5L,90L,179L,61L,9L,391L,14L,185L,50L,9L,100L,205L,23L,14L,94L,35L,27L,1006L,5L,20L,40L,44L,115L,395L,31L,228L,131L,59L,2L,61L,20L,295L,442L,54L,14L,320L,23L,346L,265L,9L,44L,125L,61L,275L,31L,23L,104L,1349L,14L,52L,314L,65L,125L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286452Inst : IEnumerable<long>
{
public static readonly long[] Value=A286452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286452.Bytes);
public long this[int i]=>Value[i];

public static A286452Inst Instance=new A286452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286453
{
public static readonly long[] Value={ 0L,2L,5L,11L,94L,5L,14L,254L,17L,9L,195L,47L,259L,500L,9L,11L,413L,138L,44L,303L,32L,20L,2784L,47L,354L,216L,5L,329L,506L,9L,77L,3161L,356L,35L,175L,107L,202L,2709L,216L,24L,11188L,14L,420L,356L,24L,285L,450L,498L,70L,2349L,35L,51L,115937L,5L,20L,329L,74L,310L,3420L,864L,1243L,336L,500L,11L,384L,20L,580L,47285L,87L,14L,615L,498L,1296L,3015L,9L,74L,3491L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286453Inst : IEnumerable<long>
{
public static readonly long[] Value=A286453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286453.Bytes);
public long this[int i]=>Value[i];

public static A286453Inst Instance=new A286453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286454
{
public static readonly long[] Value={ 1L,5L,8L,9L,12L,32L,23L,20L,13L,49L,38L,51L,47L,82L,49L,35L,68L,51L,80L,72L,124L,140L,122L,74L,18L,175L,26L,111L,155L,334L,192L,65L,257L,280L,82L,116L,255L,329L,355L,99L,327L,570L,380L,177L,72L,469L,437L,132L,31L,72L,532L,216L,498L,74L,257L,144L,599L,634L,597L,448L,632L,745L,159L,119L,784L,1044L,782L,331L,907L,570L,863L,186L,905L,1039L,72L,384L,140L,1335L,1037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286454Inst : IEnumerable<long>
{
public static readonly long[] Value=A286454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286454.Bytes);
public long this[int i]=>Value[i];

public static A286454Inst Instance=new A286454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286535
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,5L,2L,3L,4L,5L,4L,6L,6L,7L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,4L,6L,8L,9L,8L,12L,12L,13L,6L,10L,12L,14L,9L,14L,13L,15L,2L,3L,4L,5L,4L,6L,6L,7L,4L,6L,8L,9L,6L,10L,9L,11L,4L,6L,8L,9L,8L,12L,12L,13L,6L,10L,12L,14L,9L,14L,13L,15L,4L,6L,8L,9L,8L,12L,12L,13L,8L,12L,16L,17L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286535Inst : IEnumerable<long>
{
public static readonly long[] Value=A286535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286535.Bytes);
public long this[int i]=>Value[i];

public static A286535Inst Instance=new A286535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286536
{
public static readonly long[] Value={ 2L,4L,2L,4L,8L,2L,6L,4L,12L,8L,2L,16L,12L,6L,6L,4L,12L,12L,8L,2L,36L,32L,12L,24L,12L,6L,16L,30L,24L,6L,6L,4L,12L,12L,12L,8L,2L,36L,72L,32L,12L,60L,72L,12L,24L,12L,6L,36L,48L,30L,64L,48L,60L,24L,30L,24L,6L,16L,30L,60L,24L,6L,6L,4L,12L,12L,12L,12L,8L,2L,36L,72L,72L,32L,12L,60L,180L,72L,12L,60L,72L,12L,24L,12L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286536Inst : IEnumerable<long>
{
public static readonly long[] Value=A286536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286536.Bytes);
public long this[int i]=>Value[i];

public static A286536Inst Instance=new A286536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286537
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,4L,2L,5L,3L,1L,6L,5L,4L,4L,2L,5L,5L,3L,1L,7L,8L,5L,9L,5L,4L,6L,10L,9L,4L,4L,2L,5L,5L,5L,3L,1L,7L,11L,8L,5L,12L,11L,5L,9L,5L,4L,7L,13L,10L,14L,13L,12L,9L,10L,9L,4L,6L,10L,12L,9L,4L,4L,2L,5L,5L,5L,5L,3L,1L,7L,11L,11L,8L,5L,12L,15L,11L,5L,12L,11L,5L,9L,5L,4L,7L,15L,13L,10L,16L,17L,13L,18L,15L,12L,12L,19L,10L,20L,13L,12L,9L,10L,9L,4L,7L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286537Inst : IEnumerable<long>
{
public static readonly long[] Value=A286537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286537.Bytes);
public long this[int i]=>Value[i];

public static A286537Inst Instance=new A286537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286538
{
public static readonly long[] Value={ 2L,2L,4L,2L,6L,8L,4L,2L,6L,12L,16L,6L,12L,8L,4L,2L,6L,12L,24L,32L,6L,30L,36L,12L,24L,16L,6L,12L,12L,8L,4L,2L,6L,12L,24L,48L,64L,6L,30L,60L,72L,12L,60L,72L,24L,48L,32L,6L,30L,36L,30L,60L,36L,12L,24L,24L,16L,6L,12L,12L,12L,8L,4L,2L,6L,12L,24L,48L,96L,128L,6L,30L,60L,120L,144L,12L,60L,180L,216L,24L,120L,144L,48L,96L,64L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286538Inst : IEnumerable<long>
{
public static readonly long[] Value=A286538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286538.Bytes);
public long this[int i]=>Value[i];

public static A286538Inst Instance=new A286538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286539
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,2L,1L,3L,5L,6L,3L,5L,4L,2L,1L,3L,5L,7L,8L,3L,9L,10L,5L,7L,6L,3L,5L,5L,4L,2L,1L,3L,5L,7L,11L,12L,3L,9L,13L,14L,5L,13L,14L,7L,11L,8L,3L,9L,10L,9L,13L,10L,5L,7L,7L,6L,3L,5L,5L,5L,4L,2L,1L,3L,5L,7L,11L,15L,16L,3L,9L,13L,17L,18L,5L,13L,19L,20L,7L,17L,18L,11L,15L,12L,3L,9L,13L,14L,9L,21L,19L,13L,19L,14L,5L,13L,14L,13L,17L,14L,7L,11L,11L,8L,3L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286539Inst : IEnumerable<long>
{
public static readonly long[] Value=A286539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286539.Bytes);
public long this[int i]=>Value[i];

public static A286539Inst Instance=new A286539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286540
{
public static readonly long[] Value={ 2L,2L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,1L,1L,1L,3L,8L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,6L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,8L,8L,24L,18L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286540Inst : IEnumerable<long>
{
public static readonly long[] Value=A286540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286540.Bytes);
public long this[int i]=>Value[i];

public static A286540Inst Instance=new A286540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286541
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,5L,5L,5L,8L,13L,19L,19L,25L,25L,25L,25L,32L,41L,51L,62L,62L,73L,86L,86L,99L,99L,99L,113L,113L,113L,113L,113L,128L,145L,163L,182L,202L,202L,222L,244L,267L,267L,290L,315L,315L,340L,340L,340L,366L,394L,394L,422L,422L,422L,451L,451L,451L,451L,481L,481L,481L,481L,481L,481L,512L,545L,579L,614L,650L,687L,687L,724L,763L,803L,844L,844L,885L,928L,972L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286541Inst : IEnumerable<long>
{
public static readonly long[] Value=A286541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286541.Bytes);
public long this[int i]=>Value[i];

public static A286541Inst Instance=new A286541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286542
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,2L,8L,6L,12L,6L,8L,6L,4L,2L,16L,210L,12L,6L,12L,30L,12L,210L,16L,6L,12L,30L,8L,30L,4L,2L,32L,210L,420L,210L,12L,30L,12L,6L,24L,210L,60L,30L,24L,30030L,420L,30L,32L,30L,12L,6L,24L,210L,60L,30030L,16L,210L,60L,30L,8L,30L,4L,2L,64L,510510L,420L,210L,420L,30030L,420L,210L,24L,210L,60L,30030L,12L,6L,12L,6L,36L,2310L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286542Inst : IEnumerable<long>
{
public static readonly long[] Value=A286542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286542.Bytes);
public long this[int i]=>Value[i];

public static A286542Inst Instance=new A286542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286543
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,2L,5L,4L,6L,4L,5L,4L,3L,2L,7L,8L,6L,4L,6L,9L,6L,8L,7L,4L,6L,9L,5L,9L,3L,2L,10L,8L,11L,8L,6L,9L,6L,4L,12L,8L,13L,9L,12L,14L,11L,9L,10L,9L,6L,4L,12L,8L,13L,14L,7L,8L,13L,9L,5L,9L,3L,2L,15L,16L,11L,8L,11L,14L,11L,8L,12L,8L,13L,14L,6L,4L,6L,4L,17L,18L,11L,14L,13L,9L,13L,9L,6L,19L,20L,14L,11L,14L,13L,14L,15L,18L,13L,14L,6L,18L,6L,4L,6L,18L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286543Inst : IEnumerable<long>
{
public static readonly long[] Value=A286543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286543.Bytes);
public long this[int i]=>Value[i];

public static A286543Inst Instance=new A286543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286544
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,4L,6L,5L,7L,6L,8L,9L,9L,5L,10L,9L,11L,8L,12L,13L,14L,9L,13L,6L,15L,11L,16L,17L,17L,8L,18L,17L,19L,13L,20L,17L,21L,8L,22L,17L,23L,24L,25L,23L,26L,13L,27L,11L,28L,16L,29L,30L,31L,17L,32L,9L,33L,34L,24L,35L,35L,6L,36L,37L,38L,39L,40L,41L,42L,13L,43L,44L,45L,28L,46L,28L,34L,6L,47L,48L,49L,21L,50L,35L,51L,39L,52L,53L,54L,55L,56L,57L,58L,11L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286544Inst : IEnumerable<long>
{
public static readonly long[] Value=A286544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286544.Bytes);
public long this[int i]=>Value[i];

public static A286544Inst Instance=new A286544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286545
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,4L,4L,4L,2L,5L,2L,4L,6L,6L,2L,7L,4L,8L,6L,4L,2L,9L,10L,4L,8L,8L,2L,11L,4L,8L,6L,4L,6L,12L,6L,6L,6L,13L,4L,11L,2L,14L,14L,6L,2L,15L,6L,16L,6L,8L,4L,17L,8L,18L,14L,6L,4L,19L,4L,6L,14L,13L,6L,11L,6L,14L,14L,20L,4L,21L,4L,8L,16L,14L,8L,17L,4L,22L,20L,6L,2L,23L,8L,6L,8L,22L,4L,24L,25L,13L,8L,4L,13L,26L,8L,14L,13L,27L,4L,17L,6L,20L,20L,6L,4L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286545Inst : IEnumerable<long>
{
public static readonly long[] Value=A286545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286545.Bytes);
public long this[int i]=>Value[i];

public static A286545Inst Instance=new A286545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286546
{
public static readonly long[] Value={ 0L,0L,1L,-1L,3L,1L,-2L,-2L,7L,5L,2L,2L,-4L,-4L,-3L,-5L,15L,13L,10L,10L,4L,4L,5L,3L,-8L,-8L,-7L,-9L,-5L,-7L,-10L,-10L,31L,29L,26L,26L,20L,20L,21L,19L,8L,8L,9L,7L,11L,9L,6L,6L,-16L,-16L,-15L,-17L,-13L,-15L,-18L,-18L,-9L,-11L,-14L,-14L,-20L,-20L,-19L,-21L,63L,61L,58L,58L,52L,52L,53L,51L,40L,40L,41L,39L,43L,41L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286546Inst : IEnumerable<long>
{
public static readonly long[] Value=A286546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286546.Bytes);
public long this[int i]=>Value[i];

public static A286546Inst Instance=new A286546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286547
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,2L,5L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,13L,14L,14L,15L,15L,7L,4L,16L,16L,17L,18L,11L,17L,19L,19L,20L,21L,22L,22L,23L,23L,24L,25L,26L,26L,27L,6L,28L,27L,29L,29L,30L,30L,31L,32L,33L,31L,34L,34L,18L,35L,36L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,43L,44L,45L,46L,46L,47L,48L,49L,47L,50L,50L,51L,51L,52L,12L,25L,52L,53L,53L,54L,24L,55L,55L,56L,56L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286547Inst : IEnumerable<long>
{
public static readonly long[] Value=A286547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286547.Bytes);
public long this[int i]=>Value[i];

public static A286547Inst Instance=new A286547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286548
{
public static readonly long[] Value={ 0L,0L,1L,-1L,2L,2L,-1L,-3L,4L,4L,5L,3L,-2L,-2L,-5L,-7L,8L,8L,9L,7L,10L,10L,7L,5L,-4L,-4L,-3L,-5L,-10L,-10L,-13L,-15L,16L,16L,17L,15L,18L,18L,15L,13L,20L,20L,21L,19L,14L,14L,11L,9L,-8L,-8L,-7L,-9L,-6L,-6L,-9L,-11L,-20L,-20L,-19L,-21L,-26L,-26L,-29L,-31L,32L,32L,33L,31L,34L,34L,31L,29L,36L,36L,37L,35L,30L,30L,27L,25L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286548Inst : IEnumerable<long>
{
public static readonly long[] Value=A286548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286548.Bytes);
public long this[int i]=>Value[i];

public static A286548Inst Instance=new A286548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286549
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,3L,5L,6L,6L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,14L,7L,16L,16L,5L,10L,17L,17L,18L,19L,20L,20L,21L,22L,23L,23L,22L,24L,25L,25L,26L,27L,28L,28L,29L,13L,30L,30L,11L,31L,32L,32L,31L,33L,34L,34L,35L,36L,37L,37L,38L,39L,40L,40L,41L,42L,43L,43L,42L,44L,45L,45L,46L,47L,48L,48L,49L,50L,51L,51L,52L,53L,54L,54L,53L,46L,55L,55L,44L,49L,56L,56L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286549Inst : IEnumerable<long>
{
public static readonly long[] Value=A286549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286549.Bytes);
public long this[int i]=>Value[i];

public static A286549Inst Instance=new A286549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286550
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,4L,0L,-2L,8L,12L,8L,14L,0L,2L,-4L,-8L,16L,28L,24L,36L,16L,30L,28L,26L,0L,8L,4L,8L,-8L,-2L,-16L,-20L,32L,60L,56L,80L,48L,86L,72L,52L,32L,64L,60L,82L,56L,102L,52L,74L,0L,20L,16L,34L,8L,34L,16L,22L,-16L,0L,-4L,6L,-32L,-22L,-40L,-50L,64L,124L,120L,168L,112L,198L,160L,132L,96L,176L,172L,230L,144L,250L,104L,108L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286550Inst : IEnumerable<long>
{
public static readonly long[] Value=A286550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286550.Bytes);
public long this[int i]=>Value[i];

public static A286550Inst Instance=new A286550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286583
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,3L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,5L,2L,2L,0L,2L,0L,1L,0L,1L,4L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,3L,0L,3L,2L,0L,0L,0L,1L,4L,0L,1L,2L,1L,0L,1L,0L,0L,1L,1L,3L,1L,0L,2L,1L,2L,1L,0L,2L,0L,1L,3L,1L,0L,3L,3L,7L,1L,2L,0L,0L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,0L,4L,0L,5L,0L,1L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286583Inst : IEnumerable<long>
{
public static readonly long[] Value=A286583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286583.Bytes);
public long this[int i]=>Value[i];

public static A286583Inst Instance=new A286583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286584
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,0L,2L,2L,1L,3L,3L,3L,1L,1L,2L,1L,2L,2L,0L,0L,0L,0L,3L,0L,1L,2L,3L,2L,0L,1L,3L,2L,1L,1L,3L,1L,1L,3L,3L,3L,2L,3L,0L,3L,0L,0L,3L,3L,1L,2L,0L,1L,2L,0L,2L,1L,2L,3L,3L,2L,2L,0L,2L,1L,0L,2L,0L,2L,1L,0L,1L,2L,0L,2L,3L,0L,0L,0L,2L,0L,1L,1L,1L,0L,3L,3L,2L,0L,1L,3L,2L,3L,1L,0L,1L,0L,3L,2L,3L,1L,0L,3L,2L,2L,1L,1L,3L,3L,1L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286584Inst : IEnumerable<long>
{
public static readonly long[] Value=A286584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286584.Bytes);
public long this[int i]=>Value[i];

public static A286584Inst Instance=new A286584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286585
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,2L,4L,3L,3L,3L,5L,1L,5L,2L,5L,2L,4L,2L,4L,2L,4L,3L,6L,5L,6L,3L,6L,4L,7L,3L,6L,3L,3L,3L,5L,3L,5L,5L,5L,4L,3L,4L,5L,4L,6L,1L,7L,5L,6L,4L,7L,2L,8L,4L,7L,4L,5L,3L,8L,4L,4L,4L,7L,4L,6L,2L,4L,5L,6L,3L,6L,4L,6L,5L,6L,4L,6L,4L,6L,7L,5L,3L,4L,5L,7L,6L,6L,5L,5L,4L,7L,3L,8L,1L,8L,5L,6L,3L,7L,6L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286585Inst : IEnumerable<long>
{
public static readonly long[] Value=A286585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286585.Bytes);
public long this[int i]=>Value[i];

public static A286585Inst Instance=new A286585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286586
{
public static readonly long[] Value={ 2L,3L,2L,6L,4L,9L,3L,12L,8L,6L,6L,18L,2L,18L,3L,24L,4L,12L,4L,12L,4L,9L,6L,36L,18L,27L,6L,36L,12L,54L,6L,48L,6L,6L,8L,24L,6L,18L,24L,24L,12L,6L,9L,18L,12L,36L,2L,72L,18L,27L,12L,54L,4L,81L,12L,72L,12L,18L,8L,108L,12L,9L,12L,96L,9L,36L,4L,12L,18L,36L,8L,48L,16L,27L,24L,36L,9L,36L,12L,48L,72L,18L,6L,12L,24L,54L,27L,36L,24L,18L,16L,72L,8L,81L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286586Inst : IEnumerable<long>
{
public static readonly long[] Value=A286586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286586.Bytes);
public long this[int i]=>Value[i];

public static A286586Inst Instance=new A286586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286587
{
public static readonly long[] Value={ 2L,3L,2L,6L,4L,9L,8L,12L,3L,6L,3L,18L,18L,12L,6L,24L,6L,18L,4L,12L,8L,54L,12L,36L,18L,27L,24L,24L,12L,81L,72L,48L,2L,9L,6L,36L,12L,6L,12L,24L,9L,36L,24L,108L,4L,18L,36L,72L,8L,27L,18L,54L,36L,144L,72L,48L,27L,18L,48L,162L,288L,108L,54L,96L,4L,27L,24L,18L,9L,36L,6L,72L,16L,18L,36L,12L,72L,54L,144L,48L,8L,162L,48L,72L,18L,36L,54L,216L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286587Inst : IEnumerable<long>
{
public static readonly long[] Value=A286587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286587.Bytes);
public long this[int i]=>Value[i];

public static A286587Inst Instance=new A286587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286588
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,8L,16L,2L,6L,6L,12L,6L,30L,12L,36L,4L,12L,12L,24L,8L,24L,16L,32L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,36L,72L,4L,12L,12L,36L,12L,60L,24L,72L,8L,24L,24L,48L,16L,48L,32L,64L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,30L,60L,30L,210L,60L,180L,12L,60L,60L,180L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286588Inst : IEnumerable<long>
{
public static readonly long[] Value=A286588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286588.Bytes);
public long this[int i]=>Value[i];

public static A286588Inst Instance=new A286588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286589
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,5L,7L,2L,4L,4L,6L,4L,8L,6L,9L,3L,6L,6L,10L,5L,10L,7L,11L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,9L,13L,3L,6L,6L,9L,6L,12L,10L,13L,5L,10L,10L,14L,7L,14L,11L,15L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,14L,4L,8L,8L,12L,8L,16L,12L,17L,6L,12L,12L,17L,9L,17L,13L,18L,3L,6L,6L,9L,6L,12L,9L,13L,6L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286589Inst : IEnumerable<long>
{
public static readonly long[] Value=A286589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286589.Bytes);
public long this[int i]=>Value[i];

public static A286589Inst Instance=new A286589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286590
{
public static readonly long[] Value={ 1L,3L,9L,21L,33L,45L,81L,153L,165L,201L,393L,405L,441L,645L,873L,885L,921L,1113L,1125L,1161L,1365L,2313L,2565L,3765L,4005L,5913L,5925L,5961L,6153L,6165L,6201L,6405L,7353L,7641L,8805L,9045L,15993L,16281L,17433L,26085L,26325L,36393L,36645L,46233L,46245L,46281L,46473L,46485L,46521L,46725L,47673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286590Inst : IEnumerable<long>
{
public static readonly long[] Value=A286590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286590.Bytes);
public long this[int i]=>Value[i];

public static A286590Inst Instance=new A286590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286591
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,23L,1L,10L,6L,5L,1L,42L,1L,5L,4L,1L,1L,34L,1L,5L,1L,5L,1L,179L,1L,5L,1L,408L,1L,23L,1L,3L,4L,5L,1L,45L,1L,5L,1L,144L,1L,23L,1L,12L,13L,5L,1L,12L,1L,3L,4L,5L,1L,23L,1L,113L,1L,5L,1L,265L,1L,5L,6L,1L,1L,23L,1L,5L,4L,5L,1L,103L,1L,5L,6L,12L,1L,23L,1L,65L,1L,5L,1L,753L,1L,5L,4L,63L,1L,259L,22L,12L,1L,5L,11L,265L,1L,3L,13L,1L,1L,23L,1L,44L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286591Inst : IEnumerable<long>
{
public static readonly long[] Value=A286591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286591.Bytes);
public long this[int i]=>Value[i];

public static A286591Inst Instance=new A286591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286592
{
public static readonly long[] Value={ 1L,3L,5L,10L,8L,42L,17L,36L,40L,27L,30L,183L,47L,34L,51L,136L,57L,243L,80L,288L,72L,177L,122L,765L,194L,72L,308L,117L,192L,1020L,212L,528L,142L,259L,196L,1576L,255L,111L,196L,1059L,302L,1020L,327L,103L,202L,471L,380L,2823L,500L,832L,306L,132L,498L,765L,672L,1564L,747L,786L,668L,4620L,743L,282L,337L,2080L,502L,1020L,782L,165L,441L,696L,822L,6288L,905L,747L,1047L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286592Inst : IEnumerable<long>
{
public static readonly long[] Value=A286592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286592.Bytes);
public long this[int i]=>Value[i];

public static A286592Inst Instance=new A286592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286593
{
public static readonly long[] Value={ 1L,1L,5L,1L,4L,12L,24L,1L,16L,2L,30L,38L,37L,13L,32L,1L,46L,56L,80L,79L,22L,107L,139L,138L,137L,22L,173L,18L,172L,175L,281L,1L,67L,154L,122L,211L,232L,57L,139L,254L,277L,121L,327L,8L,37L,381L,439L,408L,407L,436L,212L,11L,466L,138L,564L,598L,562L,596L,668L,784L,704L,258L,196L,1L,352L,121L,782L,22L,301L,38L,864L,821L,862L,562L,632L,47L,631L,156L,1039L,947L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286593Inst : IEnumerable<long>
{
public static readonly long[] Value=A286593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286593.Bytes);
public long this[int i]=>Value[i];

public static A286593Inst Instance=new A286593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286594
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,1L,7L,8L,6L,5L,11L,4L,13L,5L,4L,16L,17L,7L,19L,11L,12L,6L,23L,3L,10L,6L,15L,1L,29L,5L,31L,32L,7L,7L,9L,13L,37L,7L,9L,5L,41L,6L,43L,11L,7L,8L,47L,7L,14L,14L,7L,11L,53L,7L,11L,8L,15L,9L,59L,6L,61L,9L,12L,64L,10L,8L,67L,11L,8L,20L,71L,9L,73L,10L,13L,9L,23L,9L,79L,17L,42L,11L,83L,4L,11L,11L,8L,23L,89L,5L,7L,9L,16L,12L,8L,6L,97L,17L,9L,16L,101L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286594Inst : IEnumerable<long>
{
public static readonly long[] Value=A286594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286594.Bytes);
public long this[int i]=>Value[i];

public static A286594Inst Instance=new A286594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286595
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,12L,11L,10L,16L,5L,22L,48L,37L,8L,11L,15L,46L,68L,67L,108L,22L,107L,106L,175L,137L,30L,154L,18L,172L,138L,191L,21L,67L,173L,106L,256L,232L,57L,106L,329L,277L,138L,301L,13L,37L,353L,352L,501L,407L,467L,191L,24L,466L,138L,497L,634L,562L,632L,631L,744L,704L,192L,106L,28L,352L,138L,742L,39L,301L,38L,781L,950L,862L,597L,596L,58L,631L,138L,904L,1133L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286595Inst : IEnumerable<long>
{
public static readonly long[] Value=A286595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286595.Bytes);
public long this[int i]=>Value[i];

public static A286595Inst Instance=new A286595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286596
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,2L,6L,16L,8L,4L,12L,2L,6L,6L,12L,32L,16L,8L,24L,4L,12L,12L,36L,2L,6L,6L,12L,6L,30L,12L,24L,64L,32L,16L,48L,8L,24L,24L,72L,4L,12L,12L,36L,12L,60L,36L,72L,2L,6L,6L,12L,6L,30L,12L,24L,6L,30L,30L,60L,12L,60L,24L,48L,128L,64L,32L,96L,16L,48L,48L,144L,8L,24L,24L,72L,24L,120L,72L,216L,4L,12L,12L,36L,12L,60L,36L,72L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286596Inst : IEnumerable<long>
{
public static readonly long[] Value=A286596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286596.Bytes);
public long this[int i]=>Value[i];

public static A286596Inst Instance=new A286596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286597
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,2L,5L,6L,4L,3L,7L,2L,5L,5L,7L,8L,6L,4L,9L,3L,7L,7L,10L,2L,5L,5L,7L,5L,11L,7L,9L,12L,8L,6L,13L,4L,9L,9L,14L,3L,7L,7L,10L,7L,15L,10L,14L,2L,5L,5L,7L,5L,11L,7L,9L,5L,11L,11L,15L,7L,15L,9L,13L,16L,12L,8L,17L,6L,13L,13L,18L,4L,9L,9L,14L,9L,19L,14L,20L,3L,7L,7L,10L,7L,15L,10L,14L,7L,15L,15L,21L,10L,21L,14L,18L,2L,5L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286597Inst : IEnumerable<long>
{
public static readonly long[] Value=A286597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286597.Bytes);
public long this[int i]=>Value[i];

public static A286597Inst Instance=new A286597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286598
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,8L,16L,6L,12L,6L,2L,4L,12L,12L,36L,8L,24L,16L,32L,6L,30L,12L,24L,6L,12L,6L,2L,4L,12L,12L,36L,12L,60L,36L,72L,8L,24L,24L,72L,16L,48L,32L,64L,6L,30L,30L,60L,12L,60L,24L,48L,6L,30L,12L,24L,6L,12L,6L,2L,4L,12L,12L,36L,12L,60L,36L,72L,12L,60L,60L,180L,36L,180L,72L,144L,8L,24L,24L,72L,24L,120L,72L,216L,16L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286598Inst : IEnumerable<long>
{
public static readonly long[] Value=A286598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286598.Bytes);
public long this[int i]=>Value[i];

public static A286598Inst Instance=new A286598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286775
{
public static readonly long[] Value={ 1L,10L,10L,0L,100L,0L,111000L,0L,10110000L,0L,1001100000L,100000000L,100111000000L,0L,10010110000000L,10000000000L,1011100000000L,10001100000000000L,11000000000L,100101000000000000L,101110000000000L,1100100000000000000L,100011100000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286775Inst : IEnumerable<long>
{
public static readonly long[] Value=A286775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286775.Bytes);
public long this[int i]=>Value[i];

public static A286775Inst Instance=new A286775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286776
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,0L,14L,0L,26L,0L,50L,8L,114L,0L,210L,32L,464L,98L,768L,164L,1856L,152L,3616L,94L,6400L,726L,15360L,462L,25088L,714L,62772L,202L,100400L,9412L,235634L,26496L,419860L,6656L,1040742L,14856L,1736804L,72088L,3834976L,128L,6442550L,528776L,16035446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286776Inst : IEnumerable<long>
{
public static readonly long[] Value=A286776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286776.Bytes);
public long this[int i]=>Value[i];

public static A286776Inst Instance=new A286776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286777
{
public static readonly long[] Value={ 1L,2L,2L,0L,4L,0L,56L,0L,176L,0L,608L,256L,2496L,0L,9600L,1024L,5888L,71680L,1536L,151552L,23552L,409600L,145408L,7995392L,77824L,28114944L,122880L,121110528L,573440L,349175808L,374833152L,1392508928L,404946944L,2358247424L,10482483200L,509607936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286777Inst : IEnumerable<long>
{
public static readonly long[] Value=A286777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286777.Bytes);
public long this[int i]=>Value[i];

public static A286777Inst Instance=new A286777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286778
{
public static readonly long[] Value={ 0L,2L,22L,142L,734L,3390L,14718L,61694L,253438L,1029118L,4151294L,16683006L,66904062L,267993086L,1072791550L,4292935678L,17175543806L,68710301694L,274858508286L,1099470733310L,4397960527870L,17592005689342L,70368366690302L,281474188181502L,1125898262675454L,4503596204818430L,18014391395942398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286778Inst : IEnumerable<long>
{
public static readonly long[] Value=A286778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286778.Bytes);
public long this[int i]=>Value[i];

public static A286778Inst Instance=new A286778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286779
{
public static readonly long[] Value={ 1L,4L,4L,10L,4L,16L,4L,20L,10L,16L,4L,40L,4L,16L,16L,34L,4L,40L,4L,40L,16L,16L,4L,80L,10L,16L,20L,40L,4L,64L,4L,52L,16L,16L,16L,100L,4L,16L,16L,80L,4L,64L,4L,40L,40L,16L,4L,136L,10L,40L,16L,40L,4L,80L,16L,80L,16L,16L,4L,160L,4L,16L,40L,74L,16L,64L,4L,40L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286779Inst : IEnumerable<long>
{
public static readonly long[] Value=A286779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286779.Bytes);
public long this[int i]=>Value[i];

public static A286779Inst Instance=new A286779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286780
{
public static readonly long[] Value={ 1L,2L,6L,12L,20L,40L,104L,208L,304L,608L,1824L,3648L,7104L,14208L,19072L,38144L,76544L,153088L,303616L,607232L,1235968L,2471936L,4728832L,9457664L,18919424L,37838848L,75636736L,151273472L,302891008L,605782016L,1220706304L,2441412608L,4882890752L,9765781504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286780Inst : IEnumerable<long>
{
public static readonly long[] Value=A286780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286780.Bytes);
public long this[int i]=>Value[i];

public static A286780Inst Instance=new A286780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286781
{
public static readonly long[] Value={ 1L,2L,1L,10L,9L,1L,74L,91L,23L,1L,706L,1063L,416L,46L,1L,8162L,14193L,7344L,1350L,80L,1L,110410L,213953L,134613L,34362L,3550L,127L,1L,1708394L,3602891L,2620379L,842751L,125195L,8085L,189L,1L,29752066L,67168527L,54636792L,20862684L,4009832L,382358L,16576L,268L,1L,576037442L,1375636129L,1223392968L,533394516L,124266346L,15653598L,1023340L,31356L,366L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286781Inst : IEnumerable<long>
{
public static readonly long[] Value=A286781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286781.Bytes);
public long this[int i]=>Value[i];

public static A286781Inst Instance=new A286781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286782
{
public static readonly long[] Value={ 1L,1L,6L,3L,50L,45L,5L,518L,637L,161L,7L,6354L,9567L,3744L,414L,9L,89782L,156123L,80784L,14850L,880L,11L,1435330L,2781389L,1749969L,446706L,46150L,1651L,13L,25625910L,54043365L,39305685L,12641265L,1877925L,121275L,2835L,15L,505785122L,1141864959L,928825464L,354665628L,68167144L,6500086L,281792L,4556L,17L,10944711398L,26137086451L,23244466392L,10134495804L,2361060574L,297418362L,19443460L,595764L,6954L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286782Inst : IEnumerable<long>
{
public static readonly long[] Value=A286782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286782.Bytes);
public long this[int i]=>Value[i];

public static A286782Inst Instance=new A286782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286783
{
public static readonly long[] Value={ 1L,3L,15L,5L,105L,77L,7L,945L,1044L,234L,9L,10395L,14784L,5390L,550L,11L,135135L,227877L,113126L,19760L,1105L,13L,2027025L,3862305L,2371845L,586425L,58275L,1995L,15L,34459425L,71983440L,51607716L,16271380L,2356234L,147560L,3332L,17L,654729075L,1469813400L,1185214452L,446964322L,84487110L,7888876L,333564L,5244L,19L,13749310575L,32718512925L,28937407212L,12516198870L,2884205268L,358182846L,23006928L,690480L,7875L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286783Inst : IEnumerable<long>
{
public static readonly long[] Value=A286783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286783.Bytes);
public long this[int i]=>Value[i];

public static A286783Inst Instance=new A286783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286784
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,5L,15L,9L,1L,14L,56L,56L,16L,1L,42L,210L,300L,150L,25L,1L,132L,792L,1485L,1100L,330L,36L,1L,429L,3003L,7007L,7007L,3185L,637L,49L,1L,1430L,11440L,32032L,40768L,25480L,7840L,1120L,64L,1L,4862L,43758L,143208L,222768L,179928L,77112L,17136L,1836L,81L,1L,16796L,167960L,629850L,1162800L,1162800L,651168L,203490L,34200L,2850L,100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286784Inst : IEnumerable<long>
{
public static readonly long[] Value=A286784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286784.Bytes);
public long this[int i]=>Value[i];

public static A286784Inst Instance=new A286784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286785
{
public static readonly long[] Value={ 1L,2L,5L,2L,14L,14L,2L,42L,72L,27L,2L,132L,330L,220L,44L,2L,429L,1430L,1430L,520L,65L,2L,1430L,6006L,8190L,4550L,1050L,90L,2L,4862L,24752L,43316L,33320L,11900L,1904L,119L,2L,16796L,100776L,217056L,217056L,108528L,27132L,3192L,152L,2L,58786L,406980L,1046520L,1302336L,854658L,301644L,55860L,5040L,189L,2L,208012L,1634380L,4903140L,7354710L,6056820L,2826516L,743820L,106260L,7590L,230L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286785Inst : IEnumerable<long>
{
public static readonly long[] Value=A286785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286785.Bytes);
public long this[int i]=>Value[i];

public static A286785Inst Instance=new A286785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286786
{
public static readonly BigInteger[] Value={ 1L,9L,91L,1063L,14193L,213953L,3602891L,67168527L,1375636129L,30741614905L,745133551611L,19485223248311L,547092691302545L,16422216867929457L,524970306508659691L,17809453107819266335UL,BigInteger.Parse("639153386976421052481"),BigInteger.Parse("24196474723945543441769"),BigInteger.Parse("963736849031626750711451"),BigInteger.Parse("40289411871795861783689799") };
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
public class A286786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286786Inst Instance=new A286786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286787
{
public static readonly BigInteger[] Value={ 1L,23L,416L,7344L,134613L,2620379L,54636792L,1223392968L,29409134545L,757686550455L,20870680635528L,612964613117960L,19140704352872949L,633710701752022635L,BigInteger.Parse("22185391759982205904"),BigInteger.Parse("819180275431111135536"),BigInteger.Parse("31826528430233802890049"),BigInteger.Parse("1298154677953792936043447"),BigInteger.Parse("55473817874169725876166480") };
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
public class A286787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286787Inst Instance=new A286787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286788
{
public static readonly BigInteger[] Value={ 1L,46L,1350L,34362L,842751L,20862684L,533394516L,14251251012L,400275122533L,11849888387786L,370032953752618L,12183464636804638L,422529226131247475L,15413172354966378040UL,BigInteger.Parse("590459747844232859976"),BigInteger.Parse("23715530712277152761928"),BigInteger.Parse("997006212536288359365609"),BigInteger.Parse("43800374567467950834916070") };
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
public class A286788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286788Inst Instance=new A286788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286789
{
public static readonly BigInteger[] Value={ 1L,80L,3550L,125195L,4009832L,124266346L,3854188670L,121943460540L,3979525634005L,134806148044750L,4756728585598416L,175132764223880035L,6731931366383154760L,BigInteger.Parse("270129431174068396380"),BigInteger.Parse("11308903054417009540644"),BigInteger.Parse("493544598057755406560688"),BigInteger.Parse("22431785171561428611320865") };
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
public class A286789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286789Inst Instance=new A286789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286790
{
public static readonly BigInteger[] Value={ 1L,127L,8085L,382358L,15653598L,598415692L,22280470762L,828351390146L,31225895068199L,1204894853397543L,47870402081423775L,1965205314867907972L,BigInteger.Parse("83531844407610101388"),BigInteger.Parse("3679988322044604002256"),BigInteger.Parse("168093873703636990132596"),BigInteger.Parse("7960504783782783371445468") };
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
public class A286790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286790Inst Instance=new A286790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287208
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,13L,23L,28L,37L,40L,107L,132L,156L,290L,295L,653L,948L,2292L,4727L,6188L,7340L,24326L,34031L,41026L,66848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287208Inst : IEnumerable<long>
{
public static readonly long[] Value=A287208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287208.Bytes);
public long this[int i]=>Value[i];

public static A287208Inst Instance=new A287208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287209
{
public static readonly long[] Value={ 4L,5L,9L,14L,14L,10L,6L,7L,13L,11L,6L,8L,14L,13L,9L,13L,13L,8L,12L,11L,5L,7L,12L,10L,4L,5L,9L,14L,14L,10L,6L,7L,13L,11L,6L,8L,14L,13L,9L,13L,13L,8L,12L,11L,5L,7L,12L,10L,4L,5L,9L,14L,14L,10L,6L,7L,13L,11L,6L,8L,14L,13L,9L,13L,13L,8L,12L,11L,5L,7L,12L,10L,4L,5L,9L,14L,14L,10L,6L,7L,13L,11L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287209Inst : IEnumerable<long>
{
public static readonly long[] Value=A287209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287209.Bytes);
public long this[int i]=>Value[i];

public static A287209Inst Instance=new A287209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287210
{
public static readonly long[] Value={ 0L,1L,2L,4L,11L,14L,15L,16L,18L,21L,28L,44L,55L,286L,304L,494L,970L,1611L,2051L,2756L,6452L,16758L,29291L,98413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287210Inst : IEnumerable<long>
{
public static readonly long[] Value=A287210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287210.Bytes);
public long this[int i]=>Value[i];

public static A287210Inst Instance=new A287210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287211
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,78L,308L,1264L,5332L,22994L,100896L,449004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287211Inst : IEnumerable<long>
{
public static readonly long[] Value=A287211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287211.Bytes);
public long this[int i]=>Value[i];

public static A287211Inst Instance=new A287211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287212
{
public static readonly long[] Value={ 3L,6L,18L,48L,114L,414L,546L,627L,927L,1023L,1836L,3090L,4167L,7539L,7752L,7884L,7950L,8250L,9093L,9621L,9870L,10779L,11226L,11622L,11886L,12363L,12465L,14994L,16152L,17391L,19656L,20169L,20499L,22383L,23937L,25359L,25623L,26532L,26847L,27045L,27492L,28731L,31641L,31707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287212Inst : IEnumerable<long>
{
public static readonly long[] Value=A287212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287212.Bytes);
public long this[int i]=>Value[i];

public static A287212Inst Instance=new A287212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287213
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,7L,5L,2L,1L,15L,18L,13L,5L,1L,31L,57L,61L,38L,15L,1L,63L,169L,248L,215L,129L,52L,1L,127L,482L,935L,1061L,836L,495L,203L,1L,255L,1341L,3368L,4835L,4789L,3573L,2108L,877L,1L,511L,3669L,11777L,20973L,25430L,22986L,16657L,9831L,4140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287213Inst : IEnumerable<long>
{
public static readonly long[] Value=A287213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287213.Bytes);
public long this[int i]=>Value[i];

public static A287213Inst Instance=new A287213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287214
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,1L,1L,1L,2L,5L,8L,1L,1L,1L,2L,5L,13L,16L,1L,1L,1L,2L,5L,15L,34L,32L,1L,1L,1L,2L,5L,15L,47L,89L,64L,1L,1L,1L,2L,5L,15L,52L,150L,233L,128L,1L,1L,1L,2L,5L,15L,52L,188L,481L,610L,256L,1L,1L,1L,2L,5L,15L,52L,203L,696L,1545L,1597L,512L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287214Inst : IEnumerable<long>
{
public static readonly long[] Value=A287214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287214.Bytes);
public long this[int i]=>Value[i];

public static A287214Inst Instance=new A287214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287215
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,8L,5L,1L,1L,22L,21L,7L,1L,1L,65L,86L,39L,11L,1L,1L,209L,361L,209L,77L,19L,1L,1L,732L,1584L,1123L,493L,171L,35L,1L,1L,2780L,7315L,6153L,3124L,1293L,413L,67L,1L,1L,11377L,35635L,34723L,20019L,9320L,3709L,1059L,131L,1L,1L,49863L,183080L,202852L,130916L,66992L,30396L,11373L,2837L,259L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287215Inst : IEnumerable<long>
{
public static readonly long[] Value=A287215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287215.Bytes);
public long this[int i]=>Value[i];

public static A287215Inst Instance=new A287215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287216
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,1L,1L,1L,2L,5L,9L,1L,1L,1L,2L,5L,14L,23L,1L,1L,1L,2L,5L,15L,44L,66L,1L,1L,1L,2L,5L,15L,51L,152L,210L,1L,1L,1L,2L,5L,15L,52L,191L,571L,733L,1L,1L,1L,2L,5L,15L,52L,202L,780L,2317L,2781L,1L,1L,1L,2L,5L,15L,52L,203L,857L,3440L,10096L,11378L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287216Inst : IEnumerable<long>
{
public static readonly long[] Value=A287216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287216.Bytes);
public long this[int i]=>Value[i];

public static A287216Inst Instance=new A287216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287217
{
public static readonly long[] Value={ 7L,13L,19L,29L,37L,59L,71L,79L,89L,107L,131L,139L,151L,173L,191L,211L,233L,263L,277L,283L,313L,331L,359L,379L,389L,409L,439L,467L,491L,503L,521L,541L,569L,587L,599L,613L,647L,659L,677L,691L,739L,757L,773L,809L,823L,839L,857L,863L,881L,929L,941L,953L,977L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287217Inst : IEnumerable<long>
{
public static readonly long[] Value=A287217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287217.Bytes);
public long this[int i]=>Value[i];

public static A287217Inst Instance=new A287217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287218
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,2L,3L,9L,12L,8L,3L,4L,3L,1L,36L,25L,8L,12L,19L,21L,3L,12L,19L,40L,9L,14L,1L,14L,2L,18L,81L,56L,49L,38L,38L,26L,3L,33L,103L,12L,67L,12L,11L,8L,48L,79L,2L,43L,136L,82L,12L,46L,78L,31L,117L,126L,34L,4L,27L,49L,83L,3L,57L,234L,12L,10L,116L,128L,53L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287218Inst : IEnumerable<long>
{
public static readonly long[] Value=A287218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287218.Bytes);
public long this[int i]=>Value[i];

public static A287218Inst Instance=new A287218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287219
{
public static readonly long[] Value={ 3634L,3726L,3886L,4002L,4234L,4662L,5022L,5056L,5568L,7008L,7448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287219Inst : IEnumerable<long>
{
public static readonly long[] Value=A287219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287219.Bytes);
public long this[int i]=>Value[i];

public static A287219Inst Instance=new A287219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287220
{
public static readonly long[] Value={ 0L,0L,1L,4L,10L,36L,85L,312L,737L,2760L,6604L,25176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287220Inst : IEnumerable<long>
{
public static readonly long[] Value=A287220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287220.Bytes);
public long this[int i]=>Value[i];

public static A287220Inst Instance=new A287220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287221
{
public static readonly long[] Value={ 0L,0L,0L,0L,8L,42L,168L,760L,2418L,10490L,30842L,131676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287221Inst : IEnumerable<long>
{
public static readonly long[] Value=A287221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287221.Bytes);
public long this[int i]=>Value[i];

public static A287221Inst Instance=new A287221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287222
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,16L,164L,944L,4386L,22240L,83066L,398132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287222Inst : IEnumerable<long>
{
public static readonly long[] Value=A287222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287222.Bytes);
public long this[int i]=>Value[i];

public static A287222Inst Instance=new A287222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287223
{
public static readonly long[] Value={ 0L,0L,2L,6L,22L,88L,370L,1612L,7232L,33304L,157102L,757804L,3731352L,18720504L,95519428L,494733144L,2596388976L,13783481424L,73906300822L,399722732236L,2178164438936L,11946745980632L,65898275096796L,365308080119688L,2033992114316240L,11369167905107888L,63769939599193228L,358804271821028088L,2024523256299630832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287223Inst : IEnumerable<long>
{
public static readonly long[] Value=A287223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287223.Bytes);
public long this[int i]=>Value[i];

public static A287223Inst Instance=new A287223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287288
{
public static readonly long[] Value={ 1L,1L,0L,0L,11L,11L,1L,1L,1000L,1000L,111L,111L,111L,111L,111L,111L,11000111L,11000111L,1000111L,1000111L,1010111L,1010111L,100111L,100111L,1000001011L,1000001011L,1000011L,1000011L,1000000001L,1000000001L,100110L,100110L,1100000100000010L,1100000100000010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287288Inst : IEnumerable<long>
{
public static readonly long[] Value=A287288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287288.Bytes);
public long this[int i]=>Value[i];

public static A287288Inst Instance=new A287288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287289
{
public static readonly ulong[] Value={ 1L,10L,0L,0L,11000L,110000L,1000000L,10000000L,100000L,1000000L,11100000000L,111000000000L,1110000000000L,11100000000000L,111000000000000L,1110000000000000L,11100011000000000L,111000110000000000L,1110001000000000000L,11100010000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287289Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A287289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287289.Bytes);
public ulong this[int i]=>Value[i];

public static A287289Inst Instance=new A287289Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287290
{
public static readonly long[] Value={ 1L,1L,0L,0L,3L,3L,1L,1L,8L,8L,7L,7L,7L,7L,7L,7L,199L,199L,71L,71L,87L,87L,39L,39L,523L,523L,67L,67L,513L,513L,38L,38L,49410L,49410L,16416L,16416L,16912L,16912L,16672L,16672L,147980L,147980L,81920L,81920L,45312L,45312L,16392L,16392L,3584L,3584L,17412L,17412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287290Inst : IEnumerable<long>
{
public static readonly long[] Value=A287290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287290.Bytes);
public long this[int i]=>Value[i];

public static A287290Inst Instance=new A287290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287291
{
public static readonly long[] Value={ 1L,2L,0L,0L,24L,48L,64L,128L,32L,64L,1792L,3584L,7168L,14336L,28672L,57344L,116224L,232448L,462848L,925696L,1916928L,3833856L,7471104L,14942208L,27295744L,54591488L,101711872L,203423744L,268959744L,537919488L,838860800L,1677721600L,2164654080L,4329308160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287291Inst : IEnumerable<long>
{
public static readonly long[] Value=A287291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287291.Bytes);
public long this[int i]=>Value[i];

public static A287291Inst Instance=new A287291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287292
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,5L,7L,6L,8L,8L,8L,9L,10L,10L,10L,12L,10L,13L,13L,11L,15L,14L,15L,16L,16L,16L,17L,17L,18L,19L,19L,19L,20L,20L,22L,20L,23L,22L,23L,23L,23L,24L,24L,28L,24L,25L,29L,25L,29L,30L,29L,31L,30L,30L,32L,32L,32L,33L,33L,33L,35L,34L,36L,36L,36L,37L,38L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287292Inst : IEnumerable<long>
{
public static readonly long[] Value=A287292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287292.Bytes);
public long this[int i]=>Value[i];

public static A287292Inst Instance=new A287292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287293
{
public static readonly long[] Value={ 2L,2L,4L,4L,8L,8L,8L,8L,16L,16L,16L,16L,32L,32L,32L,32L,32L,32L,32L,32L,64L,64L,64L,64L,64L,64L,64L,64L,128L,128L,128L,128L,128L,128L,128L,128L,256L,256L,256L,256L,256L,256L,256L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287293Inst : IEnumerable<long>
{
public static readonly long[] Value=A287293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287293.Bytes);
public long this[int i]=>Value[i];

public static A287293Inst Instance=new A287293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287294
{
public static readonly BigInteger[] Value={ 1L,313L,53135L,7531357L,975313579L,1197531357911L,13119753135791113L,BigInteger.Parse("151311975313579111315"),BigInteger.Parse("1715131197531357911131517"),BigInteger.Parse("19171513119753135791113151719"),BigInteger.Parse("211917151311975313579111315171921"),BigInteger.Parse("2321191715131197531357911131517192123") };
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
public class A287294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287294Inst Instance=new A287294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287295
{
public static readonly BigInteger[] Value={ 1L,11L,131L,1331L,13531L,135531L,1357531L,13577531L,135797531L,1357997531L,135791197531L,13579111197531L,1357911131197531L,135791113131197531L,13579111315131197531UL,BigInteger.Parse("1357911131515131197531"),BigInteger.Parse("135791113151715131197531"),BigInteger.Parse("13579111315171715131197531") };
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
public class A287295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287295Inst Instance=new A287295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287296
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,16L,31L,33L,93L,289L,304L,921L,3946L,4506L,4978L,5481L,7114L,13512L,14703L,14823L,16851L,26662L,1183L,77377L,82417L,95316L,98982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287296Inst : IEnumerable<long>
{
public static readonly long[] Value=A287296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287296.Bytes);
public long this[int i]=>Value[i];

public static A287296Inst Instance=new A287296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287297
{
public static readonly long[] Value={ 161038L,9115426L,143742226L,665387746L,1105826338L,3434672242L,11675882626L,16732427362L,18411253246L,81473324626L,85898088046L,98730252226L,134744844466L,136767694402L,161097973246L,183689075122L,315554044786L,553588254766L,778581406786L,1077392692846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287297Inst : IEnumerable<long>
{
public static readonly long[] Value=A287297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287297.Bytes);
public long this[int i]=>Value[i];

public static A287297Inst Instance=new A287297Inst();

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