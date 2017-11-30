using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199857
{
public static readonly long[] Value={ 24871L,81719L,81809L,88711L,174097L,198679L,201761L,256151L,273581L,290191L,329681L,405449L,422807L,428281L,472549L,572663L,592999L,604279L,620977L,701561L,728119L,752191L,770431L,876641L,898909L,1011839L,1063517L,1121729L,1178879L,1218679L,1251439L,1389223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199857Inst : IEnumerable<long>
{
public static readonly long[] Value=A199857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199857.Bytes);
public long this[int i]=>Value[i];

public static A199857Inst Instance=new A199857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199858
{
public static readonly long[] Value={ 1L,2L,3L,9L,7L,1L,9L,5L,3L,8L,1L,4L,6L,2L,2L,7L,4L,1L,1L,9L,6L,5L,0L,4L,2L,6L,7L,6L,5L,2L,4L,5L,8L,7L,1L,0L,4L,6L,7L,9L,0L,0L,0L,3L,6L,4L,6L,2L,3L,5L,4L,2L,7L,4L,1L,4L,2L,9L,5L,8L,6L,3L,0L,5L,7L,6L,9L,8L,9L,8L,3L,3L,8L,1L,7L,1L,7L,6L,5L,2L,1L,5L,0L,9L,6L,0L,2L,6L,2L,4L,8L,4L,8L,9L,7L,7L,1L,1L,4L,7L,6L,8L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199858Inst : IEnumerable<long>
{
public static readonly long[] Value=A199858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199858.Bytes);
public long this[int i]=>Value[i];

public static A199858Inst Instance=new A199858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199859
{
public static readonly long[] Value={ 1L,9L,16L,23L,29L,30L,37L,42L,44L,51L,55L,58L,61L,65L,68L,72L,79L,80L,81L,86L,93L,94L,99L,100L,105L,107L,114L,118L,120L,121L,128L,130L,133L,135L,137L,142L,146L,149L,155L,156L,159L,161L,163L,170L,172L,175L,177L,180L,184L,185L,191L,192L,194L,198L,205L,211L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199859Inst : IEnumerable<long>
{
public static readonly long[] Value=A199859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199859.Bytes);
public long this[int i]=>Value[i];

public static A199859Inst Instance=new A199859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199860
{
public static readonly long[] Value={ 5L,10L,15L,20L,21L,25L,30L,32L,35L,40L,43L,45L,49L,50L,54L,55L,60L,65L,66L,70L,75L,76L,80L,83L,85L,87L,89L,90L,95L,98L,100L,105L,109L,110L,112L,115L,117L,120L,125L,130L,131L,134L,135L,140L,141L,142L,145L,150L,151L,153L,155L,158L,160L,164L,165L,168L,170L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199860Inst : IEnumerable<long>
{
public static readonly long[] Value=A199860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199860.Bytes);
public long this[int i]=>Value[i];

public static A199860Inst Instance=new A199860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199861
{
public static readonly long[] Value={ 2L,2L,7L,1L,0L,6L,4L,4L,8L,2L,9L,4L,3L,8L,1L,2L,0L,3L,0L,1L,1L,1L,4L,3L,3L,5L,2L,5L,3L,2L,3L,4L,4L,6L,1L,8L,3L,7L,7L,5L,4L,0L,5L,3L,1L,2L,9L,8L,6L,7L,4L,9L,6L,2L,9L,3L,2L,5L,4L,0L,3L,5L,4L,5L,5L,0L,4L,8L,1L,2L,6L,1L,0L,0L,0L,1L,6L,0L,1L,8L,4L,3L,7L,1L,1L,6L,7L,7L,4L,5L,2L,8L,4L,9L,4L,9L,4L,5L,8L,6L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199861Inst : IEnumerable<long>
{
public static readonly long[] Value=A199861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199861.Bytes);
public long this[int i]=>Value[i];

public static A199861Inst Instance=new A199861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199862
{
public static readonly long[] Value={ 9L,8L,4L,4L,5L,3L,6L,3L,1L,7L,1L,3L,2L,8L,9L,9L,7L,5L,3L,8L,4L,7L,6L,0L,5L,7L,0L,6L,2L,8L,5L,3L,8L,4L,3L,3L,9L,9L,3L,2L,1L,7L,3L,8L,4L,5L,8L,2L,5L,0L,8L,3L,4L,2L,8L,9L,4L,5L,2L,1L,3L,1L,6L,1L,3L,7L,3L,0L,5L,8L,6L,1L,9L,7L,1L,3L,6L,5L,5L,7L,4L,4L,4L,0L,8L,8L,7L,8L,6L,8L,6L,1L,3L,8L,5L,0L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199862Inst : IEnumerable<long>
{
public static readonly long[] Value=A199862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199862.Bytes);
public long this[int i]=>Value[i];

public static A199862Inst Instance=new A199862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199863
{
public static readonly long[] Value={ 8L,3L,4L,0L,0L,6L,7L,4L,4L,6L,4L,2L,9L,0L,8L,3L,3L,9L,1L,1L,1L,0L,1L,6L,6L,8L,2L,9L,0L,7L,9L,2L,2L,4L,5L,8L,5L,5L,8L,6L,5L,0L,2L,6L,5L,9L,9L,1L,8L,1L,0L,4L,8L,5L,1L,0L,1L,7L,6L,7L,6L,2L,6L,1L,7L,5L,6L,3L,2L,1L,7L,1L,7L,9L,8L,2L,7L,1L,1L,8L,3L,0L,9L,3L,5L,3L,7L,3L,8L,8L,2L,2L,5L,0L,0L,8L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199863Inst : IEnumerable<long>
{
public static readonly long[] Value=A199863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199863.Bytes);
public long this[int i]=>Value[i];

public static A199863Inst Instance=new A199863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199864
{
public static readonly long[] Value={ 6L,6L,1L,5L,7L,3L,3L,0L,1L,8L,2L,0L,5L,9L,1L,2L,1L,3L,9L,3L,3L,8L,6L,7L,1L,1L,5L,4L,1L,2L,8L,3L,4L,2L,8L,3L,3L,8L,0L,2L,3L,4L,0L,0L,5L,6L,3L,2L,4L,6L,9L,9L,1L,4L,2L,9L,2L,5L,2L,0L,2L,4L,2L,7L,8L,3L,0L,7L,0L,8L,2L,2L,9L,9L,5L,2L,4L,5L,0L,6L,0L,1L,7L,3L,6L,9L,8L,0L,9L,0L,4L,4L,6L,2L,5L,1L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199864Inst : IEnumerable<long>
{
public static readonly long[] Value=A199864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199864.Bytes);
public long this[int i]=>Value[i];

public static A199864Inst Instance=new A199864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199865
{
public static readonly long[] Value={ 4L,6L,4L,6L,0L,2L,5L,2L,5L,9L,9L,5L,2L,3L,9L,3L,9L,5L,8L,9L,2L,1L,9L,0L,6L,0L,0L,7L,5L,7L,4L,7L,8L,4L,6L,4L,3L,5L,4L,0L,5L,6L,5L,2L,4L,3L,5L,7L,0L,5L,0L,2L,4L,8L,6L,1L,3L,2L,1L,3L,0L,6L,1L,0L,9L,7L,7L,8L,5L,0L,3L,0L,3L,1L,9L,6L,4L,9L,1L,5L,8L,1L,1L,7L,1L,9L,4L,5L,2L,3L,6L,3L,7L,3L,3L,9L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199865Inst : IEnumerable<long>
{
public static readonly long[] Value=A199865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199865.Bytes);
public long this[int i]=>Value[i];

public static A199865Inst Instance=new A199865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199866
{
public static readonly long[] Value={ 9L,3L,9L,5L,1L,9L,4L,9L,6L,3L,9L,1L,8L,7L,5L,0L,9L,7L,7L,0L,0L,1L,1L,5L,9L,8L,0L,6L,2L,9L,2L,9L,1L,7L,3L,5L,9L,1L,1L,4L,4L,8L,8L,0L,3L,4L,0L,8L,7L,7L,3L,5L,4L,5L,9L,3L,6L,5L,0L,5L,0L,4L,6L,2L,1L,1L,5L,6L,6L,3L,2L,8L,1L,5L,8L,0L,3L,8L,1L,1L,0L,3L,4L,2L,4L,5L,2L,6L,2L,5L,0L,0L,6L,8L,2L,7L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199866Inst : IEnumerable<long>
{
public static readonly long[] Value=A199866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199866.Bytes);
public long this[int i]=>Value[i];

public static A199866Inst Instance=new A199866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199867
{
public static readonly long[] Value={ 6L,3L,5L,7L,9L,4L,2L,3L,3L,9L,7L,1L,9L,2L,6L,5L,5L,1L,4L,3L,5L,4L,2L,6L,6L,4L,2L,1L,0L,0L,1L,5L,9L,2L,2L,3L,2L,3L,8L,8L,1L,5L,0L,3L,7L,1L,6L,5L,9L,8L,8L,6L,8L,9L,6L,3L,7L,8L,9L,2L,5L,4L,1L,7L,8L,0L,3L,0L,3L,4L,3L,4L,0L,1L,4L,0L,4L,0L,9L,4L,6L,6L,6L,4L,9L,4L,2L,7L,1L,1L,2L,3L,8L,6L,1L,7L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199867Inst : IEnumerable<long>
{
public static readonly long[] Value=A199867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199867.Bytes);
public long this[int i]=>Value[i];

public static A199867Inst Instance=new A199867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199868
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,9L,8L,3L,7L,9L,6L,7L,8L,5L,4L,5L,4L,9L,9L,7L,7L,1L,1L,9L,7L,1L,7L,0L,6L,2L,2L,8L,8L,9L,8L,0L,9L,8L,5L,9L,8L,5L,3L,3L,9L,2L,3L,3L,2L,8L,2L,7L,2L,1L,9L,4L,7L,1L,3L,2L,5L,9L,0L,8L,8L,2L,1L,2L,5L,3L,0L,6L,3L,6L,0L,4L,5L,0L,7L,2L,2L,2L,5L,2L,3L,1L,6L,9L,1L,0L,9L,1L,9L,9L,7L,8L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199868Inst : IEnumerable<long>
{
public static readonly long[] Value=A199868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199868.Bytes);
public long this[int i]=>Value[i];

public static A199868Inst Instance=new A199868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199869
{
public static readonly long[] Value={ 1L,0L,1L,9L,5L,0L,4L,6L,3L,9L,3L,1L,5L,1L,7L,6L,3L,5L,2L,8L,8L,2L,8L,4L,5L,3L,7L,8L,6L,5L,5L,2L,7L,1L,4L,6L,7L,3L,0L,1L,9L,2L,1L,7L,1L,9L,3L,3L,3L,8L,9L,0L,3L,5L,5L,1L,1L,3L,6L,1L,0L,3L,5L,9L,2L,2L,2L,0L,5L,9L,0L,9L,0L,2L,5L,4L,9L,0L,5L,0L,4L,6L,4L,0L,4L,7L,9L,8L,6L,3L,3L,3L,1L,6L,5L,7L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199869Inst : IEnumerable<long>
{
public static readonly long[] Value=A199869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199869.Bytes);
public long this[int i]=>Value[i];

public static A199869Inst Instance=new A199869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199870
{
public static readonly long[] Value={ 9L,0L,0L,8L,0L,4L,8L,3L,6L,9L,5L,4L,1L,5L,0L,8L,2L,6L,0L,1L,5L,9L,6L,3L,7L,3L,8L,5L,2L,0L,7L,0L,2L,3L,2L,4L,5L,3L,4L,5L,0L,3L,4L,2L,8L,1L,5L,9L,9L,2L,6L,1L,5L,0L,3L,9L,0L,1L,5L,8L,5L,0L,3L,6L,4L,8L,1L,2L,0L,3L,9L,4L,5L,8L,3L,7L,8L,3L,4L,6L,7L,1L,1L,5L,6L,8L,9L,5L,4L,7L,2L,0L,9L,8L,2L,0L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199870Inst : IEnumerable<long>
{
public static readonly long[] Value=A199870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199870.Bytes);
public long this[int i]=>Value[i];

public static A199870Inst Instance=new A199870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199871
{
public static readonly long[] Value={ 7L,6L,6L,4L,9L,1L,2L,1L,3L,5L,7L,0L,1L,7L,9L,1L,4L,9L,8L,5L,2L,7L,0L,4L,1L,1L,4L,6L,2L,4L,8L,3L,7L,3L,6L,0L,4L,9L,3L,0L,2L,7L,0L,1L,3L,9L,4L,2L,2L,4L,2L,9L,7L,2L,0L,9L,8L,9L,2L,4L,1L,9L,9L,7L,5L,4L,6L,7L,2L,8L,7L,8L,6L,5L,3L,6L,3L,4L,7L,3L,9L,0L,5L,9L,7L,7L,0L,0L,7L,5L,2L,7L,6L,4L,5L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199871Inst : IEnumerable<long>
{
public static readonly long[] Value=A199871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199871.Bytes);
public long this[int i]=>Value[i];

public static A199871Inst Instance=new A199871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199872
{
public static readonly long[] Value={ 1L,0L,8L,1L,7L,9L,0L,0L,5L,1L,2L,8L,5L,1L,3L,0L,2L,4L,7L,3L,7L,2L,6L,8L,1L,8L,4L,7L,8L,0L,5L,4L,1L,1L,4L,5L,9L,0L,3L,4L,2L,0L,2L,6L,1L,6L,8L,3L,4L,7L,9L,3L,1L,2L,5L,8L,4L,7L,6L,0L,4L,2L,2L,9L,9L,2L,2L,8L,3L,3L,4L,5L,3L,6L,0L,3L,3L,3L,0L,6L,2L,8L,6L,1L,4L,9L,0L,4L,9L,6L,8L,7L,9L,0L,1L,5L,7L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199872Inst : IEnumerable<long>
{
public static readonly long[] Value=A199872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199872.Bytes);
public long this[int i]=>Value[i];

public static A199872Inst Instance=new A199872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199873
{
public static readonly long[] Value={ 8L,6L,6L,9L,7L,4L,0L,6L,9L,0L,6L,4L,8L,2L,4L,9L,6L,9L,6L,7L,4L,6L,0L,5L,5L,9L,7L,4L,3L,0L,7L,1L,9L,0L,7L,3L,0L,4L,7L,1L,6L,6L,5L,8L,0L,6L,2L,5L,3L,7L,4L,4L,2L,2L,3L,1L,0L,4L,8L,2L,5L,2L,2L,0L,3L,9L,0L,5L,3L,5L,0L,4L,5L,0L,9L,1L,6L,2L,5L,1L,6L,0L,4L,8L,2L,8L,8L,0L,5L,1L,5L,2L,0L,7L,5L,7L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199873Inst : IEnumerable<long>
{
public static readonly long[] Value=A199873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199873.Bytes);
public long this[int i]=>Value[i];

public static A199873Inst Instance=new A199873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199874
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,147L,611L,2625L,11564L,51953L,237123L,1096420L,5125063L,24178427L,114974387L,550511901L,2651896733L,12843003108L,62494595022L,305400429548L,1498184696271L,7375179807191L,36421312544431L,180383163330765L,895756907248150L,4459095182031675L,22247684478181317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199874Inst : IEnumerable<long>
{
public static readonly long[] Value=A199874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199874.Bytes);
public long this[int i]=>Value[i];

public static A199874Inst Instance=new A199874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199875
{
public static readonly long[] Value={ 1L,1L,3L,12L,51L,233L,1126L,5639L,29001L,152364L,814268L,4412733L,24193883L,133964582L,748084930L,4208233719L,23825366565L,135657095301L,776310257573L,4462597387720L,25757503356976L,149216036734018L,867316809868018L,5056666312351966L,29564095191382323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199875Inst : IEnumerable<long>
{
public static readonly long[] Value=A199875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199875.Bytes);
public long this[int i]=>Value[i];

public static A199875Inst Instance=new A199875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199876
{
public static readonly long[] Value={ 1L,1L,4L,19L,103L,604L,3728L,23866L,157015L,1055121L,7211227L,49970893L,350283538L,2479386646L,17696379769L,127220129807L,920376055978L,6695598216385L,48950677790253L,359456740745360L,2650089982411601L,19608110285151138L,145555836451997536L,1083723594296492362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199876Inst : IEnumerable<long>
{
public static readonly long[] Value=A199876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199876.Bytes);
public long this[int i]=>Value[i];

public static A199876Inst Instance=new A199876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199877
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,222L,1727L,14179L,120930L,1060992L,9514463L,86818391L,803516167L,7524700644L,71169939341L,678877680077L,6523424076116L,63087757216084L,613575943566436L,5997490784042496L,58886692596764215L,580516324380845804L,5743718741275361697L,BigInteger.Parse("57017511243375535969") };
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
public class A199877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199877Inst Instance=new A199877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199878
{
public static readonly long[] Value={ 5L,2875L,609250L,2683549425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199878Inst : IEnumerable<long>
{
public static readonly long[] Value=A199878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199878.Bytes);
public long this[int i]=>Value[i];

public static A199878Inst Instance=new A199878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199879
{
public static readonly long[] Value={ 0L,2L,2L,1L,35L,1L,2L,2L,1L,2L,5L,3L,1L,1L,45L,1L,1L,6L,11L,2L,9L,2L,2L,2L,2L,1L,1L,1L,29L,1L,3L,7L,4L,1L,7L,61L,1L,1L,2L,1L,2L,6L,2L,1L,1L,96L,11L,1L,2L,1L,1L,4L,14L,1L,10L,1L,2L,1L,7L,4L,7L,5L,10L,1L,6L,2L,2L,9L,6L,8L,3L,1L,3L,1L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199879Inst : IEnumerable<long>
{
public static readonly long[] Value=A199879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199879.Bytes);
public long this[int i]=>Value[i];

public static A199879Inst Instance=new A199879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199880
{
public static readonly long[] Value={ 3L,4L,8L,12L,15L,33L,70L,4338L,22062L,46566L,98091L,255284L,2715877L,10855925L,150153128L,10009347774L,34679420772L,43644678207L,74587800101L,229110893125L,233558717156L,286861037311L,299617642336L,312870987050L,1632483095154L,31761226898013L,66327161231576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199880Inst : IEnumerable<long>
{
public static readonly long[] Value=A199880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199880.Bytes);
public long this[int i]=>Value[i];

public static A199880Inst Instance=new A199880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199881
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,0L,2L,3L,1L,0L,0L,1L,4L,4L,1L,0L,0L,0L,3L,7L,5L,1L,0L,0L,0L,1L,7L,11L,6L,1L,0L,0L,0L,0L,4L,14L,16L,7L,1L,0L,0L,0L,0L,1L,11L,25L,22L,8L,1L,0L,0L,0L,0L,0L,5L,25L,41L,29L,9L,1L,0L,0L,0L,0L,0L,1L,16L,50L,63L,37L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199881Inst : IEnumerable<long>
{
public static readonly long[] Value=A199881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199881.Bytes);
public long this[int i]=>Value[i];

public static A199881Inst Instance=new A199881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199882
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,7L,15L,33L,93L,309L,1071L,3699L,13947L,58293L,260337L,1202121L,5797035L,29682639L,161252631L,915546969L,5401610901L,33227826669L,213648580503L,1430820925083L,9936454523427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199882Inst : IEnumerable<long>
{
public static readonly long[] Value=A199882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199882.Bytes);
public long this[int i]=>Value[i];

public static A199882Inst Instance=new A199882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199883
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,48L,113L,262L,591L,1263L,2505L,4764L,8479L,14285L,22871L,35316L,52755L,76517L,107826L,148914L,202715L,270622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199883Inst : IEnumerable<long>
{
public static readonly long[] Value=A199883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199883.Bytes);
public long this[int i]=>Value[i];

public static A199883Inst Instance=new A199883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199884
{
public static readonly long[] Value={ 0L,1L,1L,6L,8L,19L,43L,90L,167L,339L,722L,1503L,2987L,5883L,11820L,24167L,49348L,99707L,199626L,398475L,797457L,1604029L,3237867L,6534327L,13143278L,26336266L,52664325L,105349525L,211135006L,423949168L,851981311L,1711365899L,3433202397L,6878160656L,13768314357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199884Inst : IEnumerable<long>
{
public static readonly long[] Value=A199884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199884.Bytes);
public long this[int i]=>Value[i];

public static A199884Inst Instance=new A199884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199885
{
public static readonly long[] Value={ 0L,1L,1L,6L,10L,23L,49L,106L,215L,444L,906L,1849L,3759L,7621L,15402L,31091L,62676L,126206L,253860L,510204L,1024665L,2056608L,4125625L,8272436L,16580967L,33223336L,66550937L,133278720L,266857006L,534220745L,1069297319L,2140037990L,4282507048L,8569103770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199885Inst : IEnumerable<long>
{
public static readonly long[] Value=A199885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199885.Bytes);
public long this[int i]=>Value[i];

public static A199885Inst Instance=new A199885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199886
{
public static readonly long[] Value={ 1L,2L,2L,7L,7L,18L,40L,85L,148L,285L,584L,1231L,2516L,5069L,10175L,20306L,40000L,78328L,154233L,307586L,620903L,1262129L,2566697L,5193429L,10424746L,20761986L,41131719L,81358316L,161239595L,320900400L,641688619L,1287937462L,2589941043L,5208522925L,10461756080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199886Inst : IEnumerable<long>
{
public static readonly long[] Value=A199886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199886.Bytes);
public long this[int i]=>Value[i];

public static A199886Inst Instance=new A199886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199887
{
public static readonly long[] Value={ 0L,0L,2L,1L,9L,14L,24L,43L,108L,227L,440L,817L,1580L,3123L,6209L,12462L,25536L,52744L,107911L,216702L,427673L,835023L,1627607L,3195179L,6352470L,12792446L,25977145L,52859412L,107195861L,215970512L,432053205L,859546186L,1705026253L,3381411667L,6718113104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199887Inst : IEnumerable<long>
{
public static readonly long[] Value=A199887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199887.Bytes);
public long this[int i]=>Value[i];

public static A199887Inst Instance=new A199887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199888
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,30L,62L,124L,247L,495L,994L,1999L,4020L,8076L,16204L,32482L,65076L,130326L,260927L,522298L,1045325L,2091849L,4185665L,8374551L,16754372L,33517355L,67048754L,134120372L,268277888L,536615992L,1073329437L,2146816436L,4293887542L,8588186785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199888Inst : IEnumerable<long>
{
public static readonly long[] Value=A199888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199888.Bytes);
public long this[int i]=>Value[i];

public static A199888Inst Instance=new A199888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199889
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,4L,9L,17L,30L,49L,76L,116L,180L,286L,460L,746L,1217L,1990L,3251L,5303L,8639L,14057L,22844L,37077L,60110L,97356L,157568L,254920L,412387L,667212L,1079754L,1747807L,2829756L,4582021L,7419619L,12014143L,19452288L,31492382L,50979547L,82517631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199889Inst : IEnumerable<long>
{
public static readonly long[] Value=A199889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199889.Bytes);
public long this[int i]=>Value[i];

public static A199889Inst Instance=new A199889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199890
{
public static readonly long[] Value={ 1L,1L,1L,6L,4L,15L,37L,81L,133L,270L,565L,1200L,2449L,4961L,10014L,20083L,39585L,77566L,152934L,305587L,617857L,1257333L,2558837L,5180712L,10404918L,20732162L,41087390L,81291644L,161136101L,320733232L,641408052L,1287453960L,2589099670L,5207066575L,10459270462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199890Inst : IEnumerable<long>
{
public static readonly long[] Value=A199890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199890.Bytes);
public long this[int i]=>Value[i];

public static A199890Inst Instance=new A199890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199891
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,4L,1L,8L,12L,31L,30L,50L,84L,166L,240L,367L,560L,970L,1647L,2736L,4340L,6924L,11185L,18334L,29875L,48272L,77632L,125262L,202838L,329098L,533758L,865248L,1402099L,2271831L,3680202L,5960113L,9650231L,15624475L,25301422L,40983324L,66398800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199891Inst : IEnumerable<long>
{
public static readonly long[] Value=A199891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199891.Bytes);
public long this[int i]=>Value[i];

public static A199891Inst Instance=new A199891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199892
{
public static readonly long[] Value={ 1L,5L,15L,49L,159L,533L,1783L,6027L,20437L,69665L,238191L,817083L,2809845L,9685397L,33450675L,115736335L,401065951L,1391807783L,4836111471L,16823523661L,58586196339L,204217367081L,712482836479L,2487770630935L,8693076444331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199892Inst : IEnumerable<long>
{
public static readonly long[] Value=A199892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199892.Bytes);
public long this[int i]=>Value[i];

public static A199892Inst Instance=new A199892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199893
{
public static readonly long[] Value={ 1L,7L,25L,111L,461L,2035L,8823L,39053L,172355L,767425L,3420017L,15311495L,68665323L,308805403L,1391091909L,6278869703L,28381760049L,128482271031L,582346682067L,2642616002605L,12004291295381L,54583533395613L,248409301882015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199893Inst : IEnumerable<long>
{
public static readonly long[] Value=A199893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199893.Bytes);
public long this[int i]=>Value[i];

public static A199893Inst Instance=new A199893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199894
{
public static readonly long[] Value={ 1L,9L,37L,209L,1043L,5725L,30199L,164993L,890299L,4877477L,26632013L,146499083L,805700567L,4449304857L,24590147861L,136249639279L,755738351775L,4199211521573L,23357174342185L,130088542750275L,725223072283995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199894Inst : IEnumerable<long>
{
public static readonly long[] Value=A199894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199894.Bytes);
public long this[int i]=>Value[i];

public static A199894Inst Instance=new A199894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199895
{
public static readonly long[] Value={ 1L,11L,51L,351L,2031L,13363L,82555L,536967L,3409609L,22163661L,142744843L,930121865L,6040974735L,39482258363L,257848379869L,1690142722447L,11081263427471L,72823380368573L,478876538926483L,3154101346620987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199895Inst : IEnumerable<long>
{
public static readonly long[] Value=A199895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199895.Bytes);
public long this[int i]=>Value[i];

public static A199895Inst Instance=new A199895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199896
{
public static readonly long[] Value={ 1L,13L,67L,545L,3573L,27457L,193689L,1462859L,10651367L,80142549L,593254327L,4466635929L,33386730231L,251884546233L,1894568061637L,14327147198653L,108231414777793L,820328179730055L,6216861991058925L,47216885967426099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199896Inst : IEnumerable<long>
{
public static readonly long[] Value=A199896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199896.Bytes);
public long this[int i]=>Value[i];

public static A199896Inst Instance=new A199896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199897
{
public static readonly long[] Value={ 1L,15L,85L,799L,5839L,51395L,406575L,3500269L,28684325L,245319361L,2048301005L,17499467353L,147731409251L,1263413909311L,10741266363733L,92019265611439L,786112365529335L,6747253002120179L,57843127733658007L,497375672047480891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199897Inst : IEnumerable<long>
{
public static readonly long[] Value=A199897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199897.Bytes);
public long this[int i]=>Value[i];

public static A199897Inst Instance=new A199897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199898
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,7L,15L,15L,1L,9L,25L,49L,33L,1L,11L,37L,111L,159L,75L,1L,13L,51L,209L,461L,533L,171L,1L,15L,67L,351L,1043L,2035L,1783L,391L,1L,17L,85L,545L,2031L,5725L,8823L,6027L,899L,1L,19L,105L,799L,3573L,13363L,30199L,39053L,20437L,2077L,1L,21L,127L,1121L,5839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199898Inst : IEnumerable<long>
{
public static readonly long[] Value=A199898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199898.Bytes);
public long this[int i]=>Value[i];

public static A199898Inst Instance=new A199898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199899
{
public static readonly long[] Value={ 15L,49L,111L,209L,351L,545L,799L,1121L,1519L,2001L,2575L,3249L,4031L,4929L,5951L,7105L,8399L,9841L,11439L,13201L,15135L,17249L,19551L,22049L,24751L,27665L,30799L,34161L,37759L,41601L,45695L,50049L,54671L,59569L,64751L,70225L,75999L,82081L,88479L,95201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199899Inst : IEnumerable<long>
{
public static readonly long[] Value=A199899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199899.Bytes);
public long this[int i]=>Value[i];

public static A199899Inst Instance=new A199899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199900
{
public static readonly long[] Value={ 33L,159L,461L,1043L,2031L,3573L,5839L,9021L,13333L,19011L,26313L,35519L,46931L,60873L,77691L,97753L,121449L,149191L,181413L,218571L,261143L,309629L,364551L,426453L,495901L,573483L,659809L,755511L,861243L,977681L,1105523L,1245489L,1398321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199900Inst : IEnumerable<long>
{
public static readonly long[] Value=A199900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199900.Bytes);
public long this[int i]=>Value[i];

public static A199900Inst Instance=new A199900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199901
{
public static readonly long[] Value={ 75L,533L,2035L,5725L,13363L,27457L,51395L,89577L,147547L,232125L,351539L,515557L,735619L,1024969L,1398787L,1874321L,2471019L,3210661L,4117491L,5218349L,6542803L,8123281L,9995203L,12197113L,14770811L,17761485L,21217843L,25192245L,29740835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199901Inst : IEnumerable<long>
{
public static readonly long[] Value=A199901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199901.Bytes);
public long this[int i]=>Value[i];

public static A199901Inst Instance=new A199901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199902
{
public static readonly long[] Value={ 171L,1783L,8823L,30199L,82555L,193689L,406575L,783989L,1413739L,2414499L,3942247L,6197307L,9431995L,13958869L,20159583L,28494345L,39511979L,53860591L,72298839L,95707807L,125103483L,161649841L,206672527L,261673149L,328344171L,408584411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199902Inst : IEnumerable<long>
{
public static readonly long[] Value=A199902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199902.Bytes);
public long this[int i]=>Value[i];

public static A199902Inst Instance=new A199902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199903
{
public static readonly long[] Value={ 1L,4L,12L,24L,82L,232L,654L,2044L,6096L,18564L,57500L,177032L,550098L,1715956L,5359158L,16799508L,52760640L,165976252L,523094304L,1650781728L,5216112586L,16501009804L,52252555938L,165618780196L,525388548976L,1667965025692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199903Inst : IEnumerable<long>
{
public static readonly long[] Value=A199903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199903.Bytes);
public long this[int i]=>Value[i];

public static A199903Inst Instance=new A199903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199904
{
public static readonly long[] Value={ 1L,4L,24L,72L,256L,1312L,5206L,21208L,97668L,422052L,1819620L,8158144L,36110122L,159422584L,712790438L,3182921756L,14206099012L,63688577860L,285783359204L,1282956672032L,5770687400200L,25983122754016L,117074268243396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199904Inst : IEnumerable<long>
{
public static readonly long[] Value=A199904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199904.Bytes);
public long this[int i]=>Value[i];

public static A199904Inst Instance=new A199904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199905
{
public static readonly long[] Value={ 1L,6L,42L,152L,804L,5016L,24864L,139148L,814776L,4509164L,25781576L,149525280L,856571710L,4954153908L,28801991844L,167153096856L,973462118580L,5682734337828L,33191217303840L,194193233863080L,1137757795417530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199905Inst : IEnumerable<long>
{
public static readonly long[] Value=A199905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199905.Bytes);
public long this[int i]=>Value[i];

public static A199905Inst Instance=new A199905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199906
{
public static readonly long[] Value={ 1L,8L,60L,256L,1836L,12872L,77874L,547604L,3784512L,25525476L,179010266L,1249682864L,8709865930L,61360521500L,432263649142L,3049721406636L,21595190691722L,153069769124720L,1086568858888600L,7726348605601340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199906Inst : IEnumerable<long>
{
public static readonly long[] Value=A199906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199906.Bytes);
public long this[int i]=>Value[i];

public static A199906Inst Instance=new A199906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199907
{
public static readonly long[] Value={ 1L,8L,84L,448L,3196L,29864L,216530L,1699268L,14546928L,116482068L,950119628L,7969545520L,65812921362L,546169532636L,4575686136942L,38231452993064L,320077674218718L,2689588505089064L,22606933344228744L,190257872374203952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199907Inst : IEnumerable<long>
{
public static readonly long[] Value=A199907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199907.Bytes);
public long this[int i]=>Value[i];

public static A199907Inst Instance=new A199907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199908
{
public static readonly long[] Value={ 1L,10L,114L,680L,6064L,62776L,518560L,4854740L,47329800L,436295060L,4163000530L,40224691008L,383919683336L,3702037559404L,35864644194258L,346836775041832L,3366637367524806L,32752033994479420L,318790073410891420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199908Inst : IEnumerable<long>
{
public static readonly long[] Value=A199908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199908.Bytes);
public long this[int i]=>Value[i];

public static A199908Inst Instance=new A199908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199909
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,4L,12L,8L,1L,6L,24L,24L,14L,1L,8L,42L,72L,82L,32L,1L,8L,60L,152L,256L,232L,56L,1L,10L,84L,256L,804L,1312L,654L,100L,1L,12L,114L,448L,1836L,5016L,5206L,2044L,204L,1L,12L,144L,680L,3196L,12872L,24864L,21208L,6096L,388L,1L,14L,180L,952L,6064L,29864L,77874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199909Inst : IEnumerable<long>
{
public static readonly long[] Value=A199909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199909.Bytes);
public long this[int i]=>Value[i];

public static A199909Inst Instance=new A199909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199910
{
public static readonly long[] Value={ 6L,12L,24L,42L,60L,84L,114L,144L,180L,222L,264L,312L,366L,420L,480L,546L,612L,684L,762L,840L,924L,1014L,1104L,1200L,1302L,1404L,1512L,1626L,1740L,1860L,1986L,2112L,2244L,2382L,2520L,2664L,2814L,2964L,3120L,3282L,3444L,3612L,3786L,3960L,4140L,4326L,4512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199910Inst : IEnumerable<long>
{
public static readonly long[] Value=A199910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199910.Bytes);
public long this[int i]=>Value[i];

public static A199910Inst Instance=new A199910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199911
{
public static readonly long[] Value={ 8L,24L,72L,152L,256L,448L,680L,952L,1384L,1848L,2368L,3136L,3912L,4760L,5960L,7128L,8384L,10112L,11752L,13496L,15848L,18040L,20352L,23424L,26248L,29208L,33096L,36632L,40320L,45120L,49448L,53944L,59752L,64952L,70336L,77248L,83400L,89752L,97864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199911Inst : IEnumerable<long>
{
public static readonly long[] Value=A199911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199911.Bytes);
public long this[int i]=>Value[i];

public static A199911Inst Instance=new A199911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199912
{
public static readonly long[] Value={ 14L,82L,256L,804L,1836L,3196L,6064L,10276L,14846L,23154L,34096L,44912L,63114L,85670L,106780L,140664L,181052L,217516L,274204L,339976L,397866L,485814L,585856L,672256L,801254L,945786L,1068792L,1249964L,1450540L,1619260L,1865064L,2134572L,2359126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199912Inst : IEnumerable<long>
{
public static readonly long[] Value=A199912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199912.Bytes);
public long this[int i]=>Value[i];

public static A199912Inst Instance=new A199912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199913
{
public static readonly long[] Value={ 32L,232L,1312L,5016L,12872L,29864L,62776L,114768L,200520L,335216L,522160L,792880L,1174320L,1666712L,2327312L,3198184L,4271544L,5640984L,7367048L,9427264L,11963896L,15059328L,18668000L,22994912L,28147648L,34047432L,40977792L,49074872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199913Inst : IEnumerable<long>
{
public static readonly long[] Value=A199913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199913.Bytes);
public long this[int i]=>Value[i];

public static A199913Inst Instance=new A199913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199914
{
public static readonly long[] Value={ 56L,654L,5206L,24864L,77874L,216530L,518560L,1071202L,2114394L,3876376L,6593960L,10975656L,17458840L,26545266L,39896954L,58112992L,82129122L,115325122L,158200672L,212380574L,284094678L,373133880L,482198944L,621972384L,790417208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199914Inst : IEnumerable<long>
{
public static readonly long[] Value=A199914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199914.Bytes);
public long this[int i]=>Value[i];

public static A199914Inst Instance=new A199914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199915
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,1L,2L,3L,1L,2L,7L,5L,6L,1L,7L,10L,21L,14L,10L,1L,10L,38L,48L,51L,35L,15L,1L,38L,89L,135L,168L,120L,76L,21L,1L,89L,229L,441L,458L,474L,281L,147L,28L,1L,229L,752L,1121L,1604L,1475L,1188L,637L,260L,36L,1L,752L,1873L,3692L,4772L,5100L,4329L,2800L,1366L,429L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199915Inst : IEnumerable<long>
{
public static readonly long[] Value=A199915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199915.Bytes);
public long this[int i]=>Value[i];

public static A199915Inst Instance=new A199915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199916
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-5L,0L,1L,1L,0L,-14L,0L,1L,0L,21L,0L,-30L,0L,1L,-1L,0L,147L,0L,-55L,0L,1L,0L,-85L,0L,627L,0L,-91L,0L,1L,1L,0L,-1408L,0L,2002L,0L,-140L,0L,1L,0L,341L,0L,-11440L,0L,5278L,0L,-204L,0L,1L,-1L,0L,13013L,0L,-61490L,0L,12138L,0L,-285L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199916Inst : IEnumerable<long>
{
public static readonly long[] Value=A199916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199916.Bytes);
public long this[int i]=>Value[i];

public static A199916Inst Instance=new A199916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199917
{
public static readonly BigInteger[] Value={ 0L,1L,0L,-1L,0L,-7L,0L,-23L,0L,-5947L,0L,-140759L,0L,-8265391L,0L,133286519L,0L,1088222737541L,0L,4970981405216383L,0L,7294918534710727L,0L,BigInteger.Parse("-32299178524632916333"),0L,BigInteger.Parse("-944164720798082858723567"),0L,BigInteger.Parse("2252653730296347607326319"),0L,BigInteger.Parse("1968938229271096381309083587") };
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
public class A199917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199917Inst Instance=new A199917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199918
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199918Inst : IEnumerable<long>
{
public static readonly long[] Value=A199918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199918.Bytes);
public long this[int i]=>Value[i];

public static A199918Inst Instance=new A199918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199919
{
public static readonly long[] Value={ 3L,7L,9L,15L,9L,25L,9L,31L,27L,37L,9L,57L,9L,49L,49L,63L,9L,79L,9L,85L,65L,49L,9L,121L,27L,49L,81L,113L,9L,145L,9L,127L,81L,49L,69L,183L,9L,49L,81L,181L,9L,193L,9L,169L,157L,49L,9L,249L,27L,187L,81L,197L,9L,241L,69L,241L,81L,49L,9L,337L,9L,49L,209L,255L,81L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199919Inst : IEnumerable<long>
{
public static readonly long[] Value=A199919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199919.Bytes);
public long this[int i]=>Value[i];

public static A199919Inst Instance=new A199919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199920
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,1L,2L,0L,3L,1L,3L,2L,2L,2L,3L,2L,2L,1L,2L,3L,3L,3L,1L,1L,3L,2L,4L,1L,2L,2L,3L,3L,3L,2L,4L,2L,4L,3L,3L,5L,3L,3L,3L,3L,4L,5L,3L,3L,3L,3L,5L,4L,4L,3L,4L,3L,3L,2L,3L,6L,5L,4L,2L,1L,3L,5L,5L,5L,2L,2L,3L,5L,3L,5L,4L,5L,2L,3L,2L,5L,5L,6L,4L,2L,3L,3L,4L,3L,3L,5L,4L,3L,1L,1L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199920Inst : IEnumerable<long>
{
public static readonly long[] Value=A199920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199920.Bytes);
public long this[int i]=>Value[i];

public static A199920Inst Instance=new A199920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199921
{
public static readonly long[] Value={ 7L,31L,93L,215L,389L,573L,691L,691L,573L,389L,215L,93L,31L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199921Inst : IEnumerable<long>
{
public static readonly long[] Value=A199921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199921.Bytes);
public long this[int i]=>Value[i];

public static A199921Inst Instance=new A199921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199922
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,27L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,27L,81L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,27L,1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199922Inst : IEnumerable<long>
{
public static readonly long[] Value=A199922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199922.Bytes);
public long this[int i]=>Value[i];

public static A199922Inst Instance=new A199922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199923
{
public static readonly long[] Value={ 1L,2L,8L,30L,108L,378L,1296L,4374L,14580L,48114L,157464L,511758L,1653372L,5314410L,17006112L,54206982L,172186884L,545258466L,1721868840L,5423886846L,17046501516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199923Inst : IEnumerable<long>
{
public static readonly long[] Value=A199923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199923.Bytes);
public long this[int i]=>Value[i];

public static A199923Inst Instance=new A199923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199924
{
public static readonly long[] Value={ 948L,1560L,1772L,2153L,2697L,8487L,11293L,12553L,13236L,18065L,32247L,36984L,40452L,43999L,55945L,94536L,100512L,107607L,127224L,134223L,214641L,218783L,366937L,425808L,429855L,595471L,620865L,645327L,757382L,850416L,875784L,1241106L,1330849L,1363977L,1387689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199924Inst : IEnumerable<long>
{
public static readonly long[] Value=A199924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199924.Bytes);
public long this[int i]=>Value[i];

public static A199924Inst Instance=new A199924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199925
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,8L,14L,25L,45L,80L,142L,253L,450L,800L,1423L,2531L,4501L,8005L,14237L,25320L,45031L,80087L,142433L,253314L,450514L,801230L,1424971L,2534282L,4507169L,8015908L,14256129L,25354235L,45091990L,80195185L,142625502L,253656548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199925Inst : IEnumerable<long>
{
public static readonly long[] Value=A199925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199925.Bytes);
public long this[int i]=>Value[i];

public static A199925Inst Instance=new A199925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199926
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,4L,6L,11L,20L,35L,62L,111L,197L,350L,623L,1108L,1970L,3504L,6232L,11083L,19711L,35056L,62346L,110881L,197200L,350716L,623741L,1109311L,1972887L,3508739L,6240221L,11098106L,19737755L,35103195L,62430317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199926Inst : IEnumerable<long>
{
public static readonly long[] Value=A199926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199926.Bytes);
public long this[int i]=>Value[i];

public static A199926Inst Instance=new A199926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199927
{
public static readonly long[] Value={ 1L,1L,-7L,3L,32L,-55L,-95L,399L,-11L,-2024L,2573L,7137L,-22015L,-9073L,123712L,-107499L,-498119L,1168399L,1090985L,-7323600L,3535193L,33005393L,-59095943L,-95072229L,420022144L,-36762335L,-2099324671L,2798230719L,7241608157L,-23295324088L,-8015161307L,128935159185L,-119396284895L,-509999348249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199927Inst : IEnumerable<long>
{
public static readonly long[] Value=A199927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199927.Bytes);
public long this[int i]=>Value[i];

public static A199927Inst Instance=new A199927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199928
{
public static readonly long[] Value={ 2L,-1L,-8L,15L,22L,-104L,17L,510L,-721L,-1708L,5806L,1503L,-31520L,31519L,121778L,-312396L,-233455L,1885694L,-1152593L,-8196936L,16079050L,21867343L,-109306936L,24246207L,528076766L,-780482080L,-1726348607L,6132589566L,1190594623L,-32799408980L,34705374038L,124349675919L,-331866549712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199928Inst : IEnumerable<long>
{
public static readonly long[] Value=A199928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199928.Bytes);
public long this[int i]=>Value[i];

public static A199928Inst Instance=new A199928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199929
{
public static readonly long[] Value={ 2L,-4L,-5L,27L,-8L,-128L,200L,405L,-1525L,-172L,8002L,-9072L,-29585L,83119L,47732L,-483840L,357884L,2025929L,-4346921L,-4941000L,28343650L,-10011500L,-132300829L,215642979L,407506016L,-1608010240L,-81576032L,8313490269L,-9921126365L,-30119890772L,88120588898L,44244248328L,-505045957225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199929Inst : IEnumerable<long>
{
public static readonly long[] Value=A199929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199929.Bytes);
public long this[int i]=>Value[i];

public static A199929Inst Instance=new A199929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199930
{
public static readonly long[] Value={ 1L,-2L,-1L,12L,-10L,-49L,112L,111L,-710L,316L,3233L,-5634L,-9505L,40592L,-1934L,-204897L,264664L,717295L,-2243578L,-873336L,12543857L,-11138050L,-50210993L,119318436L,108054622L,-743719745L,372976064L,3334358847L,-6051013534L,-9504084892L,42720535345L,-4585483266L,-212470264817L,287622301384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199930Inst : IEnumerable<long>
{
public static readonly long[] Value=A199930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199930.Bytes);
public long this[int i]=>Value[i];

public static A199930Inst Instance=new A199930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199931
{
public static readonly long[] Value={ -1L,2L,4L,-15L,-2L,79L,-88L,-294L,815L,488L,-4769L,3438L,20080L,-42527L,-49666L,278943L,-93220L,-1308634L,2103343L,4067664L,-15799793L,-1126550L,82089836L,-96324543L,-299451394L,864290495L,454552096L,-4979131422L,3870112831L,20615805880L,-45400053553L,-48829731594L,292575692408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199931Inst : IEnumerable<long>
{
public static readonly long[] Value=A199931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199931.Bytes);
public long this[int i]=>Value[i];

public static A199931Inst Instance=new A199931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199932
{
public static readonly long[] Value={ 1L,3L,5L,12L,17L,47L,65L,169L,279L,645L,1025L,2698L,4097L,9917L,17345L,39698L,65537L,161395L,262145L,624004L,1089007L,2449881L,4194305L,10097733L,16812683L,38754747L,69117097L,155178266L,268435457L,629929761L,1073741825L,2459703907L,4400500499L,9756737721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199932Inst : IEnumerable<long>
{
public static readonly long[] Value=A199932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199932.Bytes);
public long this[int i]=>Value[i];

public static A199932Inst Instance=new A199932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199933
{
public static readonly long[] Value={ 1L,1L,-4L,0L,20L,-25L,-71L,216L,94L,-1220L,1037L,4941L,-11440L,-11008L,72112L,-33453L,-326675L,577060L,950750L,-4129272L,279257L,20740793L,-27217100L,-72078336L,228625372L,83808415L,-1271796511L,1153458144L,5060707454L,-12183603100L,-10694679515L,75519944325L,-39290857304L,-336819940736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199933Inst : IEnumerable<long>
{
public static readonly long[] Value=A199933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199933.Bytes);
public long this[int i]=>Value[i];

public static A199933Inst Instance=new A199933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199934
{
public static readonly long[] Value={ 21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,153L,154L,155L,156L,157L,158L,159L,160L,161L,162L,203L,204L,205L,206L,207L,208L,209L,210L,211L,212L,275L,276L,277L,278L,279L,280L,281L,282L,283L,284L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199934Inst : IEnumerable<long>
{
public static readonly long[] Value=A199934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199934.Bytes);
public long this[int i]=>Value[i];

public static A199934Inst Instance=new A199934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199935
{
public static readonly long[] Value={ 0L,0L,2L,5L,9L,14L,22L,36L,60L,99L,161L,260L,420L,680L,1102L,1785L,2889L,4674L,7562L,12236L,19800L,32039L,51841L,83880L,135720L,219600L,355322L,574925L,930249L,1505174L,2435422L,3940596L,6376020L,10316619L,16692641L,27009260L,43701900L,70711160L,114413062L,185124225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199935Inst : IEnumerable<long>
{
public static readonly long[] Value=A199935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199935.Bytes);
public long this[int i]=>Value[i];

public static A199935Inst Instance=new A199935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199936
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,31L,52L,80L,133L,197L,298L,428L,621L,879L,1230L,1696L,2329L,3142L,4231L,5619L,7447L,9781L,12771L,16553L,21391L,27440L,35089L,44600L,56510L,71232L,89538L,112011L,139759L,173679L,215279L,265840L,327527L,402162L,492703L,601830L,733550L,891634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199936Inst : IEnumerable<long>
{
public static readonly long[] Value=A199936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199936.Bytes);
public long this[int i]=>Value[i];

public static A199936Inst Instance=new A199936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199937
{
public static readonly long[] Value={ 4L,12L,36L,104L,302L,868L,2490L,7132L,20424L,58418L,167036L,477412L,1364340L,3898236L,11138194L,31824012L,90926724L,259790792L,742259560L,2120727868L,6059178186L,17311798890L,49461883130L,141318491362L,403763748824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199937Inst : IEnumerable<long>
{
public static readonly long[] Value=A199937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199937.Bytes);
public long this[int i]=>Value[i];

public static A199937Inst Instance=new A199937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199938
{
public static readonly long[] Value={ 6L,30L,142L,660L,3042L,13890L,63260L,287514L,1305394L,5924042L,26877500L,121920302L,553009230L,2508114154L,11375127276L,51589452156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199938Inst : IEnumerable<long>
{
public static readonly long[] Value=A199938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199938.Bytes);
public long this[int i]=>Value[i];

public static A199938Inst Instance=new A199938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199939
{
public static readonly long[] Value={ 8L,56L,376L,2474L,16114L,104268L,672866L,4334232L,27893374L,179433990L,1154022716L,7420994944L,47717937374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199939Inst : IEnumerable<long>
{
public static readonly long[] Value=A199939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199939.Bytes);
public long this[int i]=>Value[i];

public static A199939Inst Instance=new A199939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199940
{
public static readonly long[] Value={ 10L,90L,778L,6604L,55540L,464782L,3879760L,32334096L,269266622L,2241467296L,18655194942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199940Inst : IEnumerable<long>
{
public static readonly long[] Value=A199940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199940.Bytes);
public long this[int i]=>Value[i];

public static A199940Inst Instance=new A199940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199941
{
public static readonly long[] Value={ 12L,132L,1404L,14696L,152586L,1577040L,16261206L,167447004L,1723164176L,17727091612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199941Inst : IEnumerable<long>
{
public static readonly long[] Value=A199941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199941.Bytes);
public long this[int i]=>Value[i];

public static A199941Inst Instance=new A199941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199942
{
public static readonly long[] Value={ 14L,182L,2294L,28490L,351148L,4310382L,52799912L,646091920L,7901341926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199942Inst : IEnumerable<long>
{
public static readonly long[] Value=A199942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199942.Bytes);
public long this[int i]=>Value[i];

public static A199942Inst Instance=new A199942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199943
{
public static readonly long[] Value={ 2L,4L,2L,6L,12L,2L,8L,30L,36L,2L,10L,56L,142L,104L,2L,12L,90L,376L,660L,302L,2L,14L,132L,778L,2474L,3042L,868L,2L,16L,182L,1404L,6604L,16114L,13890L,2490L,2L,18L,240L,2294L,14696L,55540L,104268L,63260L,7132L,2L,20L,306L,3504L,28490L,152586L,464782L,672866L,287514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199943Inst : IEnumerable<long>
{
public static readonly long[] Value=A199943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199943.Bytes);
public long this[int i]=>Value[i];

public static A199943Inst Instance=new A199943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199944
{
public static readonly long[] Value={ 2L,36L,142L,376L,778L,1404L,2294L,3504L,5074L,7060L,9502L,12456L,15962L,20076L,24838L,30304L,36514L,43524L,51374L,60120L,69802L,80476L,92182L,104976L,118898L,134004L,150334L,167944L,186874L,207180L,228902L,252096L,276802L,303076L,330958L,360504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199944Inst : IEnumerable<long>
{
public static readonly long[] Value=A199944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199944.Bytes);
public long this[int i]=>Value[i];

public static A199944Inst Instance=new A199944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199945
{
public static readonly long[] Value={ 2L,104L,660L,2474L,6604L,14696L,28490L,50448L,83092L,129642L,193292L,278240L,388258L,528328L,703140L,918330L,1179228L,1492584L,1864202L,2301584L,2811588L,3402266L,4081084L,4857344L,5738882L,6735720L,7856884L,9112842L,10513196L,12069800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199945Inst : IEnumerable<long>
{
public static readonly long[] Value=A199945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199945.Bytes);
public long this[int i]=>Value[i];

public static A199945Inst Instance=new A199945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199946
{
public static readonly long[] Value={ 2L,302L,3042L,16114L,55540L,152586L,351148L,721324L,1351980L,2366612L,3910366L,6183420L,9398302L,13840734L,19819666L,27715966L,37936024L,50997474L,67408004L,87815888L,112883696L,143392012L,180139662L,224110176L,276233778L,337668358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199946Inst : IEnumerable<long>
{
public static readonly long[] Value=A199946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199946.Bytes);
public long this[int i]=>Value[i];

public static A199946Inst Instance=new A199946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199947
{
public static readonly long[] Value={ 2L,868L,13890L,104268L,464782L,1577040L,4310382L,10274388L,21921086L,43069520L,78878810L,137045852L,226914998L,361712248L,557412114L,834701940L,1217933582L,1739046456L,2432877362L,3344664408L,4524523614L,6033558944L,7938870746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199947Inst : IEnumerable<long>
{
public static readonly long[] Value=A199947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199947.Bytes);
public long this[int i]=>Value[i];

public static A199947Inst Instance=new A199947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199948
{
public static readonly long[] Value={ 2L,2490L,63260L,672866L,3879760L,16261206L,52799912L,146068736L,354811296L,782544732L,1588743870L,3033145320L,5471502126L,9441265238L,15658407444L,25110211642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199948Inst : IEnumerable<long>
{
public static readonly long[] Value=A199948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199948.Bytes);
public long this[int i]=>Value[i];

public static A199948Inst Instance=new A199948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199949
{
public static readonly long[] Value={ 6L,5L,9L,2L,6L,6L,0L,4L,5L,7L,6L,6L,9L,4L,6L,0L,7L,4L,5L,3L,7L,3L,4L,8L,5L,7L,9L,5L,6L,3L,0L,6L,7L,6L,1L,1L,6L,1L,5L,3L,2L,8L,0L,2L,1L,6L,4L,4L,5L,1L,6L,7L,9L,7L,3L,6L,0L,9L,4L,5L,1L,3L,0L,3L,1L,4L,1L,0L,7L,3L,6L,4L,4L,5L,5L,8L,7L,4L,2L,6L,6L,2L,4L,4L,0L,7L,1L,9L,5L,1L,9L,3L,1L,6L,4L,1L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199949Inst : IEnumerable<long>
{
public static readonly long[] Value=A199949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199949.Bytes);
public long this[int i]=>Value[i];

public static A199949Inst Instance=new A199949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199950
{
public static readonly long[] Value={ 1L,2L,7L,1L,0L,2L,6L,8L,0L,0L,8L,1L,5L,9L,4L,6L,0L,6L,4L,0L,0L,4L,7L,1L,8L,8L,4L,8L,0L,9L,7L,8L,5L,0L,2L,6L,8L,3L,5L,6L,7L,1L,1L,8L,3L,7L,6L,7L,9L,9L,9L,2L,6L,8L,7L,3L,8L,7L,9L,6L,8L,1L,1L,5L,1L,0L,2L,3L,1L,8L,6L,7L,8L,7L,9L,3L,0L,1L,8L,4L,4L,1L,3L,4L,8L,9L,7L,8L,1L,8L,9L,6L,1L,6L,3L,0L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199950Inst : IEnumerable<long>
{
public static readonly long[] Value=A199950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199950.Bytes);
public long this[int i]=>Value[i];

public static A199950Inst Instance=new A199950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199951
{
public static readonly long[] Value={ 3L,6L,3L,5L,6L,0L,5L,3L,9L,8L,5L,8L,9L,5L,9L,2L,6L,6L,2L,5L,7L,3L,2L,1L,4L,8L,3L,7L,2L,2L,8L,4L,3L,9L,8L,5L,6L,6L,8L,9L,5L,7L,9L,0L,7L,4L,2L,5L,0L,8L,4L,0L,8L,0L,7L,4L,4L,2L,0L,4L,5L,7L,1L,8L,4L,0L,3L,1L,3L,4L,0L,6L,6L,8L,8L,6L,2L,2L,7L,6L,2L,6L,7L,4L,1L,8L,8L,9L,9L,6L,0L,8L,8L,5L,1L,2L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199951Inst : IEnumerable<long>
{
public static readonly long[] Value=A199951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199951.Bytes);
public long this[int i]=>Value[i];

public static A199951Inst Instance=new A199951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199952
{
public static readonly long[] Value={ 1L,7L,7L,1L,7L,9L,2L,9L,5L,2L,9L,8L,2L,0L,2L,6L,3L,3L,7L,2L,6L,5L,9L,2L,3L,5L,8L,6L,4L,4L,9L,0L,9L,4L,2L,1L,6L,2L,2L,0L,1L,5L,8L,2L,4L,5L,5L,1L,8L,6L,3L,0L,8L,9L,1L,8L,9L,2L,1L,1L,4L,7L,0L,0L,9L,3L,4L,5L,2L,5L,6L,5L,1L,6L,7L,0L,3L,5L,0L,8L,1L,3L,9L,7L,8L,1L,6L,1L,4L,4L,3L,8L,7L,0L,4L,5L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199952Inst : IEnumerable<long>
{
public static readonly long[] Value=A199952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199952.Bytes);
public long this[int i]=>Value[i];

public static A199952Inst Instance=new A199952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199953
{
public static readonly long[] Value={ 2L,6L,1L,5L,7L,3L,9L,3L,6L,4L,7L,4L,8L,1L,1L,3L,0L,2L,1L,2L,2L,9L,6L,4L,2L,0L,1L,7L,8L,3L,1L,2L,1L,1L,6L,0L,3L,9L,7L,8L,2L,8L,5L,9L,1L,3L,8L,4L,8L,6L,7L,6L,7L,1L,5L,3L,4L,2L,1L,3L,6L,8L,5L,6L,7L,6L,5L,2L,1L,0L,9L,0L,9L,6L,7L,0L,9L,2L,1L,2L,9L,5L,8L,5L,1L,2L,1L,9L,9L,4L,6L,8L,6L,6L,9L,1L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199953Inst : IEnumerable<long>
{
public static readonly long[] Value=A199953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199953.Bytes);
public long this[int i]=>Value[i];

public static A199953Inst Instance=new A199953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199954
{
public static readonly long[] Value={ 2L,0L,1L,1L,1L,3L,7L,3L,4L,2L,2L,2L,9L,3L,3L,0L,8L,4L,6L,0L,0L,2L,5L,0L,6L,5L,4L,0L,8L,7L,9L,6L,3L,9L,3L,8L,8L,6L,3L,0L,0L,8L,4L,0L,8L,3L,8L,7L,3L,6L,0L,3L,0L,2L,4L,5L,8L,3L,9L,1L,4L,5L,9L,0L,1L,5L,3L,4L,4L,8L,6L,5L,5L,4L,5L,4L,0L,4L,2L,8L,5L,6L,1L,9L,7L,0L,4L,3L,0L,7L,4L,0L,8L,0L,4L,5L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199954Inst : IEnumerable<long>
{
public static readonly long[] Value=A199954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199954.Bytes);
public long this[int i]=>Value[i];

public static A199954Inst Instance=new A199954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199955
{
public static readonly long[] Value={ 7L,4L,0L,8L,0L,3L,3L,6L,8L,1L,9L,4L,1L,3L,2L,2L,3L,7L,5L,9L,6L,4L,2L,6L,9L,2L,4L,5L,4L,7L,0L,2L,1L,6L,2L,0L,9L,1L,7L,4L,2L,2L,2L,8L,9L,0L,7L,8L,0L,2L,3L,4L,5L,7L,2L,1L,8L,9L,5L,4L,4L,9L,0L,1L,2L,0L,5L,4L,3L,8L,4L,6L,0L,9L,7L,7L,9L,3L,0L,5L,3L,8L,2L,4L,5L,9L,1L,8L,8L,0L,7L,9L,2L,0L,2L,3L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199955Inst : IEnumerable<long>
{
public static readonly long[] Value=A199955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199955.Bytes);
public long this[int i]=>Value[i];

public static A199955Inst Instance=new A199955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199956
{
public static readonly long[] Value={ 1L,8L,5L,4L,7L,7L,8L,4L,1L,0L,3L,5L,6L,7L,5L,1L,7L,7L,4L,1L,4L,1L,9L,3L,9L,5L,8L,1L,7L,3L,6L,9L,9L,8L,7L,6L,1L,2L,0L,4L,0L,2L,7L,3L,4L,6L,6L,2L,5L,0L,8L,3L,5L,1L,5L,6L,1L,8L,5L,4L,3L,4L,9L,8L,5L,1L,4L,3L,3L,5L,0L,3L,4L,7L,8L,0L,5L,7L,7L,0L,2L,7L,3L,9L,6L,7L,0L,0L,4L,1L,6L,7L,4L,8L,0L,9L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199956Inst : IEnumerable<long>
{
public static readonly long[] Value=A199956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199956.Bytes);
public long this[int i]=>Value[i];

public static A199956Inst Instance=new A199956Inst();

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