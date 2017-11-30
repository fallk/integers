using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A039960
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,8L,8L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,24L,25L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,42L,43L,44L,45L,46L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,55L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039960Inst : IEnumerable<long>
{
public static readonly long[] Value=A039960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039960.Bytes);
public long this[int i]=>Value[i];

public static A039960Inst Instance=new A039960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039961
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-2L,1L,1L,-1L,-3L,2L,1L,1L,-1L,-4L,3L,3L,-1L,1L,-1L,-5L,4L,6L,-3L,-1L,1L,-1L,-6L,5L,10L,-6L,-4L,1L,1L,-1L,-7L,6L,15L,-10L,-10L,4L,1L,1L,-1L,-8L,7L,21L,-15L,-20L,10L,5L,-1L,1L,-1L,-9L,8L,28L,-21L,-35L,20L,15L,-5L,-1L,1L,-1L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039961Inst : IEnumerable<long>
{
public static readonly long[] Value=A039961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039961.Bytes);
public long this[int i]=>Value[i];

public static A039961Inst Instance=new A039961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039962
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,7L,11L,3L,1L,10L,29L,26L,5L,1L,13L,56L,94L,56L,8L,1L,16L,92L,234L,263L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039962Inst : IEnumerable<long>
{
public static readonly long[] Value=A039962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039962.Bytes);
public long this[int i]=>Value[i];

public static A039962Inst Instance=new A039962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039963
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039963Inst : IEnumerable<long>
{
public static readonly long[] Value=A039963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039963.Bytes);
public long this[int i]=>Value[i];

public static A039963Inst Instance=new A039963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039964
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039964Inst : IEnumerable<long>
{
public static readonly long[] Value=A039964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039964.Bytes);
public long this[int i]=>Value[i];

public static A039964Inst Instance=new A039964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039981
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,2L,2L,1L,0L,1L,1L,2L,0L,0L,2L,0L,1L,2L,2L,0L,0L,2L,1L,1L,1L,0L,0L,1L,1L,2L,0L,0L,2L,0L,0L,2L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,1L,2L,2L,1L,0L,1L,2L,2L,2L,0L,0L,2L,1L,1L,1L,2L,0L,2L,2L,1L,0L,0L,1L,0L,2L,1L,1L,0L,0L,1L,2L,2L,2L,1L,0L,1L,1L,2L,0L,0L,2L,0L,0L,2L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039981Inst : IEnumerable<long>
{
public static readonly long[] Value=A039981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039981.Bytes);
public long this[int i]=>Value[i];

public static A039981Inst Instance=new A039981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039982
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039982Inst : IEnumerable<long>
{
public static readonly long[] Value=A039982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039982.Bytes);
public long this[int i]=>Value[i];

public static A039982Inst Instance=new A039982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039983
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039983Inst : IEnumerable<long>
{
public static readonly long[] Value=A039983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039983.Bytes);
public long this[int i]=>Value[i];

public static A039983Inst Instance=new A039983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039984
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039984Inst : IEnumerable<long>
{
public static readonly long[] Value=A039984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039984.Bytes);
public long this[int i]=>Value[i];

public static A039984Inst Instance=new A039984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039985
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039985Inst : IEnumerable<long>
{
public static readonly long[] Value=A039985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039985.Bytes);
public long this[int i]=>Value[i];

public static A039985Inst Instance=new A039985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039986
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,151L,211L,223L,227L,229L,233L,257L,263L,269L,353L,383L,409L,431L,433L,443L,449L,487L,499L,523L,541L,557L,599L,661L,677L,773L,827L,829L,853L,859L,881L,883L,887L,929L,997L,1447L,1451L,1481L,2111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039986Inst : IEnumerable<long>
{
public static readonly long[] Value=A039986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039986.Bytes);
public long this[int i]=>Value[i];

public static A039986Inst Instance=new A039986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039987
{
public static readonly long[] Value={ 11L,111L,122L,212L,221L,1111L,1221L,2122L,2212L,11111L,12212L,12221L,13322L,21221L,22122L,22331L,111111L,122122L,122212L,122221L,212212L,212221L,221221L,1111111L,1221221L,1222122L,1222212L,2122122L,2122212L,2122221L,2212212L,2212221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039987Inst : IEnumerable<long>
{
public static readonly long[] Value=A039987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039987.Bytes);
public long this[int i]=>Value[i];

public static A039987Inst Instance=new A039987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039988
{
public static readonly long[] Value={ 11L,111L,1111L,1221L,11111L,111111L,1111111L,1221221L,11111111L,111111111L,1111111111L,1221221221L,11111111111L,111111111111L,1111111111111L,1221221221221L,11111111111111L,111111111111111L,1111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039988Inst : IEnumerable<long>
{
public static readonly long[] Value=A039988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039988.Bytes);
public long this[int i]=>Value[i];

public static A039988Inst Instance=new A039988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039989
{
public static readonly long[] Value={ 11L,111L,122L,212L,221L,1111L,1222L,2122L,2212L,2221L,11111L,12221L,21222L,22122L,22212L,111111L,122212L,122221L,133322L,212221L,221222L,222122L,223331L,1111111L,1222122L,1222212L,1222221L,1333222L,2122212L,2122221L,2212221L,2221222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039989Inst : IEnumerable<long>
{
public static readonly long[] Value=A039989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039989.Bytes);
public long this[int i]=>Value[i];

public static A039989Inst Instance=new A039989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039990
{
public static readonly long[] Value={ 111L,122L,212L,221L,1111L,1222L,2122L,2212L,2221L,11111L,12222L,21222L,22122L,22212L,22221L,111111L,122221L,212222L,221222L,222122L,222212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039990Inst : IEnumerable<long>
{
public static readonly long[] Value=A039990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039990.Bytes);
public long this[int i]=>Value[i];

public static A039990Inst Instance=new A039990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039991
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,-1L,4L,0L,-3L,0L,8L,0L,-8L,0L,1L,16L,0L,-20L,0L,5L,0L,32L,0L,-48L,0L,18L,0L,-1L,64L,0L,-112L,0L,56L,0L,-7L,0L,128L,0L,-256L,0L,160L,0L,-32L,0L,1L,256L,0L,-576L,0L,432L,0L,-120L,0L,9L,0L,512L,0L,-1280L,0L,1120L,0L,-400L,0L,50L,0L,-1L,1024L,0L,-2816L,0L,2816L,0L,-1232L,0L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039991Inst : IEnumerable<long>
{
public static readonly long[] Value=A039991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039991.Bytes);
public long this[int i]=>Value[i];

public static A039991Inst Instance=new A039991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039992
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,1L,3L,2L,3L,4L,1L,2L,2L,3L,2L,1L,2L,3L,4L,3L,2L,1L,3L,2L,4L,5L,2L,7L,6L,7L,11L,6L,6L,3L,7L,7L,8L,11L,10L,3L,4L,6L,10L,4L,3L,4L,3L,3L,4L,6L,4L,4L,4L,4L,3L,6L,4L,3L,6L,6L,5L,7L,5L,11L,5L,7L,8L,4L,4L,7L,7L,7L,10L,3L,6L,10L,2L,1L,6L,4L,6L,3L,4L,3L,1L,5L,4L,4L,5L,6L,3L,6L,1L,4L,3L,4L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039992Inst : IEnumerable<long>
{
public static readonly long[] Value=A039992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039992.Bytes);
public long this[int i]=>Value[i];

public static A039992Inst Instance=new A039992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039993
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,3L,1L,1L,1L,3L,0L,1L,1L,1L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,3L,1L,2L,3L,1L,4L,2L,1L,0L,1L,1L,2L,0L,1L,0L,2L,0L,0L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,0L,1L,1L,1L,0L,1L,0L,2L,0L,0L,1L,3L,2L,4L,2L,2L,2L,1L,1L,3L,0L,0L,1L,2L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,2L,0L,3L,1L,0L,0L,2L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039993Inst : IEnumerable<long>
{
public static readonly long[] Value=A039993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039993.Bytes);
public long this[int i]=>Value[i];

public static A039993Inst Instance=new A039993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039994
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,3L,3L,2L,4L,4L,5L,6L,4L,2L,3L,4L,3L,4L,6L,5L,2L,3L,4L,5L,2L,3L,4L,3L,3L,4L,5L,3L,3L,4L,4L,3L,4L,3L,2L,5L,5L,4L,4L,4L,6L,3L,4L,5L,2L,4L,4L,5L,5L,5L,3L,3L,5L,2L,1L,3L,3L,5L,3L,3L,3L,1L,4L,3L,3L,4L,4L,3L,2L,1L,4L,3L,3L,6L,3L,4L,3L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039994Inst : IEnumerable<long>
{
public static readonly long[] Value=A039994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039994.Bytes);
public long this[int i]=>Value[i];

public static A039994Inst Instance=new A039994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039995
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,2L,0L,1L,0L,2L,0L,1L,1L,1L,1L,3L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,3L,1L,1L,0L,1L,1L,2L,0L,1L,0L,2L,0L,0L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,0L,1L,1L,1L,0L,1L,0L,2L,0L,0L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,0L,0L,1L,2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,2L,0L,0L,0L,2L,1L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039995Inst : IEnumerable<long>
{
public static readonly long[] Value=A039995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039995.Bytes);
public long this[int i]=>Value[i];

public static A039995Inst Instance=new A039995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039996
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,2L,1L,2L,1L,2L,2L,1L,4L,3L,4L,5L,3L,1L,2L,3L,2L,3L,5L,4L,1L,2L,3L,4L,2L,3L,4L,3L,3L,4L,4L,3L,3L,4L,3L,2L,4L,3L,2L,4L,4L,3L,4L,4L,5L,3L,4L,4L,2L,4L,4L,4L,5L,5L,3L,3L,4L,1L,1L,3L,2L,4L,3L,3L,3L,1L,3L,2L,2L,3L,4L,2L,1L,1L,3L,2L,3L,5L,3L,4L,3L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039996Inst : IEnumerable<long>
{
public static readonly long[] Value=A039996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039996.Bytes);
public long this[int i]=>Value[i];

public static A039996Inst Instance=new A039996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040013
{
public static readonly long[] Value={ 4L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040013Inst : IEnumerable<long>
{
public static readonly long[] Value=A040013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040013.Bytes);
public long this[int i]=>Value[i];

public static A040013Inst Instance=new A040013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040014
{
public static readonly long[] Value={ 0L,1L,4L,8L,16L,34L,79L,183L,429L,1019L,2466L,6048L,14912L,37128L,93117L,234855L,595341L,1516233L,3877186L,9950346L,25614562L,66124777L,171141897L,443963543L,1154106844L,3005936865L,7842921261L,20496470801L,53645077679L,140599114669L,368973074565L,969455391690L,2550043255883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040014Inst : IEnumerable<long>
{
public static readonly long[] Value=A040014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040014.Bytes);
public long this[int i]=>Value[i];

public static A040014Inst Instance=new A040014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040015
{
public static readonly long[] Value={ 4L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040015Inst : IEnumerable<long>
{
public static readonly long[] Value=A040015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040015.Bytes);
public long this[int i]=>Value[i];

public static A040015Inst Instance=new A040015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040016
{
public static readonly long[] Value={ 2L,7L,19L,53L,139L,401L,1093L,2971L,8101L,22013L,59863L,162751L,442399L,1202603L,3269011L,8886109L,24154939L,65659969L,178482289L,485165141L,1318815713L,3584912833L,9744803443L,26489122081L,72004899319L,195729609407L,532048240573L,1446257064289L,3931334297131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040016Inst : IEnumerable<long>
{
public static readonly long[] Value=A040016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040016.Bytes);
public long this[int i]=>Value[i];

public static A040016Inst Instance=new A040016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040017
{
public static readonly BigInteger[] Value={ 3L,11L,37L,101L,9091L,9901L,333667L,909091L,99990001L,999999000001L,9999999900000001L,909090909090909091L,1111111111111111111L,BigInteger.Parse("11111111111111111111111"),BigInteger.Parse("900900900900990990990991"),BigInteger.Parse("909090909090909090909090909091") };
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
public class A040017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A040017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A040017Inst Instance=new A040017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040018
{
public static readonly long[] Value={ 1L,1L,3L,8L,46L,176L,955L,5446L,36122L,259084L,2043944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040018Inst : IEnumerable<long>
{
public static readonly long[] Value=A040018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040018.Bytes);
public long this[int i]=>Value[i];

public static A040018Inst Instance=new A040018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040019
{
public static readonly long[] Value={ 4L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040019Inst : IEnumerable<long>
{
public static readonly long[] Value=A040019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040019.Bytes);
public long this[int i]=>Value[i];

public static A040019Inst Instance=new A040019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040020
{
public static readonly long[] Value={ 5L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040020Inst : IEnumerable<long>
{
public static readonly long[] Value=A040020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040020.Bytes);
public long this[int i]=>Value[i];

public static A040020Inst Instance=new A040020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040021
{
public static readonly long[] Value={ 5L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040021Inst : IEnumerable<long>
{
public static readonly long[] Value=A040021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040021.Bytes);
public long this[int i]=>Value[i];

public static A040021Inst Instance=new A040021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040022
{
public static readonly long[] Value={ 5L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L,3L,2L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040022Inst : IEnumerable<long>
{
public static readonly long[] Value=A040022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040022.Bytes);
public long this[int i]=>Value[i];

public static A040022Inst Instance=new A040022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040023
{
public static readonly long[] Value={ 12L,10L,8L,1L,5L,4L,1L,8L,1L,1L,54L,1L,4L,1L,2L,36L,23L,3L,4L,3L,1L,2L,9L,1L,2L,2L,1L,5L,2L,8L,2L,2L,4L,15L,1L,2L,7L,99L,1L,2L,1L,1L,3L,4L,1L,7L,2L,1L,2L,42L,1L,13L,2L,13L,1L,2L,8L,2L,2L,14L,1L,6L,1L,1L,1L,3L,3L,42L,2L,9L,6L,43L,5L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040023Inst : IEnumerable<long>
{
public static readonly long[] Value=A040023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040023.Bytes);
public long this[int i]=>Value[i];

public static A040023Inst Instance=new A040023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040024
{
public static readonly long[] Value={ 5L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040024Inst : IEnumerable<long>
{
public static readonly long[] Value=A040024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040024.Bytes);
public long this[int i]=>Value[i];

public static A040024Inst Instance=new A040024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040025
{
public static readonly long[] Value={ 4L,15L,93L,668L,5172L,42042L,353701L,3036643L,27045226L,239093865L,2158090933L,19742800564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040025Inst : IEnumerable<long>
{
public static readonly long[] Value=A040025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040025.Bytes);
public long this[int i]=>Value[i];

public static A040025Inst Instance=new A040025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040026
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,-3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,23L,9L,25L,13L,27L,-7L,29L,15L,31L,1L,33L,17L,35L,9L,37L,19L,39L,-15L,41L,21L,43L,-11L,45L,23L,47L,-15L,49L,25L,51L,13L,53L,27L,55L,-7L,57L,29L,59L,-15L,61L,31L,63L,1L,65L,33L,67L,17L,69L,35L,71L,9L,73L,37L,75L,-19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040026Inst : IEnumerable<long>
{
public static readonly long[] Value=A040026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040026.Bytes);
public long this[int i]=>Value[i];

public static A040026Inst Instance=new A040026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040027
{
public static readonly long[] Value={ 1L,1L,3L,9L,31L,121L,523L,2469L,12611L,69161L,404663L,2512769L,16485691L,113842301L,824723643L,6249805129L,49416246911L,406754704841L,3478340425563L,30845565317189L,283187362333331L,2687568043654521L,26329932233283223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040027Inst : IEnumerable<long>
{
public static readonly long[] Value=A040027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040027.Bytes);
public long this[int i]=>Value[i];

public static A040027Inst Instance=new A040027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040028
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,31L,41L,43L,47L,53L,59L,71L,83L,89L,101L,107L,109L,113L,127L,131L,137L,149L,157L,167L,173L,179L,191L,197L,223L,227L,229L,233L,239L,251L,257L,263L,269L,277L,281L,283L,293L,307L,311L,317L,347L,353L,359L,383L,389L,397L,401L,419L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040028Inst : IEnumerable<long>
{
public static readonly long[] Value=A040028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040028.Bytes);
public long this[int i]=>Value[i];

public static A040028Inst Instance=new A040028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040045
{
public static readonly long[] Value={ 7L,19L,31L,37L,43L,61L,73L,79L,97L,103L,109L,139L,151L,157L,193L,223L,229L,271L,277L,283L,307L,331L,349L,373L,397L,421L,433L,439L,463L,499L,523L,541L,547L,571L,577L,601L,607L,613L,619L,661L,673L,709L,727L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040045Inst : IEnumerable<long>
{
public static readonly long[] Value=A040045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040045.Bytes);
public long this[int i]=>Value[i];

public static A040045Inst Instance=new A040045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040046
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,29L,37L,41L,47L,53L,59L,71L,83L,89L,101L,107L,113L,131L,137L,139L,149L,163L,167L,173L,179L,181L,191L,197L,227L,233L,239L,241L,251L,257L,263L,269L,281L,293L,307L,311L,313L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040046Inst : IEnumerable<long>
{
public static readonly long[] Value=A040046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040046.Bytes);
public long this[int i]=>Value[i];

public static A040046Inst Instance=new A040046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040047
{
public static readonly long[] Value={ 13L,19L,31L,43L,61L,67L,73L,79L,97L,103L,109L,127L,151L,157L,193L,199L,211L,223L,229L,271L,277L,283L,331L,367L,373L,397L,433L,457L,463L,487L,523L,547L,577L,601L,613L,619L,661L,673L,691L,709L,733L,739L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040047Inst : IEnumerable<long>
{
public static readonly long[] Value=A040047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040047.Bytes);
public long this[int i]=>Value[i];

public static A040047Inst Instance=new A040047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040048
{
public static readonly long[] Value={ 7L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040048Inst : IEnumerable<long>
{
public static readonly long[] Value=A040048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040048.Bytes);
public long this[int i]=>Value[i];

public static A040048Inst Instance=new A040048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040049
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,29L,41L,47L,53L,59L,71L,73L,83L,89L,101L,107L,113L,131L,137L,149L,157L,167L,173L,179L,181L,191L,197L,223L,227L,233L,239L,251L,257L,263L,269L,281L,293L,311L,313L,317L,331L,337L,347L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040049Inst : IEnumerable<long>
{
public static readonly long[] Value=A040049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040049.Bytes);
public long this[int i]=>Value[i];

public static A040049Inst Instance=new A040049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040050
{
public static readonly long[] Value={ 13L,31L,37L,43L,61L,67L,79L,97L,103L,109L,127L,139L,151L,163L,193L,199L,211L,229L,241L,271L,277L,283L,307L,349L,379L,397L,409L,433L,457L,499L,523L,547L,577L,601L,613L,619L,631L,643L,691L,709L,727L,733L,739L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040050Inst : IEnumerable<long>
{
public static readonly long[] Value=A040050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040050.Bytes);
public long this[int i]=>Value[i];

public static A040050Inst Instance=new A040050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040051
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040051Inst : IEnumerable<long>
{
public static readonly long[] Value=A040051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040051.Bytes);
public long this[int i]=>Value[i];

public static A040051Inst Instance=new A040051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040052
{
public static readonly long[] Value={ 7L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040052Inst : IEnumerable<long>
{
public static readonly long[] Value=A040052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040052.Bytes);
public long this[int i]=>Value[i];

public static A040052Inst Instance=new A040052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040053
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040053Inst : IEnumerable<long>
{
public static readonly long[] Value=A040053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040053.Bytes);
public long this[int i]=>Value[i];

public static A040053Inst Instance=new A040053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040054
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,37L,41L,47L,53L,59L,71L,73L,79L,83L,89L,101L,103L,107L,113L,127L,131L,137L,139L,149L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,271L,281L,293L,311L,317L,331L,347L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040054Inst : IEnumerable<long>
{
public static readonly long[] Value=A040054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040054.Bytes);
public long this[int i]=>Value[i];

public static A040054Inst Instance=new A040054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040055
{
public static readonly long[] Value={ 7L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040055Inst : IEnumerable<long>
{
public static readonly long[] Value=A040055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040055.Bytes);
public long this[int i]=>Value[i];

public static A040055Inst Instance=new A040055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040056
{
public static readonly long[] Value={ 8L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040056Inst : IEnumerable<long>
{
public static readonly long[] Value=A040056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040056.Bytes);
public long this[int i]=>Value[i];

public static A040056Inst Instance=new A040056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040057
{
public static readonly long[] Value={ 8L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040057Inst : IEnumerable<long>
{
public static readonly long[] Value=A040057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040057.Bytes);
public long this[int i]=>Value[i];

public static A040057Inst Instance=new A040057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040058
{
public static readonly long[] Value={ 7L,13L,19L,31L,43L,61L,67L,97L,109L,151L,157L,163L,181L,193L,199L,211L,223L,229L,241L,277L,283L,307L,313L,337L,367L,373L,379L,397L,409L,433L,439L,487L,499L,523L,541L,571L,577L,601L,619L,631L,709L,727L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040058Inst : IEnumerable<long>
{
public static readonly long[] Value=A040058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040058.Bytes);
public long this[int i]=>Value[i];

public static A040058Inst Instance=new A040058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040059
{
public static readonly long[] Value={ 8L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040059Inst : IEnumerable<long>
{
public static readonly long[] Value=A040059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040059.Bytes);
public long this[int i]=>Value[i];

public static A040059Inst Instance=new A040059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040060
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,71L,83L,89L,101L,107L,113L,131L,137L,149L,167L,173L,179L,191L,193L,197L,199L,211L,227L,229L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040060Inst : IEnumerable<long>
{
public static readonly long[] Value=A040060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040060.Bytes);
public long this[int i]=>Value[i];

public static A040060Inst Instance=new A040060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040093
{
public static readonly long[] Value={ 10L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040093Inst : IEnumerable<long>
{
public static readonly long[] Value=A040093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040093.Bytes);
public long this[int i]=>Value[i];

public static A040093Inst Instance=new A040093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040094
{
public static readonly long[] Value={ 10L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L,20L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040094Inst : IEnumerable<long>
{
public static readonly long[] Value=A040094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040094.Bytes);
public long this[int i]=>Value[i];

public static A040094Inst Instance=new A040094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040095
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,31L,37L,41L,47L,53L,59L,61L,71L,83L,89L,101L,103L,107L,109L,113L,131L,137L,139L,149L,157L,163L,167L,173L,179L,191L,193L,197L,211L,227L,233L,239L,241L,251L,257L,263L,269L,271L,281L,293L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040095Inst : IEnumerable<long>
{
public static readonly long[] Value=A040095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040095.Bytes);
public long this[int i]=>Value[i];

public static A040095Inst Instance=new A040095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040096
{
public static readonly long[] Value={ 7L,13L,19L,43L,67L,73L,79L,97L,127L,151L,181L,199L,223L,229L,277L,283L,307L,331L,337L,349L,367L,397L,409L,421L,433L,439L,457L,487L,499L,523L,541L,547L,577L,601L,607L,619L,631L,643L,661L,691L,709L,733L,739L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040096Inst : IEnumerable<long>
{
public static readonly long[] Value=A040096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040096.Bytes);
public long this[int i]=>Value[i];

public static A040096Inst Instance=new A040096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040097
{
public static readonly long[] Value={ 10L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040097Inst : IEnumerable<long>
{
public static readonly long[] Value=A040097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040097.Bytes);
public long this[int i]=>Value[i];

public static A040097Inst Instance=new A040097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040098
{
public static readonly long[] Value={ 2L,7L,23L,31L,47L,71L,73L,79L,89L,103L,113L,127L,151L,167L,191L,199L,223L,233L,239L,257L,263L,271L,281L,311L,337L,353L,359L,367L,383L,431L,439L,463L,479L,487L,503L,577L,593L,599L,601L,607L,617L,631L,647L,719L,727L,743L,751L,823L,839L,863L,881L,887L,911L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040098Inst : IEnumerable<long>
{
public static readonly long[] Value=A040098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040098.Bytes);
public long this[int i]=>Value[i];

public static A040098Inst Instance=new A040098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040099
{
public static readonly long[] Value={ 10L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L,20L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040099Inst : IEnumerable<long>
{
public static readonly long[] Value=A040099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040099.Bytes);
public long this[int i]=>Value[i];

public static A040099Inst Instance=new A040099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040100
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,29L,37L,41L,43L,53L,59L,61L,67L,83L,97L,101L,107L,109L,131L,137L,139L,149L,157L,163L,173L,179L,181L,193L,197L,211L,227L,229L,241L,251L,269L,277L,283L,293L,307L,313L,317L,331L,347L,349L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040100Inst : IEnumerable<long>
{
public static readonly long[] Value=A040100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040100.Bytes);
public long this[int i]=>Value[i];

public static A040100Inst Instance=new A040100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040101
{
public static readonly long[] Value={ 2L,3L,11L,13L,23L,47L,59L,71L,83L,107L,109L,131L,167L,179L,181L,191L,193L,227L,229L,239L,251L,263L,277L,311L,313L,347L,359L,383L,419L,421L,431L,433L,443L,467L,479L,491L,503L,541L,563L,577L,587L,599L,601L,647L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040101Inst : IEnumerable<long>
{
public static readonly long[] Value=A040101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040101.Bytes);
public long this[int i]=>Value[i];

public static A040101Inst Instance=new A040101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040102
{
public static readonly long[] Value={ 5L,7L,17L,19L,29L,31L,37L,41L,43L,53L,61L,67L,73L,79L,89L,97L,101L,103L,113L,127L,137L,139L,149L,151L,157L,163L,173L,197L,199L,211L,223L,233L,241L,257L,269L,271L,281L,283L,293L,307L,317L,331L,337L,349L,353L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040102Inst : IEnumerable<long>
{
public static readonly long[] Value=A040102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040102.Bytes);
public long this[int i]=>Value[i];

public static A040102Inst Instance=new A040102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040103
{
public static readonly long[] Value={ 2L,3L,7L,11L,17L,19L,23L,31L,41L,43L,47L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,113L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040103Inst : IEnumerable<long>
{
public static readonly long[] Value=A040103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040103.Bytes);
public long this[int i]=>Value[i];

public static A040103Inst Instance=new A040103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040104
{
public static readonly long[] Value={ 1193L,1201L,1213L,1217L,1223L,1229L,1231L,1237L,1249L,1259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040104Inst : IEnumerable<long>
{
public static readonly long[] Value=A040104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040104.Bytes);
public long this[int i]=>Value[i];

public static A040104Inst Instance=new A040104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040105
{
public static readonly long[] Value={ 2L,5L,11L,19L,31L,59L,71L,79L,101L,109L,131L,139L,149L,151L,179L,181L,191L,199L,211L,239L,251L,269L,271L,311L,331L,359L,379L,389L,401L,409L,419L,431L,439L,449L,461L,479L,491L,499L,521L,541L,569L,571L,599L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040105Inst : IEnumerable<long>
{
public static readonly long[] Value=A040105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040105.Bytes);
public long this[int i]=>Value[i];

public static A040105Inst Instance=new A040105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040106
{
public static readonly long[] Value={ 3L,7L,13L,17L,23L,29L,37L,41L,43L,47L,53L,61L,67L,73L,83L,89L,97L,103L,107L,113L,127L,137L,157L,163L,167L,173L,193L,197L,223L,227L,229L,233L,241L,257L,263L,277L,281L,283L,293L,307L,313L,317L,337L,347L,349L,353L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040106Inst : IEnumerable<long>
{
public static readonly long[] Value=A040106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040106.Bytes);
public long this[int i]=>Value[i];

public static A040106Inst Instance=new A040106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040107
{
public static readonly long[] Value={ 2L,3L,5L,19L,23L,43L,47L,67L,71L,97L,139L,149L,163L,167L,173L,191L,211L,239L,241L,263L,283L,307L,311L,331L,359L,379L,383L,389L,409L,431L,457L,461L,479L,499L,503L,523L,547L,557L,571L,577L,599L,601L,619L,643L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040107Inst : IEnumerable<long>
{
public static readonly long[] Value=A040107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040107.Bytes);
public long this[int i]=>Value[i];

public static A040107Inst Instance=new A040107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040108
{
public static readonly long[] Value={ 7L,11L,13L,17L,29L,31L,37L,41L,53L,59L,61L,73L,79L,83L,89L,101L,103L,107L,109L,113L,127L,131L,137L,151L,157L,179L,181L,193L,197L,199L,223L,227L,229L,233L,251L,257L,269L,271L,277L,281L,293L,313L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040108Inst : IEnumerable<long>
{
public static readonly long[] Value=A040108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040108.Bytes);
public long this[int i]=>Value[i];

public static A040108Inst Instance=new A040108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040269
{
public static readonly long[] Value={ 16L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040269Inst : IEnumerable<long>
{
public static readonly long[] Value=A040269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040269.Bytes);
public long this[int i]=>Value[i];

public static A040269Inst Instance=new A040269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040270
{
public static readonly long[] Value={ 16L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040270Inst : IEnumerable<long>
{
public static readonly long[] Value=A040270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040270.Bytes);
public long this[int i]=>Value[i];

public static A040270Inst Instance=new A040270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040271
{
public static readonly long[] Value={ 16L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040271Inst : IEnumerable<long>
{
public static readonly long[] Value=A040271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040271.Bytes);
public long this[int i]=>Value[i];

public static A040271Inst Instance=new A040271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040272
{
public static readonly long[] Value={ 17L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040272Inst : IEnumerable<long>
{
public static readonly long[] Value=A040272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040272.Bytes);
public long this[int i]=>Value[i];

public static A040272Inst Instance=new A040272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040273
{
public static readonly long[] Value={ 17L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040273Inst : IEnumerable<long>
{
public static readonly long[] Value=A040273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040273.Bytes);
public long this[int i]=>Value[i];

public static A040273Inst Instance=new A040273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040274
{
public static readonly long[] Value={ 17L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040274Inst : IEnumerable<long>
{
public static readonly long[] Value=A040274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040274.Bytes);
public long this[int i]=>Value[i];

public static A040274Inst Instance=new A040274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040275
{
public static readonly long[] Value={ 17L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040275Inst : IEnumerable<long>
{
public static readonly long[] Value=A040275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040275.Bytes);
public long this[int i]=>Value[i];

public static A040275Inst Instance=new A040275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040276
{
public static readonly long[] Value={ 17L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040276Inst : IEnumerable<long>
{
public static readonly long[] Value=A040276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040276.Bytes);
public long this[int i]=>Value[i];

public static A040276Inst Instance=new A040276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040277
{
public static readonly long[] Value={ 17L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040277Inst : IEnumerable<long>
{
public static readonly long[] Value=A040277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040277.Bytes);
public long this[int i]=>Value[i];

public static A040277Inst Instance=new A040277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040278
{
public static readonly long[] Value={ 17L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040278Inst : IEnumerable<long>
{
public static readonly long[] Value=A040278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040278.Bytes);
public long this[int i]=>Value[i];

public static A040278Inst Instance=new A040278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040279
{
public static readonly long[] Value={ 17L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040279Inst : IEnumerable<long>
{
public static readonly long[] Value=A040279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040279.Bytes);
public long this[int i]=>Value[i];

public static A040279Inst Instance=new A040279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040280
{
public static readonly long[] Value={ 17L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040280Inst : IEnumerable<long>
{
public static readonly long[] Value=A040280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040280.Bytes);
public long this[int i]=>Value[i];

public static A040280Inst Instance=new A040280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040281
{
public static readonly long[] Value={ 17L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040281Inst : IEnumerable<long>
{
public static readonly long[] Value=A040281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040281.Bytes);
public long this[int i]=>Value[i];

public static A040281Inst Instance=new A040281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040282
{
public static readonly long[] Value={ 17L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040282Inst : IEnumerable<long>
{
public static readonly long[] Value=A040282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040282.Bytes);
public long this[int i]=>Value[i];

public static A040282Inst Instance=new A040282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040283
{
public static readonly long[] Value={ 17L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040283Inst : IEnumerable<long>
{
public static readonly long[] Value=A040283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040283.Bytes);
public long this[int i]=>Value[i];

public static A040283Inst Instance=new A040283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040284
{
public static readonly long[] Value={ 17L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040284Inst : IEnumerable<long>
{
public static readonly long[] Value=A040284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040284.Bytes);
public long this[int i]=>Value[i];

public static A040284Inst Instance=new A040284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040317
{
public static readonly long[] Value={ 18L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L,3L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040317Inst : IEnumerable<long>
{
public static readonly long[] Value=A040317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040317.Bytes);
public long this[int i]=>Value[i];

public static A040317Inst Instance=new A040317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040318
{
public static readonly long[] Value={ 18L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L,1L,4L,2L,11L,1L,3L,1L,2L,36L,2L,1L,3L,1L,11L,2L,4L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040318Inst : IEnumerable<long>
{
public static readonly long[] Value=A040318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040318.Bytes);
public long this[int i]=>Value[i];

public static A040318Inst Instance=new A040318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040319
{
public static readonly long[] Value={ 18L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L,36L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040319Inst : IEnumerable<long>
{
public static readonly long[] Value=A040319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040319.Bytes);
public long this[int i]=>Value[i];

public static A040319Inst Instance=new A040319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040320
{
public static readonly long[] Value={ 18L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L,17L,1L,2L,2L,2L,36L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040320Inst : IEnumerable<long>
{
public static readonly long[] Value=A040320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040320.Bytes);
public long this[int i]=>Value[i];

public static A040320Inst Instance=new A040320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040321
{
public static readonly long[] Value={ 18L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L,1L,8L,1L,1L,1L,1L,3L,2L,36L,2L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040321Inst : IEnumerable<long>
{
public static readonly long[] Value=A040321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040321.Bytes);
public long this[int i]=>Value[i];

public static A040321Inst Instance=new A040321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040322
{
public static readonly long[] Value={ 18L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L,1L,2L,1L,2L,8L,1L,6L,2L,36L,2L,6L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040322Inst : IEnumerable<long>
{
public static readonly long[] Value=A040322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040322.Bytes);
public long this[int i]=>Value[i];

public static A040322Inst Instance=new A040322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040323
{
public static readonly long[] Value={ 18L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L,2L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040323Inst : IEnumerable<long>
{
public static readonly long[] Value=A040323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040323.Bytes);
public long this[int i]=>Value[i];

public static A040323Inst Instance=new A040323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040324
{
public static readonly long[] Value={ 18L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L,1L,5L,3L,1L,17L,1L,3L,5L,1L,11L,1L,1L,36L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040324Inst : IEnumerable<long>
{
public static readonly long[] Value=A040324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040324.Bytes);
public long this[int i]=>Value[i];

public static A040324Inst Instance=new A040324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040325
{
public static readonly long[] Value={ 18L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L,36L,1L,1L,4L,1L,3L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040325Inst : IEnumerable<long>
{
public static readonly long[] Value=A040325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040325.Bytes);
public long this[int i]=>Value[i];

public static A040325Inst Instance=new A040325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040326
{
public static readonly long[] Value={ 18L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L,36L,1L,1L,2L,1L,6L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040326Inst : IEnumerable<long>
{
public static readonly long[] Value=A040326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040326.Bytes);
public long this[int i]=>Value[i];

public static A040326Inst Instance=new A040326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040327
{
public static readonly long[] Value={ 18L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L,36L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040327Inst : IEnumerable<long>
{
public static readonly long[] Value=A040327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040327.Bytes);
public long this[int i]=>Value[i];

public static A040327Inst Instance=new A040327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040328
{
public static readonly long[] Value={ 18L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L,1L,2L,4L,1L,17L,1L,4L,2L,1L,1L,1L,36L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040328Inst : IEnumerable<long>
{
public static readonly long[] Value=A040328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040328.Bytes);
public long this[int i]=>Value[i];

public static A040328Inst Instance=new A040328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040329
{
public static readonly long[] Value={ 18L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040329Inst : IEnumerable<long>
{
public static readonly long[] Value=A040329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040329.Bytes);
public long this[int i]=>Value[i];

public static A040329Inst Instance=new A040329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040330
{
public static readonly long[] Value={ 18L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L,7L,7L,2L,1L,36L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040330Inst : IEnumerable<long>
{
public static readonly long[] Value=A040330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040330.Bytes);
public long this[int i]=>Value[i];

public static A040330Inst Instance=new A040330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040331
{
public static readonly long[] Value={ 18L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L,2L,2L,1L,36L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040331Inst : IEnumerable<long>
{
public static readonly long[] Value=A040331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040331.Bytes);
public long this[int i]=>Value[i];

public static A040331Inst Instance=new A040331Inst();

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