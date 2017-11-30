using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A225405
{
public static readonly long[] Value={ 3L,4L,5L,1L,5L,0L,7L,1L,2L,2L,2L,4L,4L,2L,9L,6L,0L,7L,3L,5L,4L,5L,8L,8L,8L,0L,4L,1L,8L,5L,1L,4L,0L,0L,6L,1L,3L,5L,4L,4L,8L,1L,3L,7L,4L,0L,7L,4L,8L,5L,5L,1L,6L,7L,4L,5L,5L,0L,0L,4L,9L,0L,4L,7L,0L,8L,6L,8L,4L,7L,4L,4L,2L,2L,0L,3L,2L,2L,0L,1L,6L,5L,5L,4L,3L,0L,3L,4L,9L,7L,1L,5L,1L,2L,3L,0L,2L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225405Inst : IEnumerable<long>
{
public static readonly long[] Value=A225405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225405.Bytes);
public long this[int i]=>Value[i];

public static A225405Inst Instance=new A225405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225406
{
public static readonly long[] Value={ 9L,6L,5L,0L,6L,6L,3L,4L,8L,6L,6L,0L,4L,8L,5L,4L,5L,9L,4L,5L,1L,1L,9L,4L,0L,6L,0L,8L,1L,3L,7L,0L,6L,6L,9L,4L,8L,3L,9L,9L,3L,0L,2L,4L,2L,0L,3L,5L,9L,8L,6L,5L,5L,0L,9L,6L,7L,7L,4L,8L,0L,7L,4L,6L,1L,0L,3L,2L,9L,8L,5L,8L,2L,1L,5L,7L,0L,9L,0L,9L,8L,8L,1L,6L,0L,6L,8L,6L,0L,3L,9L,5L,0L,9L,9L,5L,6L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225406Inst : IEnumerable<long>
{
public static readonly long[] Value=A225406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225406.Bytes);
public long this[int i]=>Value[i];

public static A225406Inst Instance=new A225406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225407
{
public static readonly long[] Value={ 3L,1L,4L,5L,6L,8L,4L,0L,1L,2L,1L,9L,9L,4L,1L,6L,7L,5L,9L,3L,8L,4L,3L,3L,7L,0L,5L,1L,8L,6L,9L,6L,3L,8L,1L,5L,1L,5L,3L,8L,0L,7L,7L,8L,6L,6L,1L,3L,1L,2L,1L,1L,0L,9L,3L,4L,0L,3L,6L,4L,6L,9L,7L,5L,7L,6L,9L,0L,9L,4L,7L,8L,3L,9L,2L,9L,8L,0L,0L,5L,2L,4L,2L,0L,6L,5L,1L,3L,3L,6L,6L,8L,8L,5L,6L,6L,3L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225407Inst : IEnumerable<long>
{
public static readonly long[] Value=A225407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225407.Bytes);
public long this[int i]=>Value[i];

public static A225407Inst Instance=new A225407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225408
{
public static readonly long[] Value={ 7L,5L,4L,8L,4L,9L,2L,8L,7L,7L,7L,5L,5L,7L,0L,3L,9L,2L,6L,4L,5L,4L,1L,1L,1L,9L,5L,8L,1L,4L,8L,5L,9L,9L,3L,8L,6L,4L,5L,5L,1L,8L,6L,2L,5L,9L,2L,5L,1L,4L,4L,8L,3L,2L,5L,4L,4L,9L,9L,5L,0L,9L,5L,2L,9L,1L,3L,1L,5L,2L,5L,5L,7L,7L,9L,6L,7L,7L,9L,8L,3L,4L,4L,5L,6L,9L,6L,5L,0L,2L,8L,4L,8L,7L,6L,9L,7L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225408Inst : IEnumerable<long>
{
public static readonly long[] Value=A225408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225408.Bytes);
public long this[int i]=>Value[i];

public static A225408Inst Instance=new A225408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225409
{
public static readonly long[] Value={ 1L,3L,4L,9L,3L,3L,6L,5L,1L,3L,3L,9L,5L,1L,4L,5L,4L,0L,5L,4L,8L,8L,0L,5L,9L,3L,9L,1L,8L,6L,2L,9L,3L,3L,0L,5L,1L,6L,0L,0L,6L,9L,7L,5L,7L,9L,6L,4L,0L,1L,3L,4L,4L,9L,0L,3L,2L,2L,5L,1L,9L,2L,5L,3L,8L,9L,6L,7L,0L,1L,4L,1L,7L,8L,4L,2L,9L,0L,9L,0L,1L,1L,8L,3L,9L,3L,1L,3L,9L,6L,0L,4L,9L,0L,0L,4L,3L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225409Inst : IEnumerable<long>
{
public static readonly long[] Value=A225409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225409.Bytes);
public long this[int i]=>Value[i];

public static A225409Inst Instance=new A225409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225410
{
public static readonly long[] Value={ 7L,4L,2L,9L,3L,3L,0L,0L,1L,6L,6L,7L,2L,0L,5L,8L,6L,3L,0L,4L,4L,6L,0L,9L,7L,1L,9L,4L,2L,6L,8L,7L,9L,6L,8L,0L,5L,7L,1L,0L,6L,6L,9L,8L,6L,4L,9L,0L,9L,8L,5L,9L,0L,5L,9L,6L,5L,2L,1L,5L,3L,4L,6L,7L,2L,4L,4L,1L,6L,3L,2L,6L,1L,4L,1L,0L,2L,7L,0L,0L,5L,4L,1L,7L,9L,6L,4L,1L,3L,2L,1L,0L,4L,6L,1L,5L,6L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225410Inst : IEnumerable<long>
{
public static readonly long[] Value=A225410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225410.Bytes);
public long this[int i]=>Value[i];

public static A225410Inst Instance=new A225410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225411
{
public static readonly long[] Value={ 3L,2L,5L,3L,5L,5L,4L,1L,6L,5L,5L,3L,1L,6L,8L,4L,8L,9L,4L,8L,3L,0L,3L,8L,6L,8L,6L,2L,7L,7L,5L,3L,5L,5L,6L,1L,6L,4L,6L,6L,4L,3L,7L,4L,7L,6L,7L,1L,3L,6L,5L,8L,1L,0L,3L,2L,9L,5L,1L,6L,3L,2L,8L,8L,3L,3L,4L,7L,9L,2L,5L,9L,0L,7L,1L,9L,6L,9L,6L,9L,2L,6L,0L,2L,0L,2L,6L,5L,3L,4L,6L,8L,6L,9L,9L,1L,2L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225411Inst : IEnumerable<long>
{
public static readonly long[] Value=A225411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225411.Bytes);
public long this[int i]=>Value[i];

public static A225411Inst Instance=new A225411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225412
{
public static readonly long[] Value={ 9L,2L,5L,1L,1L,7L,1L,3L,6L,2L,6L,3L,3L,8L,2L,1L,4L,1L,0L,2L,7L,1L,2L,2L,4L,6L,1L,6L,0L,1L,0L,1L,2L,7L,2L,8L,2L,8L,8L,3L,6L,7L,0L,7L,7L,7L,2L,2L,6L,2L,6L,9L,9L,6L,8L,1L,3L,2L,1L,5L,4L,3L,7L,4L,7L,7L,6L,9L,6L,1L,4L,0L,2L,0L,9L,6L,3L,6L,6L,1L,9L,1L,9L,9L,7L,4L,9L,8L,8L,7L,7L,3L,0L,8L,7L,7L,8L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225412Inst : IEnumerable<long>
{
public static readonly long[] Value=A225412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225412.Bytes);
public long this[int i]=>Value[i];

public static A225412Inst Instance=new A225412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225413
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,3L,0L,0L,0L,0L,6L,12L,6L,0L,0L,0L,0L,10L,30L,30L,10L,0L,0L,0L,0L,15L,60L,91L,60L,15L,0L,0L,0L,0L,21L,105L,215L,215L,105L,21L,0L,0L,0L,0L,28L,168L,435L,590L,435L,168L,28L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225413Inst : IEnumerable<long>
{
public static readonly long[] Value=A225413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225413.Bytes);
public long this[int i]=>Value[i];

public static A225413Inst Instance=new A225413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225414
{
public static readonly long[] Value={ 3L,22L,49L,69L,156L,187L,190L,295L,465L,498L,594L,777L,880L,931L,1144L,1269L,1330L,1501L,1611L,1633L,2190L,2272L,2494L,2619L,2655L,2893L,3475L,3732L,3937L,4182L,4524L,4719L,4900L,5502L,5635L,5866L,6490L,7021L,7185L,7719L,7761L,7828L,7849L,8688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225414Inst : IEnumerable<long>
{
public static readonly long[] Value=A225414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225414.Bytes);
public long this[int i]=>Value[i];

public static A225414Inst Instance=new A225414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225415
{
public static readonly long[] Value={ 1L,1L,58L,1L,1L,1556L,12006L,1556L,1L,1L,39054L,1461615L,5647300L,1461615L,39054L,1L,1L,976552L,135028828L,1838120344L,4873361350L,1838120344L,135028828L,976552L,1L,1L,24414050L,11462721645L,414730580760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225415Inst : IEnumerable<long>
{
public static readonly long[] Value=A225415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225415.Bytes);
public long this[int i]=>Value[i];

public static A225415Inst Instance=new A225415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225416
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,2L,3L,2L,2L,3L,1L,2L,1L,2L,3L,2L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,4L,5L,2L,3L,1L,3L,3L,2L,1L,2L,3L,4L,5L,3L,1L,2L,2L,3L,2L,1L,2L,3L,4L,5L,1L,3L,2L,4L,3L,2L,1L,2L,3L,4L,1L,2L,3L,5L,4L,3L,2L,1L,2L,3L,1L,2L,3L,2L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225416Inst : IEnumerable<long>
{
public static readonly long[] Value=A225416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225416.Bytes);
public long this[int i]=>Value[i];

public static A225416Inst Instance=new A225416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225417
{
public static readonly long[] Value={ 6L,28L,121L,437L,496L,611L,1331L,1397L,8128L,10201L,14641L,27019L,40301L,40991L,41347L,41917L,45743L,47873L,49901L,51101L,67997L,76459L,97637L,99101L,99553L,99779L,120353L,133307L,133961L,134179L,153091L,161051L,165101L,165743L,166171L,182525L,186503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225417Inst : IEnumerable<long>
{
public static readonly long[] Value=A225417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225417.Bytes);
public long this[int i]=>Value[i];

public static A225417Inst Instance=new A225417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225418
{
public static readonly long[] Value={ 25L,32L,54L,98L,125L,126L,128L,140L,196L,230L,243L,246L,255L,256L,315L,322L,348L,366L,392L,512L,520L,576L,625L,810L,828L,896L,1024L,1029L,1060L,1080L,1152L,1166L,1216L,1224L,1225L,1243L,1330L,1395L,1400L,1458L,1462L,1512L,1536L,1548L,1575L,1647L,1708L,1792L,1824L,1872L,1875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225418Inst : IEnumerable<long>
{
public static readonly long[] Value=A225418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225418.Bytes);
public long this[int i]=>Value[i];

public static A225418Inst Instance=new A225418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225419
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,15L,1L,8L,28L,56L,1L,10L,45L,120L,210L,1L,12L,66L,220L,495L,792L,1L,14L,91L,364L,1001L,2002L,3003L,1L,16L,120L,560L,1820L,4368L,8008L,11440L,1L,18L,153L,816L,3060L,8568L,18564L,31824L,43758L,1L,20L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225419Inst : IEnumerable<long>
{
public static readonly long[] Value=A225419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225419.Bytes);
public long this[int i]=>Value[i];

public static A225419Inst Instance=new A225419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225420
{
public static readonly long[] Value={ 1L,14L,33L,32L,91L,141L,213L,212L,213L,3090L,3093L,3090L,3090L,3090L,38405L,38404L,3090L,3090L,38401L,38400L,294581L,294581L,39569681L,5571498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225420Inst : IEnumerable<long>
{
public static readonly long[] Value=A225420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225420.Bytes);
public long this[int i]=>Value[i];

public static A225420Inst Instance=new A225420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225421
{
public static readonly long[] Value={ 3L,5L,7L,11L,19L,53L,59L,151L,353L,557L,599L,773L,997L,5557L,7559L,11119L,15559L,59999L,71777L,75553L,79999L,99991L,191999L,511111L,555557L,575557L,775777L,777977L,799979L,1111151L,3353333L,5595559L,5755559L,7577777L,9999991L,33335333L,55555553L,55555559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225421Inst : IEnumerable<long>
{
public static readonly long[] Value=A225421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225421.Bytes);
public long this[int i]=>Value[i];

public static A225421Inst Instance=new A225421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225422
{
public static readonly long[] Value={ 2L,2L,6L,12L,12L,24L,60L,180L,360L,1260L,5040L,15120L,55440L,166320L,831600L,4324320L,36756720L,367567200L,2327925600L,27935107200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225422Inst : IEnumerable<long>
{
public static readonly long[] Value=A225422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225422.Bytes);
public long this[int i]=>Value[i];

public static A225422Inst Instance=new A225422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225423
{
public static readonly long[] Value={ 37L,43L,103L,157L,181L,283L,331L,379L,409L,433L,613L,631L,643L,691L,739L,811L,823L,829L,991L,1021L,1093L,1171L,1201L,1237L,1249L,1279L,1297L,1381L,1483L,1741L,1759L,1777L,1873L,1879L,2011L,2017L,2131L,2221L,2239L,2269L,2341L,2377L,2467L,2473L,2551L,2659L,2791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225423Inst : IEnumerable<long>
{
public static readonly long[] Value=A225423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225423.Bytes);
public long this[int i]=>Value[i];

public static A225423Inst Instance=new A225423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225424
{
public static readonly long[] Value={ 5L,0L,3L,37L,7L,17L,11L,101L,61L,19L,41L,197L,109L,229L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225424Inst : IEnumerable<long>
{
public static readonly long[] Value=A225424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225424.Bytes);
public long this[int i]=>Value[i];

public static A225424Inst Instance=new A225424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225425
{
public static readonly long[] Value={ 1L,6L,31L,120L,418L,1268L,3499L,8987L,22316L,51677L,116978L,252856L,528275L,1075319L,2131671L,4119410L,7801334L,14482065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225425Inst : IEnumerable<long>
{
public static readonly long[] Value=A225425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225425.Bytes);
public long this[int i]=>Value[i];

public static A225425Inst Instance=new A225425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225426
{
public static readonly long[] Value={ 1L,8L,9L,5L,27L,32L,1L,48L,49L,1L,63L,64L,1L,80L,81L,32L,49L,81L,4L,121L,125L,3L,125L,128L,1L,224L,225L,1L,242L,243L,2L,243L,245L,7L,243L,250L,13L,243L,256L,81L,175L,256L,1L,288L,289L,100L,243L,343L,32L,343L,375L,5L,507L,512L,169L,343L,512L,1L,512L,513L,27L,512L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225426Inst : IEnumerable<long>
{
public static readonly long[] Value=A225426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225426.Bytes);
public long this[int i]=>Value[i];

public static A225426Inst Instance=new A225426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225427
{
public static readonly long[] Value={ 3L,34L,10L,21L,8L,20L,12L,456L,168L,216L,40L,1764L,24L,432L,2772L,780L,1008L,5640L,720L,88452L,15840L,840L,3360L,14040L,288288L,117600L,338400L,13860L,40320L,6283200L,100800L,2106720L,7698600L,26943840L,19768320L,202799520L,12972960L,242260200L,372556800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225427Inst : IEnumerable<long>
{
public static readonly long[] Value=A225427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225427.Bytes);
public long this[int i]=>Value[i];

public static A225427Inst Instance=new A225427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225428
{
public static readonly long[] Value={ 0L,1L,9L,47L,212L,1232L,6592L,31145L,129587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225428Inst : IEnumerable<long>
{
public static readonly long[] Value=A225428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225428.Bytes);
public long this[int i]=>Value[i];

public static A225428Inst Instance=new A225428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225429
{
public static readonly long[] Value={ 0L,1L,8L,38L,165L,1020L,5360L,24553L,98442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225429Inst : IEnumerable<long>
{
public static readonly long[] Value=A225429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225429.Bytes);
public long this[int i]=>Value[i];

public static A225429Inst Instance=new A225429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225430
{
public static readonly long[] Value={ 4L,7L,8L,17L,43L,83L,167L,314L,707L,836L,6833L,8167L,21886L,41833L,89437L,134164L,947617L,987917L,3143167L,3162083L,9272917L,24060133L,60827617L,434738887L,529027313L,2641873937L,5383305583L,14141757313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225430Inst : IEnumerable<long>
{
public static readonly long[] Value=A225430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225430.Bytes);
public long this[int i]=>Value[i];

public static A225430Inst Instance=new A225430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225431
{
public static readonly long[] Value={ 3L,11L,41L,2131L,110771L,15558008491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225431Inst : IEnumerable<long>
{
public static readonly long[] Value=A225431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225431.Bytes);
public long this[int i]=>Value[i];

public static A225431Inst Instance=new A225431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225432
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,10L,1L,5L,250L,106L,1138L,2L,25L,146L,298L,5L,17L,1L,97L,253970L,2L,226L,3034L,9148450L,2050L,10L,157L,126890L,1L,14341370L,5L,110671282L,986L,7586L,530L,130L,173L,5129602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225432Inst : IEnumerable<long>
{
public static readonly long[] Value=A225432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225432.Bytes);
public long this[int i]=>Value[i];

public static A225432Inst Instance=new A225432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225433
{
public static readonly long[] Value={ 1L,1L,1L,1L,-38L,1L,1L,-165L,-165L,1L,1L,-676L,4806L,-676L,1L,1L,-2723L,44452L,44452L,-2723L,1L,1L,-10914L,362895L,-1346780L,362895L,-10914L,1L,1L,-43681L,2780367L,-20297327L,-20297327L,2780367L,-43681L,1L,1L,-174752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225433Inst : IEnumerable<long>
{
public static readonly long[] Value=A225433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225433.Bytes);
public long this[int i]=>Value[i];

public static A225433Inst Instance=new A225433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225434
{
public static readonly long[] Value={ 1L,1L,1L,1L,-58L,1L,1L,-307L,-307L,1L,1L,-1556L,12006L,-1556L,1L,1L,-7805L,140722L,140722L,-7805L,1L,1L,-39054L,1461615L,-5647300L,1461615L,-39054L,1L,1L,-195303L,14287093L,-109642851L,-109642851L,14287093L,-195303L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225434Inst : IEnumerable<long>
{
public static readonly long[] Value=A225434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225434.Bytes);
public long this[int i]=>Value[i];

public static A225434Inst Instance=new A225434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225435
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,19L,68L,44L,416L,758L,6092L,24284L,10348L,110864L,997828L,4545476L,827252L,5166356L,255994804L,1289266004L,3332578444L,8757252244L,3766552348L,27079574548L,1434303566956L,4061479240156L,46849154788124L,54858398447372L,816458740546228L,189647639388428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225435Inst : IEnumerable<long>
{
public static readonly long[] Value=A225435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225435.Bytes);
public long this[int i]=>Value[i];

public static A225435Inst Instance=new A225435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225436
{
public static readonly long[] Value={ 1L,3L,3L,9L,12L,39L,123L,87L,771L,1473L,11427L,46779L,19533L,212559L,1890093L,8691981L,1570137L,9863961L,486463449L,2459255649L,6337494039L,16694653089L,7166066763L,51605000913L,2729643372111L,7738039298811L,89176449644619L,104501330075607L,1554311845035993L,361227369257943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225436Inst : IEnumerable<long>
{
public static readonly long[] Value=A225436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225436.Bytes);
public long this[int i]=>Value[i];

public static A225436Inst Instance=new A225436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225437
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,0L,5L,1L,7L,0L,4L,0L,18L,0L,2L,0L,17L,0L,16L,0L,15L,0L,9L,0L,39L,0L,9L,0L,61L,0L,10L,3L,27L,0L,18L,0L,56L,0L,8L,0L,80L,0L,48L,1L,41L,0L,12L,0L,118L,1L,10L,0L,90L,0L,30L,2L,24L,0L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225437Inst : IEnumerable<long>
{
public static readonly long[] Value=A225437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225437.Bytes);
public long this[int i]=>Value[i];

public static A225437Inst Instance=new A225437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225438
{
public static readonly long[] Value={ 1L,9L,15L,21L,25L,27L,33L,39L,45L,49L,51L,55L,57L,63L,65L,69L,75L,77L,81L,85L,87L,93L,99L,105L,111L,117L,123L,129L,135L,141L,147L,153L,155L,159L,161L,165L,171L,177L,183L,185L,187L,189L,195L,201L,205L,207L,213L,219L,221L,225L,231L,237L,243L,245L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225438Inst : IEnumerable<long>
{
public static readonly long[] Value=A225438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225438.Bytes);
public long this[int i]=>Value[i];

public static A225438Inst Instance=new A225438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225439
{
public static readonly long[] Value={ 1L,3L,21L,162L,1305L,10773L,90342L,765936L,6546177L,56293380L,486451251L,4220183916L,36731240910L,320571837810L,2804298945840L,24580601689752L,215832643307217L,1898042178972285L,16714070686567620L,147360883148636850L,1300623629653125855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225439Inst : IEnumerable<long>
{
public static readonly long[] Value=A225439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225439.Bytes);
public long this[int i]=>Value[i];

public static A225439Inst Instance=new A225439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225440
{
public static readonly long[] Value={ 378L,630L,990L,3240L,4095L,4950L,5460L,9180L,15400L,19110L,25200L,31878L,37128L,37950L,39060L,52650L,61425L,79800L,97020L,103740L,105570L,122265L,145530L,157080L,161028L,176715L,192510L,221445L,265356L,288420L,304590L,306936L,346528L,437580L,500500L,545490L,583740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225440Inst : IEnumerable<long>
{
public static readonly long[] Value=A225440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225440.Bytes);
public long this[int i]=>Value[i];

public static A225440Inst Instance=new A225440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225441
{
public static readonly long[] Value={ 3L,3L,6L,5L,9L,8L,0L,3L,1L,9L,2L,2L,9L,2L,4L,9L,3L,1L,3L,9L,4L,0L,7L,4L,3L,6L,7L,8L,6L,4L,6L,8L,1L,7L,7L,1L,3L,8L,8L,0L,1L,7L,8L,4L,6L,0L,3L,0L,1L,0L,0L,2L,8L,0L,2L,4L,3L,4L,8L,2L,9L,2L,3L,5L,5L,4L,1L,3L,5L,3L,1L,0L,7L,0L,1L,1L,6L,7L,9L,9L,8L,1L,7L,2L,0L,8L,4L,1L,3L,1L,7L,4L,3L,5L,3L,7L,0L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225441Inst : IEnumerable<long>
{
public static readonly long[] Value=A225441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225441.Bytes);
public long this[int i]=>Value[i];

public static A225441Inst Instance=new A225441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225442
{
public static readonly long[] Value={ 7L,3L,4L,7L,5L,2L,2L,0L,4L,1L,9L,0L,8L,3L,4L,1L,0L,5L,3L,3L,0L,9L,6L,5L,3L,4L,9L,0L,4L,7L,7L,0L,5L,1L,3L,8L,2L,2L,9L,9L,9L,1L,8L,0L,6L,9L,5L,8L,3L,9L,8L,1L,4L,6L,7L,1L,1L,3L,0L,5L,0L,5L,2L,2L,8L,8L,5L,7L,7L,9L,5L,1L,5L,8L,3L,6L,5L,0L,4L,7L,7L,9L,0L,1L,3L,7L,7L,9L,2L,8L,9L,8L,4L,4L,2L,7L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225442Inst : IEnumerable<long>
{
public static readonly long[] Value=A225442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225442.Bytes);
public long this[int i]=>Value[i];

public static A225442Inst Instance=new A225442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225443
{
public static readonly long[] Value={ 1L,3L,0L,1L,9L,1L,8L,7L,3L,0L,2L,4L,3L,2L,5L,8L,3L,2L,4L,7L,4L,4L,6L,5L,6L,9L,7L,2L,5L,7L,7L,4L,8L,4L,4L,0L,8L,4L,1L,3L,1L,9L,8L,3L,1L,7L,7L,8L,4L,2L,0L,6L,9L,6L,8L,6L,6L,0L,0L,1L,7L,0L,9L,8L,8L,6L,6L,0L,7L,2L,1L,3L,3L,5L,9L,7L,3L,3L,7L,3L,9L,4L,5L,4L,5L,2L,3L,7L,6L,7L,3L,5L,5L,3L,7L,7L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225443Inst : IEnumerable<long>
{
public static readonly long[] Value=A225443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225443.Bytes);
public long this[int i]=>Value[i];

public static A225443Inst Instance=new A225443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225444
{
public static readonly long[] Value={ 7L,2L,6L,1L,5L,9L,6L,2L,8L,3L,7L,8L,8L,7L,9L,3L,6L,0L,9L,3L,4L,8L,1L,3L,8L,2L,7L,6L,2L,0L,5L,7L,4L,8L,4L,1L,7L,6L,4L,5L,3L,5L,1L,1L,5L,1L,0L,9L,6L,1L,7L,8L,6L,2L,0L,6L,2L,7L,7L,9L,5L,1L,7L,1L,3L,6L,0L,6L,5L,4L,8L,9L,1L,5L,3L,5L,9L,7L,2L,9L,3L,1L,4L,8L,3L,5L,8L,7L,3L,1L,0L,5L,5L,9L,0L,0L,7L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225444Inst : IEnumerable<long>
{
public static readonly long[] Value=A225444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225444.Bytes);
public long this[int i]=>Value[i];

public static A225444Inst Instance=new A225444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225445
{
public static readonly long[] Value={ 3L,4L,3L,2L,1L,0L,9L,4L,6L,2L,6L,6L,3L,5L,3L,3L,3L,4L,9L,8L,0L,7L,9L,7L,3L,9L,5L,8L,1L,9L,5L,2L,0L,2L,3L,5L,9L,5L,9L,0L,0L,7L,4L,3L,9L,1L,6L,4L,5L,0L,2L,8L,4L,9L,1L,8L,9L,7L,8L,9L,8L,1L,0L,5L,6L,9L,5L,9L,6L,0L,1L,3L,0L,7L,8L,5L,7L,7L,8L,5L,1L,2L,9L,9L,9L,5L,2L,9L,9L,3L,5L,8L,8L,3L,1L,6L,4L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225445Inst : IEnumerable<long>
{
public static readonly long[] Value=A225445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225445.Bytes);
public long this[int i]=>Value[i];

public static A225445Inst Instance=new A225445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225446
{
public static readonly long[] Value={ 9L,2L,1L,7L,4L,9L,7L,9L,3L,5L,3L,7L,1L,0L,8L,5L,2L,9L,1L,0L,5L,5L,6L,4L,6L,0L,5L,0L,3L,6L,4L,7L,4L,2L,7L,6L,0L,5L,0L,5L,1L,1L,8L,9L,9L,5L,1L,5L,8L,5L,1L,4L,5L,0L,0L,7L,7L,2L,8L,0L,7L,7L,7L,4L,8L,3L,6L,2L,7L,7L,9L,9L,1L,0L,4L,7L,0L,9L,0L,3L,0L,5L,1L,1L,1L,7L,5L,6L,3L,3L,2L,0L,1L,1L,7L,9L,5L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225446Inst : IEnumerable<long>
{
public static readonly long[] Value=A225446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225446.Bytes);
public long this[int i]=>Value[i];

public static A225446Inst Instance=new A225446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225447
{
public static readonly long[] Value={ 3L,7L,3L,8L,4L,0L,3L,7L,1L,6L,2L,1L,1L,2L,0L,6L,3L,9L,0L,6L,5L,1L,8L,6L,1L,7L,2L,3L,7L,9L,4L,2L,5L,1L,5L,8L,2L,3L,5L,4L,6L,4L,8L,8L,4L,8L,9L,0L,3L,8L,2L,1L,3L,7L,9L,3L,7L,2L,2L,0L,4L,8L,2L,8L,6L,3L,9L,3L,4L,5L,1L,0L,8L,4L,6L,4L,0L,2L,7L,0L,6L,8L,5L,1L,6L,4L,1L,2L,6L,8L,9L,4L,4L,0L,9L,9L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225447Inst : IEnumerable<long>
{
public static readonly long[] Value=A225447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225447.Bytes);
public long this[int i]=>Value[i];

public static A225447Inst Instance=new A225447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225448
{
public static readonly long[] Value={ 7L,5L,6L,7L,8L,9L,0L,5L,3L,7L,3L,3L,6L,4L,6L,6L,6L,5L,0L,1L,9L,2L,0L,2L,6L,0L,4L,1L,8L,0L,4L,7L,9L,7L,6L,4L,0L,4L,0L,9L,9L,2L,5L,6L,0L,8L,3L,5L,4L,9L,7L,1L,5L,0L,8L,1L,0L,2L,1L,0L,1L,8L,9L,4L,3L,0L,4L,0L,3L,9L,8L,6L,9L,2L,1L,4L,2L,2L,1L,4L,8L,7L,0L,0L,0L,4L,7L,0L,0L,6L,4L,1L,1L,6L,8L,3L,5L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225448Inst : IEnumerable<long>
{
public static readonly long[] Value=A225448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225448.Bytes);
public long this[int i]=>Value[i];

public static A225448Inst Instance=new A225448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225449
{
public static readonly long[] Value={ 1L,7L,8L,2L,5L,0L,2L,0L,6L,4L,6L,2L,8L,9L,1L,4L,7L,0L,8L,9L,4L,4L,3L,5L,3L,9L,4L,9L,6L,3L,5L,2L,5L,7L,2L,3L,9L,4L,9L,4L,8L,8L,1L,0L,0L,4L,8L,4L,1L,4L,8L,5L,4L,9L,9L,2L,2L,7L,1L,9L,2L,2L,2L,5L,1L,6L,3L,7L,2L,2L,0L,0L,8L,9L,5L,2L,9L,0L,9L,6L,9L,4L,8L,8L,8L,2L,4L,3L,6L,6L,7L,9L,8L,8L,2L,0L,4L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225449Inst : IEnumerable<long>
{
public static readonly long[] Value=A225449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225449.Bytes);
public long this[int i]=>Value[i];

public static A225449Inst Instance=new A225449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225450
{
public static readonly long[] Value={ 7L,6L,3L,4L,0L,1L,9L,6L,8L,0L,7L,7L,0L,7L,5L,0L,6L,8L,6L,0L,5L,9L,2L,5L,6L,3L,2L,1L,3L,5L,3L,1L,8L,2L,2L,8L,6L,1L,1L,9L,8L,2L,1L,5L,3L,9L,6L,9L,8L,9L,9L,7L,1L,9L,7L,5L,6L,5L,1L,7L,0L,7L,6L,4L,4L,5L,8L,6L,4L,6L,8L,9L,2L,9L,8L,8L,3L,2L,0L,0L,1L,8L,2L,7L,9L,1L,5L,8L,6L,8L,2L,5L,6L,4L,6L,2L,9L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225450Inst : IEnumerable<long>
{
public static readonly long[] Value=A225450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225450.Bytes);
public long this[int i]=>Value[i];

public static A225450Inst Instance=new A225450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225451
{
public static readonly long[] Value={ 3L,6L,5L,2L,4L,7L,7L,9L,5L,8L,0L,9L,1L,6L,5L,8L,9L,4L,6L,6L,9L,0L,3L,4L,6L,5L,0L,9L,5L,2L,2L,9L,4L,8L,6L,1L,7L,7L,0L,0L,0L,8L,1L,9L,3L,0L,4L,1L,6L,0L,1L,8L,5L,3L,2L,8L,8L,6L,9L,4L,9L,4L,7L,7L,1L,1L,4L,2L,2L,0L,4L,8L,4L,1L,6L,3L,4L,9L,5L,2L,2L,0L,9L,8L,6L,2L,2L,0L,7L,1L,0L,1L,5L,5L,7L,2L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225451Inst : IEnumerable<long>
{
public static readonly long[] Value=A225451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225451.Bytes);
public long this[int i]=>Value[i];

public static A225451Inst Instance=new A225451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225452
{
public static readonly long[] Value={ 9L,6L,9L,8L,0L,8L,1L,2L,6L,9L,7L,5L,6L,7L,4L,1L,6L,7L,5L,2L,5L,5L,3L,4L,3L,0L,2L,7L,4L,2L,2L,5L,1L,5L,5L,9L,1L,5L,8L,6L,8L,0L,1L,6L,8L,2L,2L,1L,5L,7L,9L,3L,0L,3L,1L,3L,3L,9L,9L,8L,2L,9L,0L,1L,1L,3L,3L,9L,2L,7L,8L,6L,6L,4L,0L,2L,6L,6L,2L,6L,0L,5L,4L,5L,4L,7L,6L,2L,3L,2L,6L,4L,4L,6L,2L,2L,6L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225452Inst : IEnumerable<long>
{
public static readonly long[] Value=A225452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225452.Bytes);
public long this[int i]=>Value[i];

public static A225452Inst Instance=new A225452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225453
{
public static readonly long[] Value={ 7L,3L,3L,4L,8L,0L,8L,1L,7L,8L,6L,4L,7L,5L,1L,0L,2L,5L,1L,7L,1L,7L,2L,4L,0L,8L,1L,1L,4L,8L,7L,0L,6L,5L,3L,2L,1L,4L,0L,4L,2L,9L,6L,1L,0L,6L,8L,3L,5L,9L,2L,4L,1L,2L,9L,5L,4L,2L,9L,1L,6L,8L,4L,8L,7L,1L,6L,6L,5L,1L,2L,6L,7L,4L,6L,0L,9L,0L,5L,3L,8L,4L,4L,1L,4L,4L,1L,6L,6L,6L,5L,4L,2L,4L,9L,0L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225453Inst : IEnumerable<long>
{
public static readonly long[] Value=A225453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225453.Bytes);
public long this[int i]=>Value[i];

public static A225453Inst Instance=new A225453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225454
{
public static readonly long[] Value={ 3L,5L,8L,8L,4L,3L,5L,1L,8L,9L,4L,3L,0L,2L,8L,7L,3L,6L,5L,9L,9L,1L,4L,9L,8L,0L,3L,6L,0L,6L,7L,4L,8L,6L,5L,2L,4L,5L,6L,8L,0L,9L,2L,1L,6L,2L,9L,2L,0L,0L,6L,2L,4L,0L,4L,6L,1L,0L,9L,1L,1L,7L,0L,5L,5L,8L,6L,6L,1L,9L,4L,3L,9L,5L,6L,7L,3L,8L,7L,3L,7L,5L,5L,3L,4L,2L,5L,9L,3L,8L,2L,7L,7L,3L,9L,8L,7L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225454Inst : IEnumerable<long>
{
public static readonly long[] Value=A225454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225454.Bytes);
public long this[int i]=>Value[i];

public static A225454Inst Instance=new A225454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225455
{
public static readonly long[] Value={ 1L,9L,3L,4L,8L,5L,1L,1L,9L,3L,5L,8L,6L,8L,7L,0L,8L,3L,8L,4L,5L,2L,6L,8L,7L,2L,8L,2L,5L,8L,9L,8L,2L,0L,5L,0L,8L,7L,4L,3L,6L,6L,9L,4L,4L,3L,6L,2L,2L,8L,0L,2L,2L,3L,7L,5L,2L,0L,5L,5L,6L,9L,2L,8L,2L,7L,1L,7L,1L,0L,8L,0L,6L,3L,0L,8L,8L,8L,6L,7L,6L,7L,5L,7L,4L,9L,8L,1L,5L,5L,2L,1L,7L,0L,3L,1L,6L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225455Inst : IEnumerable<long>
{
public static readonly long[] Value=A225455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225455.Bytes);
public long this[int i]=>Value[i];

public static A225455Inst Instance=new A225455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225456
{
public static readonly long[] Value={ 3L,8L,4L,8L,6L,5L,6L,4L,6L,4L,5L,5L,2L,3L,6L,5L,5L,3L,6L,4L,9L,7L,9L,9L,7L,5L,6L,0L,7L,5L,8L,8L,9L,3L,7L,7L,1L,9L,0L,3L,1L,0L,8L,3L,6L,1L,4L,2L,7L,5L,6L,7L,3L,8L,7L,8L,8L,7L,3L,4L,2L,8L,0L,0L,8L,6L,6L,9L,6L,4L,9L,4L,5L,5L,5L,6L,7L,0L,6L,5L,1L,7L,3L,6L,4L,6L,3L,3L,4L,6L,3L,0L,9L,7L,7L,1L,6L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225456Inst : IEnumerable<long>
{
public static readonly long[] Value=A225456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225456.Bytes);
public long this[int i]=>Value[i];

public static A225456Inst Instance=new A225456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225457
{
public static readonly long[] Value={ 7L,0L,6L,9L,4L,2L,3L,0L,7L,3L,6L,7L,9L,6L,2L,6L,7L,7L,2L,1L,4L,0L,9L,2L,6L,5L,6L,9L,7L,8L,9L,8L,9L,7L,5L,0L,3L,7L,3L,7L,8L,5L,2L,8L,0L,3L,2L,6L,6L,3L,1L,3L,4L,1L,3L,7L,5L,3L,4L,5L,3L,4L,6L,5L,3L,5L,8L,0L,9L,6L,7L,3L,9L,1L,6L,4L,4L,5L,9L,3L,8L,4L,1L,8L,6L,4L,1L,8L,5L,9L,6L,2L,6L,4L,3L,3L,3L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225457Inst : IEnumerable<long>
{
public static readonly long[] Value=A225457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225457.Bytes);
public long this[int i]=>Value[i];

public static A225457Inst Instance=new A225457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225458
{
public static readonly long[] Value={ 9L,8L,2L,1L,2L,9L,8L,0L,2L,7L,6L,9L,1L,4L,4L,8L,0L,3L,4L,5L,3L,6L,1L,1L,9L,4L,4L,9L,6L,7L,2L,0L,3L,1L,3L,2L,4L,9L,5L,0L,4L,9L,4L,0L,0L,9L,4L,7L,4L,6L,6L,3L,3L,6L,5L,1L,7L,2L,1L,9L,9L,0L,9L,0L,5L,1L,4L,9L,6L,5L,5L,5L,1L,2L,7L,7L,0L,2L,0L,6L,2L,2L,2L,6L,1L,5L,9L,5L,0L,1L,8L,0L,6L,8L,1L,2L,3L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225458Inst : IEnumerable<long>
{
public static readonly long[] Value=A225458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225458.Bytes);
public long this[int i]=>Value[i];

public static A225458Inst Instance=new A225458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225459
{
public static readonly long[] Value={ 7L,1L,5L,1L,3L,4L,3L,5L,3L,5L,4L,4L,7L,6L,3L,4L,4L,6L,3L,5L,0L,2L,0L,0L,2L,4L,3L,9L,2L,4L,1L,1L,0L,6L,2L,2L,8L,0L,9L,6L,8L,9L,1L,6L,3L,8L,5L,7L,2L,4L,3L,2L,6L,1L,2L,1L,1L,2L,6L,5L,7L,1L,9L,9L,1L,3L,3L,0L,3L,5L,0L,5L,4L,4L,4L,3L,2L,9L,3L,4L,8L,2L,6L,3L,5L,3L,6L,6L,5L,3L,6L,9L,0L,2L,2L,8L,3L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225459Inst : IEnumerable<long>
{
public static readonly long[] Value=A225459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225459.Bytes);
public long this[int i]=>Value[i];

public static A225459Inst Instance=new A225459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225460
{
public static readonly long[] Value={ 3L,9L,3L,0L,5L,7L,6L,9L,2L,6L,3L,2L,0L,3L,7L,3L,2L,2L,7L,8L,5L,9L,0L,7L,3L,4L,3L,0L,2L,1L,0L,1L,0L,2L,4L,9L,6L,2L,6L,2L,1L,4L,7L,1L,9L,6L,7L,3L,3L,6L,8L,6L,5L,8L,6L,2L,4L,6L,5L,4L,6L,5L,3L,4L,6L,4L,1L,9L,0L,3L,2L,6L,0L,8L,3L,5L,5L,4L,0L,6L,1L,5L,8L,1L,3L,5L,8L,1L,4L,0L,3L,7L,3L,5L,6L,6L,6L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225460Inst : IEnumerable<long>
{
public static readonly long[] Value=A225460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225460.Bytes);
public long this[int i]=>Value[i];

public static A225460Inst Instance=new A225460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225461
{
public static readonly long[] Value={ 9L,15L,21L,26L,34L,39L,45L,50L,56L,64L,69L,76L,81L,86L,99L,105L,111L,120L,129L,134L,144L,154L,160L,165L,170L,176L,186L,195L,225L,231L,236L,246L,254L,260L,266L,274L,279L,288L,300L,309L,315L,324L,334L,342L,351L,356L,370L,376L,381L,386L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225461Inst : IEnumerable<long>
{
public static readonly long[] Value=A225461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225461.Bytes);
public long this[int i]=>Value[i];

public static A225461Inst Instance=new A225461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225462
{
public static readonly long[] Value={ 3L,6L,6L,5L,1L,9L,1L,8L,2L,1L,3L,5L,2L,4L,8L,9L,7L,4L,8L,2L,8L,2L,7L,5L,9L,1L,8L,8L,5L,1L,2L,9L,3L,4L,6L,7L,8L,5L,9L,5L,7L,0L,3L,8L,9L,3L,1L,6L,4L,0L,7L,5L,8L,7L,0L,4L,5L,7L,0L,8L,3L,1L,5L,1L,2L,8L,3L,3L,4L,8L,7L,3L,2L,5L,3L,9L,0L,9L,4L,6L,1L,5L,5L,8L,5L,5L,8L,3L,3L,3L,4L,5L,7L,5L,0L,9L,9L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225462Inst : IEnumerable<long>
{
public static readonly long[] Value=A225462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225462.Bytes);
public long this[int i]=>Value[i];

public static A225462Inst Instance=new A225462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225463
{
public static readonly long[] Value={ 7L,4L,1L,1L,5L,6L,4L,8L,1L,0L,5L,6L,9L,7L,1L,2L,6L,3L,4L,0L,0L,8L,5L,0L,1L,9L,6L,3L,9L,3L,2L,5L,1L,3L,4L,7L,5L,4L,3L,1L,9L,0L,7L,8L,3L,7L,0L,7L,9L,9L,3L,7L,5L,9L,5L,3L,8L,9L,0L,8L,8L,2L,9L,4L,4L,1L,3L,3L,8L,0L,5L,6L,0L,4L,3L,2L,6L,1L,2L,6L,2L,4L,4L,6L,5L,7L,4L,0L,6L,1L,7L,2L,2L,6L,0L,1L,2L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225463Inst : IEnumerable<long>
{
public static readonly long[] Value=A225463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225463.Bytes);
public long this[int i]=>Value[i];

public static A225463Inst Instance=new A225463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225464
{
public static readonly long[] Value={ 9L,0L,6L,5L,1L,4L,8L,8L,0L,6L,4L,1L,3L,1L,2L,9L,1L,6L,1L,5L,4L,7L,3L,1L,2L,7L,1L,7L,4L,1L,0L,1L,7L,9L,4L,9L,1L,2L,5L,6L,3L,3L,0L,5L,5L,6L,3L,7L,7L,1L,9L,7L,7L,6L,2L,4L,7L,9L,4L,4L,3L,0L,7L,1L,7L,2L,8L,2L,8L,9L,1L,9L,3L,6L,9L,1L,1L,1L,3L,2L,3L,2L,4L,2L,5L,0L,1L,8L,4L,4L,7L,8L,2L,9L,6L,8L,3L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225464Inst : IEnumerable<long>
{
public static readonly long[] Value=A225464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225464.Bytes);
public long this[int i]=>Value[i];

public static A225464Inst Instance=new A225464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225465
{
public static readonly long[] Value={ 1L,2L,2L,9L,12L,3L,64L,96L,36L,4L,625L,1000L,450L,80L,5L,7776L,12960L,6480L,1440L,150L,6L,117649L,201684L,108045L,27440L,3675L,252L,7L,2097152L,3670016L,2064384L,573440L,89600L,8064L,392L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225465Inst : IEnumerable<long>
{
public static readonly long[] Value=A225465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225465.Bytes);
public long this[int i]=>Value[i];

public static A225465Inst Instance=new A225465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225466
{
public static readonly long[] Value={ 1L,2L,3L,4L,21L,9L,8L,117L,135L,27L,16L,609L,1431L,702L,81L,32L,3093L,13275L,12015L,3240L,243L,64L,15561L,115479L,171990L,81405L,13851L,729L,128L,77997L,970515L,2238327L,1655640L,479682L,56133L,2187L,256L,390369L,7998111L,27533142L,29893941L,13121514L,2561706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225466Inst : IEnumerable<long>
{
public static readonly long[] Value=A225466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225466.Bytes);
public long this[int i]=>Value[i];

public static A225466Inst Instance=new A225466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225467
{
public static readonly long[] Value={ 1L,3L,4L,9L,40L,16L,27L,316L,336L,64L,81L,2320L,4960L,2304L,256L,243L,16564L,63840L,54400L,14080L,1024L,729L,116920L,768496L,1071360L,485120L,79872L,4096L,2187L,821356L,8921136L,19144384L,13502720L,3777536L,430080L,16384L,6561L,5758240L,101417920L,322850304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225467Inst : IEnumerable<long>
{
public static readonly long[] Value=A225467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225467.Bytes);
public long this[int i]=>Value[i];

public static A225467Inst Instance=new A225467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225468
{
public static readonly long[] Value={ 1L,2L,1L,4L,7L,1L,8L,39L,15L,1L,16L,203L,159L,26L,1L,32L,1031L,1475L,445L,40L,1L,64L,5187L,12831L,6370L,1005L,57L,1L,128L,25999L,107835L,82901L,20440L,1974L,77L,1L,256L,130123L,888679L,1019746L,369061L,53998L,3514L,100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225468Inst : IEnumerable<long>
{
public static readonly long[] Value=A225468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225468.Bytes);
public long this[int i]=>Value[i];

public static A225468Inst Instance=new A225468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225469
{
public static readonly long[] Value={ 1L,3L,1L,9L,10L,1L,27L,79L,21L,1L,81L,580L,310L,36L,1L,243L,4141L,3990L,850L,55L,1L,729L,29230L,48031L,16740L,1895L,78L,1L,2187L,205339L,557571L,299131L,52745L,3689L,105L,1L,6561L,1439560L,6338620L,5044536L,1301286L,137592L,6524L,136L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225469Inst : IEnumerable<long>
{
public static readonly long[] Value=A225469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225469.Bytes);
public long this[int i]=>Value[i];

public static A225469Inst Instance=new A225469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225470
{
public static readonly long[] Value={ 1L,2L,1L,10L,7L,1L,80L,66L,15L,1L,880L,806L,231L,26L,1L,12320L,12164L,4040L,595L,40L,1L,209440L,219108L,80844L,14155L,1275L,57L,1L,4188800L,4591600L,1835988L,363944L,39655L,2415L,77L,1L,96342400L,109795600L,46819324L,10206700L,1276009L,95200L,4186L,100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225470Inst : IEnumerable<long>
{
public static readonly long[] Value=A225470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225470.Bytes);
public long this[int i]=>Value[i];

public static A225470Inst Instance=new A225470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225471
{
public static readonly long[] Value={ 1L,3L,1L,21L,10L,1L,231L,131L,21L,1L,3465L,2196L,446L,36L,1L,65835L,45189L,10670L,1130L,55L,1L,1514205L,1105182L,290599L,36660L,2395L,78L,1L,40883535L,31354119L,8951355L,1280419L,101325L,4501L,105L,1L,1267389585L,1012861224L,308846124L,48644344L,4421494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225471Inst : IEnumerable<long>
{
public static readonly long[] Value=A225471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225471.Bytes);
public long this[int i]=>Value[i];

public static A225471Inst Instance=new A225471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225472
{
public static readonly long[] Value={ 1L,2L,3L,4L,21L,18L,8L,117L,270L,162L,16L,609L,2862L,4212L,1944L,32L,3093L,26550L,72090L,77760L,29160L,64L,15561L,230958L,1031940L,1953720L,1662120L,524880L,128L,77997L,1941030L,13429962L,39735360L,57561840L,40415760L,11022480L,256L,390369L,15996222L,165198852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225472Inst : IEnumerable<long>
{
public static readonly long[] Value=A225472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225472.Bytes);
public long this[int i]=>Value[i];

public static A225472Inst Instance=new A225472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225473
{
public static readonly long[] Value={ 1L,3L,4L,9L,40L,32L,27L,316L,672L,384L,81L,2320L,9920L,13824L,6144L,243L,16564L,127680L,326400L,337920L,122880L,729L,116920L,1536992L,6428160L,11642880L,9584640L,2949120L,2187L,821356L,17842272L,114866304L,324065280L,453304320L,309657600L,82575360L,6561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225473Inst : IEnumerable<long>
{
public static readonly long[] Value=A225473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225473.Bytes);
public long this[int i]=>Value[i];

public static A225473Inst Instance=new A225473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225474
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,8L,15L,46L,72L,48L,105L,352L,688L,768L,384L,945L,3378L,7600L,11040L,9600L,3840L,10395L,39048L,97112L,167040L,193920L,138240L,46080L,135135L,528414L,1418648L,2754192L,3857280L,3736320L,2257920L,645120L,2027025L,8196480L,23393376L,49824768L,79892736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225474Inst : IEnumerable<long>
{
public static readonly long[] Value=A225474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225474.Bytes);
public long this[int i]=>Value[i];

public static A225474Inst Instance=new A225474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225475
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,2L,15L,23L,18L,6L,105L,176L,172L,96L,24L,945L,1689L,1900L,1380L,600L,120L,10395L,19524L,24278L,20880L,12120L,4320L,720L,135135L,264207L,354662L,344274L,241080L,116760L,35280L,5040L,2027025L,4098240L,5848344L,6228096L,4993296L,2956800L,1229760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225475Inst : IEnumerable<long>
{
public static readonly long[] Value=A225475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225475.Bytes);
public long this[int i]=>Value[i];

public static A225475Inst Instance=new A225475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225476
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,1L,13L,18L,6L,1L,40L,116L,96L,24L,1L,121L,660L,1020L,600L,120L,1L,364L,3542L,9120L,9480L,4320L,720L,1L,1093L,18438L,74466L,121800L,94920L,35280L,5040L,1L,3280L,94376L,576576L,1394064L,1653120L,1028160L,322560L,40320L,1L,9841L,478440L,4319160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225476Inst : IEnumerable<long>
{
public static readonly long[] Value=A225476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225476.Bytes);
public long this[int i]=>Value[i];

public static A225476Inst Instance=new A225476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225477
{
public static readonly long[] Value={ 1L,2L,3L,10L,21L,9L,80L,198L,135L,27L,880L,2418L,2079L,702L,81L,12320L,36492L,36360L,16065L,3240L,243L,209440L,657324L,727596L,382185L,103275L,13851L,729L,4188800L,13774800L,16523892L,9826488L,3212055L,586845L,56133L,2187L,96342400L,329386800L,421373916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225477Inst : IEnumerable<long>
{
public static readonly long[] Value=A225477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225477.Bytes);
public long this[int i]=>Value[i];

public static A225477Inst Instance=new A225477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225478
{
public static readonly long[] Value={ 1L,3L,4L,21L,40L,16L,231L,524L,336L,64L,3465L,8784L,7136L,2304L,256L,65835L,180756L,170720L,72320L,14080L,1024L,1514205L,4420728L,4649584L,2346240L,613120L,79872L,4096L,40883535L,125416476L,143221680L,81946816L,25939200L,4609024L,430080L,16384L,1267389585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225478Inst : IEnumerable<long>
{
public static readonly long[] Value=A225478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225478.Bytes);
public long this[int i]=>Value[i];

public static A225478Inst Instance=new A225478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225479
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,2L,6L,6L,0L,6L,22L,36L,24L,0L,24L,100L,210L,240L,120L,0L,120L,548L,1350L,2040L,1800L,720L,0L,720L,3528L,9744L,17640L,21000L,15120L,5040L,0L,5040L,26136L,78792L,162456L,235200L,231840L,141120L,40320L,0L,40320L,219168L,708744L,1614816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225479Inst : IEnumerable<long>
{
public static readonly long[] Value=A225479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225479.Bytes);
public long this[int i]=>Value[i];

public static A225479Inst Instance=new A225479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225480
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,0L,14L,0L,-62L,0L,254L,0L,-5110L,0L,2828954L,0L,-114674L,0L,237036478L,0L,-11499383114L,0L,183092554714L,0L,-3584085584926L,0L,3965530936622474L,0L,-573989008898786L,0L,6375197353574922166L,0L,BigInteger.Parse("-9251189109760413581110"),0L,BigInteger.Parse("33111281730973040956798"),0L };
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
public class A225480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225480Inst Instance=new A225480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225481
{
public static readonly long[] Value={ 1L,2L,6L,2L,30L,6L,42L,2L,30L,10L,66L,6L,2730L,14L,30L,2L,510L,6L,798L,10L,2310L,22L,138L,6L,2730L,26L,6L,14L,870L,30L,14322L,2L,5610L,34L,210L,6L,1919190L,38L,78L,10L,13530L,42L,1806L,22L,690L,46L,282L,6L,46410L,10L,1122L,26L,1590L,6L,43890L,14L,16530L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225481Inst : IEnumerable<long>
{
public static readonly long[] Value=A225481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225481.Bytes);
public long this[int i]=>Value[i];

public static A225481Inst Instance=new A225481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225482
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,2L,2L,3L,4L,4L,6L,8L,10L,12L,16L,21L,26L,34L,43L,55L,71L,91L,116L,148L,191L,244L,312L,400L,512L,656L,840L,1076L,1377L,1764L,2260L,2893L,3705L,4745L,6077L,7782L,9966L,12763L,16344L,20932L,26806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225482Inst : IEnumerable<long>
{
public static readonly long[] Value=A225482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225482.Bytes);
public long this[int i]=>Value[i];

public static A225482Inst Instance=new A225482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225483
{
public static readonly long[] Value={ 1L,1L,-26L,1L,1L,-120L,1192L,-120L,1L,1L,-502L,14609L,-88736L,14609L,-502L,1L,1L,-2036L,152638L,-2205524L,9890752L,-2205524L,152638L,-2036L,1L,1L,-8178L,1479727L,-45541628L,424761262L,-1551163136L,424761262L,-45541628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225483Inst : IEnumerable<long>
{
public static readonly long[] Value=A225483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225483.Bytes);
public long this[int i]=>Value[i];

public static A225483Inst Instance=new A225483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225484
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,2L,3L,4L,6L,8L,10L,14L,20L,26L,36L,49L,66L,90L,123L,167L,227L,308L,420L,571L,776L,1056L,1436L,1952L,2656L,3612L,4912L,6680L,9085L,12356L,16804L,22853L,31081L,42269L,57486L,78182L,106327L,144604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225484Inst : IEnumerable<long>
{
public static readonly long[] Value=A225484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225484.Bytes);
public long this[int i]=>Value[i];

public static A225484Inst Instance=new A225484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225485
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,3L,1L,3L,4L,3L,1L,1L,4L,8L,1L,1L,3L,6L,9L,3L,1L,2L,8L,12L,7L,1L,3L,11L,17L,10L,1L,1L,11L,26L,17L,1L,5L,19L,25L,27L,1L,1L,17L,44L,38L,1L,3L,25L,53L,52L,1L,1L,3L,29L,63L,76L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225485Inst : IEnumerable<long>
{
public static readonly long[] Value=A225485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225485.Bytes);
public long this[int i]=>Value[i];

public static A225485Inst Instance=new A225485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225486
{
public static readonly long[] Value={ 0L,2L,3L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225486Inst : IEnumerable<long>
{
public static readonly long[] Value=A225486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225486.Bytes);
public long this[int i]=>Value[i];

public static A225486Inst Instance=new A225486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225487
{
public static readonly long[] Value={ 3L,5L,11L,7L,13L,101L,47L,53L,23L,19L,29L,37L,31L,41L,83L,73L,17L,43L,67L,157L,179L,167L,79L,443L,139L,113L,137L,97L,233L,61L,823L,71L,103L,151L,199L,499L,181L,229L,353L,313L,1889L,271L,317L,197L,613L,607L,127L,257L,89L,367L,223L,433L,239L,911L,109L,107L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225487Inst : IEnumerable<long>
{
public static readonly long[] Value=A225487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225487.Bytes);
public long this[int i]=>Value[i];

public static A225487Inst Instance=new A225487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225488
{
public static readonly long[] Value={ 9L,45L,3L,225L,18L,15L,-1L,1125L,1L,99L,495L,33L,2475L,198L,165L,-1L,12375L,11L,999L,4995L,333L,24975L,1998L,1665L,-1L,124875L,111L,9999L,49995L,3333L,249975L,19998L,16665L,-1L,1249875L,1111L,99999L,49995L,33333L,2499975L,199998L,166665L,-1L,12499875L,11111L,999999L,4999995L,333333L,24999975L,1999998L,1666665L,-1L,124999875L,111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225488Inst : IEnumerable<long>
{
public static readonly long[] Value=A225488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225488.Bytes);
public long this[int i]=>Value[i];

public static A225488Inst Instance=new A225488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225489
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,6L,5L,6L,8L,9L,8L,9L,12L,13L,11L,12L,17L,18L,14L,15L,21L,22L,17L,18L,23L,24L,20L,21L,27L,28L,23L,24L,32L,33L,26L,27L,36L,37L,29L,30L,38L,39L,32L,33L,42L,43L,35L,36L,48L,49L,38L,39L,52L,53L,41L,42L,53L,54L,44L,45L,57L,58L,47L,48L,65L,66L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225489Inst : IEnumerable<long>
{
public static readonly long[] Value=A225489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225489.Bytes);
public long this[int i]=>Value[i];

public static A225489Inst Instance=new A225489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225490
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,15L,21L,30L,42L,60L,84L,118L,166L,233L,327L,458L,643L,901L,1263L,1770L,2481L,3477L,4872L,6828L,9568L,13408L,18788L,26328L,36893L,51697L,72442L,101511L,142245L,199323L,279306L,391383L,548433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225490Inst : IEnumerable<long>
{
public static readonly long[] Value=A225490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225490.Bytes);
public long this[int i]=>Value[i];

public static A225490Inst Instance=new A225490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225491
{
public static readonly long[] Value={ 0L,4L,5L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225491Inst : IEnumerable<long>
{
public static readonly long[] Value=A225491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225491.Bytes);
public long this[int i]=>Value[i];

public static A225491Inst Instance=new A225491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225492
{
public static readonly long[] Value={ 15L,440L,93L,1518L,1081L,8712L,52305L,32300L,5383L,8058L,7165L,196168L,405L,11456L,81L,66432L,102745L,88848L,1071L,15206L,8607L,12228L,270185L,57668L,56895L,42322L,339835L,120510L,3089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225492Inst : IEnumerable<long>
{
public static readonly long[] Value=A225492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225492.Bytes);
public long this[int i]=>Value[i];

public static A225492Inst Instance=new A225492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225493
{
public static readonly long[] Value={ 1L,11L,17L,29L,37L,41L,59L,67L,71L,79L,97L,101L,107L,121L,127L,137L,149L,163L,179L,187L,191L,197L,223L,227L,239L,251L,269L,277L,281L,289L,307L,311L,319L,331L,347L,367L,379L,397L,407L,419L,431L,439L,451L,457L,461L,479L,487L,493L,499L,521L,541L,557L,569L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225493Inst : IEnumerable<long>
{
public static readonly long[] Value=A225493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225493.Bytes);
public long this[int i]=>Value[i];

public static A225493Inst Instance=new A225493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225494
{
public static readonly long[] Value={ 1L,5L,25L,53L,125L,157L,173L,211L,257L,263L,265L,373L,563L,593L,607L,625L,653L,733L,785L,865L,947L,977L,1055L,1103L,1123L,1187L,1223L,1285L,1315L,1325L,1367L,1511L,1747L,1753L,1865L,1907L,2287L,2417L,2677L,2809L,2815L,2903L,2963L,2965L,3035L,3125L,3265L,3307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225494Inst : IEnumerable<long>
{
public static readonly long[] Value=A225494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225494.Bytes);
public long this[int i]=>Value[i];

public static A225494Inst Instance=new A225494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225495
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,19L,21L,23L,27L,31L,39L,43L,47L,49L,57L,61L,63L,69L,73L,81L,83L,89L,91L,93L,103L,109L,113L,117L,129L,131L,133L,139L,141L,147L,151L,161L,167L,169L,171L,181L,183L,189L,193L,199L,207L,217L,219L,229L,233L,241L,243L,247L,249L,267L,271L,273L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225495Inst : IEnumerable<long>
{
public static readonly long[] Value=A225495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225495.Bytes);
public long this[int i]=>Value[i];

public static A225495Inst Instance=new A225495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225496
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,54L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225496Inst : IEnumerable<long>
{
public static readonly long[] Value=A225496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225496.Bytes);
public long this[int i]=>Value[i];

public static A225496Inst Instance=new A225496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225497
{
public static readonly BigInteger[] Value={ 1L,6L,42L,380L,4320L,59682L,974848L,18423288L,396000000L,9548713790L,255409127424L,7507985556084L,240659872940032L,8355664160156250L,312437224148828160L,12519386633593104368UL,BigInteger.Parse("535233488907211702272"),BigInteger.Parse("24320165501859426874998"),BigInteger.Parse("1170472960000000000000000"),BigInteger.Parse("59483046140261749951587180") };
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
public class A225497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A225497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225497Inst Instance=new A225497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225498
{
public static readonly long[] Value={ 9L,25L,27L,45L,49L,81L,121L,125L,169L,225L,243L,289L,325L,343L,361L,405L,529L,561L,625L,637L,729L,841L,891L,961L,1105L,1125L,1225L,1331L,1369L,1377L,1681L,1729L,1849L,2025L,2187L,2197L,2209L,2401L,2465L,2809L,2821L,3125L,3321L,3481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225498Inst : IEnumerable<long>
{
public static readonly long[] Value=A225498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225498.Bytes);
public long this[int i]=>Value[i];

public static A225498Inst Instance=new A225498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225499
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,7L,9L,11L,13L,16L,20L,25L,31L,39L,48L,59L,74L,92L,113L,140L,175L,217L,269L,334L,414L,513L,637L,791L,981L,1217L,1510L,1874L,2325L,2884L,3578L,4440L,5509L,6835L,8481L,10522L,13054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225499Inst : IEnumerable<long>
{
public static readonly long[] Value=A225499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225499.Bytes);
public long this[int i]=>Value[i];

public static A225499Inst Instance=new A225499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225500
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,15L,19L,25L,33L,43L,56L,73L,95L,124L,161L,210L,273L,355L,463L,603L,786L,1023L,1332L,1735L,2259L,2942L,3831L,4989L,6497L,8461L,11019L,14350L,18687L,24335L,31691L,41270L,53745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225500Inst : IEnumerable<long>
{
public static readonly long[] Value=A225500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225500.Bytes);
public long this[int i]=>Value[i];

public static A225500Inst Instance=new A225500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225501
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,15L,20L,27L,36L,46L,61L,80L,106L,139L,183L,241L,317L,417L,549L,722L,950L,1251L,1646L,2166L,2849L,3750L,4935L,6494L,8545L,11245L,14797L,19472L,25623L,33718L,44370L,58387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225501Inst : IEnumerable<long>
{
public static readonly long[] Value=A225501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225501.Bytes);
public long this[int i]=>Value[i];

public static A225501Inst Instance=new A225501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225502
{
public static readonly long[] Value={ 2L,1L,2L,2L,3L,3L,12L,4L,9L,5L,5L,30L,6L,6L,20L,14L,230L,23L,24L,8L,8L,35L,36L,9L,29L,90L,30L,434L,10L,159L,22L,11L,140L,530L,854L,147L,12L,25L,77L,39L,1938509L,13L,41L,69L,182L,70L,14L,104L,105L,60L,30L,15L,15L,47L,240L,65274L,6314L,16L,17009L,33L,50L,68L,17L,264L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225502Inst : IEnumerable<long>
{
public static readonly long[] Value=A225502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225502.Bytes);
public long this[int i]=>Value[i];

public static A225502Inst Instance=new A225502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225503
{
public static readonly long[] Value={ 6L,3L,15L,21L,66L,78L,1326L,190L,1035L,435L,465L,17205L,861L,903L,9870L,5565L,1567335L,16836L,20100L,2556L,2628L,49770L,55278L,4005L,42195L,413595L,47895L,10100265L,5995L,1437360L,32131L,8646L,1352190L,19559385L,54397665L,1642578L,12246L,52975L,501501L,134940L,336324807802305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225503Inst : IEnumerable<long>
{
public static readonly long[] Value=A225503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225503.Bytes);
public long this[int i]=>Value[i];

public static A225503Inst Instance=new A225503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225504
{
public static readonly long[] Value={ 3L,5L,7L,13L,29L,73L,233L,883L,4049L,22013L,140269L,1036183L,8771489L,84270997L,910550899L,10977409981L,146618640533L,2155882170713L,34701120973507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225504Inst : IEnumerable<long>
{
public static readonly long[] Value=A225504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225504.Bytes);
public long this[int i]=>Value[i];

public static A225504Inst Instance=new A225504Inst();

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