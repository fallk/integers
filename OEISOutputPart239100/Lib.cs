using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016413
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016413Inst : IEnumerable<long>
{
public static readonly long[] Value=A016413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016413.Bytes);
public long this[int i]=>Value[i];

public static A016413Inst Instance=new A016413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016446
{
public static readonly long[] Value={ 2L,1L,8L,8L,4L,1L,1L,1L,36L,14L,1L,1L,1L,65L,1L,1L,4L,27L,7L,1L,1L,2L,3L,8L,7L,4L,1L,7L,1L,4L,13L,1L,3L,1L,2L,3L,6L,1L,4L,2L,2L,1L,1L,2L,8L,2L,6L,2L,1L,5L,3L,1L,1L,1L,1L,116L,1L,48L,28L,1L,7L,1L,1L,23L,1L,15L,1L,10L,1L,9L,2L,1L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016446Inst : IEnumerable<long>
{
public static readonly long[] Value=A016446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016446.Bytes);
public long this[int i]=>Value[i];

public static A016446Inst Instance=new A016446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016447
{
public static readonly long[] Value={ 2L,1L,16L,1L,563L,1L,3L,1L,2L,1L,1L,7L,1L,2L,89L,1L,5L,2L,1L,31L,5L,3L,1L,1L,3L,1L,1L,31L,1L,1L,43L,1L,1L,14L,1L,1L,8L,2L,7L,2L,1L,2L,25L,1L,5L,165L,1L,4L,7L,1L,16L,1L,17L,1L,12L,29L,1L,1L,1L,1L,1L,6L,4L,1L,1L,1L,3L,1L,9L,5L,3L,3L,1L,1L,14L,2L,4L,1L,2L,2L,4L,1L,2L,1L,2L,4L,2L,1L,11L,2L,1L,1L,1L,2L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016447Inst : IEnumerable<long>
{
public static readonly long[] Value=A016447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016447.Bytes);
public long this[int i]=>Value[i];

public static A016447Inst Instance=new A016447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016448
{
public static readonly long[] Value={ 2L,1L,233L,3L,6L,2L,1L,1L,2L,2L,2L,4L,8L,2L,2L,1L,27L,1L,6L,6L,2L,1L,4L,3L,1L,1L,1L,33L,2L,1L,2L,1L,1L,1L,3L,5L,3L,1L,3L,2L,2L,3L,7L,1L,2L,1L,4L,1L,5L,1L,2L,3L,4L,11L,2L,8L,2L,3L,5L,3L,1L,2L,1L,1L,2L,1L,5L,9L,1L,6L,7L,1L,6L,1L,3L,1L,47L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016448Inst : IEnumerable<long>
{
public static readonly long[] Value=A016448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016448.Bytes);
public long this[int i]=>Value[i];

public static A016448Inst Instance=new A016448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016449
{
public static readonly long[] Value={ 3L,22L,2L,5L,1L,5L,2L,1L,3L,2L,5L,2L,1L,9L,4L,1L,2L,26L,1L,1L,1L,51L,1L,2L,7L,11L,1L,1L,1L,10L,4L,1L,6L,19L,5L,1L,1L,3L,2L,6L,1L,5L,2L,3L,20L,11L,7L,2L,2L,1L,5L,1L,4L,1L,1L,1L,1L,1L,1L,18L,1L,13L,3L,2L,2L,3L,4L,3L,4L,1L,2L,10L,1L,6L,28L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016449Inst : IEnumerable<long>
{
public static readonly long[] Value=A016449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016449.Bytes);
public long this[int i]=>Value[i];

public static A016449Inst Instance=new A016449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016450
{
public static readonly long[] Value={ 3L,10L,1L,61L,16L,2L,3L,3L,5L,6L,171L,2L,4L,5L,4L,1L,2L,1L,1L,3L,1L,1L,3L,22L,1L,13L,1L,17L,3L,2L,1L,3L,1L,1L,1L,4L,6L,1L,3L,2L,2L,1L,2L,1L,8L,2L,25L,5L,12L,1L,1L,1L,2L,1L,7L,3L,2L,1L,4L,4L,1L,17L,1L,66L,1L,2L,37L,1L,3L,3L,5L,1L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016450Inst : IEnumerable<long>
{
public static readonly long[] Value=A016450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016450.Bytes);
public long this[int i]=>Value[i];

public static A016450Inst Instance=new A016450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016451
{
public static readonly long[] Value={ 3L,7L,2L,1L,1L,1L,2L,3L,1L,1L,1L,4L,158L,3L,2L,5L,1L,6L,4L,2L,72L,1L,2L,1L,5L,14L,3L,1L,5L,2L,2L,1L,4L,8L,1L,1L,1L,4L,18L,1L,1L,2L,1L,4L,2L,1L,1L,1L,2L,3L,3L,26L,1L,3L,1L,22L,3L,5L,1L,2L,2L,2L,1L,29L,2L,1L,2L,1L,8L,9L,2L,1L,2L,8L,19L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016451Inst : IEnumerable<long>
{
public static readonly long[] Value=A016451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016451.Bytes);
public long this[int i]=>Value[i];

public static A016451Inst Instance=new A016451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016452
{
public static readonly long[] Value={ 3L,5L,1L,1L,1L,1L,1L,1L,6L,35660L,1L,3L,1L,2L,1L,3L,3L,2L,1L,13L,2L,4L,1L,16L,3L,7L,10L,2L,16L,1L,3L,1L,1L,9L,1L,1L,5L,2L,6L,2L,4L,203L,1L,4L,7L,1L,1L,1L,1L,2L,33L,1L,8L,1L,5L,2L,12L,136L,3L,6L,1L,1L,1L,1L,1L,37L,8L,1L,1L,3L,1L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016452Inst : IEnumerable<long>
{
public static readonly long[] Value=A016452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016452.Bytes);
public long this[int i]=>Value[i];

public static A016452Inst Instance=new A016452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016453
{
public static readonly long[] Value={ 3L,4L,1L,1L,3L,7L,2L,12L,47L,2L,1L,1L,1L,1L,1L,1L,19L,1L,11L,1L,5L,15L,3L,1L,1L,3L,1L,1L,19L,8L,1L,1L,1L,1L,1L,20L,6L,1L,3L,2L,3L,4L,9L,3L,26L,8L,9L,8L,32L,1L,1L,1L,1L,5L,1L,8L,2L,4L,2L,10L,2L,7L,1L,1L,7L,20L,1L,27L,70L,1L,15L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016453Inst : IEnumerable<long>
{
public static readonly long[] Value=A016453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016453.Bytes);
public long this[int i]=>Value[i];

public static A016453Inst Instance=new A016453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016454
{
public static readonly long[] Value={ 3L,3L,1L,6L,1L,31L,1L,1L,1L,2L,1461L,1L,1L,2L,1L,3L,1L,4L,2L,5L,1L,1L,104L,6L,25L,10L,6L,12L,1L,2L,1L,156L,2L,1L,1L,7L,1L,139L,1L,8L,1L,3L,2L,1L,8L,7L,1L,8L,2L,3L,2L,9L,6L,46L,1L,3L,5L,1L,5L,1L,10L,1L,2L,7L,7L,2L,22L,2L,4L,3L,1L,177L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016454Inst : IEnumerable<long>
{
public static readonly long[] Value=A016454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016454.Bytes);
public long this[int i]=>Value[i];

public static A016454Inst Instance=new A016454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016455
{
public static readonly long[] Value={ 3L,3L,2L,1L,1L,1L,2L,2L,1L,4L,4L,1L,3L,10L,1L,4L,1L,5L,3L,5L,5L,1L,1L,1L,3L,108L,1L,7L,1L,1L,3L,3L,1L,1L,1L,8L,2L,1L,1L,1L,2L,3L,1L,3L,1L,7L,1L,1L,2L,12L,1L,50L,4L,3L,23L,3L,8L,3L,1L,5L,1L,4L,7L,1L,6L,1L,1L,5L,1L,1L,1L,1L,6L,15L,1L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016455Inst : IEnumerable<long>
{
public static readonly long[] Value=A016455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016455.Bytes);
public long this[int i]=>Value[i];

public static A016455Inst Instance=new A016455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016456
{
public static readonly long[] Value={ 3L,3L,98L,10L,4L,17L,2L,1L,3L,10L,1L,1L,1L,1L,3L,8L,43L,1L,38L,2L,1L,1L,2L,2L,1L,11L,1L,1L,2L,1L,10L,12L,1L,72L,1L,3L,1L,2L,2L,2L,2L,1L,1L,8L,1L,1L,193L,7L,2L,1L,1L,5L,1L,6L,2L,1L,2L,1L,3L,1L,1L,10L,3L,1L,1L,2L,1L,6L,2L,1L,2L,1L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016456Inst : IEnumerable<long>
{
public static readonly long[] Value=A016456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016456.Bytes);
public long this[int i]=>Value[i];

public static A016456Inst Instance=new A016456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016457
{
public static readonly long[] Value={ 3L,2L,1L,2L,1L,1L,1L,1L,7L,1L,1L,6L,3L,1L,1L,1L,4L,2L,6L,2L,1L,1L,5L,2L,1L,1L,2L,2L,23L,358L,1L,5L,1L,3L,4L,3L,2L,3L,4L,3L,1L,6L,4L,1L,3L,8L,482L,4L,4L,2L,12L,2L,1L,17L,49L,7L,2L,1L,6L,1L,3L,2L,1L,1L,3L,1L,9L,1L,145L,41L,2L,480L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016457Inst : IEnumerable<long>
{
public static readonly long[] Value=A016457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016457.Bytes);
public long this[int i]=>Value[i];

public static A016457Inst Instance=new A016457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016458
{
public static readonly long[] Value={ 3L,2L,2L,33L,160L,1L,2L,51L,1L,3L,22L,1L,7L,1L,2L,4L,7L,7L,1L,1L,1L,5L,4L,2L,18L,3L,12L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,5L,2L,7L,2L,1L,2L,2L,5L,4L,2L,1L,1L,3L,1L,2L,2L,12L,1L,1L,4L,2L,1L,1L,2L,2L,4L,2L,2L,3L,3L,2L,1L,3L,2L,2L,3L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016458Inst : IEnumerable<long>
{
public static readonly long[] Value=A016458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016458.Bytes);
public long this[int i]=>Value[i];

public static A016458Inst Instance=new A016458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016459
{
public static readonly long[] Value={ 3L,2L,3L,3L,2L,13L,1L,5L,3L,1L,32L,1L,6L,2L,2L,1L,24L,2L,5L,1L,6L,1L,16L,1L,1L,13L,14L,2L,1L,5L,4L,4L,1L,3L,5L,4L,19L,1L,16L,1L,2L,5L,2L,3L,1L,7L,1L,1L,1L,91L,26L,1L,16L,1L,13L,1L,6L,29L,2L,17L,1L,8L,2L,28L,1L,7L,6L,5L,1L,1L,1L,15L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016459Inst : IEnumerable<long>
{
public static readonly long[] Value=A016459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016459.Bytes);
public long this[int i]=>Value[i];

public static A016459Inst Instance=new A016459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016460
{
public static readonly long[] Value={ 3L,2L,6L,1L,3L,1L,9L,1L,10L,1L,3L,1L,1L,12L,1L,1L,1L,1L,2L,12L,3L,1L,2L,36L,13L,2L,2L,4L,2L,1L,1L,4L,4L,2L,1L,3L,1L,1L,1L,1L,3L,2L,3L,3L,2L,4L,1L,2L,1L,2L,1L,10L,1L,2L,5L,1L,69L,3L,5L,7L,2L,1L,1L,1L,1L,3L,3L,3L,1L,13L,6L,1L,1L,10L,1L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016460Inst : IEnumerable<long>
{
public static readonly long[] Value=A016460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016460.Bytes);
public long this[int i]=>Value[i];

public static A016460Inst Instance=new A016460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016461
{
public static readonly long[] Value={ 3L,2L,71L,12L,61L,1L,5L,12L,1L,5L,6L,6L,1L,9L,1L,1L,4L,1L,997L,1L,1L,1L,1L,8L,7L,8L,5L,1L,1L,1L,1L,4L,1L,1L,1L,1L,4L,1L,2L,53L,1L,3L,2L,3L,2L,1L,1L,1L,1L,82L,1L,1L,2L,2L,6L,3L,260L,1L,1L,6L,1L,3L,24L,4L,1L,3L,6L,1L,4L,2L,1L,3L,1L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016461Inst : IEnumerable<long>
{
public static readonly long[] Value=A016461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016461.Bytes);
public long this[int i]=>Value[i];

public static A016461Inst Instance=new A016461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016478
{
public static readonly long[] Value={ 3L,1L,10L,2L,1L,2L,1L,2L,18L,1L,1L,6L,1L,1L,1L,7L,1L,9L,1L,9L,3L,1L,4L,1L,1L,3L,9L,5L,1L,1L,2L,1L,3L,5L,7L,1L,2L,1L,1L,2L,18L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,13L,5L,515L,8L,4L,2L,2L,1L,1L,1L,44L,4L,6L,8L,4L,1L,5L,2L,3L,51L,2L,11L,2L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016478Inst : IEnumerable<long>
{
public static readonly long[] Value=A016478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016478.Bytes);
public long this[int i]=>Value[i];

public static A016478Inst Instance=new A016478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016479
{
public static readonly long[] Value={ 3L,1L,13L,1L,2L,68L,1L,59L,4L,9L,3L,1L,1L,3L,1L,17L,1L,2L,4L,4L,1L,4L,1L,1L,2L,3L,1L,9L,4L,5L,1L,1L,21L,186L,1L,1L,15L,1L,8L,25L,1L,1L,1L,1L,107L,163L,1L,2L,1L,1L,2L,9L,10L,2L,2L,4L,1L,1L,121L,1L,2L,19L,1L,2L,1L,47L,1L,2L,2L,1L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016479Inst : IEnumerable<long>
{
public static readonly long[] Value=A016479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016479.Bytes);
public long this[int i]=>Value[i];

public static A016479Inst Instance=new A016479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016480
{
public static readonly long[] Value={ 3L,1L,19L,1L,1L,24L,15L,1L,3L,1L,12L,1L,7L,2L,5L,1L,6L,1L,3L,6L,1L,31L,1L,7L,39L,3L,2L,1L,1L,3L,8L,2L,1L,1L,1L,1L,8L,1L,6L,4L,2L,7L,1L,4L,1L,8L,7L,1L,1L,2L,39L,1L,7L,2L,1L,2L,6L,5L,2L,2L,20L,2L,1L,13L,2L,1L,1L,10L,4L,2L,2L,1L,2L,7L,5L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016480Inst : IEnumerable<long>
{
public static readonly long[] Value=A016480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016480.Bytes);
public long this[int i]=>Value[i];

public static A016480Inst Instance=new A016480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016481
{
public static readonly long[] Value={ 3L,1L,32L,1L,1L,1L,18L,2L,97L,2L,1L,1L,1L,28L,2L,2L,1L,331L,6L,1L,1L,1L,7L,2L,1L,1L,1L,3L,2L,1L,15L,1L,1L,1L,2L,1L,2L,7L,2L,1L,2L,7L,9L,2L,15L,1L,1L,1L,1L,3L,1L,26L,6L,1L,1L,2L,2L,6L,25L,1L,1L,14L,31L,1L,5L,11L,4L,2L,1L,2L,2L,1L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016481Inst : IEnumerable<long>
{
public static readonly long[] Value=A016481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016481.Bytes);
public long this[int i]=>Value[i];

public static A016481Inst Instance=new A016481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016482
{
public static readonly long[] Value={ 3L,1L,89L,1L,3L,2L,35L,1L,1L,1L,1L,39L,3L,1L,1L,1L,14L,4L,13L,2L,6L,1L,3L,1L,1L,12L,1L,2L,12L,1L,3L,1L,1L,14L,2L,1L,10L,123L,1L,14L,2L,3L,1L,2L,1L,3L,1L,72L,2L,8L,21L,1L,1L,1L,5L,1L,25L,4L,4L,1L,1L,89L,3L,1L,2L,1L,1L,4L,3L,6L,1L,3L,5L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016482Inst : IEnumerable<long>
{
public static readonly long[] Value=A016482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016482.Bytes);
public long this[int i]=>Value[i];

public static A016482Inst Instance=new A016482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016483
{
public static readonly long[] Value={ 4L,136L,2L,1L,2L,1L,2L,3L,1L,1L,1L,8L,1L,1L,2L,1L,5L,1L,1L,2L,7L,3L,1L,22L,5L,3L,6L,1L,3L,4L,1L,1L,1L,1L,2L,2L,1L,5L,1L,1L,1L,2L,3L,2L,1L,1L,5L,2L,2L,25L,6L,1L,4L,1L,7L,2L,1L,2L,1L,15L,2L,3L,5L,1L,3L,1L,18L,8L,9L,1L,4L,1L,4L,2L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016483Inst : IEnumerable<long>
{
public static readonly long[] Value=A016483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016483.Bytes);
public long this[int i]=>Value[i];

public static A016483Inst Instance=new A016483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016484
{
public static readonly long[] Value={ 4L,39L,2L,4L,18L,1L,1L,2L,1L,1L,91L,1L,7L,1L,3L,1L,3L,2L,1L,1L,1L,3L,1L,1L,1L,5L,8L,2L,1L,4L,16L,1L,7L,1L,2L,53L,2L,1L,3L,1L,6L,2L,11L,1L,11L,2L,1L,2L,8L,1L,1L,14L,49L,1L,7L,2L,1L,7L,2L,4L,257L,3L,5L,1L,5L,1L,99L,1L,4L,1L,1L,16L,11L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016484Inst : IEnumerable<long>
{
public static readonly long[] Value=A016484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016484.Bytes);
public long this[int i]=>Value[i];

public static A016484Inst Instance=new A016484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016485
{
public static readonly long[] Value={ 4L,23L,4L,2L,1L,1L,1L,1L,5L,1L,1L,1L,1L,4L,2L,1L,9L,4L,1L,94L,1L,1L,1L,1L,1L,1L,1L,1L,25L,1L,2L,3L,3L,13L,1L,4L,10L,1L,21L,1L,1L,1L,5L,2L,1L,1L,1L,1L,1L,1L,2L,4L,1L,5L,7L,2L,2L,4L,1L,3L,1L,2L,1L,1L,2L,32L,1L,5L,3L,13L,17L,1L,1L,1L,6L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016485Inst : IEnumerable<long>
{
public static readonly long[] Value=A016485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016485.Bytes);
public long this[int i]=>Value[i];

public static A016485Inst Instance=new A016485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016486
{
public static readonly long[] Value={ 4L,16L,1L,1L,5L,8L,1L,1L,3L,8L,5L,1L,2L,1L,3L,1L,9L,2L,1L,11L,1L,13L,1L,1L,4L,1L,1L,2L,2L,1L,5L,2L,2L,2L,3L,1L,1L,11L,1L,11L,5L,2L,2L,3L,2L,3L,7L,19L,1L,1L,4L,2L,1L,1L,4L,171L,2L,1L,1L,12L,1L,1L,1L,4L,1L,4L,2L,3L,11L,10L,1L,1L,2L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016486Inst : IEnumerable<long>
{
public static readonly long[] Value=A016486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016486.Bytes);
public long this[int i]=>Value[i];

public static A016486Inst Instance=new A016486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016487
{
public static readonly long[] Value={ 4L,12L,1L,8L,1L,2L,2L,2L,1L,16L,1L,6L,2L,2L,3L,11L,1L,2L,1L,1L,4L,2L,1L,1L,1L,1L,7L,1L,6L,4L,1L,2L,5L,2L,2L,1L,4L,1L,4L,2L,11L,4L,4L,2L,3L,11L,1L,3L,15L,1L,1L,1L,3L,4L,2L,1L,6L,1L,1L,4L,3L,2L,1L,7L,1L,20L,8L,2L,3L,1L,3L,1L,47L,1L,1L,1L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016487Inst : IEnumerable<long>
{
public static readonly long[] Value=A016487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016487.Bytes);
public long this[int i]=>Value[i];

public static A016487Inst Instance=new A016487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016488
{
public static readonly long[] Value={ 4L,10L,1L,1L,2L,71L,1L,2L,14L,14L,1L,1L,122L,1L,3L,1L,1L,87L,2L,2L,4L,2L,3L,3L,3L,4L,3L,5L,2L,4L,3L,1L,2L,2L,1L,3L,1L,3L,75L,1L,38L,2L,3L,10L,22L,1L,10L,4L,1L,2L,3L,1L,1L,7L,1L,2L,2L,1L,1L,1L,8L,2L,2L,8L,1L,3L,1L,2L,1L,1L,3L,1L,3L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016488Inst : IEnumerable<long>
{
public static readonly long[] Value=A016488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016488.Bytes);
public long this[int i]=>Value[i];

public static A016488Inst Instance=new A016488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016489
{
public static readonly long[] Value={ 4L,9L,51L,1L,12L,1L,1L,5L,1L,4L,1L,1L,1L,2L,1L,3L,6L,1L,2L,11L,1L,357L,2L,7L,5L,7L,2L,6L,1L,522L,1L,7L,3L,2L,2L,1L,2L,1L,3L,1L,1L,1L,1L,4L,1L,6L,4L,13L,3L,1L,4L,5L,5L,1L,1L,9L,1L,1L,21L,1L,17L,1L,6L,1L,16L,1L,11L,8L,20L,1L,2L,3L,37L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016489Inst : IEnumerable<long>
{
public static readonly long[] Value=A016489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016489.Bytes);
public long this[int i]=>Value[i];

public static A016489Inst Instance=new A016489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016490
{
public static readonly long[] Value={ 4L,7L,1L,6L,2L,4L,10L,2L,1L,2L,4L,1L,7L,3L,3L,1L,43L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,3L,9L,1L,2L,6L,1L,13L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,33L,1L,1L,9L,1L,1L,1L,9L,1L,15L,5L,6L,8L,1L,2L,185L,5L,1L,5L,2L,1L,1L,11L,4L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016490Inst : IEnumerable<long>
{
public static readonly long[] Value=A016490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016490.Bytes);
public long this[int i]=>Value[i];

public static A016490Inst Instance=new A016490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016491
{
public static readonly long[] Value={ 4L,6L,1L,72L,1L,1L,1L,36L,4L,7L,1L,2L,5L,5L,1L,6L,2L,1L,9L,1L,4L,1L,1L,9L,2L,8L,1L,10L,1L,4L,1L,2L,1L,2L,2L,4L,6L,1L,33L,2L,8L,1L,1L,1L,1L,4L,1L,1L,12L,1L,1L,1L,1L,8L,7L,1L,2L,1L,1019L,4L,2L,6L,1604L,1L,1L,6L,3L,12L,1L,1L,7L,2L,1L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016491Inst : IEnumerable<long>
{
public static readonly long[] Value=A016491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016491.Bytes);
public long this[int i]=>Value[i];

public static A016491Inst Instance=new A016491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016492
{
public static readonly long[] Value={ 4L,6L,3L,2L,2L,18L,1L,1L,1L,64L,1L,3L,1L,10L,1L,2L,1L,7L,2L,5L,3L,1L,2L,2L,3L,2L,1L,2L,1L,4L,1L,3L,3L,2L,1L,1L,1L,4L,1L,1L,7L,2L,1L,27L,2L,1L,1L,4L,4L,1L,1L,1L,4L,1L,1L,6L,20L,1L,8L,2L,2L,1L,5L,1L,11L,1L,10L,1L,5L,1L,1L,2L,5L,9L,1L,5L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016492Inst : IEnumerable<long>
{
public static readonly long[] Value=A016492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016492.Bytes);
public long this[int i]=>Value[i];

public static A016492Inst Instance=new A016492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016493
{
public static readonly long[] Value={ 4L,5L,1L,2L,1L,3L,4L,21L,22L,2L,4L,1L,2L,1L,2L,1L,1L,1L,1L,3L,22L,2L,1L,4L,4L,2L,2L,1L,1L,1L,278L,5L,1L,7L,2L,1L,1L,1L,4L,6L,22L,4L,2L,5L,1L,43L,1L,1L,8L,1L,22L,19L,2L,64L,1L,17L,2L,3L,3L,2L,1L,1L,2L,19L,5L,9L,2L,2L,2L,13L,1L,8L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016493Inst : IEnumerable<long>
{
public static readonly long[] Value=A016493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016493.Bytes);
public long this[int i]=>Value[i];

public static A016493Inst Instance=new A016493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016494
{
public static readonly long[] Value={ 4L,5L,3L,1L,1L,1L,690L,18L,2L,5L,4L,1L,20L,4L,5L,2L,3L,1L,1L,1L,1L,4L,1L,46L,11L,10L,1L,2L,3L,1L,4L,1L,2L,3L,1L,52L,1L,2L,2L,2L,1L,8L,1L,33L,2L,13L,1L,6L,2L,3L,1L,3L,1L,4L,18L,1L,6L,1L,25L,1L,1L,123L,2L,1L,2L,1L,4L,1L,8L,12L,38L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016494Inst : IEnumerable<long>
{
public static readonly long[] Value=A016494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016494.Bytes);
public long this[int i]=>Value[i];

public static A016494Inst Instance=new A016494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016495
{
public static readonly long[] Value={ 4L,4L,1L,7L,1L,2L,1L,1L,1L,1L,1L,9L,1L,4L,3L,1L,5L,4L,1L,80L,2L,2L,1L,9L,1L,5L,6L,1L,2L,2L,2L,12L,1L,1L,1L,1L,2L,1L,5L,1L,4L,1L,1L,5L,1L,1L,3L,12L,2L,3L,1L,1L,2L,1L,14L,5L,7L,2L,2L,1L,1L,1L,3L,25L,1L,3L,4L,5L,22L,2L,1L,2L,1L,2L,1L,1L,66L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016495Inst : IEnumerable<long>
{
public static readonly long[] Value=A016495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016495.Bytes);
public long this[int i]=>Value[i];

public static A016495Inst Instance=new A016495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016496
{
public static readonly long[] Value={ 4L,4L,1L,1L,3L,1L,131L,1L,2L,2L,8L,2L,2L,2L,10L,1L,1L,3L,1L,39L,1L,6L,1L,1L,1L,1L,1L,3L,3L,3L,3L,1L,2L,12L,2L,3L,1L,7L,3L,25L,4L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,26L,2L,3L,9L,1L,133L,1L,1L,2L,3L,1L,1L,1L,1L,10L,7L,7L,1L,1L,7L,1L,11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016496Inst : IEnumerable<long>
{
public static readonly long[] Value=A016496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016496.Bytes);
public long this[int i]=>Value[i];

public static A016496Inst Instance=new A016496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016497
{
public static readonly long[] Value={ 4L,4L,3L,1L,2L,6L,1L,2L,1L,1L,6L,1L,11L,1L,10L,1L,3L,5L,1L,6L,1L,8L,1L,1L,2L,43L,1L,17L,14L,1L,4L,6L,1L,3L,1L,1L,6L,1L,1L,1L,1L,2L,281L,7L,1L,1L,1L,3L,1L,1L,1L,723L,1L,2L,2L,7L,7L,1L,3L,45L,3L,1L,1L,1L,4L,2L,1L,1L,4L,3L,1L,2L,9L,1L,1L,1L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016497Inst : IEnumerable<long>
{
public static readonly long[] Value=A016497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016497.Bytes);
public long this[int i]=>Value[i];

public static A016497Inst Instance=new A016497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016498
{
public static readonly long[] Value={ 4L,4L,41L,3L,1L,1L,25L,10L,7L,1L,1L,4L,3L,1L,2L,2L,5L,2L,1L,1L,3L,2L,1L,1L,12L,1L,1L,1L,1L,1L,39L,1L,1L,1L,22L,1L,24L,4L,13L,4L,1L,1L,1L,106L,1L,1L,10L,22L,1L,1L,2L,4L,3L,1L,5L,1L,8L,5L,1L,1L,152L,1L,15L,1L,3L,1L,6L,2L,1L,2L,1L,2L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016498Inst : IEnumerable<long>
{
public static readonly long[] Value=A016498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016498.Bytes);
public long this[int i]=>Value[i];

public static A016498Inst Instance=new A016498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016499
{
public static readonly long[] Value={ 4L,3L,1L,4L,5L,1L,1L,2L,2L,6L,48L,8L,1L,26L,6L,14L,1L,1L,4L,1L,2L,1L,7L,4L,2L,2L,4L,1L,7L,2L,10L,1L,5L,1L,4L,3L,4L,9L,9L,1L,5L,1L,5L,6L,1L,3L,4L,10L,743L,1L,16L,1L,2L,1L,11L,1L,3L,1L,3L,1L,2L,2L,4L,5L,33L,4L,12L,1L,6L,1L,1L,18L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016499Inst : IEnumerable<long>
{
public static readonly long[] Value=A016499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016499.Bytes);
public long this[int i]=>Value[i];

public static A016499Inst Instance=new A016499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016500
{
public static readonly long[] Value={ 4L,3L,1L,1L,1L,1L,2L,6L,20L,7L,1L,1L,2L,1L,5L,1L,1L,2L,2L,1L,3L,1L,5L,1L,6L,1L,3L,1L,6L,1L,2L,5L,1L,1L,1L,2L,1L,4L,20563L,1L,10L,3L,1L,1L,1L,1L,4L,1L,5L,1L,2L,1L,1L,9L,11L,2L,1L,11L,1L,1L,1L,11L,2L,3L,1L,1L,1L,1L,16L,1L,1L,1L,18L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016500Inst : IEnumerable<long>
{
public static readonly long[] Value=A016500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016500.Bytes);
public long this[int i]=>Value[i];

public static A016500Inst Instance=new A016500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016501
{
public static readonly long[] Value={ 4L,3L,2L,3L,1L,6L,1L,4L,1L,5L,1L,1L,1L,3L,1L,1L,2L,4L,1L,1L,1L,1L,2L,32L,1L,1L,1L,6L,1L,3L,1L,2L,1L,1L,2L,1L,1L,1L,11L,1L,5L,2L,27L,4L,1L,1L,1L,1L,5L,1L,24L,2L,3L,2L,2L,5L,3L,2L,3L,4L,2L,1L,2L,6L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,72L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016501Inst : IEnumerable<long>
{
public static readonly long[] Value=A016501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016501.Bytes);
public long this[int i]=>Value[i];

public static A016501Inst Instance=new A016501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016502
{
public static readonly long[] Value={ 4L,3L,3L,2L,6L,3L,1L,49L,1L,1L,4L,1L,1L,7L,3L,1L,1L,20L,3L,30L,20L,1L,1L,4L,1L,1L,5L,1L,10L,1L,96L,1L,3L,2L,1L,4L,5L,1L,1L,2L,2L,1L,2L,3L,4L,1L,4L,1L,1L,7L,1L,4L,1L,4L,79L,1L,2L,4L,1L,14L,4L,4L,11L,1L,1L,2L,2L,2L,2L,10L,1L,2L,1L,3L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016502Inst : IEnumerable<long>
{
public static readonly long[] Value=A016502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016502.Bytes);
public long this[int i]=>Value[i];

public static A016502Inst Instance=new A016502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016503
{
public static readonly long[] Value={ 4L,3L,6L,1L,2L,8L,1L,2L,1L,1L,23L,1L,28L,7L,1L,55L,1L,5L,2L,2L,1L,45L,1L,2L,2L,6L,1L,7L,2L,2L,1L,5L,46L,1L,53L,2L,2L,12L,3L,2L,30L,1L,1L,1L,1L,2L,1L,6L,3L,8L,2L,2L,1L,5L,3L,1L,1L,31L,3L,1L,441L,3L,3L,1L,2L,1L,3L,2L,1L,1L,4L,2L,1L,4L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016503Inst : IEnumerable<long>
{
public static readonly long[] Value=A016503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016503.Bytes);
public long this[int i]=>Value[i];

public static A016503Inst Instance=new A016503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016504
{
public static readonly long[] Value={ 4L,3L,42L,2L,2L,21L,1L,1L,6L,1L,15L,3L,2L,1L,2L,1L,1L,2L,2L,1L,4L,1L,3L,5L,1L,2L,1L,8L,1L,2L,1L,1L,1L,1L,2L,4L,7L,1L,2L,1L,1L,2L,3L,1L,3L,2L,7L,17L,3L,1L,19L,1L,1L,2L,9L,5L,1L,5L,1L,1L,1L,19L,1L,2L,9L,1L,2L,3L,2L,1L,3L,88L,1L,13L,3L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016504Inst : IEnumerable<long>
{
public static readonly long[] Value=A016504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016504.Bytes);
public long this[int i]=>Value[i];

public static A016504Inst Instance=new A016504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016505
{
public static readonly long[] Value={ 4L,2L,1L,9L,1L,16L,1L,2L,2L,4484L,1L,1L,4L,1L,1L,1L,4L,8L,3L,1L,3L,1L,2L,1L,1L,1L,4L,1L,1L,11L,5L,1L,11L,13L,1L,2L,4L,8L,2L,13L,3L,6L,1L,1L,8L,1L,9L,1L,4L,7L,1L,1L,3L,1L,3L,3L,25L,2L,40L,1L,1L,680L,3L,70L,1L,34L,1L,6L,3L,1L,5L,10L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016505Inst : IEnumerable<long>
{
public static readonly long[] Value=A016505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016505.Bytes);
public long this[int i]=>Value[i];

public static A016505Inst Instance=new A016505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016506
{
public static readonly long[] Value={ 4L,2L,1L,4L,11L,1L,1L,5L,1L,1L,1L,2L,1L,16L,1L,5L,5L,1L,2L,5L,6L,1L,1L,1L,11L,4L,1L,1L,24L,293L,1L,2L,1L,8L,2L,5L,8L,2L,1L,8L,2L,36L,1L,1L,2L,1995L,1L,1L,9L,1L,46L,1L,1L,1L,1L,1L,3L,1L,3L,61L,4L,1L,9L,1L,1L,1L,1L,2L,3L,10L,65L,3L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016506Inst : IEnumerable<long>
{
public static readonly long[] Value=A016506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016506.Bytes);
public long this[int i]=>Value[i];

public static A016506Inst Instance=new A016506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016507
{
public static readonly long[] Value={ 4L,2L,1L,2L,2L,2L,3L,1L,1L,1L,1L,2L,2L,1L,50L,1L,1L,4L,5L,4L,1L,7L,1L,3L,1L,1L,1L,27L,2L,5L,4L,13L,1L,1L,2L,3L,2L,6L,3L,5L,12L,13L,1L,15L,1L,1L,1L,6L,1L,9L,2L,7L,1L,1L,4L,1L,3L,22L,2L,5L,2L,2L,2L,1L,2L,43L,21L,17L,67L,1L,1L,21L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016507Inst : IEnumerable<long>
{
public static readonly long[] Value=A016507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016507.Bytes);
public long this[int i]=>Value[i];

public static A016507Inst Instance=new A016507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016508
{
public static readonly long[] Value={ 4L,2L,1L,1L,1L,1L,1L,1L,2L,29L,1L,17L,2L,1L,1L,1L,3L,2L,1L,27L,1L,10L,1L,3L,1L,2L,3L,5L,5L,1L,3L,2L,3L,4L,1L,22L,5L,1L,1L,2L,2L,2L,1L,2L,7L,4L,9L,1L,2L,2L,12L,9L,3L,1L,8L,1L,11L,4L,1L,196L,1L,2L,2L,3L,2L,5L,1L,4L,2L,1L,17L,1L,5L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016508Inst : IEnumerable<long>
{
public static readonly long[] Value=A016508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016508.Bytes);
public long this[int i]=>Value[i];

public static A016508Inst Instance=new A016508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016509
{
public static readonly long[] Value={ 4L,2L,1L,1L,6L,1L,1L,1L,1L,5L,1L,17L,1L,7L,2L,1L,2L,4L,4L,3L,1L,7L,1L,1L,4L,2L,1L,8L,2L,2L,5L,2L,1L,2L,1L,5L,1L,11L,5L,1L,3L,55L,1L,1L,1L,1L,9L,613L,1L,3L,2L,1L,1L,3L,1L,1L,1L,1L,2L,3L,1L,18L,1L,10L,1L,2L,1L,23L,5L,2L,4L,1L,1L,4L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016509Inst : IEnumerable<long>
{
public static readonly long[] Value=A016509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016509.Bytes);
public long this[int i]=>Value[i];

public static A016509Inst Instance=new A016509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016510
{
public static readonly long[] Value={ 4L,2L,2L,5L,1L,1L,4L,4L,1L,2L,2L,1L,12L,1L,9L,2L,49L,2L,1L,7L,1L,1L,2L,1L,1L,6L,1L,2L,1L,4L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,1L,1L,1L,2L,5L,2L,3L,1L,1L,2L,1L,1L,3L,1L,9L,1L,1L,3L,1L,2L,1L,236L,4L,1L,3L,98L,1L,11L,7L,3L,3L,1L,1L,3L,6L,3L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016510Inst : IEnumerable<long>
{
public static readonly long[] Value=A016510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016510.Bytes);
public long this[int i]=>Value[i];

public static A016510Inst Instance=new A016510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016511
{
public static readonly long[] Value={ 4L,2L,2L,1L,1L,2L,1L,1L,1L,1L,3L,74L,1L,1L,37L,1L,2L,1L,2L,4L,12L,119L,1L,65L,1L,9L,1L,5L,6L,2L,2L,37L,1L,1L,3L,2L,4L,2L,2L,2L,4L,3L,2L,4L,4L,2L,4L,4L,1L,1L,2L,9L,3L,8L,1L,122L,8L,2L,2L,3L,1L,1L,26L,3L,3L,3L,2L,3L,1L,9L,1L,166L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016511Inst : IEnumerable<long>
{
public static readonly long[] Value=A016511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016511.Bytes);
public long this[int i]=>Value[i];

public static A016511Inst Instance=new A016511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016512
{
public static readonly long[] Value={ 4L,2L,3L,8L,1L,4L,11L,1L,68L,1L,12L,1L,2L,2L,1L,1L,32L,2L,2L,3L,1L,2L,4L,1L,1L,30L,2L,2L,1L,1L,3L,1L,106L,55L,9L,1L,4L,1L,1L,19L,1L,5L,32L,1L,1L,1L,4L,2L,1L,2L,3L,26L,1L,1L,2L,27L,4L,16L,2L,9L,3L,2L,9L,19L,1L,1L,1L,1L,9L,1L,1L,3L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016512Inst : IEnumerable<long>
{
public static readonly long[] Value=A016512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016512.Bytes);
public long this[int i]=>Value[i];

public static A016512Inst Instance=new A016512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016513
{
public static readonly long[] Value={ 4L,2L,3L,1L,6L,9L,2L,1L,7L,1L,1L,3L,1L,9L,1L,7L,1L,1L,4L,1L,3L,2L,1L,1L,1L,42L,1L,2L,61L,1L,3L,1L,1L,6L,4L,3L,1L,1L,8L,3L,2L,1L,38L,11L,3L,43L,5L,2L,20L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,4L,1L,1L,9L,1L,1L,2L,1L,1L,4L,2L,1L,1L,44L,3L,1L,12L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016513Inst : IEnumerable<long>
{
public static readonly long[] Value=A016513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016513.Bytes);
public long this[int i]=>Value[i];

public static A016513Inst Instance=new A016513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016514
{
public static readonly long[] Value={ 4L,2L,4L,1L,40L,1L,7L,1L,16L,1L,2L,2L,1L,17L,1L,79L,1L,1L,18L,1L,1L,1L,2L,1L,4L,1L,4L,1L,5L,1L,1L,2L,11L,8L,2L,1L,4L,22L,6L,2L,1L,2L,14L,8L,6L,5L,1L,1L,13L,2L,1L,3L,13L,2L,4L,2L,2L,1L,4L,1L,1L,1L,3L,1L,2L,1L,1L,1L,10L,1L,17L,4L,7L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016514Inst : IEnumerable<long>
{
public static readonly long[] Value=A016514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016514.Bytes);
public long this[int i]=>Value[i];

public static A016514Inst Instance=new A016514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016515
{
public static readonly long[] Value={ 4L,2L,6L,1L,4L,1L,131L,1L,80L,1L,3L,53L,5L,1L,6L,1L,1L,2L,6L,4L,3L,2L,20L,1L,1L,1L,16L,1L,16L,1L,2L,1L,3L,1L,2L,4L,7L,1L,4L,9L,1L,37L,1L,1L,1L,20L,3L,19L,1L,31L,3L,1L,2L,1L,15L,1L,2L,1L,2L,1L,4L,743L,4L,1L,2L,4L,1L,1L,3L,1L,2L,1L,2L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016515Inst : IEnumerable<long>
{
public static readonly long[] Value=A016515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016515.Bytes);
public long this[int i]=>Value[i];

public static A016515Inst Instance=new A016515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016516
{
public static readonly long[] Value={ 4L,2L,10L,1L,1L,7L,1L,1L,6L,4L,18L,1L,4L,37L,1L,1L,3L,26L,1L,31L,2L,4L,18L,1L,2L,1L,3L,1L,8L,1L,4L,2L,1L,2L,7L,11L,2L,2L,1L,3L,1L,1L,1L,3L,1L,12L,2L,7L,3L,2L,3L,3L,1L,1L,22L,2L,4L,1L,1L,4L,5L,7L,3L,13L,2L,1L,4L,1L,2L,354L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016516Inst : IEnumerable<long>
{
public static readonly long[] Value=A016516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016516.Bytes);
public long this[int i]=>Value[i];

public static A016516Inst Instance=new A016516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016517
{
public static readonly long[] Value={ 4L,2L,21L,1L,1L,21183L,2L,1L,1L,1L,90L,1L,1L,4L,13L,1L,1L,1L,2L,3L,2L,1L,113L,1L,3L,3L,9L,8L,1L,3L,1L,1L,8L,1L,2L,1L,1L,8L,1L,8L,5L,3L,1L,6L,1L,6L,3L,3L,3L,2L,1L,10L,1L,3L,2L,8L,1L,24L,1L,11L,5L,5L,1L,1L,1L,1L,8L,2L,2L,1L,15L,5L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016517Inst : IEnumerable<long>
{
public static readonly long[] Value=A016517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016517.Bytes);
public long this[int i]=>Value[i];

public static A016517Inst Instance=new A016517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016518
{
public static readonly long[] Value={ 4L,2L,1313L,96L,5L,2L,2L,1L,26L,1L,38L,2L,2L,15L,1L,2L,2L,1L,1L,1L,4L,2L,2L,31L,1L,1L,1L,22L,2L,1L,18L,4L,2L,4L,1L,2L,5L,1L,15L,4L,1L,2L,2L,2L,3L,1L,1L,2L,2L,36L,1L,10L,1L,1L,1L,1L,29L,1L,7L,1L,4L,1L,1L,3L,7L,3L,6L,1L,1L,1L,1L,12L,17L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016518Inst : IEnumerable<long>
{
public static readonly long[] Value=A016518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016518.Bytes);
public long this[int i]=>Value[i];

public static A016518Inst Instance=new A016518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016519
{
public static readonly long[] Value={ 4L,1L,1L,22L,1L,1L,11L,4L,3L,1L,8L,1L,1L,1L,8L,1L,3L,4L,2L,1L,5L,1L,1L,1L,2L,2L,1L,21L,1L,1L,1L,1L,3L,7L,3L,1L,1L,1L,1L,5L,12L,1L,138L,1L,1L,106L,5L,1L,1L,3L,33L,9L,1L,2L,4L,15L,5L,1L,1L,1L,1L,4L,2L,3L,1L,3L,3L,1L,5L,2L,2L,1L,4L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016519Inst : IEnumerable<long>
{
public static readonly long[] Value=A016519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016519.Bytes);
public long this[int i]=>Value[i];

public static A016519Inst Instance=new A016519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016520
{
public static readonly long[] Value={ 4L,1L,1L,10L,1L,37L,3L,6L,1L,1L,2L,1L,1L,1L,1L,2L,3L,8L,1L,20L,1L,71L,6L,1L,82L,4L,4L,2L,13L,1L,20L,1L,6L,1L,1L,1L,3L,1L,2L,2L,4L,1L,2L,1L,4L,7L,2L,2L,12L,1L,4L,7L,1L,1L,1L,1L,1L,1L,1L,2L,5L,1L,1L,1L,1L,1L,8L,1L,5L,4L,1L,1L,4L,3L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016520Inst : IEnumerable<long>
{
public static readonly long[] Value=A016520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016520.Bytes);
public long this[int i]=>Value[i];

public static A016520Inst Instance=new A016520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016521
{
public static readonly long[] Value={ 4L,1L,1L,7L,5L,1L,12L,598L,1L,3L,372L,10L,100L,1L,8L,25L,2L,1L,1L,4L,1L,4L,1L,2L,3L,2L,1L,3L,1L,1L,1L,1L,1L,12L,1L,1L,3L,2L,77L,4L,4L,10L,1L,1L,2L,1L,3L,9L,1L,10L,6L,5L,7L,1L,2L,3L,1L,8L,1L,1L,1L,12L,2L,2L,2L,1L,24L,2L,19L,1L,4L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016521Inst : IEnumerable<long>
{
public static readonly long[] Value=A016521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016521.Bytes);
public long this[int i]=>Value[i];

public static A016521Inst Instance=new A016521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016522
{
public static readonly long[] Value={ 4L,1L,1L,5L,3L,1L,1L,1L,4L,2L,2L,36L,2L,4L,3L,1L,12L,4L,1L,1L,2L,1L,1L,2L,2L,2L,1L,5L,4L,1L,1L,2L,1L,14L,2L,3L,5L,3L,2L,1L,25L,2L,2L,1L,1L,6L,4L,22L,10L,1L,8L,1L,2L,1L,1L,1L,1L,2L,9L,1L,1L,5L,2L,4L,1L,2L,5L,2L,9L,10L,2L,1L,1L,4L,1L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016522Inst : IEnumerable<long>
{
public static readonly long[] Value=A016522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016522.Bytes);
public long this[int i]=>Value[i];

public static A016522Inst Instance=new A016522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016523
{
public static readonly long[] Value={ 4L,1L,1L,4L,7L,7L,1L,1L,3L,1L,1L,4L,2L,7L,25L,1L,1L,5L,1L,1L,1L,58L,1L,7L,1L,1L,6L,1L,39L,1L,3L,11L,2L,2L,1L,3L,1L,1L,41L,31L,4L,1L,3L,1L,1L,1L,5L,12L,1L,3L,1L,2L,2L,26L,1L,3L,6L,2L,1L,1L,1L,1L,1L,1L,9L,5L,1L,1L,1L,5L,2L,1L,22L,2L,2L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016523Inst : IEnumerable<long>
{
public static readonly long[] Value=A016523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016523.Bytes);
public long this[int i]=>Value[i];

public static A016523Inst Instance=new A016523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016524
{
public static readonly long[] Value={ 4L,1L,1L,3L,2L,1L,1L,2L,11L,1L,1L,53L,2L,7L,1L,1L,6L,3L,1L,1L,5L,15L,7L,1L,1L,1L,6L,1L,3L,1L,1L,1L,2L,3L,1L,3L,1L,53L,1L,2L,2L,2L,8L,1L,1L,9L,3L,1L,1L,26L,1L,28L,3L,95L,4L,11L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,4L,19L,1L,6L,4L,1L,1L,1L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016524Inst : IEnumerable<long>
{
public static readonly long[] Value=A016524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016524.Bytes);
public long this[int i]=>Value[i];

public static A016524Inst Instance=new A016524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016525
{
public static readonly long[] Value={ 4L,1L,1L,2L,1L,5L,1L,1L,78L,1L,4L,26L,2L,4L,2L,1L,1L,4L,21L,2L,2L,1L,1L,1L,1L,1L,36L,1L,12L,8L,2L,1L,1L,2L,12L,1L,2L,3L,4L,1L,23L,1L,1L,2L,3L,11L,1L,8L,1L,3L,1L,2L,1L,1L,1L,3L,8L,11L,6L,4L,1L,2L,1L,3L,3L,1L,4L,1L,4L,1L,28L,1L,16L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016525Inst : IEnumerable<long>
{
public static readonly long[] Value=A016525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016525.Bytes);
public long this[int i]=>Value[i];

public static A016525Inst Instance=new A016525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016590
{
public static readonly long[] Value={ 2L,6L,0L,2L,6L,8L,9L,6L,8L,5L,4L,4L,4L,3L,8L,3L,7L,6L,4L,7L,6L,8L,5L,0L,3L,5L,8L,9L,3L,0L,9L,4L,0L,0L,5L,4L,5L,8L,6L,6L,9L,7L,1L,5L,3L,9L,1L,0L,7L,9L,9L,3L,1L,0L,1L,0L,8L,3L,4L,0L,2L,9L,9L,1L,4L,1L,9L,0L,8L,9L,2L,5L,7L,6L,8L,6L,1L,3L,2L,1L,8L,5L,0L,1L,4L,9L,8L,3L,9L,3L,7L,4L,4L,4L,7L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016590Inst : IEnumerable<long>
{
public static readonly long[] Value=A016590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016590.Bytes);
public long this[int i]=>Value[i];

public static A016590Inst Instance=new A016590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016591
{
public static readonly long[] Value={ 2L,6L,7L,4L,1L,4L,8L,6L,4L,9L,4L,2L,6L,5L,2L,8L,7L,1L,7L,7L,6L,6L,0L,3L,9L,9L,1L,0L,9L,0L,3L,7L,3L,5L,0L,3L,7L,4L,1L,9L,0L,1L,2L,7L,7L,9L,5L,6L,2L,4L,8L,8L,8L,2L,4L,8L,0L,0L,9L,9L,0L,3L,4L,2L,1L,4L,9L,3L,8L,7L,1L,5L,9L,1L,6L,8L,1L,5L,7L,6L,1L,7L,6L,8L,7L,5L,0L,3L,7L,8L,7L,8L,2L,1L,4L,3L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016591Inst : IEnumerable<long>
{
public static readonly long[] Value=A016591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016591.Bytes);
public long this[int i]=>Value[i];

public static A016591Inst Instance=new A016591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016592
{
public static readonly long[] Value={ 2L,7L,4L,0L,8L,4L,0L,0L,2L,3L,9L,2L,5L,2L,0L,0L,9L,3L,6L,5L,1L,1L,9L,3L,2L,2L,0L,3L,0L,8L,4L,1L,8L,0L,6L,4L,2L,3L,7L,4L,4L,3L,8L,7L,9L,6L,1L,2L,0L,3L,3L,6L,7L,1L,7L,6L,3L,6L,0L,3L,8L,0L,6L,2L,9L,8L,1L,5L,8L,7L,7L,9L,4L,6L,2L,7L,8L,5L,6L,5L,1L,6L,6L,0L,8L,0L,0L,1L,5L,0L,4L,3L,3L,9L,6L,6L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016592Inst : IEnumerable<long>
{
public static readonly long[] Value=A016592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016592.Bytes);
public long this[int i]=>Value[i];

public static A016592Inst Instance=new A016592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016593
{
public static readonly long[] Value={ 2L,8L,0L,3L,3L,6L,0L,3L,8L,0L,9L,0L,6L,5L,3L,4L,9L,2L,6L,0L,3L,9L,9L,5L,6L,6L,9L,3L,4L,2L,9L,4L,7L,8L,4L,3L,6L,3L,9L,3L,6L,9L,7L,2L,7L,7L,3L,9L,9L,9L,1L,1L,3L,7L,2L,8L,3L,2L,5L,8L,2L,0L,3L,3L,2L,7L,4L,6L,7L,4L,2L,9L,5L,1L,6L,2L,1L,5L,0L,9L,6L,4L,3L,4L,2L,8L,0L,7L,1L,3L,5L,8L,1L,9L,9L,4L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016593Inst : IEnumerable<long>
{
public static readonly long[] Value=A016593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016593.Bytes);
public long this[int i]=>Value[i];

public static A016593Inst Instance=new A016593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016594
{
public static readonly long[] Value={ 2L,8L,6L,2L,2L,0L,0L,8L,8L,0L,9L,2L,9L,4L,6L,8L,3L,7L,0L,2L,8L,8L,8L,7L,9L,9L,5L,5L,2L,1L,1L,1L,9L,0L,8L,0L,1L,0L,8L,7L,1L,8L,5L,9L,4L,9L,4L,9L,0L,1L,2L,3L,6L,5L,6L,2L,5L,1L,3L,5L,8L,0L,3L,1L,9L,1L,8L,3L,6L,5L,2L,2L,8L,4L,9L,0L,0L,3L,2L,3L,1L,6L,8L,1L,1L,9L,2L,9L,0L,4L,9L,6L,8L,4L,6L,3L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016594Inst : IEnumerable<long>
{
public static readonly long[] Value=A016594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016594.Bytes);
public long this[int i]=>Value[i];

public static A016594Inst Instance=new A016594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016595
{
public static readonly long[] Value={ 2L,9L,1L,7L,7L,7L,0L,7L,3L,2L,0L,8L,4L,2L,7L,9L,1L,3L,4L,9L,5L,0L,8L,6L,3L,5L,4L,9L,5L,7L,3L,2L,7L,0L,5L,9L,5L,8L,2L,4L,5L,7L,7L,4L,5L,2L,8L,0L,7L,3L,8L,0L,9L,0L,9L,5L,2L,4L,2L,3L,2L,6L,7L,1L,6L,9L,9L,5L,9L,6L,1L,2L,5L,0L,2L,0L,6L,6L,6L,3L,4L,9L,7L,9L,3L,1L,5L,8L,2L,0L,6L,6L,7L,5L,7L,4L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016595Inst : IEnumerable<long>
{
public static readonly long[] Value=A016595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016595.Bytes);
public long this[int i]=>Value[i];

public static A016595Inst Instance=new A016595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016596
{
public static readonly long[] Value={ 2L,9L,7L,0L,4L,1L,4L,4L,6L,5L,5L,6L,9L,7L,0L,1L,1L,1L,8L,0L,3L,1L,5L,0L,0L,5L,5L,7L,0L,2L,9L,6L,6L,7L,7L,4L,1L,3L,7L,7L,2L,5L,8L,3L,6L,8L,2L,2L,2L,7L,0L,1L,3L,1L,4L,0L,3L,3L,0L,5L,9L,8L,3L,4L,8L,0L,7L,5L,6L,5L,3L,3L,8L,5L,7L,3L,3L,2L,4L,4L,3L,0L,6L,6L,7L,3L,2L,7L,0L,9L,1L,2L,5L,7L,8L,0L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016596Inst : IEnumerable<long>
{
public static readonly long[] Value=A016596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016596.Bytes);
public long this[int i]=>Value[i];

public static A016596Inst Instance=new A016596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016597
{
public static readonly long[] Value={ 3L,0L,2L,0L,4L,2L,4L,8L,8L,6L,1L,4L,4L,3L,6L,2L,4L,9L,4L,4L,4L,9L,5L,3L,1L,2L,5L,1L,5L,7L,9L,2L,3L,1L,0L,2L,0L,3L,0L,0L,9L,1L,0L,3L,3L,5L,0L,3L,9L,0L,4L,6L,3L,7L,9L,4L,9L,8L,5L,8L,2L,9L,0L,0L,7L,6L,6L,5L,8L,4L,9L,9L,4L,4L,3L,5L,9L,6L,2L,7L,9L,0L,3L,5L,6L,4L,5L,3L,8L,1L,4L,3L,7L,5L,5L,6L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016597Inst : IEnumerable<long>
{
public static readonly long[] Value=A016597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016597.Bytes);
public long this[int i]=>Value[i];

public static A016597Inst Instance=new A016597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016598
{
public static readonly long[] Value={ 3L,0L,6L,8L,0L,5L,2L,9L,3L,5L,1L,3L,3L,6L,1L,7L,1L,1L,4L,0L,5L,5L,6L,1L,0L,3L,9L,1L,8L,8L,7L,6L,7L,0L,4L,6L,7L,4L,8L,3L,6L,3L,6L,0L,5L,0L,5L,2L,1L,3L,0L,0L,1L,6L,1L,0L,7L,1L,0L,0L,5L,2L,5L,5L,4L,2L,9L,4L,6L,5L,5L,5L,1L,9L,0L,3L,2L,9L,1L,7L,2L,2L,9L,3L,1L,7L,2L,8L,6L,7L,1L,0L,8L,7L,5L,7L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016598Inst : IEnumerable<long>
{
public static readonly long[] Value=A016598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016598.Bytes);
public long this[int i]=>Value[i];

public static A016598Inst Instance=new A016598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016599
{
public static readonly long[] Value={ 3L,1L,1L,3L,5L,1L,5L,3L,0L,9L,2L,1L,0L,3L,7L,4L,4L,4L,7L,9L,7L,4L,0L,1L,7L,6L,8L,5L,6L,1L,3L,0L,6L,2L,4L,8L,0L,7L,4L,5L,0L,8L,2L,3L,3L,5L,5L,5L,3L,7L,6L,1L,3L,7L,1L,2L,6L,1L,3L,5L,6L,5L,4L,9L,2L,5L,5L,7L,7L,3L,9L,5L,2L,1L,7L,5L,1L,8L,0L,9L,8L,2L,7L,7L,1L,5L,0L,2L,0L,6L,0L,7L,2L,4L,2L,2L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016599Inst : IEnumerable<long>
{
public static readonly long[] Value=A016599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016599.Bytes);
public long this[int i]=>Value[i];

public static A016599Inst Instance=new A016599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016600
{
public static readonly long[] Value={ 3L,1L,5L,7L,0L,0L,0L,4L,2L,1L,1L,5L,0L,1L,1L,3L,2L,7L,7L,4L,0L,3L,7L,1L,8L,5L,4L,8L,3L,1L,3L,9L,9L,7L,1L,4L,0L,8L,2L,0L,5L,5L,0L,3L,6L,7L,6L,5L,9L,9L,6L,8L,7L,7L,9L,0L,7L,9L,8L,2L,8L,3L,3L,7L,3L,1L,3L,4L,2L,4L,5L,9L,1L,5L,3L,6L,1L,0L,6L,3L,5L,7L,0L,0L,4L,8L,2L,6L,4L,2L,6L,4L,3L,8L,3L,2L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016600Inst : IEnumerable<long>
{
public static readonly long[] Value=A016600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016600.Bytes);
public long this[int i]=>Value[i];

public static A016600Inst Instance=new A016600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016601
{
public static readonly long[] Value={ 3L,1L,9L,8L,6L,7L,3L,1L,1L,7L,5L,5L,0L,6L,8L,1L,3L,0L,0L,7L,9L,3L,4L,7L,3L,3L,6L,5L,4L,2L,8L,1L,8L,2L,8L,9L,1L,1L,9L,8L,6L,6L,9L,3L,2L,4L,8L,0L,3L,4L,6L,7L,1L,2L,2L,7L,9L,8L,1L,0L,0L,2L,9L,0L,3L,8L,1L,7L,6L,6L,1L,0L,3L,5L,3L,4L,4L,4L,3L,8L,1L,9L,9L,6L,9L,4L,5L,3L,6L,7L,0L,1L,7L,9L,3L,2L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016601Inst : IEnumerable<long>
{
public static readonly long[] Value=A016601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016601.Bytes);
public long this[int i]=>Value[i];

public static A016601Inst Instance=new A016601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016602
{
public static readonly long[] Value={ 3L,2L,3L,8L,6L,7L,8L,4L,5L,2L,1L,6L,4L,3L,8L,0L,4L,6L,2L,2L,2L,7L,5L,4L,7L,7L,3L,3L,3L,3L,7L,4L,7L,5L,6L,7L,2L,1L,6L,0L,1L,9L,3L,4L,3L,6L,0L,4L,8L,2L,3L,8L,9L,8L,4L,9L,1L,1L,2L,5L,2L,0L,6L,2L,0L,2L,6L,3L,9L,3L,2L,4L,7L,0L,4L,9L,8L,4L,5L,5L,3L,2L,1L,7L,9L,8L,4L,7L,2L,9L,5L,8L,5L,4L,8L,1L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016602Inst : IEnumerable<long>
{
public static readonly long[] Value=A016602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016602.Bytes);
public long this[int i]=>Value[i];

public static A016602Inst Instance=new A016602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016603
{
public static readonly long[] Value={ 3L,2L,7L,7L,1L,4L,4L,7L,3L,2L,9L,9L,2L,1L,7L,6L,5L,2L,4L,7L,2L,7L,2L,3L,7L,0L,1L,7L,5L,7L,0L,8L,8L,1L,2L,0L,2L,2L,8L,4L,4L,7L,7L,6L,1L,8L,5L,5L,0L,9L,6L,2L,3L,4L,8L,9L,2L,7L,4L,4L,9L,4L,6L,0L,5L,2L,4L,6L,1L,1L,0L,1L,1L,9L,7L,3L,7L,9L,5L,1L,4L,2L,9L,2L,8L,7L,9L,6L,6L,1L,7L,4L,8L,9L,5L,0L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016603Inst : IEnumerable<long>
{
public static readonly long[] Value=A016603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016603.Bytes);
public long this[int i]=>Value[i];

public static A016603Inst Instance=new A016603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016604
{
public static readonly long[] Value={ 3L,3L,1L,4L,1L,8L,6L,0L,0L,4L,6L,7L,2L,5L,2L,5L,6L,0L,9L,2L,4L,5L,4L,7L,0L,7L,8L,9L,7L,3L,3L,1L,4L,0L,3L,7L,1L,2L,7L,1L,8L,0L,8L,0L,7L,3L,8L,4L,5L,6L,7L,9L,6L,4L,3L,0L,1L,0L,5L,3L,5L,5L,9L,1L,1L,1L,1L,3L,5L,8L,9L,8L,9L,6L,5L,1L,1L,9L,9L,7L,6L,2L,0L,9L,9L,3L,2L,5L,2L,5L,9L,0L,9L,9L,3L,9L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016604Inst : IEnumerable<long>
{
public static readonly long[] Value=A016604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016604.Bytes);
public long this[int i]=>Value[i];

public static A016604Inst Instance=new A016604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016605
{
public static readonly long[] Value={ 3L,3L,4L,9L,9L,0L,4L,0L,8L,7L,2L,7L,4L,6L,0L,4L,8L,4L,1L,9L,8L,7L,0L,4L,0L,5L,4L,7L,3L,5L,2L,2L,0L,2L,6L,7L,3L,8L,0L,9L,3L,6L,9L,6L,8L,4L,7L,6L,1L,6L,2L,3L,0L,1L,6L,1L,5L,1L,9L,7L,4L,5L,6L,0L,5L,5L,3L,3L,9L,3L,3L,7L,3L,3L,1L,3L,1L,1L,1L,5L,3L,9L,9L,8L,1L,9L,1L,0L,8L,1L,1L,6L,3L,3L,0L,5L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016605Inst : IEnumerable<long>
{
public static readonly long[] Value=A016605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016605.Bytes);
public long this[int i]=>Value[i];

public static A016605Inst Instance=new A016605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016622
{
public static readonly long[] Value={ 3L,8L,1L,7L,7L,1L,2L,3L,2L,5L,9L,5L,6L,9L,0L,4L,7L,3L,1L,7L,4L,1L,6L,0L,8L,0L,6L,3L,5L,5L,0L,3L,2L,1L,7L,6L,6L,3L,6L,6L,8L,5L,2L,5L,3L,9L,9L,8L,1L,8L,1L,3L,0L,5L,0L,7L,5L,7L,7L,5L,5L,6L,5L,1L,1L,0L,7L,6L,5L,0L,9L,0L,8L,1L,0L,6L,7L,8L,4L,7L,3L,1L,5L,8L,1L,3L,6L,9L,8L,3L,5L,0L,3L,1L,9L,4L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016622Inst : IEnumerable<long>
{
public static readonly long[] Value=A016622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016622.Bytes);
public long this[int i]=>Value[i];

public static A016622Inst Instance=new A016622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016623
{
public static readonly long[] Value={ 3L,8L,3L,9L,4L,5L,2L,3L,1L,2L,5L,9L,3L,3L,1L,0L,6L,2L,7L,9L,0L,7L,1L,7L,7L,4L,4L,0L,0L,0L,6L,7L,0L,6L,3L,4L,7L,0L,2L,1L,9L,2L,9L,3L,5L,3L,9L,4L,3L,0L,8L,6L,1L,6L,9L,3L,7L,0L,7L,3L,2L,3L,9L,6L,6L,1L,9L,0L,8L,2L,0L,8L,7L,8L,4L,6L,4L,6L,5L,4L,8L,3L,4L,8L,1L,6L,1L,7L,2L,5L,9L,1L,5L,3L,4L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016623Inst : IEnumerable<long>
{
public static readonly long[] Value=A016623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016623.Bytes);
public long this[int i]=>Value[i];

public static A016623Inst Instance=new A016623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016624
{
public static readonly long[] Value={ 3L,8L,6L,0L,7L,2L,9L,7L,1L,1L,0L,4L,0L,5L,9L,5L,5L,2L,5L,1L,9L,2L,5L,5L,4L,6L,4L,3L,6L,5L,5L,8L,6L,4L,6L,0L,8L,6L,8L,7L,4L,8L,0L,4L,8L,1L,2L,0L,7L,3L,9L,1L,2L,8L,6L,3L,2L,9L,9L,2L,8L,1L,1L,8L,3L,9L,0L,0L,7L,8L,0L,6L,7L,8L,0L,2L,1L,6L,0L,3L,3L,7L,7L,3L,8L,4L,2L,8L,9L,3L,4L,9L,1L,2L,5L,0L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016624Inst : IEnumerable<long>
{
public static readonly long[] Value=A016624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016624.Bytes);
public long this[int i]=>Value[i];

public static A016624Inst Instance=new A016624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016625
{
public static readonly long[] Value={ 3L,8L,8L,1L,5L,6L,3L,7L,9L,7L,9L,4L,3L,4L,3L,7L,5L,1L,2L,6L,9L,9L,4L,8L,9L,5L,0L,0L,2L,4L,5L,7L,8L,5L,1L,4L,5L,7L,3L,3L,4L,1L,4L,7L,6L,8L,2L,9L,8L,5L,2L,6L,1L,0L,1L,8L,5L,5L,5L,5L,4L,3L,5L,9L,2L,6L,6L,7L,8L,3L,6L,6L,9L,8L,0L,8L,4L,9L,2L,4L,0L,9L,7L,3L,6L,4L,1L,9L,4L,1L,8L,0L,3L,7L,8L,5L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016625Inst : IEnumerable<long>
{
public static readonly long[] Value=A016625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016625.Bytes);
public long this[int i]=>Value[i];

public static A016625Inst Instance=new A016625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016626
{
public static readonly long[] Value={ 3L,9L,0L,1L,9L,7L,2L,6L,6L,9L,5L,7L,4L,6L,4L,4L,6L,1L,7L,4L,3L,5L,2L,0L,1L,9L,3L,0L,3L,5L,2L,0L,0L,4L,1L,4L,1L,0L,4L,1L,1L,8L,7L,8L,3L,5L,2L,2L,2L,6L,6L,0L,8L,2L,4L,5L,6L,7L,2L,7L,6L,3L,6L,6L,9L,1L,2L,1L,6L,8L,5L,8L,8L,3L,8L,0L,7L,5L,9L,9L,3L,1L,2L,1L,6L,4L,2L,2L,8L,9L,0L,6L,3L,3L,6L,8L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016626Inst : IEnumerable<long>
{
public static readonly long[] Value=A016626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016626.Bytes);
public long this[int i]=>Value[i];

public static A016626Inst Instance=new A016626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016627
{
public static readonly long[] Value={ 1L,3L,8L,6L,2L,9L,4L,3L,6L,1L,1L,1L,9L,8L,9L,0L,6L,1L,8L,8L,3L,4L,4L,6L,4L,2L,4L,2L,9L,1L,6L,3L,5L,3L,1L,3L,6L,1L,5L,1L,0L,0L,0L,2L,6L,8L,7L,2L,0L,5L,1L,0L,5L,0L,8L,2L,4L,1L,3L,6L,0L,0L,1L,8L,9L,8L,6L,7L,8L,7L,2L,4L,3L,9L,3L,9L,3L,8L,9L,4L,3L,1L,2L,1L,1L,7L,2L,6L,6L,5L,3L,9L,9L,2L,8L,3L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016627Inst : IEnumerable<long>
{
public static readonly long[] Value=A016627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016627.Bytes);
public long this[int i]=>Value[i];

public static A016627Inst Instance=new A016627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016628
{
public static readonly long[] Value={ 1L,6L,0L,9L,4L,3L,7L,9L,1L,2L,4L,3L,4L,1L,0L,0L,3L,7L,4L,6L,0L,0L,7L,5L,9L,3L,3L,3L,2L,2L,6L,1L,8L,7L,6L,3L,9L,5L,2L,5L,6L,0L,1L,3L,5L,4L,2L,6L,8L,5L,1L,7L,7L,2L,1L,9L,1L,2L,6L,4L,7L,8L,9L,1L,4L,7L,4L,1L,7L,8L,9L,8L,7L,7L,0L,7L,6L,5L,7L,7L,6L,4L,6L,3L,0L,1L,3L,3L,8L,7L,8L,0L,9L,3L,1L,7L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016628Inst : IEnumerable<long>
{
public static readonly long[] Value=A016628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016628.Bytes);
public long this[int i]=>Value[i];

public static A016628Inst Instance=new A016628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016629
{
public static readonly long[] Value={ 1L,7L,9L,1L,7L,5L,9L,4L,6L,9L,2L,2L,8L,0L,5L,5L,0L,0L,0L,8L,1L,2L,4L,7L,7L,3L,5L,8L,3L,8L,0L,7L,0L,2L,2L,7L,2L,7L,2L,2L,9L,9L,0L,6L,9L,2L,1L,8L,3L,0L,0L,4L,7L,0L,5L,8L,5L,5L,3L,7L,4L,3L,4L,3L,1L,3L,0L,8L,8L,7L,9L,1L,5L,1L,8L,8L,3L,0L,3L,6L,8L,2L,4L,7L,9L,4L,7L,9L,0L,8L,1L,8L,1L,0L,1L,5L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016629Inst : IEnumerable<long>
{
public static readonly long[] Value=A016629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016629.Bytes);
public long this[int i]=>Value[i];

public static A016629Inst Instance=new A016629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016630
{
public static readonly long[] Value={ 1L,9L,4L,5L,9L,1L,0L,1L,4L,9L,0L,5L,5L,3L,1L,3L,3L,0L,5L,1L,0L,5L,3L,5L,2L,7L,4L,3L,4L,4L,3L,1L,7L,9L,7L,2L,9L,6L,3L,7L,0L,8L,4L,7L,2L,9L,5L,8L,1L,8L,6L,1L,1L,8L,8L,4L,5L,9L,3L,9L,0L,1L,4L,9L,9L,3L,7L,5L,7L,9L,8L,6L,2L,7L,5L,2L,0L,6L,9L,2L,6L,7L,7L,8L,7L,6L,5L,8L,4L,9L,8L,5L,8L,7L,8L,7L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016630Inst : IEnumerable<long>
{
public static readonly long[] Value=A016630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016630.Bytes);
public long this[int i]=>Value[i];

public static A016630Inst Instance=new A016630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016631
{
public static readonly long[] Value={ 2L,0L,7L,9L,4L,4L,1L,5L,4L,1L,6L,7L,9L,8L,3L,5L,9L,2L,8L,2L,5L,1L,6L,9L,6L,3L,6L,4L,3L,7L,4L,5L,2L,9L,7L,0L,4L,2L,2L,6L,5L,0L,0L,4L,0L,3L,0L,8L,0L,7L,6L,5L,7L,6L,2L,3L,6L,2L,0L,4L,0L,0L,2L,8L,4L,8L,0L,1L,8L,0L,8L,6L,5L,9L,0L,9L,0L,8L,4L,1L,4L,6L,8L,1L,7L,5L,8L,9L,9L,8L,0L,9L,8L,9L,2L,5L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016631Inst : IEnumerable<long>
{
public static readonly long[] Value=A016631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016631.Bytes);
public long this[int i]=>Value[i];

public static A016631Inst Instance=new A016631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016632
{
public static readonly long[] Value={ 2L,1L,9L,7L,2L,2L,4L,5L,7L,7L,3L,3L,6L,2L,1L,9L,3L,8L,2L,7L,9L,0L,4L,9L,0L,4L,7L,3L,8L,4L,5L,0L,5L,1L,4L,0L,9L,2L,9L,4L,9L,8L,1L,1L,1L,5L,6L,4L,5L,4L,9L,8L,9L,0L,3L,4L,6L,9L,3L,8L,8L,6L,6L,7L,2L,7L,4L,9L,8L,8L,5L,8L,6L,4L,3L,7L,2L,1L,7L,9L,3L,3L,7L,4L,7L,2L,3L,1L,5L,0L,9L,6L,2L,7L,4L,6L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016632Inst : IEnumerable<long>
{
public static readonly long[] Value=A016632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016632.Bytes);
public long this[int i]=>Value[i];

public static A016632Inst Instance=new A016632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016633
{
public static readonly long[] Value={ 1L,25L,447L,6989L,101759L,1417941L,19180519L,253983853L,3309800367L,42599540357L,542895780791L,6863463633117L,86197420501375L,1076563471968373L,13382900349107463L,165700329729679181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016633Inst : IEnumerable<long>
{
public static readonly long[] Value=A016633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016633.Bytes);
public long this[int i]=>Value[i];

public static A016633Inst Instance=new A016633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016634
{
public static readonly long[] Value={ 2L,3L,9L,7L,8L,9L,5L,2L,7L,2L,7L,9L,8L,3L,7L,0L,5L,4L,4L,0L,6L,1L,9L,4L,3L,5L,7L,7L,9L,6L,5L,1L,2L,9L,2L,9L,9L,8L,2L,1L,7L,0L,6L,8L,5L,3L,9L,3L,7L,4L,1L,7L,1L,7L,5L,2L,1L,8L,5L,6L,7L,7L,0L,9L,1L,3L,0L,5L,7L,3L,6L,2L,3L,9L,1L,3L,2L,3L,6L,7L,1L,3L,0L,7L,5L,0L,5L,4L,7L,0L,8L,0L,0L,2L,6L,3L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016634Inst : IEnumerable<long>
{
public static readonly long[] Value=A016634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016634.Bytes);
public long this[int i]=>Value[i];

public static A016634Inst Instance=new A016634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016635
{
public static readonly long[] Value={ 2L,4L,8L,4L,9L,0L,6L,6L,4L,9L,7L,8L,8L,0L,0L,0L,3L,1L,0L,2L,2L,9L,7L,0L,9L,4L,7L,9L,8L,3L,8L,8L,7L,8L,8L,4L,0L,7L,9L,8L,4L,9L,0L,8L,2L,6L,5L,4L,3L,2L,5L,9L,9L,5L,9L,9L,7L,6L,0L,5L,4L,3L,5L,2L,6L,2L,4L,2L,8L,1L,5L,3L,7L,1L,5L,7L,9L,9L,8L,3L,9L,8L,0L,8L,5L,3L,4L,2L,4L,0L,8L,8L,0L,6L,5L,6L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016635Inst : IEnumerable<long>
{
public static readonly long[] Value=A016635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016635.Bytes);
public long this[int i]=>Value[i];

public static A016635Inst Instance=new A016635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016636
{
public static readonly long[] Value={ 2L,5L,6L,4L,9L,4L,9L,3L,5L,7L,4L,6L,1L,5L,3L,6L,7L,3L,6L,0L,5L,3L,4L,8L,7L,4L,4L,1L,5L,6L,5L,3L,1L,8L,6L,0L,4L,8L,0L,5L,2L,6L,7L,9L,4L,4L,7L,6L,0L,2L,0L,7L,1L,1L,6L,4L,1L,9L,0L,4L,5L,5L,1L,0L,6L,6L,3L,4L,6L,4L,6L,6L,7L,3L,2L,4L,4L,1L,0L,1L,7L,9L,3L,9L,9L,5L,7L,4L,6L,6L,3L,4L,4L,0L,4L,8L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016636Inst : IEnumerable<long>
{
public static readonly long[] Value=A016636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016636.Bytes);
public long this[int i]=>Value[i];

public static A016636Inst Instance=new A016636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016637
{
public static readonly long[] Value={ 2L,6L,3L,9L,0L,5L,7L,3L,2L,9L,6L,1L,5L,2L,5L,8L,6L,1L,4L,5L,2L,2L,5L,8L,4L,8L,6L,4L,9L,0L,1L,3L,5L,6L,2L,9L,7L,7L,1L,2L,5L,8L,4L,8L,6L,3L,9L,4L,2L,1L,1L,6L,4L,4L,2L,5L,8L,0L,0L,7L,0L,1L,5L,9L,4L,3L,0L,9L,7L,3L,4L,8L,4L,7L,2L,1L,7L,6L,3L,9L,8L,3L,3L,9L,3L,5L,2L,1L,8L,2L,5L,5L,8L,4L,2L,9L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016637Inst : IEnumerable<long>
{
public static readonly long[] Value=A016637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016637.Bytes);
public long this[int i]=>Value[i];

public static A016637Inst Instance=new A016637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016654
{
public static readonly long[] Value={ 3L,4L,3L,3L,9L,8L,7L,2L,0L,4L,4L,8L,5L,1L,4L,6L,2L,4L,5L,9L,2L,9L,1L,6L,4L,3L,2L,4L,5L,4L,2L,3L,5L,7L,2L,1L,0L,4L,4L,9L,9L,3L,8L,9L,3L,0L,4L,8L,0L,5L,9L,1L,9L,7L,1L,7L,5L,6L,7L,1L,8L,0L,7L,2L,4L,7L,4L,9L,8L,1L,4L,1L,6L,5L,9L,7L,5L,5L,1L,2L,3L,2L,2L,1L,3L,8L,6L,4L,8L,3L,1L,3L,3L,6L,0L,8L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016654Inst : IEnumerable<long>
{
public static readonly long[] Value=A016654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016654.Bytes);
public long this[int i]=>Value[i];

public static A016654Inst Instance=new A016654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016655
{
public static readonly long[] Value={ 3L,4L,6L,5L,7L,3L,5L,9L,0L,2L,7L,9L,9L,7L,2L,6L,5L,4L,7L,0L,8L,6L,1L,6L,0L,6L,0L,7L,2L,9L,0L,8L,8L,2L,8L,4L,0L,3L,7L,7L,5L,0L,0L,6L,7L,1L,8L,0L,1L,2L,7L,6L,2L,7L,0L,6L,0L,3L,4L,0L,0L,0L,4L,7L,4L,6L,6L,9L,6L,8L,1L,0L,9L,8L,4L,8L,4L,7L,3L,5L,7L,8L,0L,2L,9L,3L,1L,6L,6L,3L,4L,9L,8L,2L,0L,9L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016655Inst : IEnumerable<long>
{
public static readonly long[] Value=A016655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016655.Bytes);
public long this[int i]=>Value[i];

public static A016655Inst Instance=new A016655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016656
{
public static readonly long[] Value={ 3L,4L,9L,6L,5L,0L,7L,5L,6L,1L,4L,6L,6L,4L,8L,0L,2L,3L,5L,4L,5L,7L,1L,8L,8L,8L,1L,4L,8L,8L,7L,6L,5L,5L,0L,0L,4L,4L,6L,9L,1L,9L,7L,4L,1L,1L,7L,6L,0L,1L,6L,6L,6L,2L,6L,9L,5L,3L,2L,6L,2L,0L,4L,2L,7L,6L,8L,0L,6L,7L,9L,1L,7L,1L,3L,1L,8L,4L,5L,6L,7L,9L,9L,4L,8L,6L,7L,0L,4L,6L,2L,8L,1L,6L,3L,6L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016656Inst : IEnumerable<long>
{
public static readonly long[] Value=A016656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016656.Bytes);
public long this[int i]=>Value[i];

public static A016656Inst Instance=new A016656Inst();

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