using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A211957
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,9L,12L,4L,1L,16L,40L,32L,8L,1L,25L,100L,140L,80L,16L,1L,36L,210L,448L,432L,192L,32L,1L,49L,392L,1176L,1680L,1232L,448L,64L,1L,64L,672L,2688L,5280L,5632L,3328L,1024L,128L,1L,81L,1080L,5544L,14256L,20592L,17472L,8640L,2304L,256L,1L,100L,1650L,10560L,34320L,64064L,72800L,51200L,21760L,5120L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211957Inst : IEnumerable<long>
{
public static readonly long[] Value=A211957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211957.Bytes);
public long this[int i]=>Value[i];

public static A211957Inst Instance=new A211957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211958
{
public static readonly long[] Value={ 0L,3L,12L,37L,90L,186L,343L,582L,927L,1405L,2046L,2883L,3952L,5292L,6945L,8956L,11373L,14247L,17632L,21585L,26166L,31438L,37467L,44322L,52075L,60801L,70578L,81487L,93612L,107040L,121861L,138168L,156057L,175627L,196980L,220221L,245458L,272802L,302367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211958Inst : IEnumerable<long>
{
public static readonly long[] Value=A211958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211958.Bytes);
public long this[int i]=>Value[i];

public static A211958Inst Instance=new A211958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211959
{
public static readonly long[] Value={ 0L,3L,43L,499L,3304L,15021L,53038L,156458L,403574L,938134L,2006916L,4011448L,7577023L,13642474L,23574489L,39310561L,63534983L,99892613L,153245449L,229977369L,338352706L,488934643L,695069728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211959Inst : IEnumerable<long>
{
public static readonly long[] Value=A211959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211959.Bytes);
public long this[int i]=>Value[i];

public static A211959Inst Instance=new A211959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211960
{
public static readonly long[] Value={ 0L,0L,65L,3146L,64705L,695587L,4904333L,25825865L,109813056L,396433235L,1257315972L,3589635788L,9392825390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211960Inst : IEnumerable<long>
{
public static readonly long[] Value=A211960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211960.Bytes);
public long this[int i]=>Value[i];

public static A211960Inst Instance=new A211960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211961
{
public static readonly long[] Value={ 0L,0L,67L,10112L,743866L,20556897L,303369413L,2935224783L,20968226394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211961Inst : IEnumerable<long>
{
public static readonly long[] Value=A211961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211961.Bytes);
public long this[int i]=>Value[i];

public static A211961Inst Instance=new A211961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211962
{
public static readonly long[] Value={ 0L,0L,67L,17947L,5225620L,408588191L,13307423101L,244159057556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211962Inst : IEnumerable<long>
{
public static readonly long[] Value=A211962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211962.Bytes);
public long this[int i]=>Value[i];

public static A211962Inst Instance=new A211962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211963
{
public static readonly long[] Value={ 0L,0L,3L,0L,3L,12L,0L,0L,43L,37L,0L,0L,65L,499L,90L,0L,0L,67L,3146L,3304L,186L,0L,0L,67L,10112L,64705L,15021L,343L,0L,0L,0L,17947L,743866L,695587L,53038L,582L,0L,0L,0L,21062L,5225620L,20556897L,4904333L,156458L,927L,0L,0L,0L,21348L,22803273L,408588191L,303369413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211963Inst : IEnumerable<long>
{
public static readonly long[] Value=A211963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211963.Bytes);
public long this[int i]=>Value[i];

public static A211963Inst Instance=new A211963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211964
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,8L,10L,12L,15L,17L,20L,24L,25L,27L,29L,32L,37L,40L,47L,51L,56L,63L,67L,73L,80L,82L,86L,90L,95L,103L,109L,120L,128L,136L,145L,151L,158L,166L,174L,182L,187L,193L,203L,210L,221L,232L,241L,250L,262L,271L,285L,294L,304L,318L,329L,343L,353L,362L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211964Inst : IEnumerable<long>
{
public static readonly long[] Value=A211964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211964.Bytes);
public long this[int i]=>Value[i];

public static A211964Inst Instance=new A211964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211965
{
public static readonly long[] Value={ 2L,4L,12L,40L,148L,572L,2248L,8920L,35536L,141860L,566880L,2266400L,9063372L,36249044L,144987304L,579931488L,2319690516L,9278691224L,37114623248L,148458209744L,593832272556L,2375327957436L,9501309564288L,38005233726372L,152020925844036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211965Inst : IEnumerable<long>
{
public static readonly long[] Value=A211965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211965.Bytes);
public long this[int i]=>Value[i];

public static A211965Inst Instance=new A211965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211966
{
public static readonly long[] Value={ 2L,6L,20L,74L,286L,1124L,4460L,17768L,70930L,283440L,1133200L,4531686L,18124522L,72493652L,289965744L,1159845258L,4639345612L,18557311624L,74229104872L,296916136278L,1187663978718L,4750654782144L,19002616863186L,76010462922018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211966Inst : IEnumerable<long>
{
public static readonly long[] Value=A211966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211966.Bytes);
public long this[int i]=>Value[i];

public static A211966Inst Instance=new A211966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211967
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,11L,16L,17L,18L,19L,22L,23L,32L,33L,34L,35L,37L,38L,39L,44L,46L,47L,64L,65L,66L,67L,68L,69L,70L,71L,74L,75L,76L,77L,78L,79L,88L,89L,92L,93L,94L,95L,128L,129L,130L,131L,132L,133L,134L,135L,137L,138L,139L,140L,141L,142L,143L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211967Inst : IEnumerable<long>
{
public static readonly long[] Value=A211967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211967.Bytes);
public long this[int i]=>Value[i];

public static A211967Inst Instance=new A211967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211968
{
public static readonly long[] Value={ 11L,110L,111L,1010L,1100L,1101L,1110L,1111L,10100L,10101L,11000L,11001L,11010L,11011L,11100L,11101L,11110L,11111L,100100L,101000L,101001L,101010L,101011L,101101L,110000L,110001L,110010L,110011L,110100L,110101L,110110L,110111L,111000L,111001L,111010L,111011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211968Inst : IEnumerable<long>
{
public static readonly long[] Value=A211968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211968.Bytes);
public long this[int i]=>Value[i];

public static A211968Inst Instance=new A211968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211969
{
public static readonly long[] Value={ 3L,6L,7L,10L,12L,13L,14L,15L,20L,21L,24L,25L,26L,27L,28L,29L,30L,31L,36L,40L,41L,42L,43L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,72L,73L,80L,81L,82L,83L,84L,85L,86L,87L,90L,91L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211969Inst : IEnumerable<long>
{
public static readonly long[] Value=A211969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211969.Bytes);
public long this[int i]=>Value[i];

public static A211969Inst Instance=new A211969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211970
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,6L,3L,1L,1L,1L,10L,5L,2L,1L,1L,1L,16L,7L,3L,1L,1L,1L,1L,24L,11L,4L,2L,1L,1L,1L,1L,36L,15L,5L,3L,1L,1L,1L,1L,1L,54L,22L,7L,4L,2L,1L,1L,1L,1L,1L,78L,30L,10L,4L,3L,1L,1L,1L,1L,1L,1L,112L,42L,13L,5L,4L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211970Inst : IEnumerable<long>
{
public static readonly long[] Value=A211970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211970.Bytes);
public long this[int i]=>Value[i];

public static A211970Inst Instance=new A211970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211971
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,10L,16L,24L,36L,54L,78L,112L,160L,224L,312L,432L,590L,802L,1084L,1452L,1936L,2568L,3384L,4440L,5800L,7538L,9758L,12584L,16160L,20680L,26376L,33520L,42468L,53644L,67552L,84832L,106246L,132706L,165344L,205512L,254824L,315256L,389168L,479368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211971Inst : IEnumerable<long>
{
public static readonly long[] Value=A211971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211971.Bytes);
public long this[int i]=>Value[i];

public static A211971Inst Instance=new A211971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211972
{
public static readonly long[] Value={ 2L,3L,5L,17L,41L,73L,89L,97L,137L,193L,257L,281L,313L,409L,521L,569L,577L,641L,673L,761L,929L,953L,1033L,1049L,1153L,1289L,1409L,1657L,1721L,1801L,1913L,2081L,2113L,2297L,2593L,2713L,3137L,3257L,3361L,3449L,3617L,4129L,4153L,4217L,4481L,4513L,4729L,4793L,4993L,5113L,5153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211972Inst : IEnumerable<long>
{
public static readonly long[] Value=A211972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211972.Bytes);
public long this[int i]=>Value[i];

public static A211972Inst Instance=new A211972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211973
{
public static readonly long[] Value={ 1L,5L,22L,91L,369L,1486L,5962L,23884L,95607L,382568L,1530552L,6122765L,24492171L,97970902L,391888040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211973Inst : IEnumerable<long>
{
public static readonly long[] Value=A211973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211973.Bytes);
public long this[int i]=>Value[i];

public static A211973Inst Instance=new A211973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211974
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,3L,3L,3L,5L,3L,5L,7L,1L,3L,3L,5L,9L,5L,13L,7L,9L,13L,7L,11L,13L,3L,7L,7L,9L,15L,11L,21L,15L,15L,17L,11L,13L,15L,15L,15L,9L,11L,19L,13L,21L,21L,17L,17L,23L,17L,27L,17L,19L,27L,21L,27L,19L,17L,17L,21L,31L,31L,25L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211974Inst : IEnumerable<long>
{
public static readonly long[] Value=A211974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211974.Bytes);
public long this[int i]=>Value[i];

public static A211974Inst Instance=new A211974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211975
{
public static readonly long[] Value={ 1L,3L,10L,37L,143L,562L,2230L,8884L,35465L,141720L,566600L,2265843L,9062261L,36246826L,144982872L,579922629L,2319672806L,9278655812L,37114552436L,148458068139L,593831989359L,2375327391072L,9501308431593L,38005231461009L,152020921313377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211975Inst : IEnumerable<long>
{
public static readonly long[] Value=A211975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211975.Bytes);
public long this[int i]=>Value[i];

public static A211975Inst Instance=new A211975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211976
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,3L,4L,1L,2L,2L,3L,5L,3L,7L,4L,5L,7L,4L,6L,7L,2L,4L,4L,5L,8L,6L,11L,8L,8L,9L,6L,7L,8L,8L,8L,5L,6L,10L,7L,11L,11L,9L,9L,12L,9L,14L,9L,10L,14L,11L,14L,10L,9L,9L,11L,16L,16L,13L,12L,11L,14L,14L,16L,17L,10L,10L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211976Inst : IEnumerable<long>
{
public static readonly long[] Value=A211976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211976.Bytes);
public long this[int i]=>Value[i];

public static A211976Inst Instance=new A211976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211977
{
public static readonly long[] Value={ 1L,3L,1L,5L,5L,1L,10L,15L,7L,1L,14L,35L,28L,9L,1L,26L,75L,85L,45L,11L,1L,35L,140L,217L,166L,66L,13L,1L,57L,259L,497L,505L,287L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211977Inst : IEnumerable<long>
{
public static readonly long[] Value=A211977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211977.Bytes);
public long this[int i]=>Value[i];

public static A211977Inst Instance=new A211977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211978
{
public static readonly long[] Value={ 0L,2L,6L,12L,24L,40L,70L,108L,172L,256L,384L,550L,798L,1112L,1560L,2136L,2926L,3930L,5288L,6996L,9260L,12104L,15798L,20412L,26348L,33702L,43044L,54588L,69090L,86906L,109126L,136270L,169854L,210732L,260924L,321752L,396028L,485624L,594402L,725174L,883092L,1072208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211978Inst : IEnumerable<long>
{
public static readonly long[] Value=A211978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211978.Bytes);
public long this[int i]=>Value[i];

public static A211978Inst Instance=new A211978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211979
{
public static readonly BigInteger[] Value={ 110L,11100L,111110000L,1111111000000L,BigInteger.Parse("111111111110000000000"),BigInteger.Parse("1111111111111000000000000"),BigInteger.Parse("111111111111111110000000000000000"),BigInteger.Parse("1111111111111111111000000000000000000"),BigInteger.Parse("111111111111111111111110000000000000000000000") };
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
public class A211979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A211979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A211979Inst Instance=new A211979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211980
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,4L,3L,2L,7L,6L,5L,4L,2L,11L,10L,9L,8L,6L,4L,15L,14L,13L,12L,10L,8L,4L,22L,21L,20L,19L,17L,15L,11L,7L,30L,29L,28L,27L,25L,23L,19L,15L,8L,42L,41L,40L,39L,37L,35L,31L,27L,20L,12L,56L,55L,54L,53L,51L,49L,45L,41L,34L,26L,14L,77L,76L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211980Inst : IEnumerable<long>
{
public static readonly long[] Value=A211980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211980.Bytes);
public long this[int i]=>Value[i];

public static A211980Inst Instance=new A211980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211981
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,10L,16L,21L,32L,42L,64L,75L,85L,113L,128L,151L,170L,227L,256L,341L,512L,682L,1024L,1365L,2048L,2730L,4096L,5461L,7281L,8192L,10922L,14563L,16384L,21845L,32768L,43690L,65536L,87381L,131072L,174762L,262144L,349525L,466033L,524288L,699050L,932067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211981Inst : IEnumerable<long>
{
public static readonly long[] Value=A211981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211981.Bytes);
public long this[int i]=>Value[i];

public static A211981Inst Instance=new A211981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211982
{
public static readonly long[] Value={ 2L,6L,10L,20L,28L,52L,70L,114L,160L,238L,322L,476L,630L,880L,1178L,1602L,2096L,2814L,3640L,4798L,6174L,7996L,10184L,13090L,16526L,20972L,26330L,33124L,41260L,51546L,63794L,79092L,97384L,119920L,146846L,179874L,219106L,266878L,323680L,392336L,473686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211982Inst : IEnumerable<long>
{
public static readonly long[] Value=A211982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211982.Bytes);
public long this[int i]=>Value[i];

public static A211982Inst Instance=new A211982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211983
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,4L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,4L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,2L,5L,6L,3L,3L,4L,2L,2L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,2L,1L,5L,1L,6L,1L,3L,3L,1L,4L,2L,1L,2L,2L,2L,1L,4L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,2L,1L,1L,5L,1L,1L,3L,2L,2L,5L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211983Inst : IEnumerable<long>
{
public static readonly long[] Value=A211983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211983.Bytes);
public long this[int i]=>Value[i];

public static A211983Inst Instance=new A211983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211984
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,4L,5L,3L,2L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,4L,1L,5L,1L,3L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,2L,2L,2L,4L,2L,3L,3L,6L,7L,4L,3L,5L,2L,3L,2L,2L,5L,1L,1L,3L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,3L,2L,1L,1L,5L,1L,1L,4L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211984Inst : IEnumerable<long>
{
public static readonly long[] Value=A211984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211984.Bytes);
public long this[int i]=>Value[i];

public static A211984Inst Instance=new A211984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211985
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,1L,1L,2L,4L,2L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,5L,2L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,4L,6L,3L,3L,4L,2L,2L,2L,2L,1L,4L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,3L,1L,5L,1L,7L,3L,4L,2L,5L,2L,2L,3L,1L,5L,1L,1L,2L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,2L,2L,2L,1L,4L,2L,1L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211985Inst : IEnumerable<long>
{
public static readonly long[] Value=A211985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211985.Bytes);
public long this[int i]=>Value[i];

public static A211985Inst Instance=new A211985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211986
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,1L,2L,1L,4L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,3L,5L,3L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,4L,1L,6L,3L,3L,2L,4L,2L,2L,2L,1L,4L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,2L,1L,5L,7L,4L,3L,5L,2L,3L,2L,2L,1L,5L,1L,1L,3L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,2L,2L,2L,1L,2L,4L,1L,3L,3L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211986Inst : IEnumerable<long>
{
public static readonly long[] Value=A211986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211986.Bytes);
public long this[int i]=>Value[i];

public static A211986Inst Instance=new A211986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211987
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,4L,2L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,4L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,3L,5L,6L,3L,3L,4L,2L,2L,2L,2L,1L,4L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,3L,1L,5L,1L,1L,6L,1L,3L,3L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211987Inst : IEnumerable<long>
{
public static readonly long[] Value=A211987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211987.Bytes);
public long this[int i]=>Value[i];

public static A211987Inst Instance=new A211987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211988
{
public static readonly long[] Value={ 0L,-6L,-37L,676L,2882L,12502L,-196209L,-856850L,-3740697L,58876883L,257003504L,1121852777L,-17656510365L,-77073076671L,-336434457597L,5295048110651L,23113603862267L,100894018986142L,-1587942800101489L,-6931585922526870L,-30257313674299627L,476211413709501353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211988Inst : IEnumerable<long>
{
public static readonly long[] Value=A211988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211988.Bytes);
public long this[int i]=>Value[i];

public static A211988Inst Instance=new A211988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211989
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,1L,2L,1L,4L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,5L,3L,2L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,4L,1L,6L,3L,3L,4L,2L,2L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,2L,1L,5L,1L,7L,4L,3L,5L,2L,3L,2L,2L,5L,1L,1L,3L,2L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,2L,1L,4L,2L,1L,3L,3L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211989Inst : IEnumerable<long>
{
public static readonly long[] Value=A211989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211989.Bytes);
public long this[int i]=>Value[i];

public static A211989Inst Instance=new A211989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211990
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,2L,3L,4L,5L,2L,4L,5L,6L,7L,4L,6L,8L,9L,10L,11L,4L,8L,10L,12L,13L,14L,15L,7L,11L,15L,17L,19L,20L,21L,22L,8L,15L,19L,23L,25L,27L,28L,29L,30L,12L,20L,27L,31L,35L,37L,39L,40L,41L,42L,14L,26L,34L,41L,45L,49L,51L,53L,54L,55L,56L,21L,35L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211990Inst : IEnumerable<long>
{
public static readonly long[] Value=A211990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211990.Bytes);
public long this[int i]=>Value[i];

public static A211990Inst Instance=new A211990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211991
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,-1L,0L,5L,2L,-1L,0L,0L,0L,-1L,-1L,17L,0L,0L,0L,2L,-1L,-1L,0L,8L,4L,-1L,14L,4L,0L,-11L,0L,49L,-1L,-1L,-1L,5L,0L,-1L,-1L,18L,0L,-13L,0L,8L,6L,-1L,0L,36L,6L,2L,-1L,10L,0L,15L,-1L,28L,-1L,-1L,0L,-16L,0L,-1L,10L,129L,-1L,-17L,0L,14L,-1L,-15L,0L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211991Inst : IEnumerable<long>
{
public static readonly long[] Value=A211991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211991.Bytes);
public long this[int i]=>Value[i];

public static A211991Inst Instance=new A211991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211992
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,2L,1L,1L,3L,1L,2L,2L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,4L,1L,3L,2L,5L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,3L,2L,1L,5L,1L,2L,2L,2L,4L,2L,3L,3L,6L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,3L,2L,1L,1L,5L,1L,1L,2L,2L,2L,1L,4L,2L,1L,3L,3L,1L,6L,1L,3L,2L,2L,5L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211992Inst : IEnumerable<long>
{
public static readonly long[] Value=A211992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211992.Bytes);
public long this[int i]=>Value[i];

public static A211992Inst Instance=new A211992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211993
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,4L,2L,2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,4L,1L,3L,2L,5L,6L,3L,3L,4L,2L,2L,2L,2L,5L,1L,3L,2L,1L,4L,1L,1L,2L,2L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,4L,1L,1L,1L,3L,2L,1L,1L,5L,1L,1L,2L,2L,2L,1L,4L,2L,1L,3L,3L,1L,6L,1L,3L,2L,2L,5L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211993Inst : IEnumerable<long>
{
public static readonly long[] Value=A211993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211993.Bytes);
public long this[int i]=>Value[i];

public static A211993Inst Instance=new A211993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211994
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,2L,2L,4L,5L,3L,2L,4L,1L,2L,2L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,3L,2L,1L,5L,1L,2L,2L,2L,4L,2L,3L,3L,6L,7L,4L,3L,5L,2L,3L,2L,2L,6L,1L,3L,3L,1L,4L,2L,1L,2L,2L,2L,1L,5L,1L,1L,3L,2L,1L,1L,4L,1L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211994Inst : IEnumerable<long>
{
public static readonly long[] Value=A211994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211994.Bytes);
public long this[int i]=>Value[i];

public static A211994Inst Instance=new A211994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211995
{
public static readonly long[] Value={ 0L,1L,0L,2L,6L,13L,46L,33L,246L,479L,398L,883L,20L,6215L,9467L,16751L,42245L,115091L,140675L,492363L,674695L,1312859L,2497856L,2451041L,4384342L,6956591L,24348068L,118772672L,147268896L,112787953L,394757837L,844781520L,809251672L,2832380853L,1323398395L,13221828975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211995Inst : IEnumerable<long>
{
public static readonly long[] Value=A211995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211995.Bytes);
public long this[int i]=>Value[i];

public static A211995Inst Instance=new A211995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211996
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,2L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,4L,1L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211996Inst : IEnumerable<long>
{
public static readonly long[] Value=A211996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211996.Bytes);
public long this[int i]=>Value[i];

public static A211996Inst Instance=new A211996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211997
{
public static readonly long[] Value={ 2L,3L,7L,23L,31L,127L,127L,383L,991L,2039L,3583L,6143L,8191L,63487L,63487L,129023L,131071L,522239L,524287L,1966079L,4128767L,14680063L,14680063L,33546239L,67108351L,201064447L,260046847L,536739839L,1073479679L,2147483647L,2147483647L,8581545983L,16911433727L,32212254719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211997Inst : IEnumerable<long>
{
public static readonly long[] Value=A211997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211997.Bytes);
public long this[int i]=>Value[i];

public static A211997Inst Instance=new A211997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211998
{
public static readonly long[] Value={ 6L,14L,22L,30L,38L,62L,78L,94L,126L,174L,206L,254L,510L,542L,606L,766L,1022L,1278L,2046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211998Inst : IEnumerable<long>
{
public static readonly long[] Value=A211998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211998.Bytes);
public long this[int i]=>Value[i];

public static A211998Inst Instance=new A211998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A211999
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,4L,4L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,2L,5L,5L,1L,3L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,2L,2L,2L,4L,2L,3L,3L,6L,6L,1L,3L,3L,1L,4L,2L,1L,2L,2L,2L,1L,4L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,2L,1L,1L,5L,1L,1L,3L,2L,2L,5L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A211999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A211999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A211999Inst : IEnumerable<long>
{
public static readonly long[] Value=A211999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A211999.Bytes);
public long this[int i]=>Value[i];

public static A211999Inst Instance=new A211999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212000
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,3L,12L,11L,9L,6L,20L,19L,17L,14L,8L,35L,34L,32L,29L,23L,15L,54L,53L,51L,48L,42L,34L,19L,86L,85L,83L,80L,74L,66L,51L,32L,128L,127L,125L,122L,116L,108L,93L,74L,42L,192L,191L,189L,186L,180L,172L,157L,138L,106L,64L,275L,274L,272L,269L,263L,255L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212000Inst : IEnumerable<long>
{
public static readonly long[] Value=A212000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212000.Bytes);
public long this[int i]=>Value[i];

public static A212000Inst Instance=new A212000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212001
{
public static readonly long[] Value={ 1L,4L,3L,9L,8L,5L,20L,19L,16L,11L,35L,34L,31L,26L,15L,66L,65L,62L,57L,46L,31L,105L,104L,101L,96L,85L,70L,39L,176L,175L,172L,167L,156L,141L,110L,71L,270L,269L,266L,261L,250L,235L,204L,165L,94L,420L,419L,416L,411L,400L,385L,354L,315L,244L,150L,616L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212001Inst : IEnumerable<long>
{
public static readonly long[] Value=A212001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212001.Bytes);
public long this[int i]=>Value[i];

public static A212001Inst Instance=new A212001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212002
{
public static readonly long[] Value={ 3L,9L,4L,7L,8L,4L,1L,7L,6L,0L,4L,3L,5L,7L,4L,3L,4L,4L,7L,5L,3L,3L,7L,9L,6L,3L,9L,9L,9L,5L,0L,4L,6L,0L,4L,5L,4L,1L,2L,5L,4L,7L,9L,7L,6L,2L,8L,9L,6L,3L,1L,6L,2L,5L,0L,5L,6L,5L,3L,3L,9L,7L,5L,0L,4L,8L,8L,0L,1L,7L,9L,2L,8L,9L,6L,7L,6L,8L,2L,0L,9L,7L,2L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212002Inst : IEnumerable<long>
{
public static readonly long[] Value=A212002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212002.Bytes);
public long this[int i]=>Value[i];

public static A212002Inst Instance=new A212002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212003
{
public static readonly long[] Value={ 2L,4L,8L,0L,5L,0L,2L,1L,3L,4L,4L,2L,3L,9L,8L,5L,6L,1L,4L,0L,3L,8L,1L,0L,5L,2L,0L,5L,3L,6L,8L,1L,1L,1L,6L,1L,6L,1L,7L,8L,0L,2L,3L,0L,8L,5L,2L,7L,0L,8L,0L,8L,6L,1L,5L,5L,3L,1L,5L,6L,3L,0L,4L,8L,3L,0L,4L,5L,1L,1L,5L,9L,3L,3L,9L,7L,2L,5L,6L,4L,8L,3L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212003Inst : IEnumerable<long>
{
public static readonly long[] Value=A212003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212003.Bytes);
public long this[int i]=>Value[i];

public static A212003Inst Instance=new A212003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212004
{
public static readonly long[] Value={ 1L,5L,5L,8L,5L,4L,5L,4L,5L,6L,5L,4L,4L,0L,3L,8L,9L,9L,5L,7L,8L,3L,0L,4L,5L,3L,2L,3L,0L,1L,9L,2L,8L,1L,7L,7L,9L,9L,9L,5L,6L,4L,1L,3L,7L,0L,7L,6L,2L,9L,6L,6L,7L,4L,7L,0L,6L,3L,4L,8L,5L,7L,5L,0L,2L,3L,9L,5L,3L,3L,6L,8L,7L,3L,0L,9L,2L,3L,5L,1L,3L,9L,0L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212004Inst : IEnumerable<long>
{
public static readonly long[] Value=A212004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212004.Bytes);
public long this[int i]=>Value[i];

public static A212004Inst Instance=new A212004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212005
{
public static readonly long[] Value={ 9L,7L,9L,2L,6L,2L,9L,9L,1L,3L,1L,2L,9L,0L,0L,6L,5L,0L,4L,4L,0L,7L,7L,2L,1L,9L,2L,1L,3L,8L,9L,9L,3L,9L,4L,0L,7L,3L,6L,9L,6L,2L,2L,6L,1L,2L,0L,9L,8L,3L,9L,9L,6L,9L,7L,7L,1L,1L,7L,5L,8L,1L,9L,7L,9L,5L,9L,5L,1L,9L,7L,4L,8L,2L,7L,5L,6L,4L,8L,7L,8L,3L,5L,4L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212005Inst : IEnumerable<long>
{
public static readonly long[] Value=A212005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212005.Bytes);
public long this[int i]=>Value[i];

public static A212005Inst Instance=new A212005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212006
{
public static readonly long[] Value={ 6L,1L,5L,2L,8L,9L,0L,8L,3L,8L,8L,8L,1L,9L,4L,8L,3L,9L,6L,9L,9L,3L,4L,0L,4L,4L,3L,9L,3L,7L,5L,4L,8L,7L,3L,5L,2L,7L,5L,0L,1L,9L,2L,1L,7L,9L,7L,1L,8L,6L,9L,8L,3L,4L,2L,0L,2L,2L,8L,8L,7L,5L,9L,9L,8L,9L,8L,2L,0L,1L,0L,4L,2L,1L,9L,1L,0L,4L,1L,3L,6L,6L,3L,9L,5L,0L,1L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212006Inst : IEnumerable<long>
{
public static readonly long[] Value=A212006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212006.Bytes);
public long this[int i]=>Value[i];

public static A212006Inst Instance=new A212006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212007
{
public static readonly long[] Value={ 3L,8L,6L,5L,9L,7L,5L,3L,3L,1L,5L,5L,4L,2L,9L,3L,8L,4L,6L,4L,1L,8L,1L,8L,4L,3L,1L,1L,1L,3L,2L,2L,1L,3L,5L,4L,4L,8L,5L,4L,3L,1L,3L,5L,6L,8L,3L,7L,8L,1L,1L,4L,8L,9L,6L,3L,2L,5L,4L,2L,0L,1L,5L,0L,2L,5L,0L,4L,1L,2L,3L,7L,4L,1L,3L,5L,8L,2L,3L,2L,0L,7L,6L,0L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212007Inst : IEnumerable<long>
{
public static readonly long[] Value=A212007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212007.Bytes);
public long this[int i]=>Value[i];

public static A212007Inst Instance=new A212007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212008
{
public static readonly long[] Value={ 0L,1L,5L,13L,29L,51L,71L,95L,131L,171L,203L,247L,303L,397L,457L,513L,589L,661L,693L,741L,813L,925L,1057L,1197L,1333L,1501L,1613L,1745L,1885L,2123L,2271L,2391L,2547L,2683L,2715L,2763L,2835L,2947L,3079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212008Inst : IEnumerable<long>
{
public static readonly long[] Value=A212008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212008.Bytes);
public long this[int i]=>Value[i];

public static A212008Inst Instance=new A212008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212009
{
public static readonly long[] Value={ 0L,1L,4L,8L,16L,22L,20L,24L,36L,40L,32L,44L,56L,94L,60L,56L,76L,72L,32L,48L,72L,112L,132L,140L,136L,168L,112L,132L,140L,238L,148L,120L,156L,136L,32L,48L,72L,112L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212009Inst : IEnumerable<long>
{
public static readonly long[] Value=A212009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212009.Bytes);
public long this[int i]=>Value[i];

public static A212009Inst Instance=new A212009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212010
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,6L,9L,11L,12L,8L,14L,17L,19L,20L,15L,23L,29L,32L,34L,35L,19L,34L,42L,48L,51L,53L,54L,32L,51L,66L,74L,80L,83L,85L,86L,42L,74L,93L,108L,116L,122L,125L,127L,128L,64L,106L,138L,157L,172L,180L,186L,189L,191L,192L,83L,147L,189L,221L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212010Inst : IEnumerable<long>
{
public static readonly long[] Value=A212010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212010.Bytes);
public long this[int i]=>Value[i];

public static A212010Inst Instance=new A212010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212011
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,9L,11L,16L,19L,20L,15L,26L,31L,34L,35L,31L,46L,57L,62L,65L,66L,39L,70L,85L,96L,101L,104L,105L,71L,110L,141L,156L,167L,172L,175L,176L,94L,165L,204L,235L,250L,261L,266L,269L,270L,150L,244L,315L,354L,385L,400L,411L,416L,419L,420L,196L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212011Inst : IEnumerable<long>
{
public static readonly long[] Value=A212011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212011.Bytes);
public long this[int i]=>Value[i];

public static A212011Inst Instance=new A212011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212012
{
public static readonly long[] Value={ 2L,4L,2L,6L,4L,2L,8L,6L,4L,2L,10L,8L,6L,4L,2L,12L,10L,8L,6L,4L,2L,14L,12L,10L,8L,6L,4L,2L,16L,14L,12L,10L,8L,6L,4L,2L,18L,16L,14L,12L,10L,8L,6L,4L,2L,20L,18L,16L,14L,12L,10L,8L,6L,4L,2L,22L,20L,18L,16L,14L,12L,10L,8L,6L,4L,2L,24L,22L,20L,18L,16L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212012Inst : IEnumerable<long>
{
public static readonly long[] Value=A212012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212012.Bytes);
public long this[int i]=>Value[i];

public static A212012Inst Instance=new A212012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212013
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,14L,17L,19L,20L,25L,29L,32L,34L,35L,41L,46L,50L,53L,55L,56L,63L,69L,74L,78L,81L,83L,84L,92L,99L,105L,110L,114L,117L,119L,120L,129L,137L,144L,150L,155L,159L,162L,164L,165L,175L,184L,192L,199L,205L,210L,214L,217L,219L,220L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212013Inst : IEnumerable<long>
{
public static readonly long[] Value=A212013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212013.Bytes);
public long this[int i]=>Value[i];

public static A212013Inst Instance=new A212013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212014
{
public static readonly long[] Value={ 2L,6L,8L,14L,18L,20L,28L,34L,38L,40L,50L,58L,64L,68L,70L,82L,92L,100L,106L,110L,112L,126L,138L,148L,156L,162L,166L,168L,184L,198L,210L,220L,228L,234L,238L,240L,258L,274L,288L,300L,310L,318L,324L,328L,330L,350L,368L,384L,398L,410L,420L,428L,434L,438L,440L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212014Inst : IEnumerable<long>
{
public static readonly long[] Value=A212014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212014.Bytes);
public long this[int i]=>Value[i];

public static A212014Inst Instance=new A212014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212015
{
public static readonly long[] Value={ 2L,5L,6L,10L,13L,14L,15L,19L,28L,29L,30L,31L,35L,41L,44L,50L,54L,55L,56L,60L,61L,69L,77L,85L,86L,90L,91L,92L,96L,105L,110L,113L,126L,135L,139L,140L,141L,145L,146L,149L,154L,170L,174L,181L,182L,190L,194L,195L,199L,203L,204L,205L,209L,218L,221L,230L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212015Inst : IEnumerable<long>
{
public static readonly long[] Value=A212015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212015.Bytes);
public long this[int i]=>Value[i];

public static A212015Inst Instance=new A212015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212016
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,13L,14L,15L,19L,25L,28L,29L,30L,31L,35L,41L,44L,50L,54L,55L,56L,60L,61L,69L,77L,85L,86L,90L,91L,92L,96L,105L,110L,113L,121L,126L,135L,139L,140L,141L,145L,146L,149L,154L,170L,174L,181L,182L,190L,194L,195L,199L,203L,204L,205L,209L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212016Inst : IEnumerable<long>
{
public static readonly long[] Value=A212016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212016.Bytes);
public long this[int i]=>Value[i];

public static A212016Inst Instance=new A212016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212017
{
public static readonly long[] Value={ 0L,1L,4L,9L,11L,16L,25L,26L,36L,47L,49L,64L,65L,66L,81L,100L,109L,121L,144L,169L,196L,225L,256L,289L,324L,361L,400L,441L,484L,529L,576L,625L,676L,729L,784L,841L,900L,921L,935L,961L,1024L,1079L,1089L,1156L,1225L,1296L,1369L,1444L,1521L,1600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212017Inst : IEnumerable<long>
{
public static readonly long[] Value=A212017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212017.Bytes);
public long this[int i]=>Value[i];

public static A212017Inst Instance=new A212017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212018
{
public static readonly long[] Value={ 1L,11L,26L,47L,65L,66L,109L,921L,935L,1079L,2161L,2820L,2860L,5029L,9105L,10681L,12284L,13156L,16761L,18340L,41921L,43500L,61721L,63765L,64605L,66317L,75130L,99359L,105731L,116180L,122009L,146821L,159371L,218205L,253393L,260165L,264680L,269588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212018Inst : IEnumerable<long>
{
public static readonly long[] Value=A212018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212018.Bytes);
public long this[int i]=>Value[i];

public static A212018Inst Instance=new A212018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212019
{
public static readonly long[] Value={ 0L,0L,4L,8L,24L,32L,64L,76L,124L,154L,214L,234L,340L,364L,452L,532L,664L,696L,854L,890L,1086L,1206L,1350L,1394L,1692L,1794L,1966L,2108L,2396L,2452L,2822L,2882L,3212L,3408L,3636L,3860L,4360L,4432L,4688L,4920L,5470L,5550L,6090L,6174L,6642L,7056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212019Inst : IEnumerable<long>
{
public static readonly long[] Value=A212019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212019.Bytes);
public long this[int i]=>Value[i];

public static A212019Inst Instance=new A212019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212020
{
public static readonly long[] Value={ 0L,0L,0L,8L,14L,18L,48L,56L,74L,126L,154L,166L,262L,278L,318L,422L,480L,500L,674L,698L,800L,956L,1024L,1052L,1308L,1378L,1458L,1698L,1852L,1888L,2240L,2280L,2434L,2686L,2794L,2950L,3472L,3520L,3640L,3944L,4234L,4286L,4800L,4856L,5102L,5672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212020Inst : IEnumerable<long>
{
public static readonly long[] Value=A212020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212020.Bytes);
public long this[int i]=>Value[i];

public static A212020Inst Instance=new A212020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212021
{
public static readonly long[] Value={ 0L,0L,0L,8L,16L,20L,48L,56L,80L,132L,164L,176L,272L,288L,332L,436L,512L,532L,696L,720L,844L,1000L,1076L,1104L,1360L,1430L,1518L,1758L,1942L,1978L,2328L,2368L,2566L,2818L,2938L,3098L,3600L,3648L,3780L,4084L,4440L,4492L,4996L,5052L,5348L,5920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212021Inst : IEnumerable<long>
{
public static readonly long[] Value=A212021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212021.Bytes);
public long this[int i]=>Value[i];

public static A212021Inst Instance=new A212021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212022
{
public static readonly long[] Value={ 0L,2L,25L,346L,2589L,12636L,46612L,141520L,372416L,878329L,1899446L,3828397L,7278790L,13174461L,22863219L,38259181L,62018107L,97750460L,150277231L,225933884L,332928091L,481757242L,685692030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212022Inst : IEnumerable<long>
{
public static readonly long[] Value=A212022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212022.Bytes);
public long this[int i]=>Value[i];

public static A212022Inst Instance=new A212022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212023
{
public static readonly long[] Value={ 0L,0L,34L,1793L,44294L,532619L,4022727L,22156544L,97173498L,358710379L,1156729484L,3344765527L,8839882229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212023Inst : IEnumerable<long>
{
public static readonly long[] Value=A212023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212023.Bytes);
public long this[int i]=>Value[i];

public static A212023Inst Instance=new A212023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212024
{
public static readonly long[] Value={ 0L,0L,35L,4785L,440660L,14245030L,231475447L,2383699176L,17770342627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212024Inst : IEnumerable<long>
{
public static readonly long[] Value=A212024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212024.Bytes);
public long this[int i]=>Value[i];

public static A212024Inst Instance=new A212024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212025
{
public static readonly long[] Value={ 0L,0L,35L,7396L,2655126L,254601542L,9411294829L,187291345391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212025Inst : IEnumerable<long>
{
public static readonly long[] Value=A212025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212025.Bytes);
public long this[int i]=>Value[i];

public static A212025Inst Instance=new A212025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212026
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,9L,0L,0L,25L,31L,0L,0L,34L,346L,80L,0L,0L,35L,1793L,2589L,171L,0L,0L,35L,4785L,44294L,12636L,322L,0L,0L,0L,7396L,440660L,532619L,46612L,554L,0L,0L,0L,8220L,2655126L,14245030L,4022727L,141520L,891L,0L,0L,0L,8291L,9881099L,254601542L,231475447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212026Inst : IEnumerable<long>
{
public static readonly long[] Value=A212026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212026.Bytes);
public long this[int i]=>Value[i];

public static A212026Inst Instance=new A212026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212027
{
public static readonly ulong[] Value={ 1L,1L,2L,7L,34L,203L,1405L,10902L,92856L,855879L,8451785L,88756905L,985639145L,11522892870L,141307864173L,1812306734024L,24246751794221L,337657449975797L,4884937564807339L,73291058678194555L,1138608805124859321L,18289927572984177863UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212027Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A212027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212027.Bytes);
public ulong this[int i]=>Value[i];

public static A212027Inst Instance=new A212027Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212028
{
public static readonly BigInteger[] Value={ 1L,1L,2L,11L,74L,635L,6296L,70268L,864106L,11546531L,165996792L,2548556963L,41546769324L,715850868468L,12986529841038L,247255748839532L,4926870211273246L,102495266879754087L,2221254395951869988L,BigInteger.Parse("50049980203162990978"),BigInteger.Parse("1170440788530570387644") };
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
public class A212028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212028Inst Instance=new A212028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212029
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,190L,2112L,26922L,382110L,5920788L,98862273L,1762572957L,33325846461L,664774457583L,13932829786025L,305788481726799L,7008171327166869L,167321925537782445L,4153009604547937170L,BigInteger.Parse("106963758805117459392"),BigInteger.Parse("2854029374011293902121"),BigInteger.Parse("78773444214057182702790") };
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
public class A212029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212029Inst Instance=new A212029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212030
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,142L,1350L,14607L,174626L,2263749L,31426878L,463144150L,7199095692L,117452998632L,2003613768328L,35628141598164L,658723330672311L,12636278430184303L,251042922016657782L,5156985005918404047L,BigInteger.Parse("109382326645948764003"),BigInteger.Parse("2392477607054828471286") };
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
public class A212030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212030Inst Instance=new A212030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212031
{
public static readonly long[] Value={ 0L,3L,10L,31L,78L,166L,313L,540L,871L,1333L,1956L,2773L,3820L,5136L,6763L,8746L,11133L,13975L,17326L,21243L,25786L,31018L,37005L,43816L,51523L,60201L,69928L,80785L,92856L,106228L,120991L,137238L,155065L,174571L,195858L,219031L,244198L,271470L,300961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212031Inst : IEnumerable<long>
{
public static readonly long[] Value=A212031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212031.Bytes);
public long this[int i]=>Value[i];

public static A212031Inst Instance=new A212031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212032
{
public static readonly long[] Value={ 0L,3L,28L,338L,2440L,11859L,43943L,134273L,355568L,843290L,1832469L,3708583L,7075643L,12844948L,22348290L,37479704L,60870173L,96100013L,147953978L,222724440L,328568314L,475923713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212032Inst : IEnumerable<long>
{
public static readonly long[] Value=A212032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212032.Bytes);
public long this[int i]=>Value[i];

public static A212032Inst Instance=new A212032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212033
{
public static readonly long[] Value={ 0L,0L,34L,1651L,39901L,480914L,3668669L,20431909L,90528036L,337143876L,1095367909L,3187460809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212033Inst : IEnumerable<long>
{
public static readonly long[] Value=A212033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212033.Bytes);
public long this[int i]=>Value[i];

public static A212033Inst Instance=new A212033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212034
{
public static readonly long[] Value={ 0L,0L,34L,3967L,373930L,12302859L,203628239L,2132961900L,16137269619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212034Inst : IEnumerable<long>
{
public static readonly long[] Value=A212034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212034.Bytes);
public long this[int i]=>Value[i];

public static A212034Inst Instance=new A212034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212035
{
public static readonly long[] Value={ 0L,0L,34L,5395L,2083264L,208868785L,7959909333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212035Inst : IEnumerable<long>
{
public static readonly long[] Value=A212035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212035.Bytes);
public long this[int i]=>Value[i];

public static A212035Inst Instance=new A212035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212036
{
public static readonly long[] Value={ 0L,0L,3L,0L,3L,10L,0L,0L,28L,31L,0L,0L,34L,338L,78L,0L,0L,34L,1651L,2440L,166L,0L,0L,34L,3967L,39901L,11859L,313L,0L,0L,0L,5395L,373930L,480914L,43943L,540L,0L,0L,0L,5587L,2083264L,12302859L,3668669L,134273L,871L,0L,0L,0L,5587L,7013146L,208868785L,203628239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212036Inst : IEnumerable<long>
{
public static readonly long[] Value=A212036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212036.Bytes);
public long this[int i]=>Value[i];

public static A212036Inst Instance=new A212036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212037
{
public static readonly long[] Value={ 1L,6L,1L,4L,2L,2L,2L,24L,6L,2L,28L,7L,16L,47L,29L,6L,41L,16L,3L,17L,32L,10L,10L,23L,14L,15L,52L,4L,13L,20L,23L,4L,84L,26L,88L,50L,20L,35L,51L,44L,41L,87L,1L,142L,13L,188L,107L,162L,91L,96L,197L,4L,148L,71L,9L,66L,97L,41L,10L,9L,152L,234L,48L,104L,144L,40L,18L,45L,52L,204L,21L,49L,51L,9L,102L,13L,31L,108L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212037Inst : IEnumerable<long>
{
public static readonly long[] Value=A212037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212037.Bytes);
public long this[int i]=>Value[i];

public static A212037Inst Instance=new A212037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212038
{
public static readonly long[] Value={ 1L,7L,5L,2L,4L,11L,6L,1L,3L,2L,31L,2L,11L,11L,11L,6L,30L,16L,2L,36L,90L,56L,11L,52L,13L,36L,10L,62L,20L,31L,23L,28L,30L,14L,47L,22L,10L,5L,104L,39L,11L,14L,64L,184L,209L,176L,193L,162L,25L,38L,23L,5L,27L,157L,5L,17L,32L,90L,1L,199L,96L,83L,29L,82L,12L,220L,19L,40L,37L,13L,16L,120L,11L,130L,12L,77L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212038Inst : IEnumerable<long>
{
public static readonly long[] Value=A212038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212038.Bytes);
public long this[int i]=>Value[i];

public static A212038Inst Instance=new A212038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212039
{
public static readonly long[] Value={ 0L,1L,4L,19L,58L,136L,271L,484L,799L,1243L,1846L,2641L,3664L,4954L,6553L,8506L,10861L,13669L,16984L,20863L,25366L,30556L,36499L,43264L,50923L,59551L,69226L,80029L,92044L,105358L,120061L,136246L,154009L,173449L,194668L,217771L,242866L,270064L,299479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212039Inst : IEnumerable<long>
{
public static readonly long[] Value=A212039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212039.Bytes);
public long this[int i]=>Value[i];

public static A212039Inst Instance=new A212039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212040
{
public static readonly long[] Value={ 0L,1L,5L,119L,1310L,7849L,32696L,107400L,298404L,731960L,1630174L,3361016L,6505445L,11945114L,20974435L,35441099L,57919461L,91921515L,142150499L,214802485L,317921624L,461815031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212040Inst : IEnumerable<long>
{
public static readonly long[] Value=A212040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212040.Bytes);
public long this[int i]=>Value[i];

public static A212040Inst Instance=new A212040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212041
{
public static readonly long[] Value={ 0L,0L,5L,319L,14949L,253072L,2326567L,14516200L,69305994L,271885024L,917364452L,2746402607L,7459357270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212041Inst : IEnumerable<long>
{
public static readonly long[] Value=A212041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212041.Bytes);
public long this[int i]=>Value[i];

public static A212041Inst Instance=new A212041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212042
{
public static readonly long[] Value={ 0L,0L,5L,447L,94131L,5054845L,109065807L,1339229741L,11235618109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212042Inst : IEnumerable<long>
{
public static readonly long[] Value=A212042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212042.Bytes);
public long this[int i]=>Value[i];

public static A212042Inst Instance=new A212042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212043
{
public static readonly long[] Value={ 0L,0L,5L,463L,339764L,65635205L,3564578765L,89579748909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212043Inst : IEnumerable<long>
{
public static readonly long[] Value=A212043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212043.Bytes);
public long this[int i]=>Value[i];

public static A212043Inst Instance=new A212043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212044
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,0L,0L,5L,19L,0L,0L,5L,119L,58L,0L,0L,5L,319L,1310L,136L,0L,0L,5L,447L,14949L,7849L,271L,0L,0L,0L,463L,94131L,253072L,32696L,484L,0L,0L,0L,463L,339764L,5054845L,2326567L,107400L,799L,0L,0L,0L,463L,728291L,65635205L,109065807L,14516200L,298404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212044Inst : IEnumerable<long>
{
public static readonly long[] Value=A212044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212044.Bytes);
public long this[int i]=>Value[i];

public static A212044Inst Instance=new A212044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212045
{
public static readonly long[] Value={ 1L,3L,1L,7L,3L,5L,15L,7L,61L,2L,31L,15L,241L,25L,8L,21L,31L,131L,101L,137L,13L,127L,21L,12L,7L,2381L,343L,151L,255L,127L,2105L,167L,10781L,2033L,32663L,32L,511L,255L,16531L,929L,42061L,9383L,84677L,2357L,83L,1023L,511L,5231L,7387L,74189L,1771L,12419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212045Inst : IEnumerable<long>
{
public static readonly long[] Value=A212045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212045.Bytes);
public long this[int i]=>Value[i];

public static A212045Inst Instance=new A212045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212046
{
public static readonly long[] Value={ 1L,4L,1L,12L,4L,6L,32L,12L,96L,3L,80L,32L,480L,48L,15L,64L,80L,320L,240L,320L,30L,448L,64L,35L,20L,6720L,960L,420L,1024L,448L,7168L,560L,35840L,6720L,107520L,105L,2304L,1024L,64512L,3584L,161280L,35840L,322560L,8960L,315L,5120L,2304L,23040L,32256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212046Inst : IEnumerable<long>
{
public static readonly long[] Value=A212046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212046.Bytes);
public long this[int i]=>Value[i];

public static A212046Inst Instance=new A212046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212047
{
public static readonly long[] Value={ 0L,0L,1L,1L,14L,18L,31L,35L,80L,96L,125L,133L,216L,228L,269L,309L,444L,460L,543L,559L,720L,784L,853L,873L,1142L,1202L,1287L,1363L,1596L,1624L,1831L,1859L,2206L,2314L,2427L,2559L,2962L,2998L,3123L,3247L,3758L,3798L,4103L,4143L,4524L,4772L,4925L,4969L,5712L,5836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212047Inst : IEnumerable<long>
{
public static readonly long[] Value=A212047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212047.Bytes);
public long this[int i]=>Value[i];

public static A212047Inst Instance=new A212047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212048
{
public static readonly long[] Value={ 0L,0L,0L,2L,14L,18L,30L,34L,74L,104L,128L,136L,216L,228L,260L,318L,438L,454L,554L,570L,718L,812L,868L,888L,1128L,1182L,1250L,1398L,1614L,1642L,1864L,1892L,2204L,2354L,2446L,2570L,2990L,3026L,3126L,3304L,3760L,3800L,4128L,4168L,4520L,4906L,5030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212048Inst : IEnumerable<long>
{
public static readonly long[] Value=A212048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212048.Bytes);
public long this[int i]=>Value[i];

public static A212048Inst Instance=new A212048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212049
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,18L,26L,30L,38L,44L,108L,116L,144L,152L,172L,280L,314L,326L,372L,384L,564L,612L,652L,668L,752L,954L,1002L,1056L,1136L,1156L,1528L,1552L,1642L,1718L,1778L,2084L,2250L,2278L,2346L,2430L,2922L,2954L,3150L,3182L,3318L,3830L,3918L,3954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212049Inst : IEnumerable<long>
{
public static readonly long[] Value=A212049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212049.Bytes);
public long this[int i]=>Value[i];

public static A212049Inst Instance=new A212049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212050
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,20L,32L,36L,46L,54L,118L,126L,162L,170L,194L,316L,358L,370L,430L,442L,614L,666L,714L,730L,840L,1064L,1124L,1184L,1276L,1296L,1686L,1710L,1824L,1908L,1980L,2320L,2524L,2552L,2636L,2732L,3202L,3234L,3470L,3502L,3658L,4222L,4330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212050Inst : IEnumerable<long>
{
public static readonly long[] Value=A212050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212050.Bytes);
public long this[int i]=>Value[i];

public static A212050Inst Instance=new A212050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212051
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,16L,28L,32L,40L,52L,112L,120L,164L,172L,192L,280L,310L,322L,398L,410L,580L,644L,680L,696L,816L,1004L,1048L,1138L,1218L,1238L,1592L,1616L,1702L,1798L,1854L,2138L,2394L,2422L,2486L,2598L,3068L,3100L,3368L,3400L,3536L,3976L,4056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212051Inst : IEnumerable<long>
{
public static readonly long[] Value=A212051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212051.Bytes);
public long this[int i]=>Value[i];

public static A212051Inst Instance=new A212051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212052
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,18L,26L,30L,46L,52L,104L,112L,148L,156L,176L,278L,342L,354L,406L,418L,562L,602L,642L,658L,794L,988L,1040L,1090L,1190L,1210L,1526L,1550L,1726L,1794L,1858L,2152L,2368L,2396L,2468L,2548L,2980L,3012L,3212L,3244L,3408L,3890L,3982L,4018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212052Inst : IEnumerable<long>
{
public static readonly long[] Value=A212052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212052.Bytes);
public long this[int i]=>Value[i];

public static A212052Inst Instance=new A212052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212053
{
public static readonly long[] Value={ 0L,1L,13L,56L,158L,365L,725L,1312L,2198L,3477L,5245L,7624L,10742L,14725L,19725L,25920L,33470L,42557L,53397L,66176L,81150L,98525L,118533L,141456L,167606L,197189L,230509L,267920L,309726L,356205L,407805L,464744L,527494L,596389L,671789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212053Inst : IEnumerable<long>
{
public static readonly long[] Value=A212053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212053.Bytes);
public long this[int i]=>Value[i];

public static A212053Inst Instance=new A212053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212054
{
public static readonly long[] Value={ 0L,0L,3L,25L,98L,260L,571L,1089L,1898L,3084L,4755L,7017L,9994L,13836L,18691L,24705L,32066L,40964L,51579L,64145L,78850L,95956L,115723L,138385L,164170L,193436L,226467L,263521L,304930L,351076L,402195L,458777L,521082L,589532L,664547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212054Inst : IEnumerable<long>
{
public static readonly long[] Value=A212054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212054.Bytes);
public long this[int i]=>Value[i];

public static A212054Inst Instance=new A212054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212055
{
public static readonly long[] Value={ 0L,1L,15L,62L,176L,395L,775L,1382L,2296L,3595L,5407L,7822L,10968L,14995L,20063L,26286L,33896L,43043L,53951L,66798L,81832L,99251L,119375L,142382L,168592L,198251L,231711L,269190L,311088L,357675L,409367L,466422L,529296L,598267L,673855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212055Inst : IEnumerable<long>
{
public static readonly long[] Value=A212055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212055.Bytes);
public long this[int i]=>Value[i];

public static A212055Inst Instance=new A212055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212056
{
public static readonly long[] Value={ 0L,0L,1L,19L,80L,230L,521L,1019L,1800L,2966L,4593L,6819L,9768L,13566L,18353L,24339L,31640L,40478L,51025L,63523L,78168L,95230L,114881L,137459L,163184L,192374L,225265L,262251L,303568L,349606L,400633L,457099L,519280L,587654L,662481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212056Inst : IEnumerable<long>
{
public static readonly long[] Value=A212056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212056.Bytes);
public long this[int i]=>Value[i];

public static A212056Inst Instance=new A212056Inst();

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