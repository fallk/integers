using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200405
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,583L,3637L,25548L,199506L,1714383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200405Inst : IEnumerable<long>
{
public static readonly long[] Value=A200405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200405.Bytes);
public long this[int i]=>Value[i];

public static A200405Inst Instance=new A200405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200406
{
public static readonly long[] Value={ 1L,2L,6L,23L,105L,550L,3228L,20878L,146994L,1116000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200406Inst : IEnumerable<long>
{
public static readonly long[] Value=A200406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200406.Bytes);
public long this[int i]=>Value[i];

public static A200406Inst Instance=new A200406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200407
{
public static readonly long[] Value={ 1L,9L,131L,209L,3051L,44539L,71059L,1037331L,15143129L,24159851L,352689489L,5148619321L,8214278281L,119913388929L,1750515426011L,2792830455689L,40770199546371L,595170096224419L,949554140655979L,13861747932377211L,202356082200876449L,322845614992577171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200407Inst : IEnumerable<long>
{
public static readonly long[] Value=A200407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200407.Bytes);
public long this[int i]=>Value[i];

public static A200407Inst Instance=new A200407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200408
{
public static readonly long[] Value={ 1L,16L,41L,121L,316L,841L,2201L,5776L,15121L,39601L,103676L,271441L,710641L,1860496L,4870841L,12752041L,33385276L,87403801L,228826121L,599074576L,1568397601L,4106118241L,10749957116L,28143753121L,73681302241L,192900153616L,505019158601L,1322157322201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200408Inst : IEnumerable<long>
{
public static readonly long[] Value=A200408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200408.Bytes);
public long this[int i]=>Value[i];

public static A200408Inst Instance=new A200408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200409
{
public static readonly long[] Value={ 1L,39L,571L,911L,13299L,194141L,309739L,4521621L,66007369L,105310349L,1537337841L,22442311319L,35805208921L,522690344319L,7630319841091L,12173665722791L,177713179730619L,2594286303659621L,4139010540540019L,60421958418066141L,882049712924430049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200409Inst : IEnumerable<long>
{
public static readonly long[] Value=A200409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200409.Bytes);
public long this[int i]=>Value[i];

public static A200409Inst Instance=new A200409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200410
{
public static readonly long[] Value={ 1L,4L,6L,7L,1L,0L,7L,0L,6L,7L,9L,4L,7L,8L,9L,4L,0L,0L,2L,3L,4L,3L,2L,4L,8L,3L,6L,3L,2L,3L,9L,3L,6L,5L,8L,0L,8L,2L,6L,6L,0L,9L,4L,3L,7L,9L,9L,7L,6L,0L,2L,3L,2L,3L,4L,2L,5L,2L,4L,8L,0L,9L,9L,2L,0L,7L,4L,3L,8L,3L,7L,5L,3L,0L,8L,5L,7L,7L,5L,7L,1L,5L,9L,5L,6L,5L,4L,2L,7L,7L,4L,9L,6L,7L,6L,5L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200410Inst : IEnumerable<long>
{
public static readonly long[] Value=A200410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200410.Bytes);
public long this[int i]=>Value[i];

public static A200410Inst Instance=new A200410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200411
{
public static readonly long[] Value={ 1L,4L,8L,6L,5L,3L,0L,3L,9L,7L,4L,1L,1L,8L,9L,4L,6L,0L,3L,1L,2L,9L,2L,5L,5L,4L,9L,9L,4L,6L,4L,8L,6L,4L,9L,6L,0L,2L,7L,4L,1L,2L,7L,5L,3L,4L,5L,4L,6L,9L,2L,8L,9L,5L,5L,4L,4L,1L,3L,4L,6L,4L,6L,0L,5L,7L,6L,8L,8L,5L,2L,7L,6L,7L,6L,5L,6L,8L,0L,2L,5L,1L,1L,7L,6L,5L,9L,6L,0L,2L,2L,7L,2L,6L,9L,7L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200411Inst : IEnumerable<long>
{
public static readonly long[] Value=A200411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200411.Bytes);
public long this[int i]=>Value[i];

public static A200411Inst Instance=new A200411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200412
{
public static readonly long[] Value={ 1L,4L,8L,2L,3L,0L,6L,6L,2L,7L,5L,7L,2L,3L,7L,6L,1L,1L,3L,9L,0L,7L,0L,5L,8L,9L,9L,3L,0L,2L,9L,1L,1L,5L,1L,1L,6L,9L,0L,1L,2L,4L,0L,8L,6L,0L,5L,5L,4L,6L,4L,8L,8L,3L,0L,4L,4L,9L,5L,5L,6L,8L,3L,0L,5L,7L,8L,1L,5L,9L,4L,9L,4L,9L,0L,3L,1L,1L,4L,9L,8L,7L,8L,4L,0L,7L,4L,4L,1L,6L,5L,6L,4L,2L,8L,4L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200412Inst : IEnumerable<long>
{
public static readonly long[] Value=A200412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200412.Bytes);
public long this[int i]=>Value[i];

public static A200412Inst Instance=new A200412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200413
{
public static readonly long[] Value={ 1L,4L,9L,0L,1L,4L,5L,8L,2L,7L,9L,1L,2L,3L,2L,0L,4L,6L,1L,4L,3L,7L,5L,7L,0L,2L,7L,8L,4L,7L,3L,0L,8L,6L,6L,9L,0L,7L,2L,1L,1L,5L,5L,3L,5L,8L,2L,0L,1L,8L,5L,1L,2L,2L,9L,6L,1L,8L,7L,3L,7L,8L,1L,5L,9L,3L,8L,9L,7L,4L,1L,9L,6L,3L,4L,0L,7L,9L,3L,3L,4L,9L,9L,4L,5L,0L,7L,3L,7L,4L,2L,2L,8L,0L,7L,3L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200413Inst : IEnumerable<long>
{
public static readonly long[] Value=A200413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200413.Bytes);
public long this[int i]=>Value[i];

public static A200413Inst Instance=new A200413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200414
{
public static readonly long[] Value={ 1L,4L,9L,6L,6L,1L,6L,7L,4L,7L,9L,9L,1L,5L,7L,4L,2L,6L,8L,6L,6L,0L,2L,8L,1L,5L,2L,6L,8L,6L,1L,3L,9L,0L,7L,0L,3L,2L,0L,0L,3L,2L,3L,5L,1L,8L,6L,6L,2L,3L,6L,8L,9L,0L,0L,0L,8L,0L,9L,1L,4L,4L,1L,1L,6L,3L,8L,0L,4L,3L,8L,2L,0L,1L,4L,0L,1L,1L,3L,3L,5L,9L,2L,7L,2L,8L,0L,0L,2L,2L,2L,3L,3L,5L,2L,4L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200414Inst : IEnumerable<long>
{
public static readonly long[] Value=A200414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200414.Bytes);
public long this[int i]=>Value[i];

public static A200414Inst Instance=new A200414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200415
{
public static readonly long[] Value={ 1L,5L,0L,2L,0L,6L,6L,8L,7L,6L,3L,2L,6L,6L,0L,9L,2L,5L,5L,1L,5L,1L,6L,4L,8L,8L,1L,7L,3L,5L,4L,6L,9L,7L,6L,3L,0L,8L,7L,5L,0L,0L,3L,9L,7L,4L,6L,0L,8L,4L,4L,8L,8L,3L,4L,9L,5L,4L,1L,4L,7L,7L,4L,1L,5L,1L,3L,3L,0L,3L,5L,5L,7L,8L,6L,1L,3L,0L,7L,8L,7L,4L,5L,8L,9L,4L,1L,4L,0L,7L,7L,8L,1L,8L,7L,7L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200415Inst : IEnumerable<long>
{
public static readonly long[] Value=A200415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200415.Bytes);
public long this[int i]=>Value[i];

public static A200415Inst Instance=new A200415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200416
{
public static readonly long[] Value={ 1L,4L,9L,3L,4L,8L,5L,1L,6L,4L,0L,7L,9L,5L,5L,2L,7L,7L,4L,1L,5L,5L,5L,7L,8L,7L,6L,8L,9L,1L,5L,0L,5L,7L,0L,6L,5L,3L,6L,0L,1L,6L,4L,3L,2L,6L,6L,1L,4L,3L,9L,6L,3L,9L,3L,8L,2L,4L,8L,3L,1L,2L,5L,5L,6L,6L,5L,2L,8L,1L,0L,5L,4L,0L,1L,5L,2L,9L,6L,8L,6L,7L,5L,4L,2L,7L,2L,6L,7L,8L,3L,6L,1L,6L,1L,2L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200416Inst : IEnumerable<long>
{
public static readonly long[] Value=A200416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200416.Bytes);
public long this[int i]=>Value[i];

public static A200416Inst Instance=new A200416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200417
{
public static readonly long[] Value={ 1L,5L,0L,4L,5L,0L,6L,5L,2L,0L,3L,1L,8L,8L,7L,6L,0L,0L,5L,8L,6L,5L,8L,4L,8L,1L,1L,9L,7L,6L,6L,0L,4L,3L,8L,0L,5L,4L,8L,7L,2L,2L,6L,6L,3L,0L,9L,7L,9L,0L,8L,7L,9L,5L,2L,9L,7L,5L,5L,3L,9L,1L,1L,3L,3L,5L,2L,0L,5L,5L,1L,9L,3L,2L,5L,3L,3L,8L,7L,9L,2L,9L,6L,1L,8L,4L,0L,7L,5L,5L,5L,5L,6L,4L,1L,4L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200417Inst : IEnumerable<long>
{
public static readonly long[] Value=A200417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200417.Bytes);
public long this[int i]=>Value[i];

public static A200417Inst Instance=new A200417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200418
{
public static readonly long[] Value={ 1L,5L,0L,2L,0L,8L,7L,8L,5L,1L,4L,9L,1L,0L,8L,1L,7L,6L,6L,0L,8L,7L,7L,4L,9L,9L,1L,4L,8L,0L,8L,2L,0L,3L,0L,6L,4L,3L,7L,5L,6L,8L,0L,6L,4L,2L,3L,6L,3L,0L,6L,5L,9L,3L,2L,7L,7L,3L,5L,3L,0L,1L,0L,2L,4L,9L,4L,6L,1L,5L,0L,5L,3L,1L,2L,4L,6L,9L,1L,3L,2L,7L,8L,4L,4L,8L,3L,6L,6L,4L,7L,4L,9L,5L,3L,3L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200418Inst : IEnumerable<long>
{
public static readonly long[] Value=A200418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200418.Bytes);
public long this[int i]=>Value[i];

public static A200418Inst Instance=new A200418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200419
{
public static readonly long[] Value={ 1L,5L,0L,6L,7L,8L,9L,6L,5L,1L,9L,2L,9L,9L,8L,8L,3L,9L,2L,9L,9L,5L,4L,6L,8L,4L,5L,4L,0L,2L,1L,3L,0L,4L,2L,0L,6L,7L,7L,1L,7L,4L,6L,9L,6L,8L,8L,3L,0L,9L,3L,7L,2L,7L,0L,9L,8L,4L,6L,0L,3L,1L,5L,9L,7L,4L,1L,0L,3L,2L,2L,2L,8L,5L,4L,0L,0L,3L,6L,3L,4L,9L,8L,5L,7L,7L,6L,7L,2L,7L,4L,0L,0L,0L,5L,0L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200419Inst : IEnumerable<long>
{
public static readonly long[] Value=A200419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200419.Bytes);
public long this[int i]=>Value[i];

public static A200419Inst Instance=new A200419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200420
{
public static readonly long[] Value={ 1L,5L,1L,0L,8L,5L,6L,1L,4L,1L,3L,1L,7L,3L,3L,3L,7L,9L,4L,3L,3L,1L,8L,5L,1L,1L,5L,9L,1L,8L,3L,3L,1L,7L,6L,6L,2L,6L,8L,7L,1L,5L,5L,9L,0L,2L,1L,8L,7L,0L,0L,4L,2L,3L,1L,7L,6L,7L,0L,8L,9L,4L,2L,9L,7L,1L,0L,0L,0L,7L,1L,5L,2L,5L,7L,5L,4L,0L,5L,4L,5L,2L,0L,9L,5L,3L,1L,8L,3L,3L,6L,8L,6L,4L,3L,5L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200420Inst : IEnumerable<long>
{
public static readonly long[] Value=A200420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200420.Bytes);
public long this[int i]=>Value[i];

public static A200420Inst Instance=new A200420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200421
{
public static readonly long[] Value={ 1L,5L,1L,4L,4L,1L,3L,2L,8L,2L,8L,6L,8L,3L,6L,0L,2L,2L,3L,3L,1L,4L,0L,1L,9L,4L,3L,1L,7L,9L,0L,6L,5L,4L,5L,5L,7L,8L,4L,5L,1L,0L,6L,3L,8L,2L,9L,9L,0L,8L,7L,2L,7L,3L,5L,5L,0L,4L,8L,9L,5L,9L,9L,4L,2L,9L,5L,6L,0L,6L,1L,6L,7L,3L,4L,1L,7L,8L,9L,2L,0L,1L,5L,9L,9L,2L,3L,5L,1L,8L,0L,2L,8L,2L,1L,2L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200421Inst : IEnumerable<long>
{
public static readonly long[] Value=A200421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200421.Bytes);
public long this[int i]=>Value[i];

public static A200421Inst Instance=new A200421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200422
{
public static readonly long[] Value={ 1L,5L,0L,8L,9L,2L,9L,7L,7L,3L,7L,6L,0L,1L,7L,5L,5L,0L,2L,2L,5L,5L,5L,7L,2L,5L,4L,4L,9L,7L,6L,1L,8L,4L,1L,8L,4L,3L,7L,0L,8L,6L,1L,5L,6L,4L,3L,7L,3L,1L,3L,8L,1L,8L,1L,3L,1L,5L,8L,5L,5L,1L,2L,0L,4L,3L,2L,2L,7L,5L,8L,8L,8L,0L,3L,3L,0L,7L,1L,6L,5L,6L,1L,3L,5L,2L,5L,5L,5L,1L,2L,9L,9L,8L,6L,1L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200422Inst : IEnumerable<long>
{
public static readonly long[] Value=A200422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200422.Bytes);
public long this[int i]=>Value[i];

public static A200422Inst Instance=new A200422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200423
{
public static readonly long[] Value={ 1L,5L,1L,6L,0L,8L,1L,4L,9L,5L,9L,5L,8L,7L,8L,3L,8L,3L,3L,9L,1L,4L,0L,4L,1L,5L,5L,7L,3L,1L,0L,8L,6L,4L,1L,7L,0L,7L,6L,3L,2L,8L,4L,3L,9L,3L,7L,1L,5L,5L,8L,7L,3L,5L,7L,9L,3L,4L,3L,4L,1L,9L,6L,7L,7L,6L,1L,2L,8L,3L,8L,7L,8L,0L,9L,8L,1L,4L,7L,5L,5L,3L,0L,3L,7L,8L,0L,0L,7L,7L,1L,5L,0L,0L,9L,8L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200423Inst : IEnumerable<long>
{
public static readonly long[] Value=A200423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200423.Bytes);
public long this[int i]=>Value[i];

public static A200423Inst Instance=new A200423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200424
{
public static readonly long[] Value={ 20L,80L,212L,594L,1928L,6780L,23674L,80750L,271000L,909282L,3082640L,10545846L,36174576L,123964062L,424595930L,1456168762L,5004245744L,17226485764L,59361633214L,204702938074L,706403203606L,2439664629760L,8432567247356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200424Inst : IEnumerable<long>
{
public static readonly long[] Value=A200424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200424.Bytes);
public long this[int i]=>Value[i];

public static A200424Inst Instance=new A200424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200425
{
public static readonly long[] Value={ 92L,520L,2232L,9898L,50592L,270848L,1432402L,7469120L,38883992L,203526914L,1071337158L,5658347658L,29934599276L,158560687098L,841075030030L,4468272429398L,23771639720040L,126620792508358L,675163140324368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200425Inst : IEnumerable<long>
{
public static readonly long[] Value=A200425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200425.Bytes);
public long this[int i]=>Value[i];

public static A200425Inst Instance=new A200425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200426
{
public static readonly long[] Value={ 248L,1830L,11008L,67852L,473034L,3397130L,24220966L,171351382L,1214558880L,8651325238L,61876262346L,443696753874L,3187550880360L,22937925283316L,165329774491030L,1193432351805558L,8626352984960916L,62427556201202018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200426Inst : IEnumerable<long>
{
public static readonly long[] Value=A200426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200426.Bytes);
public long this[int i]=>Value[i];

public static A200426Inst Instance=new A200426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200427
{
public static readonly long[] Value={ 520L,4750L,36952L,293464L,2591502L,23380862L,210222830L,1882624856L,16911040968L,152565274262L,1381204433968L,12534862082614L,113983746333928L,1038347313892636L,9474508237939826L,86579678278534962L,792234931151418444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200427Inst : IEnumerable<long>
{
public static readonly long[] Value=A200427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200427.Bytes);
public long this[int i]=>Value[i];

public static A200427Inst Instance=new A200427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200428
{
public static readonly long[] Value={ 940L,10250L,98052L,955602L,10217182L,111101654L,1206988576L,13090995142L,142480007436L,1556876199472L,17066756670292L,187540784116604L,2065041046363200L,22780124416681858L,251710751862388016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200428Inst : IEnumerable<long>
{
public static readonly long[] Value=A200428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200428.Bytes);
public long this[int i]=>Value[i];

public static A200428Inst Instance=new A200428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200429
{
public static readonly long[] Value={ 1540L,19530L,221984L,2567334L,32233938L,410475622L,5230842688L,66651385442L,852399648492L,10942076565344L,140893244263052L,1818559742718468L,23521609925458628L,304795848113641082L,3956133736667718388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200429Inst : IEnumerable<long>
{
public static readonly long[] Value=A200429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200429.Bytes);
public long this[int i]=>Value[i];

public static A200429Inst Instance=new A200429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200430
{
public static readonly long[] Value={ 0L,20L,0L,92L,80L,0L,248L,520L,212L,0L,520L,1830L,2232L,594L,0L,940L,4750L,11008L,9898L,1928L,0L,1540L,10250L,36952L,67852L,50592L,6780L,0L,2352L,19530L,98052L,293464L,473034L,270848L,23674L,0L,3408L,34020L,221984L,955602L,2591502L,3397130L,1432402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200430Inst : IEnumerable<long>
{
public static readonly long[] Value=A200430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200430.Bytes);
public long this[int i]=>Value[i];

public static A200430Inst Instance=new A200430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200431
{
public static readonly long[] Value={ 0L,20L,92L,248L,520L,940L,1540L,2352L,3408L,4740L,6380L,8360L,10712L,13468L,16660L,20320L,24480L,29172L,34428L,40280L,46760L,53900L,61732L,70288L,79600L,89700L,100620L,112392L,125048L,138620L,153140L,168640L,185152L,202708L,221340L,241080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200431Inst : IEnumerable<long>
{
public static readonly long[] Value=A200431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200431.Bytes);
public long this[int i]=>Value[i];

public static A200431Inst Instance=new A200431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200432
{
public static readonly long[] Value={ 0L,80L,520L,1830L,4750L,10250L,19530L,34020L,55380L,85500L,126500L,180730L,250770L,339430L,449750L,585000L,748680L,944520L,1176480L,1448750L,1765750L,2132130L,2552770L,3032780L,3577500L,4192500L,4883580L,5656770L,6518330L,7474750L,8532750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200432Inst : IEnumerable<long>
{
public static readonly long[] Value=A200432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200432.Bytes);
public long this[int i]=>Value[i];

public static A200432Inst Instance=new A200432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200433
{
public static readonly long[] Value={ 0L,212L,2232L,11008L,36952L,98052L,221984L,448224L,830160L,1437204L,2356904L,3697056L,5587816L,8183812L,11666256L,16245056L,22160928L,29687508L,39133464L,50844608L,65206008L,82644100L,103628800L,128675616L,158347760L,193258260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200433Inst : IEnumerable<long>
{
public static readonly long[] Value=A200433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200433.Bytes);
public long this[int i]=>Value[i];

public static A200433Inst Instance=new A200433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200434
{
public static readonly long[] Value={ 0L,594L,9898L,67852L,293464L,955602L,2567334L,6003816L,12643728L,24534258L,44579634L,76753204L,126333064L,200161234L,306926382L,457470096L,665116704L,946026642L,1319573370L,1808743836L,2440562488L,3246538834L,4263138550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200434Inst : IEnumerable<long>
{
public static readonly long[] Value=A200434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200434.Bytes);
public long this[int i]=>Value[i];

public static A200434Inst Instance=new A200434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200435
{
public static readonly long[] Value={ 0L,1928L,50592L,473034L,2591502L,10217182L,32233938L,86581308L,205946004L,445471164L,892792604L,1680711318L,3002811474L,5132333154L,8444609086L,13443374616L,20791260168L,31344775440L,46194094584L,66707951618L,94583955318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200435Inst : IEnumerable<long>
{
public static readonly long[] Value=A200435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200435.Bytes);
public long this[int i]=>Value[i];

public static A200435Inst Instance=new A200435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200436
{
public static readonly long[] Value={ 0L,6780L,270848L,3397130L,23380862L,111101654L,410475622L,1264140498L,3392223642L,8172417894L,18054265218L,37145223104L,72010763708L,132735430724L,234296453996L,398306196892L,655184386476L,1046825751528L,1629833368476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200436Inst : IEnumerable<long>
{
public static readonly long[] Value=A200436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200436.Bytes);
public long this[int i]=>Value[i];

public static A200436Inst Instance=new A200436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200437
{
public static readonly long[] Value={ 0L,23674L,1432402L,24220966L,210222830L,1206988576L,5230842688L,18491305412L,56022717236L,150412523630L,366439267062L,824236891962L,1734285496242L,3448292160196L,6530868950100L,11857838629608L,20748002017096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200437Inst : IEnumerable<long>
{
public static readonly long[] Value=A200437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200437.Bytes);
public long this[int i]=>Value[i];

public static A200437Inst Instance=new A200437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200438
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,5L,14L,-40L,-119L,351L,1083L,-3291L,-10424L,32562L,105066L,-334666L,-1094595L,3536043L,11686231L,-38172425L,-127199414L,419230644L,1406346735L,-4669311299L,-15750517780L,52616257231L,178312867791L,-598779740235L,-2037290707630L,6871904761413L,23461177498832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200438Inst : IEnumerable<long>
{
public static readonly long[] Value=A200438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200438.Bytes);
public long this[int i]=>Value[i];

public static A200438Inst Instance=new A200438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200439
{
public static readonly long[] Value={ 2L,7L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200439Inst : IEnumerable<long>
{
public static readonly long[] Value=A200439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200439.Bytes);
public long this[int i]=>Value[i];

public static A200439Inst Instance=new A200439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200440
{
public static readonly long[] Value={ 0L,5L,9L,63L,192L,259L,1421L,3007L,9653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200440Inst : IEnumerable<long>
{
public static readonly long[] Value=A200440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200440.Bytes);
public long this[int i]=>Value[i];

public static A200440Inst Instance=new A200440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200441
{
public static readonly BigInteger[] Value={ 1L,33L,1088L,35871L,1182655L,38991744L,1285544897L,42383989857L,1397386120384L,46071357982815L,1518957427312511L,50079523743330048L,1651105326102579073L,BigInteger.Parse("54436396237641779361"),BigInteger.Parse("1794749970516076139840"),BigInteger.Parse("59172312630792870835359"),BigInteger.Parse("1950891566845648661427007") };
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
public class A200441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200441Inst Instance=new A200441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200442
{
public static readonly BigInteger[] Value={ 1L,31L,960L,29729L,920639L,28510080L,882891841L,27341136991L,846692354880L,26220121864289L,811977085438079L,25145069526716160L,778685178242762881L,BigInteger.Parse("24114095455998933151"),BigInteger.Parse("746758273957724164800"),BigInteger.Parse("23125392397233450175649"),BigInteger.Parse("716140406040279231280319") };
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
public class A200442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200442Inst Instance=new A200442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200443
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,8L,9L,6L,5L,4L,3L,2L,1L,9L,12L,9L,6L,5L,4L,3L,2L,1L,10L,15L,14L,9L,6L,5L,4L,3L,2L,1L,11L,18L,19L,12L,7L,6L,5L,4L,3L,2L,1L,12L,21L,24L,17L,12L,7L,6L,5L,4L,3L,2L,1L,13L,24L,33L,22L,19L,8L,7L,6L,7L,4L,3L,2L,1L,14L,29L,42L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200443Inst : IEnumerable<long>
{
public static readonly long[] Value=A200443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200443.Bytes);
public long this[int i]=>Value[i];

public static A200443Inst Instance=new A200443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200444
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,14L,19L,24L,33L,42L,53L,64L,77L,94L,115L,136L,159L,182L,209L,242L,279L,316L,355L,398L,445L,492L,549L,606L,673L,740L,811L,882L,957L,1042L,1137L,1232L,1331L,1430L,1541L,1652L,1779L,1906L,2037L,2176L,2323L,2470L,2623L,2786L,2961L,3140L,3327L,3514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200444Inst : IEnumerable<long>
{
public static readonly long[] Value=A200444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200444.Bytes);
public long this[int i]=>Value[i];

public static A200444Inst Instance=new A200444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200445
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,12L,17L,22L,37L,52L,71L,94L,117L,148L,197L,250L,305L,364L,453L,546L,655L,768L,897L,1050L,1227L,1412L,1623L,1846L,2121L,2400L,2729L,3066L,3417L,3824L,4289L,4774L,5285L,5812L,6447L,7094L,7799L,8516L,9309L,10190L,11117L,12072L,13101L,14170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200445Inst : IEnumerable<long>
{
public static readonly long[] Value=A200445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200445.Bytes);
public long this[int i]=>Value[i];

public static A200445Inst Instance=new A200445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200446
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,12L,19L,28L,43L,66L,97L,132L,177L,242L,321L,420L,529L,662L,829L,1044L,1327L,1624L,1977L,2400L,2883L,3434L,4103L,4818L,5711L,6698L,7791L,8982L,10279L,11860L,13693L,15648L,17783L,20078L,22725L,25538L,28845L,32338L,36091L,40360L,44961L,49814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200446Inst : IEnumerable<long>
{
public static readonly long[] Value=A200446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200446.Bytes);
public long this[int i]=>Value[i];

public static A200446Inst Instance=new A200446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200447
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,17L,26L,41L,60L,93L,130L,187L,256L,373L,522L,717L,940L,1209L,1586L,2121L,2728L,3513L,4412L,5477L,6734L,8393L,10272L,12585L,15230L,18267L,21728L,25639L,30370L,36047L,42304L,49367L,57338L,66281L,76008L,87997L,101138L,115865L,132268L,150389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200447Inst : IEnumerable<long>
{
public static readonly long[] Value=A200447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200447.Bytes);
public long this[int i]=>Value[i];

public static A200447Inst Instance=new A200447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200448
{
public static readonly long[] Value={ 10L,44L,144L,486L,1582L,5478L,18692L,64782L,223272L,776430L,2701660L,9439702L,33021250L,115801892L,406698282L,1430840312L,5040451088L,17779563894L,62784860258L,221948186878L,785340477204L,2781302241584L,9857972484436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200448Inst : IEnumerable<long>
{
public static readonly long[] Value=A200448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200448.Bytes);
public long this[int i]=>Value[i];

public static A200448Inst Instance=new A200448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200449
{
public static readonly long[] Value={ 26L,142L,728L,3788L,19802L,103726L,548204L,2916664L,15576706L,83481240L,448758338L,2418733790L,13066215896L,70726653732L,383520053994L,2082953525918L,11328873637896L,61694898371006L,336368349457684L,1835858710497508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200449Inst : IEnumerable<long>
{
public static readonly long[] Value=A200449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200449.Bytes);
public long this[int i]=>Value[i];

public static A200449Inst Instance=new A200449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200450
{
public static readonly long[] Value={ 44L,342L,2334L,16380L,115140L,820650L,5876818L,42324384L,306098316L,2222013090L,16179361028L,118122171194L,864377954818L,6338065287424L,46557302873890L,342540516750538L,2523812868946712L,18619248362911724L,137522653687668252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200450Inst : IEnumerable<long>
{
public static readonly long[] Value=A200450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200450.Bytes);
public long this[int i]=>Value[i];

public static A200450Inst Instance=new A200450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200451
{
public static readonly long[] Value={ 72L,678L,5720L,50852L,451708L,4062384L,36725772L,334032710L,3050654456L,27965763262L,257160791680L,2371128350480L,21913699015614L,202938626310668L,1882772669652668L,17495621074794634L,162811923678190584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200451Inst : IEnumerable<long>
{
public static readonly long[] Value=A200451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200451.Bytes);
public long this[int i]=>Value[i];

public static A200451Inst Instance=new A200451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200452
{
public static readonly long[] Value={ 102L,1148L,12002L,127988L,1375006L,14923636L,163058296L,1791564880L,19771609900L,219008350922L,2433568582846L,27114470656254L,302815705130546L,3388823734521446L,37993433832232370L,426648365048068166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200452Inst : IEnumerable<long>
{
public static readonly long[] Value=A200452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200452.Bytes);
public long this[int i]=>Value[i];

public static A200452Inst Instance=new A200452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200453
{
public static readonly long[] Value={ 142L,1832L,22276L,278906L,3513884L,44716536L,572857272L,7380022092L,95496980144L,1240352594210L,16161267003100L,211148128583658L,2765181621011902L,36287540439791446L,477071904597059874L,6282247056373911518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200453Inst : IEnumerable<long>
{
public static readonly long[] Value=A200453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200453.Bytes);
public long this[int i]=>Value[i];

public static A200453Inst Instance=new A200453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200454
{
public static readonly long[] Value={ 4L,10L,4L,26L,44L,6L,44L,142L,144L,10L,72L,342L,728L,486L,14L,102L,678L,2334L,3788L,1582L,22L,142L,1148L,5720L,16380L,19802L,5478L,34L,184L,1832L,12002L,50852L,115140L,103726L,18692L,52L,236L,2744L,22276L,127988L,451708L,820650L,548204L,64782L,80L,290L,3874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200454Inst : IEnumerable<long>
{
public static readonly long[] Value=A200454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200454.Bytes);
public long this[int i]=>Value[i];

public static A200454Inst Instance=new A200454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200455
{
public static readonly long[] Value={ 4L,10L,26L,44L,72L,102L,142L,184L,236L,290L,354L,420L,496L,574L,662L,752L,852L,954L,1066L,1180L,1304L,1430L,1566L,1704L,1852L,2002L,2162L,2324L,2496L,2670L,2854L,3040L,3236L,3434L,3642L,3852L,4072L,4294L,4526L,4760L,5004L,5250L,5506L,5764L,6032L,6302L,6582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200455Inst : IEnumerable<long>
{
public static readonly long[] Value=A200455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200455.Bytes);
public long this[int i]=>Value[i];

public static A200455Inst Instance=new A200455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200456
{
public static readonly long[] Value={ 4L,44L,142L,342L,678L,1148L,1832L,2744L,3874L,5334L,7114L,9192L,11708L,14644L,17962L,21826L,26206L,31044L,36544L,42660L,49310L,56734L,64866L,73616L,83256L,93696L,104834L,116970L,130006L,143824L,158748L,174668L,191446L,209446L,228542L,248572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200456Inst : IEnumerable<long>
{
public static readonly long[] Value=A200456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200456.Bytes);
public long this[int i]=>Value[i];

public static A200456Inst Instance=new A200456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200457
{
public static readonly long[] Value={ 6L,144L,728L,2334L,5720L,12002L,22276L,38174L,61290L,93704L,137374L,194964L,268842L,362092L,477620L,618954L,789324L,992970L,1233412L,1515270L,1842742L,2220844L,2654034L,3148080L,3707758L,4339192L,5047836L,5840186L,6721964L,7700510L,8781768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200457Inst : IEnumerable<long>
{
public static readonly long[] Value=A200457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200457.Bytes);
public long this[int i]=>Value[i];

public static A200457Inst Instance=new A200457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200458
{
public static readonly long[] Value={ 10L,486L,3788L,16380L,50852L,127988L,278906L,547518L,991740L,1686602L,2726152L,4224676L,6319970L,9175294L,12980046L,17954222L,24348932L,32448240L,42572590L,55080404L,70369230L,88879322L,111095332L,137546940L,168813148L,205524308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200458Inst : IEnumerable<long>
{
public static readonly long[] Value=A200458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200458.Bytes);
public long this[int i]=>Value[i];

public static A200458Inst Instance=new A200458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200459
{
public static readonly long[] Value={ 14L,1582L,19802L,115140L,451708L,1375006L,3513884L,7910100L,16176994L,30639164L,54582252L,92444962L,150029642L,234839570L,356372880L,526276044L,758938962L,1071722528L,1485196016L,2023848468L,2716453852L,3596089776L,4701336350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200459Inst : IEnumerable<long>
{
public static readonly long[] Value=A200459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200459.Bytes);
public long this[int i]=>Value[i];

public static A200459Inst Instance=new A200459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200460
{
public static readonly long[] Value={ 22L,5478L,103726L,820650L,4062384L,14923636L,44716536L,115516220L,266427776L,562116652L,1103746930L,2042412926L,3596047852L,6069519806L,9877920686L,15574753386L,23883962076L,35735712652L,52308828350L,75077488038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200460Inst : IEnumerable<long>
{
public static readonly long[] Value=A200460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200460.Bytes);
public long this[int i]=>Value[i];

public static A200460Inst Instance=new A200460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200461
{
public static readonly long[] Value={ 34L,18692L,548204L,5876818L,36725772L,163058296L,572857272L,1697721154L,4418429664L,10383073842L,22471124198L,45437973772L,86792210440L,157952348940L,275717978586L,464147942094L,756885155284L,1199972729134L,1855294240358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200461Inst : IEnumerable<long>
{
public static readonly long[] Value=A200461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200461.Bytes);
public long this[int i]=>Value[i];

public static A200461Inst Instance=new A200461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200462
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,20L,29L,43L,63L,91L,130L,184L,262L,370L,519L,724L,1010L,1408L,1955L,2705L,3735L,5157L,7107L,9775L,13418L,18406L,25227L,34529L,47200L,64455L,87969L,119952L,163415L,222427L,302568L,411334L,558808L,758640L,1029312L,1395882L,1891970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200462Inst : IEnumerable<long>
{
public static readonly long[] Value=A200462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200462.Bytes);
public long this[int i]=>Value[i];

public static A200462Inst Instance=new A200462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200463
{
public static readonly long[] Value={ 3L,6L,12L,24L,48L,98L,199L,400L,800L,1597L,3188L,6360L,12679L,25273L,50376L,100400L,200077L,398698L,794502L,1583212L,3154828L,6286514L,12526942L,24961994L,49740765L,99116372L,197505241L,393560803L,784232662L,1562708632L,3113946596L,6205036280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200463Inst : IEnumerable<long>
{
public static readonly long[] Value=A200463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200463.Bytes);
public long this[int i]=>Value[i];

public static A200463Inst Instance=new A200463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200464
{
public static readonly long[] Value={ 4L,10L,26L,69L,181L,455L,1120L,2794L,6955L,17254L,42770L,105825L,262026L,648672L,1605786L,3974375L,9835789L,24343416L,60250311L,149117782L,369056036L,913396093L,2260628044L,5594995167L,13847440350L,34272006253L,84822308047L,209933077581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200464Inst : IEnumerable<long>
{
public static readonly long[] Value=A200464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200464.Bytes);
public long this[int i]=>Value[i];

public static A200464Inst Instance=new A200464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200465
{
public static readonly long[] Value={ 5L,15L,45L,135L,405L,1213L,3627L,10846L,32429L,96970L,289870L,866499L,2590128L,7742621L,23144448L,69183744L,206804024L,618180094L,1847865864L,5523643627L,16511274210L,49355507149L,147533484214L,441007079909L,1318258258809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200465Inst : IEnumerable<long>
{
public static readonly long[] Value=A200465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200465.Bytes);
public long this[int i]=>Value[i];

public static A200465Inst Instance=new A200465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200466
{
public static readonly long[] Value={ 6L,21L,75L,267L,951L,3328L,11576L,40309L,140298L,487872L,1695490L,5890943L,20469215L,71122969L,247110741L,858548734L,2982886197L,10363606865L,36006690099L,125099226783L,434636165827L,1510070809645L,5246488474683L,18228043608602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200466Inst : IEnumerable<long>
{
public static readonly long[] Value=A200466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200466.Bytes);
public long this[int i]=>Value[i];

public static A200466Inst Instance=new A200466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200467
{
public static readonly long[] Value={ 7L,28L,112L,448L,1792L,7140L,28434L,113193L,450812L,1795581L,7151892L,28486092L,113459436L,451907189L,1799936702L,7169108310L,28554377148L,113731374269L,452989138551L,1804244048124L,7186257254293L,28622677050945L,114003380196965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200467Inst : IEnumerable<long>
{
public static readonly long[] Value=A200467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200467.Bytes);
public long this[int i]=>Value[i];

public static A200467Inst Instance=new A200467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200468
{
public static readonly long[] Value={ 8L,36L,164L,750L,3434L,15446L,69136L,309748L,1386973L,6207948L,27781867L,124317636L,556310068L,2489502301L,11140314293L,49852273554L,223086037878L,998302588120L,4467360525658L,19991251154656L,89460006607948L,400329985806851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200468Inst : IEnumerable<long>
{
public static readonly long[] Value=A200468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200468.Bytes);
public long this[int i]=>Value[i];

public static A200468Inst Instance=new A200468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200469
{
public static readonly long[] Value={ 2L,3L,3L,4L,6L,5L,5L,10L,12L,8L,6L,15L,26L,24L,13L,7L,21L,45L,69L,48L,20L,8L,28L,75L,135L,181L,98L,29L,9L,36L,112L,267L,405L,455L,199L,43L,10L,45L,164L,448L,951L,1213L,1120L,400L,63L,11L,55L,225L,750L,1792L,3328L,3627L,2794L,800L,91L,12L,66L,305L,1125L,3434L,7140L,11576L,10846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200469Inst : IEnumerable<long>
{
public static readonly long[] Value=A200469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200469.Bytes);
public long this[int i]=>Value[i];

public static A200469Inst Instance=new A200469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200470
{
public static readonly long[] Value={ 20L,98L,455L,1213L,3328L,7140L,15446L,28023L,51356L,85228L,141665L,217763L,335496L,489964L,716380L,1000977L,1400376L,1894984L,2565347L,3373769L,4439204L,5709980L,7346722L,9262315L,11681488L,14491782L,17981005L,21979651L,26872568L,32446832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200470Inst : IEnumerable<long>
{
public static readonly long[] Value=A200470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200470.Bytes);
public long this[int i]=>Value[i];

public static A200470Inst Instance=new A200470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200471
{
public static readonly long[] Value={ 29L,199L,1120L,3627L,11576L,28434L,69136L,139566L,281169L,509465L,917176L,1519297L,2507652L,3907871L,6070416L,8983497L,13266213L,18901105L,26867168L,37023721L,50931188L,68369984L,91636040L,120165960L,157385059L,202502115L,260240316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200471Inst : IEnumerable<long>
{
public static readonly long[] Value=A200471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200471.Bytes);
public long this[int i]=>Value[i];

public static A200471Inst Instance=new A200471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200472
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,3L,0L,1L,1L,0L,0L,0L,1L,1L,10L,15L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,35L,0L,105L,0L,0L,0L,1L,1L,0L,280L,0L,0L,0L,0L,0L,1L,1L,126L,0L,0L,945L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,462L,5775L,15400L,0L,10395L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200472Inst : IEnumerable<long>
{
public static readonly long[] Value=A200472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200472.Bytes);
public long this[int i]=>Value[i];

public static A200472Inst Instance=new A200472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200473
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,10L,15L,1L,1L,1L,1L,35L,105L,1L,1L,280L,1L,1L,126L,945L,1L,1L,1L,1L,462L,5775L,15400L,10395L,1L,1L,1L,1L,1716L,135135L,1L,1L,126126L,1401400L,1L,1L,6435L,2627625L,2027025L,1L,1L,1L,1L,24310L,2858856L,190590400L,34459425L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200473Inst : IEnumerable<long>
{
public static readonly long[] Value=A200473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200473.Bytes);
public long this[int i]=>Value[i];

public static A200473Inst Instance=new A200473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200474
{
public static readonly long[] Value={ 3L,6L,2L,4L,6L,1L,5L,3L,1L,2L,4L,3L,1L,3L,2L,1L,3L,2L,3L,3L,1L,0L,1L,0L,1L,6L,1L,2L,0L,4L,0L,2L,2L,1L,2L,2L,0L,3L,0L,1L,0L,4L,4L,1L,0L,1L,2L,0L,3L,1L,1L,1L,0L,1L,1L,0L,3L,4L,1L,0L,1L,4L,1L,2L,0L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,2L,0L,2L,0L,1L,1L,1L,2L,1L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200474Inst : IEnumerable<long>
{
public static readonly long[] Value=A200474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200474.Bytes);
public long this[int i]=>Value[i];

public static A200474Inst Instance=new A200474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200475
{
public static readonly long[] Value={ 1L,1L,3L,13L,65L,350L,1981L,11627L,70132L,432090L,2707595L,17202779L,110563543L,717547090L,4695774335L,30952628861L,205318395288L,1369539030021L,9180527051187L,61813112864984L,417850301293691L,2834802846097200L,19294989810689802L,131723105933867817L,901709774424393614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200475Inst : IEnumerable<long>
{
public static readonly long[] Value=A200475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200475.Bytes);
public long this[int i]=>Value[i];

public static A200475Inst Instance=new A200475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200476
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,3L,1L,3L,1L,8L,3L,9L,6L,16L,9L,24L,17L,35L,29L,49L,45L,81L,73L,110L,115L,166L,166L,240L,250L,347L,372L,491L,539L,715L,776L,988L,1109L,1393L,1553L,1935L,2178L,2676L,3034L,3674L,4176L,5056L,5734L,6862L,7834L,9316L,10615L,12576L,14341L,16890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200476Inst : IEnumerable<long>
{
public static readonly long[] Value=A200476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200476.Bytes);
public long this[int i]=>Value[i];

public static A200476Inst Instance=new A200476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200477
{
public static readonly long[] Value={ 6L,5L,9L,6L,0L,6L,2L,2L,6L,9L,1L,3L,3L,5L,3L,9L,0L,4L,4L,3L,4L,8L,1L,9L,3L,9L,2L,7L,7L,3L,3L,5L,5L,8L,5L,0L,5L,7L,5L,1L,0L,3L,4L,0L,5L,2L,0L,2L,9L,6L,0L,9L,8L,1L,4L,6L,9L,4L,6L,0L,6L,6L,3L,9L,7L,5L,9L,1L,8L,4L,6L,4L,7L,4L,1L,9L,3L,8L,5L,8L,9L,9L,9L,8L,0L,3L,8L,7L,2L,0L,5L,7L,1L,1L,9L,9L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200477Inst : IEnumerable<long>
{
public static readonly long[] Value=A200477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200477.Bytes);
public long this[int i]=>Value[i];

public static A200477Inst Instance=new A200477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200478
{
public static readonly long[] Value={ 1L,1L,3L,6L,3L,1L,1L,5L,7L,7L,5L,0L,5L,6L,6L,5L,7L,0L,2L,3L,1L,0L,8L,5L,5L,2L,8L,6L,1L,7L,8L,4L,4L,3L,8L,6L,4L,5L,8L,5L,6L,0L,5L,6L,8L,7L,8L,4L,5L,0L,2L,7L,6L,6L,3L,7L,3L,7L,3L,2L,8L,5L,9L,0L,7L,0L,6L,0L,3L,8L,2L,9L,5L,9L,0L,4L,2L,3L,2L,5L,0L,6L,8L,3L,4L,1L,1L,5L,9L,6L,8L,5L,3L,0L,1L,3L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200478Inst : IEnumerable<long>
{
public static readonly long[] Value=A200478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200478.Bytes);
public long this[int i]=>Value[i];

public static A200478Inst Instance=new A200478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200479
{
public static readonly long[] Value={ 1L,2L,8L,1L,5L,9L,8L,1L,8L,8L,3L,8L,9L,5L,4L,6L,5L,5L,1L,8L,1L,6L,8L,0L,9L,9L,7L,6L,0L,1L,5L,6L,1L,0L,9L,5L,7L,3L,8L,6L,8L,5L,9L,0L,5L,6L,4L,0L,3L,2L,7L,6L,0L,4L,2L,4L,2L,5L,3L,3L,9L,4L,9L,7L,0L,7L,6L,8L,5L,8L,0L,5L,0L,6L,4L,5L,2L,5L,4L,8L,1L,9L,3L,8L,7L,1L,0L,2L,1L,4L,2L,9L,9L,3L,0L,9L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200479Inst : IEnumerable<long>
{
public static readonly long[] Value=A200479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200479.Bytes);
public long this[int i]=>Value[i];

public static A200479Inst Instance=new A200479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200480
{
public static readonly long[] Value={ 1L,3L,5L,0L,8L,9L,8L,4L,1L,5L,9L,2L,7L,0L,6L,2L,6L,0L,3L,1L,1L,7L,1L,8L,7L,7L,8L,6L,3L,9L,8L,9L,5L,4L,8L,5L,4L,7L,9L,4L,9L,2L,5L,5L,8L,7L,3L,1L,9L,8L,5L,9L,6L,1L,3L,3L,5L,6L,0L,2L,5L,2L,2L,9L,2L,6L,2L,4L,2L,7L,6L,1L,9L,6L,9L,7L,8L,9L,2L,7L,0L,0L,2L,0L,1L,5L,7L,2L,3L,0L,9L,1L,9L,9L,8L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200480Inst : IEnumerable<long>
{
public static readonly long[] Value=A200480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200480.Bytes);
public long this[int i]=>Value[i];

public static A200480Inst Instance=new A200480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200481
{
public static readonly long[] Value={ 3L,7L,3L,7L,5L,2L,2L,6L,6L,8L,3L,0L,3L,9L,4L,3L,9L,3L,0L,2L,4L,3L,6L,2L,4L,5L,4L,0L,8L,6L,3L,6L,0L,6L,4L,3L,2L,8L,4L,4L,8L,3L,5L,6L,7L,8L,4L,9L,8L,0L,8L,1L,4L,5L,1L,1L,4L,9L,7L,6L,1L,7L,2L,9L,7L,4L,5L,9L,1L,5L,2L,9L,0L,1L,3L,3L,5L,3L,8L,4L,5L,8L,8L,7L,7L,5L,8L,1L,2L,2L,2L,3L,0L,0L,6L,1L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200481Inst : IEnumerable<long>
{
public static readonly long[] Value=A200481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200481.Bytes);
public long this[int i]=>Value[i];

public static A200481Inst Instance=new A200481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200482
{
public static readonly long[] Value={ 8L,0L,4L,2L,0L,3L,5L,6L,2L,1L,3L,8L,6L,9L,2L,6L,4L,6L,0L,3L,3L,8L,2L,6L,9L,4L,5L,5L,4L,3L,8L,6L,9L,6L,7L,6L,8L,9L,0L,4L,1L,8L,0L,7L,8L,3L,4L,8L,4L,8L,8L,9L,6L,4L,8L,4L,3L,0L,8L,8L,2L,3L,3L,4L,4L,4L,5L,5L,7L,4L,0L,1L,9L,2L,3L,2L,1L,6L,2L,3L,2L,2L,6L,2L,3L,1L,1L,8L,5L,8L,9L,8L,6L,4L,3L,5L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200482Inst : IEnumerable<long>
{
public static readonly long[] Value=A200482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200482.Bytes);
public long this[int i]=>Value[i];

public static A200482Inst Instance=new A200482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200483
{
public static readonly long[] Value={ 1L,1L,0L,9L,5L,3L,6L,9L,1L,8L,7L,7L,1L,0L,3L,7L,7L,5L,1L,3L,0L,9L,1L,7L,8L,3L,5L,9L,0L,7L,3L,5L,6L,1L,4L,8L,5L,7L,9L,9L,3L,7L,6L,7L,3L,1L,9L,0L,0L,8L,8L,0L,7L,2L,7L,7L,6L,2L,1L,9L,0L,0L,7L,5L,1L,6L,2L,7L,8L,3L,1L,8L,1L,0L,0L,3L,8L,1L,4L,2L,6L,2L,3L,7L,6L,8L,2L,6L,6L,0L,5L,2L,0L,9L,1L,3L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200483Inst : IEnumerable<long>
{
public static readonly long[] Value=A200483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200483.Bytes);
public long this[int i]=>Value[i];

public static A200483Inst Instance=new A200483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200484
{
public static readonly long[] Value={ 1L,2L,5L,5L,4L,4L,5L,6L,4L,8L,9L,2L,1L,7L,7L,2L,0L,6L,0L,8L,3L,1L,9L,7L,6L,5L,0L,7L,2L,1L,7L,5L,5L,9L,2L,7L,0L,5L,5L,0L,3L,7L,7L,7L,0L,2L,7L,6L,5L,1L,8L,1L,4L,9L,1L,7L,2L,2L,4L,7L,0L,8L,2L,6L,6L,9L,9L,3L,6L,9L,7L,5L,6L,0L,6L,2L,3L,0L,3L,4L,4L,1L,7L,1L,3L,3L,9L,1L,9L,4L,5L,7L,1L,2L,0L,3L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200484Inst : IEnumerable<long>
{
public static readonly long[] Value=A200484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200484.Bytes);
public long this[int i]=>Value[i];

public static A200484Inst Instance=new A200484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200485
{
public static readonly long[] Value={ 2L,6L,6L,0L,8L,4L,5L,5L,4L,1L,1L,2L,8L,5L,2L,7L,2L,1L,7L,8L,8L,6L,4L,2L,1L,4L,4L,2L,7L,8L,3L,5L,9L,0L,7L,1L,3L,2L,5L,7L,8L,0L,4L,3L,5L,9L,4L,7L,6L,9L,1L,4L,3L,9L,2L,3L,7L,2L,1L,2L,9L,3L,8L,1L,9L,4L,9L,7L,7L,3L,7L,7L,2L,1L,3L,4L,5L,7L,4L,5L,4L,2L,8L,4L,2L,2L,1L,2L,3L,2L,7L,8L,8L,2L,5L,4L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200485Inst : IEnumerable<long>
{
public static readonly long[] Value=A200485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200485.Bytes);
public long this[int i]=>Value[i];

public static A200485Inst Instance=new A200485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200486
{
public static readonly long[] Value={ 5L,6L,2L,0L,3L,2L,0L,3L,3L,5L,2L,3L,6L,8L,9L,9L,2L,3L,5L,8L,6L,2L,2L,1L,6L,3L,2L,1L,4L,4L,2L,7L,2L,1L,1L,4L,7L,6L,7L,7L,5L,1L,6L,4L,6L,6L,5L,3L,9L,9L,0L,1L,6L,9L,8L,6L,4L,7L,7L,7L,0L,1L,3L,2L,8L,0L,5L,1L,7L,6L,3L,9L,7L,0L,1L,0L,5L,5L,7L,0L,3L,2L,4L,0L,4L,5L,9L,9L,0L,1L,4L,4L,1L,7L,8L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200486Inst : IEnumerable<long>
{
public static readonly long[] Value=A200486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200486.Bytes);
public long this[int i]=>Value[i];

public static A200486Inst Instance=new A200486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200487
{
public static readonly long[] Value={ 8L,5L,9L,4L,6L,0L,9L,4L,1L,0L,0L,6L,0L,2L,7L,0L,7L,4L,0L,8L,1L,4L,4L,7L,6L,4L,1L,6L,1L,4L,2L,2L,2L,6L,1L,0L,6L,2L,0L,1L,7L,2L,4L,2L,2L,7L,9L,3L,8L,2L,1L,7L,6L,9L,7L,6L,3L,6L,1L,0L,9L,7L,5L,7L,5L,3L,6L,5L,4L,5L,9L,2L,2L,8L,6L,3L,6L,0L,3L,0L,1L,1L,7L,4L,6L,8L,9L,1L,0L,7L,0L,1L,8L,0L,7L,6L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200487Inst : IEnumerable<long>
{
public static readonly long[] Value=A200487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200487.Bytes);
public long this[int i]=>Value[i];

public static A200487Inst Instance=new A200487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200488
{
public static readonly long[] Value={ 1L,0L,9L,0L,1L,8L,3L,4L,1L,5L,1L,3L,8L,3L,2L,5L,5L,1L,8L,7L,4L,7L,3L,8L,3L,9L,8L,8L,3L,2L,7L,2L,2L,1L,9L,1L,0L,5L,6L,0L,8L,1L,8L,3L,0L,8L,0L,4L,3L,8L,5L,5L,6L,9L,7L,0L,7L,2L,9L,2L,4L,9L,3L,6L,2L,8L,4L,9L,2L,7L,8L,4L,5L,1L,0L,3L,9L,0L,4L,5L,9L,3L,1L,0L,2L,0L,3L,7L,2L,7L,4L,1L,8L,9L,2L,2L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200488Inst : IEnumerable<long>
{
public static readonly long[] Value=A200488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200488.Bytes);
public long this[int i]=>Value[i];

public static A200488Inst Instance=new A200488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200489
{
public static readonly long[] Value={ 2L,0L,8L,0L,4L,5L,7L,0L,0L,8L,8L,3L,7L,1L,6L,3L,5L,2L,6L,2L,9L,6L,4L,4L,8L,1L,3L,6L,0L,8L,9L,7L,9L,5L,2L,2L,7L,2L,3L,5L,4L,4L,8L,3L,3L,8L,0L,7L,4L,3L,9L,9L,2L,4L,5L,2L,0L,6L,6L,4L,8L,3L,6L,5L,9L,2L,1L,1L,2L,5L,3L,7L,5L,2L,9L,8L,9L,2L,4L,4L,0L,7L,0L,9L,9L,2L,5L,2L,7L,6L,1L,5L,3L,8L,2L,3L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200489Inst : IEnumerable<long>
{
public static readonly long[] Value=A200489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200489.Bytes);
public long this[int i]=>Value[i];

public static A200489Inst Instance=new A200489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200490
{
public static readonly long[] Value={ 4L,3L,1L,4L,4L,3L,5L,4L,4L,9L,6L,7L,0L,4L,5L,5L,3L,5L,1L,5L,4L,8L,7L,4L,3L,8L,7L,5L,0L,8L,5L,5L,3L,8L,7L,3L,7L,0L,4L,0L,6L,2L,4L,5L,8L,7L,4L,9L,8L,9L,0L,5L,7L,9L,1L,2L,3L,4L,1L,6L,7L,7L,0L,1L,4L,7L,4L,5L,6L,6L,2L,6L,1L,3L,7L,5L,5L,8L,6L,7L,9L,6L,7L,4L,0L,5L,9L,6L,7L,0L,1L,4L,6L,0L,7L,2L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200490Inst : IEnumerable<long>
{
public static readonly long[] Value=A200490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200490.Bytes);
public long this[int i]=>Value[i];

public static A200490Inst Instance=new A200490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200491
{
public static readonly long[] Value={ 6L,6L,4L,5L,5L,1L,2L,2L,7L,8L,1L,8L,2L,3L,0L,7L,2L,6L,9L,1L,0L,9L,6L,1L,1L,8L,8L,5L,0L,3L,0L,0L,9L,0L,4L,0L,4L,0L,4L,2L,2L,4L,6L,0L,6L,8L,4L,7L,8L,8L,6L,3L,6L,4L,3L,0L,0L,1L,0L,8L,4L,6L,3L,0L,9L,1L,5L,4L,6L,8L,7L,6L,4L,8L,4L,6L,5L,6L,4L,9L,5L,5L,2L,9L,5L,1L,5L,6L,7L,6L,8L,1L,4L,6L,2L,7L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200491Inst : IEnumerable<long>
{
public static readonly long[] Value=A200491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200491.Bytes);
public long this[int i]=>Value[i];

public static A200491Inst Instance=new A200491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200492
{
public static readonly long[] Value={ 8L,8L,9L,4L,7L,3L,0L,3L,5L,0L,3L,2L,5L,9L,7L,1L,7L,8L,1L,5L,5L,7L,0L,1L,8L,7L,0L,7L,4L,5L,6L,3L,7L,6L,9L,1L,0L,5L,1L,7L,0L,4L,0L,1L,1L,5L,8L,6L,0L,5L,1L,0L,5L,5L,5L,0L,0L,2L,5L,3L,9L,4L,6L,0L,6L,1L,1L,3L,7L,1L,6L,0L,8L,0L,4L,0L,1L,4L,2L,4L,8L,2L,8L,2L,6L,5L,9L,5L,9L,1L,6L,3L,0L,3L,2L,2L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200492Inst : IEnumerable<long>
{
public static readonly long[] Value=A200492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200492.Bytes);
public long this[int i]=>Value[i];

public static A200492Inst Instance=new A200492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200493
{
public static readonly long[] Value={ 1L,2L,2L,5L,1L,1L,8L,4L,0L,4L,9L,0L,9L,9L,7L,7L,2L,0L,4L,2L,0L,6L,0L,6L,4L,4L,3L,2L,8L,8L,6L,9L,5L,7L,7L,6L,6L,2L,2L,5L,2L,6L,6L,8L,6L,3L,4L,4L,6L,4L,3L,9L,0L,1L,0L,8L,6L,0L,1L,8L,6L,6L,8L,2L,4L,7L,8L,0L,9L,8L,7L,9L,6L,0L,6L,9L,4L,2L,7L,0L,3L,1L,2L,9L,7L,5L,6L,7L,2L,6L,7L,1L,9L,9L,5L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200493Inst : IEnumerable<long>
{
public static readonly long[] Value=A200493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200493.Bytes);
public long this[int i]=>Value[i];

public static A200493Inst Instance=new A200493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200494
{
public static readonly long[] Value={ 1L,3L,3L,9L,7L,0L,0L,0L,0L,4L,3L,1L,9L,6L,5L,6L,6L,5L,2L,2L,4L,3L,8L,9L,3L,6L,5L,9L,7L,7L,1L,9L,6L,6L,6L,8L,3L,8L,2L,9L,0L,2L,2L,2L,2L,2L,9L,9L,7L,0L,2L,8L,0L,4L,8L,6L,2L,7L,9L,1L,2L,0L,2L,1L,5L,6L,3L,0L,4L,8L,4L,4L,0L,9L,4L,2L,2L,9L,1L,0L,4L,8L,0L,9L,8L,4L,6L,3L,3L,0L,1L,2L,7L,8L,1L,9L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200494Inst : IEnumerable<long>
{
public static readonly long[] Value=A200494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200494.Bytes);
public long this[int i]=>Value[i];

public static A200494Inst Instance=new A200494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200495
{
public static readonly long[] Value={ 1L,3L,9L,0L,1L,3L,3L,0L,5L,2L,8L,3L,3L,6L,3L,1L,7L,1L,4L,7L,9L,1L,9L,1L,2L,7L,1L,2L,3L,7L,5L,5L,7L,9L,9L,3L,8L,9L,3L,6L,5L,5L,0L,4L,9L,8L,4L,7L,7L,9L,0L,3L,9L,8L,9L,9L,1L,6L,0L,7L,4L,5L,1L,1L,4L,3L,6L,2L,7L,8L,7L,9L,3L,2L,9L,2L,9L,1L,7L,8L,9L,7L,8L,9L,6L,2L,8L,0L,0L,1L,8L,8L,1L,0L,5L,9L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200495Inst : IEnumerable<long>
{
public static readonly long[] Value=A200495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200495.Bytes);
public long this[int i]=>Value[i];

public static A200495Inst Instance=new A200495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200496
{
public static readonly long[] Value={ 1L,4L,2L,0L,7L,9L,4L,7L,4L,4L,8L,7L,9L,0L,2L,5L,8L,4L,9L,1L,8L,6L,2L,4L,8L,2L,4L,1L,8L,2L,3L,6L,9L,9L,1L,7L,2L,2L,9L,7L,1L,3L,2L,8L,3L,7L,8L,3L,4L,3L,4L,7L,2L,2L,4L,7L,5L,4L,9L,3L,0L,9L,0L,2L,8L,9L,6L,7L,5L,3L,0L,5L,9L,6L,9L,4L,4L,2L,2L,7L,3L,3L,2L,9L,6L,5L,8L,6L,6L,4L,2L,0L,3L,3L,6L,3L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200496Inst : IEnumerable<long>
{
public static readonly long[] Value=A200496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200496.Bytes);
public long this[int i]=>Value[i];

public static A200496Inst Instance=new A200496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200497
{
public static readonly long[] Value={ 4L,6L,5L,5L,4L,5L,2L,1L,5L,9L,7L,9L,7L,5L,5L,1L,3L,6L,9L,7L,8L,5L,6L,5L,8L,8L,3L,2L,1L,5L,8L,7L,7L,1L,4L,8L,5L,8L,7L,0L,5L,2L,3L,1L,4L,9L,5L,1L,7L,6L,6L,5L,9L,0L,6L,7L,6L,8L,7L,6L,8L,9L,1L,1L,0L,9L,3L,7L,2L,9L,9L,5L,7L,1L,3L,1L,9L,6L,8L,7L,7L,7L,8L,3L,8L,1L,5L,8L,4L,2L,5L,8L,0L,5L,9L,2L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200497Inst : IEnumerable<long>
{
public static readonly long[] Value=A200497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200497.Bytes);
public long this[int i]=>Value[i];

public static A200497Inst Instance=new A200497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200498
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,8L,1L,9L,3L,1L,8L,4L,0L,0L,9L,1L,9L,5L,4L,9L,5L,2L,3L,1L,4L,0L,8L,2L,6L,8L,7L,1L,0L,5L,5L,7L,9L,8L,3L,3L,0L,3L,0L,8L,0L,7L,4L,3L,8L,8L,4L,2L,4L,2L,2L,0L,8L,2L,0L,0L,7L,7L,6L,6L,0L,3L,9L,9L,0L,5L,4L,0L,6L,4L,7L,9L,8L,5L,8L,7L,4L,4L,6L,3L,7L,5L,7L,6L,2L,0L,8L,4L,2L,6L,7L,7L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200498Inst : IEnumerable<long>
{
public static readonly long[] Value=A200498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200498.Bytes);
public long this[int i]=>Value[i];

public static A200498Inst Instance=new A200498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200499
{
public static readonly long[] Value={ 2L,8L,9L,9L,2L,7L,3L,5L,6L,0L,6L,5L,5L,8L,9L,8L,9L,8L,2L,2L,0L,1L,4L,1L,6L,0L,2L,5L,9L,1L,1L,2L,0L,7L,7L,3L,9L,7L,5L,8L,2L,7L,3L,5L,5L,2L,9L,5L,2L,3L,0L,3L,9L,4L,6L,2L,2L,0L,6L,0L,3L,6L,2L,6L,3L,8L,7L,7L,3L,8L,5L,7L,7L,0L,0L,3L,8L,6L,5L,9L,6L,2L,3L,4L,9L,5L,5L,7L,6L,1L,2L,9L,2L,3L,0L,5L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200499Inst : IEnumerable<long>
{
public static readonly long[] Value=A200499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200499.Bytes);
public long this[int i]=>Value[i];

public static A200499Inst Instance=new A200499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200500
{
public static readonly long[] Value={ 7L,1L,9L,8L,5L,8L,2L,0L,2L,3L,9L,4L,7L,0L,8L,5L,8L,6L,2L,5L,0L,2L,1L,5L,6L,0L,9L,9L,6L,3L,7L,2L,0L,7L,2L,5L,6L,1L,7L,2L,3L,0L,4L,8L,5L,6L,2L,9L,8L,9L,7L,2L,5L,5L,2L,5L,4L,1L,5L,6L,5L,6L,7L,8L,9L,7L,5L,4L,1L,0L,6L,3L,8L,5L,9L,0L,3L,9L,5L,0L,4L,9L,0L,5L,0L,2L,0L,7L,6L,1L,5L,0L,0L,0L,5L,4L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200500Inst : IEnumerable<long>
{
public static readonly long[] Value=A200500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200500.Bytes);
public long this[int i]=>Value[i];

public static A200500Inst Instance=new A200500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200501
{
public static readonly long[] Value={ 1L,1L,4L,0L,7L,9L,4L,8L,9L,4L,5L,9L,0L,9L,1L,3L,3L,2L,8L,2L,5L,3L,3L,5L,3L,8L,0L,8L,0L,7L,1L,8L,8L,8L,3L,7L,1L,1L,4L,6L,5L,8L,3L,4L,0L,8L,2L,8L,7L,3L,5L,6L,7L,5L,7L,4L,8L,3L,4L,3L,0L,2L,5L,1L,0L,2L,7L,3L,9L,7L,7L,2L,7L,3L,2L,3L,2L,6L,8L,1L,0L,0L,5L,6L,5L,9L,4L,1L,6L,8L,0L,7L,2L,2L,1L,8L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200501Inst : IEnumerable<long>
{
public static readonly long[] Value=A200501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200501.Bytes);
public long this[int i]=>Value[i];

public static A200501Inst Instance=new A200501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200502
{
public static readonly long[] Value={ 1L,2L,8L,9L,1L,6L,8L,1L,2L,5L,3L,8L,3L,7L,6L,0L,4L,2L,4L,9L,4L,2L,1L,5L,1L,4L,6L,1L,2L,0L,8L,9L,2L,5L,2L,2L,4L,6L,2L,9L,6L,0L,6L,6L,0L,9L,7L,2L,0L,5L,0L,6L,8L,8L,1L,4L,8L,4L,0L,6L,8L,8L,5L,1L,4L,1L,3L,3L,1L,7L,6L,6L,9L,5L,7L,8L,1L,7L,7L,7L,3L,4L,4L,5L,6L,9L,9L,0L,5L,9L,6L,1L,3L,5L,5L,0L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200502Inst : IEnumerable<long>
{
public static readonly long[] Value=A200502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200502.Bytes);
public long this[int i]=>Value[i];

public static A200502Inst Instance=new A200502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200503
{
public static readonly long[] Value={ 90L,15960L,24360L,1047480L,2605680L,2856000L,3605070L,4438560L,5268900L,17958150L,21955290L,23910600L,37284660L,40198200L,62438460L,64094520L,66134250L,70590030L,77649390L,83360970L,90070470L,93143820L,98228130L,117164040L,131312160L,151078830L,154904820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200503Inst : IEnumerable<long>
{
public static readonly long[] Value=A200503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200503.Bytes);
public long this[int i]=>Value[i];

public static A200503Inst Instance=new A200503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200504
{
public static readonly long[] Value={ 7L,97L,19417L,43777L,3400207L,11664547L,37055647L,82984537L,89483827L,94752727L,381674467L,1569747997L,2019957337L,5892947647L,6797589427L,14048370097L,23438578897L,24649559647L,29637700987L,29869155847L,45555183127L,52993564567L,58430706067L,93378527647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200504Inst : IEnumerable<long>
{
public static readonly long[] Value=A200504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200504.Bytes);
public long this[int i]=>Value[i];

public static A200504Inst Instance=new A200504Inst();

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