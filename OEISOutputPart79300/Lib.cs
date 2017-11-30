using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A099979
{
public static readonly long[] Value={ 5L,21L,50L,85L,130L,210L,250L,341L,455L,546L,610L,850L,850L,1050L,1300L,1365L,1450L,1911L,1810L,2210L,2500L,2562L,2650L,3410L,3255L,3570L,4100L,4250L,4210L,5460L,4810L,5461L,6100L,6090L,6500L,7735L,6850L,7602L,8500L,8866L,8410L,10500L,9250L,10370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099979Inst : IEnumerable<long>
{
public static readonly long[] Value=A099979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099979.Bytes);
public long this[int i]=>Value[i];

public static A099979Inst Instance=new A099979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099980
{
public static readonly long[] Value={ 4L,9L,14L,21L,25L,33L,35L,39L,49L,55L,58L,65L,74L,82L,86L,91L,94L,106L,115L,119L,122L,129L,134L,142L,145L,155L,159L,166L,177L,183L,187L,201L,203L,206L,213L,215L,218L,221L,235L,247L,253L,259L,265L,274L,287L,291L,298L,301L,303L,309L,319L,323L,327L,334L,339L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099980Inst : IEnumerable<long>
{
public static readonly long[] Value=A099980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099980.Bytes);
public long this[int i]=>Value[i];

public static A099980Inst Instance=new A099980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099981
{
public static readonly long[] Value={ 6L,10L,15L,22L,26L,34L,38L,46L,51L,57L,62L,69L,77L,85L,87L,93L,95L,111L,118L,121L,123L,133L,141L,143L,146L,158L,161L,169L,178L,185L,194L,202L,205L,209L,214L,217L,219L,226L,237L,249L,254L,262L,267L,278L,289L,295L,299L,302L,305L,314L,321L,326L,329L,335L,341L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099981Inst : IEnumerable<long>
{
public static readonly long[] Value=A099981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099981.Bytes);
public long this[int i]=>Value[i];

public static A099981Inst Instance=new A099981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099982
{
public static readonly long[] Value={ 2L,5L,13L,19L,61L,107L,521L,1279L,2281L,4253L,9689L,11213L,21701L,44497L,110503L,216091L,859433L,1398269L,3021377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099982Inst : IEnumerable<long>
{
public static readonly long[] Value=A099982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099982.Bytes);
public long this[int i]=>Value[i];

public static A099982Inst Instance=new A099982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099983
{
public static readonly long[] Value={ 3L,7L,17L,31L,89L,127L,607L,2203L,3217L,4423L,9941L,19937L,23209L,86243L,132049L,756839L,1257787L,2976221L,6972593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099983Inst : IEnumerable<long>
{
public static readonly long[] Value=A099983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099983.Bytes);
public long this[int i]=>Value[i];

public static A099983Inst Instance=new A099983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099984
{
public static readonly long[] Value={ 1L,3L,5L,7L,3L,11L,13L,15L,17L,19L,21L,23L,5L,3L,29L,31L,33L,35L,37L,39L,41L,43L,15L,47L,7L,51L,53L,55L,57L,59L,61L,21L,65L,67L,69L,71L,73L,15L,77L,79L,3L,83L,85L,87L,89L,91L,93L,95L,97L,33L,101L,103L,105L,107L,109L,111L,113L,115L,39L,119L,11L,123L,5L,127L,129L,131L,133L,15L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099984Inst : IEnumerable<long>
{
public static readonly long[] Value=A099984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099984.Bytes);
public long this[int i]=>Value[i];

public static A099984Inst Instance=new A099984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099985
{
public static readonly long[] Value={ 2L,2L,6L,2L,10L,6L,14L,2L,6L,10L,22L,6L,26L,14L,30L,2L,34L,6L,38L,10L,42L,22L,46L,6L,10L,26L,6L,14L,58L,30L,62L,2L,66L,34L,70L,6L,74L,38L,78L,10L,82L,42L,86L,22L,30L,46L,94L,6L,14L,10L,102L,26L,106L,6L,110L,14L,114L,58L,118L,30L,122L,62L,42L,2L,130L,66L,134L,34L,138L,70L,142L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099985Inst : IEnumerable<long>
{
public static readonly long[] Value=A099985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099985.Bytes);
public long this[int i]=>Value[i];

public static A099985Inst Instance=new A099985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099986
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,4L,9L,4L,2L,5L,6L,2L,7L,7L,3L,2L,6L,4L,7L,5L,2L,7L,9L,6L,9L,5L,5L,4L,6L,9L,7L,2L,7L,4L,7L,6L,0L,5L,5L,7L,9L,5L,1L,8L,1L,8L,2L,1L,6L,2L,4L,7L,6L,3L,1L,3L,0L,3L,5L,9L,1L,1L,4L,3L,9L,6L,9L,4L,5L,2L,0L,3L,4L,9L,2L,0L,9L,6L,0L,3L,1L,2L,2L,6L,7L,4L,4L,0L,6L,2L,3L,2L,8L,0L,5L,1L,5L,5L,0L,9L,1L,5L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099986Inst : IEnumerable<long>
{
public static readonly long[] Value=A099986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099986.Bytes);
public long this[int i]=>Value[i];

public static A099986Inst Instance=new A099986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099987
{
public static readonly long[] Value={ 7L,8L,8L,8L,8L,5L,0L,5L,3L,3L,0L,8L,4L,1L,5L,6L,2L,9L,7L,7L,4L,0L,3L,9L,9L,9L,7L,9L,6L,6L,6L,7L,2L,0L,6L,3L,3L,3L,4L,5L,4L,7L,3L,2L,7L,5L,5L,6L,4L,7L,2L,4L,6L,9L,9L,2L,0L,0L,9L,2L,8L,7L,1L,5L,6L,2L,0L,3L,7L,9L,0L,3L,2L,5L,6L,5L,5L,3L,7L,8L,3L,3L,8L,2L,9L,3L,9L,7L,3L,3L,8L,9L,8L,7L,3L,9L,2L,1L,1L,0L,1L,7L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099987Inst : IEnumerable<long>
{
public static readonly long[] Value=A099987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099987.Bytes);
public long this[int i]=>Value[i];

public static A099987Inst Instance=new A099987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099988
{
public static readonly long[] Value={ 1L,7L,13L,21L,31L,37L,49L,63L,69L,75L,87L,99L,111L,127L,133L,141L,159L,169L,189L,195L,205L,219L,231L,237L,259L,267L,283L,289L,303L,319L,327L,339L,357L,367L,391L,399L,415L,427L,433L,463L,477L,487L,495L,517L,529L,537L,553L,577L,583L,601L,615L,621L,639L,645L,655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099988Inst : IEnumerable<long>
{
public static readonly long[] Value=A099988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099988.Bytes);
public long this[int i]=>Value[i];

public static A099988Inst Instance=new A099988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099989
{
public static readonly long[] Value={ 3L,9L,15L,25L,33L,43L,51L,67L,73L,79L,93L,105L,115L,129L,135L,151L,163L,171L,193L,201L,211L,223L,235L,241L,261L,273L,285L,297L,307L,321L,331L,349L,361L,385L,393L,409L,421L,429L,451L,475L,483L,489L,511L,519L,535L,541L,559L,579L,591L,613L,619L,631L,643L,651L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099989Inst : IEnumerable<long>
{
public static readonly long[] Value=A099989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099989.Bytes);
public long this[int i]=>Value[i];

public static A099989Inst Instance=new A099989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099990
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,0L,-1L,-1L,1L,-1L,-1L,1L,-1L,0L,0L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,0L,1L,-1L,1L,-1L,-1L,0L,1L,-1L,0L,-1L,1L,1L,-1L,1L,1L,1L,-1L,0L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,0L,1L,0L,1L,0L,-1L,1L,-1L,1L,0L,-1L,-1L,1L,1L,1L,0L,-1L,-1L,0L,1L,-1L,1L,1L,-1L,-1L,-1L,0L,0L,-1L,0L,1L,-1L,-1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099990Inst : IEnumerable<long>
{
public static readonly long[] Value=A099990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099990.Bytes);
public long this[int i]=>Value[i];

public static A099990Inst Instance=new A099990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099991
{
public static readonly long[] Value={ -1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,-1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099991Inst : IEnumerable<long>
{
public static readonly long[] Value=A099991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099991.Bytes);
public long this[int i]=>Value[i];

public static A099991Inst Instance=new A099991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099992
{
public static readonly long[] Value={ 1L,4L,8L,16L,30L,36L,60L,72L,120L,144L,192L,216L,256L,360L,420L,480L,576L,768L,864L,960L,1080L,1260L,1440L,1680L,1800L,2048L,2304L,2520L,2880L,3360L,3600L,4096L,4608L,5040L,5400L,6144L,6480L,6912L,7560L,7776L,8640L,9240L,10368L,11520L,12600L,13440L,13860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099992Inst : IEnumerable<long>
{
public static readonly long[] Value=A099992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099992.Bytes);
public long this[int i]=>Value[i];

public static A099992Inst Instance=new A099992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099993
{
public static readonly long[] Value={ 2L,6L,12L,24L,32L,48L,64L,96L,128L,180L,210L,240L,288L,384L,432L,512L,720L,840L,900L,1024L,1152L,1296L,1536L,1728L,1920L,2160L,2310L,2592L,3072L,3456L,3840L,4320L,4620L,5184L,5760L,6300L,6720L,7200L,7680L,8192L,9216L,10080L,10800L,12288L,12960L,13824L,14400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099993Inst : IEnumerable<long>
{
public static readonly long[] Value=A099993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099993.Bytes);
public long this[int i]=>Value[i];

public static A099993Inst Instance=new A099993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099994
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,11L,33L,55L,77L,99L,111L,131L,151L,171L,191L,212L,232L,252L,272L,292L,313L,333L,353L,373L,393L,414L,434L,454L,474L,494L,515L,535L,555L,575L,595L,616L,636L,656L,676L,696L,717L,737L,757L,777L,797L,818L,838L,858L,878L,898L,919L,939L,959L,979L,999L,1111L,1331L,1551L,1771L,1991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099994Inst : IEnumerable<long>
{
public static readonly long[] Value=A099994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099994.Bytes);
public long this[int i]=>Value[i];

public static A099994Inst Instance=new A099994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099995
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,22L,44L,66L,88L,101L,121L,141L,161L,181L,202L,222L,242L,262L,282L,303L,323L,343L,363L,383L,404L,424L,444L,464L,484L,505L,525L,545L,565L,585L,606L,626L,646L,666L,686L,707L,727L,747L,767L,787L,808L,828L,848L,868L,888L,909L,929L,949L,969L,989L,1001L,1221L,1441L,1661L,1881L,2002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099995Inst : IEnumerable<long>
{
public static readonly long[] Value=A099995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099995.Bytes);
public long this[int i]=>Value[i];

public static A099995Inst Instance=new A099995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099996
{
public static readonly long[] Value={ 1L,2L,12L,60L,840L,2520L,27720L,360360L,720720L,12252240L,232792560L,232792560L,5354228880L,26771144400L,80313433200L,2329089562800L,144403552893600L,144403552893600L,144403552893600L,5342931457063200L,5342931457063200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099996Inst : IEnumerable<long>
{
public static readonly long[] Value=A099996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099996.Bytes);
public long this[int i]=>Value[i];

public static A099996Inst Instance=new A099996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099997
{
public static readonly long[] Value={ 1L,8L,16L,27L,36L,64L,100L,125L,144L,196L,225L,256L,324L,361L,441L,512L,576L,676L,784L,900L,1000L,1089L,1225L,1331L,1444L,1600L,1728L,1849L,2025L,2116L,2197L,2304L,2500L,2704L,2809L,3025L,3136L,3364L,3481L,3721L,3969L,4225L,4489L,4761L,4913L,5184L,5476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099997Inst : IEnumerable<long>
{
public static readonly long[] Value=A099997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099997.Bytes);
public long this[int i]=>Value[i];

public static A099997Inst Instance=new A099997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099998
{
public static readonly long[] Value={ 4L,9L,25L,32L,49L,81L,121L,128L,169L,216L,243L,289L,343L,400L,484L,529L,625L,729L,841L,961L,1024L,1156L,1296L,1369L,1521L,1681L,1764L,1936L,2048L,2187L,2209L,2401L,2601L,2744L,2916L,3125L,3249L,3375L,3600L,3844L,4096L,4356L,4624L,4900L,5041L,5329L,5625L,5832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099998Inst : IEnumerable<long>
{
public static readonly long[] Value=A099998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099998.Bytes);
public long this[int i]=>Value[i];

public static A099998Inst Instance=new A099998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099999
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,3L,9L,31L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099999Inst : IEnumerable<long>
{
public static readonly long[] Value=A099999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099999.Bytes);
public long this[int i]=>Value[i];

public static A099999Inst Instance=new A099999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100000
{
public static readonly long[] Value={ 3L,6L,4L,8L,10L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100000Inst : IEnumerable<long>
{
public static readonly long[] Value=A100000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100000.Bytes);
public long this[int i]=>Value[i];

public static A100000Inst Instance=new A100000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100001
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,3L,10L,25L,95L,366L,1433L,5802L,24105L,102479L,445577L,1992044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100001Inst : IEnumerable<long>
{
public static readonly long[] Value=A100001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100001.Bytes);
public long this[int i]=>Value[i];

public static A100001Inst Instance=new A100001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100002
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,3L,1L,2L,4L,4L,3L,4L,1L,2L,5L,5L,3L,5L,1L,2L,4L,5L,3L,4L,6L,6L,1L,2L,6L,3L,7L,7L,6L,4L,7L,7L,5L,6L,1L,2L,5L,3L,8L,8L,7L,4L,8L,8L,1L,2L,6L,7L,3L,6L,5L,8L,4L,8L,5L,6L,9L,9L,1L,2L,9L,3L,10L,10L,9L,4L,10L,10L,7L,8L,9L,5L,7L,10L,1L,2L,9L,7L,3L,4L,9L,6L,11L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100002Inst : IEnumerable<long>
{
public static readonly long[] Value=A100002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100002.Bytes);
public long this[int i]=>Value[i];

public static A100002Inst Instance=new A100002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100003
{
public static readonly long[] Value={ 3L,5L,17L,89L,383L,8831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100003Inst : IEnumerable<long>
{
public static readonly long[] Value=A100003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100003.Bytes);
public long this[int i]=>Value[i];

public static A100003Inst Instance=new A100003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100004
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,1260230400L,0L,211691822284800L,167823813692620800L,BigInteger.Parse("478913396715566841600"),BigInteger.Parse("800774658647826785894400"),BigInteger.Parse("611331534352048834410577920"),BigInteger.Parse("247750040775246869910100377600"),BigInteger.Parse("59524143410351572596837132825600"),BigInteger.Parse("9219467698757233237143045380505600"),BigInteger.Parse("982518868151763901368740969501491200") };
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
public class A100004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100004Inst Instance=new A100004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100005
{
public static readonly long[] Value={ 0L,3L,5L,7L,6L,11L,13L,8L,17L,19L,10L,23L,10L,9L,29L,31L,14L,12L,37L,16L,41L,43L,11L,47L,14L,20L,53L,16L,22L,59L,61L,13L,18L,67L,26L,71L,73L,13L,18L,79L,12L,83L,22L,32L,89L,20L,34L,24L,97L,17L,101L,103L,15L,107L,109L,40L,113L,28L,19L,24L,22L,44L,15L,127L,46L,131L,26L,14L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100005Inst : IEnumerable<long>
{
public static readonly long[] Value=A100005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100005.Bytes);
public long this[int i]=>Value[i];

public static A100005Inst Instance=new A100005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100006
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,7L,9L,8L,8L,9L,13L,9L,15L,11L,10L,10L,19L,10L,21L,11L,12L,15L,25L,11L,12L,17L,11L,13L,31L,12L,33L,12L,16L,21L,14L,12L,39L,23L,18L,13L,43L,14L,45L,17L,13L,27L,49L,13L,16L,14L,22L,19L,55L,13L,18L,15L,24L,33L,61L,14L,63L,35L,15L,14L,20L,18L,69L,23L,28L,16L,73L,14L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100006Inst : IEnumerable<long>
{
public static readonly long[] Value=A100006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100006.Bytes);
public long this[int i]=>Value[i];

public static A100006Inst Instance=new A100006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100007
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,4L,2L,2L,4L,2L,2L,2L,2L,2L,4L,4L,2L,4L,2L,2L,4L,2L,2L,4L,2L,4L,4L,2L,2L,4L,4L,2L,4L,2L,2L,4L,4L,2L,2L,2L,4L,4L,2L,4L,4L,4L,2L,4L,2L,2L,8L,2L,2L,4L,2L,4L,4L,4L,2L,4L,2L,2L,4L,2L,4L,4L,2L,2L,4L,4L,4L,4L,2L,2L,4L,4L,2L,4L,4L,2L,8L,2L,2L,4L,2L,4L,4L,2L,2L,4L,4L,4L,4L,2L,2L,8L,2L,2L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100007Inst : IEnumerable<long>
{
public static readonly long[] Value=A100007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100007.Bytes);
public long this[int i]=>Value[i];

public static A100007Inst Instance=new A100007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100008
{
public static readonly long[] Value={ 2L,2L,4L,2L,4L,4L,4L,2L,4L,4L,4L,4L,4L,4L,8L,2L,4L,4L,4L,4L,8L,4L,4L,4L,4L,4L,4L,4L,4L,8L,4L,2L,8L,4L,8L,4L,4L,4L,8L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,4L,8L,4L,4L,4L,8L,4L,8L,4L,4L,8L,4L,4L,8L,2L,8L,8L,4L,4L,8L,8L,4L,4L,4L,4L,8L,4L,8L,8L,4L,4L,4L,4L,4L,8L,8L,4L,8L,4L,4L,8L,8L,4L,8L,4L,8L,4L,4L,4L,8L,4L,4L,8L,4L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100008Inst : IEnumerable<long>
{
public static readonly long[] Value=A100008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100008.Bytes);
public long this[int i]=>Value[i];

public static A100008Inst Instance=new A100008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100009
{
public static readonly BigInteger[] Value={ 2L,5L,70L,1088430L,BigInteger.Parse("58478088289964410654020") };
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
public class A100009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100009Inst Instance=new A100009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100010
{
public static readonly BigInteger[] Value={ 2L,24L,941184L,BigInteger.Parse("2354066797535483525627904") };
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
public class A100010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100010Inst Instance=new A100010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100011
{
public static readonly BigInteger[] Value={ 2L,600L,16858418928600L,BigInteger.Parse("10540904502382779165253193559218987587063928137089696600") };
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
public class A100011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100011Inst Instance=new A100011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100012
{
public static readonly BigInteger[] Value={ 2L,120L,4930988840L,BigInteger.Parse("14287387711051307292599794275187472361080") };
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
public class A100012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100012Inst Instance=new A100012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100013
{
public static readonly long[] Value={ 3L,3L,2L,1L,1L,1L,1L,3L,3L,3L,3L,2L,3L,3L,4L,2L,2L,3L,3L,5L,5L,5L,3L,4L,3L,2L,4L,5L,5L,4L,7L,6L,4L,4L,7L,2L,5L,4L,7L,4L,5L,3L,4L,6L,5L,4L,3L,3L,5L,6L,3L,5L,6L,3L,3L,7L,4L,5L,5L,2L,4L,4L,5L,4L,2L,4L,3L,5L,2L,5L,7L,4L,7L,5L,5L,3L,5L,4L,6L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100013Inst : IEnumerable<long>
{
public static readonly long[] Value=A100013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100013.Bytes);
public long this[int i]=>Value[i];

public static A100013Inst Instance=new A100013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100014
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,3L,5L,12L,3L,5L,8L,6L,5L,3L,18L,8L,41L,5L,11L,14L,66L,8L,2L,9L,18L,8L,21L,12L,30L,16L,6L,1L,6L,8L,33L,2L,53L,23L,2L,5L,21L,15L,6L,12L,20L,5L,5L,28L,53L,80L,11L,53L,9L,5L,56L,2L,120L,5L,23L,16L,9L,8L,5L,9L,24L,25L,62L,131L,41L,51L,12L,3L,99L,56L,2L,37L,155L,3L,23L,55L,29L,9L,2L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100014Inst : IEnumerable<long>
{
public static readonly long[] Value=A100014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100014.Bytes);
public long this[int i]=>Value[i];

public static A100014Inst Instance=new A100014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100015
{
public static readonly long[] Value={ 2L,3L,43L,481066515733L,130850092279663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100015Inst : IEnumerable<long>
{
public static readonly long[] Value=A100015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100015.Bytes);
public long this[int i]=>Value[i];

public static A100015Inst Instance=new A100015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100016
{
public static readonly BigInteger[] Value={ 1L,2L,6L,42L,1806L,3270666L,10697259354222L,BigInteger.Parse("114431357691543566765996394"),BigInteger.Parse("13094535623129987017538646614449662873664453962869814"),BigInteger.Parse("171466863185420237392391564368967506501628543653753176958938044126997508808439363294403869833497610468982") };
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
public class A100016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100016Inst Instance=new A100016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100017
{
public static readonly long[] Value={ 32L,69L,97L,110L,130L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100017Inst : IEnumerable<long>
{
public static readonly long[] Value=A100017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100017.Bytes);
public long this[int i]=>Value[i];

public static A100017Inst Instance=new A100017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100018
{
public static readonly long[] Value={ 2L,1L,48L,1L,30L,25L,33L,12L,30L,6L,117L,22L,471L,119L,255L,98L,180L,29L,153L,48L,399L,135L,267L,20L,426L,320L,213L,391L,714L,216L,1395L,148L,915L,65L,2703L,65L,525L,364L,573L,173L,240L,1239L,657L,205L,135L,30L,1080L,82L,1056L,604L,3102L,148L,279L,661L,1962L,435L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100018Inst : IEnumerable<long>
{
public static readonly long[] Value=A100018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100018.Bytes);
public long this[int i]=>Value[i];

public static A100018Inst Instance=new A100018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100019
{
public static readonly long[] Value={ 0L,3L,28L,117L,336L,775L,1548L,2793L,4672L,7371L,11100L,16093L,22608L,30927L,41356L,54225L,69888L,88723L,111132L,137541L,168400L,204183L,245388L,292537L,346176L,406875L,475228L,551853L,637392L,732511L,837900L,954273L,1082368L,1222947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100019Inst : IEnumerable<long>
{
public static readonly long[] Value=A100019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100019.Bytes);
public long this[int i]=>Value[i];

public static A100019Inst Instance=new A100019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100020
{
public static readonly long[] Value={ 2L,7L,11L,2L,11L,5L,3L,7L,2L,3L,5L,11L,3L,5L,7L,2L,2L,7L,3L,11L,5L,3L,7L,5L,2L,5L,11L,3L,5L,7L,3L,7L,2L,3L,13L,2L,3L,11L,5L,3L,2L,11L,3L,5L,11L,3L,11L,11L,2L,7L,5L,3L,7L,5L,3L,5L,2L,3L,5L,7L,3L,13L,3L,2L,2L,5L,3L,2L,5L,3L,5L,7L,2L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100020Inst : IEnumerable<long>
{
public static readonly long[] Value=A100020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100020.Bytes);
public long this[int i]=>Value[i];

public static A100020Inst Instance=new A100020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100021
{
public static readonly long[] Value={ 0L,1L,5L,7L,17L,19L,29L,31L,37L,53L,53L,67L,77L,79L,85L,97L,113L,113L,127L,137L,137L,151L,157L,167L,187L,197L,199L,209L,211L,209L,247L,253L,269L,265L,293L,293L,305L,319L,325L,337L,353L,349L,377L,379L,389L,383L,407L,439L,449L,451L,457L,473L,469L,493L,505L,517L,533L,533L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100021Inst : IEnumerable<long>
{
public static readonly long[] Value=A100021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100021.Bytes);
public long this[int i]=>Value[i];

public static A100021Inst Instance=new A100021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100022
{
public static readonly long[] Value={ 1L,4L,29L,205L,1412L,9688L,66416L,455237L,3120256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100022Inst : IEnumerable<long>
{
public static readonly long[] Value=A100022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100022.Bytes);
public long this[int i]=>Value[i];

public static A100022Inst Instance=new A100022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100023
{
public static readonly long[] Value={ 1L,2L,33L,415L,5198L,49274L,362191L,2127283L,10415371L,43855201L,162942160L,544750425L,1664602301L,4706957039L,12441105905L,30990626912L,73251661498L,165232613947L,357406368959L,744394713024L,1498152895495L,2922476743386L,5540491429760L,10232097731194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100023Inst : IEnumerable<long>
{
public static readonly long[] Value=A100023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100023.Bytes);
public long this[int i]=>Value[i];

public static A100023Inst Instance=new A100023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100024
{
public static readonly long[] Value={ 1L,7L,46L,237L,1056L,4071L,13986L,43461L,124146L,329681L,822074L,1939691L,4359264L,9381561L,19422294L,38828715L,75208515L,141537930L,259444020L,464210670L,812292096L,1392398634L,2341628076L,3868602654L,6286255716L,10057721934L,15859890444L,24670480954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100024Inst : IEnumerable<long>
{
public static readonly long[] Value=A100024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100024.Bytes);
public long this[int i]=>Value[i];

public static A100024Inst Instance=new A100024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100025
{
public static readonly long[] Value={ 1L,1L,7L,21L,92L,291L,981L,2871L,8134L,21131L,52481L,122759L,275356L,590289L,1220811L,2436045L,4715827L,8866230L,16246890L,29054190L,50830264L,87104226L,146467614L,241934106L,393098860L,628867434L,991602894L,1542350194L,2368492984L,3593354974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100025Inst : IEnumerable<long>
{
public static readonly long[] Value=A100025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100025.Bytes);
public long this[int i]=>Value[i];

public static A100025Inst Instance=new A100025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100026
{
public static readonly long[] Value={ 0L,3L,3L,3L,5L,8L,323L,5L,8L,212L,3L,161L,8L,3L,242L,3L,8L,10901L,737L,161L,242L,333L,282L,6L,252L,474L,5L,12921L,8L,131L,18381L,6L,444L,6L,797L,606L,717L,15351L,464L,333L,626L,545L,13031L,161L,747L,191L,323L,636L,32523L,303L,282L,888L,686L,18981L,111L,15951L,12021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100026Inst : IEnumerable<long>
{
public static readonly long[] Value=A100026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100026.Bytes);
public long this[int i]=>Value[i];

public static A100026Inst Instance=new A100026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100027
{
public static readonly BigInteger[] Value={ 101L,10301L,1003001L,100030001L,10000500001L,1000008000001L,100000323000001L,10000000500000001L,1000000008000000001L,BigInteger.Parse("100000000212000000001"),BigInteger.Parse("10000000000300000000001"),BigInteger.Parse("1000000000016100000000001"),BigInteger.Parse("100000000000080000000000001"),BigInteger.Parse("10000000000000300000000000001"),BigInteger.Parse("1000000000000024200000000000001") };
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
public class A100027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100027Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100027.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100027Inst Instance=new A100027Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100028
{
public static readonly long[] Value={ 3L,5L,7L,9L,23L,29L,33L,185L,267L,307L,757L,897L,1571L,2977L,3831L,4595L,6573L,9511L,11651L,15641L,68885L,69883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100028Inst : IEnumerable<long>
{
public static readonly long[] Value=A100028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100028.Bytes);
public long this[int i]=>Value[i];

public static A100028Inst Instance=new A100028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100029
{
public static readonly long[] Value={ 0L,3L,5L,7L,3L,11L,13L,8L,17L,19L,10L,23L,5L,3L,29L,31L,14L,12L,37L,16L,41L,43L,8L,47L,7L,20L,53L,16L,22L,59L,61L,10L,18L,67L,26L,71L,73L,8L,18L,79L,3L,83L,22L,32L,89L,20L,34L,24L,97L,14L,101L,103L,15L,107L,109L,40L,113L,28L,16L,24L,11L,44L,5L,127L,46L,131L,26L,8L,137L,139L,50L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100029Inst : IEnumerable<long>
{
public static readonly long[] Value=A100029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100029.Bytes);
public long this[int i]=>Value[i];

public static A100029Inst Instance=new A100029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100030
{
public static readonly long[] Value={ 2L,2L,5L,2L,7L,5L,9L,2L,5L,7L,13L,5L,15L,9L,10L,2L,19L,5L,21L,7L,12L,13L,25L,5L,7L,15L,5L,9L,31L,10L,33L,2L,16L,19L,14L,5L,39L,21L,18L,7L,43L,12L,45L,13L,10L,25L,49L,5L,9L,7L,22L,15L,55L,5L,18L,9L,24L,31L,61L,10L,63L,33L,12L,2L,20L,16L,69L,19L,28L,14L,73L,5L,75L,39L,10L,21L,20L,18L,81L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100030Inst : IEnumerable<long>
{
public static readonly long[] Value=A100030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100030.Bytes);
public long this[int i]=>Value[i];

public static A100030Inst Instance=new A100030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100031
{
public static readonly long[] Value={ 2L,5L,23L,41L,83L,113L,173L,191L,239L,281L,359L,431L,491L,593L,653L,683L,743L,809L,953L,1019L,1049L,1223L,1289L,1439L,1481L,1511L,1583L,1733L,1889L,1931L,2003L,2063L,2129L,2273L,2351L,2399L,2543L,2693L,2741L,2819L,2939L,2969L,3299L,3359L,3413L,3491L,3593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100031Inst : IEnumerable<long>
{
public static readonly long[] Value=A100031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100031.Bytes);
public long this[int i]=>Value[i];

public static A100031Inst Instance=new A100031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100032
{
public static readonly long[] Value={ 3L,11L,29L,53L,89L,131L,179L,233L,251L,293L,419L,443L,509L,641L,659L,719L,761L,911L,1013L,1031L,1103L,1229L,1409L,1451L,1499L,1559L,1601L,1811L,1901L,1973L,2039L,2069L,2141L,2339L,2393L,2459L,2549L,2699L,2753L,2903L,2963L,3023L,3329L,3389L,3449L,3539L,3623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100032Inst : IEnumerable<long>
{
public static readonly long[] Value=A100032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100032.Bytes);
public long this[int i]=>Value[i];

public static A100032Inst Instance=new A100032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100033
{
public static readonly ulong[] Value={ 3L,35L,462L,6435L,92378L,1352078L,20058300L,300540195L,4537567650L,68923264410L,1052049481860L,16123801841550L,247959266474052L,3824345300380220L,59132290782430712L,916312070471295267L,14226520737620288370UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100033Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A100033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100033.Bytes);
public ulong this[int i]=>Value[i];

public static A100033Inst Instance=new A100033Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100034
{
public static readonly long[] Value={ 0L,1L,4L,20L,115L,719L,4766L,32973L,235381L,1721159L,12826228L,97055181L,743724984L,5759636510L,45007066269L,354426847597L,2809934352700L,22409533673568L,179655930440464L,1447023384581029L,11703780079612453L,95020085893954917L,774088023431472074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100034Inst : IEnumerable<long>
{
public static readonly long[] Value=A100034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100034.Bytes);
public long this[int i]=>Value[i];

public static A100034Inst Instance=new A100034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100035
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,3L,5L,4L,2L,5L,1L,6L,5L,7L,6L,4L,7L,3L,6L,2L,7L,1L,8L,7L,9L,8L,6L,9L,5L,8L,4L,9L,3L,8L,2L,9L,1L,10L,9L,11L,10L,8L,11L,7L,10L,6L,11L,5L,10L,4L,11L,3L,10L,2L,11L,1L,12L,11L,13L,12L,10L,13L,9L,12L,8L,13L,7L,12L,6L,13L,5L,12L,4L,13L,3L,12L,2L,13L,1L,14L,13L,15L,14L,12L,15L,11L,14L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100035Inst : IEnumerable<long>
{
public static readonly long[] Value=A100035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100035.Bytes);
public long this[int i]=>Value[i];

public static A100035Inst Instance=new A100035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100036
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,12L,14L,23L,25L,38L,40L,57L,59L,80L,82L,107L,109L,138L,140L,173L,175L,212L,214L,255L,257L,302L,304L,353L,355L,408L,410L,467L,469L,530L,532L,597L,599L,668L,670L,743L,745L,822L,824L,905L,907L,992L,994L,1083L,1085L,1178L,1180L,1277L,1279L,1380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100036Inst : IEnumerable<long>
{
public static readonly long[] Value=A100036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100036.Bytes);
public long this[int i]=>Value[i];

public static A100036Inst Instance=new A100036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100037
{
public static readonly long[] Value={ 4L,9L,18L,31L,48L,69L,94L,123L,156L,193L,234L,279L,328L,381L,438L,499L,564L,633L,706L,783L,864L,949L,1038L,1131L,1228L,1329L,1434L,1543L,1656L,1773L,1894L,2019L,2148L,2281L,2418L,2559L,2704L,2853L,3006L,3163L,3324L,3489L,3658L,3831L,4008L,4189L,4374L,4563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100037Inst : IEnumerable<long>
{
public static readonly long[] Value=A100037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100037.Bytes);
public long this[int i]=>Value[i];

public static A100037Inst Instance=new A100037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100038
{
public static readonly long[] Value={ 11L,20L,33L,50L,71L,96L,125L,158L,195L,236L,281L,330L,383L,440L,501L,566L,635L,708L,785L,866L,951L,1040L,1133L,1230L,1331L,1436L,1545L,1658L,1775L,1896L,2021L,2150L,2283L,2420L,2561L,2706L,2855L,3008L,3165L,3326L,3491L,3660L,3833L,4010L,4191L,4376L,4565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100038Inst : IEnumerable<long>
{
public static readonly long[] Value=A100038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100038.Bytes);
public long this[int i]=>Value[i];

public static A100038Inst Instance=new A100038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100039
{
public static readonly long[] Value={ 22L,35L,52L,73L,98L,127L,160L,197L,238L,283L,332L,385L,442L,503L,568L,637L,710L,787L,868L,953L,1042L,1135L,1232L,1333L,1438L,1547L,1660L,1777L,1898L,2023L,2152L,2285L,2422L,2563L,2708L,2857L,3010L,3167L,3328L,3493L,3662L,3835L,4012L,4193L,4378L,4567L,4760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100039Inst : IEnumerable<long>
{
public static readonly long[] Value=A100039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100039.Bytes);
public long this[int i]=>Value[i];

public static A100039Inst Instance=new A100039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100040
{
public static readonly long[] Value={ -5L,-2L,5L,16L,31L,50L,73L,100L,131L,166L,205L,248L,295L,346L,401L,460L,523L,590L,661L,736L,815L,898L,985L,1076L,1171L,1270L,1373L,1480L,1591L,1706L,1825L,1948L,2075L,2206L,2341L,2480L,2623L,2770L,2921L,3076L,3235L,3398L,3565L,3736L,3911L,4090L,4273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100040Inst : IEnumerable<long>
{
public static readonly long[] Value=A100040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100040.Bytes);
public long this[int i]=>Value[i];

public static A100040Inst Instance=new A100040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100041
{
public static readonly long[] Value={ -7L,-4L,3L,14L,29L,48L,71L,98L,129L,164L,203L,246L,293L,344L,399L,458L,521L,588L,659L,734L,813L,896L,983L,1074L,1169L,1268L,1371L,1478L,1589L,1704L,1823L,1946L,2073L,2204L,2339L,2478L,2621L,2768L,2919L,3074L,3233L,3396L,3563L,3734L,3909L,4088L,4271L,4458L,4649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100041Inst : IEnumerable<long>
{
public static readonly long[] Value=A100041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100041.Bytes);
public long this[int i]=>Value[i];

public static A100041Inst Instance=new A100041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100042
{
public static readonly BigInteger[] Value={ 8L,24L,160L,896L,22528L,106496L,2228224L,9961472L,192937984L,15569256448L,66571993088L,5085241278464L,90159953477632L,378231999954944L,6614661952700416L,477381560501272576L,BigInteger.Parse("34011184385901985792") };
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
public class A100042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100042Inst Instance=new A100042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100043
{
public static readonly BigInteger[] Value={ 2L,120L,40320L,39916800L,87178291200L,355687428096000L,2432902008176640000L,BigInteger.Parse("25852016738884976640000"),BigInteger.Parse("403291461126605635584000000"),BigInteger.Parse("8841761993739701954543616000000"),BigInteger.Parse("263130836933693530167218012160000000") };
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
public class A100043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100043Inst Instance=new A100043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100044
{
public static readonly long[] Value={ 1L,0L,9L,6L,6L,2L,2L,7L,1L,1L,2L,3L,2L,1L,5L,0L,9L,5L,7L,6L,4L,8L,2L,7L,6L,7L,7L,7L,7L,6L,4L,0L,1L,6L,7L,9L,2L,8L,1L,2L,6L,3L,3L,2L,6L,7L,4L,7L,1L,1L,9L,8L,9L,5L,8L,4L,9L,0L,3L,7L,2L,1L,5L,2L,9L,1L,3L,3L,3L,8L,3L,1L,3L,6L,0L,2L,1L,3L,3L,9L,1L,5L,8L,8L,9L,0L,8L,5L,9L,3L,3L,7L,4L,6L,5L,0L,5L,8L,0L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100044Inst : IEnumerable<long>
{
public static readonly long[] Value=A100044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100044.Bytes);
public long this[int i]=>Value[i];

public static A100044Inst Instance=new A100044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100045
{
public static readonly long[] Value={ 1L,4L,0L,1L,4L,8L,0L,5L,1L,3L,8L,9L,3L,2L,7L,8L,6L,4L,2L,7L,5L,0L,5L,6L,5L,4L,5L,4L,7L,9L,1L,5L,0L,9L,9L,0L,1L,4L,0L,8L,8L,3L,3L,4L,6L,7L,6L,9L,3L,5L,8L,8L,5L,8L,7L,4L,5L,4L,0L,1L,3L,3L,4L,2L,8L,2L,6L,7L,2L,6L,9L,5L,5L,3L,0L,3L,0L,2L,8L,0L,4L,8L,9L,3L,9L,1L,9L,6L,6L,6L,0L,3L,2L,9L,7L,5L,2L,0L,2L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100045Inst : IEnumerable<long>
{
public static readonly long[] Value=A100045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100045.Bytes);
public long this[int i]=>Value[i];

public static A100045Inst Instance=new A100045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100046
{
public static readonly long[] Value={ 2L,5L,4L,3L,2L,2L,6L,0L,7L,4L,4L,2L,4L,6L,9L,6L,5L,4L,5L,1L,0L,1L,8L,7L,3L,3L,6L,3L,6L,7L,3L,8L,9L,1L,3L,1L,0L,6L,3L,9L,5L,7L,8L,5L,1L,6L,9L,6L,6L,0L,6L,4L,2L,5L,9L,3L,7L,2L,8L,3L,8L,6L,6L,1L,6L,3L,1L,3L,6L,3L,3L,1L,3L,8L,2L,9L,8L,9L,8L,2L,3L,7L,5L,1L,7L,8L,6L,2L,8L,4L,1L,5L,9L,0L,9L,8L,7L,6L,4L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100046Inst : IEnumerable<long>
{
public static readonly long[] Value=A100046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100046.Bytes);
public long this[int i]=>Value[i];

public static A100046Inst Instance=new A100046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100047
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L,0L,1L,1L,-1L,-1L,0L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100047Inst : IEnumerable<long>
{
public static readonly long[] Value=A100047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100047.Bytes);
public long this[int i]=>Value[i];

public static A100047Inst Instance=new A100047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100048
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,9L,16L,29L,56L,106L,198L,373L,704L,1325L,2494L,4698L,8848L,16661L,31376L,59089L,111276L,209554L,394634L,743177L,1399552L,2635641L,4963450L,9347186L,17602652L,33149377L,62427024L,117562789L,221394656L,416931194L,785166286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100048Inst : IEnumerable<long>
{
public static readonly long[] Value=A100048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100048.Bytes);
public long this[int i]=>Value[i];

public static A100048Inst Instance=new A100048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100049
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,-3L,3L,3L,-6L,2L,10L,-13L,-9L,29L,-9L,-43L,55L,32L,-126L,48L,183L,-243L,-121L,541L,-241L,-765L,1082L,450L,-2326L,1171L,3179L,-4803L,-1617L,9993L,-5601L,-13168L,21250L,5552L,-42849L,26489L,54351L,-93763L,-17765L,183347L,-124086L,-223422L,412698L,49827L,-782881L,576541L,914279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100049Inst : IEnumerable<long>
{
public static readonly long[] Value=A100049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100049.Bytes);
public long this[int i]=>Value[i];

public static A100049Inst Instance=new A100049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100050
{
public static readonly long[] Value={ 0L,1L,2L,0L,-4L,-5L,0L,7L,8L,0L,-10L,-11L,0L,13L,14L,0L,-16L,-17L,0L,19L,20L,0L,-22L,-23L,0L,25L,26L,0L,-28L,-29L,0L,31L,32L,0L,-34L,-35L,0L,37L,38L,0L,-40L,-41L,0L,43L,44L,0L,-46L,-47L,0L,49L,50L,0L,-52L,-53L,0L,55L,56L,0L,-58L,-59L,0L,61L,62L,0L,-64L,-65L,0L,67L,68L,0L,-70L,-71L,0L,73L,74L,0L,-76L,-77L,0L,79L,80L,0L,-82L,-83L,0L,85L,86L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100050Inst : IEnumerable<long>
{
public static readonly long[] Value=A100050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100050.Bytes);
public long this[int i]=>Value[i];

public static A100050Inst Instance=new A100050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100051
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100051Inst : IEnumerable<long>
{
public static readonly long[] Value=A100051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100051.Bytes);
public long this[int i]=>Value[i];

public static A100051Inst Instance=new A100051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100052
{
public static readonly long[] Value={ 1L,3L,3L,-2L,-9L,-9L,2L,15L,15L,-2L,-21L,-21L,2L,27L,27L,-2L,-33L,-33L,2L,39L,39L,-2L,-45L,-45L,2L,51L,51L,-2L,-57L,-57L,2L,63L,63L,-2L,-69L,-69L,2L,75L,75L,-2L,-81L,-81L,2L,87L,87L,-2L,-93L,-93L,2L,99L,99L,-2L,-105L,-105L,2L,111L,111L,-2L,-117L,-117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100052Inst : IEnumerable<long>
{
public static readonly long[] Value=A100052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100052.Bytes);
public long this[int i]=>Value[i];

public static A100052Inst Instance=new A100052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100053
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,1L,4L,2L,5L,3L,4L,4L,3L,2L,4L,2L,6L,4L,4L,3L,5L,4L,4L,3L,5L,5L,4L,3L,4L,4L,4L,5L,8L,6L,5L,3L,5L,4L,5L,3L,5L,5L,5L,9L,7L,5L,11L,9L,7L,6L,8L,6L,4L,7L,5L,3L,5L,6L,5L,4L,4L,5L,5L,3L,14L,12L,10L,8L,6L,5L,4L,7L,5L,6L,4L,6L,4L,4L,6L,4L,6L,7L,5L,5L,4L,4L,11L,9L,7L,6L,4L,6L,7L,5L,7L,5L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100053Inst : IEnumerable<long>
{
public static readonly long[] Value=A100053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100053.Bytes);
public long this[int i]=>Value[i];

public static A100053Inst Instance=new A100053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100054
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,9L,11L,14L,15L,23L,24L,26L,28L,33L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100054Inst : IEnumerable<long>
{
public static readonly long[] Value=A100054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100054.Bytes);
public long this[int i]=>Value[i];

public static A100054Inst Instance=new A100054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100055
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,16L,32L,43L,46L,64L,128L,256L,512L,1024L,2048L,4096L,8192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100055Inst : IEnumerable<long>
{
public static readonly long[] Value=A100055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100055.Bytes);
public long this[int i]=>Value[i];

public static A100055Inst Instance=new A100055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100056
{
public static readonly long[] Value={ 1L,3L,7L,10L,16L,22L,27L,37L,47L,57L,67L,75L,91L,107L,123L,139L,155L,171L,187L,200L,226L,252L,278L,304L,330L,356L,382L,408L,434L,460L,486L,512L,533L,575L,617L,659L,701L,743L,785L,827L,869L,911L,953L,995L,1037L,1079L,1121L,1163L,1205L,1247L,1289L,1331L,1373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100056Inst : IEnumerable<long>
{
public static readonly long[] Value=A100056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100056.Bytes);
public long this[int i]=>Value[i];

public static A100056Inst Instance=new A100056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100057
{
public static readonly long[] Value={ 2L,4L,8L,12L,18L,24L,30L,40L,50L,60L,70L,80L,96L,112L,128L,144L,160L,176L,192L,208L,234L,260L,286L,312L,338L,364L,390L,416L,442L,468L,494L,520L,546L,588L,630L,672L,714L,756L,798L,840L,882L,924L,966L,1008L,1050L,1092L,1134L,1176L,1218L,1260L,1302L,1344L,1386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100057Inst : IEnumerable<long>
{
public static readonly long[] Value=A100057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100057.Bytes);
public long this[int i]=>Value[i];

public static A100057Inst Instance=new A100057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100058
{
public static readonly long[] Value={ 1L,3L,10L,31L,97L,302L,941L,2931L,9130L,28439L,88585L,275934L,859509L,2677291L,8339514L,25976815L,80915377L,252043918L,785093501L,2445493667L,7617486666L,23727766663L,73909799321L,230222191294L,717120839877L,2233765112283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100058Inst : IEnumerable<long>
{
public static readonly long[] Value=A100058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100058.Bytes);
public long this[int i]=>Value[i];

public static A100058Inst Instance=new A100058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100059
{
public static readonly long[] Value={ 1L,5L,14L,45L,139L,434L,1351L,4209L,13110L,40837L,127203L,396226L,1234207L,3844441L,11975078L,37301261L,116189979L,361921042L,1127350583L,3511592833L,10938286998L,34071752661L,106130359315L,330586256610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100059Inst : IEnumerable<long>
{
public static readonly long[] Value=A100059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100059.Bytes);
public long this[int i]=>Value[i];

public static A100059Inst Instance=new A100059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100060
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100060Inst : IEnumerable<long>
{
public static readonly long[] Value=A100060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100060.Bytes);
public long this[int i]=>Value[i];

public static A100060Inst Instance=new A100060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100061
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100000000L,612579511L,5738374621L,53509541320L,496353364300L,4576113154000L,41886926650000L,380127217600000L,3413851687000000L,30264311980000000L,263901070900000000L,2401684855296999121L,BigInteger.Parse("21793684651236981541"),BigInteger.Parse("197206153848009709930") };
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
public class A100061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100061Inst Instance=new A100061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100062
{
public static readonly long[] Value={ 9L,81L,729L,6561L,59049L,531441L,4782969L,43046721L,387420489L,3486784401L,31381059609L,282429536481L,2541865828329L,22876792454961L,205891132094649L,1853020188851841L,16677181699666569L,150094635296999121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100062Inst : IEnumerable<long>
{
public static readonly long[] Value=A100062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100062.Bytes);
public long this[int i]=>Value[i];

public static A100062Inst Instance=new A100062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100063
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100063Inst : IEnumerable<long>
{
public static readonly long[] Value=A100063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100063.Bytes);
public long this[int i]=>Value[i];

public static A100063Inst Instance=new A100063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100064
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,8L,1L,3L,15L,51L,1L,4L,24L,120L,408L,1L,5L,35L,225L,1215L,4365L,1L,6L,48L,372L,2628L,15084L,53856L,1L,7L,63L,567L,4851L,36603L,216405L,777609L,1L,8L,80L,816L,8112L,74352L,585792L,3558672L,12810240L,1L,9L,99L,1125L,12663L,135081L,1301157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100064Inst : IEnumerable<long>
{
public static readonly long[] Value=A100064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100064.Bytes);
public long this[int i]=>Value[i];

public static A100064Inst Instance=new A100064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100065
{
public static readonly BigInteger[] Value={ 1L,1L,3L,-3L,-57L,369L,3861L,-76617L,-413775L,26879103L,-52349229L,-13272657111L,163271276343L,8454393401121L,-248550519324411L,-5938622542044441L,389600359347114081L,2878180608333977343L,BigInteger.Parse("-677734293694386004317"),BigInteger.Parse("5701654525891937630409") };
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
public class A100065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100065Inst Instance=new A100065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100066
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,9L,9L,29L,29L,99L,99L,351L,351L,1275L,1275L,4707L,4707L,17577L,17577L,66197L,66197L,250953L,250953L,956385L,956385L,3660541L,3660541L,14061141L,14061141L,54177741L,54177741L,209295261L,209295261L,810375651L,810375651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100066Inst : IEnumerable<long>
{
public static readonly long[] Value=A100066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100066.Bytes);
public long this[int i]=>Value[i];

public static A100066Inst Instance=new A100066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100067
{
public static readonly long[] Value={ 1L,2L,6L,14L,38L,92L,240L,590L,1510L,3740L,9476L,23564L,59372L,147968L,371636L,927374L,2324870L,5805740L,14538660L,36322340L,90898228L,227153192L,568235696L,1420236524L,3551943388L,8878506392L,22201466280L,55498465400L,138766221800L,346895496200L,867316299260L,2168213189390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100067Inst : IEnumerable<long>
{
public static readonly long[] Value=A100067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100067.Bytes);
public long this[int i]=>Value[i];

public static A100067Inst Instance=new A100067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100068
{
public static readonly long[] Value={ 1L,3L,11L,36L,123L,408L,1370L,4560L,15235L,50760L,169326L,564336L,1881582L,6271632L,20907156L,69689376L,232304355L,774343560L,2581169510L,8603882160L,28679699578L,95598937008L,318663476076L,1062211351776L,3540705857998L,11802351958608L,39341178395660L,131137257852000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100068Inst : IEnumerable<long>
{
public static readonly long[] Value=A100068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100068.Bytes);
public long this[int i]=>Value[i];

public static A100068Inst Instance=new A100068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100069
{
public static readonly long[] Value={ 1L,4L,18L,76L,326L,1384L,5892L,25036L,106438L,452344L,1922588L,8170936L,34726940L,147589264L,627256088L,2665837516L,11329815878L,48151714264L,204644809932L,869740430056L,3696396920116L,15709686864304L,66766169526008L,283756220309176L,1205963937666076L,5125346734404784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100069Inst : IEnumerable<long>
{
public static readonly long[] Value=A100069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100069.Bytes);
public long this[int i]=>Value[i];

public static A100069Inst Instance=new A100069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100070
{
public static readonly BigInteger[] Value={ 6L,117L,5632L,515625L,77262336L,17230990189L,5360119185408L,2219048868131217L,1180000000000000000L,BigInteger.Parse("783948341202404638821"),BigInteger.Parse("636404158746280870281216"),BigInteger.Parse("619884903445287035295372217"),BigInteger.Parse("713552333492738487958741450752") };
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
public class A100070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100070Inst Instance=new A100070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100071
{
public static readonly long[] Value={ 0L,1L,2L,6L,12L,30L,60L,140L,280L,630L,1260L,2772L,5544L,12012L,24024L,51480L,102960L,218790L,437580L,923780L,1847560L,3879876L,7759752L,16224936L,32449872L,67603900L,135207800L,280816200L,561632400L,1163381400L,2326762800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100071Inst : IEnumerable<long>
{
public static readonly long[] Value=A100071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100071.Bytes);
public long this[int i]=>Value[i];

public static A100071Inst Instance=new A100071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100072
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,7L,8L,5L,5L,2L,7L,2L,2L,9L,1L,2L,2L,4L,9L,5L,3L,9L,6L,0L,2L,9L,6L,0L,4L,9L,6L,6L,8L,8L,6L,9L,2L,9L,7L,8L,0L,4L,4L,8L,7L,5L,8L,6L,9L,1L,7L,7L,1L,5L,0L,2L,8L,2L,0L,2L,2L,6L,5L,9L,5L,9L,2L,9L,3L,5L,4L,3L,2L,4L,3L,1L,0L,7L,8L,0L,9L,2L,3L,4L,6L,6L,1L,5L,9L,2L,9L,7L,4L,0L,3L,1L,1L,5L,8L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100072Inst : IEnumerable<long>
{
public static readonly long[] Value=A100072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100072.Bytes);
public long this[int i]=>Value[i];

public static A100072Inst Instance=new A100072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100073
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,2L,1L,0L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,0L,2L,2L,1L,0L,1L,1L,3L,0L,1L,3L,1L,0L,2L,1L,1L,0L,2L,2L,2L,0L,1L,2L,1L,0L,3L,2L,2L,0L,1L,1L,2L,0L,1L,3L,1L,0L,3L,1L,2L,0L,1L,3L,2L,0L,1L,2L,2L,0L,2L,2L,1L,0L,2L,1L,2L,0L,2L,4L,1L,0L,3L,1L,1L,0L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100073Inst : IEnumerable<long>
{
public static readonly long[] Value=A100073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100073.Bytes);
public long this[int i]=>Value[i];

public static A100073Inst Instance=new A100073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100074
{
public static readonly long[] Value={ 0L,4L,0L,9L,4L,8L,2L,2L,2L,4L,2L,3L,4L,0L,0L,5L,6L,3L,5L,2L,1L,9L,4L,1L,8L,0L,4L,6L,3L,3L,8L,0L,7L,2L,4L,2L,0L,9L,3L,7L,2L,7L,2L,9L,9L,7L,4L,5L,6L,8L,9L,6L,1L,8L,4L,7L,7L,7L,8L,1L,7L,0L,0L,3L,0L,2L,3L,0L,9L,3L,4L,7L,4L,9L,3L,8L,1L,0L,9L,7L,9L,2L,5L,8L,5L,4L,7L,4L,0L,1L,3L,4L,3L,4L,3L,2L,8L,0L,3L,5L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100074Inst : IEnumerable<long>
{
public static readonly long[] Value=A100074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100074.Bytes);
public long this[int i]=>Value[i];

public static A100074Inst Instance=new A100074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100075
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,9L,15L,1L,4L,16L,48L,96L,1L,5L,25L,105L,345L,555L,1L,6L,36L,192L,864L,2772L,6408L,1L,7L,49L,315L,1785L,8169L,28665L,59157L,1L,8L,64L,480L,3264L,19056L,91296L,323424L,734976L,1L,9L,81L,693L,5481L,38583L,233361L,1144611L,4222449L,9129591L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100075Inst : IEnumerable<long>
{
public static readonly long[] Value=A100075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100075.Bytes);
public long this[int i]=>Value[i];

public static A100075Inst Instance=new A100075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100076
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-3L,9L,-33L,513L,-10917L,155313L,-869697L,-27095391L,1126973331L,-25370851671L,400873570911L,-3945969886815L,-19472448499317L,3355787673885537L,-205870807636111233L,10635145244261722305UL,BigInteger.Parse("-447262563680813504349"),BigInteger.Parse("13896854240554592685081") };
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
public class A100076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100076Inst Instance=new A100076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100077
{
public static readonly long[] Value={ 9L,4L,22L,3L,5L,10L,1L,6L,8L,2L,108L,195L,25L,43L,4L,80L,147L,20L,7L,72L,56L,24L,419L,22L,242L,49L,89L,161L,167L,255L,16L,3L,23L,66L,44L,128L,46L,169L,182L,67L,299L,19L,101L,45L,207L,14L,347L,5L,106L,64L,40L,146L,51L,15L,53L,10L,34L,112L,29L,11L,47L,155L,70L,86L,93L,33L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100077Inst : IEnumerable<long>
{
public static readonly long[] Value=A100077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100077.Bytes);
public long this[int i]=>Value[i];

public static A100077Inst Instance=new A100077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100078
{
public static readonly long[] Value={ 2L,10L,1L,9L,15L,5L,6L,22L,17L,7L,208L,29L,231L,77L,30L,10L,25L,54L,66L,103L,1L,136L,57L,45L,187L,97L,112L,58L,16L,43L,78L,9L,132L,94L,46L,95L,90L,138L,23L,19L,47L,65L,15L,194L,31L,85L,101L,309L,374L,32L,402L,28L,96L,18L,255L,61L,5L,72L,87L,11L,91L,26L,42L,75L,38L,224L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100078Inst : IEnumerable<long>
{
public static readonly long[] Value=A100078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100078.Bytes);
public long this[int i]=>Value[i];

public static A100078Inst Instance=new A100078Inst();

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