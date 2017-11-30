using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245682
{
public static readonly long[] Value={ 123876L,142857L,153846L,230769L,285714L,1028574L,1218753L,1238760L,1239876L,1246878L,1294857L,1402857L,1420785L,1425897L,1428507L,1428570L,1428597L,1428705L,1429857L,1485792L,1492857L,1538460L,1539846L,1570284L,1584297L,2300769L,2307690L,2307699L,2309769L,2857014L,2857140L,2859714L,2985714L,10028574L,10178649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245682Inst : IEnumerable<long>
{
public static readonly long[] Value=A245682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245682.Bytes);
public long this[int i]=>Value[i];

public static A245682Inst Instance=new A245682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245683
{
public static readonly long[] Value={ 0L,2L,1L,0L,1L,1L,-6L,-3L,-1L,0L,0L,-3L,-3L,-2L,-1L,50L,25L,11L,4L,1L,0L,0L,25L,25L,18L,11L,6L,3L,-854L,-427L,-201L,-88L,-35L,-12L,-3L,0L,0L,-427L,-427L,-314L,-201L,-118L,-65L,-34L,-17L,24930L,12465L,6019L,2796L,1241L,520L,201L,68L,17L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245683Inst : IEnumerable<long>
{
public static readonly long[] Value=A245683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245683.Bytes);
public long this[int i]=>Value[i];

public static A245683Inst Instance=new A245683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245684
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,6L,8L,4L,8L,4L,2L,0L,9L,0L,3L,3L,4L,9L,8L,8L,0L,0L,9L,5L,1L,2L,0L,6L,2L,0L,4L,5L,4L,6L,5L,7L,4L,4L,6L,7L,2L,6L,8L,5L,9L,1L,9L,3L,2L,1L,3L,4L,7L,4L,6L,6L,5L,0L,0L,7L,8L,8L,9L,1L,0L,8L,5L,4L,8L,8L,3L,3L,8L,7L,3L,2L,2L,7L,7L,5L,8L,2L,8L,6L,3L,0L,3L,1L,4L,8L,6L,3L,3L,7L,7L,9L,9L,7L,2L,2L,3L,5L,4L,2L,9L,5L,7L,7L,0L,5L,0L,1L,3L,8L,9L,9L,2L,3L,8L,1L,7L,9L,0L,5L,1L,5L,0L,9L,0L,5L,7L,0L,3L,6L,7L,0L,4L,2L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245684Inst : IEnumerable<long>
{
public static readonly long[] Value=A245684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245684.Bytes);
public long this[int i]=>Value[i];

public static A245684Inst Instance=new A245684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245685
{
public static readonly long[] Value={ 6L,9L,12L,18L,21L,27L,30L,36L,45L,48L,57L,63L,66L,72L,81L,90L,93L,102L,108L,111L,120L,126L,135L,147L,153L,156L,162L,165L,171L,192L,198L,207L,210L,225L,228L,237L,246L,252L,261L,270L,273L,288L,291L,297L,300L,318L,336L,342L,345L,351L,360L,363L,378L,387L,396L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245685Inst : IEnumerable<long>
{
public static readonly long[] Value=A245685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245685.Bytes);
public long this[int i]=>Value[i];

public static A245685Inst Instance=new A245685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245686
{
public static readonly long[] Value={ 2L,21L,395L,10180L,322095L,12194323L,536197356L,26904958363L,1516697994964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245686Inst : IEnumerable<long>
{
public static readonly long[] Value=A245686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245686.Bytes);
public long this[int i]=>Value[i];

public static A245686Inst Instance=new A245686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245687
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,2L,0L,24L,0L,3L,0L,216L,36L,0L,4L,0L,2920L,200L,0L,0L,5L,0L,44100L,2250L,300L,0L,0L,6L,0L,799134L,22932L,1470L,0L,0L,0L,7L,0L,16429504L,342608L,3136L,1960L,0L,0L,0L,8L,0L,382625856L,4638384L,147168L,9072L,0L,0L,0L,0L,9L,0L,9918836100L,79610850L,1522800L,18900L,11340L,0L,0L,0L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245687Inst : IEnumerable<long>
{
public static readonly long[] Value=A245687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245687.Bytes);
public long this[int i]=>Value[i];

public static A245687Inst Instance=new A245687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245688
{
public static readonly long[] Value={ 47L,99L,123L,322L,843L,2207L,5778L,15075L,15127L,39603L,103682L,271443L,710647L,1860498L,4870847L,12752043L,33385282L,87403803L,228826127L,599074578L,1568397607L,4106118243L,10749957122L,28143753123L,73681302247L,192900153618L,505019158607L,1322157322203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245688Inst : IEnumerable<long>
{
public static readonly long[] Value=A245688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245688.Bytes);
public long this[int i]=>Value[i];

public static A245688Inst Instance=new A245688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245689
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,4L,3L,5L,11L,6L,13L,7L,3L,4L,17L,6L,19L,4L,3L,11L,23L,6L,5L,13L,3L,4L,29L,10L,31L,4L,3L,17L,5L,6L,37L,19L,3L,4L,41L,6L,43L,4L,3L,23L,47L,6L,7L,5L,3L,4L,53L,6L,5L,4L,3L,29L,59L,10L,61L,31L,3L,4L,5L,6L,67L,4L,3L,5L,71L,6L,73L,37L,3L,4L,7L,6L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245689Inst : IEnumerable<long>
{
public static readonly long[] Value=A245689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245689.Bytes);
public long this[int i]=>Value[i];

public static A245689Inst Instance=new A245689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245690
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245690Inst : IEnumerable<long>
{
public static readonly long[] Value=A245690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245690.Bytes);
public long this[int i]=>Value[i];

public static A245690Inst Instance=new A245690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245691
{
public static readonly long[] Value={ 1L,3L,2L,6L,2L,6L,3L,9L,5L,15L,8L,24L,12L,6L,4L,12L,6L,5L,15L,8L,24L,12L,6L,6L,18L,9L,5L,15L,8L,24L,12L,6L,7L,21L,11L,33L,17L,51L,26L,78L,39L,20L,60L,30L,15L,8L,24L,12L,6L,8L,24L,12L,6L,9L,27L,14L,42L,21L,11L,33L,17L,51L,26L,78L,39L,20L,60L,30L,15L,8L,24L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245691Inst : IEnumerable<long>
{
public static readonly long[] Value=A245691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245691.Bytes);
public long this[int i]=>Value[i];

public static A245691Inst Instance=new A245691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245692
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,12L,7L,4L,4L,144L,62L,28L,12L,10L,2000L,695L,264L,100L,40L,26L,32400L,9504L,3126L,1050L,370L,130L,76L,605052L,154007L,44716L,13458L,4256L,1366L,456L,232L,12845056L,2891776L,751872L,204776L,58784L,17292L,5272L,1624L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245692Inst : IEnumerable<long>
{
public static readonly long[] Value=A245692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245692.Bytes);
public long this[int i]=>Value[i];

public static A245692Inst Instance=new A245692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245693
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,2L,0L,0L,4L,12L,2L,0L,0L,10L,72L,18L,4L,0L,0L,26L,480L,120L,36L,8L,0L,0L,76L,3600L,840L,264L,84L,20L,0L,0L,232L,30240L,6480L,1920L,648L,216L,52L,0L,0L,764L,282240L,55440L,15120L,4920L,1776L,612L,152L,0L,0L,2620L,2903040L,524160L,131040L,39600L,13920L,5232L,1848L,464L,0L,0L,9496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245693Inst : IEnumerable<long>
{
public static readonly long[] Value=A245693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245693.Bytes);
public long this[int i]=>Value[i];

public static A245693Inst Instance=new A245693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245694
{
public static readonly long[] Value={ 9L,25L,49L,121L,289L,1849L,5041L,11881L,32761L,109561L,196249L,6466849L,9369721L,30283009L,52374169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245694Inst : IEnumerable<long>
{
public static readonly long[] Value=A245694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245694.Bytes);
public long this[int i]=>Value[i];

public static A245694Inst Instance=new A245694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245695
{
public static readonly long[] Value={ 1L,2L,0L,4L,25L,42L,49L,88L,207L,170L,121L,12L,377L,938L,285L,688L,391L,558L,703L,1780L,609L,682L,713L,2328L,3275L,1066L,1593L,28L,1943L,6690L,3317L,4064L,2607L,1258L,3395L,2196L,4847L,38L,1677L,3880L,2173L,42L,4171L,3124L,2115L,10994L,4747L,11184L,2597L,4150L,3111L,14092L,2809L,3834L,12265L,3976L,8493L,6206L,16697L,17580L,16531L,47678L,8253L,17344L,4355L,12738L,18961L,4964L,5727L,9170L,9869L,61704L,7373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245695Inst : IEnumerable<long>
{
public static readonly long[] Value=A245695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245695.Bytes);
public long this[int i]=>Value[i];

public static A245695Inst Instance=new A245695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245696
{
public static readonly long[] Value={ 0L,4L,5L,42L,7L,8L,279L,130L,121L,156L,13L,322L,15L,752L,901L,1062L,779L,2020L,651L,682L,1679L,2136L,1825L,3874L,999L,1204L,2929L,930L,31L,1952L,33L,34L,6755L,4068L,4699L,3686L,39L,2920L,3403L,5502L,3397L,4796L,4905L,2438L,4183L,3792L,5047L,2950L,4947L,9308L,3551L,3186L,6985L,3416L,26277L,16066L,6431L,8220L,8479L,4402L,4473L,6464L,23335L,8382L,21239L,12988L,17319L,7210L,6887L,54072L,11899L,27602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245696Inst : IEnumerable<long>
{
public static readonly long[] Value=A245696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245696.Bytes);
public long this[int i]=>Value[i];

public static A245696Inst Instance=new A245696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245697
{
public static readonly long[] Value={ 0L,4L,25L,42L,133L,152L,279L,170L,121L,204L,1079L,938L,5295L,3632L,2771L,1062L,1159L,2260L,7413L,682L,33281L,13704L,9725L,4966L,9099L,24724L,2929L,54690L,20429L,22688L,5379L,46274L,15365L,11052L,40441L,65854L,97149L,42520L,44731L,83958L,61877L,4796L,123885L,27922L,122999L,12912L,5047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245697Inst : IEnumerable<long>
{
public static readonly long[] Value=A245697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245697.Bytes);
public long this[int i]=>Value[i];

public static A245697Inst Instance=new A245697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245698
{
public static readonly long[] Value={ 2L,6L,5L,6L,1L,4L,4L,1L,7L,3L,3L,6L,8L,0L,9L,5L,1L,6L,4L,2L,6L,6L,6L,3L,2L,7L,9L,4L,6L,2L,2L,0L,6L,2L,8L,7L,6L,6L,1L,8L,1L,0L,6L,9L,3L,2L,8L,2L,6L,8L,2L,0L,9L,6L,4L,3L,7L,7L,8L,2L,5L,6L,7L,5L,4L,5L,7L,9L,5L,9L,0L,1L,0L,6L,8L,5L,5L,8L,0L,0L,2L,7L,9L,0L,9L,1L,7L,2L,9L,9L,2L,7L,5L,8L,1L,1L,0L,5L,1L,9L,3L,9L,3L,1L,7L,6L,5L,1L,0L,7L,7L,5L,7L,8L,7L,9L,9L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245698Inst : IEnumerable<long>
{
public static readonly long[] Value=A245698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245698.Bytes);
public long this[int i]=>Value[i];

public static A245698Inst Instance=new A245698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245699
{
public static readonly long[] Value={ 5L,4L,1L,0L,7L,5L,0L,8L,0L,0L,4L,6L,7L,4L,3L,5L,0L,4L,4L,6L,4L,6L,7L,3L,3L,6L,0L,0L,8L,3L,5L,2L,2L,6L,6L,7L,5L,5L,0L,2L,3L,1L,7L,7L,0L,7L,8L,2L,1L,8L,9L,0L,8L,4L,2L,9L,9L,5L,7L,1L,5L,9L,2L,0L,3L,2L,0L,5L,6L,6L,6L,8L,1L,8L,2L,3L,3L,8L,0L,6L,0L,1L,5L,5L,8L,8L,9L,6L,9L,1L,0L,7L,8L,5L,4L,2L,2L,0L,9L,3L,5L,6L,5L,2L,7L,8L,8L,4L,0L,3L,0L,4L,7L,4L,2L,3L,1L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245699Inst : IEnumerable<long>
{
public static readonly long[] Value=A245699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245699.Bytes);
public long this[int i]=>Value[i];

public static A245699Inst Instance=new A245699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245700
{
public static readonly long[] Value={ 6L,0L,7L,9L,8L,6L,4L,0L,5L,5L,0L,0L,3L,6L,0L,7L,5L,6L,1L,8L,2L,1L,4L,4L,6L,4L,2L,5L,6L,3L,9L,6L,4L,7L,5L,9L,4L,9L,5L,2L,0L,5L,9L,7L,2L,7L,8L,9L,0L,2L,0L,6L,9L,6L,2L,6L,7L,0L,0L,6L,9L,1L,6L,7L,4L,2L,7L,0L,6L,9L,0L,6L,6L,3L,7L,9L,8L,5L,5L,7L,5L,0L,5L,1L,7L,3L,7L,2L,7L,2L,0L,3L,6L,7L,6L,6L,3L,5L,5L,5L,3L,0L,3L,2L,5L,8L,4L,0L,5L,9L,9L,8L,2L,2L,7L,9L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245700Inst : IEnumerable<long>
{
public static readonly long[] Value=A245700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245700.Bytes);
public long this[int i]=>Value[i];

public static A245700Inst Instance=new A245700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245701
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,9L,8L,7L,11L,19L,6L,17L,10L,15L,23L,39L,13L,35L,18L,21L,31L,47L,79L,27L,16L,71L,37L,43L,63L,95L,14L,159L,55L,33L,143L,75L,22L,87L,127L,191L,38L,29L,319L,111L,67L,287L,12L,151L,45L,175L,255L,383L,77L,59L,34L,639L,223L,135L,20L,575L,30L,25L,303L,91L,351L,511L,46L,767L,155L,119L,69L,1279L,78L,447L,271L,41L,1151L,61L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245701Inst : IEnumerable<long>
{
public static readonly long[] Value=A245701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245701.Bytes);
public long this[int i]=>Value[i];

public static A245701Inst Instance=new A245701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245702
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,11L,8L,7L,6L,13L,9L,47L,17L,31L,14L,25L,12L,19L,10L,59L,20L,37L,15L,319L,62L,87L,24L,185L,42L,61L,21L,137L,34L,55L,18L,97L,27L,41L,16L,415L,76L,103L,28L,229L,49L,67L,22L,3053L,373L,433L,79L,647L,108L,131L,33L,1627L,222L,283L,54L,425L,78L,109L,29L,1123L,166L,203L,45L,379L,71L,91L,26L,731L,121L,145L,36L,253L,53L,73L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245702Inst : IEnumerable<long>
{
public static readonly long[] Value=A245702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245702.Bytes);
public long this[int i]=>Value[i];

public static A245702Inst Instance=new A245702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245703
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,5L,11L,6L,8L,12L,25L,9L,13L,17L,10L,14L,47L,18L,19L,34L,15L,20L,31L,24L,16L,21L,62L,26L,55L,27L,137L,45L,22L,28L,42L,33L,37L,23L,29L,79L,59L,35L,87L,71L,36L,166L,41L,58L,30L,38L,54L,44L,61L,49L,32L,39L,99L,76L,319L,46L,91L,108L,89L,48L,200L,53L,97L,75L,40L,50L,203L,70L,67L,57L,78L,64L,43L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245703Inst : IEnumerable<long>
{
public static readonly long[] Value=A245703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245703.Bytes);
public long this[int i]=>Value[i];

public static A245703Inst Instance=new A245703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245704
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,9L,12L,15L,7L,10L,13L,16L,21L,25L,14L,18L,19L,22L,26L,33L,38L,24L,11L,28L,30L,34L,39L,49L,23L,55L,36L,20L,42L,45L,37L,50L,56L,69L,47L,35L,77L,52L,32L,60L,17L,64L,54L,70L,78L,94L,66L,51L,29L,105L,74L,48L,41L,84L,53L,27L,88L,76L,95L,106L,73L,125L,91L,72L,44L,140L,97L,100L,68L,58L,115L,75L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245704Inst : IEnumerable<long>
{
public static readonly long[] Value=A245704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245704.Bytes);
public long this[int i]=>Value[i];

public static A245704Inst Instance=new A245704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245705
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,8L,13L,10L,7L,12L,37L,18L,19L,16L,69L,26L,17L,20L,33L,14L,277L,24L,213L,74L,11L,36L,73L,38L,71L,32L,45L,138L,25L,52L,1109L,34L,457L,40L,173L,66L,43L,28L,549L,554L,3351L,48L,77L,426L,21L,148L,53L,22L,135L,72L,125L,146L,651L,76L,273L,142L,55L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245705Inst : IEnumerable<long>
{
public static readonly long[] Value=A245705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245705.Bytes);
public long this[int i]=>Value[i];

public static A245705Inst Instance=new A245705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245706
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,11L,8L,7L,10L,27L,12L,9L,22L,75L,16L,19L,14L,15L,20L,51L,54L,659L,24L,35L,18L,91L,44L,565L,150L,83L,32L,21L,38L,67L,28L,13L,30L,99L,40L,139L,102L,43L,108L,33L,1318L,651L,48L,73L,70L,115L,36L,53L,182L,63L,88L,105L,1130L,19179L,300L,1107L,166L,8875L,64L,555L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245706Inst : IEnumerable<long>
{
public static readonly long[] Value=A245706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245706.Bytes);
public long this[int i]=>Value[i];

public static A245706Inst Instance=new A245706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245707
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,6L,19L,13L,8L,35L,11L,10L,17L,21L,18L,27L,139L,16L,23L,33L,14L,555L,51L,22L,37L,75L,36L,29L,105L,26L,67L,147L,278L,71L,165L,38L,53L,587L,12L,107L,83L,28L,25L,2219L,72L,43L,73L,20L,87L,41L,34L,291L,277L,210L,163L,31L,66L,149L,131L,330L,15L,229L,24L,39L,2347L,70L,49L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245707Inst : IEnumerable<long>
{
public static readonly long[] Value=A245707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245707.Bytes);
public long this[int i]=>Value[i];

public static A245707Inst Instance=new A245707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245708
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,8L,6L,11L,7L,14L,13L,41L,10L,23L,63L,20L,15L,17L,9L,50L,16L,26L,21L,65L,45L,32L,18L,44L,30L,413L,58L,95L,22L,53L,12L,29L,27L,38L,66L,221L,52L,122L,48L,77L,115L,83L,748L,179L,69L,263L,25L,365L,39L,113L,153L,176L,130L,158L,508L,1007L,247L,140L,78L,242L,97L,59L,33L,89L,72L,68L,36L,47L,49L,188L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245708Inst : IEnumerable<long>
{
public static readonly long[] Value=A245708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245708.Bytes);
public long this[int i]=>Value[i];

public static A245708Inst Instance=new A245708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245709
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,16L,20L,24L,32L,40L,43L,48L,53L,64L,80L,86L,96L,106L,128L,160L,172L,192L,212L,249L,256L,320L,344L,384L,417L,424L,498L,512L,640L,688L,768L,834L,848L,996L,1024L,1280L,1321L,1376L,1536L,1668L,1696L,1992L,2048L,2560L,2642L,2752L,3072L,3336L,3392L,3984L,4096L,5120L,5284L,5504L,5545L,6144L,6672L,6784L,6827L,7081L,7968L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245709Inst : IEnumerable<long>
{
public static readonly long[] Value=A245709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245709.Bytes);
public long this[int i]=>Value[i];

public static A245709Inst Instance=new A245709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245710
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,3L,3L,4L,5L,5L,6L,6L,6L,7L,7L,8L,9L,9L,10L,10L,10L,11L,12L,12L,12L,13L,13L,14L,15L,15L,15L,16L,17L,17L,18L,18L,18L,19L,20L,20L,20L,21L,21L,22L,23L,23L,24L,24L,24L,25L,25L,26L,27L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,32L,33L,33L,34L,34L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245710Inst : IEnumerable<long>
{
public static readonly long[] Value=A245710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245710.Bytes);
public long this[int i]=>Value[i];

public static A245710Inst Instance=new A245710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245711
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,19L,10L,35L,9L,17L,139L,107L,6L,37L,36L,23L,13L,555L,229L,87L,22L,275L,1676L,39L,11L,27L,68L,63L,326L,137L,28L,4435L,18L,53L,147L,25L,8L,6819L,9388L,995L,16L,155L,73L,3659L,14L,533L,838L,145L,20L,49L,851L,29L,587L,535L,403L,4179L,26L,501L,1059L,1611L,1163L,69L,152L,663L,51L,283L,222L,181L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245711Inst : IEnumerable<long>
{
public static readonly long[] Value=A245711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245711.Bytes);
public long this[int i]=>Value[i];

public static A245711Inst Instance=new A245711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245712
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,14L,5L,38L,10L,8L,26L,330L,18L,46L,283L,42L,11L,34L,7L,50L,70L,22L,17L,326L,37L,58L,27L,32L,53L,9590L,554L,4438L,278L,174L,9L,16L,15L,142L,25L,226L,146L,658L,105L,310L,1190L,806L,1770L,524L,51L,5258L,66L,5302L,35L,518L,17739L,1054L,19030L,542L,5550L,8054L,35498L,4434L,29L,810L,1106L,72L,75L,28L,63L,166L,83L,150L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245712Inst : IEnumerable<long>
{
public static readonly long[] Value=A245712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245712.Bytes);
public long this[int i]=>Value[i];

public static A245712Inst Instance=new A245712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245713
{
public static readonly long[] Value={ 1L,8L,16L,27L,32L,64L,64L,81L,125L,128L,216L,243L,256L,256L,343L,512L,512L,625L,729L,729L,1000L,1024L,1024L,1296L,1331L,1728L,2048L,2187L,2197L,2401L,2744L,3125L,3375L,4096L,4096L,4096L,4096L,4913L,5832L,6561L,6561L,6859L,7776L,8000L,8192L,9261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245713Inst : IEnumerable<long>
{
public static readonly long[] Value=A245713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245713.Bytes);
public long this[int i]=>Value[i];

public static A245713Inst Instance=new A245713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245714
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,0L,2L,1L,2L,1L,3L,0L,2L,1L,2L,1L,4L,0L,2L,1L,3L,0L,3L,0L,2L,1L,2L,1L,3L,0L,0L,0L,2L,1L,3L,0L,2L,1L,2L,1L,4L,0L,2L,1L,3L,0L,4L,0L,2L,1L,3L,0L,3L,0L,2L,1L,2L,1L,3L,0L,0L,0L,2L,1L,3L,0L,2L,1L,2L,1L,3L,0L,0L,0L,2L,1L,4L,0L,2L,1L,3L,0L,4L,0L,2L,1L,4L,0L,3L,0L,0L,0L,2L,1L,3L,0L,2L,1L,2L,1L,3L,0L,2L,1L,2L,1L,5L,0L,2L,1L,4L,0L,4L,0L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245714Inst : IEnumerable<long>
{
public static readonly long[] Value=A245714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245714.Bytes);
public long this[int i]=>Value[i];

public static A245714Inst Instance=new A245714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245715
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,3L,1L,2L,4L,4L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,0L,4L,1L,2L,1L,2L,0L,3L,1L,2L,0L,0L,0L,3L,1L,2L,0L,0L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,0L,4L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,0L,4L,1L,2L,0L,0L,0L,3L,1L,2L,0L,0L,0L,3L,0L,4L,1L,2L,0L,0L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,3L,1L,2L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245715Inst : IEnumerable<long>
{
public static readonly long[] Value=A245715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245715.Bytes);
public long this[int i]=>Value[i];

public static A245715Inst Instance=new A245715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245716
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,0L,0L,2L,0L,3L,1L,3L,0L,2L,0L,3L,1L,0L,0L,2L,0L,3L,0L,3L,0L,0L,0L,4L,1L,0L,0L,0L,0L,3L,0L,3L,0L,2L,0L,0L,1L,4L,0L,2L,0L,3L,0L,0L,0L,0L,0L,3L,0L,4L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,3L,0L,2L,0L,0L,1L,3L,0L,0L,0L,3L,0L,0L,0L,2L,0L,4L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,1L,3L,0L,2L,0L,3L,1L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245716Inst : IEnumerable<long>
{
public static readonly long[] Value=A245716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245716.Bytes);
public long this[int i]=>Value[i];

public static A245716Inst Instance=new A245716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245717
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,4L,1L,4L,1L,1L,1L,1L,5L,1L,2L,3L,2L,1L,6L,1L,1L,1L,1L,1L,1L,7L,1L,4L,1L,8L,1L,4L,1L,8L,1L,1L,9L,1L,1L,9L,1L,1L,9L,1L,2L,1L,2L,5L,2L,1L,2L,1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,4L,3L,4L,1L,12L,1L,4L,3L,4L,1L,12L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245717Inst : IEnumerable<long>
{
public static readonly long[] Value=A245717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245717.Bytes);
public long this[int i]=>Value[i];

public static A245717Inst Instance=new A245717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245718
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,0L,1L,1L,3L,1L,3L,1L,2L,1L,4L,1L,3L,2L,3L,2L,5L,1L,5L,3L,3L,2L,4L,2L,7L,3L,4L,3L,7L,2L,8L,3L,4L,3L,9L,3L,8L,3L,6L,4L,10L,3L,7L,4L,6L,5L,11L,3L,11L,5L,6L,6L,9L,4L,12L,6L,8L,4L,13L,4L,14L,6L,7L,7L,11L,4L,15L,6L,10L,7L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245718Inst : IEnumerable<long>
{
public static readonly long[] Value=A245718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245718.Bytes);
public long this[int i]=>Value[i];

public static A245718Inst Instance=new A245718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245719
{
public static readonly long[] Value={ 1L,1L,3L,9L,5L,4L,7L,0L,9L,9L,4L,0L,4L,6L,4L,8L,6L,5L,7L,4L,9L,2L,7L,9L,3L,0L,1L,9L,3L,8L,9L,8L,4L,6L,1L,1L,2L,0L,8L,7L,5L,9L,9L,7L,9L,5L,8L,3L,6L,5L,5L,1L,8L,2L,4L,7L,2L,1L,6L,5L,5L,7L,1L,0L,0L,8L,5L,2L,4L,8L,0L,0L,7L,7L,0L,6L,0L,7L,0L,6L,8L,5L,7L,0L,7L,1L,8L,7L,5L,4L,6L,8L,8L,6L,9L,3L,8L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245719Inst : IEnumerable<long>
{
public static readonly long[] Value=A245719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245719.Bytes);
public long this[int i]=>Value[i];

public static A245719Inst Instance=new A245719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245720
{
public static readonly long[] Value={ 1L,1L,1L,8L,4L,4L,2L,7L,5L,2L,8L,4L,5L,4L,9L,6L,9L,5L,6L,7L,5L,3L,4L,4L,3L,3L,6L,0L,5L,1L,6L,1L,1L,1L,8L,0L,3L,8L,2L,7L,5L,1L,1L,9L,4L,4L,1L,3L,2L,1L,2L,2L,0L,1L,4L,5L,8L,2L,8L,0L,0L,2L,3L,3L,5L,4L,6L,7L,2L,7L,3L,4L,0L,2L,4L,6L,6L,3L,2L,4L,6L,3L,0L,1L,5L,2L,4L,6L,6L,0L,9L,7L,2L,3L,1L,1L,5L,9L,5L,2L,2L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245720Inst : IEnumerable<long>
{
public static readonly long[] Value=A245720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245720.Bytes);
public long this[int i]=>Value[i];

public static A245720Inst Instance=new A245720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245721
{
public static readonly long[] Value={ 170693941183817L,170693941183847L,170693941183859L,170693941183861L,170693941183889L,170693941183891L,170693941183903L,170693941183907L,170693941183933L,170693941183937L,170693941183949L,170693941183951L,170693941183979L,170693941183981L,170693941183993L,170693941184023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245721Inst : IEnumerable<long>
{
public static readonly long[] Value=A245721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245721.Bytes);
public long this[int i]=>Value[i];

public static A245721Inst Instance=new A245721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245722
{
public static readonly long[] Value={ 3L,5L,7L,11L,221L,323L,437L,23L,899L,1147L,1517L,82861L,107113L,2491L,3127L,241133L,21182921L,347261L,33984931L,478661L,583573L,7387L,8633L,107972737L,13710311357L,135745657L,1317919L,12317L,14351L,16637L,2494633L,428448457L,490995677L,3532343L,645328247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245722Inst : IEnumerable<long>
{
public static readonly long[] Value=A245722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245722.Bytes);
public long this[int i]=>Value[i];

public static A245722Inst Instance=new A245722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245723
{
public static readonly long[] Value={ 1L,3L,7L,19L,109L,509L,241L,317L,181L,1471L,2503L,2491L,7151L,11779L,3361L,2927L,1733L,5881L,15893L,16943L,11639L,31897L,25939L,12011L,17123L,6283L,10369L,63949L,8471L,125261L,64579L,117541L,21859L,58879L,44711L,216829L,64081L,67159L,73273L,181931L,139709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245723Inst : IEnumerable<long>
{
public static readonly long[] Value=A245723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245723.Bytes);
public long this[int i]=>Value[i];

public static A245723Inst Instance=new A245723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245724
{
public static readonly long[] Value={ 6L,1L,9L,4L,0L,3L,6L,9L,8L,4L,5L,8L,6L,3L,1L,8L,8L,5L,7L,1L,8L,5L,1L,4L,2L,0L,8L,1L,0L,4L,1L,6L,4L,6L,0L,9L,7L,1L,2L,3L,5L,8L,4L,9L,5L,5L,0L,9L,1L,4L,6L,5L,3L,5L,0L,6L,6L,8L,3L,8L,3L,9L,7L,7L,7L,6L,0L,5L,4L,1L,6L,4L,7L,2L,8L,3L,6L,8L,0L,7L,7L,0L,7L,0L,5L,9L,6L,6L,7L,9L,1L,2L,9L,5L,4L,3L,7L,0L,8L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245724Inst : IEnumerable<long>
{
public static readonly long[] Value=A245724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245724.Bytes);
public long this[int i]=>Value[i];

public static A245724Inst Instance=new A245724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245725
{
public static readonly long[] Value={ 1L,6L,1L,5L,3L,2L,9L,7L,3L,6L,0L,9L,7L,2L,5L,2L,5L,7L,0L,4L,6L,8L,1L,8L,2L,5L,5L,3L,6L,1L,9L,0L,3L,1L,9L,7L,0L,3L,6L,1L,2L,0L,9L,2L,0L,3L,9L,0L,2L,9L,3L,5L,0L,8L,0L,6L,5L,4L,3L,4L,2L,3L,5L,1L,8L,0L,5L,0L,7L,5L,5L,6L,4L,0L,3L,6L,3L,4L,9L,2L,1L,0L,4L,1L,8L,9L,3L,8L,0L,4L,5L,4L,4L,6L,8L,5L,6L,9L,6L,0L,3L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245725Inst : IEnumerable<long>
{
public static readonly long[] Value=A245725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245725.Bytes);
public long this[int i]=>Value[i];

public static A245725Inst Instance=new A245725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245726
{
public static readonly long[] Value={ 0L,1L,5L,7L,7L,2L,4L,7L,9L,7L,0L,3L,6L,6L,1L,2L,4L,4L,8L,8L,0L,8L,8L,0L,9L,1L,8L,8L,6L,8L,0L,8L,5L,6L,9L,5L,9L,7L,9L,9L,0L,1L,0L,3L,1L,3L,8L,3L,7L,6L,0L,5L,0L,6L,6L,1L,7L,7L,4L,5L,0L,8L,6L,4L,9L,1L,0L,1L,2L,0L,0L,1L,4L,6L,4L,2L,6L,5L,1L,7L,0L,9L,2L,7L,3L,1L,8L,1L,7L,7L,0L,4L,1L,1L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245726Inst : IEnumerable<long>
{
public static readonly long[] Value=A245726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245726.Bytes);
public long this[int i]=>Value[i];

public static A245726Inst Instance=new A245726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245727
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,1L,2L,1L,2L,3L,6L,1L,6L,9L,8L,3L,4L,5L,12L,7L,8L,15L,10L,13L,6L,7L,2L,5L,10L,7L,6L,19L,10L,15L,4L,1L,2L,9L,4L,9L,12L,1L,6L,3L,2L,3L,4L,13L,2L,1L,2L,9L,28L,17L,2L,1L,22L,3L,22L,7L,2L,1L,4L,5L,4L,7L,12L,1L,2L,9L,6L,11L,20L,3L,2L,5L,12L,1L,14L,1L,10L,5L,4L,37L,12L,3L,16L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245727Inst : IEnumerable<long>
{
public static readonly long[] Value=A245727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245727.Bytes);
public long this[int i]=>Value[i];

public static A245727Inst Instance=new A245727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245728
{
public static readonly long[] Value={ 1L,2L,10L,1030L,10009593662L,13957196317L,55299492770L,3764656723270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245728Inst : IEnumerable<long>
{
public static readonly long[] Value=A245728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245728.Bytes);
public long this[int i]=>Value[i];

public static A245728Inst Instance=new A245728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245729
{
public static readonly long[] Value={ 10L,14L,20L,22L,26L,28L,33L,34L,38L,39L,40L,44L,46L,51L,52L,56L,57L,58L,62L,66L,68L,69L,74L,76L,78L,80L,82L,86L,87L,88L,92L,93L,94L,99L,102L,104L,106L,111L,112L,114L,116L,117L,118L,122L,123L,124L,129L,132L,134L,136L,138L,141L,142L,145L,146L,148L,152L,153L,155L,156L,158L,159L,160L,164L,166L,171L,172L,174L,176L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245729Inst : IEnumerable<long>
{
public static readonly long[] Value=A245729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245729.Bytes);
public long this[int i]=>Value[i];

public static A245729Inst Instance=new A245729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245730
{
public static readonly BigInteger[] Value={ 3L,5L,7L,17L,31L,73L,127L,257L,8191L,65537L,131071L,262657L,524287L,2147483647L,4432676798593L,2305843009213693951L,BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127"),BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A245730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245730Inst Instance=new A245730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245731
{
public static readonly BigInteger[] Value={ 1L,2L,9L,109L,2647L,110481L,7291543L,726434549L,106312974249L,22465350835849L,6771847676632679L,2883916106465622053L,BigInteger.Parse("1720792953946798909927"),BigInteger.Parse("1427968172285571102335605"),BigInteger.Parse("1637002867699829205840095585"),BigInteger.Parse("2577011453377960519672777065693"),BigInteger.Parse("5541005747990556022043234479371823"),BigInteger.Parse("16195114271558690956785525865003941945"),BigInteger.Parse("64068293759315414337050896928055465961863") };
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
public class A245731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245731Inst Instance=new A245731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245732
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,1L,27L,13L,1L,1L,256L,75L,7L,1L,1L,3125L,541L,21L,1L,1L,1L,46656L,4683L,141L,21L,1L,1L,1L,823543L,47293L,743L,71L,1L,1L,1L,1L,16777216L,545835L,5699L,183L,71L,1L,1L,1L,1L,387420489L,7087261L,42241L,2101L,253L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245732Inst : IEnumerable<long>
{
public static readonly long[] Value=A245732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245732.Bytes);
public long this[int i]=>Value[i];

public static A245732Inst Instance=new A245732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245733
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,14L,12L,0L,1L,181L,68L,6L,0L,1L,2584L,520L,20L,0L,0L,1L,41973L,4542L,120L,20L,0L,0L,1L,776250L,46550L,672L,70L,0L,0L,0L,1L,16231381L,540136L,5516L,112L,70L,0L,0L,0L,1L,380333228L,7045020L,40140L,1848L,252L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245733Inst : IEnumerable<long>
{
public static readonly long[] Value=A245733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245733.Bytes);
public long this[int i]=>Value[i];

public static A245733Inst Instance=new A245733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245734
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,74L,294L,1228L,5318L,23662L,107512L,496726L,2326462L,11020424L,52706138L,254148326L,1234240140L,6031310162L,29635011990L,146323849876L,725635937678L,3612656833694L,18049975590512L,90474958563374L,454841633027198L,2292796383312656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245734Inst : IEnumerable<long>
{
public static readonly long[] Value=A245734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245734.Bytes);
public long this[int i]=>Value[i];

public static A245734Inst Instance=new A245734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245735
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-5L,9L,-3L,-29L,89L,-107L,-121L,833L,-1703L,631L,6705L,-21943L,27587L,34937L,-242427L,507739L,-172615L,-2201619L,7253775L,-9083263L,-12931023L,86757487L,-181330015L,52436881L,843605643L,-2751023447L,3373429837L,5393254483L,-34585122919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245735Inst : IEnumerable<long>
{
public static readonly long[] Value=A245735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245735.Bytes);
public long this[int i]=>Value[i];

public static A245735Inst Instance=new A245735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245736
{
public static readonly long[] Value={ 7L,8L,6L,6L,8L,4L,2L,7L,5L,3L,7L,8L,8L,3L,2L,1L,7L,9L,1L,2L,1L,6L,5L,7L,9L,8L,9L,4L,9L,4L,6L,9L,5L,3L,8L,0L,5L,5L,1L,1L,7L,0L,8L,1L,6L,5L,7L,8L,0L,3L,2L,7L,4L,9L,7L,1L,8L,6L,4L,6L,4L,5L,1L,8L,9L,8L,8L,1L,7L,9L,9L,2L,8L,8L,1L,8L,3L,9L,9L,3L,7L,2L,4L,3L,9L,6L,8L,6L,6L,7L,2L,6L,1L,5L,2L,3L,4L,7L,8L,0L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245736Inst : IEnumerable<long>
{
public static readonly long[] Value=A245736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245736.Bytes);
public long this[int i]=>Value[i];

public static A245736Inst Instance=new A245736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245737
{
public static readonly long[] Value={ 8L,0L,7L,6L,6L,4L,8L,6L,8L,0L,4L,8L,6L,2L,6L,2L,8L,5L,2L,3L,4L,0L,9L,1L,2L,7L,6L,8L,0L,9L,5L,1L,5L,9L,8L,5L,1L,8L,0L,6L,0L,4L,6L,0L,1L,9L,5L,1L,4L,6L,7L,5L,4L,0L,3L,2L,7L,1L,7L,1L,1L,7L,5L,9L,0L,2L,5L,3L,7L,7L,8L,2L,0L,1L,8L,1L,7L,4L,6L,0L,5L,2L,0L,9L,4L,6L,9L,0L,2L,2L,7L,2L,3L,4L,2L,8L,4L,8L,0L,1L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245737Inst : IEnumerable<long>
{
public static readonly long[] Value=A245737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245737.Bytes);
public long this[int i]=>Value[i];

public static A245737Inst Instance=new A245737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245738
{
public static readonly long[] Value={ 2L,3L,7L,11L,20L,32L,54L,87L,143L,231L,376L,608L,986L,1595L,2583L,4179L,6764L,10944L,17710L,28655L,46367L,75023L,121392L,196416L,317810L,514227L,832039L,1346267L,2178308L,3524576L,5702886L,9227463L,14930351L,24157815L,39088168L,63245984L,102334154L,165580139L,267914295L,433494435L,701408732L,1134903168L,1836311902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245738Inst : IEnumerable<long>
{
public static readonly long[] Value=A245738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245738.Bytes);
public long this[int i]=>Value[i];

public static A245738Inst Instance=new A245738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245739
{
public static readonly long[] Value={ 1L,1L,3L,5L,6L,9L,6L,4L,0L,1L,7L,7L,5L,1L,0L,2L,5L,2L,3L,7L,6L,0L,2L,1L,9L,9L,7L,0L,6L,6L,6L,5L,7L,8L,0L,8L,1L,0L,2L,8L,0L,6L,6L,6L,3L,2L,0L,2L,8L,6L,4L,6L,5L,9L,5L,5L,0L,3L,2L,3L,8L,8L,9L,8L,3L,1L,1L,9L,8L,7L,8L,2L,6L,4L,0L,8L,2L,1L,7L,6L,3L,0L,9L,6L,6L,1L,3L,9L,0L,4L,2L,4L,1L,9L,0L,0L,2L,5L,7L,8L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245739Inst : IEnumerable<long>
{
public static readonly long[] Value=A245739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245739.Bytes);
public long this[int i]=>Value[i];

public static A245739Inst Instance=new A245739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245740
{
public static readonly long[] Value={ 7L,2L,0L,5L,6L,3L,3L,2L,2L,8L,6L,6L,5L,7L,7L,1L,0L,6L,0L,7L,7L,3L,6L,4L,5L,2L,0L,6L,2L,7L,9L,5L,7L,5L,5L,2L,4L,2L,2L,3L,8L,3L,5L,1L,9L,3L,3L,2L,3L,6L,7L,0L,4L,2L,3L,8L,3L,6L,1L,4L,0L,9L,6L,1L,5L,2L,7L,9L,1L,4L,7L,4L,1L,6L,0L,4L,3L,5L,9L,9L,0L,3L,2L,0L,4L,4L,7L,9L,4L,6L,3L,9L,2L,2L,9L,4L,7L,7L,6L,6L,5L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245740Inst : IEnumerable<long>
{
public static readonly long[] Value=A245740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245740.Bytes);
public long this[int i]=>Value[i];

public static A245740Inst Instance=new A245740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245741
{
public static readonly long[] Value={ 1L,5L,7L,3L,3L,6L,8L,5L,5L,0L,7L,5L,7L,6L,6L,4L,3L,5L,8L,2L,4L,3L,3L,1L,5L,9L,7L,8L,9L,8L,9L,3L,9L,0L,7L,6L,1L,1L,0L,2L,3L,4L,1L,6L,3L,3L,1L,5L,6L,0L,6L,5L,4L,9L,9L,4L,3L,7L,2L,9L,2L,9L,0L,3L,7L,9L,7L,6L,3L,5L,9L,8L,5L,7L,6L,3L,6L,7L,9L,8L,7L,4L,4L,8L,7L,9L,3L,7L,3L,3L,4L,5L,2L,3L,0L,4L,6L,9L,5L,6L,1L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245741Inst : IEnumerable<long>
{
public static readonly long[] Value=A245741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245741.Bytes);
public long this[int i]=>Value[i];

public static A245741Inst Instance=new A245741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245742
{
public static readonly long[] Value={ 43L,61L,263L,461L,563L,601L,613L,641L,653L,683L,821L,1063L,1283L,1361L,1423L,1481L,1601L,1613L,1621L,1663L,1823L,1871L,2063L,2081L,2111L,2381L,2843L,3061L,3163L,3343L,3461L,3463L,3631L,3881L,4003L,4561L,4583L,4643L,4651L,5563L,5641L,5651L,5653L,5783L,5813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245742Inst : IEnumerable<long>
{
public static readonly long[] Value=A245742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245742.Bytes);
public long this[int i]=>Value[i];

public static A245742Inst Instance=new A245742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245743
{
public static readonly long[] Value={ 41L,163L,181L,263L,401L,443L,463L,487L,563L,613L,653L,1021L,1381L,1433L,1613L,1663L,1831L,2141L,2243L,2281L,2441L,2663L,2851L,2887L,3041L,3463L,3613L,3623L,3643L,4133L,4363L,4463L,4603L,4643L,4663L,4801L,5281L,5563L,5581L,5653L,5821L,5851L,5857L,6043L,6053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245743Inst : IEnumerable<long>
{
public static readonly long[] Value=A245743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245743.Bytes);
public long this[int i]=>Value[i];

public static A245743Inst Instance=new A245743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245744
{
public static readonly long[] Value={ 29L,67L,89L,227L,239L,269L,457L,487L,499L,607L,677L,827L,2027L,2087L,2237L,2267L,2309L,2339L,2549L,2657L,2687L,2729L,2789L,2969L,2999L,3257L,3299L,3329L,3527L,3929L,4229L,4259L,4447L,4789L,4969L,4999L,5279L,5479L,5647L,6067L,6269L,6299L,6469L,6547L,6827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245744Inst : IEnumerable<long>
{
public static readonly long[] Value=A245744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245744.Bytes);
public long this[int i]=>Value[i];

public static A245744Inst Instance=new A245744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245745
{
public static readonly long[] Value={ 47L,67L,229L,283L,467L,523L,607L,647L,823L,829L,2029L,2083L,2089L,2239L,2269L,2383L,2593L,2659L,2689L,2803L,3253L,3259L,3529L,3823L,4007L,4243L,4273L,4423L,4723L,4787L,5023L,5233L,6047L,6079L,6679L,6709L,6829L,6869L,6967L,6977L,6997L,7687L,8089L,8233L,8293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245745Inst : IEnumerable<long>
{
public static readonly long[] Value=A245745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245745.Bytes);
public long this[int i]=>Value[i];

public static A245745Inst Instance=new A245745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245746
{
public static readonly long[] Value={ 9220303L,16079387L,17232253L,43606237L,66063373L,85403083L,97649917L,104719757L,159685553L,180467533L,197072563L,344777863L,492619373L,517774063L,647320727L,672712637L,715230127L,769494413L,790845563L,909545573L,944196137L,975302173L,1120585597L,1123182763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245746Inst : IEnumerable<long>
{
public static readonly long[] Value=A245746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245746.Bytes);
public long this[int i]=>Value[i];

public static A245746Inst Instance=new A245746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245747
{
public static readonly long[] Value={ 1L,2L,5L,10L,21L,42L,87L,178L,371L,773L,1630L,3447L,7346L,15712L,33790L,72922L,158020L,343494L,749101L,1638102L,3591723L,7893801L,17387930L,38379199L,84875595L,188036829L,417284180L,927469844L,2064465340L,4601670624L,10270463564L,22950838754L,51346678940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245747Inst : IEnumerable<long>
{
public static readonly long[] Value=A245747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245747.Bytes);
public long this[int i]=>Value[i];

public static A245747Inst Instance=new A245747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245748
{
public static readonly long[] Value={ 1L,3L,9L,25L,66L,170L,431L,1076L,2665L,6560L,16067L,39219L,95476L,231970L,562736L,1363640L,3301586L,7988916L,19322585L,46722160L,112955614L,273063236L,660116215L,1595906490L,3858740567L,9331539319L,22570697689L,54605064084L,132137719127L,319841444030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245748Inst : IEnumerable<long>
{
public static readonly long[] Value=A245748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245748.Bytes);
public long this[int i]=>Value[i];

public static A245748Inst Instance=new A245748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245749
{
public static readonly long[] Value={ 2L,6L,21L,63L,185L,512L,1403L,3750L,9928L,25969L,67462L,174039L,446884L,1142457L,2911078L,7396049L,18746761L,47420345L,119746936L,301941284L,760387426L,1912814031L,4807298905L,12071798139L,30292240853L,75965728619L,190398931985L,476980247827L,1194401725174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245749Inst : IEnumerable<long>
{
public static readonly long[] Value=A245749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245749.Bytes);
public long this[int i]=>Value[i];

public static A245749Inst Instance=new A245749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245750
{
public static readonly long[] Value={ 1L,7L,26L,91L,291L,885L,2588L,7373L,20555L,56413L,152812L,409696L,1089029L,2874506L,7542257L,19690939L,51188137L,132579401L,342294012L,881292334L,2263535926L,5801350565L,14840644204L,37901021924L,96650247055L,246137463494L,626087267035L,1590840361215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245750Inst : IEnumerable<long>
{
public static readonly long[] Value=A245750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245750.Bytes);
public long this[int i]=>Value[i];

public static A245750Inst Instance=new A245750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245751
{
public static readonly long[] Value={ 3L,15L,70L,256L,884L,2840L,8788L,26238L,76511L,218462L,614003L,1702291L,4667792L,12678438L,34163511L,91424125L,243210889L,643652954L,1695711086L,4449529462L,11634279616L,30324707572L,78819222196L,204348623105L,528597552113L,1364545143938L,3515960193715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245751Inst : IEnumerable<long>
{
public static readonly long[] Value=A245751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245751.Bytes);
public long this[int i]=>Value[i];

public static A245751Inst Instance=new A245751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245752
{
public static readonly long[] Value={ 3L,23L,114L,474L,1780L,6179L,20363L,64441L,197653L,591131L,1732165L,4989933L,14171244L,39760411L,110402589L,303808762L,829504935L,2249326273L,6062516975L,16252409052L,43361162336L,115191492778L,304834916107L,803891596292L,2113302899765L,5539657831304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245752Inst : IEnumerable<long>
{
public static readonly long[] Value=A245752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245752.Bytes);
public long this[int i]=>Value[i];

public static A245752Inst Instance=new A245752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245753
{
public static readonly long[] Value={ 1L,19L,113L,564L,2362L,9062L,32336L,109826L,358021L,1131089L,3480858L,10484995L,31012892L,90329292L,259621691L,737665484L,2074944123L,5785110380L,16003477783L,43963346701L,120021805899L,325835717520L,880125679307L,2366498068034L,6336725620724L,16903670460151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245753Inst : IEnumerable<long>
{
public static readonly long[] Value=A245753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245753.Bytes);
public long this[int i]=>Value[i];

public static A245753Inst Instance=new A245753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245754
{
public static readonly long[] Value={ 6L,63L,400L,2003L,8749L,34754L,128907L,453653L,1531833L,5001990L,15888511L,49313315L,150075356L,449080945L,1324309374L,3855721297L,11100436053L,31641094693L,89395066791L,250570651706L,697347017396L,1928281739720L,5300986280922L,14495618055341L,39446850848309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245754Inst : IEnumerable<long>
{
public static readonly long[] Value=A245754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245754.Bytes);
public long this[int i]=>Value[i];

public static A245754Inst Instance=new A245754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245755
{
public static readonly long[] Value={ 15L,147L,1003L,5286L,24396L,101768L,395410L,1452251L,5104104L,17300428L,56912396L,182543809L,573014123L,1765525901L,5352351017L,15996845972L,47213204699L,137795770991L,398168121417L,1140238386377L,3238947787201L,9133172049405L,25582174762816L,71220487524663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245755Inst : IEnumerable<long>
{
public static readonly long[] Value=A245755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245755.Bytes);
public long this[int i]=>Value[i];

public static A245755Inst Instance=new A245755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245756
{
public static readonly long[] Value={ 1L,1L,3L,1L,0L,1L,0L,2L,3L,1L,0L,1L,0L,0L,3L,1L,0L,1L,0L,2L,0L,1L,0L,2L,5L,0L,3L,1L,0L,1L,0L,2L,3L,0L,5L,1L,0L,38L,0L,1L,0L,1L,0L,2L,3L,1L,0L,0L,7L,0L,3L,1L,0L,0L,0L,2L,0L,1L,0L,1L,0L,0L,3L,0L,5L,1L,0L,4L,0L,1L,0L,1L,0L,74L,0L,0L,0L,1L,0L,2L,3L,1L,0L,2L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245756Inst : IEnumerable<long>
{
public static readonly long[] Value=A245756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245756.Bytes);
public long this[int i]=>Value[i];

public static A245756Inst Instance=new A245756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245757
{
public static readonly long[] Value={ 5L,7L,11L,13L,14L,17L,19L,21L,23L,26L,29L,31L,34L,37L,39L,41L,43L,47L,48L,50L,53L,54L,55L,57L,59L,61L,62L,64L,67L,69L,71L,73L,75L,76L,77L,79L,83L,86L,89L,90L,93L,94L,97L,98L,99L,101L,103L,107L,109L,110L,111L,113L,118L,119L,122L,125L,127L,128L,129L,131L,134L,137L,139L,141L,142L,143L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245757Inst : IEnumerable<long>
{
public static readonly long[] Value=A245757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245757.Bytes);
public long this[int i]=>Value[i];

public static A245757Inst Instance=new A245757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245758
{
public static readonly long[] Value={ 7L,8L,2L,7L,0L,4L,1L,8L,0L,1L,7L,1L,5L,2L,1L,7L,0L,1L,8L,4L,4L,7L,0L,7L,4L,9L,7L,7L,3L,4L,6L,0L,9L,0L,5L,5L,0L,2L,1L,3L,1L,2L,9L,5L,0L,9L,4L,8L,6L,3L,7L,5L,1L,4L,7L,7L,5L,8L,3L,1L,8L,5L,2L,0L,8L,6L,5L,0L,8L,9L,7L,3L,8L,9L,0L,8L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245758Inst : IEnumerable<long>
{
public static readonly long[] Value=A245758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245758.Bytes);
public long this[int i]=>Value[i];

public static A245758Inst Instance=new A245758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245759
{
public static readonly long[] Value={ 61L,83L,137L,139L,197L,199L,223L,241L,281L,313L,337L,353L,373L,397L,421L,449L,557L,577L,647L,719L,773L,809L,881L,937L,953L,971L,991L,1033L,1039L,1091L,1093L,1097L,1129L,1187L,1217L,1277L,1291L,1297L,1303L,1321L,1361L,1381L,1523L,1543L,1567L,1657L,1693L,1723L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245759Inst : IEnumerable<long>
{
public static readonly long[] Value=A245759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245759.Bytes);
public long this[int i]=>Value[i];

public static A245759Inst Instance=new A245759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245760
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,4L,3L,4L,3L,3L,3L,4L,3L,4L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245760Inst : IEnumerable<long>
{
public static readonly long[] Value=A245760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245760.Bytes);
public long this[int i]=>Value[i];

public static A245760Inst Instance=new A245760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245761
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245761Inst : IEnumerable<long>
{
public static readonly long[] Value=A245761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245761.Bytes);
public long this[int i]=>Value[i];

public static A245761Inst Instance=new A245761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245762
{
public static readonly long[] Value={ 1L,3L,9L,24L,56L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245762Inst : IEnumerable<long>
{
public static readonly long[] Value=A245762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245762.Bytes);
public long this[int i]=>Value[i];

public static A245762Inst Instance=new A245762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245763
{
public static readonly long[] Value={ 61L,337L,353L,449L,577L,881L,937L,971L,991L,1091L,1129L,1217L,1297L,1381L,1543L,1657L,1693L,2069L,2137L,2539L,2621L,2791L,3347L,3727L,3943L,4157L,4201L,4243L,4513L,4861L,5077L,5431L,5701L,5927L,6043L,6317L,6353L,6421L,6449L,6661L,6917L,7109L,7127L,7507L,7547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245763Inst : IEnumerable<long>
{
public static readonly long[] Value=A245763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245763.Bytes);
public long this[int i]=>Value[i];

public static A245763Inst Instance=new A245763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245764
{
public static readonly long[] Value={ 2L,4L,14L,20L,42L,52L,86L,100L,146L,164L,222L,244L,314L,340L,422L,452L,546L,580L,686L,724L,842L,884L,1014L,1060L,1202L,1252L,1406L,1460L,1626L,1684L,1862L,1924L,2114L,2180L,2382L,2452L,2666L,2740L,2966L,3044L,3282L,3364L,3614L,3700L,3962L,4052L,4326L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245764Inst : IEnumerable<long>
{
public static readonly long[] Value=A245764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245764.Bytes);
public long this[int i]=>Value[i];

public static A245764Inst Instance=new A245764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245765
{
public static readonly BigInteger[] Value={ 1L,1L,5L,54L,1004L,28500L,1145220L,61822320L,4314308544L,377894704320L,40585486536000L,5244015013776000L,802446580009071360L,BigInteger.Parse("143506045946368385280"),BigInteger.Parse("29655761650514250451200"),BigInteger.Parse("7012678074108426720000000") };
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
public class A245765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245765Inst Instance=new A245765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245766
{
public static readonly long[] Value={ 2L,4L,6L,20L,26L,52L,62L,100L,114L,164L,182L,244L,266L,340L,366L,452L,482L,580L,614L,724L,762L,884L,926L,1060L,1106L,1252L,1302L,1460L,1514L,1684L,1742L,1924L,1986L,2180L,2246L,2452L,2522L,2740L,2814L,3044L,3122L,3364L,3446L,3700L,3786L,4052L,4142L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245766Inst : IEnumerable<long>
{
public static readonly long[] Value=A245766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245766.Bytes);
public long this[int i]=>Value[i];

public static A245766Inst Instance=new A245766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245767
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,4L,19L,57L,66L,29L,219L,876L,1428L,1116L,355L,4231L,21155L,44500L,49070L,28405L,6942L,130023L,780138L,2013810L,2858700L,2354415L,1068576L,209527L,6129859L,42909013L,131457522L,228345565L,242894155L,158322528L,58628647L,9535241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245767Inst : IEnumerable<long>
{
public static readonly long[] Value=A245767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245767.Bytes);
public long this[int i]=>Value[i];

public static A245767Inst Instance=new A245767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245768
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,224L,2337L,28088L,377144L,5544824L,88039724L,1494960308L,26954440490L,513267546824L,10279486681982L,215822203235952L,4737785187211908L,108509135362455192L,2588049036893027820L,BigInteger.Parse("64180886929824389840"),BigInteger.Parse("1652564046132761428040"),BigInteger.Parse("44124859215715377422552"),BigInteger.Parse("1220338620776444854394561") };
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
public class A245768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245768Inst Instance=new A245768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245769
{
public static readonly long[] Value={ -1L,1L,7L,25L,87L,329L,1359L,6001L,27759L,132689L,649815L,3242377L,16421831L,84196761L,436129183L,2278835681L,11996748255L,63568974241L,338777252263L,1814623238137L,9763917858359L,52750451120361L,286036294786287L,1556185889290065L,8492182185653327L,46471113779766769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245769Inst : IEnumerable<long>
{
public static readonly long[] Value=A245769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245769.Bytes);
public long this[int i]=>Value[i];

public static A245769Inst Instance=new A245769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245770
{
public static readonly long[] Value={ 1L,9L,6L,5L,93L,84626L,3L,2L,502884L,69399L,5105820L,4944L,2L,816406286L,986L,4825342L,70L,9L,480865L,2L,66L,93L,55058L,25L,4081284L,174L,270L,85L,555964462L,4895L,9644288L,7566L,344L,28475648L,8L,65L,201L,45648L,23L,4543L,393L,2602L,412L,724L,660L,55L,74881L,20962L,25L,1715364L,892L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245770Inst : IEnumerable<long>
{
public static readonly long[] Value=A245770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245770.Bytes);
public long this[int i]=>Value[i];

public static A245770Inst Instance=new A245770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245771
{
public static readonly long[] Value={ 1L,7L,6L,7L,9L,9L,3L,7L,8L,6L,1L,3L,6L,1L,5L,4L,0L,5L,0L,4L,4L,3L,6L,3L,4L,4L,0L,6L,7L,8L,1L,1L,3L,2L,3L,3L,1L,0L,7L,7L,6L,8L,1L,4L,3L,3L,1L,3L,1L,9L,5L,6L,5L,1L,5L,5L,7L,6L,9L,8L,6L,0L,5L,9L,6L,2L,6L,0L,0L,0L,7L,6L,4L,6L,0L,6L,3L,8L,7L,5L,1L,4L,4L,4L,4L,8L,1L,6L,5L,1L,6L,3L,2L,5L,6L,8L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245771Inst : IEnumerable<long>
{
public static readonly long[] Value=A245771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245771.Bytes);
public long this[int i]=>Value[i];

public static A245771Inst Instance=new A245771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245772
{
public static readonly long[] Value={ 1L,8L,9L,5L,6L,0L,0L,4L,8L,3L,1L,6L,3L,5L,9L,9L,6L,5L,9L,1L,7L,7L,2L,4L,2L,0L,1L,1L,1L,6L,9L,6L,9L,6L,6L,0L,2L,0L,4L,2L,8L,5L,0L,7L,6L,2L,1L,4L,6L,3L,6L,6L,8L,1L,5L,8L,5L,1L,7L,9L,6L,0L,0L,9L,8L,7L,3L,2L,1L,9L,3L,3L,1L,2L,5L,4L,2L,4L,3L,5L,9L,5L,6L,7L,8L,8L,6L,1L,7L,7L,6L,2L,0L,3L,4L,0L,0L,4L,0L,0L,4L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245772Inst : IEnumerable<long>
{
public static readonly long[] Value=A245772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245772.Bytes);
public long this[int i]=>Value[i];

public static A245772Inst Instance=new A245772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245773
{
public static readonly long[] Value={ 1L,5L,11L,21L,29L,53L,55L,85L,104L,143L,131L,217L,181L,273L,317L,341L,305L,494L,379L,595L,603L,653L,551L,865L,744L,903L,950L,1141L,869L,1499L,991L,1365L,1439L,1523L,1593L,2002L,1405L,1893L,1989L,2395L,1721L,2877L,1891L,2737L,2990L,2753L,2255L,3441L,2736L,3658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245773Inst : IEnumerable<long>
{
public static readonly long[] Value=A245773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245773.Bytes);
public long this[int i]=>Value[i];

public static A245773Inst Instance=new A245773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245774
{
public static readonly long[] Value={ 1L,3L,6L,12L,28L,84L,120L,234L,270L,496L,672L,1080L,1488L,1638L,6048L,6552L,8128L,24384L,30240L,32760L,35640L,199584L,435708L,523776L,2142720L,2178540L,4713984L,12999168L,18506880L,23569920L,33550336L,36197280L,45532800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245774Inst : IEnumerable<long>
{
public static readonly long[] Value=A245774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245774.Bytes);
public long this[int i]=>Value[i];

public static A245774Inst Instance=new A245774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245775
{
public static readonly long[] Value={ 3L,12L,84L,234L,270L,1080L,1488L,1638L,6048L,6552L,24384L,35640L,199584L,435708L,2142720L,4713984L,12999168L,18506880L,36197280L,100651008L,208565280L,240589440L,275890944L,299980800L,470564640L,3899750400L,4138364160L,6039429120L,13286744064L,17827568640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245775Inst : IEnumerable<long>
{
public static readonly long[] Value=A245775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245775.Bytes);
public long this[int i]=>Value[i];

public static A245775Inst Instance=new A245775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245776
{
public static readonly long[] Value={ 0L,-1L,1L,-5L,13L,-1L,33L,1L,14L,7L,97L,-1L,141L,25L,43L,101L,253L,5L,321L,37L,313L,85L,481L,1L,532L,127L,569L,8L,781L,27L,897L,323L,299L,235L,1033L,53L,1293L,301L,1297L,11L,1597L,83L,1761L,179L,173L,457L,2113L,133L,2230L,971L,771L,529L,2701L,163L,2737L,34L,2929L,751L,3361L,11L,3597L,865L,1115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245776Inst : IEnumerable<long>
{
public static readonly long[] Value=A245776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245776.Bytes);
public long this[int i]=>Value[i];

public static A245776Inst Instance=new A245776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245777
{
public static readonly long[] Value={ 1L,2L,6L,12L,10L,2L,14L,8L,9L,10L,22L,3L,26L,14L,20L,80L,34L,6L,38L,30L,84L,22L,46L,2L,75L,26L,108L,3L,58L,20L,62L,96L,44L,34L,140L,36L,74L,38L,156L,4L,82L,28L,86L,33L,30L,46L,94L,60L,147L,150L,68L,78L,106L,36L,220L,7L,228L,58L,118L,5L,122L,62L,126L,448L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245777Inst : IEnumerable<long>
{
public static readonly long[] Value=A245777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245777.Bytes);
public long this[int i]=>Value[i];

public static A245777Inst Instance=new A245777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245778
{
public static readonly long[] Value={ 1L,672L,4680L,30240L,435708L,23569920L,45532800L,4138364160L,14182439040L,53798734080L,153003540480L,403031236608L,518666803200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245778Inst : IEnumerable<long>
{
public static readonly long[] Value=A245778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245778.Bytes);
public long this[int i]=>Value[i];

public static A245778Inst Instance=new A245778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245779
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,18L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245779Inst : IEnumerable<long>
{
public static readonly long[] Value=A245779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245779.Bytes);
public long this[int i]=>Value[i];

public static A245779Inst Instance=new A245779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245780
{
public static readonly long[] Value={ 1L,4L,8L,4L,9L,5L,5L,0L,6L,7L,7L,5L,9L,2L,2L,0L,4L,7L,9L,1L,8L,3L,5L,9L,9L,9L,4L,7L,0L,1L,3L,3L,9L,2L,1L,8L,4L,1L,4L,7L,6L,3L,8L,3L,7L,6L,2L,4L,8L,5L,9L,6L,2L,6L,9L,2L,9L,8L,5L,8L,1L,8L,8L,6L,2L,3L,8L,9L,2L,7L,9L,7L,1L,8L,5L,7L,5L,8L,2L,5L,8L,6L,3L,4L,9L,3L,7L,0L,2L,3L,3L,1L,0L,7L,8L,2L,3L,9L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245780Inst : IEnumerable<long>
{
public static readonly long[] Value=A245780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245780.Bytes);
public long this[int i]=>Value[i];

public static A245780Inst Instance=new A245780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245781
{
public static readonly long[] Value={ 3L,2L,8L,7L,0L,9L,6L,9L,1L,6L,8L,5L,6L,6L,3L,9L,3L,0L,3L,6L,2L,5L,9L,7L,6L,7L,0L,2L,3L,8L,3L,9L,6L,4L,3L,4L,0L,2L,0L,9L,9L,7L,6L,3L,8L,5L,5L,5L,8L,9L,8L,1L,2L,8L,8L,3L,0L,0L,3L,1L,8L,5L,4L,3L,5L,4L,7L,2L,1L,3L,5L,2L,6L,8L,4L,4L,0L,5L,9L,9L,7L,8L,9L,5L,5L,5L,3L,9L,0L,6L,2L,5L,7L,6L,7L,9L,9L,5L,6L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245781Inst : IEnumerable<long>
{
public static readonly long[] Value=A245781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245781.Bytes);
public long this[int i]=>Value[i];

public static A245781Inst Instance=new A245781Inst();

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