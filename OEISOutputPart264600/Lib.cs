using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A240659
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,2L,0L,0L,7L,0L,9L,5L,0L,0L,13L,0L,15L,0L,0L,0L,0L,0L,0L,12L,25L,0L,0L,9L,7L,0L,0L,17L,0L,37L,0L,13L,0L,0L,43L,0L,45L,0L,24L,49L,0L,0L,0L,0L,19L,0L,0L,6L,0L,4L,0L,67L,0L,23L,0L,0L,73L,0L,0L,39L,79L,0L,0L,0L,87L,22L,0L,0L,93L,0L,0L,97L,11L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240659Inst : IEnumerable<long>
{
public static readonly long[] Value=A240659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240659.Bytes);
public long this[int i]=>Value[i];

public static A240659Inst Instance=new A240659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240660
{
public static readonly long[] Value={ 1L,1L,0L,3L,0L,2L,8L,0L,11L,7L,0L,18L,10L,21L,23L,26L,0L,15L,11L,0L,36L,0L,41L,22L,48L,0L,51L,53L,0L,56L,21L,0L,68L,0L,0L,0L,78L,27L,83L,86L,0L,0L,0L,96L,98L,0L,0L,111L,113L,57L,116L,0L,20L,0L,128L,131L,0L,0L,138L,70L,141L,146L,153L,0L,4L,158L,0L,56L,173L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240660Inst : IEnumerable<long>
{
public static readonly long[] Value=A240660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240660.Bytes);
public long this[int i]=>Value[i];

public static A240660Inst Instance=new A240660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240661
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,6L,8L,0L,0L,7L,3L,2L,20L,0L,0L,13L,29L,30L,0L,0L,18L,39L,41L,44L,6L,5L,51L,53L,54L,56L,63L,65L,68L,0L,0L,75L,78L,0L,0L,0L,89L,30L,0L,48L,7L,99L,0L,111L,113L,114L,116L,0L,10L,125L,128L,0L,67L,135L,138L,28L,0L,73L,0L,0L,26L,79L,0L,28L,173L,58L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240661Inst : IEnumerable<long>
{
public static readonly long[] Value=A240661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240661.Bytes);
public long this[int i]=>Value[i];

public static A240661Inst Instance=new A240661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240662
{
public static readonly long[] Value={ 1L,0L,2L,0L,5L,6L,8L,0L,11L,0L,0L,0L,20L,3L,0L,13L,0L,30L,33L,35L,12L,39L,0L,44L,48L,50L,0L,53L,0L,7L,63L,0L,34L,0L,37L,75L,26L,81L,0L,86L,89L,6L,5L,12L,49L,0L,105L,0L,0L,114L,58L,119L,120L,0L,128L,131L,134L,0L,69L,10L,0L,146L,0L,0L,52L,79L,55L,28L,173L,174L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240662Inst : IEnumerable<long>
{
public static readonly long[] Value=A240662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240662.Bytes);
public long this[int i]=>Value[i];

public static A240662Inst Instance=new A240662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240663
{
public static readonly long[] Value={ 0L,1L,2L,0L,5L,2L,4L,3L,0L,14L,0L,6L,10L,7L,0L,26L,29L,10L,11L,0L,0L,0L,41L,0L,8L,50L,0L,53L,6L,14L,0L,65L,34L,23L,74L,0L,26L,27L,0L,86L,89L,30L,0L,16L,98L,0L,35L,0L,113L,38L,0L,0L,4L,25L,8L,0L,134L,0L,46L,35L,47L,146L,17L,0L,26L,158L,5L,0L,173L,58L,44L,0L,0L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240663Inst : IEnumerable<long>
{
public static readonly long[] Value=A240663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240663.Bytes);
public long this[int i]=>Value[i];

public static A240663Inst Instance=new A240663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240664
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,4L,0L,0L,7L,0L,0L,2L,0L,0L,13L,0L,0L,0L,0L,3L,0L,0L,22L,12L,25L,0L,0L,0L,28L,0L,0L,34L,0L,37L,0L,0L,0L,0L,43L,0L,0L,0L,4L,49L,0L,0L,0L,0L,0L,58L,0L,30L,0L,64L,0L,67L,0L,0L,70L,0L,73L,0L,0L,0L,79L,0L,42L,0L,0L,88L,0L,0L,0L,0L,0L,97L,0L,100L,51L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240664Inst : IEnumerable<long>
{
public static readonly long[] Value=A240664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240664.Bytes);
public long this[int i]=>Value[i];

public static A240664Inst Instance=new A240664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240665
{
public static readonly long[] Value={ 0L,0L,0L,3L,1L,3L,8L,9L,11L,14L,0L,0L,0L,0L,23L,0L,29L,30L,0L,0L,4L,0L,0L,22L,48L,2L,17L,0L,54L,56L,21L,65L,4L,23L,74L,0L,39L,0L,83L,0L,89L,90L,0L,96L,49L,0L,15L,111L,0L,114L,116L,0L,15L,25L,128L,131L,134L,0L,0L,14L,0L,73L,0L,0L,156L,0L,55L,168L,0L,58L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240665Inst : IEnumerable<long>
{
public static readonly long[] Value=A240665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240665.Bytes);
public long this[int i]=>Value[i];

public static A240665Inst Instance=new A240665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240666
{
public static readonly long[] Value={ 3L,2L,2L,3L,2L,2L,2L,2L,5L,2L,3L,2L,2L,2L,5L,2L,2L,2L,2L,7L,3L,3L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,3L,2L,2L,5L,2L,2L,2L,7L,2L,2L,3L,2L,3L,2L,2L,3L,7L,2L,2L,2L,5L,2L,3L,2L,2L,2L,2L,2L,11L,2L,2L,2L,3L,2L,2L,2L,7L,3L,2L,2L,5L,2L,2L,2L,2L,2L,2L,7L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240666Inst : IEnumerable<long>
{
public static readonly long[] Value=A240666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240666.Bytes);
public long this[int i]=>Value[i];

public static A240666Inst Instance=new A240666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240667
{
public static readonly long[] Value={ 1L,0L,2L,3L,0L,5L,4L,7L,0L,0L,0L,1L,9L,13L,8L,0L,0L,1L,0L,19L,0L,0L,0L,1L,0L,0L,0L,12L,0L,29L,1L,1L,0L,0L,0L,22L,0L,37L,18L,27L,0L,1L,0L,43L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,49L,0L,0L,1L,0L,61L,32L,0L,0L,0L,0L,67L,0L,0L,0L,1L,0L,73L,0L,0L,0L,45L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240667Inst : IEnumerable<long>
{
public static readonly long[] Value=A240667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240667.Bytes);
public long this[int i]=>Value[i];

public static A240667Inst Instance=new A240667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240668
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,0L,2L,1L,0L,0L,2L,0L,1L,2L,0L,1L,0L,0L,2L,0L,3L,3L,0L,0L,1L,2L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,5L,0L,1L,0L,0L,3L,0L,1L,1L,0L,2L,0L,0L,2L,1L,0L,0L,3L,0L,1L,2L,0L,3L,0L,0L,2L,0L,5L,2L,0L,0L,1L,3L,0L,1L,0L,0L,2L,0L,1L,1L,0L,1L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240668Inst : IEnumerable<long>
{
public static readonly long[] Value=A240668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240668.Bytes);
public long this[int i]=>Value[i];

public static A240668Inst Instance=new A240668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240669
{
public static readonly long[] Value={ 1L,0L,3L,4L,4L,0L,1L,0L,2L,0L,1L,1L,0L,2L,10L,11L,1L,0L,1L,1L,0L,2L,2L,0L,2L,1L,2L,0L,0L,3L,0L,0L,2L,0L,4L,1L,0L,2L,1L,0L,1L,5L,2L,0L,0L,6L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,3L,2L,0L,0L,1L,0L,0L,3L,3L,0L,1L,1L,0L,2L,1L,0L,8L,1L,1L,0L,0L,1L,0L,2L,0L,1L,2L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240669Inst : IEnumerable<long>
{
public static readonly long[] Value=A240669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240669.Bytes);
public long this[int i]=>Value[i];

public static A240669Inst Instance=new A240669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240670
{
public static readonly long[] Value={ 1L,3L,4L,5L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240670Inst : IEnumerable<long>
{
public static readonly long[] Value=A240670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240670.Bytes);
public long this[int i]=>Value[i];

public static A240670Inst Instance=new A240670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240671
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,12L,15L,18L,22L,28L,34L,42L,52L,64L,79L,98L,121L,149L,183L,226L,279L,343L,423L,521L,642L,791L,975L,1201L,1480L,1823L,2246L,2767L,3409L,4199L,5173L,6373L,7851L,9672L,11915L,14679L,18083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240671Inst : IEnumerable<long>
{
public static readonly long[] Value=A240671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240671.Bytes);
public long this[int i]=>Value[i];

public static A240671Inst Instance=new A240671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240720
{
public static readonly long[] Value={ 2L,5L,14L,46L,58L,105L,157L,163L,455L,1060L,1256L,2677L,8093L,28277L,33327L,49304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240720Inst : IEnumerable<long>
{
public static readonly long[] Value=A240720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240720.Bytes);
public long this[int i]=>Value[i];

public static A240720Inst Instance=new A240720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240721
{
public static readonly long[] Value={ 1L,7L,49L,351L,2561L,18943L,141569L,1066495L,8085505L,61616127L,471556097L,3621830655L,27902803969L,215530668031L,1668644405249L,12944666918911L,100598145875969L,783027553697791L,6103529011806209L,47636654222999551L,372225072921837569L,2911581699143892991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240721Inst : IEnumerable<long>
{
public static readonly long[] Value=A240721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240721.Bytes);
public long this[int i]=>Value[i];

public static A240721Inst Instance=new A240721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240722
{
public static readonly long[] Value={ 1L,7L,46L,323L,2326L,17062L,126764L,950819L,7184422L,54604082L,416990564L,3197008718L,24592858876L,189719297068L,1467180979096L,11370769197347L,88291427756294L,686715981892666L,5349188181210548L,41723881423351898L,325845079538136596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240722Inst : IEnumerable<long>
{
public static readonly long[] Value=A240722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240722.Bytes);
public long this[int i]=>Value[i];

public static A240722Inst Instance=new A240722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240723
{
public static readonly long[] Value={ 5L,9L,7L,1L,1L,9L,6L,5L,9L,9L,9L,6L,3L,6L,5L,5L,3L,3L,4L,3L,7L,5L,0L,6L,3L,6L,5L,6L,8L,7L,4L,0L,5L,3L,2L,0L,3L,3L,9L,5L,5L,4L,4L,1L,3L,0L,4L,4L,5L,8L,4L,4L,8L,9L,5L,8L,5L,5L,6L,9L,1L,3L,0L,1L,1L,8L,3L,3L,7L,4L,6L,3L,2L,4L,8L,0L,8L,2L,6L,2L,1L,1L,6L,7L,5L,7L,8L,5L,1L,7L,8L,5L,6L,0L,3L,9L,1L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240723Inst : IEnumerable<long>
{
public static readonly long[] Value=A240723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240723.Bytes);
public long this[int i]=>Value[i];

public static A240723Inst Instance=new A240723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240724
{
public static readonly long[] Value={ 19L,29L,41L,53L,71L,97L,127L,157L,181L,199L,211L,223L,241L,269L,293L,311L,337L,373L,433L,479L,521L,547L,571L,601L,631L,661L,683L,701L,743L,787L,827L,907L,983L,1061L,1091L,1171L,1279L,1399L,1487L,1543L,1601L,1657L,1721L,1777L,1831L,1987L,2131L,2269L,2347L,2417L,2477L,2539L,2659L,2797L,2897L,2963L,3083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240724Inst : IEnumerable<long>
{
public static readonly long[] Value=A240724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240724.Bytes);
public long this[int i]=>Value[i];

public static A240724Inst Instance=new A240724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240725
{
public static readonly long[] Value={ 23L,31L,43L,521L,1061L,2153L,3457L,4019L,4943L,5477L,6991L,7577L,8291L,8539L,10993L,11953L,14767L,17957L,18439L,26321L,40993L,41047L,53269L,57917L,71347L,79979L,80989L,88997L,91499L,92269L,94561L,108457L,109111L,112019L,117671L,121763L,133103L,140407L,147073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240725Inst : IEnumerable<long>
{
public static readonly long[] Value=A240725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240725.Bytes);
public long this[int i]=>Value[i];

public static A240725Inst Instance=new A240725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240726
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,6L,9L,13L,18L,25L,32L,44L,58L,78L,102L,131L,166L,219L,277L,353L,446L,566L,696L,882L,1089L,1362L,1667L,2071L,2525L,3109L,3766L,4614L,5583L,6789L,8163L,9886L,11857L,14276L,17043L,20437L,24318L,29049L,34456L,40970L,48477L,57453L,67739L,80009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240726Inst : IEnumerable<long>
{
public static readonly long[] Value=A240726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240726.Bytes);
public long this[int i]=>Value[i];

public static A240726Inst Instance=new A240726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240727
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,13L,17L,24L,31L,45L,57L,77L,98L,129L,166L,219L,271L,350L,439L,556L,689L,879L,1076L,1347L,1648L,2051L,2494L,3079L,3733L,4583L,5529L,6727L,8094L,9814L,11751L,14158L,16909L,20295L,24146L,28856L,34212L,40719L,48164L,57081L,67301L,79534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240727Inst : IEnumerable<long>
{
public static readonly long[] Value=A240727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240727.Bytes);
public long this[int i]=>Value[i];

public static A240727Inst Instance=new A240727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240728
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,4L,4L,6L,6L,13L,13L,19L,20L,27L,35L,53L,52L,73L,86L,110L,123L,183L,194L,258L,286L,384L,423L,554L,624L,817L,915L,1144L,1305L,1651L,1865L,2301L,2633L,3252L,3709L,4538L,5163L,6263L,7194L,8604L,9848L,11795L,13507L,16086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240728Inst : IEnumerable<long>
{
public static readonly long[] Value=A240728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240728.Bytes);
public long this[int i]=>Value[i];

public static A240728Inst Instance=new A240728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240729
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,2L,5L,4L,8L,7L,13L,11L,19L,19L,26L,28L,44L,40L,61L,63L,89L,91L,128L,127L,181L,188L,248L,258L,350L,357L,474L,497L,641L,674L,870L,906L,1167L,1229L,1537L,1634L,2058L,2163L,2691L,2866L,3523L,3753L,4603L,4883L,5969L,6372L,7676L,8226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240729Inst : IEnumerable<long>
{
public static readonly long[] Value=A240729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240729.Bytes);
public long this[int i]=>Value[i];

public static A240729Inst Instance=new A240729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240730
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,13L,17L,26L,34L,49L,64L,90L,116L,157L,205L,269L,341L,450L,566L,729L,913L,1164L,1447L,1831L,2255L,2822L,3470L,4307L,5254L,6485L,7875L,9646L,11669L,14209L,17107L,20731L,24848L,29956L,35801L,42949L,51116L,61098L,72484L,86268L,102035L,121001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240730Inst : IEnumerable<long>
{
public static readonly long[] Value=A240730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240730.Bytes);
public long this[int i]=>Value[i];

public static A240730Inst Instance=new A240730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240731
{
public static readonly long[] Value={ 1L,0L,1L,3L,5L,5L,11L,12L,22L,26L,42L,51L,79L,97L,138L,179L,241L,297L,410L,505L,666L,824L,1073L,1319L,1704L,2074L,2634L,3222L,4049L,4904L,6128L,7401L,9149L,11028L,13535L,16237L,19825L,23681L,28727L,34264L,41315L,49058L,58935L,69793L,83402L,98512L,117248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240731Inst : IEnumerable<long>
{
public static readonly long[] Value=A240731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240731.Bytes);
public long this[int i]=>Value[i];

public static A240731Inst Instance=new A240731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240732
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,12L,15L,20L,28L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240732Inst : IEnumerable<long>
{
public static readonly long[] Value=A240732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240732.Bytes);
public long this[int i]=>Value[i];

public static A240732Inst Instance=new A240732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240733
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,21L,32L,50L,78L,121L,187L,289L,448L,693L,1072L,1658L,2564L,3966L,6134L,9487L,14673L,22695L,35101L,54288L,83964L,129862L,200850L,310643L,480452L,743085L,1149282L,1777523L,2749182L,4251987L,6576279L,10171116L,15731022L,24330178L,37629950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240733Inst : IEnumerable<long>
{
public static readonly long[] Value=A240733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240733.Bytes);
public long this[int i]=>Value[i];

public static A240733Inst Instance=new A240733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240734
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,8L,11L,16L,22L,32L,46L,65L,92L,130L,185L,262L,371L,526L,745L,1056L,1496L,2119L,3001L,4251L,6021L,8528L,12080L,17110L,24236L,34328L,48622L,68869L,97547L,138166L,195700L,277191L,392616L,556104L,787670L,1115663L,1580234L,2238256L,3170284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240734Inst : IEnumerable<long>
{
public static readonly long[] Value=A240734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240734.Bytes);
public long this[int i]=>Value[i];

public static A240734Inst Instance=new A240734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240735
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,13L,17L,21L,27L,35L,44L,56L,71L,90L,115L,146L,185L,235L,298L,378L,479L,607L,770L,977L,1238L,1570L,1991L,2525L,3202L,4060L,5148L,6527L,8276L,10494L,13306L,16872L,21393L,27125L,34393L,43609L,55294L,70111L,88897L,112717L,142919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240735Inst : IEnumerable<long>
{
public static readonly long[] Value=A240735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240735.Bytes);
public long this[int i]=>Value[i];

public static A240735Inst Instance=new A240735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240816
{
public static readonly long[] Value={ 7L,0L,15L,165L,55L,14L,0L,0L,11L,12L,61L,38L,12L,13L,14L,2355L,31L,14L,14L,15L,16L,283L,64L,45L,15L,16L,18L,19L,1337L,369L,32L,16L,18L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240816Inst : IEnumerable<long>
{
public static readonly long[] Value=A240816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240816.Bytes);
public long this[int i]=>Value[i];

public static A240816Inst Instance=new A240816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240817
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,6L,7L,8L,8L,7L,5L,8L,12L,12L,9L,7L,16L,11L,8L,13L,24L,14L,9L,14L,15L,9L,20L,16L,17L,21L,26L,13L,23L,40L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240817Inst : IEnumerable<long>
{
public static readonly long[] Value=A240817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240817.Bytes);
public long this[int i]=>Value[i];

public static A240817Inst Instance=new A240817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240818
{
public static readonly long[] Value={ 6L,0L,162L,0L,56L,2349L,276L,1300L,84L,1245L,356L,408L,486L,470L,764L,1172L,258L,356L,805L,819L,1078L,2099L,470L,2593L,662L,1170L,665L,1085L,2104L,1417L,724L,1196L,1247L,1628L,648L,2240L,712L,2304L,1836L,1424L,1082L,2759L,1264L,1570L,2235L,1512L,1442L,2447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240818Inst : IEnumerable<long>
{
public static readonly long[] Value=A240818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240818.Bytes);
public long this[int i]=>Value[i];

public static A240818Inst Instance=new A240818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240819
{
public static readonly long[] Value={ 13L,29L,0L,29L,24L,50L,0L,332L,56L,848L,2936L,140L,370L,605L,1514L,532L,169L,360L,1784L,514L,713L,279L,817L,945L,973L,949L,932L,444L,1529L,420L,2345L,628L,517L,913L,713L,738L,1611L,1066L,1639L,727L,1256L,1140L,1336L,718L,941L,907L,2272L,606L,1152L,2091L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240819Inst : IEnumerable<long>
{
public static readonly long[] Value=A240819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240819.Bytes);
public long this[int i]=>Value[i];

public static A240819Inst Instance=new A240819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240820
{
public static readonly long[] Value={ 20L,71L,34L,0L,46L,34L,36L,39L,90L,0L,142L,70L,91L,94L,255L,2004L,306L,525L,259L,454L,304L,1866L,316L,198L,254L,297L,415L,3315L,348L,406L,397L,420L,903L,1226L,408L,589L,1294L,535L,490L,958L,1343L,477L,492L,915L,1378L,1723L,797L,1869L,745L,696L,863L,1070L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240820Inst : IEnumerable<long>
{
public static readonly long[] Value=A240820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240820.Bytes);
public long this[int i]=>Value[i];

public static A240820Inst Instance=new A240820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240821
{
public static readonly long[] Value={ 6L,0L,13L,162L,29L,20L,0L,0L,71L,27L,56L,29L,34L,35L,28L,2349L,24L,0L,28L,54L,41L,276L,50L,46L,44L,34L,55L,40L,1300L,0L,34L,0L,37L,68L,89L,44L,84L,332L,36L,60L,56L,43L,80L,93L,54L,1245L,56L,39L,44L,0L,48L,48L,71L,87L,57L,356L,848L,90L,46L,74L,68L,51L,55L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240821Inst : IEnumerable<long>
{
public static readonly long[] Value=A240821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240821.Bytes);
public long this[int i]=>Value[i];

public static A240821Inst Instance=new A240821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240822
{
public static readonly long[] Value={ 7L,0L,163L,0L,57L,2350L,277L,1301L,85L,1246L,357L,409L,487L,471L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240822Inst : IEnumerable<long>
{
public static readonly long[] Value=A240822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240822.Bytes);
public long this[int i]=>Value[i];

public static A240822Inst Instance=new A240822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240823
{
public static readonly long[] Value={ 14L,30L,0L,30L,25L,51L,0L,333L,57L,849L,2937L,141L,371L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240823Inst : IEnumerable<long>
{
public static readonly long[] Value=A240823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240823.Bytes);
public long this[int i]=>Value[i];

public static A240823Inst Instance=new A240823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240824
{
public static readonly long[] Value={ 21L,72L,35L,0L,47L,35L,37L,40L,91L,0L,143L,71L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240824Inst : IEnumerable<long>
{
public static readonly long[] Value=A240824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240824.Bytes);
public long this[int i]=>Value[i];

public static A240824Inst Instance=new A240824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240825
{
public static readonly long[] Value={ 7L,0L,14L,163L,30L,21L,0L,0L,72L,28L,57L,30L,35L,36L,29L,2350L,25L,0L,29L,55L,42L,277L,51L,47L,45L,35L,56L,41L,1301L,0L,35L,0L,38L,69L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240825Inst : IEnumerable<long>
{
public static readonly long[] Value=A240825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240825.Bytes);
public long this[int i]=>Value[i];

public static A240825Inst Instance=new A240825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240826
{
public static readonly long[] Value={ 0L,35L,969L,7770L,35990L,121485L,333375L,790244L,1679580L,3280455L,5989445L,10349790L,17083794L,27128465L,41674395L,62207880L,90556280L,128936619L,180007425L,246923810L,333395790L,443749845L,582993719L,756884460L,971999700L,1235812175L,1556767485L,1944365094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240826Inst : IEnumerable<long>
{
public static readonly long[] Value=A240826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240826.Bytes);
public long this[int i]=>Value[i];

public static A240826Inst Instance=new A240826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240827
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,9L,9L,7L,8L,9L,10L,11L,12L,15L,15L,15L,13L,14L,15L,18L,18L,18L,18L,18L,18L,14L,16L,18L,25L,26L,24L,23L,22L,24L,20L,24L,24L,29L,28L,30L,29L,29L,27L,30L,28L,30L,27L,33L,33L,36L,32L,33L,27L,36L,36L,43L,36L,36L,38L,36L,36L,33L,32L,36L,39L,50L,48L,45L,39L,42L,37L,40L,42L,49L,44L,48L,48L,53L,48L,47L,42L,48L,44L,53L,48L,57L,52L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240827Inst : IEnumerable<long>
{
public static readonly long[] Value=A240827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240827.Bytes);
public long this[int i]=>Value[i];

public static A240827Inst Instance=new A240827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240828
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,2L,6L,4L,8L,4L,10L,6L,12L,6L,14L,8L,16L,8L,18L,10L,20L,10L,22L,12L,24L,12L,26L,14L,28L,14L,30L,16L,32L,16L,34L,18L,36L,18L,38L,20L,40L,20L,42L,22L,44L,22L,46L,24L,48L,24L,50L,26L,52L,26L,54L,28L,56L,28L,58L,30L,60L,30L,62L,32L,64L,32L,66L,34L,68L,34L,70L,36L,72L,36L,74L,38L,76L,38L,78L,40L,80L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240828Inst : IEnumerable<long>
{
public static readonly long[] Value=A240828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240828.Bytes);
public long this[int i]=>Value[i];

public static A240828Inst Instance=new A240828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240829
{
public static readonly long[] Value={ -1L,0L,1L,3L,2L,4L,4L,7L,4L,7L,7L,9L,8L,9L,11L,10L,10L,13L,15L,13L,13L,13L,18L,15L,18L,18L,18L,18L,18L,23L,23L,20L,19L,23L,28L,27L,23L,25L,27L,28L,25L,26L,28L,30L,31L,32L,33L,33L,32L,34L,33L,38L,36L,39L,34L,36L,36L,39L,39L,39L,39L,44L,46L,46L,43L,46L,46L,44L,44L,49L,49L,49L,46L,51L,48L,51L,51L,54L,54L,54L,54L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240829Inst : IEnumerable<long>
{
public static readonly long[] Value=A240829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240829.Bytes);
public long this[int i]=>Value[i];

public static A240829Inst Instance=new A240829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240830
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,7L,7L,7L,7L,7L,7L,13L,13L,13L,13L,13L,13L,19L,13L,19L,19L,19L,19L,25L,19L,25L,19L,25L,25L,31L,25L,31L,25L,31L,25L,31L,31L,37L,31L,37L,31L,37L,37L,37L,37L,43L,37L,43L,43L,43L,43L,43L,43L,49L,49L,49L,49L,49L,49L,49L,55L,55L,55L,55L,55L,55L,61L,55L,61L,61L,61L,61L,67L,61L,67L,61L,67L,67L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240830Inst : IEnumerable<long>
{
public static readonly long[] Value=A240830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240830.Bytes);
public long this[int i]=>Value[i];

public static A240830Inst Instance=new A240830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240831
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,7L,1L,7L,1L,1L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,7L,7L,1L,7L,1L,7L,7L,7L,7L,7L,1L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,13L,7L,7L,7L,7L,7L,13L,7L,13L,7L,7L,7L,13L,7L,13L,7L,13L,7L,13L,7L,13L,7L,13L,7L,19L,7L,13L,7L,13L,7L,19L,7L,19L,7L,13L,7L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240831Inst : IEnumerable<long>
{
public static readonly long[] Value=A240831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240831.Bytes);
public long this[int i]=>Value[i];

public static A240831Inst Instance=new A240831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240880
{
public static readonly long[] Value={ 1L,1L,-6L,33L,-162L,666L,-1836L,-2079L,79542L,-741474L,4907628L,-24837030L,82449900L,53319060L,-3741922008L,38613958497L,-274566158298L,1475669401398L,-5211777090564L,-2356585871778L,240686500011588L,-2593621485808596L,19047621883804056L,-105353643788834598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240880Inst : IEnumerable<long>
{
public static readonly long[] Value=A240880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240880.Bytes);
public long this[int i]=>Value[i];

public static A240880Inst Instance=new A240880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240881
{
public static readonly BigInteger[] Value={ 1L,2L,9L,58L,401L,2952L,22759L,181358L,1481751L,12346102L,104505959L,896170608L,7768885801L,67972510202L,599449125609L,5323095489058L,47555513297801L,427127946025752L,3854618439044959L,34934658168463958L,317834095671077751L,2901725605879035502L,BigInteger.Parse("26575914921615695759") };
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
public class A240881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240881Inst Instance=new A240881Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240882
{
public static readonly long[] Value={ 6L,7L,9L,11L,15L,21L,23L,27L,33L,35L,47L,77L,83L,143L,167L,227L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240882Inst : IEnumerable<long>
{
public static readonly long[] Value=A240882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240882.Bytes);
public long this[int i]=>Value[i];

public static A240882Inst Instance=new A240882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240883
{
public static readonly long[] Value={ 0L,0L,2L,1L,2L,0L,2L,2L,2L,2L,4L,1L,2L,1L,3L,3L,2L,2L,4L,3L,4L,0L,2L,2L,2L,2L,4L,2L,3L,2L,4L,4L,2L,2L,4L,3L,4L,2L,4L,4L,4L,4L,6L,1L,2L,1L,3L,3L,2L,2L,4L,3L,4L,1L,3L,3L,3L,3L,5L,3L,4L,3L,5L,5L,2L,2L,4L,3L,4L,2L,4L,4L,4L,4L,6L,3L,4L,3L,5L,5L,4L,4L,6L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240883Inst : IEnumerable<long>
{
public static readonly long[] Value=A240883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240883.Bytes);
public long this[int i]=>Value[i];

public static A240883Inst Instance=new A240883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240884
{
public static readonly long[] Value={ 33L,74L,237L,371L,1055L,1397L,10901L,12443L,30287L,39899L,55613L,80453L,207149L,303041L,360467L,407999L,639797L,1230821L,1650053L,2056511L,2695349L,2873441L,3454427L,3956873L,9823349L,10384103L,13680599L,15844877L,16419449L,20608499L,22705373L,26508143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240884Inst : IEnumerable<long>
{
public static readonly long[] Value=A240884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240884.Bytes);
public long this[int i]=>Value[i];

public static A240884Inst Instance=new A240884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240885
{
public static readonly long[] Value={ 1L,2L,7L,5L,5L,4L,7L,7L,3L,6L,4L,1L,7L,2L,1L,5L,3L,7L,8L,8L,0L,1L,3L,4L,3L,1L,9L,7L,4L,6L,7L,8L,5L,4L,7L,9L,0L,7L,3L,0L,7L,8L,1L,4L,3L,7L,4L,9L,4L,7L,2L,6L,1L,4L,3L,9L,4L,4L,8L,7L,3L,2L,6L,4L,6L,3L,1L,6L,4L,6L,9L,2L,5L,6L,4L,3L,0L,0L,8L,6L,4L,1L,6L,0L,4L,6L,2L,5L,2L,7L,5L,9L,5L,4L,2L,9L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240885Inst : IEnumerable<long>
{
public static readonly long[] Value=A240885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240885.Bytes);
public long this[int i]=>Value[i];

public static A240885Inst Instance=new A240885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240886
{
public static readonly long[] Value={ 23L,31L,47L,59L,695689L,698471L,883517L,992609L,992737L,993037L,1314239L,1324361L,1324571L,1326511L,1327289L,1766291L,3174029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240886Inst : IEnumerable<long>
{
public static readonly long[] Value=A240886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240886.Bytes);
public long this[int i]=>Value[i];

public static A240886Inst Instance=new A240886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240887
{
public static readonly long[] Value={ 1L,4L,57L,2362L,245268L,64074526L,41971040844L,69012323813116L,284711573170326892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240887Inst : IEnumerable<long>
{
public static readonly long[] Value=A240887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240887.Bytes);
public long this[int i]=>Value[i];

public static A240887Inst Instance=new A240887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240888
{
public static readonly long[] Value={ 2L,11L,57L,289L,1485L,7609L,38981L,199761L,1023597L,5245049L,26876501L,137719297L,705694973L,3616090505L,18529407461L,94947553233L,486525966349L,2493034391385L,12774694280053L,65459511713057L,335424674724381L,1718767975363881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240888Inst : IEnumerable<long>
{
public static readonly long[] Value=A240888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240888.Bytes);
public long this[int i]=>Value[i];

public static A240888Inst Instance=new A240888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240889
{
public static readonly long[] Value={ 4L,36L,289L,2362L,19065L,154858L,1255585L,10186158L,82615013L,670126562L,5435464261L,44088312610L,357608156789L,2900631278142L,23527575671521L,190836751334954L,1547913820098569L,12555429390762018L,101839521640750945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240889Inst : IEnumerable<long>
{
public static readonly long[] Value=A240889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240889.Bytes);
public long this[int i]=>Value[i];

public static A240889Inst Instance=new A240889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240890
{
public static readonly long[] Value={ 8L,116L,1485L,19065L,245268L,3146755L,40424861L,519218802L,6669141957L,85661208693L,1100266812500L,14132294288479L,181521187277681L,2331535718787322L,29947240904675409L,384655164983132569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240890Inst : IEnumerable<long>
{
public static readonly long[] Value=A240890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240890.Bytes);
public long this[int i]=>Value[i];

public static A240890Inst Instance=new A240890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240891
{
public static readonly BigInteger[] Value={ 16L,376L,7609L,154858L,3146755L,64074526L,1302610899L,26501432610L,539075345618L,10966382557858L,223082242117552L,4538081394098364L,92316133808933027L,1877950089801487198L,BigInteger.Parse("38202362639765816422"),BigInteger.Parse("777135231123406032012") };
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
public class A240891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240891Inst Instance=new A240891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240892
{
public static readonly BigInteger[] Value={ 32L,1216L,38981L,1255585L,40424861L,1302610899L,41971040844L,1352138182759L,43565815810587L,1403705064843757L,45228360174728351L,1457291782946371386L,BigInteger.Parse("46955159811511460603"),BigInteger.Parse("1512935850829951577045"),BigInteger.Parse("48748133543911846159969") };
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
public class A240892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240892Inst Instance=new A240892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240893
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,4L,11L,11L,4L,8L,36L,57L,36L,8L,16L,116L,289L,289L,116L,16L,32L,376L,1485L,2362L,1485L,376L,32L,64L,1216L,7609L,19065L,19065L,7609L,1216L,64L,128L,3936L,38981L,154858L,245268L,154858L,38981L,3936L,128L,256L,12736L,199761L,1255585L,3146755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240893Inst : IEnumerable<long>
{
public static readonly long[] Value=A240893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240893.Bytes);
public long this[int i]=>Value[i];

public static A240893Inst Instance=new A240893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240894
{
public static readonly long[] Value={ 13L,17L,23L,37L,43L,47L,53L,67L,73L,83L,97L,131L,211L,241L,271L,311L,331L,431L,461L,541L,571L,631L,641L,661L,761L,811L,899L,911L,941L,971L,1601L,3701L,5101L,5701L,6101L,6701L,8101L,9601L,13001L,19001L,24001L,54001L,69001L,93001L,97001L,102737L,194357L,217267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240894Inst : IEnumerable<long>
{
public static readonly long[] Value=A240894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240894.Bytes);
public long this[int i]=>Value[i];

public static A240894Inst Instance=new A240894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240895
{
public static readonly long[] Value={ 11L,25L,31L,41L,61L,71L,341L,671L,2119L,10231L,39579L,52231L,60341L,402959L,1288689L,1393059L,1956759L,16752951L,108659999L,181704519L,794033191L,1062726071L,3518397571L,4062296851L,4085227151L,7015608139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240895Inst : IEnumerable<long>
{
public static readonly long[] Value=A240895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240895.Bytes);
public long this[int i]=>Value[i];

public static A240895Inst Instance=new A240895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240944
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,5L,7L,9L,15L,28L,45L,66L,99L,164L,269L,422L,651L,1028L,1654L,2637L,4149L,6522L,10350L,16467L,26091L,41205L,65174L,103339L,163833L,259361L,410376L,649827L,1029543L,1630725L,2581848L,4087797L,6473832L,10253370L,16237375L,25711316L,40714953L,64478427L,102111230L,161701086L,256062990L,405499697L,642156651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240944Inst : IEnumerable<long>
{
public static readonly long[] Value=A240944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240944.Bytes);
public long this[int i]=>Value[i];

public static A240944Inst Instance=new A240944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240945
{
public static readonly BigInteger[] Value={ 1L,9L,81L,729L,6561L,531441L,4782969L,282429536481L,2541865828329L,22876792454961L,16677181699666569L,BigInteger.Parse("278128389443693511257285776231761") };
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
public class A240945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240945Inst Instance=new A240945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240946
{
public static readonly long[] Value={ 1L,5L,7L,4L,5L,9L,7L,2L,3L,7L,5L,5L,1L,8L,9L,3L,6L,5L,7L,4L,9L,4L,6L,9L,2L,1L,8L,3L,0L,7L,6L,5L,1L,9L,6L,9L,0L,2L,2L,1L,6L,6L,6L,1L,8L,0L,7L,5L,8L,5L,1L,9L,1L,7L,0L,1L,9L,3L,6L,9L,3L,0L,9L,8L,3L,0L,1L,8L,3L,1L,1L,8L,0L,5L,9L,4L,4L,5L,4L,3L,8L,2L,1L,3L,1L,0L,8L,5L,3L,1L,3L,3L,6L,2L,2L,4L,1L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240946Inst : IEnumerable<long>
{
public static readonly long[] Value=A240946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240946.Bytes);
public long this[int i]=>Value[i];

public static A240946Inst Instance=new A240946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240947
{
public static readonly long[] Value={ 2L,5L,5L,5L,4L,8L,5L,4L,1L,2L,9L,2L,9L,0L,7L,6L,2L,8L,5L,5L,2L,3L,8L,9L,7L,6L,1L,6L,8L,3L,3L,3L,1L,3L,1L,0L,3L,7L,7L,3L,7L,1L,7L,5L,2L,5L,3L,6L,3L,6L,6L,0L,7L,5L,4L,2L,5L,1L,4L,7L,1L,6L,1L,9L,7L,9L,8L,6L,1L,8L,1L,2L,1L,5L,5L,2L,5L,6L,5L,3L,3L,2L,1L,4L,8L,2L,5L,8L,8L,6L,2L,6L,4L,0L,1L,2L,4L,8L,0L,4L,5L,7L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240947Inst : IEnumerable<long>
{
public static readonly long[] Value=A240947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240947.Bytes);
public long this[int i]=>Value[i];

public static A240947Inst Instance=new A240947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240948
{
public static readonly long[] Value={ 1L,1L,6L,15L,26L,57L,102L,172L,276L,453L,743L,1128L,1698L,2539L,3780L,5531L,7882L,11238L,15918L,22259L,30861L,42438L,58110L,78909L,106392L,142872L,190698L,253179L,334266L,439581L,575956L,750613L,974316L,1260336L,1624702L,2086806L,2670162L,3406695L,4333590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240948Inst : IEnumerable<long>
{
public static readonly long[] Value=A240948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240948.Bytes);
public long this[int i]=>Value[i];

public static A240948Inst Instance=new A240948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240949
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,11L,11L,21L,20L,38L,31L,67L,51L,107L,83L,172L,126L,263L,192L,399L,299L,584L,437L,857L,648L,1218L,941L,1743L,1351L,2438L,1912L,3399L,2708L,4672L,3750L,6439L,5193L,8712L,7113L,11815L,9678L,15836L,13056L,21186L,17609L,28080L,23438L,37210L,31181L,48819L,41182L,64039L,54188L,83374L,70923L,108364L,92587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240949Inst : IEnumerable<long>
{
public static readonly long[] Value=A240949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240949.Bytes);
public long this[int i]=>Value[i];

public static A240949Inst Instance=new A240949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240950
{
public static readonly long[] Value={ 13L,29L,41L,53L,58L,61L,73L,74L,85L,89L,97L,106L,109L,113L,125L,130L,137L,149L,157L,173L,181L,185L,193L,202L,218L,229L,233L,241L,250L,265L,269L,274L,277L,281L,293L,298L,313L,314L,317L,337L,338L,346L,349L,353L,365L,370L,373L,389L,394L,397L,409L,421L,425L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240950Inst : IEnumerable<long>
{
public static readonly long[] Value=A240950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240950.Bytes);
public long this[int i]=>Value[i];

public static A240950Inst Instance=new A240950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240951
{
public static readonly long[] Value={ 1L,2L,5L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240951Inst : IEnumerable<long>
{
public static readonly long[] Value=A240951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240951.Bytes);
public long this[int i]=>Value[i];

public static A240951Inst Instance=new A240951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240952
{
public static readonly long[] Value={ 19L,0L,1L,2L,6L,18L,36L,72L,106L,450L,562L,2312L,1156L,9522L,1381L,8712L,4930L,16562L,13812L,35912L,14862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240952Inst : IEnumerable<long>
{
public static readonly long[] Value=A240952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240952.Bytes);
public long this[int i]=>Value[i];

public static A240952Inst Instance=new A240952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240953
{
public static readonly long[] Value={ 7L,2L,9L,2L,6L,4L,7L,4L,4L,2L,5L,7L,1L,1L,9L,0L,1L,8L,8L,5L,3L,6L,1L,5L,3L,1L,6L,9L,3L,1L,3L,0L,0L,1L,2L,8L,1L,7L,7L,5L,4L,5L,9L,7L,1L,0L,3L,7L,8L,4L,3L,6L,1L,8L,6L,7L,4L,7L,6L,6L,9L,1L,2L,8L,7L,6L,5L,5L,6L,4L,6L,6L,1L,2L,5L,6L,6L,7L,2L,2L,9L,4L,7L,4L,2L,8L,3L,5L,9L,1L,5L,6L,4L,2L,8L,0L,1L,6L,9L,7L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240953Inst : IEnumerable<long>
{
public static readonly long[] Value=A240953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240953.Bytes);
public long this[int i]=>Value[i];

public static A240953Inst Instance=new A240953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240954
{
public static readonly long[] Value={ 1L,0L,1L,29L,100L,182L,484L,902L,2116L,4034L,8836L,17138L,36100L,70850L,145924L,288578L,586756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240954Inst : IEnumerable<long>
{
public static readonly long[] Value=A240954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240954.Bytes);
public long this[int i]=>Value[i];

public static A240954Inst Instance=new A240954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240955
{
public static readonly BigInteger[] Value={ 1L,1L,8L,1L,96L,384L,1L,2048L,36864L,98304L,1L,84480L,6881280L,62914560L,125829120L,1L,7221248L,3043491840L,80530636800L,483183820800L,773094113280L,1L,1218502656L,3326443782144L,260661565194240L,3752083429785600L,16624615811973120L,22166154415964160L,1L,421846581248L,9253226255745024L,2290594981959696384L,BigInteger.Parse("75808248102597427200"),BigInteger.Parse("726340547902313594880"),BigInteger.Parse("2542191917658097582080"),BigInteger.Parse("2905362191609254379520") };
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
public class A240955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240955Inst Instance=new A240955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240956
{
public static readonly BigInteger[] Value={ 1L,2L,9L,72L,830L,12420L,228060L,4959360L,124589304L,3550050000L,113116311000L,3985174226880L,153815533185600L,6454433029524480L,292557975636326400L,14244829479956275200UL,BigInteger.Parse("741502151945703308160"),BigInteger.Parse("41092028680670274827520"),BigInteger.Parse("2415394879269218890243200") };
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
public class A240956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240956Inst Instance=new A240956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240957
{
public static readonly BigInteger[] Value={ 1L,3L,20L,234L,3944L,86400L,2324160L,74062800L,2726970624L,113893395840L,5319595814400L,274730601277440L,15544557784673280L,956232958853652480L,BigInteger.Parse("63540675378122342400"),BigInteger.Parse("4535620918350762240000"),BigInteger.Parse("346127227962539155292160"),BigInteger.Parse("28120835253815298895380480"),BigInteger.Parse("2423309442415144546546483200") };
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
public class A240957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240957Inst Instance=new A240957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240958
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,296L,3840L,60480L,1127280L,24240384L,590728320L,16090099200L,484387706880L,15971308784640L,572403619307520L,22155942961152000L,921115890645350400L,BigInteger.Parse("40935834850710159360"),BigInteger.Parse("1936630231160472207360"),BigInteger.Parse("97172886828612884889600"),BigInteger.Parse("5154401709528015200256000") };
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
public class A240958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A240958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A240958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A240958Inst Instance=new A240958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A240959
{
public static readonly long[] Value={ 2L,23L,235L,2357L,112357L,113257L,231175L,11325719L,11325719L,11329175L,11329175L,113291735L,3117329145L,11329143715L,411329173475L,3114329173547L,31143291735947L,1132914347167359L,1132914347167359L,1132914347167359L,1132914347167359L,11329143471673597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A240959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A240959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A240959Inst : IEnumerable<long>
{
public static readonly long[] Value=A240959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A240959.Bytes);
public long this[int i]=>Value[i];

public static A240959Inst Instance=new A240959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241008
{
public static readonly long[] Value={ 3L,5L,7L,10L,11L,13L,14L,17L,19L,21L,22L,23L,26L,27L,29L,31L,33L,34L,37L,38L,39L,41L,43L,44L,46L,47L,51L,52L,53L,55L,57L,58L,59L,61L,62L,65L,67L,68L,69L,71L,73L,74L,76L,79L,82L,83L,85L,86L,87L,89L,92L,93L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241008Inst : IEnumerable<long>
{
public static readonly long[] Value=A241008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241008.Bytes);
public long this[int i]=>Value[i];

public static A241008Inst Instance=new A241008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241009
{
public static readonly long[] Value={ 1L,7L,7L,1L,0L,1L,1L,9L,6L,0L,9L,5L,6L,0L,9L,3L,9L,4L,2L,8L,7L,3L,9L,8L,0L,2L,3L,3L,5L,3L,6L,0L,5L,2L,9L,0L,8L,0L,1L,6L,6L,5L,0L,3L,9L,4L,5L,6L,8L,7L,2L,0L,8L,6L,1L,0L,2L,2L,8L,7L,0L,9L,0L,5L,2L,9L,5L,5L,9L,1L,1L,1L,1L,9L,4L,7L,4L,4L,5L,7L,9L,0L,6L,2L,0L,1L,6L,5L,2L,5L,1L,5L,4L,2L,4L,6L,4L,0L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241009Inst : IEnumerable<long>
{
public static readonly long[] Value=A241009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241009.Bytes);
public long this[int i]=>Value[i];

public static A241009Inst Instance=new A241009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241010
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,25L,32L,49L,50L,64L,81L,98L,121L,128L,169L,242L,256L,289L,338L,361L,484L,512L,529L,578L,625L,676L,722L,729L,841L,961L,1024L,1058L,1156L,1250L,1369L,1444L,1681L,1682L,1849L,1922L,2048L,2116L,2209L,2312L,2401L,2738L,2809L,2888L,3025L,3249L,3362L,3364L,3481L,3698L,3721L,3844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241010Inst : IEnumerable<long>
{
public static readonly long[] Value=A241010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241010.Bytes);
public long this[int i]=>Value[i];

public static A241010Inst Instance=new A241010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241011
{
public static readonly long[] Value={ 2L,0L,1L,6L,6L,2L,1L,5L,4L,5L,7L,3L,3L,4L,0L,8L,1L,1L,5L,2L,6L,2L,7L,9L,6L,8L,5L,9L,7L,1L,5L,1L,1L,5L,4L,2L,6L,4L,5L,0L,1L,8L,4L,1L,7L,7L,5L,2L,3L,6L,4L,7L,4L,8L,0L,6L,1L,0L,9L,1L,9L,2L,8L,3L,4L,4L,7L,8L,1L,4L,3L,4L,1L,6L,1L,6L,1L,8L,2L,7L,8L,7L,2L,5L,5L,4L,1L,3L,5L,1L,3L,9L,8L,3L,0L,6L,1L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241011Inst : IEnumerable<long>
{
public static readonly long[] Value=A241011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241011.Bytes);
public long this[int i]=>Value[i];

public static A241011Inst Instance=new A241011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241012
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,3L,10L,12L,14L,5L,16L,7L,18L,9L,11L,20L,22L,13L,24L,15L,17L,19L,26L,21L,28L,23L,30L,25L,32L,27L,34L,36L,29L,31L,33L,35L,38L,37L,39L,41L,40L,42L,43L,44L,46L,48L,45L,50L,47L,52L,54L,56L,49L,58L,60L,62L,64L,66L,51L,53L,55L,68L,70L,57L,72L,59L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241012Inst : IEnumerable<long>
{
public static readonly long[] Value=A241012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241012.Bytes);
public long this[int i]=>Value[i];

public static A241012Inst Instance=new A241012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241013
{
public static readonly long[] Value={ 4L,6L,9L,14L,21L,22L,26L,34L,39L,46L,49L,51L,57L,62L,69L,74L,77L,82L,86L,87L,91L,94L,106L,111L,119L,121L,122L,129L,134L,141L,142L,146L,159L,161L,166L,169L,177L,187L,194L,201L,202L,206L,209L,214L,217L,219L,221L,226L,237L,247L,249L,254L,259L,262L,267L,274L,287L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241013Inst : IEnumerable<long>
{
public static readonly long[] Value=A241013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241013.Bytes);
public long this[int i]=>Value[i];

public static A241013Inst Instance=new A241013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241014
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,-1L,3L,-8L,-3L,-6L,13L,-2L,-4L,16L,-25L,10L,-13L,7L,-16L,-15L,-30L,21L,5L,37L,-4L,22L,24L,26L,-53L,13L,64L,58L,-22L,-29L,60L,44L,-3L,44L,-43L,-5L,-50L,94L,31L,-56L,5L,-99L,3L,-73L,18L,29L,5L,-59L,-1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241014Inst : IEnumerable<long>
{
public static readonly long[] Value=A241014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241014.Bytes);
public long this[int i]=>Value[i];

public static A241014Inst Instance=new A241014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241015
{
public static readonly BigInteger[] Value={ 1L,1L,6L,141L,6184L,387545L,33404256L,3891981205L,592320594048L,113184611671473L,26327424526220800L,7302855260707822541L,BigInteger.Parse("2381136881374877847552"),BigInteger.Parse("901709366369630531857417"),BigInteger.Parse("392234247731566637785780224"),BigInteger.Parse("194028806625479344354551301125") };
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
public class A241015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241015Inst Instance=new A241015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241016
{
public static readonly long[] Value={ 1L,3L,7L,6L,15L,24L,10L,26L,42L,58L,15L,40L,65L,90L,115L,21L,57L,93L,129L,165L,201L,28L,77L,126L,175L,224L,273L,322L,36L,100L,164L,228L,292L,356L,420L,484L,45L,126L,207L,288L,369L,450L,531L,612L,693L,55L,155L,255L,355L,455L,555L,655L,755L,855L,955L,66L,187L,308L,429L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241016Inst : IEnumerable<long>
{
public static readonly long[] Value=A241016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241016.Bytes);
public long this[int i]=>Value[i];

public static A241016Inst Instance=new A241016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241017
{
public static readonly long[] Value={ 8L,2L,2L,8L,2L,5L,2L,4L,9L,6L,7L,8L,8L,4L,7L,0L,3L,2L,9L,9L,5L,3L,2L,8L,7L,1L,6L,2L,6L,1L,4L,6L,4L,9L,4L,9L,4L,7L,5L,6L,9L,3L,1L,1L,8L,8L,9L,4L,8L,5L,0L,2L,1L,8L,3L,9L,3L,8L,1L,5L,6L,1L,3L,0L,3L,7L,0L,9L,0L,9L,5L,6L,4L,4L,6L,4L,0L,1L,6L,6L,7L,5L,7L,2L,1L,9L,5L,3L,2L,5L,7L,3L,2L,3L,4L,4L,5L,3L,2L,4L,7L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241017Inst : IEnumerable<long>
{
public static readonly long[] Value=A241017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241017.Bytes);
public long this[int i]=>Value[i];

public static A241017Inst Instance=new A241017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241018
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,7L,1L,0L,2L,6L,3L,3L,11L,2L,14L,4L,0L,4L,6L,0L,4L,20L,6L,7L,18L,1L,1L,23L,8L,8L,23L,7L,0L,0L,0L,26L,33L,0L,11L,8L,5L,8L,13L,12L,44L,2L,2L,0L,11L,31L,17L,39L,1L,51L,5L,7L,4L,29L,9L,16L,0L,0L,26L,14L,26L,10L,13L,0L,0L,34L,40L,0L,15L,3L,14L,32L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241018Inst : IEnumerable<long>
{
public static readonly long[] Value=A241018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241018.Bytes);
public long this[int i]=>Value[i];

public static A241018Inst Instance=new A241018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241019
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,4L,2L,6L,5L,5L,5L,0L,3L,8L,1L,11L,7L,6L,4L,5L,11L,5L,0L,0L,9L,11L,0L,5L,5L,0L,4L,5L,17L,19L,19L,6L,0L,3L,9L,35L,1L,27L,24L,32L,0L,36L,14L,11L,34L,14L,22L,0L,17L,53L,0L,47L,11L,0L,16L,3L,0L,15L,0L,39L,22L,40L,27L,39L,0L,19L,2L,19L,48L,2L,43L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241019Inst : IEnumerable<long>
{
public static readonly long[] Value=A241019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241019.Bytes);
public long this[int i]=>Value[i];

public static A241019Inst Instance=new A241019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241020
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,0L,6L,0L,1L,2L,0L,2L,1L,0L,3L,0L,0L,5L,2L,0L,6L,4L,0L,7L,4L,0L,12L,0L,0L,19L,8L,0L,26L,5L,0L,0L,33L,0L,6L,11L,0L,1L,23L,0L,18L,34L,0L,15L,0L,0L,1L,22L,0L,1L,50L,0L,32L,15L,0L,15L,25L,0L,21L,10L,0L,29L,47L,0L,0L,11L,0L,56L,14L,0L,2L,0L,0L,54L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241020Inst : IEnumerable<long>
{
public static readonly long[] Value=A241020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241020.Bytes);
public long this[int i]=>Value[i];

public static A241020Inst Instance=new A241020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241021
{
public static readonly BigInteger[] Value={ 19L,199L,1999L,99991L,199999L,9999991L,19999999L,0L,9199999999L,99999199999L,991999999999L,9919999999999L,99999999991999L,919999999999999L,9999999999999199L,99919999999999999L,0L,9991999999999999999UL,BigInteger.Parse("99999199999999999999"),0L,BigInteger.Parse("9991999999999999999999") };
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
public class A241021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241021Inst Instance=new A241021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241022
{
public static readonly BigInteger[] Value={ 13L,313L,3313L,31333L,313333L,3331333L,31333333L,333331333L,3333133333L,33331333333L,333313333333L,0L,33133333333333L,333333313333333L,1333333333333333L,33333333331333333L,333333133333333333L,3333313333333333333L,BigInteger.Parse("33313333333333333333"),BigInteger.Parse("333313333333333333333") };
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
public class A241022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A241022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A241022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A241022Inst Instance=new A241022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241023
{
public static readonly long[] Value={ 1L,4L,16L,76L,384L,2004L,10672L,57628L,314368L,1728292L,9560016L,53144172L,296642688L,1661529588L,9333781872L,52566230076L,296697618432L,1677889961028L,9505151782288L,53928746972812L,306393243712384L,1742920028025364L,9925790375394096L,56584659163097436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241023Inst : IEnumerable<long>
{
public static readonly long[] Value=A241023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241023.Bytes);
public long this[int i]=>Value[i];

public static A241023Inst Instance=new A241023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241088
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,4L,6L,7L,10L,12L,15L,18L,22L,26L,32L,39L,46L,56L,66L,78L,91L,108L,125L,147L,171L,200L,231L,269L,309L,357L,410L,470L,538L,616L,703L,801L,913L,1037L,1178L,1335L,1511L,1707L,1929L,2172L,2448L,2752L,3093L,3470L,3894L,4359L,4880L,5455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241088Inst : IEnumerable<long>
{
public static readonly long[] Value=A241088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241088.Bytes);
public long this[int i]=>Value[i];

public static A241088Inst Instance=new A241088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241089
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,3L,4L,5L,6L,8L,10L,13L,16L,20L,24L,29L,35L,42L,50L,61L,72L,85L,101L,118L,138L,161L,188L,218L,254L,293L,339L,391L,450L,515L,591L,675L,771L,878L,999L,1135L,1289L,1460L,1652L,1868L,2108L,2376L,2676L,3009L,3379L,3793L,4250L,4760L,5325L,5952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241089Inst : IEnumerable<long>
{
public static readonly long[] Value=A241089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241089.Bytes);
public long this[int i]=>Value[i];

public static A241089Inst Instance=new A241089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241090
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,3L,5L,6L,10L,12L,16L,21L,29L,36L,47L,58L,77L,93L,121L,146L,185L,225L,280L,338L,419L,505L,612L,743L,888L,1075L,1283L,1539L,1822L,2190L,2575L,3073L,3612L,4287L,5022L,5936L,6938L,8158L,9527L,11151L,12983L,15156L,17617L,20468L,23770L,27531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241090Inst : IEnumerable<long>
{
public static readonly long[] Value=A241090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241090.Bytes);
public long this[int i]=>Value[i];

public static A241090Inst Instance=new A241090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241091
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,3L,3L,3L,4L,5L,5L,7L,7L,9L,10L,11L,12L,15L,16L,19L,22L,24L,27L,30L,34L,37L,43L,47L,53L,59L,66L,72L,82L,88L,99L,109L,120L,131L,146L,160L,176L,194L,212L,233L,256L,279L,304L,334L,362L,396L,431L,471L,510L,558L,604L,659L,714L,776L,839L,913L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241091Inst : IEnumerable<long>
{
public static readonly long[] Value=A241091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241091.Bytes);
public long this[int i]=>Value[i];

public static A241091Inst Instance=new A241091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241092
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,5L,7L,7L,8L,9L,10L,10L,12L,13L,15L,17L,19L,21L,25L,26L,29L,32L,35L,38L,42L,46L,51L,57L,62L,69L,76L,83L,90L,100L,107L,117L,127L,139L,150L,165L,178L,195L,212L,231L,250L,273L,294L,319L,346L,373L,402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241092Inst : IEnumerable<long>
{
public static readonly long[] Value=A241092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241092.Bytes);
public long this[int i]=>Value[i];

public static A241092Inst Instance=new A241092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241093
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,3L,4L,5L,7L,8L,11L,13L,17L,21L,26L,31L,38L,45L,54L,65L,77L,92L,108L,128L,149L,175L,203L,237L,274L,318L,366L,424L,486L,559L,640L,733L,836L,953L,1084L,1232L,1398L,1583L,1792L,2025L,2286L,2576L,2902L,3262L,3666L,4111L,4610L,5160L,5774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241093Inst : IEnumerable<long>
{
public static readonly long[] Value=A241093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241093.Bytes);
public long this[int i]=>Value[i];

public static A241093Inst Instance=new A241093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A241094
{
public static readonly long[] Value={ 0L,1L,1L,4L,4L,4L,18L,24L,24L,18L,96L,144L,144L,96L,600L,960L,1080L,1080L,960L,600L,4320L,7200L,8460L,8460L,8460L,7200L,4320L,35280L,60840L,75600L,80640L,80640L,75600L,60480L,35280L,322560L,564480L,725760L,806400L,806400L,806400L,725760L,564480L,322560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A241094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A241094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A241094Inst : IEnumerable<long>
{
public static readonly long[] Value=A241094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A241094.Bytes);
public long this[int i]=>Value[i];

public static A241094Inst Instance=new A241094Inst();

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