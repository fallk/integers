using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011485
{
public static readonly long[] Value={ 1L,0L,6L,5L,5L,3L,7L,7L,6L,7L,0L,4L,7L,1L,3L,5L,3L,5L,4L,3L,0L,6L,6L,6L,0L,1L,5L,3L,3L,2L,9L,6L,5L,8L,3L,7L,2L,5L,0L,5L,4L,0L,9L,5L,0L,6L,0L,1L,6L,6L,3L,8L,7L,6L,1L,4L,9L,8L,7L,1L,1L,8L,4L,6L,6L,7L,1L,8L,4L,2L,7L,5L,4L,5L,5L,7L,4L,8L,5L,8L,2L,2L,0L,8L,7L,7L,8L,5L,4L,2L,0L,2L,6L,7L,4L,5L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011485Inst : IEnumerable<long>
{
public static readonly long[] Value=A011485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011485.Bytes);
public long this[int i]=>Value[i];

public static A011485Inst Instance=new A011485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011484
{
public static readonly long[] Value={ 1L,0L,6L,6L,3L,2L,8L,3L,9L,6L,5L,5L,6L,7L,9L,7L,9L,9L,0L,6L,4L,3L,2L,1L,3L,1L,9L,3L,0L,4L,5L,8L,4L,1L,2L,4L,2L,9L,6L,4L,1L,3L,7L,6L,7L,8L,6L,1L,5L,6L,4L,9L,3L,3L,2L,5L,4L,3L,1L,2L,2L,6L,0L,2L,4L,5L,9L,9L,5L,8L,4L,0L,6L,6L,3L,0L,3L,0L,3L,3L,8L,2L,5L,1L,6L,6L,2L,4L,7L,7L,3L,4L,1L,9L,4L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011484Inst : IEnumerable<long>
{
public static readonly long[] Value=A011484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011484.Bytes);
public long this[int i]=>Value[i];

public static A011484Inst Instance=new A011484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011483
{
public static readonly long[] Value={ 1L,0L,6L,7L,1L,4L,0L,4L,0L,0L,6L,7L,6L,8L,2L,3L,6L,1L,8L,1L,6L,9L,5L,2L,1L,1L,2L,0L,9L,9L,2L,8L,0L,9L,1L,6L,2L,6L,0L,6L,8L,9L,2L,2L,1L,2L,5L,7L,4L,0L,0L,4L,6L,3L,0L,6L,8L,9L,9L,4L,2L,2L,9L,3L,5L,1L,8L,6L,0L,8L,8L,6L,2L,3L,6L,9L,8L,9L,2L,2L,6L,3L,3L,8L,1L,4L,7L,5L,7L,1L,5L,9L,5L,3L,7L,3L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011483Inst : IEnumerable<long>
{
public static readonly long[] Value=A011483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011483.Bytes);
public long this[int i]=>Value[i];

public static A011483Inst Instance=new A011483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011482
{
public static readonly long[] Value={ 1L,0L,6L,7L,9L,7L,4L,6L,9L,1L,6L,2L,4L,1L,1L,1L,3L,7L,1L,2L,0L,7L,2L,5L,3L,5L,2L,9L,5L,6L,5L,2L,5L,0L,9L,5L,2L,5L,8L,3L,0L,9L,3L,6L,3L,5L,7L,8L,3L,6L,6L,6L,9L,4L,1L,0L,4L,6L,1L,7L,8L,2L,9L,2L,7L,7L,1L,8L,0L,5L,3L,9L,9L,7L,3L,4L,6L,7L,0L,7L,5L,7L,9L,9L,7L,3L,9L,7L,0L,1L,1L,7L,5L,3L,0L,9L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011482Inst : IEnumerable<long>
{
public static readonly long[] Value=A011482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011482.Bytes);
public long this[int i]=>Value[i];

public static A011482Inst Instance=new A011482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011481
{
public static readonly long[] Value={ 1L,0L,6L,8L,8L,3L,2L,2L,3L,5L,3L,1L,1L,8L,8L,9L,2L,7L,9L,0L,9L,3L,5L,6L,6L,9L,9L,5L,9L,5L,2L,1L,1L,8L,9L,4L,3L,4L,6L,1L,5L,1L,0L,7L,8L,9L,2L,5L,1L,6L,0L,2L,2L,4L,1L,4L,1L,9L,2L,2L,4L,7L,9L,4L,2L,5L,8L,3L,7L,3L,0L,8L,7L,0L,8L,5L,9L,9L,0L,8L,7L,8L,4L,3L,8L,2L,3L,8L,5L,0L,5L,7L,9L,3L,5L,1L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011481Inst : IEnumerable<long>
{
public static readonly long[] Value=A011481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011481.Bytes);
public long this[int i]=>Value[i];

public static A011481Inst Instance=new A011481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011480
{
public static readonly long[] Value={ 1L,0L,6L,9L,7L,1L,4L,0L,5L,5L,4L,0L,7L,5L,3L,7L,2L,4L,6L,3L,8L,9L,9L,3L,4L,6L,7L,7L,1L,1L,2L,4L,8L,9L,4L,0L,6L,3L,3L,5L,5L,3L,3L,9L,6L,8L,9L,0L,3L,5L,0L,2L,8L,7L,3L,1L,2L,9L,0L,2L,9L,0L,5L,0L,4L,6L,0L,1L,6L,9L,8L,2L,9L,9L,7L,5L,0L,6L,7L,5L,4L,5L,6L,1L,3L,6L,2L,2L,3L,5L,7L,9L,4L,9L,9L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011480Inst : IEnumerable<long>
{
public static readonly long[] Value=A011480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011480.Bytes);
public long this[int i]=>Value[i];

public static A011480Inst Instance=new A011480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011479
{
public static readonly long[] Value={ 1L,0L,7L,0L,6L,2L,1L,2L,3L,7L,7L,6L,6L,9L,6L,6L,1L,9L,9L,6L,3L,8L,3L,4L,5L,5L,1L,3L,1L,4L,4L,0L,3L,4L,1L,8L,3L,4L,6L,3L,3L,0L,0L,8L,3L,7L,4L,7L,9L,1L,7L,5L,7L,9L,3L,5L,0L,5L,1L,1L,7L,3L,5L,1L,5L,0L,4L,4L,2L,8L,3L,8L,1L,8L,5L,1L,1L,3L,3L,1L,4L,1L,6L,1L,2L,0L,7L,7L,9L,9L,0L,9L,6L,8L,8L,9L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011479Inst : IEnumerable<long>
{
public static readonly long[] Value=A011479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011479.Bytes);
public long this[int i]=>Value[i];

public static A011479Inst Instance=new A011479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011478
{
public static readonly long[] Value={ 1L,0L,7L,1L,5L,5L,4L,9L,3L,5L,2L,8L,7L,1L,8L,4L,0L,6L,1L,6L,9L,2L,7L,6L,1L,9L,4L,5L,9L,6L,5L,2L,6L,5L,1L,8L,9L,0L,9L,4L,5L,2L,0L,2L,9L,8L,7L,9L,0L,3L,8L,5L,6L,4L,0L,9L,9L,8L,0L,5L,9L,2L,5L,1L,0L,9L,6L,4L,8L,1L,7L,2L,0L,9L,7L,8L,0L,7L,5L,5L,7L,3L,1L,8L,2L,1L,4L,5L,6L,9L,8L,0L,2L,8L,8L,6L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011478Inst : IEnumerable<long>
{
public static readonly long[] Value=A011478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011478.Bytes);
public long this[int i]=>Value[i];

public static A011478Inst Instance=new A011478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011477
{
public static readonly long[] Value={ 1L,0L,7L,2L,5L,1L,6L,3L,7L,3L,2L,2L,4L,0L,4L,3L,7L,0L,0L,5L,0L,2L,6L,0L,7L,6L,0L,4L,2L,9L,4L,2L,1L,8L,4L,4L,7L,3L,4L,4L,0L,6L,0L,6L,5L,5L,4L,5L,7L,2L,8L,3L,8L,9L,2L,3L,0L,8L,1L,9L,9L,6L,4L,1L,5L,5L,7L,2L,8L,1L,2L,2L,2L,8L,5L,0L,8L,7L,5L,4L,8L,0L,5L,8L,4L,1L,5L,6L,0L,5L,3L,9L,2L,2L,1L,3L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011477Inst : IEnumerable<long>
{
public static readonly long[] Value=A011477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011477.Bytes);
public long this[int i]=>Value[i];

public static A011477Inst Instance=new A011477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011476
{
public static readonly long[] Value={ 1L,0L,7L,3L,5L,0L,6L,8L,5L,5L,0L,2L,8L,3L,2L,4L,9L,2L,6L,8L,5L,7L,6L,5L,5L,3L,2L,2L,4L,1L,8L,9L,9L,2L,5L,1L,9L,0L,9L,5L,8L,8L,3L,7L,9L,0L,4L,1L,2L,9L,7L,5L,4L,3L,3L,1L,4L,3L,0L,7L,0L,3L,0L,2L,3L,3L,0L,5L,3L,8L,0L,9L,9L,3L,2L,4L,7L,7L,6L,4L,3L,5L,1L,0L,9L,4L,9L,1L,5L,5L,8L,1L,0L,2L,8L,0L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011476Inst : IEnumerable<long>
{
public static readonly long[] Value=A011476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011476.Bytes);
public long this[int i]=>Value[i];

public static A011476Inst Instance=new A011476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011475
{
public static readonly long[] Value={ 1L,0L,7L,4L,5L,2L,7L,7L,6L,8L,7L,6L,0L,3L,8L,4L,4L,4L,4L,5L,0L,4L,6L,3L,4L,4L,4L,4L,1L,0L,2L,0L,4L,6L,5L,0L,8L,2L,3L,7L,8L,1L,8L,2L,7L,3L,7L,2L,0L,2L,4L,1L,8L,0L,9L,5L,1L,1L,1L,9L,5L,6L,3L,5L,1L,2L,3L,6L,9L,9L,7L,8L,2L,6L,2L,9L,7L,1L,3L,8L,2L,8L,2L,5L,0L,1L,7L,6L,1L,4L,1L,7L,1L,2L,5L,6L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011475Inst : IEnumerable<long>
{
public static readonly long[] Value=A011475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011475.Bytes);
public long this[int i]=>Value[i];

public static A011475Inst Instance=new A011475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011474
{
public static readonly long[] Value={ 1L,0L,7L,5L,5L,8L,0L,5L,9L,4L,1L,5L,1L,7L,7L,1L,6L,3L,8L,5L,5L,6L,9L,7L,4L,1L,1L,1L,7L,6L,6L,0L,1L,0L,2L,3L,9L,4L,5L,3L,2L,7L,5L,0L,3L,3L,8L,1L,4L,7L,0L,0L,3L,9L,4L,4L,2L,8L,3L,3L,9L,9L,0L,5L,8L,8L,4L,4L,3L,4L,6L,4L,9L,5L,2L,3L,2L,9L,4L,0L,8L,1L,2L,6L,6L,7L,8L,4L,7L,3L,8L,6L,6L,9L,5L,7L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011474Inst : IEnumerable<long>
{
public static readonly long[] Value=A011474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011474.Bytes);
public long this[int i]=>Value[i];

public static A011474Inst Instance=new A011474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011473
{
public static readonly long[] Value={ 1L,0L,7L,6L,6L,6L,6L,9L,1L,0L,3L,9L,1L,6L,4L,1L,4L,2L,1L,1L,4L,3L,2L,7L,6L,7L,5L,5L,1L,4L,0L,1L,1L,1L,8L,6L,6L,3L,2L,0L,1L,1L,9L,0L,8L,7L,5L,1L,5L,3L,7L,5L,9L,6L,2L,4L,3L,1L,6L,2L,2L,1L,8L,7L,3L,7L,3L,5L,7L,9L,8L,7L,6L,3L,9L,8L,2L,5L,2L,4L,3L,3L,7L,5L,5L,7L,2L,3L,2L,1L,9L,7L,0L,8L,1L,3L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011473Inst : IEnumerable<long>
{
public static readonly long[] Value=A011473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011473.Bytes);
public long this[int i]=>Value[i];

public static A011473Inst Instance=new A011473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011472
{
public static readonly long[] Value={ 1L,0L,7L,7L,7L,8L,8L,4L,0L,4L,7L,2L,6L,7L,2L,1L,5L,0L,9L,7L,4L,4L,3L,2L,3L,3L,7L,7L,4L,3L,0L,4L,8L,1L,8L,4L,8L,5L,0L,1L,7L,7L,5L,0L,1L,0L,8L,6L,3L,8L,1L,2L,8L,8L,3L,4L,6L,5L,1L,1L,0L,9L,7L,9L,4L,9L,6L,5L,9L,6L,8L,3L,6L,4L,2L,9L,4L,9L,4L,8L,2L,8L,8L,8L,7L,2L,7L,4L,6L,2L,0L,5L,1L,3L,8L,3L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011472Inst : IEnumerable<long>
{
public static readonly long[] Value=A011472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011472.Bytes);
public long this[int i]=>Value[i];

public static A011472Inst Instance=new A011472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011471
{
public static readonly long[] Value={ 1L,0L,7L,8L,9L,4L,6L,8L,8L,1L,9L,7L,6L,2L,7L,8L,0L,4L,9L,9L,2L,6L,3L,1L,4L,6L,1L,3L,2L,2L,6L,4L,3L,6L,8L,1L,4L,4L,4L,9L,6L,9L,0L,9L,3L,9L,1L,5L,7L,7L,0L,8L,9L,7L,6L,4L,5L,4L,7L,3L,2L,8L,5L,9L,2L,0L,7L,8L,0L,4L,1L,2L,0L,5L,5L,0L,0L,5L,2L,8L,8L,5L,8L,6L,1L,9L,4L,2L,6L,3L,3L,8L,4L,4L,6L,8L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011471Inst : IEnumerable<long>
{
public static readonly long[] Value=A011471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011471.Bytes);
public long this[int i]=>Value[i];

public static A011471Inst Instance=new A011471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011470
{
public static readonly long[] Value={ 1L,0L,8L,0L,1L,4L,4L,2L,7L,5L,0L,7L,8L,2L,9L,1L,7L,0L,9L,5L,6L,5L,2L,7L,5L,0L,3L,6L,1L,3L,9L,4L,9L,1L,2L,2L,3L,6L,3L,3L,1L,5L,7L,1L,0L,4L,9L,1L,3L,8L,0L,9L,4L,9L,9L,6L,7L,1L,9L,4L,5L,2L,0L,4L,9L,7L,5L,1L,6L,2L,7L,1L,6L,1L,5L,2L,4L,3L,1L,7L,3L,3L,3L,4L,9L,0L,6L,8L,4L,8L,0L,6L,6L,5L,0L,0L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011470Inst : IEnumerable<long>
{
public static readonly long[] Value=A011470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011470.Bytes);
public long this[int i]=>Value[i];

public static A011470Inst Instance=new A011470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011453
{
public static readonly long[] Value={ 1L,1L,0L,9L,2L,8L,5L,9L,1L,2L,2L,6L,3L,0L,4L,3L,0L,8L,2L,2L,2L,3L,9L,5L,8L,3L,0L,3L,3L,6L,1L,6L,8L,7L,7L,6L,1L,3L,9L,1L,4L,4L,5L,7L,4L,4L,1L,9L,5L,3L,0L,9L,4L,7L,7L,1L,8L,7L,2L,5L,4L,1L,4L,1L,3L,6L,7L,9L,4L,4L,7L,9L,8L,6L,3L,9L,6L,9L,6L,3L,9L,5L,9L,2L,2L,5L,9L,6L,4L,1L,6L,5L,2L,8L,2L,1L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011453Inst : IEnumerable<long>
{
public static readonly long[] Value=A011453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011453.Bytes);
public long this[int i]=>Value[i];

public static A011453Inst Instance=new A011453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011452
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,7L,1L,5L,9L,5L,0L,4L,3L,2L,0L,8L,7L,4L,5L,6L,1L,0L,5L,4L,8L,4L,1L,5L,8L,1L,9L,6L,0L,2L,6L,2L,7L,8L,9L,1L,8L,0L,2L,1L,3L,6L,2L,8L,1L,9L,6L,7L,1L,4L,2L,5L,6L,4L,6L,8L,2L,2L,6L,0L,6L,8L,5L,1L,3L,7L,7L,8L,6L,2L,1L,2L,7L,6L,7L,1L,6L,7L,1L,0L,4L,3L,5L,3L,6L,6L,5L,7L,0L,6L,3L,3L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011452Inst : IEnumerable<long>
{
public static readonly long[] Value=A011452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011452.Bytes);
public long this[int i]=>Value[i];

public static A011452Inst Instance=new A011452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011451
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,8L,6L,7L,4L,2L,5L,9L,5L,8L,9L,2L,5L,3L,6L,3L,0L,8L,8L,1L,2L,9L,5L,6L,9L,1L,9L,6L,0L,3L,0L,6L,7L,8L,0L,0L,4L,5L,7L,3L,3L,5L,4L,8L,4L,3L,6L,8L,8L,3L,8L,5L,0L,9L,4L,4L,1L,0L,7L,0L,2L,2L,6L,2L,6L,0L,5L,6L,3L,9L,3L,9L,7L,5L,5L,7L,7L,4L,4L,5L,7L,6L,0L,2L,3L,2L,8L,4L,6L,7L,9L,0L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011451Inst : IEnumerable<long>
{
public static readonly long[] Value=A011451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011451.Bytes);
public long this[int i]=>Value[i];

public static A011451Inst Instance=new A011451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011450
{
public static readonly long[] Value={ 1L,1L,1L,7L,1L,4L,2L,1L,5L,9L,2L,5L,0L,4L,5L,6L,2L,0L,4L,6L,4L,5L,5L,7L,1L,8L,0L,8L,6L,1L,8L,9L,5L,5L,8L,0L,8L,5L,9L,0L,8L,9L,3L,8L,9L,0L,2L,1L,5L,8L,0L,3L,8L,8L,6L,1L,2L,1L,2L,4L,5L,5L,8L,1L,1L,6L,5L,6L,1L,7L,1L,2L,0L,5L,2L,5L,1L,3L,7L,5L,6L,2L,2L,0L,5L,3L,8L,9L,0L,3L,4L,1L,5L,9L,6L,6L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011450Inst : IEnumerable<long>
{
public static readonly long[] Value=A011450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011450.Bytes);
public long this[int i]=>Value[i];

public static A011450Inst Instance=new A011450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011449
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,4L,9L,9L,0L,9L,1L,5L,0L,1L,9L,6L,5L,2L,8L,8L,5L,6L,3L,8L,1L,8L,3L,0L,6L,0L,6L,6L,9L,3L,1L,8L,1L,9L,8L,8L,3L,4L,3L,3L,0L,4L,7L,4L,6L,8L,9L,2L,6L,2L,2L,0L,2L,5L,5L,5L,9L,7L,8L,8L,0L,1L,9L,9L,1L,3L,9L,1L,3L,0L,2L,9L,1L,2L,3L,1L,8L,1L,5L,4L,3L,3L,0L,2L,0L,1L,8L,4L,6L,0L,4L,9L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011449Inst : IEnumerable<long>
{
public static readonly long[] Value=A011449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011449.Bytes);
public long this[int i]=>Value[i];

public static A011449Inst Instance=new A011449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011448
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,5L,0L,7L,0L,9L,1L,7L,9L,4L,0L,8L,9L,0L,0L,2L,7L,8L,4L,4L,6L,5L,5L,6L,6L,8L,7L,1L,7L,8L,8L,8L,3L,9L,2L,5L,3L,8L,8L,3L,3L,7L,0L,4L,1L,7L,0L,7L,8L,2L,9L,3L,3L,9L,5L,4L,2L,7L,6L,4L,1L,5L,7L,4L,8L,4L,9L,3L,9L,1L,1L,7L,9L,0L,2L,9L,4L,7L,1L,9L,4L,1L,0L,1L,9L,0L,5L,6L,4L,3L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011448Inst : IEnumerable<long>
{
public static readonly long[] Value=A011448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011448.Bytes);
public long this[int i]=>Value[i];

public static A011448Inst Instance=new A011448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011447
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,7L,8L,1L,4L,5L,2L,5L,0L,8L,7L,3L,6L,7L,4L,9L,8L,3L,1L,7L,0L,3L,6L,0L,7L,0L,0L,6L,8L,7L,5L,0L,3L,9L,7L,3L,0L,0L,9L,9L,5L,6L,9L,7L,9L,0L,2L,8L,2L,9L,4L,7L,0L,2L,9L,9L,5L,3L,3L,2L,3L,5L,5L,0L,6L,8L,2L,4L,3L,9L,0L,2L,1L,1L,5L,5L,2L,1L,0L,7L,7L,4L,4L,5L,5L,3L,9L,3L,7L,5L,8L,3L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011447Inst : IEnumerable<long>
{
public static readonly long[] Value=A011447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011447.Bytes);
public long this[int i]=>Value[i];

public static A011447Inst Instance=new A011447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011446
{
public static readonly long[] Value={ 1L,1L,2L,9L,8L,3L,0L,9L,6L,3L,9L,0L,9L,7L,5L,3L,0L,3L,2L,6L,1L,2L,1L,6L,6L,1L,0L,4L,2L,8L,2L,8L,4L,1L,8L,7L,4L,4L,8L,4L,0L,0L,3L,8L,9L,3L,8L,3L,6L,8L,4L,9L,6L,2L,9L,8L,9L,3L,1L,5L,1L,2L,0L,1L,5L,4L,1L,1L,0L,6L,0L,3L,3L,6L,8L,1L,2L,0L,0L,7L,9L,5L,4L,7L,2L,3L,7L,2L,0L,0L,0L,2L,6L,5L,8L,5L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011446Inst : IEnumerable<long>
{
public static readonly long[] Value=A011446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011446.Bytes);
public long this[int i]=>Value[i];

public static A011446Inst Instance=new A011446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011445
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,0L,1L,3L,7L,6L,4L,5L,8L,7L,0L,7L,7L,5L,3L,4L,2L,0L,5L,7L,3L,3L,5L,0L,4L,8L,1L,1L,7L,0L,4L,5L,9L,2L,1L,7L,7L,3L,2L,0L,2L,3L,2L,4L,9L,0L,9L,4L,8L,7L,4L,0L,2L,4L,2L,2L,8L,7L,4L,0L,7L,9L,9L,7L,0L,2L,9L,2L,4L,1L,8L,2L,8L,7L,3L,7L,8L,9L,6L,9L,5L,8L,6L,9L,0L,6L,2L,9L,5L,7L,0L,5L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011445Inst : IEnumerable<long>
{
public static readonly long[] Value=A011445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011445.Bytes);
public long this[int i]=>Value[i];

public static A011445Inst Instance=new A011445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011444
{
public static readonly long[] Value={ 1L,1L,3L,7L,4L,1L,1L,4L,6L,1L,7L,5L,6L,0L,2L,8L,7L,1L,7L,7L,9L,9L,3L,6L,3L,3L,6L,0L,5L,8L,9L,5L,7L,6L,4L,6L,6L,5L,6L,0L,8L,6L,4L,4L,4L,8L,3L,3L,1L,8L,7L,9L,4L,5L,4L,9L,1L,2L,0L,9L,7L,0L,5L,5L,4L,1L,1L,1L,6L,5L,0L,2L,0L,7L,5L,3L,2L,6L,8L,2L,7L,5L,0L,4L,1L,4L,1L,8L,6L,8L,6L,5L,6L,8L,7L,8L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011444Inst : IEnumerable<long>
{
public static readonly long[] Value=A011444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011444.Bytes);
public long this[int i]=>Value[i];

public static A011444Inst Instance=new A011444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011443
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,8L,6L,4L,4L,0L,6L,3L,2L,1L,6L,3L,4L,2L,4L,4L,6L,0L,8L,2L,9L,3L,6L,5L,1L,9L,7L,2L,7L,7L,6L,7L,6L,1L,6L,0L,8L,5L,1L,6L,8L,3L,2L,0L,5L,5L,4L,1L,4L,6L,9L,1L,1L,6L,8L,3L,1L,0L,3L,8L,7L,0L,5L,8L,0L,3L,7L,6L,1L,6L,5L,9L,9L,5L,3L,2L,5L,8L,9L,1L,2L,4L,8L,4L,3L,4L,4L,6L,5L,0L,9L,6L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011443Inst : IEnumerable<long>
{
public static readonly long[] Value=A011443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011443.Bytes);
public long this[int i]=>Value[i];

public static A011443Inst Instance=new A011443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011442
{
public static readonly long[] Value={ 1L,1L,4L,6L,0L,5L,5L,2L,5L,8L,2L,2L,3L,4L,8L,4L,1L,8L,0L,3L,3L,1L,4L,3L,6L,9L,4L,4L,4L,7L,8L,2L,5L,9L,8L,1L,8L,2L,9L,2L,4L,0L,1L,7L,2L,5L,1L,9L,4L,5L,7L,4L,8L,4L,6L,3L,4L,7L,4L,1L,9L,7L,2L,5L,1L,2L,9L,6L,9L,0L,2L,0L,0L,0L,1L,1L,7L,2L,1L,3L,4L,0L,5L,8L,7L,0L,6L,6L,2L,7L,7L,7L,7L,6L,3L,4L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011442Inst : IEnumerable<long>
{
public static readonly long[] Value=A011442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011442.Bytes);
public long this[int i]=>Value[i];

public static A011442Inst Instance=new A011442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011441
{
public static readonly long[] Value={ 1L,1L,5L,0L,8L,5L,1L,3L,0L,0L,3L,5L,8L,2L,7L,8L,7L,8L,5L,4L,2L,4L,5L,5L,9L,7L,9L,6L,2L,3L,7L,4L,7L,8L,8L,8L,8L,9L,1L,4L,3L,3L,3L,4L,5L,6L,0L,4L,8L,1L,7L,5L,8L,8L,7L,1L,2L,7L,2L,3L,2L,8L,2L,3L,9L,9L,6L,8L,7L,8L,6L,5L,4L,2L,7L,8L,5L,3L,8L,7L,1L,5L,6L,2L,4L,3L,2L,2L,6L,4L,3L,6L,1L,9L,5L,3L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011441Inst : IEnumerable<long>
{
public static readonly long[] Value=A011441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011441.Bytes);
public long this[int i]=>Value[i];

public static A011441Inst Instance=new A011441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011440
{
public static readonly long[] Value={ 1L,1L,5L,6L,0L,1L,3L,2L,8L,1L,0L,0L,0L,8L,0L,3L,2L,7L,2L,6L,9L,5L,3L,9L,7L,0L,8L,0L,8L,9L,5L,1L,0L,7L,1L,3L,2L,1L,4L,1L,3L,1L,3L,6L,5L,6L,8L,7L,6L,6L,7L,6L,8L,5L,4L,9L,4L,1L,8L,1L,6L,1L,7L,9L,4L,0L,0L,7L,6L,3L,0L,6L,7L,6L,6L,0L,9L,0L,8L,9L,5L,6L,1L,0L,4L,5L,3L,4L,4L,6L,1L,1L,1L,9L,8L,7L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011440Inst : IEnumerable<long>
{
public static readonly long[] Value=A011440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011440.Bytes);
public long this[int i]=>Value[i];

public static A011440Inst Instance=new A011440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011439
{
public static readonly long[] Value={ 1L,1L,6L,1L,5L,8L,6L,3L,4L,9L,6L,4L,1L,5L,4L,2L,2L,8L,1L,8L,0L,8L,7L,2L,1L,2L,2L,4L,2L,4L,5L,6L,7L,6L,8L,4L,3L,4L,5L,5L,4L,3L,6L,6L,3L,8L,1L,9L,0L,7L,2L,9L,7L,7L,5L,8L,4L,4L,4L,6L,6L,4L,2L,8L,4L,1L,5L,5L,2L,0L,2L,3L,3L,3L,0L,0L,2L,0L,2L,2L,8L,6L,6L,0L,6L,2L,0L,2L,4L,2L,3L,9L,4L,2L,8L,3L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011439Inst : IEnumerable<long>
{
public static readonly long[] Value=A011439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011439.Bytes);
public long this[int i]=>Value[i];

public static A011439Inst Instance=new A011439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011438
{
public static readonly long[] Value={ 1L,1L,7L,0L,7L,7L,9L,9L,1L,3L,7L,2L,2L,7L,7L,9L,3L,3L,3L,2L,5L,7L,6L,4L,0L,9L,4L,4L,8L,9L,8L,3L,4L,4L,0L,4L,7L,5L,6L,0L,0L,1L,7L,8L,9L,0L,3L,3L,2L,7L,8L,8L,4L,9L,6L,2L,5L,1L,4L,8L,3L,2L,9L,8L,3L,1L,2L,5L,2L,8L,6L,6L,3L,1L,1L,7L,5L,1L,2L,4L,0L,2L,8L,5L,1L,1L,8L,1L,3L,4L,9L,2L,8L,6L,7L,3L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011438Inst : IEnumerable<long>
{
public static readonly long[] Value=A011438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011438.Bytes);
public long this[int i]=>Value[i];

public static A011438Inst Instance=new A011438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011421
{
public static readonly long[] Value={ 1L,1L,8L,9L,1L,0L,6L,6L,2L,8L,5L,7L,4L,0L,7L,7L,0L,6L,4L,0L,0L,0L,5L,1L,3L,8L,0L,3L,1L,0L,7L,2L,2L,9L,1L,9L,0L,6L,3L,0L,6L,4L,6L,9L,4L,8L,3L,7L,3L,0L,8L,2L,2L,0L,2L,4L,1L,1L,1L,9L,7L,7L,7L,5L,8L,3L,6L,8L,6L,8L,9L,5L,6L,4L,0L,7L,1L,7L,4L,8L,1L,9L,9L,3L,5L,8L,9L,6L,8L,5L,5L,9L,8L,4L,5L,8L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011421Inst : IEnumerable<long>
{
public static readonly long[] Value=A011421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011421.Bytes);
public long this[int i]=>Value[i];

public static A011421Inst Instance=new A011421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011420
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,4L,8L,8L,0L,2L,2L,9L,2L,7L,1L,5L,7L,1L,3L,7L,0L,9L,2L,5L,2L,3L,8L,4L,7L,7L,7L,5L,2L,3L,4L,8L,0L,7L,1L,6L,3L,5L,6L,0L,1L,6L,3L,3L,0L,3L,6L,9L,7L,2L,8L,5L,3L,7L,2L,7L,2L,7L,4L,5L,9L,7L,5L,7L,1L,8L,5L,1L,6L,5L,4L,1L,1L,3L,1L,9L,8L,3L,9L,0L,8L,5L,2L,9L,6L,7L,2L,9L,5L,7L,4L,7L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011420Inst : IEnumerable<long>
{
public static readonly long[] Value=A011420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011420.Bytes);
public long this[int i]=>Value[i];

public static A011420Inst Instance=new A011420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011419
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,8L,6L,9L,6L,7L,7L,8L,1L,2L,2L,4L,7L,3L,7L,9L,3L,8L,0L,0L,2L,9L,8L,8L,5L,0L,8L,3L,5L,0L,9L,6L,0L,1L,3L,2L,8L,9L,6L,1L,6L,5L,6L,5L,1L,6L,9L,1L,4L,5L,2L,8L,0L,7L,3L,4L,3L,5L,8L,3L,6L,2L,8L,2L,2L,9L,8L,1L,8L,3L,4L,9L,5L,8L,8L,4L,5L,3L,8L,0L,3L,8L,4L,7L,2L,6L,5L,6L,9L,0L,1L,5L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011419Inst : IEnumerable<long>
{
public static readonly long[] Value=A011419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011419.Bytes);
public long this[int i]=>Value[i];

public static A011419Inst Instance=new A011419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011418
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,6L,9L,2L,8L,4L,2L,0L,5L,2L,0L,7L,5L,7L,7L,8L,5L,3L,0L,0L,2L,4L,7L,4L,3L,4L,0L,3L,6L,9L,7L,4L,5L,0L,0L,4L,1L,3L,1L,0L,1L,8L,4L,7L,7L,1L,6L,6L,0L,9L,4L,6L,7L,5L,7L,6L,2L,0L,4L,1L,8L,4L,4L,4L,7L,6L,1L,8L,4L,1L,9L,5L,0L,3L,2L,1L,2L,8L,5L,6L,8L,3L,6L,4L,3L,6L,2L,9L,8L,8L,4L,5L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011418Inst : IEnumerable<long>
{
public static readonly long[] Value=A011418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011418.Bytes);
public long this[int i]=>Value[i];

public static A011418Inst Instance=new A011418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011417
{
public static readonly long[] Value={ 1L,2L,5L,4L,1L,9L,6L,7L,2L,2L,7L,3L,3L,2L,0L,4L,6L,5L,8L,6L,6L,1L,0L,4L,4L,2L,3L,2L,7L,2L,4L,0L,1L,3L,1L,3L,4L,0L,2L,2L,3L,0L,9L,1L,0L,8L,6L,7L,5L,3L,9L,8L,1L,1L,5L,3L,3L,7L,1L,8L,1L,2L,3L,1L,1L,6L,9L,6L,3L,8L,0L,7L,4L,3L,4L,4L,5L,3L,0L,1L,3L,8L,3L,2L,9L,6L,7L,4L,0L,6L,0L,9L,2L,9L,7L,4L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011417Inst : IEnumerable<long>
{
public static readonly long[] Value=A011417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011417.Bytes);
public long this[int i]=>Value[i];

public static A011417Inst Instance=new A011417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011416
{
public static readonly long[] Value={ 1L,2L,7L,8L,0L,9L,4L,0L,1L,1L,8L,2L,7L,9L,6L,1L,9L,4L,6L,0L,0L,0L,8L,3L,6L,5L,5L,3L,3L,1L,5L,5L,1L,9L,4L,1L,0L,6L,0L,0L,9L,8L,0L,7L,2L,2L,0L,6L,2L,9L,4L,6L,4L,3L,2L,2L,3L,0L,5L,9L,6L,2L,4L,4L,6L,9L,0L,9L,6L,7L,1L,5L,1L,5L,3L,6L,2L,1L,5L,6L,1L,4L,0L,4L,4L,5L,6L,3L,0L,7L,8L,8L,7L,4L,0L,9L,1L,5L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011416Inst : IEnumerable<long>
{
public static readonly long[] Value=A011416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011416.Bytes);
public long this[int i]=>Value[i];

public static A011416Inst Instance=new A011416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011415
{
public static readonly long[] Value={ 1L,3L,0L,6L,9L,2L,3L,9L,8L,2L,1L,1L,2L,7L,0L,1L,1L,9L,1L,6L,5L,8L,6L,8L,3L,1L,1L,2L,8L,9L,8L,2L,5L,6L,7L,6L,1L,3L,3L,1L,8L,6L,7L,0L,9L,0L,8L,2L,9L,5L,2L,9L,0L,5L,5L,8L,0L,1L,6L,8L,5L,7L,1L,5L,1L,5L,8L,0L,4L,0L,3L,0L,9L,2L,5L,8L,9L,2L,5L,7L,3L,9L,7L,0L,9L,4L,5L,2L,5L,2L,3L,5L,7L,7L,7L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011415Inst : IEnumerable<long>
{
public static readonly long[] Value=A011415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011415.Bytes);
public long this[int i]=>Value[i];

public static A011415Inst Instance=new A011415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011414
{
public static readonly long[] Value={ 1L,3L,4L,2L,3L,7L,9L,6L,5L,0L,9L,6L,2L,1L,0L,4L,7L,9L,8L,0L,9L,3L,7L,8L,3L,7L,9L,3L,0L,0L,0L,2L,9L,2L,3L,4L,6L,6L,8L,9L,8L,7L,7L,9L,8L,5L,7L,6L,3L,7L,5L,5L,2L,5L,6L,5L,6L,9L,4L,0L,1L,6L,5L,4L,3L,1L,3L,0L,2L,7L,5L,7L,6L,8L,0L,0L,2L,5L,4L,4L,7L,6L,8L,1L,7L,5L,4L,4L,2L,6L,5L,5L,2L,5L,9L,4L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011414Inst : IEnumerable<long>
{
public static readonly long[] Value=A011414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011414.Bytes);
public long this[int i]=>Value[i];

public static A011414Inst Instance=new A011414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011413
{
public static readonly long[] Value={ 1L,3L,8L,7L,0L,2L,3L,2L,2L,5L,8L,4L,4L,2L,1L,9L,1L,9L,7L,7L,3L,5L,5L,1L,7L,5L,4L,3L,1L,8L,0L,5L,8L,0L,2L,6L,0L,6L,9L,7L,6L,2L,5L,6L,8L,2L,6L,3L,0L,5L,3L,6L,5L,2L,8L,7L,4L,9L,8L,5L,6L,9L,3L,9L,3L,2L,1L,8L,9L,0L,1L,5L,3L,2L,2L,6L,2L,6L,0L,9L,1L,1L,0L,3L,6L,1L,8L,3L,4L,6L,0L,6L,5L,3L,7L,1L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011413Inst : IEnumerable<long>
{
public static readonly long[] Value=A011413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011413.Bytes);
public long this[int i]=>Value[i];

public static A011413Inst Instance=new A011413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011412
{
public static readonly long[] Value={ 1L,4L,4L,4L,9L,2L,1L,3L,2L,3L,0L,9L,3L,3L,5L,2L,3L,5L,0L,0L,6L,7L,2L,4L,6L,0L,9L,9L,9L,2L,7L,2L,4L,7L,2L,7L,7L,5L,6L,1L,1L,7L,6L,9L,1L,1L,8L,4L,7L,6L,9L,0L,7L,6L,2L,2L,0L,7L,2L,0L,5L,2L,9L,8L,3L,9L,4L,9L,2L,6L,9L,7L,4L,7L,4L,0L,8L,7L,5L,2L,2L,2L,5L,2L,9L,1L,7L,9L,9L,2L,6L,3L,6L,6L,6L,9L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011412Inst : IEnumerable<long>
{
public static readonly long[] Value=A011412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011412.Bytes);
public long this[int i]=>Value[i];

public static A011412Inst Instance=new A011412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011411
{
public static readonly long[] Value={ 1L,5L,2L,2L,9L,2L,6L,9L,9L,8L,2L,1L,8L,7L,5L,3L,3L,9L,3L,3L,8L,6L,9L,6L,8L,1L,9L,1L,5L,2L,7L,1L,9L,2L,9L,9L,8L,6L,2L,1L,4L,1L,8L,2L,0L,4L,5L,7L,2L,2L,1L,8L,5L,7L,3L,4L,3L,8L,0L,6L,8L,0L,7L,9L,7L,7L,3L,2L,1L,4L,9L,4L,1L,3L,8L,6L,2L,1L,6L,1L,5L,6L,0L,1L,0L,2L,3L,9L,2L,5L,8L,1L,6L,1L,2L,0L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011411Inst : IEnumerable<long>
{
public static readonly long[] Value=A011411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011411.Bytes);
public long this[int i]=>Value[i];

public static A011411Inst Instance=new A011411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011410
{
public static readonly long[] Value={ 1L,6L,3L,3L,5L,2L,4L,3L,0L,3L,0L,7L,0L,4L,9L,4L,5L,3L,0L,7L,2L,4L,6L,7L,0L,1L,8L,3L,5L,9L,0L,3L,8L,7L,2L,8L,8L,7L,0L,8L,8L,2L,7L,8L,4L,9L,4L,1L,5L,5L,8L,6L,5L,6L,2L,9L,0L,9L,4L,7L,4L,8L,5L,0L,5L,6L,1L,9L,9L,2L,6L,1L,3L,4L,4L,9L,5L,5L,5L,0L,2L,9L,2L,1L,5L,9L,6L,6L,8L,7L,1L,0L,1L,6L,9L,9L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011410Inst : IEnumerable<long>
{
public static readonly long[] Value=A011410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011410.Bytes);
public long this[int i]=>Value[i];

public static A011410Inst Instance=new A011410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011409
{
public static readonly long[] Value={ 1L,1L,5L,5L,4L,8L,3L,1L,7L,2L,7L,6L,3L,8L,0L,6L,6L,0L,4L,4L,2L,5L,9L,7L,0L,0L,6L,1L,5L,2L,6L,1L,0L,6L,5L,0L,5L,6L,7L,4L,1L,0L,9L,6L,6L,5L,9L,9L,4L,7L,8L,5L,2L,2L,2L,6L,5L,4L,0L,0L,9L,6L,3L,6L,5L,6L,8L,0L,9L,2L,9L,5L,5L,0L,2L,9L,0L,2L,5L,6L,5L,9L,1L,5L,4L,4L,4L,5L,2L,9L,3L,1L,8L,2L,1L,8L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011409Inst : IEnumerable<long>
{
public static readonly long[] Value=A011409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011409.Bytes);
public long this[int i]=>Value[i];

public static A011409Inst Instance=new A011409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011408
{
public static readonly long[] Value={ 1L,1L,6L,4L,3L,0L,5L,5L,6L,6L,8L,8L,3L,3L,7L,0L,0L,1L,2L,7L,2L,5L,6L,1L,4L,1L,6L,0L,5L,0L,4L,8L,6L,1L,9L,6L,1L,4L,0L,3L,5L,6L,0L,0L,7L,1L,6L,5L,5L,8L,8L,1L,9L,1L,8L,1L,8L,9L,0L,5L,5L,1L,1L,8L,9L,8L,6L,7L,1L,7L,4L,7L,0L,8L,1L,1L,2L,9L,7L,7L,0L,4L,1L,7L,5L,6L,7L,2L,0L,5L,9L,2L,1L,2L,5L,2L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011408Inst : IEnumerable<long>
{
public static readonly long[] Value=A011408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011408.Bytes);
public long this[int i]=>Value[i];

public static A011408Inst Instance=new A011408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011407
{
public static readonly long[] Value={ 1L,1L,7L,4L,1L,8L,7L,2L,5L,3L,0L,9L,9L,6L,6L,1L,5L,2L,9L,5L,1L,2L,3L,3L,2L,3L,2L,5L,8L,9L,5L,5L,5L,8L,1L,6L,7L,5L,7L,0L,2L,4L,7L,9L,6L,7L,7L,1L,9L,9L,9L,3L,8L,9L,1L,2L,0L,8L,3L,6L,0L,8L,3L,9L,9L,5L,4L,7L,7L,5L,7L,0L,3L,0L,9L,4L,3L,4L,0L,5L,3L,9L,7L,1L,9L,4L,3L,3L,9L,8L,2L,7L,8L,1L,5L,8L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011407Inst : IEnumerable<long>
{
public static readonly long[] Value=A011407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011407.Bytes);
public long this[int i]=>Value[i];

public static A011407Inst Instance=new A011407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011406
{
public static readonly long[] Value={ 1L,1L,8L,5L,3L,3L,0L,7L,7L,1L,9L,8L,2L,4L,7L,8L,9L,5L,5L,7L,4L,3L,2L,6L,2L,2L,1L,4L,9L,4L,8L,3L,5L,5L,3L,4L,1L,5L,5L,7L,8L,0L,0L,6L,4L,6L,2L,9L,5L,5L,9L,9L,7L,0L,4L,9L,5L,6L,4L,6L,8L,8L,2L,7L,8L,2L,4L,4L,7L,4L,9L,0L,3L,4L,4L,8L,1L,7L,6L,4L,2L,8L,2L,3L,1L,3L,5L,1L,8L,5L,0L,3L,3L,6L,1L,3L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011406Inst : IEnumerable<long>
{
public static readonly long[] Value=A011406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011406.Bytes);
public long this[int i]=>Value[i];

public static A011406Inst Instance=new A011406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011341
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,7L,8L,8L,4L,7L,7L,9L,6L,1L,4L,4L,8L,3L,4L,5L,2L,2L,8L,9L,1L,2L,2L,6L,2L,3L,4L,9L,2L,7L,9L,8L,1L,2L,3L,0L,6L,9L,8L,3L,0L,4L,2L,1L,9L,4L,3L,9L,2L,9L,3L,0L,2L,2L,9L,3L,1L,6L,8L,4L,8L,0L,5L,2L,8L,7L,7L,4L,0L,1L,9L,5L,8L,6L,5L,9L,8L,7L,9L,4L,0L,0L,4L,1L,4L,0L,0L,9L,6L,4L,9L,2L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011341Inst : IEnumerable<long>
{
public static readonly long[] Value=A011341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011341.Bytes);
public long this[int i]=>Value[i];

public static A011341Inst Instance=new A011341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011340
{
public static readonly long[] Value={ 1L,2L,7L,1L,1L,4L,0L,2L,1L,2L,3L,5L,9L,7L,1L,3L,1L,3L,3L,9L,4L,3L,2L,5L,7L,9L,6L,5L,6L,1L,6L,7L,4L,4L,9L,4L,4L,5L,6L,8L,8L,4L,8L,9L,1L,1L,8L,5L,8L,4L,5L,4L,8L,6L,8L,9L,0L,2L,2L,0L,3L,0L,8L,5L,3L,9L,8L,1L,3L,3L,3L,7L,1L,6L,1L,3L,2L,8L,2L,9L,8L,2L,5L,8L,5L,0L,4L,6L,8L,0L,7L,4L,2L,2L,5L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011340Inst : IEnumerable<long>
{
public static readonly long[] Value=A011340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011340.Bytes);
public long this[int i]=>Value[i];

public static A011340Inst Instance=new A011340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011339
{
public static readonly long[] Value={ 1L,3L,0L,2L,0L,0L,5L,4L,5L,4L,3L,1L,7L,4L,6L,7L,7L,0L,4L,4L,9L,7L,2L,4L,9L,3L,0L,3L,0L,7L,7L,4L,2L,5L,6L,3L,0L,3L,2L,3L,0L,2L,8L,8L,9L,1L,5L,1L,1L,1L,9L,3L,5L,3L,9L,7L,6L,2L,7L,1L,8L,4L,8L,2L,7L,3L,7L,5L,7L,3L,7L,7L,5L,7L,0L,9L,8L,5L,0L,9L,9L,1L,4L,8L,8L,6L,7L,8L,7L,3L,5L,8L,9L,4L,7L,9L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011339Inst : IEnumerable<long>
{
public static readonly long[] Value=A011339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011339.Bytes);
public long this[int i]=>Value[i];

public static A011339Inst Instance=new A011339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011338
{
public static readonly long[] Value={ 1L,3L,4L,0L,7L,4L,9L,2L,4L,0L,1L,9L,5L,2L,8L,0L,6L,0L,3L,9L,1L,0L,7L,5L,9L,9L,3L,9L,5L,1L,0L,3L,5L,4L,3L,9L,1L,1L,9L,2L,4L,6L,1L,0L,6L,7L,5L,1L,7L,6L,0L,0L,3L,5L,1L,8L,3L,6L,0L,4L,8L,3L,1L,2L,9L,7L,9L,7L,7L,2L,3L,7L,5L,6L,2L,3L,9L,8L,7L,0L,4L,7L,0L,2L,1L,9L,9L,3L,4L,6L,5L,6L,8L,4L,1L,6L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011338Inst : IEnumerable<long>
{
public static readonly long[] Value=A011338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011338.Bytes);
public long this[int i]=>Value[i];

public static A011338Inst Instance=new A011338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011337
{
public static readonly long[] Value={ 1L,3L,9L,0L,8L,0L,4L,2L,3L,5L,0L,6L,2L,4L,5L,8L,1L,3L,7L,3L,6L,4L,6L,5L,9L,6L,6L,9L,8L,9L,5L,9L,2L,6L,5L,5L,0L,6L,0L,7L,6L,3L,6L,3L,9L,9L,7L,2L,0L,4L,1L,7L,2L,1L,0L,1L,8L,8L,3L,8L,7L,9L,4L,4L,2L,4L,6L,2L,8L,0L,1L,8L,8L,7L,7L,5L,8L,5L,9L,6L,1L,1L,2L,7L,0L,2L,1L,2L,0L,4L,5L,0L,4L,8L,6L,5L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011337Inst : IEnumerable<long>
{
public static readonly long[] Value=A011337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011337.Bytes);
public long this[int i]=>Value[i];

public static A011337Inst Instance=new A011337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011336
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,1L,6L,2L,4L,9L,5L,7L,6L,2L,8L,3L,5L,3L,0L,6L,9L,1L,3L,1L,1L,2L,7L,1L,1L,2L,2L,6L,0L,6L,9L,3L,4L,3L,0L,6L,9L,2L,6L,7L,6L,4L,4L,7L,1L,3L,5L,4L,2L,5L,2L,2L,1L,1L,1L,9L,4L,6L,6L,4L,4L,9L,3L,3L,7L,9L,2L,5L,1L,9L,7L,1L,8L,5L,5L,6L,5L,6L,5L,7L,0L,7L,8L,4L,6L,0L,1L,7L,6L,0L,1L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011336Inst : IEnumerable<long>
{
public static readonly long[] Value=A011336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011336.Bytes);
public long this[int i]=>Value[i];

public static A011336Inst Instance=new A011336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011335
{
public static readonly long[] Value={ 1L,5L,5L,2L,4L,6L,3L,2L,8L,9L,1L,5L,5L,4L,0L,8L,6L,5L,5L,5L,6L,1L,5L,2L,2L,2L,0L,7L,8L,7L,8L,7L,0L,5L,2L,8L,7L,6L,5L,8L,8L,6L,7L,8L,2L,7L,9L,0L,3L,5L,8L,9L,8L,8L,1L,1L,5L,8L,1L,8L,9L,9L,2L,8L,0L,4L,4L,5L,3L,6L,7L,8L,9L,4L,8L,6L,9L,3L,6L,5L,8L,1L,3L,7L,8L,8L,2L,2L,4L,6L,0L,5L,6L,5L,5L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011335Inst : IEnumerable<long>
{
public static readonly long[] Value=A011335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011335.Bytes);
public long this[int i]=>Value[i];

public static A011335Inst Instance=new A011335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011334
{
public static readonly long[] Value={ 1L,1L,3L,6L,8L,3L,4L,2L,9L,7L,8L,5L,5L,5L,9L,8L,5L,8L,4L,9L,9L,7L,1L,5L,2L,0L,7L,8L,4L,4L,7L,3L,4L,7L,4L,9L,8L,9L,3L,0L,3L,2L,8L,1L,9L,8L,8L,5L,0L,7L,1L,1L,4L,1L,7L,5L,6L,3L,1L,2L,4L,4L,0L,2L,6L,5L,4L,3L,7L,9L,7L,5L,8L,1L,5L,4L,9L,0L,8L,2L,4L,0L,6L,5L,1L,1L,1L,9L,8L,7L,6L,7L,3L,6L,7L,2L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011334Inst : IEnumerable<long>
{
public static readonly long[] Value=A011334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011334.Bytes);
public long this[int i]=>Value[i];

public static A011334Inst Instance=new A011334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011333
{
public static readonly long[] Value={ 1L,1L,4L,4L,5L,3L,3L,7L,3L,3L,7L,1L,0L,7L,4L,1L,9L,6L,1L,0L,2L,7L,5L,3L,0L,4L,2L,2L,0L,4L,5L,2L,9L,9L,5L,2L,6L,5L,8L,6L,1L,3L,1L,2L,7L,0L,7L,2L,4L,5L,8L,4L,0L,1L,3L,6L,1L,0L,5L,2L,5L,3L,2L,0L,6L,2L,6L,6L,3L,1L,9L,7L,7L,0L,5L,3L,9L,7L,0L,2L,6L,5L,9L,4L,8L,4L,6L,7L,1L,3L,3L,5L,8L,6L,1L,9L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011333Inst : IEnumerable<long>
{
public static readonly long[] Value=A011333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011333.Bytes);
public long this[int i]=>Value[i];

public static A011333Inst Instance=new A011333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011332
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,4L,9L,8L,3L,6L,5L,9L,5L,3L,0L,8L,1L,8L,7L,0L,5L,8L,0L,4L,4L,2L,2L,3L,4L,7L,8L,7L,2L,4L,8L,4L,4L,3L,6L,3L,5L,1L,8L,3L,1L,0L,4L,8L,8L,5L,4L,5L,8L,0L,9L,2L,5L,4L,9L,2L,4L,6L,0L,1L,8L,1L,8L,1L,0L,8L,8L,1L,2L,7L,9L,2L,8L,5L,0L,9L,3L,6L,3L,5L,9L,7L,1L,4L,1L,6L,4L,8L,4L,6L,9L,0L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011332Inst : IEnumerable<long>
{
public static readonly long[] Value=A011332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011332.Bytes);
public long this[int i]=>Value[i];

public static A011332Inst Instance=new A011332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011331
{
public static readonly long[] Value={ 1L,1L,6L,2L,8L,5L,6L,3L,7L,8L,8L,7L,0L,9L,3L,7L,6L,9L,9L,4L,6L,9L,9L,3L,8L,0L,6L,1L,5L,6L,4L,7L,9L,0L,6L,0L,0L,6L,0L,5L,6L,7L,1L,8L,6L,8L,2L,8L,9L,8L,1L,1L,6L,1L,0L,9L,3L,6L,5L,5L,8L,1L,8L,8L,7L,0L,2L,1L,6L,4L,6L,6L,3L,4L,5L,2L,9L,6L,6L,7L,3L,1L,4L,0L,3L,0L,6L,8L,3L,5L,0L,6L,2L,9L,0L,6L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011331Inst : IEnumerable<long>
{
public static readonly long[] Value=A011331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011331.Bytes);
public long this[int i]=>Value[i];

public static A011331Inst Instance=new A011331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011330
{
public static readonly long[] Value={ 1L,1L,7L,3L,8L,7L,3L,9L,3L,4L,9L,4L,2L,1L,7L,6L,0L,1L,6L,0L,6L,1L,5L,7L,9L,1L,7L,0L,7L,8L,6L,0L,1L,7L,4L,6L,7L,3L,2L,4L,8L,6L,9L,9L,4L,1L,4L,3L,9L,2L,5L,3L,1L,6L,3L,2L,5L,6L,6L,8L,8L,8L,3L,3L,7L,4L,1L,3L,8L,9L,4L,8L,4L,3L,8L,7L,4L,6L,7L,5L,1L,6L,6L,9L,3L,8L,3L,4L,0L,6L,4L,8L,4L,5L,4L,5L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011330Inst : IEnumerable<long>
{
public static readonly long[] Value=A011330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011330.Bytes);
public long this[int i]=>Value[i];

public static A011330Inst Instance=new A011330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011329
{
public static readonly long[] Value={ 1L,1L,8L,6L,4L,8L,6L,7L,4L,3L,2L,3L,4L,9L,1L,4L,2L,8L,0L,8L,0L,5L,1L,1L,5L,9L,3L,8L,0L,5L,0L,6L,9L,6L,0L,4L,9L,2L,4L,2L,6L,4L,5L,8L,7L,8L,9L,8L,9L,8L,6L,4L,9L,6L,8L,5L,9L,2L,6L,4L,2L,0L,4L,2L,7L,5L,7L,1L,7L,9L,6L,6L,6L,4L,7L,4L,1L,5L,1L,0L,4L,1L,9L,5L,1L,9L,9L,5L,8L,2L,8L,6L,6L,4L,8L,4L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011329Inst : IEnumerable<long>
{
public static readonly long[] Value=A011329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011329.Bytes);
public long this[int i]=>Value[i];

public static A011329Inst Instance=new A011329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011328
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,6L,7L,4L,0L,8L,3L,6L,7L,6L,4L,7L,6L,6L,9L,4L,2L,3L,8L,4L,4L,6L,7L,6L,0L,4L,7L,1L,7L,7L,0L,1L,4L,6L,5L,9L,7L,1L,6L,1L,2L,6L,6L,0L,6L,4L,0L,4L,3L,9L,4L,4L,9L,2L,8L,0L,2L,6L,5L,3L,4L,5L,5L,9L,1L,5L,5L,1L,4L,0L,3L,8L,2L,5L,8L,6L,7L,7L,5L,9L,7L,2L,8L,2L,3L,5L,3L,9L,8L,2L,2L,8L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011328Inst : IEnumerable<long>
{
public static readonly long[] Value=A011328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011328.Bytes);
public long this[int i]=>Value[i];

public static A011328Inst Instance=new A011328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011327
{
public static readonly long[] Value={ 1L,2L,1L,8L,1L,1L,4L,0L,4L,3L,5L,6L,0L,7L,6L,8L,1L,9L,6L,6L,5L,9L,0L,2L,5L,7L,3L,3L,3L,7L,3L,6L,6L,7L,1L,5L,9L,3L,2L,8L,0L,7L,9L,8L,5L,3L,1L,9L,9L,7L,2L,0L,9L,7L,5L,8L,7L,2L,6L,5L,9L,8L,7L,9L,2L,1L,0L,6L,1L,4L,2L,4L,5L,3L,2L,0L,7L,6L,9L,4L,6L,9L,9L,2L,2L,3L,3L,5L,3L,0L,3L,8L,4L,7L,2L,8L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011327Inst : IEnumerable<long>
{
public static readonly long[] Value=A011327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011327.Bytes);
public long this[int i]=>Value[i];

public static A011327Inst Instance=new A011327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011326
{
public static readonly long[] Value={ 1L,2L,3L,8L,3L,0L,7L,8L,1L,1L,9L,0L,1L,5L,4L,3L,1L,1L,2L,2L,5L,4L,1L,1L,9L,2L,3L,9L,3L,5L,0L,9L,5L,4L,3L,2L,2L,4L,5L,4L,5L,3L,2L,6L,9L,0L,8L,3L,7L,9L,0L,2L,3L,8L,0L,7L,7L,5L,1L,6L,3L,2L,1L,7L,2L,0L,5L,8L,7L,1L,0L,8L,6L,7L,6L,8L,9L,1L,5L,5L,9L,4L,4L,8L,4L,2L,8L,8L,4L,8L,2L,9L,8L,6L,6L,2L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011326Inst : IEnumerable<long>
{
public static readonly long[] Value=A011326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011326.Bytes);
public long this[int i]=>Value[i];

public static A011326Inst Instance=new A011326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011277
{
public static readonly long[] Value={ 1L,3L,3L,3L,5L,2L,1L,4L,3L,2L,1L,6L,3L,3L,2L,4L,0L,2L,5L,6L,7L,5L,9L,3L,1L,7L,1L,5L,2L,9L,5L,3L,3L,1L,0L,9L,2L,4L,1L,5L,6L,6L,7L,9L,6L,4L,7L,6L,4L,3L,7L,0L,9L,9L,3L,3L,2L,9L,5L,4L,9L,9L,8L,7L,1L,6L,2L,7L,5L,8L,9L,4L,3L,1L,8L,0L,1L,9L,5L,8L,1L,8L,6L,4L,9L,0L,1L,3L,4L,9L,8L,0L,0L,4L,7L,3L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011277Inst : IEnumerable<long>
{
public static readonly long[] Value=A011277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011277.Bytes);
public long this[int i]=>Value[i];

public static A011277Inst Instance=new A011277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011276
{
public static readonly long[] Value={ 1L,3L,8L,9L,4L,9L,5L,4L,9L,4L,3L,7L,3L,1L,3L,7L,6L,3L,7L,1L,2L,9L,9L,8L,5L,2L,1L,7L,3L,5L,3L,0L,1L,1L,6L,2L,2L,1L,1L,3L,0L,4L,6L,7L,1L,4L,4L,9L,1L,0L,0L,0L,2L,0L,4L,9L,4L,5L,6L,2L,8L,6L,7L,9L,0L,3L,1L,6L,0L,0L,2L,4L,2L,4L,1L,0L,3L,1L,6L,5L,8L,1L,3L,8L,4L,1L,7L,5L,6L,3L,8L,9L,7L,5L,4L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011276Inst : IEnumerable<long>
{
public static readonly long[] Value=A011276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011276.Bytes);
public long this[int i]=>Value[i];

public static A011276Inst Instance=new A011276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011275
{
public static readonly long[] Value={ 1L,4L,6L,7L,7L,9L,9L,2L,6L,7L,6L,2L,2L,0L,6L,9L,5L,4L,0L,9L,2L,0L,5L,1L,7L,1L,1L,4L,8L,1L,6L,8L,6L,1L,2L,5L,4L,7L,9L,5L,6L,4L,2L,6L,5L,7L,0L,0L,5L,1L,7L,3L,9L,9L,5L,9L,4L,8L,3L,8L,2L,3L,5L,7L,8L,5L,7L,3L,7L,2L,4L,0L,7L,0L,1L,0L,3L,4L,1L,4L,2L,6L,0L,5L,9L,5L,9L,4L,9L,7L,6L,8L,9L,3L,2L,8L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011275Inst : IEnumerable<long>
{
public static readonly long[] Value=A011275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011275.Bytes);
public long this[int i]=>Value[i];

public static A011275Inst Instance=new A011275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011274
{
public static readonly long[] Value={ 1L,2L,1L,7L,4L,1L,31L,18L,6L,1L,154L,90L,33L,8L,1L,820L,481L,185L,52L,10L,1L,4575L,2690L,1065L,324L,75L,12L,1L,26398L,15547L,6276L,2006L,515L,102L,14L,1L,156233L,92124L,37711L,12468L,3420L,766L,133L,16L,1L,943174L,556664L,230277L,78030L,22412L,5439L,1085L,168L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011274Inst : IEnumerable<long>
{
public static readonly long[] Value=A011274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011274.Bytes);
public long this[int i]=>Value[i];

public static A011274Inst Instance=new A011274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011273
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,9L,5L,4L,8L,1L,8L,5L,9L,7L,7L,5L,7L,3L,5L,7L,5L,2L,2L,3L,5L,0L,9L,6L,4L,3L,7L,9L,8L,1L,2L,5L,9L,5L,7L,3L,9L,6L,8L,5L,4L,5L,4L,1L,0L,7L,3L,8L,0L,6L,4L,4L,7L,3L,2L,5L,2L,8L,0L,0L,3L,5L,6L,7L,8L,5L,7L,3L,9L,3L,4L,5L,3L,1L,6L,1L,9L,3L,1L,7L,6L,0L,5L,1L,2L,2L,3L,8L,4L,1L,9L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011273Inst : IEnumerable<long>
{
public static readonly long[] Value=A011273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011273.Bytes);
public long this[int i]=>Value[i];

public static A011273Inst Instance=new A011273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011272
{
public static readonly long[] Value={ 0L,1L,3L,13L,64L,339L,1885L,10851L,64109L,386510L,2368354L,14706331L,92337618L,585239903L,3739309053L,24059542845L,155756019048L,1013801283133L,6630587014935L,43553555324502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011272Inst : IEnumerable<long>
{
public static readonly long[] Value=A011272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011272.Bytes);
public long this[int i]=>Value[i];

public static A011272Inst Instance=new A011272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011271
{
public static readonly long[] Value={ 1L,1L,3L,7L,9L,7L,2L,8L,8L,0L,4L,6L,8L,8L,1L,3L,2L,8L,2L,7L,3L,8L,6L,5L,7L,3L,4L,0L,9L,3L,0L,6L,4L,1L,1L,4L,7L,0L,6L,4L,4L,9L,5L,5L,4L,1L,0L,5L,9L,8L,1L,8L,2L,8L,9L,6L,4L,3L,8L,6L,1L,4L,4L,8L,9L,0L,6L,8L,1L,5L,9L,5L,4L,2L,5L,9L,4L,8L,8L,2L,3L,8L,7L,1L,2L,4L,3L,4L,8L,0L,9L,4L,5L,3L,6L,6L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011271Inst : IEnumerable<long>
{
public static readonly long[] Value=A011271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011271.Bytes);
public long this[int i]=>Value[i];

public static A011271Inst Instance=new A011271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011270
{
public static readonly long[] Value={ 1L,1L,4L,18L,90L,481L,2690L,15547L,92124L,556664L,3417062L,21248966L,133576724L,847465593L,5419399722L,34895368578L,226050057378L,1472170887755L,9633297762870L,63305402213336L,417612181048826L,2764492667188504L,18358282050480384L,122265756020847943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011270Inst : IEnumerable<long>
{
public static readonly long[] Value=A011270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011270.Bytes);
public long this[int i]=>Value[i];

public static A011270Inst Instance=new A011270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011269
{
public static readonly long[] Value={ 1L,1L,5L,7L,7L,5L,3L,6L,7L,2L,5L,1L,6L,5L,9L,0L,6L,2L,9L,2L,7L,5L,6L,2L,2L,9L,9L,1L,1L,9L,6L,6L,7L,6L,1L,2L,5L,1L,5L,7L,1L,2L,1L,9L,0L,0L,7L,8L,2L,6L,6L,5L,3L,5L,2L,9L,8L,5L,3L,5L,1L,1L,6L,0L,5L,5L,4L,8L,5L,8L,6L,9L,4L,1L,2L,8L,4L,6L,3L,4L,5L,0L,2L,9L,7L,8L,7L,3L,4L,3L,9L,0L,0L,4L,3L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011269Inst : IEnumerable<long>
{
public static readonly long[] Value=A011269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011269.Bytes);
public long this[int i]=>Value[i];

public static A011269Inst Instance=new A011269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011268
{
public static readonly long[] Value={ 1L,1L,2L,1L,10L,3L,1L,30L,44L,4L,1L,70L,284L,134L,5L,1L,140L,1224L,1594L,329L,6L,1L,252L,4110L,11330L,6552L,700L,7L,1L,420L,11616L,58432L,71484L,21822L,1344L,8L,1L,660L,28908L,241098L,534562L,347274L,62370L,2388L,9L,1L,990L,65208L,842842L,3069360L,3612924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011268Inst : IEnumerable<long>
{
public static readonly long[] Value=A011268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011268.Bytes);
public long this[int i]=>Value[i];

public static A011268Inst Instance=new A011268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011267
{
public static readonly long[] Value={ 1L,1L,8L,4L,1L,4L,0L,5L,9L,4L,9L,8L,8L,8L,5L,7L,1L,4L,2L,4L,3L,7L,5L,7L,8L,7L,0L,7L,4L,4L,0L,5L,8L,4L,1L,4L,4L,7L,2L,8L,8L,3L,4L,8L,7L,6L,3L,3L,8L,9L,4L,1L,3L,0L,4L,5L,1L,8L,9L,7L,0L,3L,0L,6L,4L,4L,8L,7L,8L,5L,6L,7L,9L,9L,8L,7L,0L,2L,9L,4L,3L,0L,2L,7L,0L,1L,9L,4L,1L,1L,8L,5L,3L,7L,4L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011267Inst : IEnumerable<long>
{
public static readonly long[] Value=A011267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011267.Bytes);
public long this[int i]=>Value[i];

public static A011267Inst Instance=new A011267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011266
{
public static readonly BigInteger[] Value={ 1L,1L,4L,48L,1536L,122880L,23592960L,10569646080L,10823317585920L,24936923717959680L,BigInteger.Parse("127677049435953561600"),BigInteger.Parse("1438154284846580917862400"),BigInteger.Parse("35344079704389572637386342400"),BigInteger.Parse("1882001556099335963795547960115200") };
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
public class A011266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011266Inst Instance=new A011266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011265
{
public static readonly long[] Value={ 1L,2L,2L,1L,0L,9L,4L,6L,2L,3L,4L,9L,8L,6L,5L,5L,3L,8L,8L,2L,3L,0L,7L,7L,0L,4L,3L,7L,1L,4L,0L,1L,1L,5L,4L,2L,8L,6L,5L,6L,4L,1L,9L,3L,6L,6L,9L,4L,8L,3L,2L,7L,4L,5L,4L,2L,4L,7L,2L,7L,4L,7L,7L,9L,5L,7L,3L,1L,7L,6L,1L,3L,3L,1L,2L,4L,6L,6L,1L,9L,0L,7L,7L,9L,5L,4L,6L,9L,3L,5L,6L,3L,5L,8L,4L,9L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011265Inst : IEnumerable<long>
{
public static readonly long[] Value=A011265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011265.Bytes);
public long this[int i]=>Value[i];

public static A011265Inst Instance=new A011265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011264
{
public static readonly long[] Value={ 1L,1L,1L,8L,1L,1L,1L,4L,27L,1L,1L,8L,1L,1L,1L,32L,1L,27L,1L,8L,1L,1L,1L,4L,125L,1L,9L,8L,1L,1L,1L,16L,1L,1L,1L,216L,1L,1L,1L,4L,1L,1L,1L,8L,27L,1L,1L,32L,343L,125L,1L,8L,1L,9L,1L,4L,1L,1L,1L,8L,1L,1L,27L,128L,1L,1L,1L,8L,1L,1L,1L,108L,1L,1L,125L,8L,1L,1L,1L,32L,243L,1L,1L,8L,1L,1L,1L,4L,1L,27L,1L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011264Inst : IEnumerable<long>
{
public static readonly long[] Value=A011264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011264.Bytes);
public long this[int i]=>Value[i];

public static A011264Inst Instance=new A011264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011263
{
public static readonly long[] Value={ 1L,2L,7L,6L,5L,1L,8L,0L,0L,7L,0L,0L,9L,2L,4L,1L,6L,5L,9L,6L,8L,4L,3L,9L,8L,6L,5L,0L,5L,8L,2L,7L,1L,6L,2L,8L,2L,1L,4L,2L,6L,0L,8L,9L,9L,5L,9L,4L,8L,4L,7L,8L,3L,5L,3L,0L,7L,4L,3L,6L,4L,2L,2L,0L,5L,1L,3L,8L,2L,6L,8L,2L,3L,5L,8L,8L,7L,5L,9L,2L,1L,6L,1L,0L,0L,0L,4L,3L,6L,5L,5L,4L,1L,8L,4L,3L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011263Inst : IEnumerable<long>
{
public static readonly long[] Value=A011263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011263.Bytes);
public long this[int i]=>Value[i];

public static A011263Inst Instance=new A011263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011262
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,36L,49L,16L,3L,100L,121L,18L,169L,196L,225L,8L,289L,12L,361L,50L,441L,484L,529L,144L,5L,676L,81L,98L,841L,900L,961L,64L,1089L,1156L,1225L,6L,1369L,1444L,1521L,400L,1681L,1764L,1849L,242L,75L,2116L,2209L,72L,7L,20L,2601L,338L,2809L,324L,3025L,784L,3249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011262Inst : IEnumerable<long>
{
public static readonly long[] Value=A011262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011262.Bytes);
public long this[int i]=>Value[i];

public static A011262Inst Instance=new A011262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011213
{
public static readonly long[] Value={ 1L,0L,8L,8L,3L,9L,8L,4L,0L,0L,7L,3L,0L,3L,8L,7L,2L,4L,2L,0L,7L,5L,6L,9L,1L,6L,8L,0L,2L,9L,2L,1L,5L,5L,7L,2L,7L,6L,3L,6L,0L,9L,1L,8L,6L,6L,3L,1L,5L,2L,2L,2L,4L,8L,9L,9L,1L,9L,1L,0L,8L,7L,7L,6L,9L,7L,6L,5L,7L,1L,1L,9L,1L,8L,0L,9L,1L,0L,4L,6L,9L,2L,8L,3L,5L,0L,2L,4L,7L,4L,9L,6L,8L,1L,3L,7L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011213Inst : IEnumerable<long>
{
public static readonly long[] Value=A011213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011213.Bytes);
public long this[int i]=>Value[i];

public static A011213Inst Instance=new A011213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011212
{
public static readonly long[] Value={ 1L,0L,9L,3L,5L,3L,2L,4L,2L,9L,5L,6L,0L,4L,5L,9L,7L,8L,5L,0L,2L,2L,9L,5L,2L,0L,8L,5L,5L,0L,4L,9L,2L,0L,1L,0L,8L,5L,5L,9L,7L,8L,1L,5L,3L,3L,9L,5L,8L,3L,7L,1L,6L,0L,5L,0L,6L,9L,4L,4L,9L,9L,5L,0L,8L,2L,4L,9L,8L,6L,8L,9L,1L,5L,2L,0L,1L,2L,9L,9L,9L,1L,5L,0L,5L,5L,1L,4L,4L,1L,0L,1L,4L,3L,2L,0L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011212Inst : IEnumerable<long>
{
public static readonly long[] Value=A011212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011212.Bytes);
public long this[int i]=>Value[i];

public static A011212Inst Instance=new A011212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011211
{
public static readonly long[] Value={ 1L,0L,9L,9L,2L,9L,9L,1L,2L,5L,8L,1L,0L,3L,7L,9L,5L,3L,3L,4L,7L,8L,4L,2L,2L,2L,4L,2L,4L,8L,0L,9L,4L,1L,6L,7L,8L,2L,4L,3L,1L,5L,3L,9L,7L,7L,1L,2L,3L,9L,0L,3L,2L,5L,7L,3L,4L,2L,7L,2L,4L,7L,8L,4L,2L,9L,8L,9L,4L,7L,8L,2L,5L,3L,6L,4L,6L,6L,7L,2L,8L,2L,6L,6L,5L,4L,2L,2L,7L,7L,5L,1L,5L,6L,2L,1L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011211Inst : IEnumerable<long>
{
public static readonly long[] Value=A011211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011211.Bytes);
public long this[int i]=>Value[i];

public static A011211Inst Instance=new A011211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011210
{
public static readonly long[] Value={ 1L,1L,0L,5L,8L,2L,3L,0L,1L,7L,0L,3L,0L,2L,3L,5L,1L,9L,6L,7L,3L,2L,3L,1L,3L,1L,7L,6L,9L,0L,4L,2L,2L,0L,5L,8L,2L,8L,9L,0L,9L,6L,6L,9L,9L,0L,1L,4L,7L,5L,0L,3L,2L,7L,6L,4L,1L,8L,0L,6L,5L,3L,9L,1L,8L,5L,5L,3L,4L,5L,3L,4L,5L,1L,8L,3L,9L,9L,3L,4L,6L,0L,0L,1L,3L,4L,6L,6L,1L,1L,2L,8L,2L,6L,2L,5L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011210Inst : IEnumerable<long>
{
public static readonly long[] Value=A011210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011210.Bytes);
public long this[int i]=>Value[i];

public static A011210Inst Instance=new A011210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011209
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,6L,3L,5L,7L,6L,8L,4L,4L,8L,0L,3L,3L,9L,4L,1L,4L,5L,9L,8L,7L,2L,8L,1L,9L,4L,0L,2L,3L,0L,5L,5L,6L,7L,5L,7L,9L,2L,2L,2L,1L,3L,8L,6L,4L,3L,1L,1L,9L,0L,7L,3L,4L,6L,2L,1L,0L,7L,9L,0L,3L,1L,0L,5L,9L,1L,6L,8L,8L,1L,1L,6L,1L,3L,7L,0L,0L,9L,3L,7L,5L,4L,6L,6L,4L,2L,4L,2L,2L,4L,7L,0L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011209Inst : IEnumerable<long>
{
public static readonly long[] Value=A011209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011209.Bytes);
public long this[int i]=>Value[i];

public static A011209Inst Instance=new A011209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011208
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,2L,8L,3L,9L,6L,2L,5L,4L,0L,0L,2L,2L,7L,0L,2L,9L,3L,8L,7L,3L,9L,0L,2L,7L,3L,5L,1L,5L,2L,2L,4L,7L,8L,1L,1L,0L,5L,5L,9L,6L,6L,2L,2L,7L,6L,1L,3L,2L,0L,2L,5L,6L,0L,0L,3L,6L,4L,7L,2L,7L,1L,0L,7L,0L,4L,1L,5L,9L,3L,5L,3L,3L,8L,4L,9L,3L,5L,0L,1L,6L,9L,5L,6L,4L,0L,6L,5L,5L,4L,2L,6L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011208Inst : IEnumerable<long>
{
public static readonly long[] Value=A011208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011208.Bytes);
public long this[int i]=>Value[i];

public static A011208Inst Instance=new A011208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011207
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,9L,2L,7L,9L,1L,1L,5L,2L,7L,8L,6L,6L,3L,2L,6L,0L,5L,7L,8L,2L,2L,7L,7L,6L,4L,2L,9L,7L,9L,7L,9L,0L,1L,7L,9L,8L,6L,6L,9L,6L,3L,6L,2L,9L,4L,7L,9L,0L,0L,7L,9L,3L,0L,9L,8L,2L,3L,7L,0L,2L,5L,1L,3L,6L,1L,9L,7L,5L,4L,1L,8L,7L,4L,4L,2L,8L,5L,4L,5L,8L,6L,5L,4L,7L,2L,0L,8L,6L,9L,1L,7L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011207Inst : IEnumerable<long>
{
public static readonly long[] Value=A011207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011207.Bytes);
public long this[int i]=>Value[i];

public static A011207Inst Instance=new A011207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011206
{
public static readonly long[] Value={ 1L,1L,4L,3L,5L,2L,9L,8L,3L,6L,0L,8L,2L,9L,2L,0L,3L,0L,9L,2L,2L,6L,7L,8L,7L,8L,1L,6L,2L,5L,5L,0L,7L,8L,8L,9L,7L,8L,7L,4L,8L,3L,3L,8L,9L,5L,3L,0L,8L,8L,4L,1L,3L,5L,2L,7L,1L,9L,8L,5L,0L,2L,0L,7L,6L,6L,9L,9L,1L,3L,5L,6L,3L,2L,1L,5L,3L,6L,3L,0L,4L,2L,1L,1L,2L,2L,3L,6L,7L,1L,3L,8L,5L,3L,7L,9L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011206Inst : IEnumerable<long>
{
public static readonly long[] Value=A011206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011206.Bytes);
public long this[int i]=>Value[i];

public static A011206Inst Instance=new A011206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011205
{
public static readonly long[] Value={ 1L,1L,5L,7L,5L,5L,7L,9L,1L,1L,7L,7L,0L,6L,5L,4L,5L,6L,8L,6L,4L,2L,7L,2L,5L,7L,8L,0L,4L,7L,9L,1L,2L,7L,3L,2L,3L,2L,0L,4L,6L,5L,5L,3L,4L,7L,5L,1L,5L,2L,3L,6L,6L,4L,3L,4L,5L,7L,7L,5L,6L,7L,8L,8L,0L,4L,5L,7L,1L,2L,8L,9L,8L,9L,9L,0L,5L,8L,4L,2L,1L,3L,1L,2L,8L,7L,3L,6L,7L,0L,6L,8L,7L,2L,5L,5L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011205Inst : IEnumerable<long>
{
public static readonly long[] Value=A011205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011205.Bytes);
public long this[int i]=>Value[i];

public static A011205Inst Instance=new A011205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011204
{
public static readonly long[] Value={ 1L,1L,7L,4L,6L,1L,8L,9L,4L,3L,0L,8L,8L,0L,1L,9L,0L,0L,5L,9L,1L,4L,4L,6L,3L,6L,6L,5L,6L,9L,1L,8L,9L,8L,9L,0L,1L,6L,7L,3L,7L,2L,3L,0L,1L,8L,7L,5L,7L,3L,7L,4L,6L,6L,9L,6L,8L,1L,5L,8L,6L,2L,1L,9L,3L,7L,1L,7L,3L,3L,3L,1L,0L,8L,4L,3L,8L,0L,2L,0L,7L,8L,5L,8L,8L,3L,0L,3L,4L,6L,7L,0L,8L,8L,5L,4L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011204Inst : IEnumerable<long>
{
public static readonly long[] Value=A011204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011204.Bytes);
public long this[int i]=>Value[i];

public static A011204Inst Instance=new A011204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011203
{
public static readonly long[] Value={ 1L,1L,9L,5L,8L,1L,3L,1L,7L,4L,5L,0L,0L,4L,0L,1L,9L,4L,1L,4L,6L,0L,0L,4L,8L,4L,0L,0L,2L,5L,3L,5L,9L,5L,6L,2L,2L,3L,4L,3L,9L,4L,8L,2L,6L,4L,2L,7L,7L,8L,9L,6L,9L,7L,2L,4L,4L,5L,6L,9L,7L,9L,1L,7L,0L,1L,9L,5L,2L,2L,0L,3L,0L,3L,3L,0L,5L,6L,9L,5L,3L,0L,4L,9L,3L,4L,7L,9L,2L,5L,0L,3L,7L,5L,0L,4L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011203Inst : IEnumerable<long>
{
public static readonly long[] Value=A011203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011203.Bytes);
public long this[int i]=>Value[i];

public static A011203Inst Instance=new A011203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011202
{
public static readonly long[] Value={ 1L,2L,2L,2L,8L,4L,4L,5L,4L,4L,9L,9L,3L,8L,5L,1L,8L,4L,1L,9L,4L,1L,1L,4L,4L,3L,6L,4L,4L,6L,7L,6L,0L,1L,5L,3L,1L,4L,2L,2L,4L,2L,1L,5L,5L,2L,3L,5L,4L,0L,8L,0L,2L,3L,3L,9L,8L,5L,8L,2L,5L,1L,6L,9L,8L,5L,1L,6L,5L,2L,9L,7L,5L,6L,9L,3L,6L,5L,4L,7L,5L,2L,6L,4L,1L,7L,1L,7L,4L,0L,4L,6L,0L,2L,4L,8L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011202Inst : IEnumerable<long>
{
public static readonly long[] Value=A011202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011202.Bytes);
public long this[int i]=>Value[i];

public static A011202Inst Instance=new A011202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011201
{
public static readonly long[] Value={ 1L,2L,5L,8L,4L,9L,8L,9L,5L,0L,6L,4L,1L,8L,2L,6L,7L,3L,4L,9L,9L,2L,7L,8L,7L,1L,7L,1L,1L,7L,7L,7L,1L,3L,8L,9L,4L,8L,1L,8L,6L,8L,0L,4L,8L,1L,5L,0L,6L,7L,1L,8L,1L,9L,6L,7L,0L,7L,4L,7L,2L,5L,7L,8L,5L,6L,2L,5L,5L,8L,2L,5L,4L,5L,9L,2L,3L,4L,8L,5L,7L,1L,1L,5L,6L,4L,5L,9L,3L,6L,3L,4L,7L,8L,8L,6L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011201Inst : IEnumerable<long>
{
public static readonly long[] Value=A011201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011201.Bytes);
public long this[int i]=>Value[i];

public static A011201Inst Instance=new A011201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011200
{
public static readonly long[] Value={ 1L,3L,0L,7L,6L,6L,0L,4L,8L,6L,0L,1L,1L,8L,3L,0L,5L,9L,1L,2L,2L,9L,2L,3L,1L,6L,9L,4L,3L,4L,0L,2L,0L,3L,1L,2L,5L,1L,6L,1L,7L,8L,4L,5L,4L,9L,3L,2L,3L,5L,8L,9L,8L,1L,1L,0L,7L,5L,3L,6L,8L,9L,5L,9L,7L,4L,2L,4L,6L,9L,8L,2L,9L,1L,2L,3L,2L,4L,7L,0L,4L,4L,2L,5L,4L,3L,3L,9L,9L,2L,5L,9L,1L,6L,5L,0L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011200Inst : IEnumerable<long>
{
public static readonly long[] Value=A011200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011200.Bytes);
public long this[int i]=>Value[i];

public static A011200Inst Instance=new A011200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011199
{
public static readonly long[] Value={ 1L,24L,105L,280L,585L,1056L,1729L,2640L,3825L,5320L,7161L,9384L,12025L,15120L,18705L,22816L,27489L,32760L,38665L,45240L,52521L,60544L,69345L,78960L,89425L,100776L,113049L,126280L,140505L,155760L,172081L,189504L,208065L,227800L,248745L,270936L,294409L,319200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011199Inst : IEnumerable<long>
{
public static readonly long[] Value=A011199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011199.Bytes);
public long this[int i]=>Value[i];

public static A011199Inst Instance=new A011199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011198
{
public static readonly long[] Value={ 1L,0L,7L,5L,6L,9L,0L,5L,8L,6L,2L,2L,0L,1L,8L,2L,4L,7L,4L,2L,3L,1L,4L,0L,0L,7L,7L,6L,4L,6L,4L,0L,9L,2L,1L,3L,5L,1L,3L,3L,7L,5L,9L,9L,0L,3L,3L,5L,5L,6L,4L,0L,1L,9L,9L,4L,2L,0L,4L,1L,2L,3L,7L,1L,6L,2L,2L,9L,0L,4L,9L,7L,7L,0L,6L,5L,5L,1L,5L,0L,6L,9L,2L,6L,0L,9L,4L,0L,0L,7L,5L,7L,1L,3L,2L,3L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011198Inst : IEnumerable<long>
{
public static readonly long[] Value=A011198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011198.Bytes);
public long this[int i]=>Value[i];

public static A011198Inst Instance=new A011198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011165
{
public static readonly long[] Value={ 2L,4L,0L,2L,2L,4L,8L,8L,6L,7L,9L,6L,2L,8L,6L,2L,4L,6L,6L,4L,8L,4L,1L,9L,9L,7L,8L,7L,1L,9L,8L,3L,3L,0L,6L,4L,8L,8L,2L,4L,0L,5L,1L,8L,2L,3L,3L,0L,4L,6L,4L,6L,4L,5L,1L,9L,3L,6L,0L,7L,1L,7L,1L,6L,8L,3L,1L,1L,9L,3L,1L,9L,3L,2L,2L,4L,4L,8L,2L,9L,7L,7L,2L,7L,0L,6L,6L,2L,5L,2L,8L,7L,0L,5L,6L,2L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011165Inst : IEnumerable<long>
{
public static readonly long[] Value=A011165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011165.Bytes);
public long this[int i]=>Value[i];

public static A011165Inst Instance=new A011165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011164
{
public static readonly long[] Value={ 2L,3L,9L,6L,2L,1L,2L,9L,9L,0L,4L,8L,1L,7L,6L,9L,8L,1L,1L,9L,0L,5L,4L,4L,6L,2L,8L,0L,8L,3L,8L,7L,0L,3L,9L,6L,0L,5L,2L,7L,8L,7L,5L,7L,3L,0L,7L,6L,6L,4L,9L,6L,8L,9L,8L,8L,5L,3L,2L,8L,9L,2L,8L,4L,1L,2L,2L,7L,1L,6L,3L,3L,3L,9L,7L,8L,7L,5L,3L,0L,0L,4L,8L,8L,2L,6L,5L,3L,3L,3L,4L,0L,7L,9L,8L,6L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011164Inst : IEnumerable<long>
{
public static readonly long[] Value=A011164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011164.Bytes);
public long this[int i]=>Value[i];

public static A011164Inst Instance=new A011164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011163
{
public static readonly long[] Value={ 2L,3L,9L,0L,1L,1L,5L,6L,7L,7L,3L,5L,2L,1L,8L,7L,0L,4L,6L,1L,4L,2L,5L,7L,1L,9L,6L,7L,7L,8L,2L,7L,1L,9L,2L,6L,8L,8L,7L,7L,4L,8L,8L,3L,0L,0L,9L,6L,9L,1L,1L,5L,4L,7L,9L,7L,2L,0L,2L,5L,2L,0L,0L,5L,3L,9L,2L,7L,3L,8L,5L,6L,2L,4L,8L,5L,9L,2L,4L,8L,8L,6L,7L,6L,6L,7L,2L,7L,0L,1L,7L,0L,0L,5L,1L,1L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011163Inst : IEnumerable<long>
{
public static readonly long[] Value=A011163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011163.Bytes);
public long this[int i]=>Value[i];

public static A011163Inst Instance=new A011163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011162
{
public static readonly long[] Value={ 2L,3L,8L,3L,9L,5L,5L,5L,0L,3L,4L,5L,4L,8L,9L,9L,6L,9L,8L,0L,3L,8L,9L,1L,3L,5L,1L,2L,6L,1L,1L,7L,3L,7L,5L,1L,1L,5L,4L,5L,2L,7L,8L,1L,9L,0L,6L,1L,3L,8L,6L,5L,1L,5L,3L,7L,9L,6L,9L,1L,8L,7L,6L,1L,1L,0L,0L,1L,0L,3L,7L,2L,7L,1L,1L,2L,4L,3L,3L,2L,4L,2L,3L,5L,2L,7L,4L,4L,1L,9L,6L,8L,0L,0L,5L,3L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011162Inst : IEnumerable<long>
{
public static readonly long[] Value=A011162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011162.Bytes);
public long this[int i]=>Value[i];

public static A011162Inst Instance=new A011162Inst();

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