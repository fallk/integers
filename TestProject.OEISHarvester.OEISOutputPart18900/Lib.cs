using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A071604
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,11L,12L,13L,14L,14L,15L,15L,16L,17L,17L,17L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,23L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,29L,30L,31L,31L,31L,31L,32L,32L,33L,33L,33L,33L,34L,34L,34L,35L,36L,36L,36L,36L,36L,36L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071604Inst : IEnumerable<long>
{
public static readonly long[] Value=A071604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071604.Bytes);
public long this[int i]=>Value[i];

public static A071604Inst Instance=new A071604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071427
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,3L,1L,1L,2L,2L,3L,3L,4L,4L,0L,5L,3L,3L,4L,2L,2L,1L,1L,3L,0L,2L,2L,1L,1L,4L,4L,5L,5L,2L,6L,4L,7L,5L,8L,1L,2L,2L,0L,3L,1L,1L,2L,2L,3L,3L,4L,8L,1L,5L,5L,3L,3L,10L,2L,1L,9L,3L,0L,2L,2L,5L,9L,4L,4L,8L,11L,2L,6L,4L,4L,8L,8L,6L,6L,2L,0L,3L,11L,6L,2L,2L,3L,3L,11L,5L,1L,9L,9L,7L,3L,10L,1L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071427Inst : IEnumerable<long>
{
public static readonly long[] Value=A071427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071427.Bytes);
public long this[int i]=>Value[i];

public static A071427Inst Instance=new A071427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071426
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,3L,3L,1L,1L,1L,0L,4L,3L,3L,3L,2L,2L,2L,4L,4L,0L,5L,5L,2L,2L,2L,3L,3L,0L,5L,0L,1L,1L,1L,3L,3L,3L,5L,6L,4L,4L,1L,0L,5L,5L,6L,6L,2L,7L,7L,7L,8L,0L,1L,9L,2L,7L,2L,3L,3L,3L,9L,0L,5L,4L,4L,8L,6L,6L,2L,7L,1L,1L,1L,0L,5L,5L,9L,3L,1L,8L,2L,8L,5L,0L,1L,1L,12L,2L,2L,7L,3L,3L,9L,4L,4L,0L,11L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071426Inst : IEnumerable<long>
{
public static readonly long[] Value=A071426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071426.Bytes);
public long this[int i]=>Value[i];

public static A071426Inst Instance=new A071426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071425
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,32L,43L,50L,62L,74L,86L,104L,122L,144L,167L,184L,206L,231L,259L,290L,319L,349L,384L,422L,464L,504L,552L,594L,636L,682L,733L,789L,840L,898L,957L,1021L,1084L,1150L,1214L,1285L,1359L,1429L,1506L,1587L,1676L,1763L,1852L,1942L,2030L,2124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071425Inst : IEnumerable<long>
{
public static readonly long[] Value=A071425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071425.Bytes);
public long this[int i]=>Value[i];

public static A071425Inst Instance=new A071425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071424
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,15L,20L,26L,33L,41L,50L,60L,71L,84L,98L,113L,129L,147L,166L,186L,208L,231L,255L,281L,308L,337L,367L,398L,431L,465L,501L,538L,577L,618L,660L,704L,749L,796L,844L,894L,946L,999L,1054L,1111L,1169L,1229L,1291L,1354L,1419L,1486L,1554L,1624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071424Inst : IEnumerable<long>
{
public static readonly long[] Value=A071424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071424.Bytes);
public long this[int i]=>Value[i];

public static A071424Inst Instance=new A071424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071423
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,12L,15L,18L,22L,26L,30L,34L,39L,44L,49L,55L,61L,67L,74L,81L,88L,95L,103L,111L,119L,128L,137L,146L,156L,166L,176L,186L,197L,208L,219L,231L,243L,255L,268L,281L,294L,307L,321L,335L,349L,364L,379L,394L,410L,426L,442L,458L,475L,492L,509L,527L,545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071423Inst : IEnumerable<long>
{
public static readonly long[] Value=A071423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071423.Bytes);
public long this[int i]=>Value[i];

public static A071423Inst Instance=new A071423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071422
{
public static readonly long[] Value={ 1L,4L,8L,15L,21L,24L,32L,38L,42L,51L,54L,64L,69L,75L,81L,85L,94L,106L,108L,114L,119L,128L,134L,140L,144L,150L,154L,165L,168L,177L,182L,191L,203L,212L,224L,234L,245L,251L,262L,271L,277L,292L,300L,312L,327L,336L,348L,355L,367L,379L,388L,405L,414L,417L,426L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071422Inst : IEnumerable<long>
{
public static readonly long[] Value=A071422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071422.Bytes);
public long this[int i]=>Value[i];

public static A071422Inst Instance=new A071422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071421
{
public static readonly long[] Value={ 1L,5L,14L,27L,38L,65L,90L,127L,172L,173L,214L,268L,326L,378L,477L,565L,663L,771L,898L,929L,1046L,1194L,1340L,1493L,1644L,1798L,1987L,2150L,2317L,2380L,2564L,2769L,2976L,3190L,3450L,3720L,3991L,4256L,4562L,4674L,4982L,5297L,5610L,5935L,6241L,6593L,6967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071421Inst : IEnumerable<long>
{
public static readonly long[] Value=A071421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071421.Bytes);
public long this[int i]=>Value[i];

public static A071421Inst Instance=new A071421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071420
{
public static readonly long[] Value={ 7L,8L,5L,5L,3L,4L,4L,6L,9L,7L,8L,8L,7L,8L,5L,5L,3L,4L,4L,6L,9L,7L,8L,8L,7L,8L,5L,5L,3L,4L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071420Inst : IEnumerable<long>
{
public static readonly long[] Value=A071420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071420.Bytes);
public long this[int i]=>Value[i];

public static A071420Inst Instance=new A071420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071419
{
public static readonly long[] Value={ 1L,1L,5L,4L,4L,14L,10L,26L,17L,13L,35L,23L,53L,33L,71L,43L,89L,53L,107L,63L,125L,73L,143L,83L,161L,93L,179L,103L,197L,113L,215L,123L,233L,133L,251L,143L,269L,153L,287L,163L,305L,173L,323L,183L,341L,193L,359L,203L,377L,213L,395L,223L,413L,233L,431L,243L,449L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071419Inst : IEnumerable<long>
{
public static readonly long[] Value=A071419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071419.Bytes);
public long this[int i]=>Value[i];

public static A071419Inst Instance=new A071419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071418
{
public static readonly long[] Value={ 0L,2L,2L,8L,6L,17L,35L,21L,44L,80L,45L,28L,20L,50L,32L,71L,131L,74L,46L,98L,59L,40L,31L,27L,77L,51L,116L,215L,365L,197L,341L,186L,109L,71L,158L,290L,163L,100L,69L,54L,47L,44L,43L,43L,131L,88L,67L,57L,158L,311L,542L,890L,471L,262L,158L,320L,188L,368L,213L,136L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071418Inst : IEnumerable<long>
{
public static readonly long[] Value=A071418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071418.Bytes);
public long this[int i]=>Value[i];

public static A071418Inst Instance=new A071418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071417
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,0L,6L,3L,1L,0L,9L,5L,3L,1L,0L,12L,7L,4L,3L,1L,0L,15L,9L,6L,4L,3L,1L,0L,19L,12L,8L,6L,4L,3L,1L,0L,22L,14L,10L,8L,6L,4L,3L,1L,0L,26L,17L,12L,9L,7L,5L,4L,3L,1L,0L,30L,20L,15L,11L,9L,7L,5L,4L,3L,1L,0L,34L,23L,17L,14L,11L,9L,7L,5L,4L,3L,1L,0L,38L,26L,20L,16L,13L,10L,8L,7L,5L,4L,3L,1L,0L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071417Inst : IEnumerable<long>
{
public static readonly long[] Value=A071417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071417.Bytes);
public long this[int i]=>Value[i];

public static A071417Inst Instance=new A071417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071416
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,4L,1L,2L,15L,2L,1L,6L,1L,20L,3L,2L,1L,12L,1L,2L,1L,28L,1L,2L,1L,2L,3L,2L,7L,4L,1L,2L,1L,20L,1L,42L,1L,4L,45L,2L,1L,12L,1L,2L,3L,4L,1L,6L,1L,8L,3L,2L,1L,12L,1L,2L,3L,2L,5L,66L,1L,4L,3L,10L,1L,36L,1L,2L,15L,4L,77L,6L,1L,20L,1L,2L,1L,28L,5L,2L,3L,88L,1L,10L,91L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071416Inst : IEnumerable<long>
{
public static readonly long[] Value=A071416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071416.Bytes);
public long this[int i]=>Value[i];

public static A071416Inst Instance=new A071416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071415
{
public static readonly long[] Value={ 1L,4L,7L,10L,17L,22L,32L,38L,51L,66L,75L,93L,113L,124L,147L,172L,199L,214L,244L,276L,310L,328L,365L,404L,445L,488L,511L,557L,605L,655L,707L,734L,789L,846L,905L,966L,1029L,1062L,1128L,1196L,1266L,1338L,1412L,1450L,1527L,1606L,1687L,1770L,1855L,1942L,1987L,2077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071415Inst : IEnumerable<long>
{
public static readonly long[] Value=A071415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071415.Bytes);
public long this[int i]=>Value[i];

public static A071415Inst Instance=new A071415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071414
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,4L,2L,2L,6L,2L,2L,7L,3L,4L,5L,3L,2L,6L,3L,3L,5L,4L,3L,8L,2L,5L,9L,5L,5L,6L,4L,3L,7L,5L,4L,10L,3L,5L,11L,6L,5L,9L,5L,7L,10L,5L,5L,5L,5L,6L,11L,3L,6L,15L,3L,6L,12L,4L,6L,11L,8L,4L,11L,9L,4L,10L,6L,6L,16L,6L,7L,16L,7L,8L,11L,6L,6L,15L,9L,8L,12L,8L,8L,13L,9L,5L,14L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071414Inst : IEnumerable<long>
{
public static readonly long[] Value=A071414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071414.Bytes);
public long this[int i]=>Value[i];

public static A071414Inst Instance=new A071414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071413
{
public static readonly long[] Value={ 0L,-1L,1L,-4L,5L,-4L,2L,-11L,13L,-4L,6L,-15L,14L,-11L,3L,-26L,29L,-4L,14L,-23L,26L,-15L,7L,-38L,38L,-11L,15L,-38L,31L,-26L,4L,-57L,61L,-4L,30L,-39L,50L,-23L,15L,-62L,66L,-15L,27L,-58L,51L,-38L,8L,-85L,86L,-11L,39L,-62L,67L,-38L,16L,-93L,87L,-26L,32L,-85L,64L,-57L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071413Inst : IEnumerable<long>
{
public static readonly long[] Value=A071413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071413.Bytes);
public long this[int i]=>Value[i];

public static A071413Inst Instance=new A071413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071412
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,0L,2L,0L,1L,1L,0L,2L,2L,2L,0L,1L,1L,2L,1L,1L,0L,2L,2L,1L,2L,1L,2L,2L,0L,1L,1L,2L,1L,0L,2L,0L,1L,2L,1L,1L,0L,2L,2L,1L,2L,0L,1L,0L,2L,0L,1L,0L,2L,1L,2L,2L,0L,1L,1L,2L,1L,0L,2L,0L,1L,1L,0L,2L,2L,2L,0L,1L,1L,0L,2L,0L,1L,2L,1L,1L,0L,2L,2L,1L,2L,0L,1L,0L,2L,2L,0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,1L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071412Inst : IEnumerable<long>
{
public static readonly long[] Value=A071412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071412.Bytes);
public long this[int i]=>Value[i];

public static A071412Inst Instance=new A071412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071203
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,11L,6L,4L,3L,3L,2L,2L,2L,2L,10L,10L,11L,7L,6L,5L,4L,3L,3L,3L,10L,10L,10L,11L,8L,7L,6L,5L,4L,4L,10L,10L,10L,10L,11L,9L,7L,6L,6L,5L,10L,10L,10L,10L,10L,11L,9L,8L,7L,6L,10L,10L,10L,10L,10L,10L,11L,9L,8L,7L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071203Inst : IEnumerable<long>
{
public static readonly long[] Value=A071203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071203.Bytes);
public long this[int i]=>Value[i];

public static A071203Inst Instance=new A071203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071202
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,3L,5L,5L,3L,1L,1L,3L,7L,5L,7L,3L,1L,1L,4L,7L,14L,14L,7L,4L,1L,1L,4L,12L,19L,14L,19L,12L,4L,1L,1L,5L,15L,30L,42L,42L,30L,15L,5L,1L,1L,5L,15L,30L,66L,42L,66L,30L,15L,5L,1L,1L,6L,22L,55L,99L,132L,132L,99L,55L,22L,6L,1L,1L,6L,26L,67L,143L,202L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071202Inst : IEnumerable<long>
{
public static readonly long[] Value=A071202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071202.Bytes);
public long this[int i]=>Value[i];

public static A071202Inst Instance=new A071202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071201
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,4L,7L,14L,7L,4L,1L,1L,4L,12L,14L,14L,12L,4L,1L,1L,5L,12L,23L,42L,23L,12L,5L,1L,1L,5L,15L,30L,42L,42L,30L,15L,5L,1L,1L,6L,22L,55L,66L,132L,66L,55L,22L,6L,1L,1L,6L,22L,55L,99L,132L,132L,99L,55L,22L,6L,1L,1L,7L,26L,76L,143L,227L,429L,227L,143L,76L,26L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071201Inst : IEnumerable<long>
{
public static readonly long[] Value=A071201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071201.Bytes);
public long this[int i]=>Value[i];

public static A071201Inst Instance=new A071201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071200
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,19L,29L,37L,43L,47L,53L,61L,67L,73L,79L,89L,103L,107L,113L,137L,139L,149L,151L,157L,163L,167L,179L,181L,191L,193L,197L,227L,229L,233L,239L,241L,257L,271L,277L,281L,283L,293L,307L,313L,317L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071200Inst : IEnumerable<long>
{
public static readonly long[] Value=A071200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071200.Bytes);
public long this[int i]=>Value[i];

public static A071200Inst Instance=new A071200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071199
{
public static readonly long[] Value={ 5L,23L,31L,41L,59L,71L,83L,97L,101L,109L,127L,131L,173L,199L,211L,223L,251L,263L,269L,311L,331L,349L,421L,431L,439L,457L,479L,487L,503L,587L,607L,647L,661L,683L,701L,719L,733L,757L,811L,827L,829L,857L,883L,911L,941L,991L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071199Inst : IEnumerable<long>
{
public static readonly long[] Value=A071199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071199.Bytes);
public long this[int i]=>Value[i];

public static A071199Inst Instance=new A071199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071198
{
public static readonly long[] Value={ 2L,5L,7L,19L,43L,53L,59L,67L,83L,101L,103L,109L,163L,179L,181L,191L,193L,199L,229L,233L,241L,257L,263L,271L,277L,313L,337L,347L,367L,373L,431L,433L,449L,467L,491L,499L,521L,541L,547L,571L,587L,607L,613L,619L,643L,659L,683L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071198Inst : IEnumerable<long>
{
public static readonly long[] Value=A071198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071198.Bytes);
public long this[int i]=>Value[i];

public static A071198Inst Instance=new A071198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071197
{
public static readonly long[] Value={ 3L,11L,13L,17L,23L,29L,31L,37L,41L,47L,61L,71L,73L,79L,89L,97L,107L,113L,127L,131L,137L,139L,149L,151L,157L,167L,173L,197L,211L,223L,227L,239L,251L,269L,281L,283L,293L,307L,311L,317L,331L,349L,353L,359L,379L,383L,389L,397L,401L,409L,419L,421L,439L,443L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071197Inst : IEnumerable<long>
{
public static readonly long[] Value=A071197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071197.Bytes);
public long this[int i]=>Value[i];

public static A071197Inst Instance=new A071197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071196
{
public static readonly long[] Value={ 5L,127L,23L,31L,41L,101L,59L,71L,83L,97L,109L,479L,131L,263L,431L,173L,331L,199L,211L,223L,421L,251L,269L,719L,757L,311L,827L,587L,349L,647L,683L,1367L,733L,439L,457L,811L,487L,503L,2141L,1747L,941L,5009L,991L,1951L,607L,2053L,661L,1151L,21139L,701L,1753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071196Inst : IEnumerable<long>
{
public static readonly long[] Value=A071196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071196.Bytes);
public long this[int i]=>Value[i];

public static A071196Inst Instance=new A071196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071195
{
public static readonly long[] Value={ 3L,29L,11L,13L,17L,29L,23L,29L,31L,37L,41L,71L,47L,61L,73L,61L,73L,71L,73L,79L,97L,89L,97L,113L,127L,107L,137L,131L,127L,139L,149L,173L,157L,151L,157L,173L,167L,173L,227L,223L,197L,293L,211L,239L,211L,251L,227L,239L,563L,239L,269L,397L,283L,409L,283L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071195Inst : IEnumerable<long>
{
public static readonly long[] Value=A071195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071195.Bytes);
public long this[int i]=>Value[i];

public static A071195Inst Instance=new A071195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071194
{
public static readonly long[] Value={ 2L,9L,3L,3L,3L,5L,3L,3L,3L,3L,3L,9L,3L,5L,7L,3L,5L,3L,3L,3L,5L,3L,3L,7L,7L,3L,7L,5L,3L,5L,5L,9L,5L,3L,3L,5L,3L,3L,11L,9L,5L,21L,5L,9L,3L,9L,3L,5L,55L,3L,7L,27L,9L,27L,7L,5L,5L,3L,9L,3L,3L,3L,5L,3L,7L,7L,11L,3L,3L,3L,5L,5L,7L,7L,3L,5L,3L,9L,3L,3L,5L,11L,3L,5L,47L,5L,3L,3L,5L,3L,3L,5L,7L,3L,3L,7L,3L,5L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071194Inst : IEnumerable<long>
{
public static readonly long[] Value=A071194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071194.Bytes);
public long this[int i]=>Value[i];

public static A071194Inst Instance=new A071194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071193
{
public static readonly long[] Value={ 2L,4L,4L,5L,6L,7L,8L,9L,11L,11L,12L,13L,14L,16L,16L,17L,18L,19L,20L,21L,23L,23L,24L,25L,27L,27L,29L,29L,30L,31L,32L,33L,36L,36L,36L,37L,38L,40L,40L,41L,42L,43L,44L,46L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,59L,60L,61L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071193Inst : IEnumerable<long>
{
public static readonly long[] Value=A071193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071193.Bytes);
public long this[int i]=>Value[i];

public static A071193Inst Instance=new A071193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071192
{
public static readonly long[] Value={ 2L,4L,4L,5L,6L,7L,9L,9L,11L,11L,14L,14L,14L,17L,17L,18L,21L,21L,21L,21L,23L,23L,25L,27L,27L,27L,33L,33L,33L,33L,33L,36L,37L,37L,37L,42L,38L,41L,41L,42L,46L,46L,46L,46L,46L,47L,49L,54L,50L,51L,52L,54L,55L,63L,59L,63L,59L,59L,62L,63L,62L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071192Inst : IEnumerable<long>
{
public static readonly long[] Value=A071192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071192.Bytes);
public long this[int i]=>Value[i];

public static A071192Inst Instance=new A071192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071191
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,9L,10L,11L,13L,14L,14L,15L,17L,18L,19L,20L,21L,21L,22L,23L,25L,27L,26L,27L,28L,30L,31L,33L,33L,36L,34L,35L,37L,40L,38L,39L,41L,42L,43L,44L,46L,45L,46L,47L,49L,54L,50L,51L,52L,54L,55L,56L,57L,60L,58L,59L,61L,63L,62L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071191Inst : IEnumerable<long>
{
public static readonly long[] Value=A071191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071191.Bytes);
public long this[int i]=>Value[i];

public static A071191Inst Instance=new A071191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071190
{
public static readonly long[] Value={ 1L,3L,2L,7L,3L,3L,2L,5L,13L,3L,3L,7L,7L,3L,3L,31L,3L,13L,5L,7L,2L,3L,3L,5L,31L,7L,5L,7L,5L,3L,2L,7L,3L,3L,3L,13L,19L,5L,7L,5L,7L,3L,11L,7L,13L,3L,3L,31L,19L,31L,3L,7L,3L,5L,3L,5L,5L,5L,5L,7L,31L,3L,13L,127L,7L,3L,17L,7L,3L,3L,3L,13L,37L,19L,31L,7L,3L,7L,5L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071190Inst : IEnumerable<long>
{
public static readonly long[] Value=A071190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071190.Bytes);
public long this[int i]=>Value[i];

public static A071190Inst Instance=new A071190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071189
{
public static readonly long[] Value={ 1L,3L,2L,7L,2L,2L,2L,3L,13L,2L,2L,2L,2L,2L,2L,31L,2L,3L,2L,2L,2L,2L,2L,2L,31L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,7L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,127L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,11L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071189Inst : IEnumerable<long>
{
public static readonly long[] Value=A071189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071189.Bytes);
public long this[int i]=>Value[i];

public static A071189Inst Instance=new A071189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071188
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,5L,2L,3L,2L,3L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,5L,3L,3L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,7L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,5L,5L,2L,2L,3L,2L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071188Inst : IEnumerable<long>
{
public static readonly long[] Value=A071188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071188.Bytes);
public long this[int i]=>Value[i];

public static A071188Inst Instance=new A071188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071123
{
public static readonly long[] Value={ 1L,3L,9L,15L,18L,27L,36L,45L,72L,99L,135L,162L,189L,234L,279L,342L,405L,459L,504L,558L,621L,693L,792L,873L,945L,1026L,1134L,1224L,1350L,1467L,1602L,1710L,1854L,1998L,2142L,2313L,2466L,2574L,2763L,2952L,3096L,3285L,3465L,3681L,3888L,4104L,4329L,4563L,4788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071123Inst : IEnumerable<long>
{
public static readonly long[] Value=A071123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071123.Bytes);
public long this[int i]=>Value[i];

public static A071123Inst Instance=new A071123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071122
{
public static readonly long[] Value={ 2L,6L,14L,21L,26L,36L,47L,60L,68L,75L,89L,108L,128L,150L,176L,201L,215L,234L,263L,294L,320L,345L,386L,423L,452L,492L,527L,570L,611L,648L,695L,753L,815L,876L,935L,999L,1055L,1122L,1193L,1254L,1304L,1350L,1406L,1464L,1526L,1596L,1664L,1737L,1802L,1878L,1958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071122Inst : IEnumerable<long>
{
public static readonly long[] Value=A071122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071122.Bytes);
public long this[int i]=>Value[i];

public static A071122Inst Instance=new A071122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071121
{
public static readonly long[] Value={ 1L,9L,18L,28L,36L,45L,55L,63L,81L,82L,90L,108L,127L,144L,162L,181L,198L,216L,244L,252L,270L,289L,306L,324L,343L,369L,396L,415L,441L,450L,478L,504L,531L,550L,576L,603L,622L,648L,675L,685L,711L,738L,766L,792L,810L,838L,855L,873L,901L,909L,927L,946L,981L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071121Inst : IEnumerable<long>
{
public static readonly long[] Value=A071121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071121.Bytes);
public long this[int i]=>Value[i];

public static A071121Inst Instance=new A071121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071120
{
public static readonly long[] Value={ 2L,0L,9L,3L,1L,7L,0L,4L,5L,9L,1L,9L,5L,4L,9L,0L,8L,9L,3L,9L,6L,8L,2L,0L,1L,3L,7L,0L,1L,4L,5L,2L,0L,8L,3L,2L,5L,6L,8L,9L,5L,9L,2L,1L,6L,7L,8L,9L,1L,1L,5L,4L,5L,1L,9L,0L,6L,9L,1L,9L,6L,7L,2L,1L,5L,1L,8L,1L,8L,7L,0L,3L,3L,4L,9L,9L,8L,3L,3L,5L,9L,6L,0L,4L,7L,6L,7L,5L,2L,0L,9L,4L,4L,4L,5L,2L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071120Inst : IEnumerable<long>
{
public static readonly long[] Value=A071120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071120.Bytes);
public long this[int i]=>Value[i];

public static A071120Inst Instance=new A071120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071119
{
public static readonly long[] Value={ 2L,3L,5L,7L,131L,151L,353L,373L,727L,757L,929L,11311L,31513L,33533L,37273L,37573L,39293L,71317L,93739L,97579L,1335331L,3315133L,3392933L,7392937L,9375739L,373929373L,733929337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071119Inst : IEnumerable<long>
{
public static readonly long[] Value=A071119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071119.Bytes);
public long this[int i]=>Value[i];

public static A071119Inst Instance=new A071119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071118
{
public static readonly long[] Value={ 2L,4L,12L,16L,40L,24L,84L,64L,108L,80L,220L,96L,312L,168L,240L,256L,544L,216L,684L,320L,504L,440L,1012L,384L,1000L,624L,972L,672L,1624L,480L,1860L,1024L,1320L,1088L,1680L,864L,2664L,1368L,1872L,1280L,3280L,1008L,3612L,1760L,2160L,2024L,4324L,1536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071118Inst : IEnumerable<long>
{
public static readonly long[] Value=A071118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071118.Bytes);
public long this[int i]=>Value[i];

public static A071118Inst Instance=new A071118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071117
{
public static readonly long[] Value={ 1L,7L,8L,10L,18L,24L,38L,42L,52L,54L,64L,100L,107L,112L,113L,114L,135L,144L,145L,150L,151L,159L,162L,172L,177L,184L,189L,196L,197L,202L,213L,214L,223L,228L,230L,232L,238L,239L,240L,252L,255L,264L,267L,272L,278L,283L,302L,314L,315L,316L,332L,338L,366L,367L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071117Inst : IEnumerable<long>
{
public static readonly long[] Value=A071117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071117.Bytes);
public long this[int i]=>Value[i];

public static A071117Inst Instance=new A071117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071116
{
public static readonly long[] Value={ 2049L,81L,383L,67L,7L,25L,11L,103L,17L,271L,29L,159L,1416741L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071116Inst : IEnumerable<long>
{
public static readonly long[] Value=A071116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071116.Bytes);
public long this[int i]=>Value[i];

public static A071116Inst Instance=new A071116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071115
{
public static readonly long[] Value={ 1L,2L,4L,11L,34L,152L,1007L,7335L,85761L,812767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071115Inst : IEnumerable<long>
{
public static readonly long[] Value=A071115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071115.Bytes);
public long this[int i]=>Value[i];

public static A071115Inst Instance=new A071115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071114
{
public static readonly long[] Value={ 2L,3L,4L,7L,9L,16L,25L,31L,64L,81L,127L,289L,729L,1681L,2401L,3481L,4096L,5041L,7921L,8191L,10201L,15625L,17161L,27889L,28561L,29929L,65536L,83521L,85849L,131071L,146689L,262144L,279841L,458329L,491401L,524287L,531441L,552049L,579121L,597529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071114Inst : IEnumerable<long>
{
public static readonly long[] Value=A071114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071114.Bytes);
public long this[int i]=>Value[i];

public static A071114Inst Instance=new A071114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071113
{
public static readonly long[] Value={ 1L,2L,5L,7L,10L,14L,16L,20L,24L,29L,39L,40L,42L,44L,46L,55L,57L,59L,66L,68L,70L,81L,86L,91L,106L,108L,109L,117L,118L,119L,120L,123L,124L,133L,142L,147L,155L,159L,163L,164L,167L,168L,171L,176L,177L,198L,201L,205L,206L,213L,217L,226L,227L,228L,229L,233L,238L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071113Inst : IEnumerable<long>
{
public static readonly long[] Value=A071113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071113.Bytes);
public long this[int i]=>Value[i];

public static A071113Inst Instance=new A071113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071112
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,4L,6L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,15L,15L,17L,17L,17L,17L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L,21L,23L,23L,23L,23L,23L,23L,23L,26L,26L,26L,26L,28L,28L,28L,28L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071112Inst : IEnumerable<long>
{
public static readonly long[] Value=A071112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071112.Bytes);
public long this[int i]=>Value[i];

public static A071112Inst Instance=new A071112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071111
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,26L,31L,43L,57L,65L,82L,101L,111L,133L,157L,183L,197L,226L,257L,290L,307L,343L,381L,421L,463L,485L,530L,577L,626L,677L,703L,757L,813L,871L,931L,993L,1025L,1090L,1157L,1226L,1297L,1370L,1407L,1483L,1561L,1641L,1723L,1807L,1893L,1937L,2026L,2117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071111Inst : IEnumerable<long>
{
public static readonly long[] Value=A071111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071111.Bytes);
public long this[int i]=>Value[i];

public static A071111Inst Instance=new A071111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071110
{
public static readonly long[] Value={ 29L,76L,141L,172L,193L,197L,205L,211L,245L,181L,162L,85L,86L,69L,71L,61L,62L,67L,52L,53L,58L,58L,58L,59L,62L,45L,46L,49L,20L,51L,7L,22L,7L,7L,10L,7L,7L,7L,7L,15L,7L,13L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,10L,7L,7L,7L,7L,7L,7L,10L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071110Inst : IEnumerable<long>
{
public static readonly long[] Value=A071110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071110.Bytes);
public long this[int i]=>Value[i];

public static A071110Inst Instance=new A071110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071109
{
public static readonly long[] Value={ 1L,-2L,2L,-6L,14L,-26L,50L,-102L,214L,-426L,834L,-1678L,3398L,-6778L,13482L,-27022L,54198L,-108306L,216346L,-432878L,866334L,-1732386L,3463626L,-6927926L,13858350L,-27715378L,55426002L,-110855030L,221719582L,-443433610L,886848930L,-1773709078L,3547455846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071109Inst : IEnumerable<long>
{
public static readonly long[] Value=A071109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071109.Bytes);
public long this[int i]=>Value[i];

public static A071109Inst Instance=new A071109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071108
{
public static readonly long[] Value={ 1L,3L,7L,24L,55L,244L,543L,2416L,7791L,33580L,74951L,483286L,1041523L,4649378L,19639035L,102844553L,225328141L,1454813399L,3134954939L,20264543033L,84193127071L,357037051317L,798267229705L,6743174888957L,21027791896576L,90854342475261L,384445161797620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071108Inst : IEnumerable<long>
{
public static readonly long[] Value=A071108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071108.Bytes);
public long this[int i]=>Value[i];

public static A071108Inst Instance=new A071108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071027
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071027Inst : IEnumerable<long>
{
public static readonly long[] Value=A071027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071027.Bytes);
public long this[int i]=>Value[i];

public static A071027Inst Instance=new A071027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071026
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071026Inst : IEnumerable<long>
{
public static readonly long[] Value=A071026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071026.Bytes);
public long this[int i]=>Value[i];

public static A071026Inst Instance=new A071026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071025
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071025Inst : IEnumerable<long>
{
public static readonly long[] Value=A071025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071025.Bytes);
public long this[int i]=>Value[i];

public static A071025Inst Instance=new A071025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071024
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071024Inst : IEnumerable<long>
{
public static readonly long[] Value=A071024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071024.Bytes);
public long this[int i]=>Value[i];

public static A071024Inst Instance=new A071024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071023
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071023Inst : IEnumerable<long>
{
public static readonly long[] Value=A071023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071023.Bytes);
public long this[int i]=>Value[i];

public static A071023Inst Instance=new A071023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071022
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071022Inst : IEnumerable<long>
{
public static readonly long[] Value=A071022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071022.Bytes);
public long this[int i]=>Value[i];

public static A071022Inst Instance=new A071022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071021
{
public static readonly long[] Value={ 1L,6L,6L,30L,36L,30L,42L,180L,180L,42L,30L,252L,900L,252L,30L,66L,180L,1260L,1260L,180L,66L,2730L,396L,900L,1764L,900L,396L,2730L,6L,16380L,396L,1260L,1260L,396L,16380L,6L,510L,36L,81900L,2772L,900L,2772L,81900L,36L,510L,798L,3060L,180L,114660L,396L,396L,114660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071021Inst : IEnumerable<long>
{
public static readonly long[] Value=A071021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071021.Bytes);
public long this[int i]=>Value[i];

public static A071021Inst Instance=new A071021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071020
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,5L,-1L,-1L,-1L,-1L,5L,-691L,5L,1L,1L,1L,5L,-691L,7L,-691L,-1L,-1L,-1L,-1L,-691L,7L,-3617L,7L,691L,5L,1L,5L,691L,7L,-3617L,43867L,-3617L,-7L,-691L,-1L,-1L,-691L,-7L,-3617L,43867L,-174611L,43867L,3617L,1L,691L,25L,691L,1L,3617L,43867L,-174611L,854513L,-174611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071020Inst : IEnumerable<long>
{
public static readonly long[] Value=A071020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071020.Bytes);
public long this[int i]=>Value[i];

public static A071020Inst Instance=new A071020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071019
{
public static readonly long[] Value={ 1L,3L,4L,10L,14L,28L,39L,73L,104L,179L,253L,417L,590L,931L,1309L,2007L,2810L,4202L,5841L,8563L,11839L,17057L,23426L,33269L,45428L,63703L,86460L,119913L,161850L,222292L,298375L,406235L,542475L,732796L,973648L,1305896L,1726913L,2301197L,3029245L,4012556L,5259227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071019Inst : IEnumerable<long>
{
public static readonly long[] Value=A071019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071019.Bytes);
public long this[int i]=>Value[i];

public static A071019Inst Instance=new A071019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071018
{
public static readonly long[] Value={ 1L,3L,2L,6L,3L,7L,2L,10L,5L,10L,3L,15L,4L,8L,5L,15L,5L,17L,4L,21L,8L,12L,3L,26L,8L,14L,8L,18L,5L,20L,2L,21L,9L,16L,8L,36L,8L,16L,8L,36L,9L,30L,6L,27L,15L,14L,3L,40L,9L,27L,11L,30L,9L,31L,8L,32L,12L,18L,5L,45L,6L,10L,12L,28L,12L,32L,6L,33L,13L,32L,5L,62L,12L,28L,17L,36L,14L,34L,4L,55L,19L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071018Inst : IEnumerable<long>
{
public static readonly long[] Value=A071018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071018.Bytes);
public long this[int i]=>Value[i];

public static A071018Inst Instance=new A071018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071017
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,2L,2L,1L,1L,2L,2L,-1L,1L,3L,2L,2L,2L,4L,4L,1L,1L,3L,4L,0L,2L,3L,0L,0L,1L,3L,4L,2L,2L,6L,6L,0L,2L,7L,4L,4L,4L,4L,6L,1L,1L,6L,4L,1L,4L,7L,4L,0L,2L,4L,6L,3L,0L,4L,4L,-6L,1L,2L,0L,4L,4L,7L,4L,3L,2L,10L,10L,3L,6L,8L,4L,2L,2L,8L,10L,7L,4L,8L,12L,1L,4L,11L,6L,4L,6L,8L,8L,-2L,1L,8L,6L,0L,4L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071017Inst : IEnumerable<long>
{
public static readonly long[] Value=A071017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071017.Bytes);
public long this[int i]=>Value[i];

public static A071017Inst Instance=new A071017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071016
{
public static readonly long[] Value={ 1L,3L,8L,24L,88L,381L,1822L,9254L,49295L,275219L,1614968L,9993871L,65442602L,454736731L,3356546167L,26272011685L,217027548533L,1879608087006L,16946483469822L,158067735588494L,1518042086052977L,14962182709519890L,151056371629601794L,1560637060858070869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071016Inst : IEnumerable<long>
{
public static readonly long[] Value=A071016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071016.Bytes);
public long this[int i]=>Value[i];

public static A071016Inst Instance=new A071016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071015
{
public static readonly long[] Value={ 1L,1L,-2L,5L,-11L,22L,-43L,87L,-184L,397L,-853L,1808L,-3787L,7881L,-16358L,33887L,-69957L,143656L,-293187L,595011L,-1202704L,2426383L,-4895975L,9898470L,-20077347L,40886877L,-83618266L,171689061L,-353678491L,730241058L,-1509434519L,3119966113L,-6442035602L,13276145691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071015Inst : IEnumerable<long>
{
public static readonly long[] Value=A071015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071015.Bytes);
public long this[int i]=>Value[i];

public static A071015Inst Instance=new A071015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071014
{
public static readonly long[] Value={ 1L,3L,6L,13L,29L,64L,137L,285L,584L,1197L,2479L,5198L,10989L,23275L,49122L,102951L,213915L,440478L,899177L,1821577L,3668080L,7358199L,14742653L,29582240L,59593613L,120742119L,246254254L,505494077L,1043327165L,2161750892L,4488143133L,9319949375L,19326922734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071014Inst : IEnumerable<long>
{
public static readonly long[] Value=A071014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071014.Bytes);
public long this[int i]=>Value[i];

public static A071014Inst Instance=new A071014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071013
{
public static readonly long[] Value={ 1L,2L,5L,7L,12L,25L,119L,152L,154L,163L,164L,178L,179L,183L,190L,192L,245L,267L,279L,290L,306L,313L,359L,420L,454L,496L,528L,576L,592L,615L,649L,661L,674L,702L,760L,830L,868L,945L,967L,978L,1000L,1167L,1190L,1194L,1209L,1288L,1289L,1325L,1452L,1892L,2084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071013Inst : IEnumerable<long>
{
public static readonly long[] Value=A071013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071013.Bytes);
public long this[int i]=>Value[i];

public static A071013Inst Instance=new A071013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071012
{
public static readonly long[] Value={ 1L,2L,3L,11L,16L,21L,27L,35L,42L,51L,55L,63L,75L,89L,350L,364L,385L,385L,416L,450L,453L,468L,476L,483L,526L,604L,617L,780L,1125L,1157L,1263L,1935L,7000L,7028L,7774L,8928L,9378L,62628L,865117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071012Inst : IEnumerable<long>
{
public static readonly long[] Value=A071012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071012.Bytes);
public long this[int i]=>Value[i];

public static A071012Inst Instance=new A071012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070979
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,6L,3L,2L,1L,10L,5L,3L,2L,1L,18L,8L,4L,3L,2L,1L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070979Inst : IEnumerable<long>
{
public static readonly long[] Value=A070979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070979.Bytes);
public long this[int i]=>Value[i];

public static A070979Inst Instance=new A070979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070978
{
public static readonly long[] Value={ 2L,4L,6L,8L,11L,13L,16L,19L,22L,25L,29L,32L,35L,39L,43L,46L,50L,54L,58L,62L,66L,70L,74L,78L,83L,87L,91L,96L,100L,105L,110L,114L,119L,124L,128L,133L,138L,143L,148L,153L,158L,163L,168L,174L,179L,184L,189L,195L,200L,205L,211L,216L,222L,227L,233L,239L,244L,250L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070978Inst : IEnumerable<long>
{
public static readonly long[] Value=A070978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070978.Bytes);
public long this[int i]=>Value[i];

public static A070978Inst Instance=new A070978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070977
{
public static readonly long[] Value={ 2L,5L,8L,12L,16L,20L,25L,30L,36L,42L,48L,54L,61L,68L,75L,82L,90L,98L,106L,114L,122L,131L,140L,149L,158L,167L,177L,186L,196L,206L,217L,227L,238L,248L,259L,270L,281L,293L,304L,316L,327L,339L,351L,364L,376L,388L,401L,414L,427L,440L,453L,466L,479L,493L,506L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070977Inst : IEnumerable<long>
{
public static readonly long[] Value=A070977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070977.Bytes);
public long this[int i]=>Value[i];

public static A070977Inst Instance=new A070977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070976
{
public static readonly long[] Value={ 0L,7L,19L,111L,22L,96L,33L,76L,75L,43L,135L,134L,133L,132L,144L,205L,129L,190L,140L,95L,94L,261L,428L,91L,258L,394L,331L,255L,254L,390L,389L,388L,462L,461L,460L,459L,458L,457L,456L,455L,454L,453L,501L,500L,450L,498L,497L,752L,495L,494L,493L,748L,491L,746L,489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070976Inst : IEnumerable<long>
{
public static readonly long[] Value=A070976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070976.Bytes);
public long this[int i]=>Value[i];

public static A070976Inst Instance=new A070976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070975
{
public static readonly long[] Value={ 1L,7L,5L,16L,14L,9L,12L,20L,15L,18L,106L,21L,109L,29L,104L,11L,32L,19L,27L,102L,115L,35L,110L,30L,118L,25L,87L,100L,113L,12L,46L,28L,90L,41L,23L,15L,36L,23L,67L,31L,31L,18L,44L,119L,26L,119L,39L,70L,13L,34L,83L,52L,21L,65L,122L,78L,29L,42L,16L,42L,60L,117L,37L,86L,130L,37L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070975Inst : IEnumerable<long>
{
public static readonly long[] Value=A070975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070975.Bytes);
public long this[int i]=>Value[i];

public static A070975Inst Instance=new A070975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070974
{
public static readonly long[] Value={ 0L,1L,8L,10L,20L,20L,41L,44L,86L,66L,147L,210L,175L,264L,255L,259L,426L,425L,362L,387L,500L,489L,447L,449L,389L,559L,419L,517L,633L,444L,529L,534L,795L,950L,826L,813L,1069L,689L,728L,785L,909L,819L,1013L,1171L,1218L,996L,1327L,1330L,891L,1295L,1342L,1402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070974Inst : IEnumerable<long>
{
public static readonly long[] Value=A070974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070974.Bytes);
public long this[int i]=>Value[i];

public static A070974Inst Instance=new A070974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070973
{
public static readonly long[] Value={ 1L,2L,3L,16L,4L,37L,5L,16L,38L,49L,6L,44L,40L,29L,50L,16L,7L,51L,9L,49L,30L,40L,15L,44L,8L,40L,52L,56L,36L,50L,23L,43L,41L,26L,20L,81L,43L,9L,41L,49L,16L,73L,11L,40L,51L,29L,63L,44L,34L,49L,225L,40L,224L,196L,27L,56L,10L,36L,45L,50L,126L,23L,74L,193L,279L,41L,76L,26L,30L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070973Inst : IEnumerable<long>
{
public static readonly long[] Value=A070973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070973.Bytes);
public long this[int i]=>Value[i];

public static A070973Inst Instance=new A070973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070972
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,2L,2L,2L,3L,3L,7L,6L,4L,5L,4L,3L,4L,4L,4L,6L,5L,5L,4L,3L,2L,10L,8L,7L,5L,4L,5L,7L,9L,8L,6L,5L,7L,11L,10L,8L,6L,6L,4L,9L,7L,6L,4L,9L,8L,6L,9L,8L,6L,5L,5L,3L,4L,7L,5L,10L,8L,7L,6L,6L,6L,6L,4L,4L,7L,7L,5L,5L,5L,5L,5L,5L,9L,8L,6L,5L,6L,5L,6L,5L,5L,4L,6L,5L,10L,8L,7L,5L,6L,6L,6L,7L,7L,6L,7L,5L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070972Inst : IEnumerable<long>
{
public static readonly long[] Value=A070972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070972.Bytes);
public long this[int i]=>Value[i];

public static A070972Inst Instance=new A070972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070971
{
public static readonly long[] Value={ 3L,4L,15L,6L,105L,30L,1155L,770L,36465L,210L,15015L,6006L,255255L,2310L,8580495L,102102L,4849845L,72930L,20056049013L,74364290L,5898837945L,30030L,3234846615L,881790L,195282582495L,510510L,218257003965L,20281170L,100280245065L,17160990L,934482952262145L,6614136163635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070971Inst : IEnumerable<long>
{
public static readonly long[] Value=A070971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070971.Bytes);
public long this[int i]=>Value[i];

public static A070971Inst Instance=new A070971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070970
{
public static readonly long[] Value={ 6L,12L,63L,260L,5307L,1638L,33306L,135622L,7119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070970Inst : IEnumerable<long>
{
public static readonly long[] Value=A070970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070970.Bytes);
public long this[int i]=>Value[i];

public static A070970Inst Instance=new A070970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070969
{
public static readonly BigInteger[] Value={ 5L,9L,33L,513L,131073L,8589934593L,BigInteger.Parse("36893488147419103233"),BigInteger.Parse("680564733841876926926749214863536422913"),BigInteger.Parse("231584178474632390847141970017375815706539969331281128078915168015826259279873") };
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
public class A070969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070969Inst Instance=new A070969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070968
{
public static readonly BigInteger[] Value={ 0L,1L,15L,204L,3940L,113865L,4662231L,256485040L,18226108944L,1623855701385L,177195820499335L,23237493232953516L,3605437233380095620L,BigInteger.Parse("653193551573628900289"),BigInteger.Parse("136634950180317224866335") };
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
public class A070968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070968Inst Instance=new A070968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070967
{
public static readonly BigInteger[] Value={ 1L,2L,926L,37130L,2973350L,174174002L,11582386286L,729520967450L,47006639297270L,2999857885752002L,192222214478506046L,12295976362284182570UL,BigInteger.Parse("787111112023373201990"),BigInteger.Parse("50370558298891875954002") };
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
public class A070967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070967Inst Instance=new A070967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070966
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,4L,1L,2L,3L,4L,1L,4L,1L,4L,3L,2L,1L,6L,5L,2L,3L,4L,1L,8L,1L,4L,3L,2L,5L,8L,1L,2L,3L,8L,1L,6L,1L,4L,7L,2L,1L,8L,7L,6L,3L,4L,1L,6L,5L,10L,3L,2L,1L,12L,1L,2L,9L,8L,5L,6L,1L,4L,3L,12L,1L,12L,1L,2L,7L,4L,7L,6L,1L,12L,9L,2L,1L,14L,5L,2L,3L,8L,1L,16L,7L,4L,3L,2L,5L,12L,1L,8L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070966Inst : IEnumerable<long>
{
public static readonly long[] Value=A070966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070966.Bytes);
public long this[int i]=>Value[i];

public static A070966Inst Instance=new A070966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070965
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,-1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,-1L,2L,-1L,2L,0L,0L,0L,0L,1L,0L,-1L,-1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,2L,0L,1L,1L,1L,-1L,-1L,0L,1L,-1L,2L,3L,1L,0L,0L,1L,0L,0L,1L,-1L,2L,1L,0L,-1L,0L,-1L,-2L,2L,-1L,1L,1L,0L,1L,1L,2L,1L,3L,0L,1L,-1L,-2L,0L,2L,2L,2L,1L,0L,-1L,0L,1L,0L,2L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070965Inst : IEnumerable<long>
{
public static readonly long[] Value=A070965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070965.Bytes);
public long this[int i]=>Value[i];

public static A070965Inst Instance=new A070965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070964
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,6L,20L,21L,44L,50L,143L,108L,376L,364L,738L,987L,2583L,1938L,6764L,6150L,13938L,17622L,46367L,34776L,113957L,121160L,257114L,306852L,832039L,549000L,2178308L,2178309L,4595932L,5701290L,13686704L,11197764L,39088168L,39083988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070964Inst : IEnumerable<long>
{
public static readonly long[] Value=A070964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070964.Bytes);
public long this[int i]=>Value[i];

public static A070964Inst Instance=new A070964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070963
{
public static readonly long[] Value={ 2L,1L,2L,0L,4L,-2L,0L,2L,6L,-4L,6L,-4L,-6L,10L,2L,-2L,12L,-10L,-2L,8L,2L,-4L,8L,4L,-16L,8L,10L,-8L,10L,-8L,-8L,14L,14L,-26L,26L,-14L,-36L,42L,20L,-22L,68L,-66L,-60L,14L,-10L,60L,40L,-74L,-38L,-66L,10L,134L,44L,-98L,-64L,-54L,22L,156L,20L,-18L,-34L,-240L,10L,256L,32L,-18L,-6L,-144L,-72L,226L,70L,-68L,-50L,-184L,58L,236L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070963Inst : IEnumerable<long>
{
public static readonly long[] Value=A070963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070963.Bytes);
public long this[int i]=>Value[i];

public static A070963Inst Instance=new A070963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070962
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,5L,2L,2L,2L,8L,3L,9L,4L,10L,10L,6L,6L,12L,7L,13L,13L,13L,10L,14L,11L,15L,12L,16L,13L,29L,14L,14L,20L,20L,20L,20L,18L,21L,21L,21L,21L,40L,22L,24L,24L,24L,25L,25L,26L,26L,26L,26L,29L,27L,27L,27L,27L,27L,34L,57L,35L,30L,30L,37L,31L,62L,39L,33L,33L,65L,42L,35L,43L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070962Inst : IEnumerable<long>
{
public static readonly long[] Value=A070962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070962.Bytes);
public long this[int i]=>Value[i];

public static A070962Inst Instance=new A070962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070961
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,3L,7L,6L,6L,6L,10L,7L,9L,9L,15L,10L,15L,11L,16L,14L,14L,14L,22L,16L,16L,22L,22L,19L,23L,20L,31L,22L,22L,22L,33L,25L,24L,24L,36L,28L,34L,29L,35L,35L,30L,32L,46L,32L,39L,33L,40L,37L,49L,36L,50L,37L,37L,42L,53L,43L,40L,50L,63L,42L,52L,48L,53L,45L,54L,51L,69L,52L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070961Inst : IEnumerable<long>
{
public static readonly long[] Value=A070961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070961.Bytes);
public long this[int i]=>Value[i];

public static A070961Inst Instance=new A070961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070960
{
public static readonly long[] Value={ 1L,3L,9L,36L,180L,1080L,7560L,60480L,544320L,5443200L,59875200L,718502400L,9340531200L,130767436800L,1961511552000L,31384184832000L,533531142144000L,9603560558592000L,182467650613248000L,3649353012264960000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070960Inst : IEnumerable<long>
{
public static readonly long[] Value=A070960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070960.Bytes);
public long this[int i]=>Value[i];

public static A070960Inst Instance=new A070960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070959
{
public static readonly long[] Value={ 4L,4L,39L,13L,152L,28L,391L,49L,804L,76L,1439L,109L,2344L,148L,3567L,193L,5156L,244L,7159L,301L,9624L,364L,12599L,433L,16132L,508L,20271L,589L,25064L,676L,30559L,769L,36804L,868L,43847L,973L,51736L,1084L,60519L,1201L,70244L,1324L,80959L,1453L,92712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070959Inst : IEnumerable<long>
{
public static readonly long[] Value=A070959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070959.Bytes);
public long this[int i]=>Value[i];

public static A070959Inst Instance=new A070959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070958
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,199L,200L,288L,289L,298L,300L,377L,378L,379L,387L,397L,400L,466L,467L,468L,469L,476L,486L,496L,500L,555L,556L,557L,558L,559L,565L,575L,585L,595L,600L,646L,647L,648L,649L,655L,664L,674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070958Inst : IEnumerable<long>
{
public static readonly long[] Value=A070958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070958.Bytes);
public long this[int i]=>Value[i];

public static A070958Inst Instance=new A070958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070957
{
public static readonly long[] Value={ 2L,5L,11L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070957Inst : IEnumerable<long>
{
public static readonly long[] Value=A070957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070957.Bytes);
public long this[int i]=>Value[i];

public static A070957Inst Instance=new A070957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070956
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,3L,2L,3L,2L,5L,2L,4L,4L,5L,1L,5L,2L,5L,5L,5L,2L,7L,3L,4L,4L,6L,2L,8L,4L,6L,4L,4L,5L,9L,2L,4L,5L,8L,2L,9L,4L,7L,7L,5L,2L,10L,4L,6L,4L,7L,2L,8L,5L,9L,5L,5L,2L,12L,4L,6L,8L,8L,4L,10L,4L,6L,5L,10L,4L,12L,2L,4L,8L,7L,6L,10L,4L,11L,6L,4L,2L,13L,6L,7L,5L,10L,2L,13L,8L,8L,7L,5L,5L,13L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070956Inst : IEnumerable<long>
{
public static readonly long[] Value=A070956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070956.Bytes);
public long this[int i]=>Value[i];

public static A070956Inst Instance=new A070956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070955
{
public static readonly long[] Value={ 1L,122L,346L,1454L,3526L,7408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070955Inst : IEnumerable<long>
{
public static readonly long[] Value=A070955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070955.Bytes);
public long this[int i]=>Value[i];

public static A070955Inst Instance=new A070955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070954
{
public static readonly long[] Value={ 31L,73L,149L,167L,347L,359L,769L,967L,1033L,1069L,1091L,1109L,1279L,1487L,1499L,1601L,1879L,1901L,1933L,3023L,3049L,3301L,3347L,3407L,3541L,3583L,3803L,3851L,3889L,7507L,7589L,7643L,7717L,7949L,9041L,9127L,9341L,9439L,9613L,9871L,10177L,10321L,10333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070954Inst : IEnumerable<long>
{
public static readonly long[] Value=A070954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070954.Bytes);
public long this[int i]=>Value[i];

public static A070954Inst Instance=new A070954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070953
{
public static readonly BigInteger[] Value={ 3L,18L,648L,77760L,41057280L,82771476480L,683361309818880L,BigInteger.Parse("22304913152488243200"),BigInteger.Parse("2929259634489976002969600"),BigInteger.Parse("1534275894314621670931405209600"),BigInteger.Parse("3219180858829475639028172057057689600") };
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
public class A070953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070953Inst Instance=new A070953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070952
{
public static readonly long[] Value={ 1L,3L,3L,6L,4L,9L,5L,12L,7L,12L,11L,14L,12L,19L,13L,22L,15L,19L,20L,24L,21L,23L,23L,28L,26L,27L,26L,33L,30L,34L,31L,39L,26L,39L,29L,46L,32L,44L,38L,45L,47L,41L,45L,49L,38L,55L,42L,51L,44L,53L,43L,59L,52L,60L,49L,65L,57L,60L,56L,69L,61L,70L,59L,78L,64L,56L,65L,69L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070952Inst : IEnumerable<long>
{
public static readonly long[] Value=A070952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070952.Bytes);
public long this[int i]=>Value[i];

public static A070952Inst Instance=new A070952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070951
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,2L,8L,3L,10L,7L,10L,9L,13L,8L,16L,9L,18L,16L,17L,15L,20L,20L,22L,19L,23L,24L,27L,22L,27L,25L,30L,24L,39L,28L,40L,25L,41L,31L,39L,34L,34L,42L,40L,38L,51L,36L,51L,44L,53L,46L,58L,44L,53L,47L,60L,46L,56L,55L,61L,50L,60L,53L,66L,49L,65L,75L,68L,66L,68L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070951Inst : IEnumerable<long>
{
public static readonly long[] Value=A070951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070951.Bytes);
public long this[int i]=>Value[i];

public static A070951Inst Instance=new A070951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070950
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070950Inst : IEnumerable<long>
{
public static readonly long[] Value=A070950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070950.Bytes);
public long this[int i]=>Value[i];

public static A070950Inst Instance=new A070950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070949
{
public static readonly long[] Value={ -1L,3L,-5L,7L,-5L,7L,-11L,13L,-11L,19L,-21L,19L,-11L,13L,-19L,21L,-19L,37L,-47L,49L,-31L,39L,-45L,39L,-31L,49L,-47L,37L,-19L,21L,-29L,31L,-29L,61L,-83L,93L,-61L,79L,-101L,97L,-79L,129L,-131L,109L,-59L,67L,-77L,67L,-59L,109L,-131L,129L,-79L,97L,-101L,79L,-61L,93L,-83L,61L,-29L,31L,-41L,43L,-41L,91L,-129L,151L,-101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070949Inst : IEnumerable<long>
{
public static readonly long[] Value=A070949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070949.Bytes);
public long this[int i]=>Value[i];

public static A070949Inst Instance=new A070949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070948
{
public static readonly BigInteger[] Value={ 1L,3L,5L,8L,14L,17L,44L,53L,1011L,7262969L,27755899054L,10713771825916682198UL,BigInteger.Parse("1451983503000530523834049701901973110"),BigInteger.Parse("5317619734003376302895262678416297955761358855419919105266696681033714") };
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
public class A070948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070948Inst Instance=new A070948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070787
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,0L,2L,1L,4L,0L,1L,3L,0L,2L,5L,5L,2L,0L,13L,0L,0L,0L,2L,9L,8L,1L,1L,9L,4L,0L,10L,0L,10L,2L,12L,11L,0L,3L,23L,14L,0L,0L,1L,13L,0L,0L,5L,5L,18L,5L,32L,18L,2L,2L,2L,0L,19L,0L,13L,16L,0L,1L,20L,35L,0L,0L,42L,0L,4L,0L,23L,24L,23L,9L,1L,0L,8L,0L,44L,10L,27L,0L,1L,48L,0L,9L,2L,27L,25L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070787Inst : IEnumerable<long>
{
public static readonly long[] Value=A070787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070787.Bytes);
public long this[int i]=>Value[i];

public static A070787Inst Instance=new A070787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070786
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,2L,3L,4L,3L,2L,1L,3L,3L,6L,2L,4L,2L,4L,6L,1L,3L,5L,2L,4L,3L,6L,2L,3L,1L,5L,1L,4L,4L,2L,6L,7L,3L,6L,8L,6L,3L,1L,3L,5L,6L,4L,8L,2L,5L,10L,1L,4L,2L,6L,3L,7L,9L,5L,9L,7L,3L,2L,4L,1L,8L,9L,5L,7L,10L,3L,6L,9L,12L,4L,2L,8L,6L,4L,2L,10L,8L,12L,6L,2L,6L,3L,1L,7L,5L,10L,11L,4L,8L,7L,14L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070786Inst : IEnumerable<long>
{
public static readonly long[] Value=A070786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070786.Bytes);
public long this[int i]=>Value[i];

public static A070786Inst Instance=new A070786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070785
{
public static readonly long[] Value={ 2L,1L,4L,4L,1L,5L,2L,2L,4L,8L,6L,4L,1L,4L,3L,12L,5L,8L,2L,5L,13L,4L,5L,8L,1L,4L,4L,10L,4L,5L,2L,10L,1L,5L,4L,1L,9L,13L,2L,8L,16L,12L,3L,5L,4L,8L,9L,4L,16L,1L,5L,20L,4L,8L,2L,8L,2L,10L,18L,4L,15L,14L,8L,4L,5L,1L,13L,17L,4L,8L,16L,6L,6L,12L,24L,10L,5L,16L,9L,4L,1L,17L,10L,26L,5L,8L,10L,4L,2L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070785Inst : IEnumerable<long>
{
public static readonly long[] Value=A070785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070785.Bytes);
public long this[int i]=>Value[i];

public static A070785Inst Instance=new A070785Inst();

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