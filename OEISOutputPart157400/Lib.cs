using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200505
{
public static readonly long[] Value={ 0L,0L,4L,4L,0L,0L,4L,4L,5L,0L,4L,4L,24L,5L,4L,4L,0L,15L,4L,4L,75L,0L,4L,4L,0L,0L,4L,4L,5L,39L,4L,4L,15L,5L,4L,4L,24L,35L,4L,4L,175L,31L,4L,4L,0L,39L,4L,4L,5L,0L,4L,4L,35L,5L,4L,4L,21L,55L,4L,4L,24L,0L,4L,4L,31L,39L,4L,4L,5L,399L,4L,4L,31L,5L,4L,4L,0L,15L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200505Inst : IEnumerable<long>
{
public static readonly long[] Value=A200505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200505.Bytes);
public long this[int i]=>Value[i];

public static A200505Inst Instance=new A200505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200506
{
public static readonly long[] Value={ 0L,0L,0L,5L,5L,0L,0L,9L,5L,5L,7L,0L,63L,5L,5L,36L,9L,7L,5L,5L,0L,44L,9L,5L,5L,9L,16L,0L,5L,5L,16L,7L,0L,5L,5L,0L,0L,21L,5L,5L,9L,16L,16L,5L,5L,7L,12L,0L,5L,5L,28L,36L,7L,5L,5L,12L,192L,16L,5L,5L,37L,9L,16L,5L,5L,24L,7L,9L,5L,5L,9L,0L,0L,5L,5L,36L,9L,52L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200506Inst : IEnumerable<long>
{
public static readonly long[] Value=A200506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200506.Bytes);
public long this[int i]=>Value[i];

public static A200506Inst Instance=new A200506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200507
{
public static readonly long[] Value={ 0L,0L,3L,0L,8L,3L,0L,0L,3L,7L,8L,3L,8L,0L,3L,16L,7L,3L,8L,0L,3L,16L,28L,3L,0L,16L,3L,16L,8L,3L,7L,16L,3L,0L,8L,3L,8L,7L,3L,28L,0L,3L,8L,16L,3L,0L,19L,3L,0L,0L,3L,7L,8L,3L,0L,20L,3L,16L,7L,3L,8L,100L,3L,16L,35L,3L,8L,28L,3L,16L,20L,3L,7L,16L,3L,16L,8L,3L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200507Inst : IEnumerable<long>
{
public static readonly long[] Value=A200507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200507.Bytes);
public long this[int i]=>Value[i];

public static A200507Inst Instance=new A200507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200508
{
public static readonly long[] Value={ 0L,0L,4L,7L,0L,7L,4L,0L,0L,7L,4L,8L,7L,20L,4L,0L,7L,7L,4L,7L,9L,16L,4L,7L,7L,16L,4L,8L,0L,9L,4L,7L,9L,7L,4L,8L,48L,7L,4L,0L,7L,9L,4L,8L,7L,7L,4L,7L,0L,20L,4L,7L,7L,12L,4L,0L,9L,16L,4L,7L,0L,7L,4L,0L,0L,7L,4L,8L,7L,16L,4L,0L,7L,7L,4L,7L,32L,9L,4L,7L,7L,44L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200508Inst : IEnumerable<long>
{
public static readonly long[] Value=A200508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200508.Bytes);
public long this[int i]=>Value[i];

public static A200508Inst Instance=new A200508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200509
{
public static readonly long[] Value={ 0L,0L,4L,4L,8L,0L,4L,4L,0L,0L,4L,4L,8L,9L,4L,4L,9L,0L,4L,4L,8L,80L,4L,4L,45L,9L,4L,4L,8L,80L,4L,4L,0L,45L,4L,4L,8L,21L,4L,4L,9L,61L,4L,4L,8L,0L,4L,4L,45L,9L,4L,4L,8L,0L,4L,4L,0L,80L,4L,4L,8L,9L,4L,4L,15L,0L,4L,4L,8L,45L,4L,4L,0L,15L,4L,4L,8L,0L,4L,4L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200509Inst : IEnumerable<long>
{
public static readonly long[] Value=A200509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200509.Bytes);
public long this[int i]=>Value[i];

public static A200509Inst Instance=new A200509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200510
{
public static readonly long[] Value={ 0L,0L,3L,5L,9L,3L,0L,9L,3L,0L,0L,3L,35L,5L,3L,11L,9L,3L,5L,0L,3L,16L,9L,3L,11L,9L,3L,20L,5L,3L,16L,9L,3L,5L,9L,3L,0L,11L,3L,0L,9L,3L,20L,5L,3L,32L,11L,3L,5L,9L,3L,0L,9L,3L,28L,37L,3L,11L,5L,3L,200L,9L,3L,5L,0L,3L,16L,9L,3L,16L,9L,3L,35L,5L,3L,0L,9L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200510Inst : IEnumerable<long>
{
public static readonly long[] Value=A200510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200510.Bytes);
public long this[int i]=>Value[i];

public static A200510Inst Instance=new A200510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200511
{
public static readonly long[] Value={ 12L,18L,20L,24L,28L,36L,40L,44L,45L,48L,50L,52L,54L,56L,63L,68L,72L,75L,76L,80L,88L,92L,96L,98L,99L,100L,104L,108L,112L,116L,117L,124L,135L,136L,144L,147L,148L,152L,153L,160L,162L,164L,171L,172L,175L,176L,184L,188L,189L,192L,196L,200L,207L,208L,212L,216L,224L,225L,232L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200511Inst : IEnumerable<long>
{
public static readonly long[] Value=A200511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200511.Bytes);
public long this[int i]=>Value[i];

public static A200511Inst Instance=new A200511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200512
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,15L,16L,0L,24L,0L,0L,0L,0L,12L,24L,0L,0L,16L,0L,0L,15L,16L,16L,0L,40L,12L,20L,0L,0L,0L,0L,0L,24L,16L,28L,15L,0L,12L,16L,64L,0L,20L,0L,0L,0L,20L,20L,39L,40L,12L,15L,0L,0L,16L,16L,0L,24L,0L,0L,0L,0L,12L,24L,0L,40L,15L,20L,112L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200512Inst : IEnumerable<long>
{
public static readonly long[] Value=A200512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200512.Bytes);
public long this[int i]=>Value[i];

public static A200512Inst Instance=new A200512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200513
{
public static readonly long[] Value={ 0L,0L,8L,0L,8L,9L,0L,0L,0L,0L,8L,9L,8L,0L,9L,0L,0L,12L,8L,0L,8L,28L,0L,9L,0L,20L,8L,0L,8L,9L,20L,80L,9L,0L,8L,0L,8L,0L,9L,63L,0L,9L,8L,80L,8L,20L,0L,9L,0L,28L,8L,63L,8L,12L,0L,0L,9L,36L,8L,9L,8L,0L,12L,0L,532L,9L,8L,80L,8L,108L,20L,15L,0L,0L,8L,63L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200513Inst : IEnumerable<long>
{
public static readonly long[] Value=A200513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200513.Bytes);
public long this[int i]=>Value[i];

public static A200513Inst Instance=new A200513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200514
{
public static readonly long[] Value={ 0L,3L,4L,0L,3L,0L,4L,3L,0L,0L,3L,16L,0L,3L,4L,0L,3L,0L,4L,3L,0L,0L,3L,16L,0L,3L,4L,16L,3L,40L,4L,3L,0L,0L,3L,0L,0L,3L,4L,16L,3L,63L,4L,3L,63L,0L,3L,20L,0L,3L,4L,20L,3L,40L,4L,3L,80L,0L,3L,16L,0L,3L,4L,0L,3L,0L,4L,3L,0L,40L,3L,16L,80L,3L,4L,16L,3L,0L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200514Inst : IEnumerable<long>
{
public static readonly long[] Value=A200514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200514.Bytes);
public long this[int i]=>Value[i];

public static A200514Inst Instance=new A200514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200515
{
public static readonly long[] Value={ 0L,4L,4L,0L,0L,4L,4L,5L,0L,4L,4L,0L,5L,4L,4L,0L,24L,4L,4L,0L,0L,4L,4L,35L,0L,4L,4L,5L,15L,4L,4L,0L,5L,4L,4L,0L,24L,4L,4L,0L,24L,4L,4L,15L,0L,4L,4L,5L,0L,4L,4L,0L,5L,4L,4L,39L,0L,4L,4L,0L,24L,4L,4L,0L,24L,4L,4L,5L,35L,4L,4L,0L,5L,4L,4L,0L,0L,4L,4L,63L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200515Inst : IEnumerable<long>
{
public static readonly long[] Value=A200515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200515.Bytes);
public long this[int i]=>Value[i];

public static A200515Inst Instance=new A200515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200516
{
public static readonly long[] Value={ 0L,5L,5L,0L,7L,9L,5L,5L,0L,0L,0L,5L,5L,0L,9L,0L,5L,5L,7L,0L,9L,5L,5L,9L,0L,7L,5L,5L,0L,9L,0L,5L,5L,36L,16L,0L,5L,5L,9L,7L,0L,5L,5L,0L,21L,0L,5L,5L,0L,43L,9L,5L,5L,7L,16L,16L,5L,5L,0L,9L,7L,5L,5L,0L,0L,9L,5L,5L,9L,36L,16L,5L,5L,0L,7L,0L,5L,5L,32L,24L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200516Inst : IEnumerable<long>
{
public static readonly long[] Value=A200516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200516.Bytes);
public long this[int i]=>Value[i];

public static A200516Inst Instance=new A200516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200517
{
public static readonly long[] Value={ 0L,3L,0L,0L,3L,7L,8L,3L,0L,0L,3L,16L,7L,3L,8L,0L,3L,16L,0L,3L,8L,16L,3L,16L,0L,3L,7L,16L,3L,0L,8L,3L,0L,7L,3L,0L,8L,3L,8L,16L,3L,28L,0L,3L,8L,19L,3L,7L,0L,3L,20L,0L,3L,16L,7L,3L,100L,0L,3L,16L,8L,3L,8L,0L,3L,16L,28L,3L,7L,16L,3L,16L,0L,3L,0L,7L,3L,19L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200517Inst : IEnumerable<long>
{
public static readonly long[] Value=A200517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200517.Bytes);
public long this[int i]=>Value[i];

public static A200517Inst Instance=new A200517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200518
{
public static readonly long[] Value={ 0L,0L,4L,0L,7L,7L,4L,9L,0L,7L,4L,7L,7L,8L,4L,0L,7L,0L,4L,7L,32L,8L,4L,7L,0L,7L,4L,16L,0L,8L,4L,9L,7L,7L,4L,0L,0L,7L,4L,7L,7L,0L,4L,9L,7L,8L,4L,7L,0L,9L,4L,7L,9L,7L,4L,12L,0L,0L,4L,16L,7L,7L,4L,0L,0L,7L,4L,7L,7L,8L,4L,16L,7L,0L,4L,7L,9L,8L,4L,7L,0L,7L,4L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200518Inst : IEnumerable<long>
{
public static readonly long[] Value=A200518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200518.Bytes);
public long this[int i]=>Value[i];

public static A200518Inst Instance=new A200518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200519
{
public static readonly long[] Value={ 0L,4L,4L,0L,8L,4L,4L,0L,0L,4L,4L,9L,8L,4L,4L,0L,0L,4L,4L,0L,8L,4L,4L,9L,0L,4L,4L,0L,8L,4L,4L,80L,9L,4L,4L,0L,8L,4L,4L,63L,0L,4L,4L,80L,8L,4L,4L,9L,0L,4L,4L,45L,8L,4L,4L,0L,9L,4L,4L,9L,8L,4L,4L,0L,133L,4L,4L,80L,8L,4L,4L,15L,0L,4L,4L,63L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200519Inst : IEnumerable<long>
{
public static readonly long[] Value=A200519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200519.Bytes);
public long this[int i]=>Value[i];

public static A200519Inst Instance=new A200519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200520
{
public static readonly long[] Value={ 0L,3L,5L,0L,3L,9L,0L,3L,0L,11L,3L,9L,5L,3L,9L,0L,3L,5L,11L,3L,9L,0L,3L,9L,0L,3L,0L,5L,3L,9L,16L,3L,5L,20L,3L,0L,1001L,3L,9L,0L,3L,9L,5L,3L,0L,56L,3L,5L,0L,3L,9L,11L,3L,11L,0L,3L,9L,5L,3L,9L,112L,3L,5L,0L,3L,9L,16L,3L,9L,0L,3L,0L,5L,3L,9L,11L,3L,5L,16L,3L,0L,3367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200520Inst : IEnumerable<long>
{
public static readonly long[] Value=A200520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200520.Bytes);
public long this[int i]=>Value[i];

public static A200520Inst Instance=new A200520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200521
{
public static readonly long[] Value={ 420L,630L,660L,780L,840L,924L,990L,1020L,1050L,1092L,1140L,1170L,1260L,1320L,1380L,1386L,1428L,1470L,1530L,1540L,1560L,1596L,1638L,1650L,1680L,1710L,1716L,1740L,1820L,1848L,1860L,1890L,1932L,1950L,1980L,2040L,2070L,2100L,2142L,2184L,2220L,2244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200521Inst : IEnumerable<long>
{
public static readonly long[] Value=A200521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200521.Bytes);
public long this[int i]=>Value[i];

public static A200521Inst Instance=new A200521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200522
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,15L,12L,0L,0L,20L,16L,24L,0L,32L,20L,0L,0L,28L,12L,56L,15L,16L,16L,0L,112L,68L,16L,40L,0L,20L,12L,0L,0L,52L,20L,15L,80L,16L,16L,0L,112L,36L,12L,56L,33L,28L,28L,0L,0L,20L,15L,40L,128L,16L,12L,0L,117L,48L,16L,24L,0L,44L,28L,0L,0L,15L,12L,40L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200522Inst : IEnumerable<long>
{
public static readonly long[] Value=A200522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200522.Bytes);
public long this[int i]=>Value[i];

public static A200522Inst Instance=new A200522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200523
{
public static readonly long[] Value={ 0L,0L,0L,0L,8L,0L,8L,9L,0L,0L,12L,0L,8L,9L,8L,20L,9L,0L,0L,12L,8L,80L,8L,0L,45L,9L,0L,0L,8L,80L,8L,9L,0L,45L,9L,20L,8L,21L,8L,80L,9L,80L,28L,9L,8L,0L,8L,0L,91L,9L,20L,36L,8L,0L,8L,12L,0L,80L,9L,80L,8L,9L,8L,28L,15L,0L,91L,9L,8L,45L,8L,0L,0L,15L,0L,20L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200523Inst : IEnumerable<long>
{
public static readonly long[] Value=A200523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200523.Bytes);
public long this[int i]=>Value[i];

public static A200523Inst Instance=new A200523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200524
{
public static readonly long[] Value={ 0L,0L,3L,0L,0L,3L,4L,0L,3L,16L,4L,3L,0L,20L,3L,0L,0L,3L,4L,56L,3L,16L,4L,3L,80L,16L,3L,40L,0L,3L,4L,0L,3L,20L,4L,3L,64L,16L,3L,0L,63L,3L,4L,56L,3L,28L,4L,3L,0L,20L,3L,40L,63L,3L,4L,0L,3L,16L,4L,3L,0L,28L,3L,0L,0L,3L,4L,40L,3L,16L,4L,3L,85L,16L,3L,56L,63L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200524Inst : IEnumerable<long>
{
public static readonly long[] Value=A200524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200524.Bytes);
public long this[int i]=>Value[i];

public static A200524Inst Instance=new A200524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200525
{
public static readonly long[] Value={ 385L,2585L,7315L,8911L,27001L,39905L,48391L,87283L,192211L,196285L,319705L,410089L,425585L,441091L,624605L,679855L,1310185L,1899163L,2460439L,2586971L,2777041L,6654005L,7042411L,7501261L,8291459L,9516637L,10484585L,11141671L,12527281L,13015891L,13788319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200525Inst : IEnumerable<long>
{
public static readonly long[] Value=A200525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200525.Bytes);
public long this[int i]=>Value[i];

public static A200525Inst Instance=new A200525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200526
{
public static readonly BigInteger[] Value={ 2156316023L,211148507797805L,BigInteger.Parse("392841376460687116573"),BigInteger.Parse("13886731309220741899538675431"),BigInteger.Parse("1359801885649216204023955447726829"),BigInteger.Parse("2529908688645864568558938918274367865293"),BigInteger.Parse("89430911052730984787593270943984417274689212615") };
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
public class A200526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200526Inst Instance=new A200526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200527
{
public static readonly long[] Value={ 3L,20L,243L,4848L,167171L,10000162L,1056792824L,201092476918L,70051408245054L,45119084364602004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200527Inst : IEnumerable<long>
{
public static readonly long[] Value=A200527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200527.Bytes);
public long this[int i]=>Value[i];

public static A200527Inst Instance=new A200527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200528
{
public static readonly long[] Value={ 6L,20L,57L,146L,354L,825L,1873L,4169L,9144L,19825L,42590L,90815L,192457L,405760L,851740L,1781227L,3713015L,7718092L,16003641L,33111477L,68374642L,140947848L,290098848L,596244613L,1223916576L,2509450811L,5139839214L,10517282966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200528Inst : IEnumerable<long>
{
public static readonly long[] Value=A200528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200528.Bytes);
public long this[int i]=>Value[i];

public static A200528Inst Instance=new A200528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200529
{
public static readonly long[] Value={ 11L,57L,243L,905L,3135L,10292L,32556L,100065L,300847L,888587L,2586994L,7441963L,21193523L,59838942L,167704775L,466986683L,1293018711L,3562315723L,9770764284L,26693067952L,72663897633L,197170483178L,533459459628L,1439508706370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200529Inst : IEnumerable<long>
{
public static readonly long[] Value=A200529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200529.Bytes);
public long this[int i]=>Value[i];

public static A200529Inst Instance=new A200529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200530
{
public static readonly long[] Value={ 19L,146L,905L,4848L,23925L,111085L,494555L,2132979L,8981773L,37125420L,151253915L,609247412L,2432002859L,9638730963L,37983584772L,149003379789L,582403346152L,2269881052166L,8826625108206L,34261690527204L,132805131519232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200530Inst : IEnumerable<long>
{
public static readonly long[] Value=A200530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200530.Bytes);
public long this[int i]=>Value[i];

public static A200530Inst Instance=new A200530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200531
{
public static readonly long[] Value={ 32L,354L,3135L,23925L,167171L,1092645L,6820330L,41135050L,241717185L,1391776867L,7886862976L,44130194797L,244429190692L,1342743707709L,7326819179875L,39759798789392L,214782513374737L,1155893422272121L,6201199013944784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200531Inst : IEnumerable<long>
{
public static readonly long[] Value=A200531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200531.Bytes);
public long this[int i]=>Value[i];

public static A200531Inst Instance=new A200531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200532
{
public static readonly long[] Value={ 53L,825L,10292L,111085L,1092645L,10000162L,87098434L,731106792L,5964324991L,47562454949L,372415747947L,2872854627301L,21889626638130L,165068050869351L,1233859196014348L,9153541048411929L,67464412472963033L,494406133695289336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200532Inst : IEnumerable<long>
{
public static readonly long[] Value=A200532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200532.Bytes);
public long this[int i]=>Value[i];

public static A200532Inst Instance=new A200532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200533
{
public static readonly long[] Value={ 87L,1873L,32556L,494555L,6820330L,87098434L,1056792824L,12348422785L,140068079857L,1551453118671L,16861973522704L,180469353488204L,1907201493832312L,19944555935687461L,206749466424763994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200533Inst : IEnumerable<long>
{
public static readonly long[] Value=A200533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200533.Bytes);
public long this[int i]=>Value[i];

public static A200533Inst Instance=new A200533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200534
{
public static readonly long[] Value={ 3L,6L,6L,11L,20L,11L,19L,57L,57L,19L,32L,146L,243L,146L,32L,53L,354L,905L,905L,354L,53L,87L,825L,3135L,4848L,3135L,825L,87L,142L,1873L,10292L,23925L,23925L,10292L,1873L,142L,231L,4169L,32556L,111085L,167171L,111085L,32556L,4169L,231L,375L,9144L,100065L,494555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200534Inst : IEnumerable<long>
{
public static readonly long[] Value=A200534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200534.Bytes);
public long this[int i]=>Value[i];

public static A200534Inst Instance=new A200534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200535
{
public static readonly long[] Value={ 1L,1L,4L,5L,9L,12L,16L,20L,24L,28L,32L,36L,40L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,128L,132L,136L,140L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L,236L,240L,244L,248L,252L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200535Inst : IEnumerable<long>
{
public static readonly long[] Value=A200535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200535.Bytes);
public long this[int i]=>Value[i];

public static A200535Inst Instance=new A200535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200536
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,6L,13L,12L,4L,1L,9L,33L,63L,66L,36L,8L,1L,12L,62L,180L,321L,360L,248L,96L,16L,1L,15L,100L,390L,985L,1683L,1970L,1560L,800L,240L,32L,1L,18L,147L,720L,2355L,5418L,8989L,10836L,9420L,5760L,2352L,576L,64L,1L,21L,203L,1197L,4809L,13923L,29953L,48639L,59906L,55692L,38472L,19152L,6496L,1344L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200536Inst : IEnumerable<long>
{
public static readonly long[] Value=A200536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200536.Bytes);
public long this[int i]=>Value[i];

public static A200536Inst Instance=new A200536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200537
{
public static readonly long[] Value={ 1L,1L,9L,13L,40L,72L,144L,252L,432L,720L,1152L,1872L,2880L,4608L,6912L,10944L,16128L,25344L,36864L,57600L,82944L,129024L,184320L,285696L,405504L,626688L,884736L,1363968L,1916928L,2949120L,4128768L,6340608L,8847360L,13565952L,18874368L,28901376L,40108032L,61341696L,84934656L,129761280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200537Inst : IEnumerable<long>
{
public static readonly long[] Value=A200537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200537.Bytes);
public long this[int i]=>Value[i];

public static A200537Inst Instance=new A200537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200538
{
public static readonly long[] Value={ 1L,1L,6L,20L,99L,441L,2193L,10795L,55233L,284735L,1494404L,7914270L,42360541L,228460935L,1241224182L,6784445340L,37288826697L,205937705799L,1142317727466L,6361104740100L,35548154733969L,199295884785459L,1120615326442269L,6318077793648075L,35710056983891367L,202297486497822121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200538Inst : IEnumerable<long>
{
public static readonly long[] Value=A200538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200538.Bytes);
public long this[int i]=>Value[i];

public static A200538Inst Instance=new A200538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200539
{
public static readonly long[] Value={ 1L,1L,4L,12L,45L,168L,663L,2667L,10982L,45925L,194732L,834912L,3614063L,15771795L,69316740L,306534564L,1362986799L,6089916936L,27328613142L,123118156260L,556626199974L,2524659817449L,11484671681511L,52384730922720L,239534402969925L,1097805759803893L,5042014405418968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200539Inst : IEnumerable<long>
{
public static readonly long[] Value=A200539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200539.Bytes);
public long this[int i]=>Value[i];

public static A200539Inst Instance=new A200539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200540
{
public static readonly long[] Value={ 1L,2L,10L,48L,261L,1470L,8619L,51816L,318155L,1985630L,12561308L,80360280L,519013571L,3379514970L,22161470850L,146227235904L,970126550763L,6467496499590L,43304243215638L,291087137589552L,1963598081845335L,13288619577124122L,90195242361688863L,613843707553183800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200540Inst : IEnumerable<long>
{
public static readonly long[] Value=A200540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200540.Bytes);
public long this[int i]=>Value[i];

public static A200540Inst Instance=new A200540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200541
{
public static readonly long[] Value={ 1L,1L,4L,12L,35L,104L,312L,924L,2754L,8195L,24386L,72576L,215991L,642785L,1912960L,5693016L,16942573L,50421592L,150056090L,446571180L,1329008590L,3955167387L,11770690808L,35029911168L,104250013425L,310251009501L,923315841860L,2747814245904L,8177573467339L,24336691577000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200541Inst : IEnumerable<long>
{
public static readonly long[] Value=A200541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200541.Bytes);
public long this[int i]=>Value[i];

public static A200541Inst Instance=new A200541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200542
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,8L,17L,41L,113L,340L,1070L,3592L,12979L,50107L,204325L,875702L,3947560L,18724328L,93137201L,484066913L,2623523381L,14811843184L,87000588266L,530736806728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200542Inst : IEnumerable<long>
{
public static readonly long[] Value=A200542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200542.Bytes);
public long this[int i]=>Value[i];

public static A200542Inst Instance=new A200542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200543
{
public static readonly long[] Value={ 1L,1L,2L,12L,35L,117L,408L,1364L,4617L,15645L,52882L,178920L,605331L,2047705L,6927424L,23435384L,79281057L,268206185L,907335090L,3069491988L,10384017875L,35128880685L,118840150776L,402033352684L,1360069088841L,4601080767717L,15565344749410L,52657184101648L,178137977818211L,602636462317425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200543Inst : IEnumerable<long>
{
public static readonly long[] Value=A200543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200543.Bytes);
public long this[int i]=>Value[i];

public static A200543Inst Instance=new A200543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200544
{
public static readonly long[] Value={ 1L,1L,3L,6L,14L,28L,61L,122L,253L,505L,1017L,2008L,3976L,7769L,15169L,29379L,56751L,108993L,208725L,397913L,756385L,1432578L,2705744L,5094749L,9568504L,17922756L,33492061L,62438472L,116151352L,215612548L,399451325L,738612472L,1363261171L,2511748010L,4620024202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200544Inst : IEnumerable<long>
{
public static readonly long[] Value=A200544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200544.Bytes);
public long this[int i]=>Value[i];

public static A200544Inst Instance=new A200544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200545
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,4L,1L,0L,1L,13L,9L,1L,0L,1L,46L,56L,16L,1L,0L,1L,199L,334L,160L,25L,1L,0L,1L,1072L,2157L,1408L,365L,36L,1L,0L,1L,6985L,15701L,12445L,4417L,721L,49L,1L,0L,1L,53218L,129214L,116698L,50944L,11452L,1288L,64L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200545Inst : IEnumerable<long>
{
public static readonly long[] Value=A200545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200545.Bytes);
public long this[int i]=>Value[i];

public static A200545Inst Instance=new A200545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200546
{
public static readonly long[] Value={ 4L,14L,26L,72L,142L,362L,778L,1938L,4366L,10628L,24532L,59138L,138680L,333014L,788374L,1890870L,4503208L,10803262L,25831504L,62025512L,148725902L,357516682L,859055042L,2067463940L,4975921904L,11988835382L,28892947100L,69685951942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200546Inst : IEnumerable<long>
{
public static readonly long[] Value=A200546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200546.Bytes);
public long this[int i]=>Value[i];

public static A200546Inst Instance=new A200546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200547
{
public static readonly long[] Value={ 14L,76L,280L,1240L,4978L,21626L,91058L,393660L,1686980L,7309386L,31632968L,137600876L,599055566L,2615427970L,11433493630L,50075195034L,219589525108L,964264276780L,4238966033150L,18655002576606L,82175337524524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200547Inst : IEnumerable<long>
{
public static readonly long[] Value=A200547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200547.Bytes);
public long this[int i]=>Value[i];

public static A200547Inst Instance=new A200547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200548
{
public static readonly long[] Value={ 30L,200L,1184L,7254L,43698L,266812L,1639804L,10152636L,63132188L,394016210L,2466471522L,15481097890L,97396742734L,614019893832L,3878005568152L,24532092598782L,155413031752230L,985836563404470L,6260856742508844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200548Inst : IEnumerable<long>
{
public static readonly long[] Value=A200548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200548.Bytes);
public long this[int i]=>Value[i];

public static A200548Inst Instance=new A200548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200549
{
public static readonly long[] Value={ 52L,446L,3396L,26850L,211374L,1689732L,13587804L,109957140L,893510530L,7288331916L,59637096784L,489325754576L,4024444316206L,33167657580268L,273853057747366L,2264784856966600L,18757225819498566L,155553439876468586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200549Inst : IEnumerable<long>
{
public static readonly long[] Value=A200549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200549.Bytes);
public long this[int i]=>Value[i];

public static A200549Inst Instance=new A200549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200550
{
public static readonly long[] Value={ 80L,836L,7778L,75792L,737460L,7286542L,72366820L,723237026L,7258296910L,73127883596L,739101010202L,7490787201124L,76099633989974L,774719436417776L,7901415122713726L,80719023935569240L,825814487838111514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200550Inst : IEnumerable<long>
{
public static readonly long[] Value=A200550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200550.Bytes);
public long this[int i]=>Value[i];

public static A200550Inst Instance=new A200550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200551
{
public static readonly long[] Value={ 114L,1368L,15476L,178834L,2076774L,24378976L,288237528L,3427837106L,40950125796L,491063998130L,5907663402532L,71267752107030L,861806880210532L,10443265297671942L,126784115884242080L,1541722886174306634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200551Inst : IEnumerable<long>
{
public static readonly long[] Value=A200551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200551.Bytes);
public long this[int i]=>Value[i];

public static A200551Inst Instance=new A200551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200552
{
public static readonly long[] Value={ 154L,2134L,27806L,372150L,5012084L,68263780L,936121220L,12911643944L,178893425570L,2488110363432L,34717386812304L,485767803378730L,6813227225653584L,95761068651953630L,1348433104134460586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200552Inst : IEnumerable<long>
{
public static readonly long[] Value=A200552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200552.Bytes);
public long this[int i]=>Value[i];

public static A200552Inst Instance=new A200552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200553
{
public static readonly long[] Value={ 4L,14L,14L,30L,76L,26L,52L,200L,280L,72L,80L,446L,1184L,1240L,142L,114L,836L,3396L,7254L,4978L,362L,154L,1368L,7778L,26850L,43698L,21626L,778L,200L,2134L,15476L,75792L,211374L,266812L,91058L,1938L,252L,3140L,27806L,178834L,737460L,1689732L,1639804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200553Inst : IEnumerable<long>
{
public static readonly long[] Value=A200553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200553.Bytes);
public long this[int i]=>Value[i];

public static A200553Inst Instance=new A200553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200554
{
public static readonly long[] Value={ 14L,76L,200L,446L,836L,1368L,2134L,3140L,4368L,5942L,7852L,10064L,12734L,15836L,19320L,23374L,27956L,33000L,38726L,45076L,51968L,59654L,68060L,77088L,87022L,97772L,109224L,121694L,135076L,149240L,164534L,180836L,198000L,216406L,235916L,256368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200554Inst : IEnumerable<long>
{
public static readonly long[] Value=A200554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200554.Bytes);
public long this[int i]=>Value[i];

public static A200554Inst Instance=new A200554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200555
{
public static readonly long[] Value={ 26L,280L,1184L,3396L,7778L,15476L,27806L,46346L,72902L,109528L,158422L,222162L,303412L,405134L,530518L,683014L,866156L,1083954L,1340420L,1639900L,1986968L,2386470L,2843276L,3362828L,3950486L,4611980L,5353268L,6180592L,7100158L,8118840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200555Inst : IEnumerable<long>
{
public static readonly long[] Value=A200555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200555.Bytes);
public long this[int i]=>Value[i];

public static A200555Inst Instance=new A200555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200556
{
public static readonly long[] Value={ 72L,1240L,7254L,26850L,75792L,178834L,372150L,705270L,1242888L,2067650L,3281874L,5009232L,7397868L,10621792L,14882672L,20413220L,27478160L,36376230L,47443518L,61054528L,77624122L,97610834L,121518006L,149895400L,183343046L,222512226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200556Inst : IEnumerable<long>
{
public static readonly long[] Value=A200556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200556.Bytes);
public long this[int i]=>Value[i];

public static A200556Inst Instance=new A200556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200557
{
public static readonly long[] Value={ 142L,4978L,43698L,211374L,737460L,2076774L,5012084L,10807826L,21368704L,39388482L,68614738L,114064374L,182196622L,281328582L,421889370L,616590012L,881040966L,1234022180L,1697613488L,2298081194L,3066132222L,4036964078L,5251498784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200557Inst : IEnumerable<long>
{
public static readonly long[] Value=A200557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200557.Bytes);
public long this[int i]=>Value[i];

public static A200557Inst Instance=new A200557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200558
{
public static readonly long[] Value={ 362L,21626L,266812L,1689732L,7286542L,24378976L,68263780L,167521092L,371147726L,758120242L,1449515972L,2623194882L,4532144132L,7526204850L,12076969112L,18807807576L,28527996642L,42270457652L,61336410730L,87344689150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200558Inst : IEnumerable<long>
{
public static readonly long[] Value=A200558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200558.Bytes);
public long this[int i]=>Value[i];

public static A200558Inst Instance=new A200558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200559
{
public static readonly long[] Value={ 778L,91058L,1639804L,13587804L,72366820L,288237528L,936121220L,2613794508L,6492378076L,14694189538L,30833955936L,60757353766L,113535692414L,202761648044L,348183768616L,577776075892L,930286238568L,1458297755836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200559Inst : IEnumerable<long>
{
public static readonly long[] Value=A200559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200559.Bytes);
public long this[int i]=>Value[i];

public static A200559Inst Instance=new A200559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200560
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,180L,1502L,15456L,189208L,2683920L,43263962L,780807456L,15593180788L,341340941760L,8126644655222L,209050212857856L,5777935570510768L,170755837008595200L,5373097909706399282L,BigInteger.Parse("179351443518333574656"),BigInteger.Parse("6329687401322560131148"),BigInteger.Parse("235491796312126982538240") };
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
public class A200560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200560Inst Instance=new A200560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200561
{
public static readonly long[] Value={ 2L,-2L,6L,6L,-10L,70L,-42L,102L,374L,-506L,2070L,-90L,182L,16198L,-16554L,50406L,46070L,-77690L,573078L,-359898L,884534L,2980294L,-4090410L,17127270L,-1465738L,2996998L,131089686L,-136821594L,422976950L,352097350L,-600716202L,4688726502L,-3073380106L,7645103494L,23717948310L,-33014782170L,141611506742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200561Inst : IEnumerable<long>
{
public static readonly long[] Value=A200561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200561.Bytes);
public long this[int i]=>Value[i];

public static A200561Inst Instance=new A200561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200562
{
public static readonly long[] Value={ 1L,-1L,3L,3L,-5L,35L,-21L,51L,187L,-253L,1035L,-45L,91L,8099L,-8277L,25203L,23035L,-38845L,286539L,-179949L,442267L,1490147L,-2045205L,8563635L,-732869L,1498499L,65544843L,-68410797L,211488475L,176048675L,-300358101L,2344363251L,-1536690053L,3822551747L,11858974155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200562Inst : IEnumerable<long>
{
public static readonly long[] Value=A200562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200562.Bytes);
public long this[int i]=>Value[i];

public static A200562Inst Instance=new A200562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200563
{
public static readonly long[] Value={ 2L,6L,-2L,30L,14L,30L,238L,-66L,782L,990L,46L,8190L,-178L,16926L,48238L,-15810L,247694L,106590L,262318L,1932414L,-555058L,6518430L,7830766L,765630L,67043342L,-2865954L,143077678L,387537150L,-124309426L,2044005150L,807673198L,2285861694L,15681525902L,-4648416930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200563Inst : IEnumerable<long>
{
public static readonly long[] Value=A200563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200563.Bytes);
public long this[int i]=>Value[i];

public static A200563Inst Instance=new A200563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200564
{
public static readonly BigInteger[] Value={ 1L,2L,12L,288L,33280L,16793600L,34360786944L,281475110928384L,9223372071214514176UL,BigInteger.Parse("1208925819632221360750592"),BigInteger.Parse("633825300114132715146861084672"),BigInteger.Parse("1329227995784915909797295207699447808"),BigInteger.Parse("11150372599265311570918974863776009399828480") };
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
public class A200564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200564Inst Instance=new A200564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200565
{
public static readonly long[] Value={ 819L,5256L,838044L,322001299796379844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200565Inst : IEnumerable<long>
{
public static readonly long[] Value=A200565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200565.Bytes);
public long this[int i]=>Value[i];

public static A200565Inst Instance=new A200565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200566
{
public static readonly long[] Value={ 2L,4L,8L,10L,14L,20L,22L,28L,32L,34L,38L,44L,50L,52L,182L,242L,284L,528L,868L,5246L,8473L,8784L,48503L,48509L,146065L,438122L,591216L,1312724L,4325171L,6629045L,6823284L,56075700L,154392832L,248932942L,251237694L,1913253200L,3123337916L,3180792660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200566Inst : IEnumerable<long>
{
public static readonly long[] Value=A200566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200566.Bytes);
public long this[int i]=>Value[i];

public static A200566Inst Instance=new A200566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200567
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,19L,21L,27L,31L,33L,37L,43L,49L,51L,117L,201L,527L,867L,3472L,8472L,48508L,146064L,373824L,591215L,4325170L,6629044L,6823283L,30188529L,105066156L,203403620L,203403621L,323547634L,439515072L,478478082L,585101566L,1170278794L,2809596042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200567Inst : IEnumerable<long>
{
public static readonly long[] Value=A200567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200567.Bytes);
public long this[int i]=>Value[i];

public static A200567Inst Instance=new A200567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200568
{
public static readonly long[] Value={ 2L,6L,8L,12L,18L,20L,26L,30L,32L,36L,42L,48L,50L,116L,200L,212L,296L,320L,527L,3471L,8471L,48507L,85760L,104661L,283968L,1487448L,2982728L,3500623L,6748298L,6804175L,11135837L,11421278L,18567910L,25039773L,31512846L,203403620L,1170278793L,2809596041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200568Inst : IEnumerable<long>
{
public static readonly long[] Value=A200568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200568.Bytes);
public long this[int i]=>Value[i];

public static A200568Inst Instance=new A200568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200569
{
public static readonly long[] Value={ 1L,5L,7L,11L,17L,19L,25L,29L,31L,35L,41L,47L,49L,115L,119L,125L,127L,137L,139L,295L,319L,1333L,1334L,3470L,8470L,48506L,85759L,87165L,416320L,721404L,2731942L,3500623L,6804174L,8763443L,18567909L,25039772L,25039773L,37980379L,162799068L,304261639L,475527535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200569Inst : IEnumerable<long>
{
public static readonly long[] Value=A200569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200569.Bytes);
public long this[int i]=>Value[i];

public static A200569Inst Instance=new A200569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200570
{
public static readonly long[] Value={ 4L,6L,10L,16L,18L,24L,28L,30L,34L,40L,46L,48L,114L,118L,124L,126L,136L,138L,294L,318L,1332L,1333L,48505L,48509L,87164L,135990L,416319L,436744L,780358L,8763442L,25039772L,35176558L,44444364L,61575288L,100918165L,846178875L,1214569400L,2644138052L,9381631594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200570Inst : IEnumerable<long>
{
public static readonly long[] Value=A200570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200570.Bytes);
public long this[int i]=>Value[i];

public static A200570Inst Instance=new A200570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200571
{
public static readonly long[] Value={ 2L,36L,2174L,938128L,2421467558L,36460159508108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200571Inst : IEnumerable<long>
{
public static readonly long[] Value=A200571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200571.Bytes);
public long this[int i]=>Value[i];

public static A200571Inst Instance=new A200571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200572
{
public static readonly long[] Value={ 2L,6L,10L,22L,52L,114L,260L,600L,1374L,3162L,7290L,16796L,38722L,89296L,205916L,474882L,1095218L,2525902L,5825564L,13435770L,30987588L,71468368L,164831598L,380160714L,876787090L,2022186212L,4663888698L,10756605360L,24808602932L,57217567106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200572Inst : IEnumerable<long>
{
public static readonly long[] Value=A200572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200572.Bytes);
public long this[int i]=>Value[i];

public static A200572Inst Instance=new A200572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200573
{
public static readonly long[] Value={ 6L,36L,174L,922L,5202L,29180L,163706L,919924L,5171420L,29068726L,163403454L,918546962L,5163485576L,29025793202L,163164480016L,917206531060L,5155949803838L,28983459159770L,162926511803678L,915868877073788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200573Inst : IEnumerable<long>
{
public static readonly long[] Value=A200573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200573.Bytes);
public long this[int i]=>Value[i];

public static A200573Inst Instance=new A200573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200574
{
public static readonly long[] Value={ 10L,174L,2174L,28890L,388824L,5236786L,70594592L,951777602L,12832277870L,173011315794L,2332637651278L,31449955203276L,424026281913518L,5716965606842562L,77079410192481546L,1039228825310882064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200574Inst : IEnumerable<long>
{
public static readonly long[] Value=A200574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200574.Bytes);
public long this[int i]=>Value[i];

public static A200574Inst Instance=new A200574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200575
{
public static readonly BigInteger[] Value={ 22L,922L,28890L,938128L,30603332L,997303772L,32523513414L,1060675282092L,34590199046646L,1128052999950878L,36788018142626902L,1199728544485667908L,BigInteger.Parse("39125481049547004512"),BigInteger.Parse("1275958061644704120210"),BigInteger.Parse("41611474500836339304542") };
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
public class A200575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200575Inst Instance=new A200575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200576
{
public static readonly BigInteger[] Value={ 52L,5202L,388824L,30603332L,2421467558L,190970366840L,15075017283404L,1190087102438968L,93945476108897056L,7416172358628866324L,BigInteger.Parse("585443124609564375428"),BigInteger.Parse("46215655238302362668328"),BigInteger.Parse("3648325917726970721199010") };
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
public class A200576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200576Inst Instance=new A200576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200577
{
public static readonly long[] Value={ 114L,29180L,5236786L,997303772L,190970366840L,36460159508108L,6967106819900592L,1331428645830077622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200577Inst : IEnumerable<long>
{
public static readonly long[] Value=A200577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200577.Bytes);
public long this[int i]=>Value[i];

public static A200577Inst Instance=new A200577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200578
{
public static readonly long[] Value={ 260L,163706L,70594592L,32523513414L,15075017283404L,6967106819900592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200578Inst : IEnumerable<long>
{
public static readonly long[] Value=A200578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200578.Bytes);
public long this[int i]=>Value[i];

public static A200578Inst Instance=new A200578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200579
{
public static readonly long[] Value={ 2L,6L,6L,10L,36L,10L,22L,174L,174L,22L,52L,922L,2174L,922L,52L,114L,5202L,28890L,28890L,5202L,114L,260L,29180L,388824L,938128L,388824L,29180L,260L,600L,163706L,5236786L,30603332L,30603332L,5236786L,163706L,600L,1374L,919924L,70594592L,997303772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200579Inst : IEnumerable<long>
{
public static readonly long[] Value=A200579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200579.Bytes);
public long this[int i]=>Value[i];

public static A200579Inst Instance=new A200579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200580
{
public static readonly long[] Value={ 0L,1L,10L,73L,490L,3246L,21814L,150535L,1072786L,7915081L,60512348L,479371384L,3932969516L,33392961185L,293143783762L,2658128519225L,24872012040510L,239916007100054L,2383444110867378L,24363881751014383L,256034413642582418L,2763708806499744097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200580Inst : IEnumerable<long>
{
public static readonly long[] Value=A200580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200580.Bytes);
public long this[int i]=>Value[i];

public static A200580Inst Instance=new A200580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200581
{
public static readonly BigInteger[] Value={ 297L,4456485L,552604437L,8291281429233L,1028119449829329L,15425912516520681549UL,BigInteger.Parse("1912814180168014341405"),BigInteger.Parse("28699879385153403699122169"),BigInteger.Parse("3558786956573202226705490361"),BigInteger.Parse("53396068196303711362892876498613"),BigInteger.Parse("6621116015128616782200943391318373") };
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
public class A200581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200581Inst Instance=new A200581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200582
{
public static readonly BigInteger[] Value={ 297L,36531L,548111421L,67965852735L,1019760202547361L,126450333081725499L,BigInteger.Parse("1897261817318411934357"),BigInteger.Parse("235260591797816161585767"),BigInteger.Parse("3529851816596251006844782425"),BigInteger.Parse("437701860518526922664914606467"),BigInteger.Parse("6567282245071794543915385600213293"),BigInteger.Parse("814343436090763041972430479341054799") };
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
public class A200582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200582Inst Instance=new A200582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200583
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,8L,3L,1L,16L,1L,32L,10L,4L,1L,64L,1L,128L,35L,5L,1L,256L,22L,1L,512L,126L,6L,1L,1024L,1L,2048L,462L,134L,46L,7L,1L,4096L,1L,8192L,1716L,8L,1L,16384L,866L,94L,1L,32768L,6435L,485L,9L,1L,65536L,1L,131072L,24310L,5812L,190L,10L,1L,262144L,1L,524288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200583Inst : IEnumerable<long>
{
public static readonly long[] Value=A200583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200583.Bytes);
public long this[int i]=>Value[i];

public static A200583Inst Instance=new A200583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200584
{
public static readonly long[] Value={ 2L,1L,8L,3L,6L,5L,7L,8L,0L,2L,7L,1L,6L,2L,3L,8L,6L,5L,1L,6L,7L,8L,7L,8L,8L,2L,4L,5L,4L,8L,0L,9L,0L,3L,6L,6L,5L,8L,9L,1L,2L,2L,3L,1L,5L,2L,8L,1L,4L,4L,7L,3L,4L,1L,9L,6L,9L,7L,7L,8L,0L,8L,7L,3L,8L,1L,4L,8L,1L,8L,8L,9L,8L,0L,6L,6L,6L,5L,3L,2L,8L,5L,9L,6L,6L,0L,8L,7L,6L,2L,5L,3L,7L,9L,5L,2L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200584Inst : IEnumerable<long>
{
public static readonly long[] Value=A200584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200584.Bytes);
public long this[int i]=>Value[i];

public static A200584Inst Instance=new A200584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200585
{
public static readonly long[] Value={ 8L,1L,7L,5L,8L,9L,2L,3L,9L,1L,0L,3L,2L,7L,8L,4L,3L,9L,4L,4L,7L,9L,0L,3L,1L,6L,0L,5L,4L,5L,1L,5L,0L,6L,7L,9L,4L,0L,7L,1L,7L,4L,9L,3L,5L,1L,1L,6L,6L,2L,1L,2L,1L,5L,3L,0L,6L,6L,6L,5L,2L,9L,7L,2L,7L,3L,4L,9L,1L,9L,6L,6L,3L,5L,3L,3L,1L,2L,7L,6L,1L,5L,9L,4L,5L,4L,1L,0L,2L,9L,1L,8L,3L,5L,5L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200585Inst : IEnumerable<long>
{
public static readonly long[] Value=A200585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200585.Bytes);
public long this[int i]=>Value[i];

public static A200585Inst Instance=new A200585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200586
{
public static readonly long[] Value={ 1L,4L,2L,1L,2L,9L,3L,6L,0L,9L,0L,3L,9L,2L,7L,8L,6L,6L,7L,9L,4L,8L,4L,2L,1L,4L,0L,1L,1L,8L,5L,9L,4L,5L,2L,9L,6L,8L,2L,9L,5L,3L,4L,9L,9L,5L,3L,4L,9L,9L,5L,0L,7L,5L,7L,2L,9L,3L,9L,9L,1L,9L,6L,6L,3L,9L,6L,1L,8L,1L,6L,0L,0L,4L,6L,8L,0L,7L,0L,6L,6L,7L,6L,6L,6L,6L,8L,9L,9L,3L,6L,3L,6L,3L,4L,3L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200586Inst : IEnumerable<long>
{
public static readonly long[] Value=A200586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200586.Bytes);
public long this[int i]=>Value[i];

public static A200586Inst Instance=new A200586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200587
{
public static readonly long[] Value={ 1L,4L,4L,3L,3L,9L,6L,3L,5L,7L,5L,0L,5L,4L,8L,4L,4L,2L,5L,0L,0L,5L,6L,8L,8L,1L,4L,7L,9L,5L,2L,5L,1L,6L,6L,1L,1L,1L,7L,7L,5L,5L,3L,9L,1L,2L,4L,6L,1L,6L,6L,5L,7L,3L,7L,2L,8L,2L,4L,5L,4L,8L,3L,8L,3L,1L,4L,1L,5L,3L,2L,3L,4L,4L,3L,5L,3L,5L,6L,1L,8L,0L,4L,2L,0L,3L,2L,2L,4L,3L,9L,6L,7L,6L,0L,9L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200587Inst : IEnumerable<long>
{
public static readonly long[] Value=A200587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200587.Bytes);
public long this[int i]=>Value[i];

public static A200587Inst Instance=new A200587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200588
{
public static readonly long[] Value={ 1L,4L,5L,9L,2L,6L,7L,9L,4L,9L,4L,2L,8L,9L,8L,3L,9L,8L,1L,4L,7L,6L,5L,2L,1L,6L,1L,8L,0L,9L,2L,9L,4L,3L,5L,0L,4L,7L,0L,0L,3L,5L,3L,6L,0L,4L,2L,4L,7L,3L,6L,3L,1L,7L,3L,4L,9L,2L,3L,3L,6L,5L,1L,8L,7L,1L,1L,7L,0L,7L,1L,1L,3L,6L,9L,1L,3L,1L,3L,0L,4L,6L,5L,8L,9L,3L,0L,2L,8L,8L,5L,4L,4L,4L,3L,2L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200588Inst : IEnumerable<long>
{
public static readonly long[] Value=A200588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200588.Bytes);
public long this[int i]=>Value[i];

public static A200588Inst Instance=new A200588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200589
{
public static readonly long[] Value={ 1L,2L,8L,2L,1L,0L,9L,7L,8L,0L,7L,3L,9L,4L,6L,0L,8L,2L,4L,1L,2L,8L,6L,7L,3L,4L,2L,3L,6L,8L,2L,8L,3L,4L,8L,3L,0L,3L,3L,4L,0L,7L,6L,1L,7L,7L,2L,1L,5L,2L,5L,0L,1L,5L,2L,2L,8L,3L,2L,2L,9L,6L,4L,0L,5L,4L,0L,5L,9L,2L,2L,1L,1L,8L,5L,6L,7L,4L,8L,3L,9L,2L,2L,9L,2L,9L,6L,2L,9L,2L,1L,4L,9L,6L,8L,6L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200589Inst : IEnumerable<long>
{
public static readonly long[] Value=A200589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200589.Bytes);
public long this[int i]=>Value[i];

public static A200589Inst Instance=new A200589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200590
{
public static readonly long[] Value={ 1L,3L,6L,8L,8L,0L,9L,1L,8L,9L,5L,8L,6L,2L,9L,4L,1L,4L,3L,7L,5L,7L,8L,7L,5L,5L,6L,4L,9L,2L,1L,5L,2L,3L,3L,7L,8L,8L,4L,6L,3L,3L,4L,4L,7L,0L,5L,0L,3L,9L,1L,1L,1L,9L,4L,2L,1L,8L,3L,6L,8L,0L,7L,3L,8L,8L,9L,2L,8L,3L,9L,2L,0L,5L,0L,0L,8L,9L,9L,3L,4L,3L,1L,3L,4L,6L,6L,2L,4L,0L,4L,6L,2L,7L,1L,8L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200590Inst : IEnumerable<long>
{
public static readonly long[] Value=A200590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200590.Bytes);
public long this[int i]=>Value[i];

public static A200590Inst Instance=new A200590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200591
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,5L,0L,0L,7L,6L,3L,7L,9L,6L,7L,8L,1L,0L,7L,7L,5L,7L,3L,1L,7L,0L,2L,9L,9L,8L,5L,0L,0L,0L,4L,0L,7L,4L,9L,7L,2L,0L,6L,8L,4L,7L,2L,1L,1L,2L,1L,6L,5L,6L,8L,6L,5L,3L,2L,9L,6L,0L,1L,8L,5L,7L,2L,0L,6L,9L,8L,1L,1L,3L,4L,5L,0L,3L,2L,2L,5L,6L,5L,6L,7L,9L,6L,1L,9L,3L,7L,3L,3L,8L,0L,3L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200591Inst : IEnumerable<long>
{
public static readonly long[] Value=A200591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200591.Bytes);
public long this[int i]=>Value[i];

public static A200591Inst Instance=new A200591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200592
{
public static readonly long[] Value={ 1L,4L,3L,4L,7L,7L,0L,7L,3L,1L,0L,6L,3L,2L,9L,7L,3L,2L,6L,1L,4L,9L,8L,6L,0L,0L,4L,3L,7L,9L,2L,2L,0L,2L,6L,8L,8L,7L,4L,2L,9L,8L,9L,3L,1L,5L,1L,6L,7L,0L,6L,1L,3L,8L,9L,5L,5L,3L,0L,5L,6L,0L,9L,7L,8L,1L,7L,1L,0L,5L,0L,1L,2L,0L,2L,7L,5L,1L,2L,1L,3L,2L,7L,8L,1L,6L,2L,3L,5L,6L,6L,5L,3L,5L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200592Inst : IEnumerable<long>
{
public static readonly long[] Value=A200592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200592.Bytes);
public long this[int i]=>Value[i];

public static A200592Inst Instance=new A200592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200593
{
public static readonly long[] Value={ 3L,2L,7L,2L,8L,3L,7L,3L,0L,1L,5L,9L,5L,3L,0L,8L,4L,1L,1L,5L,6L,0L,0L,1L,1L,4L,3L,3L,8L,4L,3L,2L,4L,7L,7L,4L,4L,0L,7L,6L,1L,9L,1L,3L,4L,2L,5L,1L,4L,3L,2L,3L,6L,6L,4L,6L,6L,6L,9L,2L,4L,4L,1L,4L,4L,1L,8L,9L,4L,1L,5L,5L,8L,3L,2L,9L,6L,4L,6L,7L,4L,6L,8L,5L,0L,9L,3L,4L,1L,7L,7L,6L,4L,6L,3L,5L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200593Inst : IEnumerable<long>
{
public static readonly long[] Value=A200593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200593.Bytes);
public long this[int i]=>Value[i];

public static A200593Inst Instance=new A200593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200594
{
public static readonly long[] Value={ 1L,2L,3L,6L,1L,3L,1L,7L,8L,7L,5L,1L,5L,2L,3L,7L,2L,2L,4L,1L,3L,4L,5L,7L,0L,0L,3L,1L,7L,3L,6L,5L,8L,9L,7L,8L,2L,1L,5L,2L,6L,2L,5L,2L,0L,4L,5L,4L,0L,2L,6L,9L,4L,9L,6L,8L,2L,1L,3L,3L,8L,1L,8L,6L,7L,2L,5L,5L,3L,1L,1L,4L,2L,7L,1L,8L,3L,4L,0L,8L,4L,0L,6L,3L,1L,1L,1L,4L,1L,7L,7L,6L,6L,7L,0L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200594Inst : IEnumerable<long>
{
public static readonly long[] Value=A200594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200594.Bytes);
public long this[int i]=>Value[i];

public static A200594Inst Instance=new A200594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200595
{
public static readonly long[] Value={ 1L,3L,9L,5L,8L,5L,1L,3L,6L,0L,6L,2L,1L,1L,4L,9L,0L,7L,4L,2L,7L,3L,3L,7L,7L,9L,0L,3L,8L,5L,6L,2L,9L,4L,1L,8L,1L,3L,8L,6L,2L,5L,9L,2L,9L,3L,6L,6L,7L,1L,2L,8L,5L,3L,4L,1L,1L,5L,7L,8L,9L,5L,2L,1L,2L,5L,9L,4L,3L,7L,2L,5L,3L,3L,8L,5L,0L,8L,2L,3L,6L,6L,7L,8L,3L,1L,4L,5L,0L,3L,2L,9L,1L,1L,4L,1L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200595Inst : IEnumerable<long>
{
public static readonly long[] Value=A200595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200595.Bytes);
public long this[int i]=>Value[i];

public static A200595Inst Instance=new A200595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200596
{
public static readonly long[] Value={ 2L,3L,1L,2L,4L,1L,1L,1L,4L,8L,4L,6L,2L,2L,4L,0L,8L,6L,0L,0L,8L,7L,7L,1L,2L,6L,3L,7L,7L,6L,0L,4L,6L,9L,2L,5L,8L,7L,6L,0L,0L,2L,3L,1L,2L,8L,6L,3L,3L,6L,5L,0L,8L,3L,5L,1L,4L,7L,0L,9L,0L,8L,9L,9L,3L,8L,4L,4L,7L,2L,2L,3L,9L,4L,0L,1L,9L,0L,2L,3L,8L,8L,8L,2L,3L,4L,5L,6L,9L,3L,0L,1L,1L,6L,8L,2L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200596Inst : IEnumerable<long>
{
public static readonly long[] Value=A200596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200596.Bytes);
public long this[int i]=>Value[i];

public static A200596Inst Instance=new A200596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200597
{
public static readonly long[] Value={ 5L,9L,7L,7L,9L,0L,7L,0L,6L,8L,8L,1L,9L,3L,7L,5L,2L,1L,8L,3L,7L,2L,5L,5L,0L,8L,8L,4L,1L,7L,4L,4L,0L,0L,4L,5L,7L,8L,5L,1L,0L,6L,9L,6L,8L,2L,1L,2L,7L,9L,8L,2L,1L,5L,5L,6L,9L,2L,4L,9L,3L,1L,6L,0L,1L,4L,6L,9L,0L,7L,3L,0L,7L,8L,6L,8L,9L,8L,6L,4L,4L,4L,8L,2L,8L,1L,5L,5L,5L,2L,4L,1L,2L,4L,7L,4L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200597Inst : IEnumerable<long>
{
public static readonly long[] Value=A200597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200597.Bytes);
public long this[int i]=>Value[i];

public static A200597Inst Instance=new A200597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200598
{
public static readonly long[] Value={ 1L,1L,8L,7L,6L,3L,8L,0L,2L,6L,3L,5L,4L,6L,0L,3L,9L,8L,2L,4L,4L,7L,2L,9L,1L,0L,9L,8L,0L,4L,2L,1L,6L,2L,2L,3L,5L,9L,7L,1L,6L,3L,7L,8L,6L,7L,2L,8L,0L,3L,5L,9L,3L,3L,0L,8L,6L,2L,7L,8L,7L,7L,8L,3L,6L,0L,1L,7L,6L,1L,1L,5L,1L,3L,9L,3L,9L,3L,9L,6L,3L,9L,6L,3L,7L,2L,6L,0L,7L,3L,1L,6L,4L,3L,4L,5L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200598Inst : IEnumerable<long>
{
public static readonly long[] Value=A200598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200598.Bytes);
public long this[int i]=>Value[i];

public static A200598Inst Instance=new A200598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200599
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,9L,9L,6L,2L,2L,7L,1L,9L,5L,6L,0L,4L,9L,9L,3L,3L,3L,9L,3L,8L,5L,0L,5L,1L,5L,4L,9L,9L,7L,6L,3L,8L,6L,7L,7L,6L,2L,2L,7L,6L,0L,0L,7L,5L,2L,3L,6L,3L,3L,6L,8L,5L,5L,1L,5L,3L,5L,1L,6L,6L,2L,6L,3L,7L,2L,8L,1L,8L,0L,2L,2L,3L,7L,9L,7L,1L,8L,0L,6L,9L,1L,9L,0L,3L,6L,4L,3L,9L,9L,7L,7L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200599Inst : IEnumerable<long>
{
public static readonly long[] Value=A200599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200599.Bytes);
public long this[int i]=>Value[i];

public static A200599Inst Instance=new A200599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200600
{
public static readonly long[] Value={ 1L,4L,4L,4L,9L,9L,4L,6L,8L,8L,9L,5L,5L,1L,3L,1L,1L,8L,0L,4L,5L,3L,3L,2L,4L,9L,5L,9L,5L,8L,3L,8L,4L,1L,1L,6L,9L,9L,2L,8L,1L,0L,1L,8L,9L,1L,7L,5L,1L,3L,6L,2L,1L,6L,8L,6L,9L,8L,7L,1L,7L,9L,8L,3L,1L,4L,4L,9L,9L,7L,9L,7L,2L,2L,8L,7L,6L,1L,9L,2L,2L,0L,3L,4L,4L,2L,4L,7L,9L,1L,0L,9L,4L,7L,1L,3L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200600Inst : IEnumerable<long>
{
public static readonly long[] Value=A200600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200600.Bytes);
public long this[int i]=>Value[i];

public static A200600Inst Instance=new A200600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200601
{
public static readonly long[] Value={ 1L,4L,6L,1L,0L,8L,1L,7L,4L,3L,4L,8L,8L,1L,8L,9L,4L,1L,5L,2L,6L,5L,5L,8L,1L,2L,2L,8L,9L,5L,8L,0L,8L,2L,0L,8L,8L,0L,2L,7L,4L,7L,9L,8L,7L,8L,0L,1L,7L,0L,9L,4L,7L,4L,2L,4L,0L,0L,2L,2L,8L,4L,6L,8L,3L,0L,1L,8L,6L,2L,1L,2L,3L,6L,0L,8L,9L,1L,7L,0L,7L,8L,5L,8L,6L,4L,1L,9L,9L,7L,3L,7L,3L,9L,4L,9L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200601Inst : IEnumerable<long>
{
public static readonly long[] Value=A200601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200601.Bytes);
public long this[int i]=>Value[i];

public static A200601Inst Instance=new A200601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200602
{
public static readonly long[] Value={ 1L,4L,7L,3L,1L,4L,0L,0L,7L,1L,1L,2L,6L,3L,0L,1L,7L,2L,3L,4L,7L,9L,2L,7L,5L,0L,8L,1L,6L,1L,2L,3L,1L,1L,6L,9L,8L,1L,9L,2L,5L,5L,6L,5L,5L,5L,1L,6L,9L,8L,9L,9L,0L,7L,7L,0L,4L,4L,9L,1L,0L,7L,7L,6L,6L,5L,2L,8L,1L,6L,3L,6L,3L,3L,5L,9L,0L,2L,7L,9L,3L,1L,9L,1L,4L,9L,5L,4L,6L,1L,9L,0L,3L,5L,6L,0L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200602Inst : IEnumerable<long>
{
public static readonly long[] Value=A200602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200602.Bytes);
public long this[int i]=>Value[i];

public static A200602Inst Instance=new A200602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200603
{
public static readonly long[] Value={ 1L,4L,8L,2L,6L,0L,7L,4L,9L,2L,1L,8L,1L,6L,3L,4L,0L,4L,9L,6L,3L,8L,8L,5L,0L,7L,9L,6L,7L,4L,5L,5L,8L,7L,0L,7L,5L,9L,5L,4L,3L,1L,5L,1L,9L,4L,4L,0L,3L,0L,5L,8L,7L,5L,4L,4L,6L,2L,9L,3L,6L,3L,1L,6L,8L,3L,6L,2L,8L,4L,6L,9L,6L,3L,3L,7L,0L,0L,8L,8L,9L,7L,0L,5L,4L,4L,8L,9L,8L,0L,7L,5L,8L,6L,0L,7L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200603Inst : IEnumerable<long>
{
public static readonly long[] Value=A200603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200603.Bytes);
public long this[int i]=>Value[i];

public static A200603Inst Instance=new A200603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200604
{
public static readonly long[] Value={ 1L,4L,0L,8L,8L,8L,1L,6L,6L,6L,0L,4L,8L,5L,8L,3L,9L,9L,3L,2L,7L,2L,3L,6L,4L,4L,1L,8L,8L,3L,4L,3L,4L,8L,8L,5L,8L,0L,9L,5L,2L,3L,6L,7L,5L,5L,6L,2L,6L,5L,4L,6L,8L,7L,5L,5L,9L,5L,5L,3L,9L,8L,2L,9L,2L,8L,9L,6L,3L,3L,3L,6L,0L,0L,9L,4L,8L,1L,5L,9L,4L,1L,1L,7L,1L,5L,8L,1L,5L,3L,9L,9L,1L,6L,9L,5L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200604Inst : IEnumerable<long>
{
public static readonly long[] Value=A200604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200604.Bytes);
public long this[int i]=>Value[i];

public static A200604Inst Instance=new A200604Inst();

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