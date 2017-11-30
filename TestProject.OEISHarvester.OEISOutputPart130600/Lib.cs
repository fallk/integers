using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159905
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,4L,4L,3L,2L,1L,2L,2L,3L,3L,2L,1L,6L,6L,5L,4L,3L,2L,1L,4L,4L,4L,4L,4L,3L,2L,1L,6L,6L,6L,6L,5L,4L,3L,2L,1L,4L,4L,5L,5L,5L,5L,4L,3L,2L,1L,10L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,4L,4L,4L,5L,6L,6L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159905Inst : IEnumerable<long>
{
public static readonly long[] Value=A159905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159905.Bytes);
public long this[int i]=>Value[i];

public static A159905Inst Instance=new A159905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159906
{
public static readonly long[] Value={ 1L,1L,1L,2L,-1L,2L,2L,0L,0L,2L,4L,-1L,-1L,-1L,4L,2L,0L,2L,-1L,1L,2L,6L,-1L,-1L,-1L,-1L,-1L,6L,40L,0L,0L,0L,0L,0L,0L,4L,6L,-3L,3L,0L,0L,-3L,0L,0L,6L,4L,2L,-1L,-3L,4L,-1L,1L,-1L,1L,4L,10L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159906Inst : IEnumerable<long>
{
public static readonly long[] Value=A159906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159906.Bytes);
public long this[int i]=>Value[i];

public static A159906Inst Instance=new A159906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159907
{
public static readonly long[] Value={ 2L,24L,4320L,4680L,26208L,8910720L,17428320L,20427264L,91963648L,197064960L,8583644160L,10200236032L,21857648640L,57575890944L,57629644800L,206166804480L,17116004505600L,1416963251404800L,15338300494970880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159907Inst : IEnumerable<long>
{
public static readonly long[] Value=A159907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159907.Bytes);
public long this[int i]=>Value[i];

public static A159907Inst Instance=new A159907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159908
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,15L,19L,23L,27L,30L,34L,35L,43L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159908Inst : IEnumerable<long>
{
public static readonly long[] Value=A159908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159908.Bytes);
public long this[int i]=>Value[i];

public static A159908Inst Instance=new A159908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159909
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,3L,3L,4L,2L,7L,1L,3L,2L,6L,6L,4L,7L,9L,6L,5L,10L,7L,9L,8L,6L,13L,9L,4L,14L,10L,10L,18L,6L,12L,12L,10L,16L,15L,11L,18L,14L,11L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159909Inst : IEnumerable<long>
{
public static readonly long[] Value=A159909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159909.Bytes);
public long this[int i]=>Value[i];

public static A159909Inst Instance=new A159909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159910
{
public static readonly long[] Value={ 0L,3L,3L,21L,22L,13L,7L,39L,7L,73L,126L,119L,88L,3L,11L,66L,29L,17L,53L,42L,101L,214L,104L,298L,252L,133L,255L,141L,76L,91L,168L,81L,45L,56L,203L,301L,43L,66L,291L,223L,92L,97L,442L,290L,437L,281L,38L,144L,549L,241L,29L,192L,11L,518L,266L,490L,122L,130L,13L,329L,85L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159910Inst : IEnumerable<long>
{
public static readonly long[] Value=A159910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159910.Bytes);
public long this[int i]=>Value[i];

public static A159910Inst Instance=new A159910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159911
{
public static readonly long[] Value={ 211L,223L,229L,241L,307L,311L,313L,317L,331L,337L,347L,353L,359L,503L,523L,541L,547L,719L,743L,1103L,1117L,1123L,1129L,1153L,1303L,1307L,1319L,1723L,1741L,1747L,1753L,1759L,1907L,1913L,1931L,2311L,2341L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159911Inst : IEnumerable<long>
{
public static readonly long[] Value=A159911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159911.Bytes);
public long this[int i]=>Value[i];

public static A159911Inst Instance=new A159911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159912
{
public static readonly long[] Value={ 0L,1L,4L,7L,14L,17L,24L,31L,46L,49L,56L,63L,78L,85L,100L,115L,146L,149L,156L,163L,178L,185L,200L,215L,246L,253L,268L,283L,314L,329L,360L,391L,454L,457L,464L,471L,486L,493L,508L,523L,554L,561L,576L,591L,622L,637L,668L,699L,762L,769L,784L,799L,830L,845L,876L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159912Inst : IEnumerable<long>
{
public static readonly long[] Value=A159912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159912.Bytes);
public long this[int i]=>Value[i];

public static A159912Inst Instance=new A159912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159913
{
public static readonly long[] Value={ 1L,3L,3L,7L,3L,7L,7L,15L,3L,7L,7L,15L,7L,15L,15L,31L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L,63L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L,63L,7L,15L,15L,31L,15L,31L,31L,63L,15L,31L,31L,63L,31L,63L,63L,127L,3L,7L,7L,15L,7L,15L,15L,31L,7L,15L,15L,31L,15L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159913Inst : IEnumerable<long>
{
public static readonly long[] Value=A159913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159913.Bytes);
public long this[int i]=>Value[i];

public static A159913Inst Instance=new A159913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159914
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,5L,8L,14L,22L,30L,40L,55L,73L,91L,112L,140L,172L,204L,240L,285L,335L,385L,440L,506L,578L,650L,728L,819L,917L,1015L,1120L,1240L,1368L,1496L,1632L,1785L,1947L,2109L,2280L,2470L,2670L,2870L,3080L,3311L,3553L,3795L,4048L,4324L,4612L,4900L,5200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159914Inst : IEnumerable<long>
{
public static readonly long[] Value=A159914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159914.Bytes);
public long this[int i]=>Value[i];

public static A159914Inst Instance=new A159914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159915
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,6L,8L,8L,10L,15L,18L,18L,21L,28L,32L,32L,36L,45L,50L,50L,55L,66L,72L,72L,78L,91L,98L,98L,105L,120L,128L,128L,136L,153L,162L,162L,171L,190L,200L,200L,210L,231L,242L,242L,253L,276L,288L,288L,300L,325L,338L,338L,351L,378L,392L,392L,406L,435L,450L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159915Inst : IEnumerable<long>
{
public static readonly long[] Value=A159915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159915.Bytes);
public long this[int i]=>Value[i];

public static A159915Inst Instance=new A159915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159916
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,2L,4L,2L,0L,3L,6L,4L,2L,1L,3L,9L,10L,6L,3L,1L,4L,12L,16L,16L,12L,4L,0L,4L,16L,28L,32L,28L,16L,4L,0L,5L,20L,40L,60L,66L,44L,16L,4L,1L,5L,25L,60L,100L,126L,110L,60L,20L,5L,1L,6L,30L,80L,160L,236L,236L,160L,80L,30L,6L,0L,6L,36L,110L,240L,396L,472L,396L,240L,110L,36L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159916Inst : IEnumerable<long>
{
public static readonly long[] Value=A159916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159916.Bytes);
public long this[int i]=>Value[i];

public static A159916Inst Instance=new A159916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159917
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159917Inst : IEnumerable<long>
{
public static readonly long[] Value=A159917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159917.Bytes);
public long this[int i]=>Value[i];

public static A159917Inst Instance=new A159917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159918
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,3L,1L,3L,3L,5L,2L,4L,3L,4L,1L,3L,3L,5L,3L,6L,5L,3L,2L,5L,4L,6L,3L,5L,4L,5L,1L,3L,3L,5L,3L,6L,5L,7L,3L,5L,6L,7L,5L,8L,3L,4L,2L,5L,5L,5L,4L,8L,6L,7L,3L,6L,5L,7L,4L,6L,5L,6L,1L,3L,3L,5L,3L,6L,5L,7L,3L,6L,6L,9L,5L,7L,7L,5L,3L,6L,5L,8L,6L,7L,7L,7L,5L,9L,8L,5L,3L,6L,4L,5L,2L,5L,5L,6L,5L,9L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159918Inst : IEnumerable<long>
{
public static readonly long[] Value=A159918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159918.Bytes);
public long this[int i]=>Value[i];

public static A159918Inst Instance=new A159918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159919
{
public static readonly long[] Value={ 4L,7L,7L,10L,12L,10L,13L,17L,17L,13L,16L,22L,24L,22L,16L,19L,27L,31L,31L,27L,19L,22L,32L,38L,40L,38L,32L,22L,25L,37L,45L,49L,49L,45L,37L,25L,28L,42L,52L,58L,60L,58L,52L,42L,28L,31L,47L,59L,67L,71L,71L,67L,59L,47L,31L,34L,52L,66L,76L,82L,84L,82L,76L,66L,52L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159919Inst : IEnumerable<long>
{
public static readonly long[] Value=A159919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159919.Bytes);
public long this[int i]=>Value[i];

public static A159919Inst Instance=new A159919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159920
{
public static readonly long[] Value={ 4L,14L,32L,60L,100L,154L,224L,312L,420L,550L,704L,884L,1092L,1330L,1600L,1904L,2244L,2622L,3040L,3500L,4004L,4554L,5152L,5800L,6500L,7254L,8064L,8932L,9860L,10850L,11904L,13024L,14212L,15470L,16800L,18204L,19684L,21242L,22880L,24600L,26404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159920Inst : IEnumerable<long>
{
public static readonly long[] Value=A159920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159920.Bytes);
public long this[int i]=>Value[i];

public static A159920Inst Instance=new A159920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159921
{
public static readonly BigInteger[] Value={ 1L,36L,238L,-67608L,-3189300L,171302256L,23038278216L,-258048705312L,-179911241858928L,-4292680465160640L,1558578348234929376L,BigInteger.Parse("101525379857857028736"),BigInteger.Parse("-14483821141875255043392"),BigInteger.Parse("-1810383783782862018394368"),BigInteger.Parse("134036659769169225204616320"),BigInteger.Parse("31640724357081844323823566336") };
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
public class A159921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159921Inst Instance=new A159921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159922
{
public static readonly long[] Value={ 643266L,8813528L,1644953L,440421L,2826655L,1339785L,2775232L,988180L,196973L,643136L,4122122L,3477939L,182124L,6195602L,130854L,4937610L,2725523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159922Inst : IEnumerable<long>
{
public static readonly long[] Value=A159922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159922.Bytes);
public long this[int i]=>Value[i];

public static A159922Inst Instance=new A159922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159923
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L,1L,2L,5L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,3L,1L,2L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,7L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159923Inst : IEnumerable<long>
{
public static readonly long[] Value=A159923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159923.Bytes);
public long this[int i]=>Value[i];

public static A159923Inst Instance=new A159923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159924
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,22L,21L,17L,1L,99L,98L,94L,78L,1L,546L,545L,541L,525L,448L,1L,3599L,3598L,3594L,3578L,3501L,3054L,1L,27577L,27576L,27572L,27556L,27479L,27032L,23979L,1L,240327L,240326L,240322L,240306L,240229L,239782L,236729L,212751L,1L,2343850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159924Inst : IEnumerable<long>
{
public static readonly long[] Value=A159924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159924.Bytes);
public long this[int i]=>Value[i];

public static A159924Inst Instance=new A159924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159925
{
public static readonly long[] Value={ 1L,3L,12L,61L,370L,2606L,20925L,188772L,1890773L,20822481L,250082522L,3253176309L,45567394330L,683783923476L,10944068960451L,186098265906832L,3350501663825617L,63671208559149815L,1273621946395366224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159925Inst : IEnumerable<long>
{
public static readonly long[] Value=A159925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159925.Bytes);
public long this[int i]=>Value[i];

public static A159925Inst Instance=new A159925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159926
{
public static readonly long[] Value={ 1L,4L,16L,77L,447L,3053L,23978L,212750L,2103523L,22926004L,273008526L,3526184835L,49093579165L,732877502641L,11676946463092L,197775212369924L,3548276876195541L,67219485435345356L,1340841431830711580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159926Inst : IEnumerable<long>
{
public static readonly long[] Value=A159926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159926.Bytes);
public long this[int i]=>Value[i];

public static A159926Inst Instance=new A159926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159927
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,4L,25L,24L,23L,19L,135L,134L,133L,129L,110L,886L,885L,884L,880L,861L,751L,6784L,6783L,6782L,6778L,6759L,6649L,5898L,59115L,59114L,59113L,59109L,59090L,58980L,58229L,52331L,576527L,576526L,576525L,576521L,576502L,576392L,575641L,569743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159927Inst : IEnumerable<long>
{
public static readonly long[] Value=A159927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159927.Bytes);
public long this[int i]=>Value[i];

public static A159927Inst Instance=new A159927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159928
{
public static readonly long[] Value={ 1L,3L,15L,91L,641L,5147L,46433L,465081L,5121789L,61513799L,800196799L,11208394387L,168193068805L,2691956450679L,45775335405729L,824136306116113L,15661462041469817L,313277888390065739L,6579708440058166031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159928Inst : IEnumerable<long>
{
public static readonly long[] Value=A159928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159928.Bytes);
public long this[int i]=>Value[i];

public static A159928Inst Instance=new A159928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159929
{
public static readonly long[] Value={ 1L,2L,5L,11L,26L,57L,131L,296L,669L,1515L,3430L,7765L,17577L,39790L,90069L,203897L,461562L,1044847L,2365239L,5354224L,12120455L,27437267L,62110208L,140599921L,318278385L,720492104L,1630990029L,3692099407L,8357867190L,18919843773L,42829166807L,96953101328L,219474357191L,496827773575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159929Inst : IEnumerable<long>
{
public static readonly long[] Value=A159929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159929.Bytes);
public long this[int i]=>Value[i];

public static A159929Inst Instance=new A159929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159930
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,3L,17L,16L,15L,12L,77L,76L,75L,72L,60L,437L,436L,435L,432L,420L,360L,2957L,2956L,2955L,2952L,2940L,2880L,2520L,23117L,23116L,23115L,23112L,23100L,23040L,22680L,20160L,204557L,204556L,204555L,204552L,204540L,204480L,204120L,201600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159930Inst : IEnumerable<long>
{
public static readonly long[] Value=A159930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159930.Bytes);
public long this[int i]=>Value[i];

public static A159930Inst Instance=new A159930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159931
{
public static readonly BigInteger[] Value={ 1L,2L,1L,4L,3L,2L,28L,27L,26L,24L,471772L,471771L,471770L,471768L,471744L,BigInteger.Parse("23368379007628963695121285852"),BigInteger.Parse("23368379007628963695121285851"),BigInteger.Parse("23368379007628963695121285850"),BigInteger.Parse("23368379007628963695121285848") };
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
public class A159931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159931Inst Instance=new A159931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159932
{
public static readonly BigInteger[] Value={ 1L,2L,24L,471744L,BigInteger.Parse("23368379007628963695120814080") };
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
public class A159932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159932Inst Instance=new A159932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159933
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-1L,2L,-1L,-1L,3L,-4L,2L,2L,-3L,0L,0L,6L,-7L,-5L,14L,-2L,-14L,6L,13L,-12L,-2L,6L,-1L,-8L,7L,36L,-79L,15L,108L,-100L,-23L,32L,83L,-60L,-167L,306L,-133L,-184L,318L,-158L,-91L,54L,295L,-232L,-641L,1059L,180L,-1470L,497L,1404L,-1069L,-978L,1396L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159933Inst : IEnumerable<long>
{
public static readonly long[] Value=A159933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159933.Bytes);
public long this[int i]=>Value[i];

public static A159933Inst Instance=new A159933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159934
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,2L,0L,-1L,2L,2L,-1L,0L,-2L,2L,3L,2L,-1L,0L,-2L,3L,2L,-1L,2L,-2L,0L,-3L,2L,4L,-1L,-1L,4L,-2L,0L,-2L,4L,2L,3L,-1L,-2L,4L,-3L,0L,-4L,2L,4L,-4L,3L,-2L,-2L,6L,-2L,0L,-2L,4L,3L,2L,-4L,6L,-2L,-3L,4L,-4L,0L,-4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159934Inst : IEnumerable<long>
{
public static readonly long[] Value=A159934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159934.Bytes);
public long this[int i]=>Value[i];

public static A159934Inst Instance=new A159934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159935
{
public static readonly long[] Value={ 5L,3L,2L,4L,3L,5L,4L,3L,4L,7L,6L,4L,5L,9L,4L,5L,6L,5L,6L,6L,5L,11L,12L,5L,7L,15L,6L,8L,6L,7L,8L,6L,7L,13L,6L,8L,7L,21L,8L,7L,9L,7L,10L,12L,7L,15L,8L,7L,10L,9L,10L,8L,9L,11L,8L,9L,8L,17L,30L,8L,10L,9L,8L,9L,9L,13L,10L,18L,9L,11L,12L,9L,12L,9L,10L,10L,9L,15L,16L,9L,10L,11L,10L,10L,11L,21L,12L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159935Inst : IEnumerable<long>
{
public static readonly long[] Value=A159935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159935.Bytes);
public long this[int i]=>Value[i];

public static A159935Inst Instance=new A159935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159936
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,1L,1L,2L,2L,3L,2L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,2L,4L,4L,4L,4L,1L,1L,2L,3L,3L,3L,6L,6L,6L,1L,1L,2L,2L,4L,4L,5L,4L,5L,4L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,2L,2L,3L,2L,4L,4L,6L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159936Inst : IEnumerable<long>
{
public static readonly long[] Value=A159936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159936.Bytes);
public long this[int i]=>Value[i];

public static A159936Inst Instance=new A159936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159937
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,2L,1L,0L,2L,4L,0L,0L,0L,4L,2L,2L,2L,0L,0L,2L,6L,0L,0L,0L,0L,0L,6L,4L,2L,0L,2L,0L,0L,0L,4L,6L,0L,4L,0L,0L,0L,0L,0L,6L,4L,4L,0L,0L,4L,0L,0L,0L,0L,4L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,4L,2L,4L,4L,0L,2L,0L,0L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159937Inst : IEnumerable<long>
{
public static readonly long[] Value=A159937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159937.Bytes);
public long this[int i]=>Value[i];

public static A159937Inst Instance=new A159937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159938
{
public static readonly long[] Value={ 2L,6L,16L,36L,70L,122L,196L,296L,426L,590L,792L,1036L,1326L,1666L,2060L,2512L,3026L,3606L,4256L,4980L,5782L,6666L,7636L,8696L,9850L,11102L,12456L,13916L,15486L,17170L,18972L,20896L,22946L,25126L,27440L,29892L,32486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159938Inst : IEnumerable<long>
{
public static readonly long[] Value=A159938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159938.Bytes);
public long this[int i]=>Value[i];

public static A159938Inst Instance=new A159938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159939
{
public static readonly long[] Value={ 9L,225L,729L,18225L,65025L,140625L,531441L,5267025L,11390625L,13286025L,18792225L,40640625L,87890625L,1522170225L,2197265625L,3291890625L,3839661225L,5430953025L,7119140625L,8303765625L,11745140625L,25400390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159939Inst : IEnumerable<long>
{
public static readonly long[] Value=A159939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159939.Bytes);
public long this[int i]=>Value[i];

public static A159939Inst Instance=new A159939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159940
{
public static readonly long[] Value={ 4L,16L,46L,106L,208L,364L,586L,886L,1276L,1768L,2374L,3106L,3976L,4996L,6178L,7534L,9076L,10816L,12766L,14938L,17344L,19996L,22906L,26086L,29548L,33304L,37366L,41746L,46456L,51508L,56914L,62686L,68836L,75376L,82318L,89674L,97456L,105676L,114346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159940Inst : IEnumerable<long>
{
public static readonly long[] Value=A159940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159940.Bytes);
public long this[int i]=>Value[i];

public static A159940Inst Instance=new A159940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159941
{
public static readonly long[] Value={ 8L,32L,92L,212L,416L,728L,1172L,1772L,2552L,3536L,4748L,6212L,7952L,9992L,12356L,15068L,18152L,21632L,25532L,29876L,34688L,39992L,45812L,52172L,59096L,66608L,74732L,83492L,92912L,103016L,113828L,125372L,137672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159941Inst : IEnumerable<long>
{
public static readonly long[] Value=A159941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159941.Bytes);
public long this[int i]=>Value[i];

public static A159941Inst Instance=new A159941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159942
{
public static readonly long[] Value={ 2L,5L,7L,10L,16L,17L,19L,20L,23L,29L,31L,38L,41L,49L,50L,55L,56L,59L,61L,64L,71L,76L,79L,85L,92L,100L,101L,103L,121L,134L,136L,139L,140L,143L,149L,154L,155L,161L,175L,176L,178L,182L,184L,188L,208L,209L,211L,217L,220L,232L,236L,239L,241L,244L,265L,266L,269L,271L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159942Inst : IEnumerable<long>
{
public static readonly long[] Value=A159942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159942.Bytes);
public long this[int i]=>Value[i];

public static A159942Inst Instance=new A159942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159943
{
public static readonly BigInteger[] Value={ 1L,38L,386L,-65740L,-3723284L,136726888L,24891794104L,77945890928L,-181386683278960L,-7552427985415072L,1440171734736484384L,BigInteger.Parse("134631214005677868352"),BigInteger.Parse("-11644732516647446263616"),BigInteger.Parse("-2151777728648689174614400"),BigInteger.Parse("78394097345318787274427264"),BigInteger.Parse("34851107415866497970816728832") };
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
public class A159943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159943Inst Instance=new A159943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159944
{
public static readonly long[] Value={ 0L,1L,4L,11L,26L,46L,84L,123L,194L,268L,378L,478L,657L,800L,1019L,1239L,1548L,1793L,2197L,2505L,3003L,3434L,3991L,4444L,5223L,5801L,6582L,7292L,8274L,9006L,10199L,11034L,12330L,13398L,14744L,15912L,17705L,18906L,20586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159944Inst : IEnumerable<long>
{
public static readonly long[] Value=A159944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159944.Bytes);
public long this[int i]=>Value[i];

public static A159944Inst Instance=new A159944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159945
{
public static readonly long[] Value={ 2L,1L,3L,3L,2L,2L,4L,3L,4L,1L,3L,4L,3L,3L,5L,4L,4L,3L,5L,8L,2L,2L,4L,3L,4L,2L,4L,4L,4L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159945Inst : IEnumerable<long>
{
public static readonly long[] Value=A159945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159945.Bytes);
public long this[int i]=>Value[i];

public static A159945Inst Instance=new A159945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159946
{
public static readonly BigInteger[] Value={ 1L,40L,542L,-62960L,-4238708L,96898400L,26298701320L,436837009600L,-177294701591920L,-10789176512931200L,1256633088041014240L,BigInteger.Parse("164414811028452665600"),BigInteger.Parse("-8048103437483217101120"),BigInteger.Parse("-2409334578316563726502400"),BigInteger.Parse("14320231546481618948708480"),BigInteger.Parse("36259873035884206674901888000") };
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
public class A159946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159946Inst Instance=new A159946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159947
{
public static readonly BigInteger[] Value={ 1L,42L,706L,-59220L,-4728084L,52039512L,27197223864L,811936580112L,-167321303572080L,-13899725964095328L,1009444962121341984L,BigInteger.Parse("189455789109224933568"),BigInteger.Parse("-3790777326580730799936"),BigInteger.Parse("-2564543346247110450176640"),BigInteger.Parse("-55572469192587267485099136"),BigInteger.Parse("35651972338523534753642227968") };
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
public class A159947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159947Inst Instance=new A159947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159948
{
public static readonly BigInteger[] Value={ 1L,44L,878L,-54472L,-5183540L,2449744L,27528715336L,1195712499872L,-151266315784048L,-16776228493414720L,702203805185457376L,BigInteger.Parse("208389464888487862144"),BigInteger.Parse("996888570345112992448"),BigInteger.Parse("-2601849549129056926112512"),BigInteger.Parse("-128192585558205188847080320"),BigInteger.Parse("32898121757138562880306993664") };
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
public class A159948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159948Inst Instance=new A159948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159949
{
public static readonly BigInteger[] Value={ 1L,1L,-287L,-863L,247105L,1241281L,-354589919L,-2499523487L,712353753217L,6471255867265L,-1839949672471199L,-20477166570194399L,5808483395818564033L,BigInteger.Parse("76577571062410406977"),BigInteger.Parse("-21670384262882293332575"),BigInteger.Parse("-330431150786521054263839"),BigInteger.Parse("93285628864864986142460161") };
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
public class A159949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159949Inst Instance=new A159949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159950
{
public static readonly BigInteger[] Value={ 240L,122522400L,137932073613734400L,BigInteger.Parse("342696507457909818131702784000"),BigInteger.Parse("1879127177606120717127879344567470740879360000"),BigInteger.Parse("22740756589119797763590969093409514524935686067027158720512000000") };
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
public class A159950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159950Inst Instance=new A159950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159951
{
public static readonly BigInteger[] Value={ 12L,856800L,139890541190400L,BigInteger.Parse("50664770469826998541056000"),BigInteger.Parse("40527253814267058837705250384270510080000"),BigInteger.Parse("71554565901386985191123530075861409411081105273676595200000") };
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
public class A159951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159951Inst Instance=new A159951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159952
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,22L,100L,101L,102L,110L,111L,112L,120L,121L,122L,200L,201L,202L,210L,211L,212L,220L,221L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1022L,1100L,1101L,1102L,1110L,1111L,1112L,1120L,1121L,1122L,1200L,1201L,1202L,1210L,1211L,1212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159952Inst : IEnumerable<long>
{
public static readonly long[] Value=A159952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159952.Bytes);
public long this[int i]=>Value[i];

public static A159952Inst Instance=new A159952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159953
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,5L,2L,3L,3L,4L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,5L,2L,2L,6L,4L,2L,2L,5L,2L,5L,3L,3L,3L,7L,3L,6L,2L,3L,2L,2L,6L,3L,2L,4L,2L,3L,8L,2L,9L,4L,2L,6L,2L,2L,2L,2L,2L,2L,4L,8L,4L,2L,2L,2L,3L,4L,3L,9L,2L,10L,2L,3L,2L,4L,4L,3L,4L,2L,2L,11L,5L,2L,5L,2L,3L,4L,2L,2L,3L,5L,3L,8L,7L,4L,15L,2L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159953Inst : IEnumerable<long>
{
public static readonly long[] Value=A159953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159953.Bytes);
public long this[int i]=>Value[i];

public static A159953Inst Instance=new A159953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159954
{
public static readonly BigInteger[] Value={ 1L,5L,-263L,-4195L,206257L,5863925L,-267690455L,-11471314675L,482307383905L,28841445930725L,-1105933509428135L,-88593031827628675L,3060632198730188305L,BigInteger.Parse("321480678989935642325"),BigInteger.Parse("-9851603557096146802295"),BigInteger.Parse("-1345468115472901243865875"),BigInteger.Parse("35831586789290847966585025") };
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
public class A159954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159954Inst Instance=new A159954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159955
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159955Inst : IEnumerable<long>
{
public static readonly long[] Value=A159955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159955.Bytes);
public long this[int i]=>Value[i];

public static A159955Inst Instance=new A159955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159956
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L,3L,0L,1L,3L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159956Inst : IEnumerable<long>
{
public static readonly long[] Value=A159956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159956.Bytes);
public long this[int i]=>Value[i];

public static A159956Inst Instance=new A159956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159957
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L,0L,1L,2L,3L,4L,1L,2L,3L,4L,0L,2L,3L,4L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159957Inst : IEnumerable<long>
{
public static readonly long[] Value=A159957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159957.Bytes);
public long this[int i]=>Value[i];

public static A159957Inst Instance=new A159957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159958
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,3L,8L,6L,7L,10L,11L,9L,14L,12L,13L,15L,16L,17L,20L,18L,19L,21L,22L,23L,25L,26L,24L,28L,29L,27L,32L,30L,31L,33L,34L,35L,38L,36L,37L,39L,40L,41L,43L,44L,42L,45L,46L,47L,49L,50L,48L,53L,51L,52L,56L,54L,55L,57L,58L,59L,61L,62L,60L,63L,64L,65L,67L,68L,66L,71L,69L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159958Inst : IEnumerable<long>
{
public static readonly long[] Value=A159958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159958.Bytes);
public long this[int i]=>Value[i];

public static A159958Inst Instance=new A159958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159959
{
public static readonly long[] Value={ 1L,3L,0L,2L,5L,4L,6L,7L,8L,10L,12L,14L,9L,11L,13L,15L,17L,19L,16L,21L,23L,18L,25L,20L,27L,22L,29L,24L,26L,28L,31L,30L,32L,34L,33L,36L,38L,40L,42L,35L,44L,37L,39L,46L,41L,48L,50L,52L,43L,45L,54L,56L,58L,60L,47L,62L,64L,66L,49L,51L,68L,53L,70L,72L,55L,57L,74L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159959Inst : IEnumerable<long>
{
public static readonly long[] Value=A159959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159959.Bytes);
public long this[int i]=>Value[i];

public static A159959Inst Instance=new A159959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159960
{
public static readonly BigInteger[] Value={ 1L,10L,292L,16152L,1443616L,189709600L,34420171584L,8241995095936L,2517637537094656L,955377719901439488L,BigInteger.Parse("440888939541736115200"),BigInteger.Parse("243144648530111594371072"),BigInteger.Parse("157920570527279020394569728"),BigInteger.Parse("119308432982412667510831095808"),BigInteger.Parse("103738687936577909824307104989184") };
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
public class A159960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159960Inst Instance=new A159960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159961
{
public static readonly long[] Value={ 91L,169L,217L,469L,721L,817L,1027L,1141L,1261L,1387L,1519L,2107L,2611L,2977L,3367L,3781L,3997L,4681L,4921L,5677L,5941L,6487L,6769L,7651L,7957L,8587L,8911L,9577L,9919L,10621L,10981L,11347L,12481L,12871L,14077L,14491L,14911L,15337L,15769L,16207L,17101L,17557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159961Inst : IEnumerable<long>
{
public static readonly long[] Value=A159961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159961.Bytes);
public long this[int i]=>Value[i];

public static A159961Inst Instance=new A159961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159962
{
public static readonly long[] Value={ 1L,0L,3L,4L,6L,2L,7L,10L,9L,13L,5L,8L,11L,14L,12L,16L,15L,17L,19L,22L,18L,21L,20L,25L,28L,31L,34L,37L,24L,23L,26L,40L,29L,32L,35L,38L,41L,27L,43L,46L,49L,44L,30L,52L,47L,55L,50L,58L,53L,61L,56L,33L,36L,64L,59L,67L,70L,39L,42L,73L,45L,48L,76L,51L,79L,62L,65L,68L,54L,71L,74L,77L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159962Inst : IEnumerable<long>
{
public static readonly long[] Value=A159962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159962.Bytes);
public long this[int i]=>Value[i];

public static A159962Inst Instance=new A159962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159963
{
public static readonly long[] Value={ 0L,3L,6L,2L,1L,9L,4L,12L,5L,8L,11L,7L,10L,14L,15L,17L,13L,16L,19L,18L,20L,22L,23L,25L,21L,24L,27L,28L,26L,30L,31L,33L,29L,32L,35L,34L,36L,38L,39L,41L,37L,40L,43L,42L,45L,46L,44L,49L,48L,51L,54L,47L,52L,57L,55L,60L,50L,53L,63L,66L,58L,56L,69L,59L,61L,64L,67L,72L,62L,70L,65L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159963Inst : IEnumerable<long>
{
public static readonly long[] Value=A159963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159963.Bytes);
public long this[int i]=>Value[i];

public static A159963Inst Instance=new A159963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159964
{
public static readonly long[] Value={ 1L,0L,-4L,-16L,-48L,-128L,-320L,-768L,-1792L,-4096L,-9216L,-20480L,-45056L,-98304L,-212992L,-458752L,-983040L,-2097152L,-4456448L,-9437184L,-19922944L,-41943040L,-88080384L,-184549376L,-385875968L,-805306368L,-1677721600L,-3489660928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159964Inst : IEnumerable<long>
{
public static readonly long[] Value=A159964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159964.Bytes);
public long this[int i]=>Value[i];

public static A159964Inst Instance=new A159964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159965
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,20L,21L,8L,1L,70L,84L,45L,11L,1L,252L,330L,220L,78L,14L,1L,924L,1287L,1001L,455L,120L,17L,1L,3432L,5005L,4368L,2380L,816L,171L,20L,1L,12870L,19448L,18564L,11628L,4845L,1330L,231L,23L,1L,48620L,75582L,77520L,54264L,26334L,8855L,2024L,300L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159965Inst : IEnumerable<long>
{
public static readonly long[] Value=A159965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159965.Bytes);
public long this[int i]=>Value[i];

public static A159965Inst Instance=new A159965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159966
{
public static readonly long[] Value={ 0L,3L,2L,1L,4L,7L,6L,5L,8L,11L,10L,9L,12L,15L,14L,13L,16L,19L,18L,17L,20L,23L,22L,21L,24L,27L,26L,25L,28L,31L,30L,29L,32L,35L,34L,33L,36L,39L,38L,37L,40L,43L,42L,41L,44L,47L,46L,45L,48L,51L,50L,49L,52L,55L,54L,53L,56L,59L,58L,57L,60L,63L,62L,61L,64L,67L,66L,65L,68L,71L,70L,69L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159966Inst : IEnumerable<long>
{
public static readonly long[] Value=A159966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159966.Bytes);
public long this[int i]=>Value[i];

public static A159966Inst Instance=new A159966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159967
{
public static readonly BigInteger[] Value={ 1L,7L,-239L,-5705L,166561L,7738087L,-185681231L,-14671182953L,271635081025L,35703851090887L,-454151172380591L,-106006149348418697L,696707868662781409L,BigInteger.Parse("371234207228774486695"),BigInteger.Parse("-9834809672032188431"),BigInteger.Parse("-1496885167214122955673257"),BigInteger.Parse("-10435709792715681635690879") };
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
public class A159967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159967Inst Instance=new A159967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159968
{
public static readonly BigInteger[] Value={ 1L,11L,-167L,-8173L,54385L,10013531L,31834441L,-16953202717L,-250663462943L,36302880967595L,1049051386591801L,-93012731934163789L,-4346534843998627247L,BigInteger.Parse("273640118280485155067"),BigInteger.Parse("19283467757016197118505"),BigInteger.Parse("-891198811579737976926589"),BigInteger.Parse("-93107767637687089298134079") };
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
public class A159968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159968Inst Instance=new A159968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159969
{
public static readonly BigInteger[] Value={ 1L,13L,-119L,-9035L,-14639L,10218013L,153914329L,-15655840187L,-513817209695L,29391432064813L,1713902824372009L,-62366587629825323L,-6240409786798253711L,BigInteger.Parse("134413599620299018045"),BigInteger.Parse("25111471036836549128569"),BigInteger.Parse("-215506510190170502086043"),BigInteger.Parse("-111283139511606108762536639") };
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
public class A159969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159969Inst Instance=new A159969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159970
{
public static readonly long[] Value={ 0L,3L,1L,5L,4L,10L,15L,9L,8L,6L,14L,13L,18L,23L,28L,2L,11L,19L,7L,16L,20L,21L,26L,25L,24L,12L,30L,31L,29L,34L,39L,33L,17L,35L,38L,22L,36L,27L,32L,41L,40L,43L,46L,45L,50L,55L,60L,44L,48L,51L,49L,53L,37L,58L,63L,42L,56L,54L,61L,68L,66L,71L,76L,65L,59L,47L,70L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159970Inst : IEnumerable<long>
{
public static readonly long[] Value=A159970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159970.Bytes);
public long this[int i]=>Value[i];

public static A159970Inst Instance=new A159970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159971
{
public static readonly long[] Value={ 1L,-2L,1L,4L,-5L,1L,-10L,19L,-8L,1L,28L,-68L,43L,-11L,1L,-84L,240L,-198L,76L,-14L,1L,264L,-847L,845L,-427L,118L,-17L,1L,-858L,3003L,-3458L,2140L,-782L,169L,-20L,1L,2860L,-10712L,13804L,-9996L,4503L,-1290L,229L,-23L,1L,-9724L,38454L,-54264L,44574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159971Inst : IEnumerable<long>
{
public static readonly long[] Value=A159971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159971.Bytes);
public long this[int i]=>Value[i];

public static A159971Inst Instance=new A159971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159972
{
public static readonly long[] Value={ 1L,-1L,0L,2L,-7L,21L,-63L,195L,-624L,2054L,-6916L,23712L,-82498L,290510L,-1033410L,3707850L,-13402695L,48760365L,-178405155L,656043855L,-2423307045L,8987427465L,-33453694485L,124936258125L,-467995871775L,1757900019099L,-6619846420551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159972Inst : IEnumerable<long>
{
public static readonly long[] Value=A159972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159972.Bytes);
public long this[int i]=>Value[i];

public static A159972Inst Instance=new A159972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159973
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159973Inst : IEnumerable<long>
{
public static readonly long[] Value=A159973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159973.Bytes);
public long this[int i]=>Value[i];

public static A159973Inst Instance=new A159973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159974
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,2L,2L,5L,4L,3L,4L,5L,12L,5L,4L,6L,10L,12L,28L,6L,5L,8L,15L,24L,28L,65L,7L,6L,10L,20L,36L,56L,65L,151L,8L,7L,12L,25L,48L,84L,130L,151L,351L,9L,8L,14L,30L,60L,112L,195L,302L,351L,816L,10L,9L,16L,35L,72L,140L,260L,453L,702L,816L,1897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159974Inst : IEnumerable<long>
{
public static readonly long[] Value=A159974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159974.Bytes);
public long this[int i]=>Value[i];

public static A159974Inst Instance=new A159974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159975
{
public static readonly long[] Value={ 13L,16L,19L,26L,124L,127L,138L,139L,145L,148L,154L,161L,163L,166L,176L,182L,187L,187L,187L,199L,218L,266L,273L,275L,286L,316L,327L,364L,412L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159975Inst : IEnumerable<long>
{
public static readonly long[] Value=A159975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159975.Bytes);
public long this[int i]=>Value[i];

public static A159975Inst Instance=new A159975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159976
{
public static readonly long[] Value={ 325L,64L,95L,65L,217L,762L,184L,973L,435L,185L,253L,644L,326L,664L,275L,819L,286L,385L,748L,995L,981L,665L,728L,374L,385L,632L,872L,637L,721L,763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159976Inst : IEnumerable<long>
{
public static readonly long[] Value=A159976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159976.Bytes);
public long this[int i]=>Value[i];

public static A159976Inst Instance=new A159976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159977
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,3L,0L,2L,3L,4L,0L,5L,0L,2L,3L,4L,0L,7L,20L,14L,3L,2L,0L,13L,4L,10L,11L,16L,0L,23L,4L,4L,25L,10L,14L,35L,6L,24L,3L,2L,6L,7L,0L,20L,9L,48L,0L,5L,28L,18L,23L,14L,14L,11L,16L,10L,21L,4L,62L,13L,38L,12L,7L,16L,12L,19L,36L,28L,143L,32L,58L,29L,96L,100L,33L,2L,30L,27L,12L,62L,25L,46L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159977Inst : IEnumerable<long>
{
public static readonly long[] Value=A159977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159977.Bytes);
public long this[int i]=>Value[i];

public static A159977Inst Instance=new A159977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159978
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,2L,3L,4L,8L,5L,6L,2L,3L,4L,4L,7L,20L,14L,3L,2L,4L,13L,4L,10L,11L,16L,14L,23L,4L,4L,25L,10L,14L,35L,6L,24L,3L,2L,6L,7L,12L,20L,9L,48L,10L,5L,28L,18L,23L,14L,14L,11L,16L,10L,21L,4L,62L,13L,38L,12L,7L,16L,12L,19L,36L,28L,143L,32L,58L,29L,96L,100L,33L,2L,30L,27L,12L,62L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159978Inst : IEnumerable<long>
{
public static readonly long[] Value=A159978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159978.Bytes);
public long this[int i]=>Value[i];

public static A159978Inst Instance=new A159978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159979
{
public static readonly long[] Value={ 1L,4L,2L,5L,8L,0L,3L,6L,11L,14L,17L,7L,10L,13L,9L,12L,15L,18L,21L,24L,27L,30L,33L,36L,39L,42L,20L,23L,26L,16L,19L,22L,45L,48L,51L,25L,28L,31L,29L,32L,35L,54L,57L,60L,63L,66L,69L,72L,75L,78L,81L,84L,87L,90L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,123L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159979Inst : IEnumerable<long>
{
public static readonly long[] Value=A159979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159979.Bytes);
public long this[int i]=>Value[i];

public static A159979Inst Instance=new A159979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159980
{
public static readonly long[] Value={ 1L,3L,0L,5L,2L,4L,6L,7L,8L,10L,12L,14L,16L,18L,20L,9L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,11L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,13L,114L,116L,118L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159980Inst : IEnumerable<long>
{
public static readonly long[] Value=A159980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159980.Bytes);
public long this[int i]=>Value[i];

public static A159980Inst Instance=new A159980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159981
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,0L,1L,2L,2L,0L,2L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159981Inst : IEnumerable<long>
{
public static readonly long[] Value=A159981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159981.Bytes);
public long this[int i]=>Value[i];

public static A159981Inst Instance=new A159981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159982
{
public static readonly long[] Value={ 32L,256L,128L,2144L,256L,1024L,512L,16384L,16384L,85088L,57088L,299088L,32768L,524288L,1172224L,809344L,21856256L,950272L,8388608L,2097152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159982Inst : IEnumerable<long>
{
public static readonly long[] Value=A159982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159982.Bytes);
public long this[int i]=>Value[i];

public static A159982Inst Instance=new A159982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159983
{
public static readonly long[] Value={ 3L,15L,15L,105L,21L,45L,35L,1575L,2205L,3465L,3465L,24255L,3465L,72765L,45045L,45045L,1576575L,85995L,945945L,297297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159983Inst : IEnumerable<long>
{
public static readonly long[] Value=A159983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159983.Bytes);
public long this[int i]=>Value[i];

public static A159983Inst Instance=new A159983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159984
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,2L,2L,4L,0L,2L,1L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,2L,2L,4L,0L,3L,4L,4L,3L,0L,4L,2L,2L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,2L,0L,4L,2L,2L,4L,0L,2L,1L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159984Inst : IEnumerable<long>
{
public static readonly long[] Value=A159984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159984.Bytes);
public long this[int i]=>Value[i];

public static A159984Inst Instance=new A159984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159985
{
public static readonly long[] Value={ 1L,1L,2L,5L,2L,0L,0L,3L,2L,2L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159985Inst : IEnumerable<long>
{
public static readonly long[] Value=A159985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159985.Bytes);
public long this[int i]=>Value[i];

public static A159985Inst Instance=new A159985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159986
{
public static readonly long[] Value={ 1L,1L,2L,5L,0L,0L,6L,2L,2L,4L,3L,0L,0L,4L,6L,6L,5L,2L,0L,0L,4L,6L,6L,5L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,2L,2L,4L,3L,0L,0L,5L,4L,4L,1L,6L,0L,0L,1L,5L,5L,3L,4L,0L,0L,1L,5L,5L,3L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,6L,6L,5L,2L,0L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159986Inst : IEnumerable<long>
{
public static readonly long[] Value=A159986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159986.Bytes);
public long this[int i]=>Value[i];

public static A159986Inst Instance=new A159986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159987
{
public static readonly long[] Value={ 1L,1L,2L,5L,6L,2L,4L,5L,6L,6L,4L,2L,4L,4L,0L,5L,6L,6L,4L,6L,4L,4L,0L,2L,4L,4L,0L,4L,0L,0L,0L,5L,6L,6L,4L,6L,4L,4L,0L,6L,4L,4L,0L,4L,0L,0L,0L,2L,4L,4L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,5L,6L,6L,4L,6L,4L,4L,0L,6L,4L,4L,0L,4L,0L,0L,0L,6L,4L,4L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,4L,4L,0L,4L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159987Inst : IEnumerable<long>
{
public static readonly long[] Value=A159987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159987.Bytes);
public long this[int i]=>Value[i];

public static A159987Inst Instance=new A159987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159988
{
public static readonly long[] Value={ 1L,1L,2L,5L,3L,9L,0L,0L,0L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159988Inst : IEnumerable<long>
{
public static readonly long[] Value=A159988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159988.Bytes);
public long this[int i]=>Value[i];

public static A159988Inst Instance=new A159988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159989
{
public static readonly long[] Value={ 1L,1L,2L,5L,2L,6L,0L,9L,2L,2L,8L,10L,4L,4L,0L,9L,6L,6L,0L,6L,0L,0L,0L,6L,0L,0L,8L,8L,8L,4L,4L,1L,6L,6L,0L,10L,4L,4L,8L,2L,8L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,6L,6L,0L,6L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,6L,8L,8L,8L,4L,4L,4L,0L,0L,0L,4L,4L,4L,8L,8L,8L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,4L,4L,8L,8L,8L,0L,0L,0L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159989Inst : IEnumerable<long>
{
public static readonly long[] Value=A159989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159989.Bytes);
public long this[int i]=>Value[i];

public static A159989Inst Instance=new A159989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159990
{
public static readonly long[] Value={ 1L,22L,7L,42L,33L,4L,38L,30L,50L,15L,43L,13L,56L,48L,24L,41L,0L,48L,22L,40L,39L,37L,23L,53L,55L,57L,45L,40L,5L,46L,50L,57L,28L,45L,46L,34L,2L,6L,7L,15L,25L,25L,13L,10L,59L,30L,13L,14L,7L,6L,15L,46L,23L,53L,59L,32L,24L,20L,11L,48L,35L,4L,4L,18L,33L,50L,7L,40L,16L,16L,1L,32L,24L,10L,43L,59L,23L,44L,51L,58L,11L,22L,26L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159990Inst : IEnumerable<long>
{
public static readonly long[] Value=A159990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159990.Bytes);
public long this[int i]=>Value[i];

public static A159990Inst Instance=new A159990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159991
{
public static readonly BigInteger[] Value={ 1L,60L,3600L,216000L,12960000L,777600000L,46656000000L,2799360000000L,167961600000000L,10077696000000000L,604661760000000000L,BigInteger.Parse("36279705600000000000"),BigInteger.Parse("2176782336000000000000"),BigInteger.Parse("130606940160000000000000") };
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
public class A159991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159991Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159991.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159991Inst Instance=new A159991Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159992
{
public static readonly BigInteger[] Value={ 1L,41L,4927L,49277L,5913251L,33262037L,31931555539L,127726222157L,4598143997653L,306542933176867L,827665919577540943L,BigInteger.Parse("49659955174652456593"),BigInteger.Parse("744899327619786848909"),BigInteger.Parse("1862248319049467122273"),BigInteger.Parse("446939596571872109345521") };
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
public class A159992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159992Inst Instance=new A159992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159993
{
public static readonly BigInteger[] Value={ 1L,30L,3600L,36000L,4320000L,24300000L,23328000000L,93312000000L,3359232000000L,223948800000000L,604661760000000000L,BigInteger.Parse("36279705600000000000"),BigInteger.Parse("544195584000000000000"),BigInteger.Parse("1360488960000000000000"),BigInteger.Parse("326517350400000000000000") };
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
public class A159993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159993Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159993.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159993Inst Instance=new A159993Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159994
{
public static readonly BigInteger[] Value={ -7L,-1219L,-193885217L,-2512095067L,-10152983807749L,-249880575515347L,BigInteger.Parse("-2950249420928771944181"),BigInteger.Parse("-5129149052857317896107"),BigInteger.Parse("-1247467412339070464235923"),BigInteger.Parse("-16941291362994850503969493637") };
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
public class A159994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159994Inst Instance=new A159994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159995
{
public static readonly BigInteger[] Value={ 1L,27000L,46656000000L,46656000000000L,BigInteger.Parse("80621568000000000000"),BigInteger.Parse("14348907000000000000000"),BigInteger.Parse("12694994583552000000000000000000"),BigInteger.Parse("812479653347328000000000000000000") };
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
public class A159995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159995Inst Instance=new A159995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159996
{
public static readonly BigInteger[] Value={ 1L,17L,1L,-9775L,-167039L,8421137L,383695489L,-8028901423L,-910021430015L,3028224568337L,2410255364260609L,32253054435619793L,-7087387068572072831L,BigInteger.Parse("-231952136295227242735"),BigInteger.Parse("22591990867714977552769"),BigInteger.Parse("1319294858293510861104593"),BigInteger.Parse("-75169387957539018389183999") };
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
public class A159996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159996Inst Instance=new A159996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159997
{
public static readonly BigInteger[] Value={ 1L,19L,73L,-9557L,-244655L,6361219L,473166361L,-2002025573L,-991941869663L,-14234228603405L,2300662982701801L,84707175049140619L,-5679064003265633807L,BigInteger.Parse("-400650213031877021597"),BigInteger.Parse("13650061580620869563065"),BigInteger.Parse("1874772828976324672777339"),BigInteger.Parse("-23347582277731987729671359") };
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
public class A159997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159997Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159997.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159997Inst Instance=new A159997Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159998
{
public static readonly BigInteger[] Value={ 1L,23L,241L,-7705L,-385439L,11063L,555286609L,12752475143L,-826150875455L,-48383172864937L,1028570093285809L,163000649996592167L,490504894392176929L,BigInteger.Parse("-552048633817202459785"),BigInteger.Parse("-14533568902399966997231"),BigInteger.Parse("1891588006795761076916807"),BigInteger.Parse("106291541814670362197124481") };
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
public class A159998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159998Inst Instance=new A159998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159999
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,6L,5L,4L,7L,6L,7L,9L,7L,10L,7L,5L,9L,14L,11L,8L,6L,12L,9L,11L,14L,10L,10L,16L,14L,11L,10L,6L,17L,12L,9L,20L,18L,17L,18L,9L,13L,8L,20L,16L,14L,12L,13L,12L,20L,21L,18L,12L,10L,18L,15L,20L,24L,19L,22L,16L,14L,17L,15L,7L,23L,25L,22L,15L,13L,12L,16L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159999Inst : IEnumerable<long>
{
public static readonly long[] Value=A159999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159999.Bytes);
public long this[int i]=>Value[i];

public static A159999Inst Instance=new A159999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160000
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,11L,9L,10L,17L,20L,23L,66L,35L,57L,51L,36L,77L,153L,122L,126L,61L,213L,189L,883L,353L,338L,337L,851L,645L,570L,571L,202L,1220L,1066L,901L,4017L,3462L,2440L,2777L,1598L,1852L,512L,8084L,4909L,3952L,3122L,3399L,29851L,17813L,11391L,11285L,7128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160000Inst : IEnumerable<long>
{
public static readonly long[] Value=A160000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160000.Bytes);
public long this[int i]=>Value[i];

public static A160000Inst Instance=new A160000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160001
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,3L,1L,4L,3L,4L,9L,4L,8L,5L,1L,6L,18L,10L,5L,2L,13L,6L,25L,19L,10L,8L,41L,24L,14L,10L,1L,40L,19L,8L,138L,90L,55L,62L,7L,17L,3L,144L,63L,34L,16L,16L,43L,218L,148L,105L,22L,7L,39L,24L,323L,371L,150L,224L,54L,27L,40L,30L,1L,572L,444L,344L,71L,32L,19L,39L,1766L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160001Inst : IEnumerable<long>
{
public static readonly long[] Value=A160001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160001.Bytes);
public long this[int i]=>Value[i];

public static A160001Inst Instance=new A160001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160002
{
public static readonly long[] Value={ 0L,3L,10L,19L,34L,57L,88L,123L,176L,253L,342L,449L,572L,749L,980L,1261L,1560L,1903L,2328L,2889L,3562L,4377L,5276L,6251L,7392L,8779L,10488L,12469L,14832L,17497L,20228L,23377L,27082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160002Inst : IEnumerable<long>
{
public static readonly long[] Value=A160002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160002.Bytes);
public long this[int i]=>Value[i];

public static A160002Inst Instance=new A160002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160003
{
public static readonly BigInteger[] Value={ 1L,2L,-1246L,-7492L,4657516L,46775032L,-29015924936L,-408844589872L,253071654010256L,4594589206740512L,-2837866929201898976L,BigInteger.Parse("-63108098942660197952"),BigInteger.Parse("38894454078640790524096"),BigInteger.Parse("1024410392297184550328192"),BigInteger.Parse("-629986057993318476915903616"),BigInteger.Parse("-19187153981187366584575167232") };
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
public class A160003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160003Inst Instance=new A160003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160004
{
public static readonly BigInteger[] Value={ 1L,4L,-1234L,-14936L,4567756L,92951024L,-28176670904L,-809839363616L,243306512955536L,9071619687982144L,-2700911791997851424L,BigInteger.Parse("-124198893267768205696"),BigInteger.Parse("36640741566899384257216"),BigInteger.Parse("2009546365284120622468864"),BigInteger.Parse("-587373865000978511689884544"),BigInteger.Parse("-37516556852476024939964658176") };
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
public class A160004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160004Inst Instance=new A160004Inst();

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