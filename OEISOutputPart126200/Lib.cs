using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160164
{
public static readonly long[] Value={ 0L,2L,6L,14L,22L,30L,46L,70L,86L,94L,110L,134L,158L,190L,246L,310L,342L,350L,366L,390L,414L,446L,502L,566L,606L,638L,694L,766L,846L,966L,1142L,1302L,1366L,1374L,1390L,1414L,1438L,1470L,1526L,1590L,1630L,1662L,1718L,1790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160164Inst : IEnumerable<long>
{
public static readonly long[] Value=A160164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160164.Bytes);
public long this[int i]=>Value[i];

public static A160164Inst Instance=new A160164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160165
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,3L,0L,2L,10L,15L,17L,21L,22L,12L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160165Inst : IEnumerable<long>
{
public static readonly long[] Value=A160165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160165.Bytes);
public long this[int i]=>Value[i];

public static A160165Inst Instance=new A160165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160166
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,5L,6L,7L,2L,4L,2L,6L,8L,23L,28L,29L,16L,14L,4L,4L,-2L,9L,7L,9L,-1L,9L,10L,31L,54L,103L,120L,121L,92L,82L,56L,48L,26L,29L,11L,5L,-21L,-19L,-34L,-21L,-14L,27L,29L,27L,-7L,-9L,-32L,-23L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160166Inst : IEnumerable<long>
{
public static readonly long[] Value=A160166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160166.Bytes);
public long this[int i]=>Value[i];

public static A160166Inst Instance=new A160166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160167
{
public static readonly long[] Value={ 0L,3L,12L,21L,48L,57L,84L,111L,174L,201L,228L,255L,318L,363L,426L,507L,660L,741L,768L,795L,858L,903L,966L,1047L,1200L,1299L,1362L,1443L,1596L,1749L,1920L,2127L,2478L,2721L,2784L,2811L,2874L,2919L,2982L,3063L,3216L,3315L,3378L,3459L,3612L,3765L,3936L,4143L,4494L,4755L,4854L,4935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160167Inst : IEnumerable<long>
{
public static readonly long[] Value=A160167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160167.Bytes);
public long this[int i]=>Value[i];

public static A160167Inst Instance=new A160167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160168
{
public static readonly long[] Value={ 2L,1L,0L,4L,7L,5L,3L,8L,11L,10L,6L,13L,16L,14L,9L,17L,20L,19L,12L,22L,25L,23L,15L,26L,29L,28L,18L,31L,34L,32L,21L,35L,38L,37L,24L,40L,43L,41L,27L,44L,47L,46L,30L,49L,52L,50L,33L,53L,56L,55L,36L,58L,61L,59L,39L,62L,65L,64L,42L,67L,70L,68L,45L,71L,74L,73L,48L,76L,79L,77L,51L,80L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160168Inst : IEnumerable<long>
{
public static readonly long[] Value=A160168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160168.Bytes);
public long this[int i]=>Value[i];

public static A160168Inst Instance=new A160168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160169
{
public static readonly long[] Value={ 2L,1L,3L,0L,7L,11L,6L,5L,15L,4L,19L,23L,10L,9L,27L,8L,31L,35L,14L,13L,39L,12L,43L,47L,18L,17L,51L,16L,55L,59L,22L,21L,63L,20L,67L,71L,26L,25L,75L,24L,79L,83L,30L,29L,87L,28L,91L,95L,34L,33L,99L,32L,103L,107L,38L,37L,111L,36L,115L,119L,42L,41L,123L,40L,127L,131L,46L,45L,135L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160169Inst : IEnumerable<long>
{
public static readonly long[] Value=A160169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160169.Bytes);
public long this[int i]=>Value[i];

public static A160169Inst Instance=new A160169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160170
{
public static readonly long[] Value={ 0L,1L,5L,13L,21L,45L,77L,109L,165L,245L,325L,413L,525L,685L,853L,1093L,1317L,1661L,1981L,2301L,2645L,3093L,3621L,4157L,4861L,5565L,6437L,7173L,8053L,8893L,9917L,11005L,12261L,13589L,14981L,16397L,17837L,19341L,20997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160170Inst : IEnumerable<long>
{
public static readonly long[] Value=A160170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160170.Bytes);
public long this[int i]=>Value[i];

public static A160170Inst Instance=new A160170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160171
{
public static readonly long[] Value={ 0L,1L,4L,8L,8L,24L,32L,32L,56L,80L,80L,88L,112L,160L,168L,240L,224L,344L,320L,320L,344L,448L,528L,536L,704L,704L,872L,736L,880L,840L,1024L,1088L,1256L,1328L,1392L,1416L,1440L,1504L,1656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160171Inst : IEnumerable<long>
{
public static readonly long[] Value=A160171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160171.Bytes);
public long this[int i]=>Value[i];

public static A160171Inst Instance=new A160171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160172
{
public static readonly long[] Value={ 0L,1L,4L,9L,18L,27L,36L,49L,74L,95L,104L,117L,142L,167L,192L,229L,302L,359L,368L,381L,406L,431L,456L,493L,566L,627L,652L,689L,762L,835L,908L,1017L,1234L,1399L,1408L,1421L,1446L,1471L,1496L,1533L,1606L,1667L,1692L,1729L,1802L,1875L,1948L,2057L,2274L,2443L,2468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160172Inst : IEnumerable<long>
{
public static readonly long[] Value=A160172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160172.Bytes);
public long this[int i]=>Value[i];

public static A160172Inst Instance=new A160172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160173
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,9L,9L,13L,25L,21L,9L,13L,25L,25L,25L,37L,73L,57L,9L,13L,25L,25L,25L,37L,73L,61L,25L,37L,73L,73L,73L,109L,217L,165L,9L,13L,25L,25L,25L,37L,73L,61L,25L,37L,73L,73L,73L,109L,217L,169L,25L,37L,73L,73L,73L,109L,217L,181L,73L,109L,217L,217L,217L,325L,649L,489L,9L,13L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160173Inst : IEnumerable<long>
{
public static readonly long[] Value=A160173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160173.Bytes);
public long this[int i]=>Value[i];

public static A160173Inst Instance=new A160173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160174
{
public static readonly long[] Value={ 1L,93L,545L,1645L,3681L,6941L,11713L,18285L,26945L,37981L,51681L,68333L,88225L,111645L,138881L,170221L,205953L,246365L,291745L,342381L,398561L,460573L,528705L,603245L,684481L,772701L,868193L,971245L,1082145L,1201181L,1328641L,1464813L,1609985L,1764445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160174Inst : IEnumerable<long>
{
public static readonly long[] Value=A160174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160174.Bytes);
public long this[int i]=>Value[i];

public static A160174Inst Instance=new A160174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160175
{
public static readonly long[] Value={ 1L,2L,6L,18L,54L,160L,476L,1416L,4212L,12528L,37264L,110840L,329688L,980640L,2916864L,8676064L,25806512L,76760160L,228319200L,679123872L,2020019488L,6008445440L,17871816000L,53158809600L,158118181056L,470314504192L,1398926621696L,4161036233088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160175Inst : IEnumerable<long>
{
public static readonly long[] Value=A160175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160175.Bytes);
public long this[int i]=>Value[i];

public static A160175Inst Instance=new A160175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160176
{
public static readonly long[] Value={ 533L,617L,733L,2465L,3085L,3865L,14257L,17893L,22457L,83077L,104273L,130877L,484205L,607745L,762805L,2822153L,3542197L,4445953L,16448713L,20645437L,25912913L,95870125L,120330425L,151031525L,558772037L,701337113L,880276237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160176Inst : IEnumerable<long>
{
public static readonly long[] Value=A160176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160176.Bytes);
public long this[int i]=>Value[i];

public static A160176Inst Instance=new A160176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160177
{
public static readonly long[] Value={ 1L,2L,5L,5L,1L,3L,9L,9L,6L,1L,4L,8L,6L,7L,2L,5L,2L,9L,1L,5L,3L,9L,9L,8L,1L,9L,6L,5L,0L,2L,5L,8L,8L,2L,9L,9L,4L,9L,0L,5L,9L,4L,3L,5L,7L,7L,8L,5L,6L,8L,7L,9L,7L,5L,2L,5L,4L,0L,7L,9L,0L,8L,8L,1L,3L,5L,9L,9L,2L,4L,2L,2L,6L,6L,5L,5L,1L,2L,2L,6L,9L,6L,7L,3L,4L,2L,6L,0L,5L,4L,0L,4L,0L,9L,6L,6L,6L,3L,8L,1L,3L,1L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160177Inst : IEnumerable<long>
{
public static readonly long[] Value=A160177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160177.Bytes);
public long this[int i]=>Value[i];

public static A160177Inst Instance=new A160177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160178
{
public static readonly long[] Value={ 3L,6L,9L,9L,7L,0L,4L,6L,6L,1L,0L,0L,4L,2L,5L,4L,0L,4L,0L,5L,3L,1L,2L,1L,0L,1L,9L,5L,0L,4L,9L,6L,7L,0L,5L,1L,7L,6L,9L,3L,0L,0L,4L,0L,1L,3L,4L,9L,3L,2L,7L,3L,8L,7L,3L,7L,4L,1L,4L,1L,4L,8L,5L,5L,9L,6L,4L,5L,4L,4L,0L,6L,6L,0L,0L,5L,5L,3L,8L,4L,9L,1L,4L,6L,8L,0L,5L,9L,6L,9L,5L,2L,3L,6L,4L,9L,0L,0L,0L,0L,6L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160178Inst : IEnumerable<long>
{
public static readonly long[] Value=A160178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160178.Bytes);
public long this[int i]=>Value[i];

public static A160178Inst Instance=new A160178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160179
{
public static readonly long[] Value={ 2L,2L,2L,4L,8L,128L,8192L,134217728L,9007199254740992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160179Inst : IEnumerable<long>
{
public static readonly long[] Value=A160179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160179.Bytes);
public long this[int i]=>Value[i];

public static A160179Inst Instance=new A160179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160180
{
public static readonly long[] Value={ 2L,3L,4L,3L,5L,6L,7L,5L,8L,9L,10L,7L,11L,12L,5L,13L,9L,14L,15L,16L,11L,17L,7L,18L,19L,13L,20L,21L,22L,15L,23L,24L,7L,25L,17L,26L,27L,11L,28L,19L,29L,30L,31L,21L,32L,13L,33L,34L,23L,35L,36L,37L,25L,38L,11L,39L,40L,27L,41L,42L,17L,43L,29L,44L,45L,13L,46L,31L,47L,19L,48L,49L,33L,50L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160180Inst : IEnumerable<long>
{
public static readonly long[] Value=A160180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160180.Bytes);
public long this[int i]=>Value[i];

public static A160180Inst Instance=new A160180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160181
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,18L,59L,221L,936L,4361L,22083L,120336L,700653L,4333933L,28345090L,195233255L,1411303635L,10675375402L,84276173439L,692752181561L,5917018378496L,52416910416933L,480786834535250L,4559132648864259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160181Inst : IEnumerable<long>
{
public static readonly long[] Value=A160181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160181.Bytes);
public long this[int i]=>Value[i];

public static A160181Inst Instance=new A160181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160182
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,5L,2L,1L,1L,1L,6L,2L,1L,1L,1L,1L,10L,4L,2L,1L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,1L,16L,6L,3L,2L,1L,1L,1L,1L,1L,19L,7L,4L,2L,1L,1L,1L,1L,1L,1L,26L,10L,5L,3L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160182Inst : IEnumerable<long>
{
public static readonly long[] Value=A160182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160182.Bytes);
public long this[int i]=>Value[i];

public static A160182Inst Instance=new A160182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160183
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,5L,2L,1L,1L,6L,2L,1L,1L,1L,10L,4L,2L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,16L,6L,3L,2L,1L,1L,1L,1L,19L,7L,4L,2L,1L,1L,1L,1L,1L,26L,10L,5L,3L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160183Inst : IEnumerable<long>
{
public static readonly long[] Value=A160183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160183.Bytes);
public long this[int i]=>Value[i];

public static A160183Inst Instance=new A160183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160184
{
public static readonly BigInteger[] Value={ 1L,1L,-391L,-1175L,458641L,2301041L,-896635319L,-6308683751L,2454058631585L,22238090874721L,-8635680761357159L,-95808996990263479L,BigInteger.Parse("37141246445981806129"),BigInteger.Parse("487826768288181211345"),BigInteger.Parse("-188783965120435102822039"),BigInteger.Parse("-2865977269485973590683399"),BigInteger.Parse("1107183737638672431002905921") };
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
public class A160184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160184Inst Instance=new A160184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160185
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,15L,9L,4L,1L,52L,31L,14L,5L,1L,203L,121L,54L,20L,6L,1L,877L,523L,233L,85L,27L,7L,1L,4140L,2469L,1101L,400L,125L,35L,8L,1L,21147L,12611L,5625L,2046L,635L,175L,44L,9L,1L,115975L,69161L,30846L,11226L,3488L,952L,236L,54L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160185Inst : IEnumerable<long>
{
public static readonly long[] Value=A160185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160185.Bytes);
public long this[int i]=>Value[i];

public static A160185Inst Instance=new A160185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160186
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,6L,8L,9L,12L,11L,13L,14L,17L,16L,18L,19L,22L,21L,23L,24L,27L,26L,28L,29L,32L,31L,33L,34L,37L,36L,38L,39L,42L,41L,43L,44L,47L,46L,48L,49L,52L,51L,53L,54L,57L,56L,58L,59L,62L,61L,63L,64L,67L,66L,68L,69L,72L,71L,73L,74L,77L,76L,78L,79L,82L,81L,83L,84L,87L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160186Inst : IEnumerable<long>
{
public static readonly long[] Value=A160186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160186.Bytes);
public long this[int i]=>Value[i];

public static A160186Inst Instance=new A160186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160187
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,5L,0L,11L,17L,10L,9L,13L,16L,23L,15L,8L,29L,19L,6L,25L,31L,14L,21L,35L,20L,37L,27L,22L,43L,41L,12L,47L,53L,28L,33L,49L,34L,59L,39L,26L,65L,55L,18L,61L,67L,32L,45L,71L,38L,73L,51L,40L,79L,77L,24L,83L,89L,46L,57L,85L,52L,95L,63L,44L,101L,91L,30L,97L,103L,50L,69L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160187Inst : IEnumerable<long>
{
public static readonly long[] Value=A160187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160187.Bytes);
public long this[int i]=>Value[i];

public static A160187Inst Instance=new A160187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160188
{
public static readonly long[] Value={ 2L,1L,3L,4L,0L,11L,18L,8L,5L,6L,25L,10L,7L,17L,24L,13L,9L,15L,31L,32L,14L,39L,46L,22L,12L,20L,53L,38L,21L,45L,52L,27L,16L,29L,59L,60L,28L,67L,74L,36L,19L,34L,81L,66L,35L,73L,80L,41L,23L,43L,87L,88L,42L,95L,102L,50L,26L,48L,109L,94L,49L,101L,108L,55L,30L,57L,115L,116L,56L,123L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160188Inst : IEnumerable<long>
{
public static readonly long[] Value=A160188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160188.Bytes);
public long this[int i]=>Value[i];

public static A160188Inst Instance=new A160188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160189
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,8L,17L,36L,66L,115L,202L,340L,569L,944L,1550L,2531L,4122L,6704L,10879L,17640L,28584L,46289L,74942L,121304L,196321L,317710L,514126L,831933L,1346160L,2178196L,3524451L,5702756L,9227328L,14930213L,24157668L,39088018L,63245829L,102333992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160189Inst : IEnumerable<long>
{
public static readonly long[] Value=A160189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160189.Bytes);
public long this[int i]=>Value[i];

public static A160189Inst Instance=new A160189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160190
{
public static readonly long[] Value={ 4L,9L,25L,56L,143L,273L,578L,1045L,2047L,4176L,7223L,13949L,25010L,42441L,75059L,136952L,246679L,412665L,733382L,1257481L,2091961L,3663072L,6227075L,10803977L,19052546L,32098911L,52965587L,89028280L,146743321L,246148917L,447621406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160190Inst : IEnumerable<long>
{
public static readonly long[] Value=A160190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160190.Bytes);
public long this[int i]=>Value[i];

public static A160190Inst Instance=new A160190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160191
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,11L,10L,5L,15L,12L,19L,23L,18L,9L,27L,20L,31L,35L,26L,13L,39L,28L,43L,47L,34L,17L,51L,36L,55L,59L,42L,21L,63L,44L,67L,71L,50L,25L,75L,52L,79L,83L,58L,29L,87L,60L,91L,95L,66L,33L,99L,68L,103L,107L,74L,37L,111L,76L,115L,119L,82L,41L,123L,84L,127L,131L,90L,45L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160191Inst : IEnumerable<long>
{
public static readonly long[] Value=A160191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160191.Bytes);
public long this[int i]=>Value[i];

public static A160191Inst Instance=new A160191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160192
{
public static readonly BigInteger[] Value={ 1L,3L,-383L,-3501L,439905L,6809283L,-841785951L,-18540791469L,2254238275137L,64906636872195L,-7758232724066751L,-277708714711204653L,BigInteger.Parse("32620373362042216353"),BigInteger.Parse("1404202914087633336771"),BigInteger.Parse("-162020813910704234524575"),BigInteger.Parse("-8192328034245044455772973"),BigInteger.Parse("928105401692205765637182081") };
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
public class A160192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160192Inst Instance=new A160192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160193
{
public static readonly BigInteger[] Value={ 1L,5L,-367L,-5755L,402817L,11037925L,-734331695L,-29632858075L,1866841880705L,102262852326725L,-6074903893493615L,-431244900588230075L,BigInteger.Parse("24038761085803317505"),BigInteger.Parse("2148769817796050860325"),BigInteger.Parse("-111757677404273451703855"),BigInteger.Parse("-12351237147086094379982875"),BigInteger.Parse("595378957401697424118753025") };
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
public class A160193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160193Inst Instance=new A160193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160194
{
public static readonly BigInteger[] Value={ 1L,9L,-311L,-9855L,277041L,17946009L,-381486279L,-45642389679L,636016842465L,148858685615529L,-904139249676759L,-591663300859964511L,-1426321263133495791L,BigInteger.Parse("2770347275877071597625"),BigInteger.Parse("32201658639821938929561"),BigInteger.Parse("-14913850922254971477399951"),BigInteger.Parse("-323570411102447744202418239") };
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
public class A160194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160194Inst Instance=new A160194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160195
{
public static readonly BigInteger[] Value={ 1L,11L,-271L,-11605L,191041L,20298091L,-151161359L,-49403884981L,-128655965695L,153515367677771L,2142567291427441L,-578212001091160469L,BigInteger.Parse("-15599082172637890751"),BigInteger.Parse("2548319349233802047915"),BigInteger.Parse("107524435593334513794161"),BigInteger.Parse("-12802407797068425987221749") };
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
public class A160195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160195Inst Instance=new A160195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160196
{
public static readonly BigInteger[] Value={ 1L,13L,-223L,-13091L,92065L,21723533L,101958529L,-49768288739L,-926761957183L,144025448042125L,5141947009489249L,-497734445201769763L,BigInteger.Parse("-28642623292540648607"),BigInteger.Parse("1968988727426096533261"),BigInteger.Parse("171559661755326400233665"),BigInteger.Parse("-8575534533295174571498723"),BigInteger.Parse("-1120252760054156502803433599") };
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
public class A160196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160196Inst Instance=new A160196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160197
{
public static readonly BigInteger[] Value={ 1L,15L,-167L,-14265L,-17583L,22103775L,366019305L,-46497789225L,-1701823811295L,120289709840175L,7808380053851385L,-354409961765715225L,BigInteger.Parse("-38985884218692900495"),BigInteger.Parse("1082356196865530910975"),BigInteger.Parse("214907408931441984587145"),BigInteger.Parse("-2716359674426403870623625") };
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
public class A160197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160197Inst Instance=new A160197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160198
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,3L,1L,2L,1L,2L,1L,3L,1L,3L,1L,3L,1L,2L,1L,13L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160198Inst : IEnumerable<long>
{
public static readonly long[] Value=A160198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160198.Bytes);
public long this[int i]=>Value[i];

public static A160198Inst Instance=new A160198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160199
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,1L,4L,1L,10L,1L,24L,1L,14L,15L,8L,1L,54L,1L,40L,21L,22L,1L,2304L,1L,26L,9L,56L,1L,27000L,1L,512L,33L,34L,35L,216L,1L,38L,39L,6400L,1L,74088L,1L,88L,135L,46L,1L,73728L,1L,250L,51L,104L,1L,26244L,55L,12544L,57L,58L,1L,25920000L,1L,62L,189L,512L,65L,287496L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160199Inst : IEnumerable<long>
{
public static readonly long[] Value=A160199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160199.Bytes);
public long this[int i]=>Value[i];

public static A160199Inst Instance=new A160199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160200
{
public static readonly long[] Value={ 541L,761L,1465L,1781L,3805L,8249L,10145L,22069L,48029L,59089L,128609L,279925L,344389L,749585L,1631521L,2007245L,4368901L,9509201L,11699081L,25463821L,55423685L,68187241L,148414025L,323032909L,397424365L,865020329L,1882773769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160200Inst : IEnumerable<long>
{
public static readonly long[] Value=A160200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160200.Bytes);
public long this[int i]=>Value[i];

public static A160200Inst Instance=new A160200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160201
{
public static readonly long[] Value={ 2L,1L,7L,6L,5L,6L,5L,9L,2L,0L,9L,1L,5L,0L,7L,2L,1L,5L,8L,4L,0L,5L,2L,3L,0L,2L,1L,1L,0L,1L,8L,2L,3L,9L,8L,3L,2L,1L,9L,3L,4L,1L,4L,4L,6L,3L,1L,0L,6L,6L,3L,6L,0L,1L,8L,1L,4L,4L,0L,5L,5L,2L,4L,1L,7L,2L,3L,6L,7L,7L,2L,7L,3L,3L,8L,9L,6L,1L,0L,3L,1L,7L,9L,3L,5L,4L,5L,2L,0L,9L,0L,4L,8L,5L,3L,7L,5L,0L,4L,1L,5L,2L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160201Inst : IEnumerable<long>
{
public static readonly long[] Value=A160201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160201.Bytes);
public long this[int i]=>Value[i];

public static A160201Inst Instance=new A160201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160202
{
public static readonly long[] Value={ 1L,2L,3L,0L,2L,9L,0L,6L,4L,1L,9L,9L,8L,0L,0L,6L,3L,2L,0L,9L,2L,6L,8L,3L,6L,9L,6L,2L,8L,5L,9L,2L,2L,3L,8L,4L,5L,0L,3L,4L,0L,7L,4L,7L,6L,6L,0L,0L,4L,8L,0L,8L,6L,1L,0L,6L,3L,4L,0L,4L,0L,6L,0L,7L,4L,7L,9L,2L,1L,7L,3L,4L,9L,7L,3L,1L,7L,2L,0L,9L,7L,9L,6L,6L,8L,9L,3L,5L,2L,0L,6L,3L,8L,9L,0L,9L,3L,3L,7L,8L,3L,3L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160202Inst : IEnumerable<long>
{
public static readonly long[] Value=A160202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160202.Bytes);
public long this[int i]=>Value[i];

public static A160202Inst Instance=new A160202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160203
{
public static readonly long[] Value={ 641L,809L,1105L,2741L,4045L,5989L,15805L,23461L,34829L,92089L,136721L,202985L,536729L,796865L,1183081L,3128285L,4644469L,6895501L,18232981L,27069949L,40189925L,106269601L,157775225L,234244049L,619384625L,919581401L,1365274369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160203Inst : IEnumerable<long>
{
public static readonly long[] Value=A160203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160203.Bytes);
public long this[int i]=>Value[i];

public static A160203Inst Instance=new A160203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160204
{
public static readonly long[] Value={ 1L,4L,8L,4L,6L,6L,9L,4L,0L,2L,3L,1L,2L,1L,8L,5L,4L,7L,7L,5L,3L,0L,2L,7L,4L,1L,4L,5L,8L,7L,9L,6L,6L,6L,1L,9L,8L,0L,5L,7L,0L,6L,2L,8L,8L,6L,3L,8L,7L,4L,5L,6L,0L,6L,0L,5L,4L,0L,1L,6L,0L,3L,2L,0L,4L,1L,2L,6L,6L,9L,8L,8L,2L,5L,7L,5L,0L,4L,1L,8L,2L,0L,7L,8L,2L,8L,0L,5L,8L,1L,9L,4L,8L,5L,8L,0L,0L,7L,9L,7L,1L,2L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160204Inst : IEnumerable<long>
{
public static readonly long[] Value=A160204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160204.Bytes);
public long this[int i]=>Value[i];

public static A160204Inst Instance=new A160204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160205
{
public static readonly long[] Value={ 2L,6L,4L,4L,1L,8L,5L,1L,0L,3L,7L,1L,9L,7L,1L,6L,7L,0L,9L,4L,2L,1L,0L,2L,1L,9L,4L,2L,9L,9L,7L,0L,6L,8L,9L,3L,1L,1L,3L,9L,4L,2L,8L,9L,7L,0L,1L,1L,7L,3L,8L,7L,9L,7L,4L,2L,7L,7L,8L,0L,7L,7L,5L,9L,8L,2L,5L,8L,5L,3L,8L,9L,9L,9L,4L,7L,9L,9L,5L,8L,6L,3L,1L,9L,0L,4L,2L,7L,9L,8L,6L,4L,1L,1L,0L,4L,4L,6L,7L,0L,4L,5L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160205Inst : IEnumerable<long>
{
public static readonly long[] Value=A160205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160205.Bytes);
public long this[int i]=>Value[i];

public static A160205Inst Instance=new A160205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160206
{
public static readonly long[] Value={ 697L,857L,1117L,3065L,4285L,6005L,17693L,24853L,34913L,103093L,144833L,203473L,600865L,844145L,1185925L,3502097L,4920037L,6912077L,20411717L,28676077L,40286537L,118968205L,167136425L,234807145L,693397513L,974142473L,1368556333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160206Inst : IEnumerable<long>
{
public static readonly long[] Value=A160206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160206.Bytes);
public long this[int i]=>Value[i];

public static A160206Inst Instance=new A160206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160207
{
public static readonly long[] Value={ 1L,4L,0L,4L,8L,8L,3L,1L,3L,6L,6L,3L,7L,5L,1L,4L,5L,3L,9L,3L,7L,9L,6L,4L,3L,6L,7L,8L,0L,4L,4L,3L,8L,3L,4L,2L,6L,4L,8L,7L,3L,1L,7L,4L,9L,5L,7L,1L,6L,6L,3L,8L,3L,8L,4L,3L,2L,5L,6L,7L,4L,1L,4L,8L,1L,6L,5L,7L,5L,7L,0L,8L,3L,4L,0L,3L,7L,8L,3L,5L,2L,1L,7L,7L,1L,9L,7L,3L,6L,0L,8L,1L,7L,8L,3L,0L,1L,9L,0L,2L,3L,0L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160207Inst : IEnumerable<long>
{
public static readonly long[] Value=A160207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160207.Bytes);
public long this[int i]=>Value[i];

public static A160207Inst Instance=new A160207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160208
{
public static readonly long[] Value={ 2L,9L,5L,3L,0L,5L,1L,1L,6L,4L,6L,1L,0L,0L,9L,8L,2L,1L,0L,4L,1L,4L,0L,5L,5L,7L,5L,8L,4L,1L,7L,5L,7L,7L,5L,4L,7L,4L,9L,9L,1L,7L,5L,1L,6L,8L,6L,1L,2L,3L,2L,2L,6L,4L,4L,6L,2L,4L,7L,9L,7L,6L,1L,9L,9L,4L,0L,4L,8L,9L,3L,7L,8L,4L,5L,0L,2L,3L,7L,2L,5L,5L,8L,4L,8L,4L,9L,7L,8L,3L,7L,8L,7L,4L,7L,6L,1L,4L,2L,7L,4L,3L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160208Inst : IEnumerable<long>
{
public static readonly long[] Value=A160208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160208.Bytes);
public long this[int i]=>Value[i];

public static A160208Inst Instance=new A160208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160209
{
public static readonly long[] Value={ 673L,937L,1685L,2353L,4685L,9437L,13445L,27173L,54937L,78317L,158353L,320185L,456457L,922945L,1866173L,2660425L,5379317L,10876853L,15506093L,31352957L,63394945L,90376133L,182738425L,369492817L,526750705L,1065077593L,2153561957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160209Inst : IEnumerable<long>
{
public static readonly long[] Value=A160209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160209.Bytes);
public long this[int i]=>Value[i];

public static A160209Inst Instance=new A160209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160210
{
public static readonly long[] Value={ 2L,0L,2L,1L,9L,7L,6L,5L,8L,7L,5L,7L,8L,2L,1L,3L,5L,4L,8L,2L,3L,2L,2L,8L,8L,6L,8L,1L,3L,7L,6L,8L,4L,8L,6L,9L,5L,5L,7L,7L,6L,4L,5L,6L,4L,4L,5L,4L,7L,2L,0L,9L,9L,5L,2L,0L,0L,3L,6L,2L,8L,5L,4L,5L,8L,0L,9L,2L,9L,6L,3L,0L,1L,0L,6L,9L,1L,8L,4L,8L,0L,4L,3L,3L,1L,1L,5L,9L,1L,1L,6L,7L,2L,3L,3L,5L,8L,2L,0L,2L,5L,6L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160210Inst : IEnumerable<long>
{
public static readonly long[] Value=A160210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160210.Bytes);
public long this[int i]=>Value[i];

public static A160210Inst Instance=new A160210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160211
{
public static readonly long[] Value={ 1L,4L,2L,5L,6L,0L,4L,7L,2L,2L,9L,1L,9L,9L,9L,9L,5L,1L,1L,6L,6L,8L,1L,1L,2L,6L,4L,9L,5L,4L,1L,5L,0L,3L,5L,7L,6L,4L,3L,2L,7L,0L,7L,7L,4L,1L,9L,4L,8L,7L,2L,6L,1L,4L,1L,5L,6L,6L,2L,7L,4L,4L,6L,3L,9L,7L,8L,8L,3L,3L,9L,0L,8L,6L,8L,4L,3L,2L,6L,3L,7L,6L,4L,5L,1L,6L,3L,7L,5L,9L,8L,5L,2L,7L,0L,9L,5L,9L,7L,7L,1L,9L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160211Inst : IEnumerable<long>
{
public static readonly long[] Value=A160211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160211.Bytes);
public long this[int i]=>Value[i];

public static A160211Inst Instance=new A160211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160212
{
public static readonly long[] Value={ 845L,953L,1093L,3977L,4765L,5713L,23017L,27637L,33185L,134125L,161057L,193397L,781733L,938705L,1127197L,4556273L,5471173L,6569785L,26555905L,31888333L,38291513L,154779157L,185858825L,223179293L,902119037L,1083264617L,1300784245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160212Inst : IEnumerable<long>
{
public static readonly long[] Value=A160212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160212.Bytes);
public long this[int i]=>Value[i];

public static A160212Inst Instance=new A160212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160213
{
public static readonly long[] Value={ 1L,2L,0L,0L,8L,0L,0L,0L,8L,5L,7L,6L,5L,2L,2L,9L,5L,7L,6L,1L,2L,9L,4L,9L,5L,6L,9L,9L,6L,8L,7L,3L,0L,5L,9L,4L,0L,9L,6L,8L,1L,4L,1L,9L,8L,5L,8L,8L,3L,2L,5L,4L,5L,2L,3L,6L,8L,7L,2L,0L,7L,0L,1L,7L,3L,2L,5L,1L,3L,2L,0L,3L,2L,8L,7L,4L,3L,9L,7L,9L,7L,7L,7L,7L,2L,7L,6L,8L,1L,5L,7L,6L,6L,6L,9L,7L,5L,3L,9L,8L,7L,6L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160213Inst : IEnumerable<long>
{
public static readonly long[] Value=A160213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160213.Bytes);
public long this[int i]=>Value[i];

public static A160213Inst Instance=new A160213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160214
{
public static readonly long[] Value={ 4L,0L,4L,2L,1L,2L,6L,9L,5L,9L,3L,4L,0L,8L,4L,8L,4L,0L,1L,6L,5L,0L,2L,4L,7L,5L,6L,8L,0L,8L,4L,3L,0L,1L,0L,9L,3L,4L,2L,2L,7L,2L,4L,8L,1L,7L,1L,1L,5L,9L,4L,7L,3L,8L,4L,0L,1L,0L,7L,8L,6L,6L,0L,7L,4L,2L,6L,6L,2L,4L,9L,4L,8L,3L,1L,1L,7L,7L,9L,3L,4L,3L,4L,8L,6L,8L,0L,6L,1L,2L,7L,9L,9L,7L,9L,4L,7L,5L,8L,6L,9L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160214Inst : IEnumerable<long>
{
public static readonly long[] Value=A160214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160214.Bytes);
public long this[int i]=>Value[i];

public static A160214Inst Instance=new A160214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160215
{
public static readonly long[] Value={ 2L,5L,13L,17L,29L,37L,53L,61L,101L,109L,113L,149L,157L,173L,181L,193L,197L,229L,241L,257L,269L,277L,293L,317L,337L,349L,373L,389L,397L,401L,421L,433L,449L,461L,509L,541L,557L,577L,593L,613L,653L,661L,677L,701L,709L,733L,757L,769L,773L,797L,821L,829L,853L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160215Inst : IEnumerable<long>
{
public static readonly long[] Value=A160215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160215.Bytes);
public long this[int i]=>Value[i];

public static A160215Inst Instance=new A160215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160216
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,31L,41L,43L,47L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,127L,131L,137L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,233L,239L,251L,263L,271L,281L,283L,307L,311L,313L,331L,347L,353L,359L,367L,379L,383L,409L,419L,431L,439L,443L,457L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160216Inst : IEnumerable<long>
{
public static readonly long[] Value=A160216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160216.Bytes);
public long this[int i]=>Value[i];

public static A160216Inst Instance=new A160216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160217
{
public static readonly long[] Value={ 3L,6L,7L,9L,11L,14L,15L,18L,19L,22L,23L,25L,27L,30L,31L,33L,35L,38L,39L,41L,43L,46L,47L,50L,51L,54L,55L,57L,59L,62L,63L,66L,67L,70L,71L,73L,75L,78L,79L,82L,83L,86L,87L,89L,91L,94L,95L,97L,99L,102L,103L,105L,107L,110L,111L,114L,115L,118L,119L,121L,123L,126L,127L,129L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160217Inst : IEnumerable<long>
{
public static readonly long[] Value=A160217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160217.Bytes);
public long this[int i]=>Value[i];

public static A160217Inst Instance=new A160217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160218
{
public static readonly long[] Value={ 2L,3L,14L,20L,32L,301L,1065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160218Inst : IEnumerable<long>
{
public static readonly long[] Value=A160218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160218.Bytes);
public long this[int i]=>Value[i];

public static A160218Inst Instance=new A160218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160219
{
public static readonly BigInteger[] Value={ 1L,17L,-103L,-15079L,-135215L,21345217L,627890089L,-39529818871L,-2394937325023L,83251577454065L,9864615699400249L,-158647716730130567L,BigInteger.Parse("-45233234080226093327"),BigInteger.Parse("-22686119865309399391"),BigInteger.Parse("230122896835121911804745"),BigInteger.Parse("4036590672017890484538473") };
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
public class A160219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160219Inst Instance=new A160219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160220
{
public static readonly BigInteger[] Value={ 1L,19L,-31L,-15485L,-257759L,19383059L,873485761L,-28992725309L,-2947706709055L,34914759096979L,11062889692388641L,73329048495226499L,BigInteger.Parse("-46309928432170516511"),BigInteger.Parse("-1224828484332785265005"),BigInteger.Parse("212723654088018032104961"),BigInteger.Parse("10763608149690668144341699"),BigInteger.Parse("-1046306531193423334034678399") };
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
public class A160220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160220Inst Instance=new A160220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160221
{
public static readonly BigInteger[] Value={ 1L,23L,137L,-14881L,-503375L,11755783L,1256998009L,1261352591L,-3420191427103L,-82620004548745L,10166175250198249L,557692448585640127L,BigInteger.Parse("-31009621361385126767"),BigInteger.Parse("-3336606569458709073049"),BigInteger.Parse("81283079360068297324505"),BigInteger.Parse("20180807678470966231356527"),BigInteger.Parse("-13785930032369364946889279") };
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
public class A160221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160221Inst Instance=new A160221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160222
{
public static readonly BigInteger[] Value={ 1L,25L,233L,-13775L,-618383L,6139625L,1365521305L,19697634625L,-3254549595295L,-143135522066375L,7903662920541385L,758682819513724625L,BigInteger.Parse("-15113524025531336495"),BigInteger.Parse("-3946682083630844048375"),BigInteger.Parse("-21648533656663410430855"),BigInteger.Parse("21118177933549486876710625") };
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
public class A160222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160222Inst Instance=new A160222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160223
{
public static readonly BigInteger[] Value={ 1L,27L,337L,-12069L,-722175L,-574533L,1399950609L,39149968059L,-2784415333503L,-197953513837605L,4478672422983249L,896901929663959323L,4904316613023132033L,BigInteger.Parse("-4086610128587640090501"),BigInteger.Parse("-135330870931832163283695"),BigInteger.Parse("18773382870529500408009723") };
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
public class A160223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160223Inst Instance=new A160223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160224
{
public static readonly BigInteger[] Value={ 1L,2L,-1678L,-10084L,8447020L,84739192L,-70869959816L,-996927845296L,832429051182992L,15079519188668960L,BigInteger.Parse("-12571151938430794976"),BigInteger.Parse("-278779816630273497152"),BigInteger.Parse("232033893531586021651648"),BigInteger.Parse("6090959605928612309819264"),BigInteger.Parse("-5061471196749802724815296640") };
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
public class A160224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160224Inst Instance=new A160224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160225
{
public static readonly BigInteger[] Value={ 1L,4L,-1666L,-20120L,8326156L,168671984L,-69348284024L,-1979630798624L,808588172904080L,29872264717900864L,BigInteger.Parse("-12120918702550359584"),BigInteger.Parse("-550935167365293970816"),BigInteger.Parse("222057497165125577139904"),BigInteger.Parse("12008305406761595815509760"),BigInteger.Parse("-4807476011385589486479101824") };
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
public class A160225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160225Inst Instance=new A160225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160226
{
public static readonly BigInteger[] Value={ 1L,6L,-1646L,-30060L,8125356L,250995816L,-66828269064L,-2934019389456L,769231923622800L,44095556446256736L,BigInteger.Parse("-11380059521124405984"),BigInteger.Parse("-809967616552784735424"),BigInteger.Parse("205694055560527051103424"),BigInteger.Parse("17582550705864569406418560"),BigInteger.Parse("-4392210914651297082988957824") };
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
public class A160226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160226Inst Instance=new A160226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160227
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,25L,31L,41L,43L,47L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,127L,131L,137L,139L,151L,163L,167L,169L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160227Inst : IEnumerable<long>
{
public static readonly long[] Value=A160227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160227.Bytes);
public long this[int i]=>Value[i];

public static A160227Inst Instance=new A160227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160228
{
public static readonly long[] Value={ 8L,60L,512L,5015L,49923L,500279L,4997393L,49999921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160228Inst : IEnumerable<long>
{
public static readonly long[] Value=A160228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160228.Bytes);
public long this[int i]=>Value[i];

public static A160228Inst Instance=new A160228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160229
{
public static readonly long[] Value={ 2L,40L,488L,4985L,50077L,499721L,5002607L,5000079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160229Inst : IEnumerable<long>
{
public static readonly long[] Value=A160229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160229.Bytes);
public long this[int i]=>Value[i];

public static A160229Inst Instance=new A160229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160230
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,0L,0L,6L,6L,4L,4L,3L,2L,0L,0L,15L,14L,12L,12L,11L,10L,8L,8L,6L,6L,4L,4L,3L,2L,0L,0L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160230Inst : IEnumerable<long>
{
public static readonly long[] Value=A160230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160230.Bytes);
public long this[int i]=>Value[i];

public static A160230Inst Instance=new A160230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160231
{
public static readonly BigInteger[] Value={ 1L,8L,-1618L,-39856L,7845580L,330915808L,-63334001336L,-3846274345024L,714924336969872L,57474862282401920L,BigInteger.Parse("-10362725714790706976"),BigInteger.Parse("-1049628989308325950208"),BigInteger.Parse("183334119260591052868288"),BigInteger.Parse("22652384474283979401944576"),BigInteger.Parse("-3827564775957812126802428800") };
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
public class A160231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160231Inst Instance=new A160231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160232
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,4L,1L,4L,9L,12L,8L,1L,5L,14L,25L,28L,16L,1L,6L,20L,44L,66L,64L,32L,1L,7L,27L,70L,129L,168L,144L,64L,1L,8L,35L,104L,225L,360L,416L,320L,128L,1L,9L,44L,147L,363L,681L,968L,1008L,704L,256L,1L,10L,54L,200L,553L,1182L,1970L,2528L,2400L,1536L,512L,1L,11L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160232Inst : IEnumerable<long>
{
public static readonly long[] Value=A160232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160232.Bytes);
public long this[int i]=>Value[i];

public static A160232Inst Instance=new A160232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160233
{
public static readonly long[] Value={ 1280L,1600L,4800L,28672L,131072L,688128L,6881280L,7864320L,39321600L,43253760L,94371840L,201326592L,528482304L,9663676416L,115964116992L,241591910400L,265751101440L,347892350976L,811748818944L,3522410053632L,4174708211712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160233Inst : IEnumerable<long>
{
public static readonly long[] Value=A160233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160233.Bytes);
public long this[int i]=>Value[i];

public static A160233Inst Instance=new A160233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160234
{
public static readonly long[] Value={ 0L,45L,630L,6896L,73059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160234Inst : IEnumerable<long>
{
public static readonly long[] Value=A160234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160234.Bytes);
public long this[int i]=>Value[i];

public static A160234Inst Instance=new A160234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160235
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,5L,6L,9L,14L,21L,32L,54L,87L,144L,230L,383L,671L,1158L,1981L,3408L,6246L,10925L,19463L,34624L,63941L,114954L,208429L,380130L,707194L,1298600L,2379842L,4398644L,8253618L,15303057L,28453809L,53091455L,100061278L,187446097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160235Inst : IEnumerable<long>
{
public static readonly long[] Value=A160235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160235.Bytes);
public long this[int i]=>Value[i];

public static A160235Inst Instance=new A160235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160236
{
public static readonly BigInteger[] Value={ 1L,10L,-1582L,-49460L,7488172L,407648600L,-58899040520L,-4702980076400L,646447502318480L,69747774931223200L,-9088444540784918240L,BigInteger.Parse("-1264042019751023406400"),BigInteger.Parse("155513980696092323212480"),BigInteger.Parse("27068563933615579666902400"),BigInteger.Parse("-3129783062564598942695063680") };
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
public class A160236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160236Inst Instance=new A160236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160237
{
public static readonly BigInteger[] Value={ 1L,12L,-1538L,-58824L,7054860L,480426192L,-53566258296L,-5491256229216L,564794050426512L,80667872425448640L,-7581837866251154976L,BigInteger.Parse("-1447815668591059984512"),BigInteger.Parse("122905376178286149551808"),BigInteger.Parse("30697575968981388522011904"),BigInteger.Parse("-2319078043886628283835690880") };
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
public class A160237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160237Inst Instance=new A160237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160238
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,10L,12L,16L,17L,18L,20L,23L,24L,25L,32L,33L,35L,37L,40L,47L,57L,86L,112L,123L,139L,216L,322L,843L,1161L,1476L,2207L,3864L,4999L,5778L,15127L,39603L,103682L,271443L,710647L,1244196L,1860498L,4870847L,12752043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160238Inst : IEnumerable<long>
{
public static readonly long[] Value=A160238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160238.Bytes);
public long this[int i]=>Value[i];

public static A160238Inst Instance=new A160238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160239
{
public static readonly long[] Value={ 1L,8L,8L,24L,8L,64L,24L,112L,8L,64L,64L,192L,24L,192L,112L,416L,8L,64L,64L,192L,64L,512L,192L,896L,24L,192L,192L,576L,112L,896L,416L,1728L,8L,64L,64L,192L,64L,512L,192L,896L,64L,512L,512L,1536L,192L,1536L,896L,3328L,24L,192L,192L,576L,192L,1536L,576L,2688L,112L,896L,896L,2688L,416L,3328L,1728L,6784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160239Inst : IEnumerable<long>
{
public static readonly long[] Value=A160239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160239.Bytes);
public long this[int i]=>Value[i];

public static A160239Inst Instance=new A160239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160240
{
public static readonly BigInteger[] Value={ 1L,6L,78L,469L,3501L,22144L,144476L,899432L,5585508L,34092855L,206571444L,1241016042L,7407467656L,43975776229L,259779839242L,1528563721468L,8960651209082L,52368047294410L,305173796833144L,1774059940879290L,10289839706255591L,59564855651625602L,344177608427972004L,1985502681113986836L,11437008315770485918UL,BigInteger.Parse("65791536638478271291"),BigInteger.Parse("377999748832914166324"),BigInteger.Parse("2169320756101096085597"),BigInteger.Parse("12436728915873118081588"),BigInteger.Parse("71232070407411735554025") };
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
public class A160240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160240Inst Instance=new A160240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160241
{
public static readonly BigInteger[] Value={ 1L,7L,164L,1337L,16262L,144476L,1510446L,13506023L,132712481L,1185979605L,11264671456L,100572103736L,935551716239L,8347069749600L,76604373779441L,683160282998544L,6213169249692192L,55392188422262591L,500676083630457127L,4462726297606450762L,BigInteger.Parse("40165465812088131228"),BigInteger.Parse("357958181000067374304"),BigInteger.Parse("3212099862174948821718"),BigInteger.Parse("28623565473267451344466"),BigInteger.Parse("256312533945178149983147"),BigInteger.Parse("2283878397650977479239903"),BigInteger.Parse("20420964710002966369773032"),BigInteger.Parse("181952098315164452547737813"),BigInteger.Parse("1625193628709305194920610168"),BigInteger.Parse("14480051230931926406392771755") };
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
public class A160241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160241Inst Instance=new A160241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160242
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160242Inst : IEnumerable<long>
{
public static readonly long[] Value=A160242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160242.Bytes);
public long this[int i]=>Value[i];

public static A160242Inst Instance=new A160242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160243
{
public static readonly long[] Value={ 5L,7L,12L,18L,29L,42L,64L,95L,146L,228L,353L,558L,884L,1407L,2254L,3624L,5837L,9410L,15194L,24547L,39676L,64158L,103765L,167850L,271540L,439305L,710750L,1149958L,1860607L,3010462L,4870974L,7881327L,12752180L,30633378L,33385431L,54018672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160243Inst : IEnumerable<long>
{
public static readonly long[] Value=A160243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160243.Bytes);
public long this[int i]=>Value[i];

public static A160243Inst Instance=new A160243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160244
{
public static readonly long[] Value={ 6L,8L,14L,21L,34L,50L,77L,116L,180L,283L,442L,702L,1117L,1784L,2864L,4611L,7434L,11994L,19375L,31312L,50622L,81869L,132422L,214218L,346565L,560698L,907168L,1467769L,2374836L,3842502L,6217243L,10059636L,16276758L,26336265L,42612896L,68949024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160244Inst : IEnumerable<long>
{
public static readonly long[] Value=A160244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160244.Bytes);
public long this[int i]=>Value[i];

public static A160244Inst Instance=new A160244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160245
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,6L,1L,3L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,4L,1L,2L,1L,1L,3L,3L,2L,2L,3L,1L,1L,1L,5L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,4L,2L,2L,5L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,3L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,1L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160245Inst : IEnumerable<long>
{
public static readonly long[] Value=A160245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160245.Bytes);
public long this[int i]=>Value[i];

public static A160245Inst Instance=new A160245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160246
{
public static readonly BigInteger[] Value={ 1L,14L,-1486L,-67900L,6547756L,548499784L,-47387630984L,-6198886653904L,471157554050960L,90008424571645664L,-5872265109220393184L,BigInteger.Parse("-1596153412824165573056"),BigInteger.Parse("86302501271257396667584"),BigInteger.Parse("33424995502240561479908480"),BigInteger.Parse("-1419140555765946374814673024") };
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
public class A160246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160246Inst Instance=new A160246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160247
{
public static readonly long[] Value={ 1L,13L,6L,55L,38L,19L,147L,116L,79L,44L,309L,260L,201L,140L,85L,561L,490L,405L,314L,225L,146L,923L,826L,711L,586L,459L,338L,231L,1415L,1288L,1139L,976L,807L,640L,483L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160247Inst : IEnumerable<long>
{
public static readonly long[] Value=A160247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160247.Bytes);
public long this[int i]=>Value[i];

public static A160247Inst Instance=new A160247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160248
{
public static readonly long[] Value={ 1L,6L,4L,19L,16L,10L,44L,40L,31L,20L,85L,80L,68L,52L,35L,146L,140L,125L,104L,80L,56L,231L,224L,206L,180L,149L,116L,84L,344L,336L,315L,284L,246L,204L,161L,120L,489L,480L,456L,420L,375L,324L,270L,216L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160248Inst : IEnumerable<long>
{
public static readonly long[] Value=A160248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160248.Bytes);
public long this[int i]=>Value[i];

public static A160248Inst Instance=new A160248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160249
{
public static readonly long[] Value={ 1L,4L,13L,10L,28L,55L,20L,50L,92L,147L,35L,80L,140L,216L,309L,56L,119L,200L,300L,420L,561L,84L,168L,273L,400L,550L,724L,923L,120L,228L,360L,517L,700L,910L,1148L,1415L,165L,300L,462L,652L,871L,1120L,1400L,1712L,2057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160249Inst : IEnumerable<long>
{
public static readonly long[] Value=A160249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160249.Bytes);
public long this[int i]=>Value[i];

public static A160249Inst Instance=new A160249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160250
{
public static readonly long[] Value={ 1L,93L,617L,1957L,4497L,8621L,14713L,23157L,34337L,48637L,66441L,88133L,114097L,144717L,180377L,221461L,268353L,321437L,381097L,447717L,521681L,603373L,693177L,791477L,898657L,1015101L,1141193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160250Inst : IEnumerable<long>
{
public static readonly long[] Value=A160250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160250.Bytes);
public long this[int i]=>Value[i];

public static A160250Inst Instance=new A160250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160251
{
public static readonly BigInteger[] Value={ 1L,16L,-1426L,-76640L,5969356L,611143616L,-40423986104L,-6814445150336L,366920889983120L,97565908182651136L,-3993393901642052384L,BigInteger.Parse("-1704952878058464945664"),BigInteger.Parse("46606527919245814078144"),BigInteger.Parse("35158473337439989488532480"),BigInteger.Parse("-456562766083189138816177024") };
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
public class A160251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160251Inst Instance=new A160251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160252
{
public static readonly BigInteger[] Value={ 1L,18L,-1358L,-84996L,5322540L,667658808L,-32744702856L,-7327417341744L,253642619275152L,103163294897460000L,-1982702662432970976L,BigInteger.Parse("-1770895268099070677568"),BigInteger.Parse("4807849834551556801728"),BigInteger.Parse("35830291388333570578463616"),BigInteger.Parse("539816800507699929385760640") };
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
public class A160252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160252Inst Instance=new A160252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160253
{
public static readonly BigInteger[] Value={ 1L,20L,-1282L,-92920L,4610572L,717377200L,-24427366520L,-7728318032800L,133041452750480L,106653076504366400L,119080018350561760L,BigInteger.Parse("-1791523146436431612800"),BigInteger.Parse("-38033681428250725939520"),BigInteger.Parse("35399429559107921153964800"),BigInteger.Parse("1539633069292288796472840320") };
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
public class A160253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160253Inst Instance=new A160253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160254
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,24L,44L,81L,151L,280L,525L,984L,1859L,3511L,6682L,12709L,24334L,46565L,89626L,172381L,333262L,643733L,1249147L,2421592L,4713715L,9165792L,17888456L,34873456L,68212220L,133269997L,261167821L,511211652L,1003436520L,1967293902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160254Inst : IEnumerable<long>
{
public static readonly long[] Value=A160254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160254.Bytes);
public long this[int i]=>Value[i];

public static A160254Inst Instance=new A160254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160255
{
public static readonly long[] Value={ 0L,1L,6L,16L,40L,63L,126L,176L,270L,365L,550L,624L,936L,1099L,1350L,1664L,2176L,2349L,3078L,3280L,3948L,4631L,5566L,5712L,7000L,7813L,8748L,9520L,11368L,11475L,13950L,14592L,16236L,17969L,19390L,20304L,23976L,25327L,27222L,28400L,32800L,32949L,37926L,38896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160255Inst : IEnumerable<long>
{
public static readonly long[] Value=A160255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160255.Bytes);
public long this[int i]=>Value[i];

public static A160255Inst Instance=new A160255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160256
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,16L,18L,24L,12L,10L,30L,5L,36L,15L,48L,20L,60L,7L,120L,14L,180L,21L,240L,28L,300L,35L,360L,42L,420L,11L,840L,22L,1260L,33L,1680L,44L,2100L,55L,2520L,66L,2940L,77L,3360L,88L,3780L,110L,378L,165L,126L,220L,63L,440L,189L,880L,567L,1760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160256Inst : IEnumerable<long>
{
public static readonly long[] Value=A160256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160256.Bytes);
public long this[int i]=>Value[i];

public static A160256Inst Instance=new A160256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160257
{
public static readonly long[] Value={ 6L,6L,8L,12L,12L,18L,32L,27L,16L,5L,25L,15L,6L,108L,20L,64L,25L,21L,14L,240L,21L,270L,28L,320L,35L,375L,42L,432L,49L,110L,22L,1680L,33L,1890L,44L,2240L,55L,2625L,66L,3024L,77L,3430L,88L,3840L,99L,4725L,11L,567L,55L,168L,110L,126L,1320L,378L,2640L,1134L,3520L,1701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160257Inst : IEnumerable<long>
{
public static readonly long[] Value=A160257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160257.Bytes);
public long this[int i]=>Value[i];

public static A160257Inst Instance=new A160257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160258
{
public static readonly long[] Value={ 8L,12L,16L,18L,20L,24L,24L,27L,28L,30L,32L,32L,36L,36L,36L,40L,40L,42L,44L,45L,48L,48L,48L,48L,50L,52L,54L,54L,56L,56L,60L,60L,60L,60L,63L,64L,64L,64L,66L,68L,70L,72L,72L,72L,72L,72L,72L,75L,76L,78L,80L,80L,80L,80L,81L,84L,84L,84L,84L,88L,88L,90L,90L,90L,90L,92L,96L,96L,96L,96L,96L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160258Inst : IEnumerable<long>
{
public static readonly long[] Value=A160258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160258.Bytes);
public long this[int i]=>Value[i];

public static A160258Inst Instance=new A160258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160259
{
public static readonly BigInteger[] Value={ 1L,22L,-1198L,-100364L,3837100L,759665192L,-15557376776L,-8008803406736L,6978879212432L,107919993983713120L,2268593594123893024L,BigInteger.Parse("-1765305239735329031872"),BigInteger.Parse("-80810233952657507431232"),BigInteger.Parse("33853095811859416015817344"),BigInteger.Parse("2511764683469716209839300480") };
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
public class A160259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160259Inst Instance=new A160259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160260
{
public static readonly BigInteger[] Value={ 1L,24L,-1106L,-107280L,3006156L,793927584L,-6227509944L,-8161777416384L,-122559955912560L,106883437972961664L,4420515123955413216L,BigInteger.Parse("-1691687063730285271296"),BigInteger.Parse("-122388860352949901833536"),BigInteger.Parse("31207679045861280271833600"),BigInteger.Parse("3425139117578273280016104576") };
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
public class A160260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160260Inst Instance=new A160260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160261
{
public static readonly BigInteger[] Value={ 1L,26L,-1006L,-113620L,2122156L,819611416L,3462564856L,-8181491724016L,-253487023438960L,103499490028946336L,6528273301571581216L,BigInteger.Parse("-1571126316446016259904"),BigInteger.Parse("-161635396853273818415936"),BigInteger.Parse("27509093252961272911088000"),BigInteger.Parse("4249556012170678409171144576") };
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
public class A160261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160261Inst Instance=new A160261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160262
{
public static readonly long[] Value={ 1L,9L,2L,6L,5L,3L,8L,7L,9L,3L,3L,4L,6L,2L,4L,3L,3L,8L,3L,7L,5L,0L,2L,8L,8L,1L,9L,7L,6L,3L,9L,9L,7L,5L,1L,0L,5L,2L,0L,9L,7L,4L,4L,5L,9L,2L,3L,0L,8L,1L,6L,0L,2L,8L,6L,2L,0L,9L,9L,8L,2L,8L,0L,3L,4L,2L,5L,3L,4L,2L,1L,1L,0L,6L,7L,8L,1L,4L,8L,8L,5L,1L,3L,8L,2L,3L,0L,6L,6L,4L,7L,0L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160262Inst : IEnumerable<long>
{
public static readonly long[] Value=A160262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160262.Bytes);
public long this[int i]=>Value[i];

public static A160262Inst Instance=new A160262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160263
{
public static readonly BigInteger[] Value={ 1L,28L,-898L,-119336L,1189900L,836209808L,13406815624L,-8063638544864L,-383633726413168L,97762575920121280L,8544799476205933024L,BigInteger.Parse("-1405112141642673804928"),BigInteger.Parse("-197439019874757039348032"),BigInteger.Parse("22832490910422530976921856"),BigInteger.Parse("4956511354073268289737879680") };
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
public class A160263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160263Inst Instance=new A160263Inst();

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