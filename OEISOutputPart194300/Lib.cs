using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244962
{
public static readonly long[] Value={ 1L,2L,5L,7L,15L,22L,77L,176L,4565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244962Inst : IEnumerable<long>
{
public static readonly long[] Value=A244962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244962.Bytes);
public long this[int i]=>Value[i];

public static A244962Inst Instance=new A244962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244963
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,3L,1L,0L,0L,4L,0L,0L,0L,7L,0L,3L,0L,6L,0L,0L,0L,12L,1L,0L,4L,8L,0L,0L,0L,15L,0L,0L,0L,19L,0L,0L,0L,18L,0L,0L,0L,12L,6L,0L,0L,28L,1L,3L,0L,14L,0L,12L,0L,24L,0L,0L,0L,24L,0L,0L,8L,31L,0L,0L,0L,18L,0L,0L,0L,51L,0L,0L,4L,20L,0L,0L,0L,42L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244963Inst : IEnumerable<long>
{
public static readonly long[] Value=A244963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244963.Bytes);
public long this[int i]=>Value[i];

public static A244963Inst Instance=new A244963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244964
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,2L,2L,1L,3L,1L,3L,1L,3L,3L,2L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,3L,1L,4L,1L,2L,1L,2L,4L,3L,1L,2L,1L,4L,1L,3L,1L,3L,3L,2L,1L,3L,2L,3L,2L,3L,1L,2L,2L,3L,2L,2L,1L,5L,1L,2L,2L,2L,2L,3L,1L,2L,1L,6L,1L,3L,1L,2L,3L,2L,3L,3L,1L,4L,1L,2L,1L,4L,2L,2L,1L,3L,1L,4L,2L,3L,1L,2L,2L,3L,1L,3L,1L,4L,1L,3L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244964Inst : IEnumerable<long>
{
public static readonly long[] Value=A244964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244964.Bytes);
public long this[int i]=>Value[i];

public static A244964Inst Instance=new A244964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244965
{
public static readonly long[] Value={ 1L,3L,1L,3L,3L,4L,1L,5L,6L,6L,1L,7L,3L,4L,8L,1L,3L,9L,3L,5L,10L,1L,11L,10L,6L,12L,1L,13L,3L,7L,14L,1L,3L,5L,15L,3L,4L,8L,16L,1L,17L,6L,6L,9L,18L,1L,19L,3L,9L,10L,20L,1L,3L,7L,21L,3L,11L,22L,1L,23L,10L,6L,8L,12L,24L,1L,5L,25L,3L,13L,26L,1L,3L,9L,27L,3L,4L,7L,14L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244965Inst : IEnumerable<long>
{
public static readonly long[] Value=A244965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244965.Bytes);
public long this[int i]=>Value[i];

public static A244965Inst Instance=new A244965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244966
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,1L,3L,1L,0L,0L,1L,2L,1L,3L,2L,4L,0L,2L,0L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,1L,3L,1L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,0L,2L,1L,4L,2L,0L,0L,0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,1L,3L,2L,5L,4L,3L,7L,1L,3L,2L,5L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244966Inst : IEnumerable<long>
{
public static readonly long[] Value=A244966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244966.Bytes);
public long this[int i]=>Value[i];

public static A244966Inst Instance=new A244966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244967
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,1L,3L,2L,5L,2L,4L,3L,6L,1L,3L,2L,5L,4L,3L,7L,2L,4L,3L,6L,2L,5L,4L,8L,1L,3L,2L,5L,4L,3L,7L,3L,6L,5L,4L,9L,2L,4L,3L,6L,2L,5L,4L,8L,4L,3L,7L,6L,5L,10L,1L,3L,2L,5L,4L,3L,7L,3L,6L,5L,4L,9L,2L,5L,4L,8L,3L,7L,6L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244967Inst : IEnumerable<long>
{
public static readonly long[] Value=A244967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244967.Bytes);
public long this[int i]=>Value[i];

public static A244967Inst Instance=new A244967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244968
{
public static readonly long[] Value={ 1L,4L,9L,28L,54L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244968Inst : IEnumerable<long>
{
public static readonly long[] Value=A244968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244968.Bytes);
public long this[int i]=>Value[i];

public static A244968Inst Instance=new A244968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244969
{
public static readonly long[] Value={ 15L,35L,45L,63L,75L,77L,91L,99L,105L,117L,135L,143L,153L,165L,175L,187L,189L,195L,209L,221L,225L,231L,245L,247L,255L,273L,285L,297L,299L,315L,323L,325L,345L,351L,357L,375L,385L,391L,399L,405L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244969Inst : IEnumerable<long>
{
public static readonly long[] Value=A244969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244969.Bytes);
public long this[int i]=>Value[i];

public static A244969Inst Instance=new A244969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244970
{
public static readonly long[] Value={ 1L,2L,6L,7L,11L,12L,16L,17L,25L,29L,33L,34L,38L,42L,50L,51L,55L,56L,60L,61L,73L,77L,81L,82L,90L,94L,106L,107L,111L,112L,116L,117L,129L,133L,141L,142L,146L,150L,162L,163L,167L,168L,172L,176L,184L,188L,192L,193L,201L,209L,221L,225L,229L,230L,242L,243L,255L,259L,263L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244970Inst : IEnumerable<long>
{
public static readonly long[] Value=A244970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244970.Bytes);
public long this[int i]=>Value[i];

public static A244970Inst Instance=new A244970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244971
{
public static readonly long[] Value={ 1L,1L,4L,1L,4L,1L,4L,1L,8L,4L,4L,1L,4L,4L,8L,1L,4L,1L,4L,1L,12L,4L,4L,1L,8L,4L,12L,1L,4L,1L,4L,1L,12L,4L,8L,1L,4L,4L,12L,1L,4L,1L,4L,4L,8L,4L,4L,1L,8L,8L,12L,4L,4L,1L,12L,1L,12L,4L,4L,1L,4L,4L,16L,1L,12L,1L,4L,4L,12L,8L,4L,1L,4L,4L,12L,4L,8L,4L,4L,1L,16L,4L,4L,1L,12L,4L,12L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244971Inst : IEnumerable<long>
{
public static readonly long[] Value=A244971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244971.Bytes);
public long this[int i]=>Value[i];

public static A244971Inst Instance=new A244971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244972
{
public static readonly long[] Value={ 3L,9L,21L,27L,45L,81L,153L,243L,441L,495L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244972Inst : IEnumerable<long>
{
public static readonly long[] Value=A244972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244972.Bytes);
public long this[int i]=>Value[i];

public static A244972Inst Instance=new A244972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244973
{
public static readonly long[] Value={ 1L,-1L,-1L,17L,-65L,49L,881L,-5489L,12223L,42785L,-479951L,1746271L,440881L,-39651457L,212039855L,-326783183L,-2817155137L,23175692033L,-68726927071L,-128775914225L,2285692892785L,-10156877725985L,6169206210815L,196882990135745L,-1274770281690575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244973Inst : IEnumerable<long>
{
public static readonly long[] Value=A244973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244973.Bytes);
public long this[int i]=>Value[i];

public static A244973Inst Instance=new A244973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244974
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,16L,8L,15L,13L,30L,12L,45L,14L,36L,33L,31L,18L,79L,20L,66L,41L,64L,24L,103L,31L,70L,40L,80L,30L,235L,32L,63L,84L,114L,73L,198L,38L,120L,92L,163L,42L,310L,44L,140L,130L,132L,48L,246L,57L,213L,108L,154L,54L,300L,97L,217L,116L,150L,60L,600L,62L,156L,180L,127L,109L,540L,68L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244974Inst : IEnumerable<long>
{
public static readonly long[] Value=A244974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244974.Bytes);
public long this[int i]=>Value[i];

public static A244974Inst Instance=new A244974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244975
{
public static readonly long[] Value={ 0L,1L,11L,84L,598L,4199L,29409L,205882L,1441196L,10088397L,70618807L,494331680L,3460321794L,24222252595L,169555768205L,1186890377478L,8308232642392L,58157628496793L,407103399477603L,2849723796343276L,19948066574402990L,139636466020820991L,977455262145747001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244975Inst : IEnumerable<long>
{
public static readonly long[] Value=A244975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244975.Bytes);
public long this[int i]=>Value[i];

public static A244975Inst Instance=new A244975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244976
{
public static readonly long[] Value={ 2L,7L,7L,6L,8L,0L,1L,8L,3L,6L,3L,4L,8L,9L,7L,8L,9L,0L,4L,3L,8L,4L,9L,2L,5L,6L,1L,8L,7L,8L,7L,9L,3L,3L,5L,6L,1L,6L,3L,4L,1L,3L,8L,5L,5L,5L,8L,5L,9L,8L,0L,6L,3L,8L,9L,4L,2L,8L,3L,7L,2L,2L,5L,4L,3L,4L,7L,7L,7L,1L,7L,4L,5L,6L,8L,7L,1L,7L,1L,1L,9L,4L,1L,0L,9L,5L,7L,9L,3L,3L,4L,2L,2L,7L,9L,7L,8L,2L,7L,3L,3L,5L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244976Inst : IEnumerable<long>
{
public static readonly long[] Value=A244976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244976.Bytes);
public long this[int i]=>Value[i];

public static A244976Inst Instance=new A244976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244977
{
public static readonly long[] Value={ 1L,5L,1L,1L,4L,9L,9L,4L,7L,0L,1L,9L,5L,1L,8L,1L,5L,4L,2L,1L,6L,1L,7L,3L,1L,8L,8L,1L,3L,6L,8L,4L,6L,3L,1L,1L,0L,2L,3L,6L,7L,2L,1L,8L,7L,3L,4L,1L,0L,6L,1L,7L,1L,4L,6L,3L,0L,8L,2L,3L,7L,4L,4L,6L,1L,5L,6L,7L,6L,9L,3L,1L,7L,6L,0L,5L,2L,9L,4L,9L,0L,3L,0L,7L,0L,1L,0L,4L,1L,5L,6L,8L,4L,3L,3L,8L,3L,4L,7L,4L,0L,4L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244977Inst : IEnumerable<long>
{
public static readonly long[] Value=A244977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244977.Bytes);
public long this[int i]=>Value[i];

public static A244977Inst Instance=new A244977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244978
{
public static readonly long[] Value={ 0L,9L,8L,1L,7L,4L,7L,7L,0L,4L,2L,4L,6L,8L,1L,0L,3L,8L,7L,0L,1L,9L,5L,7L,6L,0L,5L,7L,2L,7L,4L,8L,4L,4L,6L,5L,1L,3L,1L,1L,6L,1L,5L,4L,3L,7L,3L,0L,4L,7L,2L,0L,5L,6L,9L,0L,5L,4L,6L,7L,0L,1L,8L,5L,0L,9L,6L,1L,9L,2L,6L,2L,6L,9L,6L,4L,4L,4L,0L,3L,1L,2L,0L,7L,1L,2L,6L,0L,8L,8L,2L,9L,1L,9L,4L,1L,1L,5L,8L,3L,7L,4L,4L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244978Inst : IEnumerable<long>
{
public static readonly long[] Value=A244978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244978.Bytes);
public long this[int i]=>Value[i];

public static A244978Inst Instance=new A244978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244979
{
public static readonly long[] Value={ 7L,0L,2L,4L,8L,1L,4L,7L,3L,1L,0L,4L,0L,7L,2L,6L,3L,9L,3L,1L,5L,6L,3L,7L,4L,6L,4L,3L,2L,0L,4L,8L,9L,4L,7L,9L,9L,4L,6L,6L,5L,0L,9L,1L,8L,7L,0L,6L,7L,2L,0L,2L,4L,1L,9L,9L,8L,9L,7L,2L,1L,0L,2L,6L,1L,9L,2L,1L,4L,1L,8L,8L,0L,6L,1L,9L,1L,8L,8L,2L,0L,5L,1L,0L,4L,1L,4L,2L,4L,1L,5L,3L,6L,5L,7L,6L,7L,2L,4L,0L,2L,1L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244979Inst : IEnumerable<long>
{
public static readonly long[] Value=A244979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244979.Bytes);
public long this[int i]=>Value[i];

public static A244979Inst Instance=new A244979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244980
{
public static readonly long[] Value={ 6L,4L,1L,2L,7L,4L,9L,1L,5L,0L,8L,0L,9L,3L,2L,0L,4L,7L,7L,7L,2L,0L,1L,8L,1L,7L,9L,8L,3L,5L,5L,0L,3L,2L,0L,5L,7L,3L,3L,6L,3L,0L,3L,3L,3L,7L,8L,2L,0L,4L,6L,1L,6L,1L,5L,5L,0L,6L,9L,4L,8L,0L,3L,3L,7L,8L,1L,9L,9L,4L,1L,1L,7L,5L,6L,5L,1L,1L,0L,5L,0L,5L,1L,6L,6L,4L,3L,4L,5L,9L,5L,2L,6L,1L,9L,7L,2L,2L,0L,3L,7L,2L,5L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244980Inst : IEnumerable<long>
{
public static readonly long[] Value=A244980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244980.Bytes);
public long this[int i]=>Value[i];

public static A244980Inst Instance=new A244980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244981
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,5L,32L,12L,9L,64L,128L,10L,18L,24L,256L,7L,48L,20L,512L,15L,1024L,36L,96L,27L,2048L,192L,72L,14L,4096L,30L,8192L,40L,25L,384L,16384L,11L,144L,80L,32768L,54L,28L,288L,768L,65536L,21L,131072L,1536L,50L,108L,60L,262144L,160L,576L,45L,524288L,1048576L,3072L,320L,81L,120L,2097152L,22L,6144L,4194304L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244981Inst : IEnumerable<long>
{
public static readonly long[] Value=A244981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244981.Bytes);
public long this[int i]=>Value[i];

public static A244981Inst Instance=new A244981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244982
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,18L,5L,11L,14L,38L,10L,79L,30L,22L,7L,164L,15L,337L,20L,47L,64L,694L,16L,35L,134L,26L,43L,1419L,32L,2888L,9L,100L,279L,73L,24L,5850L,575L,208L,34L,11822L,67L,23836L,92L,56L,1177L,47975L,19L,112L,50L,428L,193L,96431L,42L,152L,71L,877L,2395L,193614L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244982Inst : IEnumerable<long>
{
public static readonly long[] Value=A244982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244982.Bytes);
public long this[int i]=>Value[i];

public static A244982Inst Instance=new A244982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244983
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,8L,14L,13L,6L,11L,41L,23L,18L,7L,17L,38L,25L,68L,32L,28L,122L,63L,9L,20L,113L,53L,39L,365L,95L,50L,33L,74L,203L,61L,188L,88L,10L,26L,1094L,158L,83L,46L,608L,313L,3281L,338L,123L,149L,59L,43L,221L,116L,284L,72L,263L,138L,1013L,12L,9842L,29L,1823L,248L,98L,563L,172L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244983Inst : IEnumerable<long>
{
public static readonly long[] Value=A244983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244983.Bytes);
public long this[int i]=>Value[i];

public static A244983Inst Instance=new A244983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244984
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,14L,6L,23L,37L,10L,58L,8L,7L,90L,143L,15L,13L,225L,24L,355L,563L,12L,894L,17L,38L,1426L,20L,60L,2277L,3643L,19L,31L,5839L,96L,9398L,15155L,16L,27L,24518L,11L,39758L,50L,153L,64607L,42L,242L,80L,105250L,30L,171874L,281237L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244984Inst : IEnumerable<long>
{
public static readonly long[] Value=A244984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244984.Bytes);
public long this[int i]=>Value[i];

public static A244984Inst Instance=new A244984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244985
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,22L,36L,57L,89L,142L,224L,354L,562L,893L,1425L,2276L,3642L,5838L,9397L,15154L,24517L,39757L,64606L,105249L,171873L,281236L,461254L,758039L,1248269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244985Inst : IEnumerable<long>
{
public static readonly long[] Value=A244985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244985.Bytes);
public long this[int i]=>Value[i];

public static A244985Inst Instance=new A244985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244986
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,9L,14L,23L,37L,58L,90L,143L,225L,355L,563L,894L,1426L,2277L,3643L,5839L,9398L,15155L,24518L,39758L,64607L,105250L,171874L,281237L,461255L,758040L,1248270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244986Inst : IEnumerable<long>
{
public static readonly long[] Value=A244986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244986.Bytes);
public long this[int i]=>Value[i];

public static A244986Inst Instance=new A244986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244987
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,13L,8L,21L,15L,23L,16L,7L,25L,10L,12L,41L,18L,19L,64L,9L,22L,11L,49L,14L,26L,77L,39L,37L,34L,263L,105L,38L,30L,88L,70L,29L,33L,28L,133L,17L,54L,73L,126L,51L,462L,53L,60L,24L,66L,45L,74L,47L,42L,78L,94L,156L,81L,239L,48L,97L,62L,100L,20L,155L,50L,79L,98L,84L,36L,167L,141L,43L,52L,129L,164L,27L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244987Inst : IEnumerable<long>
{
public static readonly long[] Value=A244987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244987.Bytes);
public long this[int i]=>Value[i];

public static A244987Inst Instance=new A244987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244988
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,8L,8L,9L,10L,10L,11L,11L,11L,12L,12L,13L,14L,15L,16L,16L,16L,16L,16L,16L,17L,18L,19L,20L,21L,21L,21L,22L,23L,23L,23L,23L,23L,24L,25L,25L,25L,26L,27L,28L,28L,29L,30L,31L,31L,31L,32L,32L,33L,33L,34L,34L,34L,34L,34L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244988Inst : IEnumerable<long>
{
public static readonly long[] Value=A244988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244988.Bytes);
public long this[int i]=>Value[i];

public static A244988Inst Instance=new A244988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244989
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,4L,4L,5L,6L,6L,6L,6L,7L,8L,9L,9L,9L,10L,10L,11L,12L,12L,13L,13L,13L,13L,13L,14L,15L,16L,17L,18L,18L,18L,18L,18L,18L,19L,20L,20L,20L,21L,22L,23L,24L,24L,24L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,29L,29L,30L,30L,31L,31L,32L,33L,34L,35L,35L,35L,35L,36L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244989Inst : IEnumerable<long>
{
public static readonly long[] Value=A244989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244989.Bytes);
public long this[int i]=>Value[i];

public static A244989Inst Instance=new A244989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244990
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,12L,13L,14L,18L,19L,21L,24L,26L,27L,28L,29L,35L,36L,37L,38L,39L,42L,43L,48L,49L,52L,53L,54L,56L,57L,58L,61L,63L,65L,70L,71L,72L,74L,76L,78L,79L,81L,84L,86L,87L,89L,91L,95L,96L,98L,101L,104L,105L,106L,107L,108L,111L,112L,113L,114L,116L,117L,122L,126L,129L,130L,131L,133L,139L,140L,142L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244990Inst : IEnumerable<long>
{
public static readonly long[] Value=A244990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244990.Bytes);
public long this[int i]=>Value[i];

public static A244990Inst Instance=new A244990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244991
{
public static readonly long[] Value={ 2L,4L,5L,8L,10L,11L,15L,16L,17L,20L,22L,23L,25L,30L,31L,32L,33L,34L,40L,41L,44L,45L,46L,47L,50L,51L,55L,59L,60L,62L,64L,66L,67L,68L,69L,73L,75L,77L,80L,82L,83L,85L,88L,90L,92L,93L,94L,97L,99L,100L,102L,103L,109L,110L,115L,118L,119L,120L,121L,123L,124L,125L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244991Inst : IEnumerable<long>
{
public static readonly long[] Value=A244991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244991.Bytes);
public long this[int i]=>Value[i];

public static A244991Inst Instance=new A244991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244992
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244992Inst : IEnumerable<long>
{
public static readonly long[] Value=A244992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244992.Bytes);
public long this[int i]=>Value[i];

public static A244992Inst Instance=new A244992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244993
{
public static readonly long[] Value={ 0L,1L,4L,6L,2L,4L,4L,5L,3L,1L,6L,2L,6L,2L,8L,8L,0L,4L,7L,6L,0L,2L,8L,3L,6L,2L,1L,5L,5L,8L,5L,8L,1L,5L,0L,9L,5L,7L,4L,0L,2L,5L,5L,6L,0L,1L,8L,0L,2L,1L,4L,0L,7L,0L,7L,1L,9L,9L,8L,1L,0L,9L,7L,7L,5L,2L,6L,8L,9L,3L,0L,0L,9L,8L,2L,3L,4L,2L,2L,6L,0L,1L,4L,2L,4L,1L,5L,7L,1L,5L,5L,6L,0L,2L,0L,7L,2L,1L,9L,0L,8L,2L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244993Inst : IEnumerable<long>
{
public static readonly long[] Value=A244993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244993.Bytes);
public long this[int i]=>Value[i];

public static A244993Inst Instance=new A244993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244994
{
public static readonly long[] Value={ 4L,9L,4L,2L,3L,3L,7L,0L,9L,8L,8L,7L,3L,3L,2L,6L,6L,9L,1L,7L,8L,1L,8L,9L,5L,4L,4L,6L,6L,6L,4L,2L,3L,4L,2L,9L,5L,7L,4L,9L,9L,7L,0L,3L,3L,7L,3L,3L,7L,8L,2L,9L,2L,0L,3L,5L,1L,6L,1L,6L,4L,9L,7L,0L,6L,3L,5L,6L,3L,7L,5L,4L,3L,0L,4L,2L,4L,7L,3L,6L,0L,6L,4L,7L,5L,6L,2L,3L,3L,8L,4L,3L,7L,7L,0L,7L,1L,7L,8L,2L,9L,4L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244994Inst : IEnumerable<long>
{
public static readonly long[] Value=A244994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244994.Bytes);
public long this[int i]=>Value[i];

public static A244994Inst Instance=new A244994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244995
{
public static readonly long[] Value={ 3L,2L,9L,9L,3L,3L,8L,0L,1L,0L,6L,0L,0L,6L,4L,0L,5L,9L,0L,3L,9L,7L,9L,0L,6L,5L,2L,2L,8L,6L,9L,5L,2L,9L,6L,4L,6L,9L,3L,6L,8L,3L,0L,4L,8L,0L,7L,5L,8L,3L,4L,2L,7L,7L,3L,6L,0L,2L,6L,0L,3L,9L,3L,6L,2L,6L,0L,2L,7L,5L,7L,4L,2L,5L,7L,2L,6L,4L,4L,0L,5L,8L,4L,2L,3L,3L,4L,1L,5L,5L,1L,7L,2L,2L,6L,7L,4L,9L,4L,8L,8L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244995Inst : IEnumerable<long>
{
public static readonly long[] Value=A244995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244995.Bytes);
public long this[int i]=>Value[i];

public static A244995Inst Instance=new A244995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244996
{
public static readonly long[] Value={ 3L,2L,3L,0L,6L,5L,9L,4L,7L,2L,1L,9L,4L,5L,0L,5L,1L,4L,0L,9L,3L,6L,3L,6L,5L,1L,0L,7L,2L,3L,8L,0L,6L,3L,9L,4L,0L,7L,2L,2L,4L,1L,8L,4L,0L,7L,8L,0L,5L,8L,7L,0L,1L,6L,1L,3L,0L,8L,6L,8L,4L,7L,0L,3L,6L,1L,0L,1L,5L,1L,1L,2L,8L,0L,7L,2L,6L,9L,8L,4L,2L,0L,8L,3L,7L,8L,7L,6L,0L,9L,0L,8L,9L,3L,7L,1L,3L,9L,2L,0L,7L,3L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244996Inst : IEnumerable<long>
{
public static readonly long[] Value=A244996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244996.Bytes);
public long this[int i]=>Value[i];

public static A244996Inst Instance=new A244996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244997
{
public static readonly long[] Value={ 4L,2L,6L,2L,7L,8L,3L,9L,8L,8L,1L,7L,5L,0L,5L,7L,9L,0L,9L,2L,3L,5L,2L,1L,4L,2L,6L,5L,9L,6L,1L,6L,6L,8L,7L,3L,0L,5L,8L,0L,0L,6L,7L,6L,9L,6L,2L,9L,6L,3L,5L,1L,0L,7L,5L,4L,1L,6L,0L,6L,4L,5L,8L,0L,2L,6L,5L,2L,9L,4L,5L,1L,2L,2L,9L,1L,1L,6L,5L,8L,1L,4L,8L,9L,1L,2L,4L,1L,8L,8L,3L,3L,2L,2L,4L,2L,9L,4L,3L,5L,8L,5L,0L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244997Inst : IEnumerable<long>
{
public static readonly long[] Value=A244997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244997.Bytes);
public long this[int i]=>Value[i];

public static A244997Inst Instance=new A244997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244998
{
public static readonly long[] Value={ 1L,44L,870L,9480L,68290L,365936L,1573374L,5709120L,18107760L,51488800L,133748186L,321979164L,726436425L,1549758640L,3148837580L,6129352176L,11486265339L,20807609460L,36563769670L,62510325680L,104239453956L,169923049824L,271300238650L,42497294840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244998Inst : IEnumerable<long>
{
public static readonly long[] Value=A244998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244998.Bytes);
public long this[int i]=>Value[i];

public static A244998Inst Instance=new A244998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244999
{
public static readonly long[] Value={ 5L,4L,4L,4L,1L,2L,5L,6L,1L,7L,5L,2L,1L,8L,5L,5L,8L,5L,1L,9L,5L,8L,7L,8L,0L,6L,2L,7L,4L,5L,0L,2L,7L,6L,7L,6L,6L,6L,6L,0L,5L,2L,8L,0L,2L,0L,2L,8L,5L,2L,7L,4L,4L,2L,2L,8L,7L,0L,2L,8L,4L,9L,3L,9L,0L,2L,1L,4L,3L,6L,9L,1L,4L,2L,9L,2L,6L,6L,8L,3L,8L,7L,0L,5L,8L,4L,9L,2L,4L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244999Inst : IEnumerable<long>
{
public static readonly long[] Value=A244999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244999.Bytes);
public long this[int i]=>Value[i];

public static A244999Inst Instance=new A244999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245000
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,66L,596L,6620L,87000L,1324715L,22908742L,443117232L,9479624946L,222233111144L,5664313424130L,155929751451474L,4610317083986067L,145702128028870279L,4901223985261545846L,BigInteger.Parse("174836302846627038524"),BigInteger.Parse("6591979801098305644386"),BigInteger.Parse("261927409786051251544292") };
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
public class A245000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245000Inst Instance=new A245000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245001
{
public static readonly long[] Value={ 2L,3L,5L,10L,19L,41L,86L,197L,449L,1087L,2650L,6722L,17227L,45267L,120069L,323442L,877777L,2405399L,6628760L,18384040L,51204735L,143252991L,402115301L,1132464571L,3197928097L,9053803101L,25689876776L,73047889402L,208100836969L,593897902349L,1697686011406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245001Inst : IEnumerable<long>
{
public static readonly long[] Value=A245001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245001.Bytes);
public long this[int i]=>Value[i];

public static A245001Inst Instance=new A245001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245002
{
public static readonly long[] Value={ 4L,7L,14L,29L,66L,152L,374L,933L,2440L,6476L,17812L,49700L,142806L,416028L,1244052L,3769709L,11701968L,36779876L,118196856L,384069992L,1272985450L,4258319604L,14489712986L,49658295960L,172626616246L,603254904952L,2132886737604L,7568733370478L,27115881832378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245002Inst : IEnumerable<long>
{
public static readonly long[] Value=A245002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245002.Bytes);
public long this[int i]=>Value[i];

public static A245002Inst Instance=new A245002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245003
{
public static readonly long[] Value={ 10L,19L,41L,96L,232L,596L,1561L,4283L,11946L,34605L,101789L,309370L,954184L,3030085L,9758279L,32256938L,108044358L,370368959L,1285265155L,4552197618L,16308951180L,59495863566L,219423534749L,822464523053L,3115612818090L,11977083593001L,46520790003111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245003Inst : IEnumerable<long>
{
public static readonly long[] Value=A245003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245003.Bytes);
public long this[int i]=>Value[i];

public static A245003Inst Instance=new A245003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245004
{
public static readonly long[] Value={ 26L,56L,132L,327L,863L,2333L,6620L,19130L,57515L,175771L,555673L,1784015L,5899056L,19795308L,68163789L,238040835L,850372635L,3079156803L,11376375381L,42585665859L,162324759308L,626699226366L,2459686799702L,9775044096970L,39436677372291L,161037770577853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245004Inst : IEnumerable<long>
{
public static readonly long[] Value=A245004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245004.Bytes);
public long this[int i]=>Value[i];

public static A245004Inst Instance=new A245004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245005
{
public static readonly long[] Value={ 76L,176L,441L,1181L,3264L,9484L,28152L,87000L,273765L,891072L,2948867L,10045602L,34762462L,123358872L,444384780L,1636678431L,6116179699L,23312140822L,90119096883L,354665480523L,1415057313215L,5738879374046L,23584547598278L,98391428094200L,415716316206635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245005Inst : IEnumerable<long>
{
public static readonly long[] Value=A245005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245005.Bytes);
public long this[int i]=>Value[i];

public static A245005Inst Instance=new A245005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245006
{
public static readonly long[] Value={ 232L,582L,1563L,4384L,12939L,39198L,123629L,398003L,1324715L,4489759L,15653882L,55503161L,201686249L,744669554L,2809714695L,10764956657L,42053547589L,166724084605L,672761983296L,2753474296366L,11453358056417L,48292313841411L,206690703254636L,896160453214130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245006Inst : IEnumerable<long>
{
public static readonly long[] Value=A245006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245006.Bytes);
public long this[int i]=>Value[i];

public static A245006Inst Instance=new A245006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245007
{
public static readonly long[] Value={ 764L,2031L,5741L,17088L,52540L,168172L,551142L,1866639L,6448956L,22908742L,82853921L,306971909L,1156564466L,4451496217L,17407985332L,69394132575L,280851149296L,1156692921549L,4833132867603L,20521962586186L,88343703440840L,386014928037316L,1708872377386105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245007Inst : IEnumerable<long>
{
public static readonly long[] Value=A245007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245007.Bytes);
public long this[int i]=>Value[i];

public static A245007Inst Instance=new A245007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245008
{
public static readonly long[] Value={ 2620L,7408L,22088L,68576L,221715L,736624L,2528896L,8873588L,32006883L,117678413L,443117232L,1698040262L,6645905493L,26440507207L,107212883073L,441495784378L,1849869784105L,7864963647493L,33977806366991L,148834877695923L,661707905560864L,2980829993379396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245008Inst : IEnumerable<long>
{
public static readonly long[] Value=A245008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245008.Bytes);
public long this[int i]=>Value[i];

public static A245008Inst Instance=new A245008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245009
{
public static readonly BigInteger[] Value={ 1L,2L,10L,88L,978L,12200L,163156L,2286448L,33138874L,492657384L,7470940300L,115115319376L,1797128902132L,28364816229008L,451870965523368L,7256283996155360L,117333885356923274L,1908844190372949224L,BigInteger.Parse("31221135850863938268"),BigInteger.Parse("513100005743085437328"),BigInteger.Parse("8468653781083527106012"),BigInteger.Parse("140314257925457275837488") };
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
public class A245009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245009Inst Instance=new A245009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245010
{
public static readonly long[] Value={ 2L,6L,13L,57L,1614L,3686L,735417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245010Inst : IEnumerable<long>
{
public static readonly long[] Value=A245010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245010.Bytes);
public long this[int i]=>Value[i];

public static A245010Inst Instance=new A245010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245011
{
public static readonly long[] Value={ 1L,4L,6L,86L,854L,9556L,146168L,2660326L,56083228L,1349544632L,36786865968L,1117327217782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245011Inst : IEnumerable<long>
{
public static readonly long[] Value=A245011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245011.Bytes);
public long this[int i]=>Value[i];

public static A245011Inst Instance=new A245011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245012
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,16L,125L,1296L,15967L,225184L,3573369L,63006400L,1222037531L,25856693424L,592684459237L,14630486811136L,386952126342615L,10916525199478336L,327220530559545713L,10385328804324011136UL,BigInteger.Parse("347921328910693707955"),BigInteger.Parse("12269256633867840769360") };
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
public class A245012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245012Inst Instance=new A245012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245013
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,3L,1L,1L,1L,1L,5L,5L,5L,1L,1L,1L,1L,8L,11L,11L,8L,1L,1L,1L,1L,13L,21L,35L,21L,13L,1L,1L,1L,1L,21L,43L,93L,93L,43L,21L,1L,1L,1L,1L,34L,85L,269L,314L,269L,85L,34L,1L,1L,1L,1L,55L,171L,747L,1213L,1213L,747L,171L,55L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245013Inst : IEnumerable<long>
{
public static readonly long[] Value=A245013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245013.Bytes);
public long this[int i]=>Value[i];

public static A245013Inst Instance=new A245013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245014
{
public static readonly long[] Value={ 3L,47L,347L,6079L,10139L,147311L,687931L,18874111L,37748411L,104857199L,276823579L,805305791L,29662117211L,30064770287L,64424508539L,2473901161471L,11098195491707L,7421703486191L,83562883709531L,527765581330879L,369435906930971L,27866022694353007L,19421773393033147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245014Inst : IEnumerable<long>
{
public static readonly long[] Value=A245014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245014.Bytes);
public long this[int i]=>Value[i];

public static A245014Inst Instance=new A245014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245015
{
public static readonly long[] Value={ 1L,5L,14L,15L,23L,54L,56L,87L,95L,264L,270L,280L,354L,376L,406L,418L,435L,459L,478L,537L,623L,649L,667L,719L,1560L,1740L,1824L,1836L,1992L,2148L,2214L,2262L,2296L,2392L,2470L,2492L,2514L,2528L,2596L,2668L,2876L,3058L,3154L,3471L,3567L,3777L,3835L,3895L,4147L,4195L,4199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245015Inst : IEnumerable<long>
{
public static readonly long[] Value=A245015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245015.Bytes);
public long this[int i]=>Value[i];

public static A245015Inst Instance=new A245015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245016
{
public static readonly long[] Value={ 10L,1986L,6L,696L,200L,222L,6510L,1050L,630L,756L,56L,726L,798L,126L,114L,6600L,166L,62L,1422L,12034L,170L,34944L,1410L,912L,2880L,2558L,1200L,9350L,5148L,1506L,5040L,384L,2250L,1680L,114L,396L,3248L,2310L,18930L,30810L,938L,1176L,1020L,2022L,8500L,142L,1760L,1218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245016Inst : IEnumerable<long>
{
public static readonly long[] Value=A245016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245016.Bytes);
public long this[int i]=>Value[i];

public static A245016Inst Instance=new A245016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245017
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,12L,14L,16L,21L,22L,23L,25L,28L,32L,41L,44L,49L,52L,58L,61L,66L,82L,85L,94L,111L,112L,114L,116L,121L,122L,123L,125L,128L,132L,141L,144L,149L,152L,158L,161L,166L,182L,185L,194L,211L,212L,213L,215L,218L,221L,224L,229L,231L,236L,242L,245L,251L,254L,263L,279L,281L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245017Inst : IEnumerable<long>
{
public static readonly long[] Value=A245017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245017.Bytes);
public long this[int i]=>Value[i];

public static A245017Inst Instance=new A245017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245018
{
public static readonly long[] Value={ 5L,4L,5L,7L,8L,1L,8L,3L,8L,8L,3L,3L,9L,8L,7L,0L,8L,2L,5L,2L,3L,4L,9L,0L,3L,9L,7L,2L,5L,5L,6L,5L,8L,7L,7L,4L,0L,3L,3L,6L,8L,7L,9L,1L,3L,2L,9L,8L,0L,4L,3L,9L,3L,2L,7L,6L,7L,5L,9L,5L,2L,6L,2L,3L,5L,0L,6L,1L,8L,4L,4L,6L,8L,7L,4L,1L,0L,8L,4L,0L,5L,2L,5L,1L,2L,7L,0L,3L,1L,0L,6L,0L,2L,6L,1L,0L,0L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245018Inst : IEnumerable<long>
{
public static readonly long[] Value=A245018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245018.Bytes);
public long this[int i]=>Value[i];

public static A245018Inst Instance=new A245018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245019
{
public static readonly long[] Value={ 0L,2L,24L,194L,1320L,8162L,47544L,266114L,1448520L,7727522L,40616664L,211117634L,1088079720L,5571427682L,28384443384L,144041002754L,728708854920L,3677645732642L,18524892775704L,93171895169474L,468051525534120L,2349032799986402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245019Inst : IEnumerable<long>
{
public static readonly long[] Value=A245019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245019.Bytes);
public long this[int i]=>Value[i];

public static A245019Inst Instance=new A245019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245020
{
public static readonly long[] Value={ 0L,2L,30L,302L,2550L,19502L,140070L,963902L,6433590L,41983502L,269335110L,1705278302L,10686396630L,66425568302L,410223570150L,2520229093502L,15417960407670L,93999281613902L,571487645261190L,3466523088409502L,20987674370482710L,126870924446280302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245020Inst : IEnumerable<long>
{
public static readonly long[] Value=A245020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245020.Bytes);
public long this[int i]=>Value[i];

public static A245020Inst Instance=new A245020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245021
{
public static readonly long[] Value={ 10L,26L,35L,62L,134L,143L,161L,206L,215L,305L,314L,323L,341L,413L,422L,611L,1007L,1043L,1115L,1133L,1142L,1205L,1214L,1241L,1313L,1322L,1403L,1502L,2033L,2042L,2051L,2105L,2123L,2231L,2321L,2402L,2501L,3005L,3113L,3131L,3401L,4022L,4031L,4103L,4121L,5102L,5111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245021Inst : IEnumerable<long>
{
public static readonly long[] Value=A245021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245021.Bytes);
public long this[int i]=>Value[i];

public static A245021Inst Instance=new A245021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245022
{
public static readonly long[] Value={ 18L,25L,26L,27L,28L,33L,37L,38L,41L,43L,51L,53L,55L,59L,60L,62L,72L,79L,92L,95L,104L,112L,152L,240L,248L,288L,368L,416L,448L,608L,960L,992L,1152L,1472L,1664L,1792L,2432L,3840L,3968L,4608L,5888L,6656L,7168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245022Inst : IEnumerable<long>
{
public static readonly long[] Value=A245022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245022.Bytes);
public long this[int i]=>Value[i];

public static A245022Inst Instance=new A245022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245023
{
public static readonly long[] Value={ 3L,3L,9L,39L,153L,543L,1809L,5799L,18153L,55983L,171009L,519159L,1569753L,4733823L,14250609L,42850119L,128746953L,386634063L,1160688609L,3483638679L,10454061753L,31368476703L,94118013009L,282379204839L,847187946153L,2541664501743L,7625194831809L,22875987148599L,68628766752153L,205887910869183L,617666953833009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245023Inst : IEnumerable<long>
{
public static readonly long[] Value=A245023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245023.Bytes);
public long this[int i]=>Value[i];

public static A245023Inst Instance=new A245023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245024
{
public static readonly long[] Value={ 10L,16L,22L,26L,28L,34L,40L,46L,50L,52L,56L,58L,64L,70L,76L,82L,86L,88L,92L,94L,100L,106L,112L,116L,118L,124L,130L,134L,136L,142L,146L,148L,154L,160L,166L,170L,172L,176L,178L,184L,190L,196L,202L,206L,208L,214L,220L,226L,232L,236L,238L,244L,250L,254L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245024Inst : IEnumerable<long>
{
public static readonly long[] Value=A245024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245024.Bytes);
public long this[int i]=>Value[i];

public static A245024Inst Instance=new A245024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245025
{
public static readonly long[] Value={ 2L,1L,4L,2L,2L,0L,4L,4L,9L,8L,5L,2L,5L,6L,6L,3L,4L,6L,8L,0L,1L,3L,9L,1L,9L,7L,8L,4L,7L,0L,1L,9L,6L,5L,0L,2L,0L,1L,2L,0L,6L,4L,5L,8L,0L,1L,7L,9L,1L,8L,0L,0L,0L,6L,9L,1L,9L,3L,5L,5L,6L,3L,8L,0L,6L,4L,6L,4L,9L,9L,8L,8L,3L,2L,1L,7L,9L,0L,4L,8L,3L,3L,9L,9L,0L,7L,9L,2L,7L,8L,4L,0L,3L,3L,3L,5L,7L,8L,4L,2L,4L,0L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245025Inst : IEnumerable<long>
{
public static readonly long[] Value=A245025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245025.Bytes);
public long this[int i]=>Value[i];

public static A245025Inst Instance=new A245025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245026
{
public static readonly long[] Value={ 3L,4L,8L,9L,2L,5L,9L,3L,9L,1L,5L,6L,1L,9L,6L,9L,9L,0L,6L,3L,6L,7L,5L,3L,2L,1L,4L,7L,8L,6L,7L,9L,3L,5L,8L,2L,5L,3L,7L,9L,7L,2L,1L,7L,8L,2L,4L,5L,1L,5L,8L,1L,8L,4L,4L,0L,1L,9L,1L,1L,7L,4L,4L,9L,3L,7L,6L,0L,4L,0L,3L,5L,3L,3L,6L,9L,6L,4L,1L,0L,3L,1L,6L,6L,1L,9L,8L,5L,4L,6L,6L,2L,2L,1L,5L,0L,9L,7L,2L,2L,9L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245026Inst : IEnumerable<long>
{
public static readonly long[] Value=A245026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245026.Bytes);
public long this[int i]=>Value[i];

public static A245026Inst Instance=new A245026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245027
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,15L,16L,18L,19L,20L,24L,25L,26L,30L,32L,36L,38L,39L,40L,43L,45L,48L,50L,52L,57L,60L,65L,72L,75L,76L,78L,80L,86L,90L,95L,96L,100L,104L,114L,117L,120L,129L,130L,144L,150L,152L,156L,160L,171L,172L,180L,181L,190L,195L,200L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245027Inst : IEnumerable<long>
{
public static readonly long[] Value=A245027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245027.Bytes);
public long this[int i]=>Value[i];

public static A245027Inst Instance=new A245027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245028
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,24L,26L,28L,30L,35L,36L,37L,38L,39L,40L,42L,45L,48L,52L,56L,57L,60L,61L,63L,65L,70L,72L,74L,76L,78L,80L,84L,90L,91L,95L,104L,105L,111L,112L,114L,117L,120L,122L,126L,130L,133L,140L,144L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245028Inst : IEnumerable<long>
{
public static readonly long[] Value=A245028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245028.Bytes);
public long this[int i]=>Value[i];

public static A245028Inst Instance=new A245028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245029
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,13L,14L,16L,19L,20L,26L,28L,35L,37L,38L,40L,52L,56L,65L,70L,73L,74L,76L,80L,91L,95L,104L,112L,130L,133L,140L,146L,148L,152L,182L,185L,190L,208L,247L,259L,260L,266L,280L,292L,296L,304L,364L,365L,370L,380L,455L,481L,494L,511L,518L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245029Inst : IEnumerable<long>
{
public static readonly long[] Value=A245029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245029.Bytes);
public long this[int i]=>Value[i];

public static A245029Inst Instance=new A245029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245030
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,15L,16L,18L,19L,20L,24L,25L,26L,30L,32L,36L,38L,39L,40L,43L,45L,48L,50L,52L,57L,60L,64L,65L,72L,73L,75L,76L,78L,80L,86L,90L,95L,96L,100L,104L,114L,117L,120L,129L,130L,144L,146L,150L,152L,156L,160L,171L,172L,180L,181L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245030Inst : IEnumerable<long>
{
public static readonly long[] Value=A245030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245030.Bytes);
public long this[int i]=>Value[i];

public static A245030Inst Instance=new A245030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245031
{
public static readonly long[] Value={ 0L,1L,21L,120L,2080L,11781L,203841L,1154440L,19974360L,113123361L,1957283461L,11084934960L,191793804840L,1086210502741L,18793835590881L,106437544333680L,1841604094101520L,10429793134197921L,180458407386358101L,1022013289607062600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245031Inst : IEnumerable<long>
{
public static readonly long[] Value=A245031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245031.Bytes);
public long this[int i]=>Value[i];

public static A245031Inst Instance=new A245031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245032
{
public static readonly long[] Value={ 108L,175L,176L,135L,76L,23L,0L,31L,140L,351L,688L,1175L,1836L,2695L,3776L,5103L,6700L,8591L,10800L,13351L,16268L,19575L,23296L,27455L,32076L,37183L,42800L,48951L,55660L,62951L,70848L,79375L,88556L,98415L,108976L,120263L,132300L,145111L,158720L,173151L,188428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245032Inst : IEnumerable<long>
{
public static readonly long[] Value=A245032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245032.Bytes);
public long this[int i]=>Value[i];

public static A245032Inst Instance=new A245032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245033
{
public static readonly long[] Value={ 49L,320L,729L,1300L,2057L,3024L,4225L,5684L,7425L,9472L,11849L,14580L,17689L,21200L,25137L,29524L,34385L,39744L,45625L,52052L,59049L,66640L,74849L,83700L,93217L,103424L,114345L,126004L,138425L,151632L,165649L,180500L,196209L,212800L,230297L,248724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245033Inst : IEnumerable<long>
{
public static readonly long[] Value=A245033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245033.Bytes);
public long this[int i]=>Value[i];

public static A245033Inst Instance=new A245033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245034
{
public static readonly long[] Value={ 5L,21L,77L,117L,221L,285L,437L,725L,837L,1221L,1517L,1677L,2021L,2597L,3245L,3477L,4221L,4757L,5037L,5925L,6557L,7565L,9021L,9797L,10197L,11021L,11445L,12317L,15621L,16637L,18221L,18765L,21605L,22197L,24021L,25917L,27221L,29237L,31325L,32037L,35717L,36477L,38021L,38805L,43677L,48837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245034Inst : IEnumerable<long>
{
public static readonly long[] Value=A245034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245034.Bytes);
public long this[int i]=>Value[i];

public static A245034Inst Instance=new A245034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245035
{
public static readonly long[] Value={ 175L,176L,76L,0L,688L,1836L,6700L,10800L,23296L,55660L,70848L,132300L,188428L,221616L,299200L,446476L,635440L,708588L,961200L,1159168L,1267596L,1632960L,1911856L,2387020L,3134700L,3560908L,3787776L,4270000L,4525740L,5067436L,7300800L,8041648L,9244300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245035Inst : IEnumerable<long>
{
public static readonly long[] Value=A245035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245035.Bytes);
public long this[int i]=>Value[i];

public static A245035Inst Instance=new A245035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245036
{
public static readonly long[] Value={ 49L,2057L,4225L,11849L,17689L,34385L,74849L,93217L,165649L,230297L,268105L,355649L,519665L,727529L,807457L,1081849L,1295537L,1412185L,1803649L,2101145L,2606009L,3396649L,3845777L,4084465L,4591049L,4859329L,5426825L,7758049L,8529017L,9778649L,10220809L,12632369L,13156177L,14814049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245036Inst : IEnumerable<long>
{
public static readonly long[] Value=A245036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245036.Bytes);
public long this[int i]=>Value[i];

public static A245036Inst Instance=new A245036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245037
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,1L,2L,1L,2L,1L,4L,2L,3L,3L,3L,2L,7L,3L,5L,5L,6L,3L,11L,5L,10L,9L,12L,10L,21L,13L,20L,19L,26L,21L,38L,26L,38L,37L,45L,39L,66L,50L,64L,63L,77L,67L,104L,83L,110L,102L,124L,112L,166L,138L,176L,174L,204L,189L,264L,230L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245037Inst : IEnumerable<long>
{
public static readonly long[] Value=A245037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245037.Bytes);
public long this[int i]=>Value[i];

public static A245037Inst Instance=new A245037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245038
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,1L,2L,1L,2L,1L,2L,3L,3L,2L,4L,2L,3L,3L,6L,3L,6L,4L,6L,4L,6L,7L,9L,8L,9L,11L,14L,11L,19L,17L,20L,21L,25L,24L,31L,32L,36L,37L,44L,40L,52L,52L,65L,58L,70L,69L,83L,78L,93L,99L,111L,104L,126L,124L,142L,141L,177L,167L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245038Inst : IEnumerable<long>
{
public static readonly long[] Value=A245038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245038.Bytes);
public long this[int i]=>Value[i];

public static A245038Inst Instance=new A245038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245039
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,3L,3L,3L,2L,4L,2L,6L,4L,5L,4L,7L,3L,6L,4L,10L,6L,10L,7L,14L,11L,13L,12L,23L,15L,23L,20L,28L,24L,32L,26L,43L,34L,43L,39L,56L,45L,59L,55L,73L,63L,80L,70L,94L,81L,101L,92L,127L,104L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245039Inst : IEnumerable<long>
{
public static readonly long[] Value=A245039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245039.Bytes);
public long this[int i]=>Value[i];

public static A245039Inst Instance=new A245039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245040
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,3L,2L,4L,2L,3L,3L,3L,2L,7L,3L,5L,5L,6L,3L,7L,3L,6L,9L,7L,7L,12L,10L,12L,13L,14L,14L,22L,18L,22L,24L,26L,25L,35L,28L,34L,40L,42L,41L,52L,46L,55L,59L,64L,58L,81L,70L,82L,85L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245040Inst : IEnumerable<long>
{
public static readonly long[] Value=A245040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245040.Bytes);
public long this[int i]=>Value[i];

public static A245040Inst Instance=new A245040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245041
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,2L,3L,3L,3L,2L,4L,2L,3L,3L,6L,3L,6L,4L,6L,4L,6L,3L,7L,4L,9L,6L,11L,7L,13L,11L,14L,12L,17L,13L,25L,18L,24L,22L,30L,26L,35L,28L,37L,33L,49L,37L,53L,45L,56L,54L,67L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245041Inst : IEnumerable<long>
{
public static readonly long[] Value=A245041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245041.Bytes);
public long this[int i]=>Value[i];

public static A245041Inst Instance=new A245041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245042
{
public static readonly long[] Value={ 17L,73L,89L,193L,337L,521L,953L,1009L,1249L,1657L,2377L,2833L,3329L,3433L,4441L,4561L,5849L,6553L,7297L,8081L,8737L,9769L,11617L,12401L,12601L,13417L,15569L,16937L,17881L,18121L,20353L,21649L,27529L,28729L,29033L,30577L,33457L,35449L,36809L,46273L,49801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245042Inst : IEnumerable<long>
{
public static readonly long[] Value=A245042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245042.Bytes);
public long this[int i]=>Value[i];

public static A245042Inst Instance=new A245042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245043
{
public static readonly BigInteger[] Value={ 1L,3L,15L,117L,1158L,12930L,154986L,1947582L,25317009L,337610451L,4592807895L,63488144109L,889226772132L,12592147132572L,179982549300948L,2593187073716460L,37622924436008574L,549178914689660106L,8059539548880228138L,BigInteger.Parse("118846096104074358942"),BigInteger.Parse("1760035125442960123992") };
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
public class A245043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245043Inst Instance=new A245043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245044
{
public static readonly long[] Value={ 4L,6L,9L,86L,753L,7531L,9753L,97531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245044Inst : IEnumerable<long>
{
public static readonly long[] Value=A245044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245044.Bytes);
public long this[int i]=>Value[i];

public static A245044Inst Instance=new A245044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245045
{
public static readonly long[] Value={ 3L,11L,17L,43L,67L,113L,131L,193L,241L,353L,523L,641L,683L,1291L,1601L,1667L,1873L,2017L,2243L,2731L,3083L,3361L,3851L,4483L,4817L,4931L,5281L,5521L,7211L,8363L,8513L,8971L,9283L,9923L,10753L,11971L,13633L,16433L,17713L,18371L,18593L,19267L,21841L,22571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245045Inst : IEnumerable<long>
{
public static readonly long[] Value=A245045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245045.Bytes);
public long this[int i]=>Value[i];

public static A245045Inst Instance=new A245045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245046
{
public static readonly long[] Value={ 70L,70L,6L,991L,27L,183L,443L,38L,27L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245046Inst : IEnumerable<long>
{
public static readonly long[] Value=A245046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245046.Bytes);
public long this[int i]=>Value[i];

public static A245046Inst Instance=new A245046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245047
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,12L,16L,18L,24L,32L,36L,40L,48L,54L,56L,60L,64L,72L,80L,84L,88L,96L,104L,108L,128L,132L,136L,144L,152L,156L,162L,180L,184L,192L,204L,216L,225L,228L,232L,240L,248L,252L,256L,276L,288L,296L,324L,328L,344L,348L,360L,372L,376L,384L,396L,424L,432L,441L,444L,448L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245047Inst : IEnumerable<long>
{
public static readonly long[] Value=A245047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245047.Bytes);
public long this[int i]=>Value[i];

public static A245047Inst Instance=new A245047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245048
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,23L,41L,43L,47L,53L,67L,79L,83L,89L,97L,109L,131L,137L,149L,157L,163L,167L,179L,181L,193L,211L,223L,239L,241L,251L,263L,277L,281L,311L,317L,331L,379L,397L,401L,409L,421L,431L,439L,443L,449L,457L,467L,479L,541L,569L,599L,643L,647L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245048Inst : IEnumerable<long>
{
public static readonly long[] Value=A245048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245048.Bytes);
public long this[int i]=>Value[i];

public static A245048Inst Instance=new A245048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245049
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,7L,5L,1L,2L,11L,31L,8L,1L,2L,15L,81L,154L,13L,1L,2L,19L,155L,684L,820L,21L,1L,2L,23L,253L,1854L,6257L,4575L,34L,1L,2L,27L,375L,3920L,24124L,60325L,26398L,55L,1L,2L,31L,521L,7138L,66221L,331575L,603641L,156233L,89L,1L,2L,35L,691L,11764L,148348L,1183077L,4736345L,6210059L,943174L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245049Inst : IEnumerable<long>
{
public static readonly long[] Value=A245049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245049.Bytes);
public long this[int i]=>Value[i];

public static A245049Inst Instance=new A245049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245050
{
public static readonly BigInteger[] Value={ 1L,2L,27L,521L,11764L,290305L,7585749L,206294771L,5778015219L,165541098701L,4828687088591L,142916854642246L,4281359716909135L,129567073833995237L,3955263087052174005L,BigInteger.Parse("121649279851846182073"),BigInteger.Parse("3766009580469162813492"),BigInteger.Parse("117260083892211493754415") };
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
public class A245050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245050Inst Instance=new A245050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245051
{
public static readonly BigInteger[] Value={ 1L,2L,31L,691L,18054L,515892L,15615159L,492007235L,15968172965L,530169356965L,17922457144129L,614796956579459L,21346411113410148L,748762981653051898L,BigInteger.Parse("26493592534823331169"),BigInteger.Parse("944491728494004127029"),BigInteger.Parse("33892155096781949014406"),BigInteger.Parse("1223212951343094980654244") };
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
public class A245051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245051Inst Instance=new A245051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245052
{
public static readonly BigInteger[] Value={ 1L,2L,35L,885L,26264L,852909L,29347189L,1051325430L,38798085127L,1464834251301L,56313293080748L,2196846557946047L,86747889084025665L,3460614563468144968L,BigInteger.Parse("139261626165295942419"),BigInteger.Parse("5646457490910228197571"),BigInteger.Parse("230445856010164690649448"),BigInteger.Parse("9459481451214159977362615") };
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
public class A245052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245052Inst Instance=new A245052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245053
{
public static readonly BigInteger[] Value={ 1L,2L,39L,1103L,36650L,1333156L,51392991L,2062946770L,85311756697L,3609589528430L,155513170273468L,6799151325525095L,300899538364069838L,13453346159391591392UL,BigInteger.Parse("606776046327452415295"),BigInteger.Parse("27573839101542183831805"),BigInteger.Parse("1261298294289947726165466"),BigInteger.Parse("58029238642196850552991302") };
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
public class A245053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245053Inst Instance=new A245053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245054
{
public static readonly BigInteger[] Value={ 1L,2L,11L,155L,3920L,148348L,7585749L,492007235L,38798085127L,3609589528430L,387451906370509L,47166300422957938L,6423902286587614629L,BigInteger.Parse("968148639856266236900"),BigInteger.Parse("159999832729471473179245"),BigInteger.Parse("28775750341340155354161817"),BigInteger.Parse("5595702924360902427922341048") };
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
public class A245054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245054Inst Instance=new A245054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245055
{
public static readonly long[] Value={ 1L,7L,4L,2L,6L,5L,2L,3L,1L,1L,0L,3L,3L,5L,1L,5L,4L,3L,5L,2L,4L,8L,9L,0L,4L,8L,0L,6L,9L,4L,1L,2L,9L,8L,6L,4L,1L,1L,5L,4L,4L,3L,7L,9L,8L,9L,8L,3L,8L,1L,0L,4L,6L,2L,8L,1L,4L,2L,9L,0L,4L,7L,9L,5L,7L,4L,6L,5L,5L,5L,0L,3L,8L,7L,0L,0L,8L,1L,3L,5L,0L,8L,6L,8L,0L,5L,8L,1L,4L,7L,4L,1L,7L,5L,2L,4L,7L,8L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245055Inst : IEnumerable<long>
{
public static readonly long[] Value=A245055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245055.Bytes);
public long this[int i]=>Value[i];

public static A245055Inst Instance=new A245055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245056
{
public static readonly long[] Value={ 2L,109L,157L,167L,197L,211L,227L,317L,337L,349L,353L,389L,421L,439L,449L,457L,521L,541L,547L,563L,571L,587L,599L,613L,617L,647L,677L,701L,733L,757L,769L,821L,823L,827L,857L,859L,877L,881L,967L,977L,983L,991L,1097L,1153L,1163L,1187L,1217L,1231L,1237L,1249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245056Inst : IEnumerable<long>
{
public static readonly long[] Value=A245056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245056.Bytes);
public long this[int i]=>Value[i];

public static A245056Inst Instance=new A245056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245057
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,4L,7L,9L,6L,8L,11L,13L,10L,15L,12L,14L,16L,17L,19L,18L,21L,23L,20L,25L,22L,24L,26L,27L,28L,30L,29L,31L,33L,32L,35L,37L,34L,36L,39L,41L,38L,43L,40L,45L,42L,44L,46L,47L,48L,50L,49L,51L,53L,52L,55L,54L,57L,59L,56L,58L,60L,61L,63L,65L,62L,64L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245057Inst : IEnumerable<long>
{
public static readonly long[] Value=A245057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245057.Bytes);
public long this[int i]=>Value[i];

public static A245057Inst Instance=new A245057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245058
{
public static readonly long[] Value={ 2L,0L,5L,6L,1L,6L,7L,5L,8L,3L,5L,6L,0L,2L,8L,3L,0L,4L,5L,5L,9L,0L,5L,1L,8L,9L,5L,8L,3L,0L,7L,5L,3L,1L,4L,8L,6L,5L,2L,3L,6L,8L,7L,3L,7L,6L,5L,0L,8L,4L,9L,8L,0L,4L,7L,1L,6L,9L,4L,4L,7L,7L,8L,6L,7L,1L,2L,5L,0L,9L,3L,3L,8L,0L,0L,4L,0L,0L,1L,0L,9L,2L,2L,9L,2L,0L,3L,6L,1L,2L,5L,7L,7L,4L,6L,9L,8L,3L,8L,1L,6L,3L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245058Inst : IEnumerable<long>
{
public static readonly long[] Value=A245058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245058.Bytes);
public long this[int i]=>Value[i];

public static A245058Inst Instance=new A245058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245059
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,129L,1177L,12463L,149053L,1975473L,28628865L,449059179L,7562334793L,135837896769L,2588529249737L,52093016105575L,1102851978691749L,24480094135644513L,568066476383361793L,13745454515733689427UL,BigInteger.Parse("346020796943921077057"),BigInteger.Parse("9043636093339718229697"),BigInteger.Parse("244954584886648170627641") };
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
public class A245059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245059Inst Instance=new A245059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245060
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,271L,3172L,43174L,666577L,11445214L,215478712L,4401799930L,96757165012L,2273105615356L,56755763435503L,1499039156935948L,41714498328290992L,1218787798107634291L,BigInteger.Parse("37275555462806318512"),BigInteger.Parse("1190200470204107432854"),BigInteger.Parse("39581409916012393962280"),BigInteger.Parse("1368112674516484881342244") };
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
public class A245060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245060Inst Instance=new A245060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245061
{
public static readonly long[] Value={ 2L,3L,37L,541L,647L,881L,1151L,1301L,1627L,2377L,3271L,5179L,5641L,10501L,11597L,11821L,18503L,20543L,23339L,31259L,35461L,38669L,39499L,42901L,43331L,44201L,45523L,51973L,53407L,67213L,67757L,70489L,72169L,77291L,98893L,99551L,128291L,139721L,145207L,150011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245061Inst : IEnumerable<long>
{
public static readonly long[] Value=A245061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245061.Bytes);
public long this[int i]=>Value[i];

public static A245061Inst Instance=new A245061Inst();

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