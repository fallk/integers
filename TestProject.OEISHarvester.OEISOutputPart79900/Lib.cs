using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A099541
{
public static readonly long[] Value={ 1L,5L,9L,16L,18L,27L,35L,43L,48L,56L,60L,69L,73L,73L,73L,74L,81L,85L,86L,90L,93L,97L,99L,106L,109L,114L,115L,118L,123L,126L,126L,131L,139L,146L,147L,148L,154L,158L,165L,167L,176L,180L,188L,189L,191L,200L,201L,206L,209L,210L,211L,216L,223L,224L,229L,230L,233L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099541Inst : IEnumerable<long>
{
public static readonly long[] Value=A099541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099541.Bytes);
public long this[int i]=>Value[i];

public static A099541Inst Instance=new A099541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099542
{
public static readonly long[] Value={ 1568L,2835L,4752L,5265L,5439L,5664L,5824L,5832L,8526L,12985L,15625L,15698L,19435L,25284L,25662L,33475L,34935L,35581L,45951L,47265L,47594L,52374L,53176L,53742L,54479L,55272L,56356L,56718L,95232L,118465L,133857L,148653L,154462L,161785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099542Inst : IEnumerable<long>
{
public static readonly long[] Value=A099542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099542.Bytes);
public long this[int i]=>Value[i];

public static A099542Inst Instance=new A099542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099543
{
public static readonly long[] Value={ 24L,24L,28L,30L,54L,72L,32L,24L,48L,72L,30L,216L,54L,64L,72L,126L,162L,60L,90L,168L,504L,84L,63L,84L,504L,70L,270L,168L,54L,96L,252L,288L,96L,168L,343L,784L,96L,216L,405L,96L,324L,108L,48L,1260L,160L,144L,192L,1134L,243L,252L,1080L,72L,192L,144L,486L,81L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099543Inst : IEnumerable<long>
{
public static readonly long[] Value=A099543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099543.Bytes);
public long this[int i]=>Value[i];

public static A099543Inst Instance=new A099543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099544
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L,1L,2L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,2L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L,1L,2L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L,1L,2L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,2L,0L,2L,2L,0L,1L,1L,0L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099544Inst : IEnumerable<long>
{
public static readonly long[] Value=A099544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099544.Bytes);
public long this[int i]=>Value[i];

public static A099544Inst Instance=new A099544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099545
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099545Inst : IEnumerable<long>
{
public static readonly long[] Value=A099545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099545.Bytes);
public long this[int i]=>Value[i];

public static A099545Inst Instance=new A099545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099546
{
public static readonly long[] Value={ 1L,1L,3L,1L,0L,3L,2L,1L,4L,0L,1L,3L,3L,2L,0L,1L,2L,4L,4L,0L,1L,1L,3L,3L,0L,3L,2L,2L,4L,0L,1L,1L,3L,2L,0L,4L,2L,4L,4L,0L,1L,1L,3L,1L,0L,3L,2L,3L,4L,0L,1L,3L,3L,2L,0L,2L,2L,4L,4L,0L,1L,1L,3L,1L,0L,3L,2L,2L,4L,0L,1L,4L,3L,2L,0L,4L,2L,4L,4L,0L,1L,1L,3L,1L,0L,3L,2L,1L,4L,0L,1L,3L,3L,2L,0L,3L,2L,4L,4L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099546Inst : IEnumerable<long>
{
public static readonly long[] Value=A099546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099546.Bytes);
public long this[int i]=>Value[i];

public static A099546Inst Instance=new A099546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099547
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L,1L,5L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,5L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L,1L,1L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L,1L,5L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L,1L,5L,3L,5L,5L,3L,1L,1L,3L,5L,5L,3L,1L,5L,3L,5L,5L,3L,1L,1L,3L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099547Inst : IEnumerable<long>
{
public static readonly long[] Value=A099547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099547.Bytes);
public long this[int i]=>Value[i];

public static A099547Inst Instance=new A099547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099548
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,0L,1L,2L,5L,4L,3L,6L,0L,1L,1L,3L,2L,5L,5L,0L,4L,2L,3L,4L,6L,6L,0L,1L,1L,3L,1L,5L,3L,0L,2L,2L,5L,4L,5L,6L,0L,1L,4L,3L,2L,5L,3L,0L,4L,2L,6L,4L,6L,6L,0L,1L,1L,3L,1L,5L,3L,0L,1L,2L,5L,4L,3L,6L,0L,1L,2L,3L,2L,5L,5L,0L,4L,2L,5L,4L,6L,6L,0L,1L,1L,3L,4L,5L,3L,0L,2L,2L,5L,4L,3L,6L,0L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099548Inst : IEnumerable<long>
{
public static readonly long[] Value=A099548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099548.Bytes);
public long this[int i]=>Value[i];

public static A099548Inst Instance=new A099548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099549
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,1L,5L,3L,3L,5L,7L,7L,1L,1L,1L,3L,5L,5L,3L,7L,3L,1L,5L,3L,7L,5L,7L,7L,1L,1L,1L,3L,1L,5L,3L,7L,5L,1L,5L,3L,3L,5L,7L,7L,3L,1L,1L,3L,5L,5L,3L,7L,7L,1L,5L,3L,7L,5L,7L,7L,1L,1L,1L,3L,1L,5L,3L,7L,1L,1L,5L,3L,3L,5L,7L,7L,5L,1L,1L,3L,5L,5L,3L,7L,3L,1L,5L,3L,7L,5L,7L,7L,3L,1L,1L,3L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099549Inst : IEnumerable<long>
{
public static readonly long[] Value=A099549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099549.Bytes);
public long this[int i]=>Value[i];

public static A099549Inst Instance=new A099549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099550
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,0L,5L,2L,3L,4L,7L,6L,1L,8L,0L,1L,5L,3L,2L,5L,3L,7L,4L,0L,7L,2L,6L,4L,1L,6L,8L,8L,0L,1L,1L,3L,5L,5L,3L,7L,2L,0L,5L,2L,3L,4L,7L,6L,4L,8L,0L,1L,7L,3L,2L,5L,6L,7L,4L,0L,1L,2L,6L,4L,8L,6L,8L,8L,0L,1L,1L,3L,1L,5L,3L,7L,5L,0L,5L,2L,3L,4L,7L,6L,2L,8L,0L,1L,5L,3L,2L,5L,3L,7L,4L,0L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099550Inst : IEnumerable<long>
{
public static readonly long[] Value=A099550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099550.Bytes);
public long this[int i]=>Value[i];

public static A099550Inst Instance=new A099550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099551
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,1L,3L,3L,7L,5L,1L,7L,9L,9L,5L,1L,1L,3L,3L,5L,3L,7L,7L,9L,5L,1L,1L,3L,7L,5L,9L,7L,9L,9L,5L,1L,1L,3L,1L,5L,3L,7L,3L,9L,5L,1L,3L,3L,7L,5L,7L,7L,9L,9L,5L,1L,1L,3L,1L,5L,3L,7L,7L,9L,5L,1L,9L,3L,7L,5L,9L,7L,9L,9L,5L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,1L,3L,3L,7L,5L,3L,7L,9L,9L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099551Inst : IEnumerable<long>
{
public static readonly long[] Value=A099551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099551.Bytes);
public long this[int i]=>Value[i];

public static A099551Inst Instance=new A099551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099552
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,5L,6L,1L,10L,2L,12L,5L,14L,5L,6L,8L,10L,15L,20L,7L,6L,18L,24L,25L,6L,32L,32L,3L,10L,1L,12L,41L,34L,5L,6L,8L,46L,33L,20L,34L,36L,21L,24L,30L,36L,36L,48L,23L,50L,56L,44L,34L,42L,30L,48L,9L,26L,4L,60L,44L,34L,33L,60L,65L,28L,16L,32L,66L,20L,29L,44L,78L,48L,75L,52L,9L,8L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099552Inst : IEnumerable<long>
{
public static readonly long[] Value=A099552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099552.Bytes);
public long this[int i]=>Value[i];

public static A099552Inst Instance=new A099552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099553
{
public static readonly long[] Value={ 1L,2L,10L,42L,209L,1066L,5726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099553Inst : IEnumerable<long>
{
public static readonly long[] Value=A099553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099553.Bytes);
public long this[int i]=>Value[i];

public static A099553Inst Instance=new A099553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099554
{
public static readonly long[] Value={ 2L,0L,2L,0L,7L,4L,7L,3L,5L,8L,6L,1L,1L,8L,5L,7L,6L,6L,8L,1L,1L,2L,6L,9L,5L,2L,8L,7L,2L,4L,7L,3L,2L,3L,6L,6L,4L,9L,9L,4L,3L,3L,1L,1L,3L,1L,4L,1L,6L,2L,5L,2L,9L,8L,9L,7L,3L,1L,7L,1L,1L,6L,0L,8L,2L,6L,9L,2L,8L,5L,7L,7L,0L,0L,8L,5L,3L,6L,0L,5L,7L,4L,4L,4L,0L,7L,9L,5L,0L,5L,7L,3L,5L,5L,2L,9L,6L,1L,1L,6L,9L,3L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099554Inst : IEnumerable<long>
{
public static readonly long[] Value=A099554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099554.Bytes);
public long this[int i]=>Value[i];

public static A099554Inst Instance=new A099554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099555
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,4L,8L,1L,1L,1L,4L,9L,27L,16L,32L,1L,1L,1L,5L,16L,64L,81L,243L,64L,128L,1L,1L,1L,6L,25L,125L,256L,1024L,729L,2187L,256L,512L,1L,1L,1L,7L,36L,216L,625L,3125L,4096L,16384L,6561L,19683L,1024L,2048L,1L,1L,1L,8L,49L,343L,1296L,7776L,15625L,78125L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099555Inst : IEnumerable<long>
{
public static readonly long[] Value=A099555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099555.Bytes);
public long this[int i]=>Value[i];

public static A099555Inst Instance=new A099555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099556
{
public static readonly BigInteger[] Value={ 1L,2L,5L,18L,91L,604L,5123L,53808L,679389L,10107934L,174544505L,3451802006L,77302457077L,1942469215378L,54339334896457L,1680597905918398L,57116435365152501L,2121725699286935222L,BigInteger.Parse("85740960693607190593") };
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
public class A099556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099556Inst Instance=new A099556Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099557
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,3L,1L,0L,1L,4L,3L,1L,0L,1L,5L,6L,4L,0L,0L,1L,6L,10L,10L,1L,0L,0L,1L,7L,15L,20L,5L,1L,0L,0L,1L,8L,21L,35L,15L,6L,0L,0L,0L,1L,9L,28L,56L,35L,21L,1L,0L,0L,0L,1L,10L,36L,84L,70L,56L,7L,1L,0L,0L,0L,1L,11L,45L,120L,126L,126L,28L,8L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099557Inst : IEnumerable<long>
{
public static readonly long[] Value=A099557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099557.Bytes);
public long this[int i]=>Value[i];

public static A099557Inst Instance=new A099557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099558
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,14L,22L,34L,52L,79L,120L,183L,280L,429L,657L,1005L,1536L,2347L,3587L,5484L,8386L,12824L,19609L,29981L,45837L,70079L,107145L,163820L,250476L,382969L,585541L,895258L,1368795L,2092808L,3199790L,4892313L,7480094L,11436670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099558Inst : IEnumerable<long>
{
public static readonly long[] Value=A099558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099558.Bytes);
public long this[int i]=>Value[i];

public static A099558Inst Instance=new A099558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099559
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,10L,14L,19L,25L,33L,44L,59L,79L,105L,139L,184L,244L,324L,430L,570L,755L,1000L,1325L,1756L,2327L,3083L,4084L,5410L,7167L,9495L,12579L,16664L,22075L,29243L,38739L,51319L,67984L,90060L,119304L,158044L,209364L,277349L,367410L,486715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099559Inst : IEnumerable<long>
{
public static readonly long[] Value=A099559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099559.Bytes);
public long this[int i]=>Value[i];

public static A099559Inst Instance=new A099559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099560
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,3L,4L,5L,9L,13L,18L,28L,41L,59L,88L,129L,188L,277L,406L,594L,872L,1278L,1872L,2745L,4023L,5895L,8641L,12664L,18559L,27201L,39865L,58424L,85626L,125491L,183915L,269542L,395033L,578948L,848491L,1243524L,1822472L,2670964L,3914488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099560Inst : IEnumerable<long>
{
public static readonly long[] Value=A099560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099560.Bytes);
public long this[int i]=>Value[i];

public static A099560Inst Instance=new A099560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099561
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,3L,4L,5L,6L,10L,14L,19L,25L,36L,50L,69L,94L,131L,181L,250L,344L,476L,657L,907L,1251L,1728L,2385L,3292L,4543L,6272L,8657L,11949L,16492L,22765L,31422L,43371L,59863L,82629L,114051L,157422L,217285L,299915L,413966L,571388L,788673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099561Inst : IEnumerable<long>
{
public static readonly long[] Value=A099561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099561.Bytes);
public long this[int i]=>Value[i];

public static A099561Inst Instance=new A099561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099562
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,3L,4L,5L,6L,7L,11L,15L,20L,26L,33L,45L,60L,80L,106L,139L,185L,245L,325L,431L,570L,756L,1001L,1326L,1757L,2327L,3084L,4085L,5411L,7168L,9495L,12580L,16665L,22076L,29244L,38739L,51320L,67985L,90061L,119305L,158044L,209365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099562Inst : IEnumerable<long>
{
public static readonly long[] Value=A099562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099562.Bytes);
public long this[int i]=>Value[i];

public static A099562Inst Instance=new A099562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099563
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099563Inst : IEnumerable<long>
{
public static readonly long[] Value=A099563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099563.Bytes);
public long this[int i]=>Value[i];

public static A099563Inst Instance=new A099563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099564
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099564Inst : IEnumerable<long>
{
public static readonly long[] Value=A099564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099564.Bytes);
public long this[int i]=>Value[i];

public static A099564Inst Instance=new A099564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099565
{
public static readonly long[] Value={ 1L,4L,18L,24L,150L,180L,210L,1920L,2160L,2400L,2640L,2880L,40560L,43680L,46800L,49920L,53040L,56160L,59280L,62400L,1375920L,1441440L,1506960L,1572480L,1638000L,1703520L,1769040L,1834560L,1900080L,1965600L,2031120L,2096640L,2162160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099565Inst : IEnumerable<long>
{
public static readonly long[] Value=A099565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099565.Bytes);
public long this[int i]=>Value[i];

public static A099565Inst Instance=new A099565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099566
{
public static readonly long[] Value={ 1L,2L,6L,6L,30L,30L,30L,240L,240L,240L,240L,240L,3120L,3120L,3120L,3120L,3120L,3120L,3120L,3120L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L,65520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099566Inst : IEnumerable<long>
{
public static readonly long[] Value=A099566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099566.Bytes);
public long this[int i]=>Value[i];

public static A099566Inst Instance=new A099566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099567
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,1L,3L,5L,6L,4L,1L,4L,8L,11L,10L,5L,1L,6L,12L,19L,21L,15L,6L,1L,9L,18L,31L,40L,36L,21L,7L,1L,13L,27L,49L,71L,76L,57L,28L,8L,1L,19L,40L,76L,120L,147L,133L,85L,36L,9L,1L,28L,59L,116L,196L,267L,280L,218L,121L,45L,10L,1L,41L,87L,175L,312L,463L,547L,498L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099567Inst : IEnumerable<long>
{
public static readonly long[] Value=A099567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099567.Bytes);
public long this[int i]=>Value[i];

public static A099567Inst Instance=new A099567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099568
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,39L,80L,163L,330L,666L,1341L,2695L,5409L,10846L,21733L,43526L,87140L,174409L,349007L,698291L,1396988L,2794571L,5590014L,11181306L,22364485L,44731715L,89467453L,178940802L,357890245L,715793154L,1431604868L,2863236937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099568Inst : IEnumerable<long>
{
public static readonly long[] Value=A099568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099568.Bytes);
public long this[int i]=>Value[i];

public static A099568Inst Instance=new A099568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099569
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-2L,3L,-3L,1L,4L,-5L,6L,-4L,1L,-7L,9L,-11L,10L,-5L,1L,11L,-16L,20L,-21L,15L,-6L,1L,-16L,27L,-36L,41L,-36L,21L,-7L,1L,22L,-43L,63L,-77L,77L,-57L,28L,-8L,1L,-29L,65L,-106L,140L,-154L,134L,-85L,36L,-9L,1L,37L,-94L,171L,-246L,294L,-288L,219L,-121L,45L,-10L,1L,-46L,131L,-265L,417L,-540L,582L,-507L,340L,-166L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099569Inst : IEnumerable<long>
{
public static readonly long[] Value=A099569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099569.Bytes);
public long this[int i]=>Value[i];

public static A099569Inst Instance=new A099569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099570
{
public static readonly long[] Value={ 1L,0L,0L,-1L,2L,-3L,4L,-5L,6L,-7L,8L,-9L,10L,-11L,12L,-13L,14L,-15L,16L,-17L,18L,-19L,20L,-21L,22L,-23L,24L,-25L,26L,-27L,28L,-29L,30L,-31L,32L,-33L,34L,-35L,36L,-37L,38L,-39L,40L,-41L,42L,-43L,44L,-45L,46L,-47L,48L,-49L,50L,-51L,52L,-53L,54L,-55L,56L,-57L,58L,-59L,60L,-61L,62L,-63L,64L,-65L,66L,-67L,68L,-69L,70L,-71L,72L,-73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099570Inst : IEnumerable<long>
{
public static readonly long[] Value=A099570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099570.Bytes);
public long this[int i]=>Value[i];

public static A099570Inst Instance=new A099570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099571
{
public static readonly long[] Value={ 1L,1L,5L,6L,17L,23L,50L,73L,138L,211L,370L,581L,979L,1560L,2575L,4135L,6755L,10890L,17700L,28590L,46356L,74946L,121380L,196326L,317797L,514123L,832025L,1346148L,2178293L,3524441L,5702870L,9227311L,14930334L,24157645L,39088150L,63245795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099571Inst : IEnumerable<long>
{
public static readonly long[] Value=A099571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099571.Bytes);
public long this[int i]=>Value[i];

public static A099571Inst Instance=new A099571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099572
{
public static readonly long[] Value={ 1L,1L,6L,7L,23L,30L,73L,103L,211L,314L,581L,895L,1560L,2455L,4135L,6590L,10890L,17480L,28590L,46070L,74946L,121016L,196326L,317342L,514123L,831465L,1346148L,2177613L,3524441L,5702054L,9227311L,14929365L,24157645L,39087010L,63245795L,102332805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099572Inst : IEnumerable<long>
{
public static readonly long[] Value=A099572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099572.Bytes);
public long this[int i]=>Value[i];

public static A099572Inst Instance=new A099572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099573
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,4L,5L,1L,1L,5L,5L,8L,8L,1L,1L,6L,6L,12L,12L,13L,1L,1L,7L,7L,17L,17L,21L,21L,1L,1L,8L,8L,23L,23L,33L,33L,34L,1L,1L,9L,9L,30L,30L,50L,50L,55L,55L,1L,1L,10L,10L,38L,38L,73L,73L,88L,88L,89L,1L,1L,11L,11L,47L,47L,103L,103L,138L,138L,144L,144L,1L,1L,12L,12L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099573Inst : IEnumerable<long>
{
public static readonly long[] Value=A099573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099573.Bytes);
public long this[int i]=>Value[i];

public static A099573Inst Instance=new A099573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099574
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,9L,11L,18L,23L,37L,48L,74L,97L,147L,195L,290L,387L,568L,763L,1108L,1495L,2152L,2915L,4167L,5662L,8047L,10962L,15506L,21168L,29825L,40787L,57280L,78448L,109870L,150657L,210521L,288969L,403020L,553677L,770963L,1059932L,1473898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099574Inst : IEnumerable<long>
{
public static readonly long[] Value=A099574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099574.Bytes);
public long this[int i]=>Value[i];

public static A099574Inst Instance=new A099574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099575
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,5L,5L,1L,1L,6L,6L,21L,1L,1L,7L,7L,28L,28L,1L,1L,8L,8L,36L,36L,120L,1L,1L,9L,9L,45L,45L,165L,165L,1L,1L,10L,10L,55L,55L,220L,220L,715L,1L,1L,11L,11L,66L,66L,286L,286L,1001L,1001L,1L,1L,12L,12L,78L,78L,364L,364L,1365L,1365L,4368L,1L,1L,13L,13L,91L,91L,455L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099575Inst : IEnumerable<long>
{
public static readonly long[] Value=A099575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099575.Bytes);
public long this[int i]=>Value[i];

public static A099575Inst Instance=new A099575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099576
{
public static readonly long[] Value={ 1L,2L,6L,12L,35L,72L,210L,440L,1287L,2730L,8008L,17136L,50388L,108528L,319770L,692208L,2042975L,4440150L,13123110L,28614300L,84672315L,185122080L,548354040L,1201610592L,3562467300L,7821594872L,23206929840L,51037462560L,151532656696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099576Inst : IEnumerable<long>
{
public static readonly long[] Value=A099576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099576.Bytes);
public long this[int i]=>Value[i];

public static A099576Inst Instance=new A099576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099577
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,7L,13L,15L,38L,47L,85L,104L,245L,313L,558L,706L,1594L,2080L,3674L,4753L,10429L,13817L,24246L,31875L,68497L,91804L,160301L,213345L,451166L,610247L,1061413L,1426503L,2978230L,4058629L,7036859L,9533213L,19694622L,27007760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099577Inst : IEnumerable<long>
{
public static readonly long[] Value=A099577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099577.Bytes);
public long this[int i]=>Value[i];

public static A099577Inst Instance=new A099577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099578
{
public static readonly long[] Value={ 1L,1L,4L,5L,21L,28L,120L,165L,715L,1001L,4368L,6188L,27132L,38760L,170544L,245157L,1081575L,1562275L,6906900L,10015005L,44352165L,64512240L,286097760L,417225900L,1852482996L,2707475148L,12033222880L,17620076360L,78378960360L,114955808528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099578Inst : IEnumerable<long>
{
public static readonly long[] Value=A099578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099578.Bytes);
public long this[int i]=>Value[i];

public static A099578Inst Instance=new A099578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099579
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,10L,40L,70L,217L,427L,1159L,2440L,6160L,13480L,32689L,73129L,173383L,392770L,919480L,2097790L,4875913L,11169283L,25856071L,59363920L,137109280L,315201040L,727060321L,1672663441L,3855438727L,8873429050L,20444528200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099579Inst : IEnumerable<long>
{
public static readonly long[] Value=A099579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099579.Bytes);
public long this[int i]=>Value[i];

public static A099579Inst Instance=new A099579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099580
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,13L,65L,117L,441L,909L,2929L,6565L,19305L,45565L,126881L,309141L,833049L,2069613L,5467345L,13745797L,35877321L,90860509L,235418369L,598860405L,1544728185L,3940169805L,10135859761L,25896538981L,66507086889L,170093242813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099580Inst : IEnumerable<long>
{
public static readonly long[] Value=A099580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099580.Bytes);
public long this[int i]=>Value[i];

public static A099580Inst Instance=new A099580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099581
{
public static readonly long[] Value={ 0L,0L,1L,3L,15L,54L,216L,810L,3105L,11745L,44631L,169128L,641520L,2431944L,9221121L,34959195L,132543135L,502506990L,1905156936L,7222991778L,27384465825L,103822372809L,393620574951L,1492328843280L,5657848431840L,21450531825360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099581Inst : IEnumerable<long>
{
public static readonly long[] Value=A099581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099581.Bytes);
public long this[int i]=>Value[i];

public static A099581Inst Instance=new A099581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099582
{
public static readonly long[] Value={ 0L,0L,1L,4L,24L,112L,560L,2688L,13056L,62976L,304384L,1469440L,7096320L,34263040L,165441536L,798818304L,3857055744L,18623496192L,89922273280L,434183077888L,2096421666816L,10122418978816L,48875363631104L,235991130439680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099582Inst : IEnumerable<long>
{
public static readonly long[] Value=A099582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099582.Bytes);
public long this[int i]=>Value[i];

public static A099582Inst Instance=new A099582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099583
{
public static readonly long[] Value={ 0L,0L,1L,2L,10L,26L,91L,260L,820L,2420L,7381L,22022L,66430L,198926L,597871L,1792520L,5380840L,16139240L,48427561L,145272842L,435848050L,1307514626L,3922632451L,11767808780L,35303692060L,105910810460L,317733228541L,953198888462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099583Inst : IEnumerable<long>
{
public static readonly long[] Value=A099583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099583.Bytes);
public long this[int i]=>Value[i];

public static A099583Inst Instance=new A099583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099584
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,1L,2L,0L,1L,0L,0L,0L,1L,1L,0L,2L,1L,0L,0L,1L,0L,1L,0L,3L,0L,2L,0L,0L,1L,0L,1L,1L,4L,0L,0L,0L,2L,0L,1L,0L,2L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,3L,1L,0L,1L,0L,2L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,3L,0L,0L,2L,0L,1L,0L,1L,0L,3L,1L,0L,0L,1L,0L,1L,0L,0L,5L,0L,1L,0L,0L,0L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099584Inst : IEnumerable<long>
{
public static readonly long[] Value=A099584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099584.Bytes);
public long this[int i]=>Value[i];

public static A099584Inst Instance=new A099584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099585
{
public static readonly long[] Value={ 1L,2L,4L,2L,10L,4L,16L,2L,22L,28L,10L,4L,40L,14L,46L,52L,58L,20L,22L,70L,8L,26L,82L,88L,32L,100L,34L,106L,4L,112L,14L,130L,136L,46L,148L,50L,52L,2L,166L,172L,178L,20L,190L,64L,196L,22L,70L,74L,226L,76L,232L,238L,80L,250L,256L,262L,268L,10L,92L,280L,94L,292L,34L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099585Inst : IEnumerable<long>
{
public static readonly long[] Value=A099585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099585.Bytes);
public long this[int i]=>Value[i];

public static A099585Inst Instance=new A099585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099586
{
public static readonly long[] Value={ 1L,1L,1L,0L,-4L,-14L,-34L,-68L,-116L,-164L,-164L,0L,560L,1912L,4616L,9232L,15760L,22288L,22288L,0L,-76096L,-259808L,-627232L,-1254464L,-2141504L,-3028544L,-3028544L,0L,10340096L,35303296L,85229696L,170459392L,290992384L,411525376L,411525376L,0L,-1405035520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099586Inst : IEnumerable<long>
{
public static readonly long[] Value=A099586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099586.Bytes);
public long this[int i]=>Value[i];

public static A099586Inst Instance=new A099586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099587
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,0L,-14L,-48L,-116L,-232L,-396L,-560L,-560L,0L,1912L,6528L,15760L,31520L,53808L,76096L,76096L,0L,-259808L,-887040L,-2141504L,-4283008L,-7311552L,-10340096L,-10340096L,0L,35303296L,120532992L,290992384L,581984768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099587Inst : IEnumerable<long>
{
public static readonly long[] Value=A099587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099587.Bytes);
public long this[int i]=>Value[i];

public static A099587Inst Instance=new A099587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099588
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,10L,14L,14L,0L,-48L,-164L,-396L,-792L,-1352L,-1912L,-1912L,0L,6528L,22288L,53808L,107616L,183712L,259808L,259808L,0L,-887040L,-3028544L,-7311552L,-14623104L,-24963200L,-35303296L,-35303296L,0L,120532992L,411525376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099588Inst : IEnumerable<long>
{
public static readonly long[] Value=A099588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099588.Bytes);
public long this[int i]=>Value[i];

public static A099588Inst Instance=new A099588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099589
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,10L,20L,34L,48L,48L,0L,-164L,-560L,-1352L,-2704L,-4616L,-6528L,-6528L,0L,22288L,76096L,183712L,367424L,627232L,887040L,887040L,0L,-3028544L,-10340096L,-24963200L,-49926400L,-85229696L,-120532992L,-120532992L,0L,411525376L,1405035520L,3392055808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099589Inst : IEnumerable<long>
{
public static readonly long[] Value=A099589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099589.Bytes);
public long this[int i]=>Value[i];

public static A099589Inst Instance=new A099589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099590
{
public static readonly long[] Value={ 0L,4L,14L,32L,77L,192L,452L,1024L,2299L,5120L,11270L,24576L,53241L,114688L,245768L,524288L,1114103L,2359296L,4980746L,10485760L,22020085L,46137344L,96469004L,201326592L,419430387L,872415232L,1811939342L,3758096384L,7784628209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099590Inst : IEnumerable<long>
{
public static readonly long[] Value=A099590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099590.Bytes);
public long this[int i]=>Value[i];

public static A099590Inst Instance=new A099590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099591
{
public static readonly long[] Value={ 47L,62L,63L,77L,78L,79L,127L,142L,143L,157L,158L,159L,207L,222L,223L,237L,238L,239L,287L,302L,303L,317L,318L,319L,367L,382L,383L,397L,398L,399L,447L,462L,463L,477L,478L,479L,527L,542L,543L,557L,558L,559L,607L,622L,623L,687L,702L,703L,752L,767L,782L,783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099591Inst : IEnumerable<long>
{
public static readonly long[] Value=A099591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099591.Bytes);
public long this[int i]=>Value[i];

public static A099591Inst Instance=new A099591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099592
{
public static readonly long[] Value={ 1260L,330L,210L,120L,90L,78L,66L,60L,60L,60L,42L,42L,42L,42L,42L,42L,42L,42L,42L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099592Inst : IEnumerable<long>
{
public static readonly long[] Value=A099592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099592.Bytes);
public long this[int i]=>Value[i];

public static A099592Inst Instance=new A099592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099593
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,9L,11L,12L,13L,15L,16L,17L,18L,21L,22L,24L,25L,27L,28L,29L,30L,32L,34L,35L,37L,39L,40L,41L,42L,44L,45L,46L,47L,51L,52L,53L,54L,56L,57L,58L,59L,61L,63L,64L,65L,68L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,84L,86L,87L,88L,90L,94L,95L,96L,97L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099593Inst : IEnumerable<long>
{
public static readonly long[] Value=A099593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099593.Bytes);
public long this[int i]=>Value[i];

public static A099593Inst Instance=new A099593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099594
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,14L,8L,1L,1L,16L,46L,46L,16L,1L,1L,32L,146L,230L,146L,32L,1L,1L,64L,454L,1066L,1066L,454L,64L,1L,1L,128L,1394L,4718L,6902L,4718L,1394L,128L,1L,1L,256L,4246L,20266L,41506L,41506L,20266L,4246L,256L,1L,1L,512L,12866L,85310L,237686L,329462L,237686L,85310L,12866L,512L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099594Inst : IEnumerable<long>
{
public static readonly long[] Value=A099594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099594.Bytes);
public long this[int i]=>Value[i];

public static A099594Inst Instance=new A099594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099595
{
public static readonly long[] Value={ 1L,6L,370L,25941L,766167L,12111089L,124259069L,930574233L,5484818300L,26776879826L,112280445305L,415327028116L,1382930259679L,4210626581064L,11869191180654L,31287023072875L,77754009678155L,183413881787587L,412999556427123L,891974451978733L,1855294967497534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099595Inst : IEnumerable<long>
{
public static readonly long[] Value=A099595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099595.Bytes);
public long this[int i]=>Value[i];

public static A099595Inst Instance=new A099595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099596
{
public static readonly long[] Value={ 3L,5L,11L,17L,23L,47L,59L,83L,107L,137L,167L,179L,227L,239L,257L,263L,317L,347L,359L,383L,431L,443L,467L,479L,503L,557L,563L,587L,647L,659L,719L,797L,827L,839L,857L,863L,887L,983L,1019L,1091L,1097L,1187L,1223L,1259L,1283L,1307L,1319L,1367L,1439L,1487L,1499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099596Inst : IEnumerable<long>
{
public static readonly long[] Value=A099596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099596.Bytes);
public long this[int i]=>Value[i];

public static A099596Inst Instance=new A099596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099597
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,9L,4L,1L,1L,5L,19L,19L,5L,1L,1L,6L,33L,82L,33L,6L,1L,1L,7L,51L,229L,229L,51L,7L,1L,1L,8L,73L,496L,1313L,496L,73L,8L,1L,1L,9L,99L,919L,4581L,4581L,919L,99L,9L,1L,1L,10L,129L,1534L,11905L,32826L,11905L,1534L,129L,10L,1L,1L,11L,163L,2377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099597Inst : IEnumerable<long>
{
public static readonly long[] Value=A099597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099597.Bytes);
public long this[int i]=>Value[i];

public static A099597Inst Instance=new A099597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099598
{
public static readonly long[] Value={ 1L,2L,4L,8L,19L,50L,162L,576L,2469L,11218L,59984L,331432L,2120663L,13784290L,102616622L,766648128L,6507054537L,54919451490L,523342287196L,4923469621256L,52040350449307L,539901936037202L,6268123599148282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099598Inst : IEnumerable<long>
{
public static readonly long[] Value=A099598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099598.Bytes);
public long this[int i]=>Value[i];

public static A099598Inst Instance=new A099598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099599
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,9L,-12L,6L,1L,-104L,204L,-120L,24L,1L,2265L,-4840L,3540L,-1080L,120L,1L,-71064L,164910L,-138840L,54360L,-10080L,720L,1L,3079825L,-7626948L,7134330L,-3300360L,808920L,-100800L,5040L,1L,-176449776L,460982648L,-468313104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099599Inst : IEnumerable<long>
{
public static readonly long[] Value=A099599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099599.Bytes);
public long this[int i]=>Value[i];

public static A099599Inst Instance=new A099599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099600
{
public static readonly long[] Value={ 0L,0L,33333333333L,97777777778L,188000000000L,296266666667L,413555555556L,530844444444L,640314074074L,736230320988L,815361224691L,876907483128L,922041405981L,953224843588L,973494078033L,985863508285L,992931754142L,996701485266L,998570643615L,999428257446L,999790361064L,999930120355L,999979036106L,999994409628L,999998695580L,999999739116L,999999956519L,999999994203L,999999999420L,999999999961L,999999999999L,1000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099600Inst : IEnumerable<long>
{
public static readonly long[] Value=A099600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099600.Bytes);
public long this[int i]=>Value[i];

public static A099600Inst Instance=new A099600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099601
{
public static readonly BigInteger[] Value={ 1L,7L,131L,3067L,79459L,2181257L,62165039L,1818812387L,54257991011L,1642977121597L,50344383988381L,1557608560147757L,48577698917598031L,1525245771206644117L,BigInteger.Parse("48165918788138198759"),BigInteger.Parse("1528611371067309862067") };
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
public class A099601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099601Inst Instance=new A099601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099602
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,5L,4L,1L,1L,5L,8L,5L,1L,3L,13L,22L,18L,7L,1L,1L,9L,26L,35L,24L,8L,1L,4L,26L,70L,101L,84L,40L,10L,1L,1L,14L,61L,131L,160L,116L,49L,11L,1L,5L,45L,171L,363L,476L,400L,215L,71L,13L,1L,1L,20L,120L,363L,654L,752L,565L,275L,83L,14L,1L,6L,71L,356L,1017L,1856L,2282L,1932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099602Inst : IEnumerable<long>
{
public static readonly long[] Value=A099602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099602.Bytes);
public long this[int i]=>Value[i];

public static A099602Inst Instance=new A099602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099603
{
public static readonly long[] Value={ 1L,2L,4L,12L,20L,64L,104L,336L,544L,1760L,2848L,9216L,14912L,48256L,78080L,252672L,408832L,1323008L,2140672L,6927360L,11208704L,36272128L,58689536L,189923328L,307302400L,994451456L,1609056256L,5207015424L,8425127936L,27264286720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099603Inst : IEnumerable<long>
{
public static readonly long[] Value=A099603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099603.Bytes);
public long this[int i]=>Value[i];

public static A099603Inst Instance=new A099603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099604
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,23L,40L,72L,131L,233L,420L,756L,1355L,2438L,4381L,7868L,14144L,25413L,45661L,82058L,147444L,264943L,476092L,855483L,1537236L,2762296L,4963591L,8919173L,16027012L,28799164L,51749715L,92989886L,167094985L,300255720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099604Inst : IEnumerable<long>
{
public static readonly long[] Value=A099604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099604.Bytes);
public long this[int i]=>Value[i];

public static A099604Inst Instance=new A099604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099605
{
public static readonly long[] Value={ 1L,2L,2L,1L,5L,4L,4L,16L,20L,8L,1L,14L,41L,44L,16L,6L,50L,146L,198L,128L,32L,1L,27L,155L,377L,456L,272L,64L,8L,112L,560L,1408L,1992L,1616L,704L,128L,1L,44L,406L,1652L,3649L,4712L,3568L,1472L,256L,10L,210L,1572L,6084L,14002L,20330L,18880L,10912L,3584L,512L,1L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099605Inst : IEnumerable<long>
{
public static readonly long[] Value=A099605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099605.Bytes);
public long this[int i]=>Value[i];

public static A099605Inst Instance=new A099605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099606
{
public static readonly long[] Value={ 1L,4L,10L,48L,116L,560L,1352L,6528L,15760L,76096L,183712L,887040L,2141504L,10340096L,24963200L,120532992L,290992384L,1405035520L,3392055808L,16378294272L,39540700160L,190919389184L,460920178688L,2225519493120L,5372879343616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099606Inst : IEnumerable<long>
{
public static readonly long[] Value=A099606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099606.Bytes);
public long this[int i]=>Value[i];

public static A099606Inst Instance=new A099606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099607
{
public static readonly long[] Value={ 1L,2L,3L,9L,21L,40L,100L,225L,482L,1119L,2513L,5565L,12636L,28376L,63481L,143118L,321483L,721413L,1622729L,3645740L,8188668L,18406009L,41355654L,92914375L,208799157L,469157625L,1054150840L,2368736000L,5322460497L,11959337226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099607Inst : IEnumerable<long>
{
public static readonly long[] Value=A099607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099607.Bytes);
public long this[int i]=>Value[i];

public static A099607Inst Instance=new A099607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099608
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,7L,1L,1L,7L,19L,13L,1L,1L,9L,37L,55L,21L,1L,1L,11L,61L,147L,131L,31L,1L,1L,13L,91L,309L,471L,271L,43L,1L,1L,15L,127L,561L,1251L,1281L,505L,57L,1L,1L,17L,169L,923L,2751L,4251L,3067L,869L,73L,1L,1L,19L,217L,1415L,5321L,11253L,12559L,6637L,1405L,91L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099608Inst : IEnumerable<long>
{
public static readonly long[] Value=A099608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099608.Bytes);
public long this[int i]=>Value[i];

public static A099608Inst Instance=new A099608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099609
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,7L,11L,13L,17L,19L,29L,31L,41L,43L,59L,61L,71L,73L,101L,103L,107L,109L,137L,139L,149L,151L,179L,181L,191L,193L,197L,199L,227L,229L,239L,241L,269L,271L,281L,283L,311L,313L,347L,349L,419L,421L,431L,433L,461L,463L,521L,523L,569L,571L,599L,601L,617L,619L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099609Inst : IEnumerable<long>
{
public static readonly long[] Value=A099609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099609.Bytes);
public long this[int i]=>Value[i];

public static A099609Inst Instance=new A099609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099610
{
public static readonly long[] Value={ 15L,21L,33L,39L,51L,69L,85L,111L,123L,155L,177L,201L,235L,259L,291L,327L,365L,403L,445L,489L,533L,579L,629L,679L,731L,789L,843L,905L,965L,1027L,1099L,1159L,1227L,1299L,1371L,1457L,1527L,1603L,1685L,1769L,1851L,1939L,2031L,2119L,2215L,2307L,2407L,2507L,2603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099610Inst : IEnumerable<long>
{
public static readonly long[] Value=A099610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099610.Bytes);
public long this[int i]=>Value[i];

public static A099610Inst Instance=new A099610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099611
{
public static readonly long[] Value={ 15L,21L,35L,39L,57L,77L,95L,119L,143L,161L,187L,221L,253L,287L,323L,355L,395L,437L,481L,527L,573L,623L,671L,723L,781L,835L,899L,959L,1011L,1081L,1149L,1219L,1293L,1363L,1441L,1517L,1591L,1679L,1763L,1843L,1929L,2021L,2105L,2201L,2291L,2395L,2497L,2599L,2701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099611Inst : IEnumerable<long>
{
public static readonly long[] Value=A099611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099611.Bytes);
public long this[int i]=>Value[i];

public static A099611Inst Instance=new A099611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099612
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,5L,2L,61L,17L,277L,62L,50521L,1382L,540553L,21844L,199360981L,929569L,3878302429L,6404582L,2404879675441L,443861162L,14814847529501L,18888466084L,69348874393137901L,113927491862L,238685140977801337L,58870668456604L,BigInteger.Parse("4087072509293123892361") };
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
public class A099612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099612Inst Instance=new A099612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099613
{
public static readonly long[] Value={ 1L,1L,10L,1L,13L,113L,1L,16L,171L,1526L,1L,19L,241L,2551L,24337L,1L,22L,323L,3956L,43653L,450066L,1L,25L,417L,5801L,72689L,850809L,9492289L,1L,28L,523L,8146L,114265L,1496944L,18689527L,225159022L,1L,31L,641L,11051L,171561L,2487171L,34358881L,557947691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099613Inst : IEnumerable<long>
{
public static readonly long[] Value=A099613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099613.Bytes);
public long this[int i]=>Value[i];

public static A099613Inst Instance=new A099613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099614
{
public static readonly long[] Value={ 1L,1L,8L,1L,11L,81L,1L,14L,131L,1024L,1L,17L,193L,1829L,15625L,1L,20L,267L,2974L,29849L,279936L,1L,23L,353L,4519L,52113L,561399L,5764801L,1L,26L,451L,6524L,84997L,1034270L,11994247L,134217728L,1L,29L,561L,9049L,131441L,1782969L,23046721L,287420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099614Inst : IEnumerable<long>
{
public static readonly long[] Value=A099614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099614.Bytes);
public long this[int i]=>Value[i];

public static A099614Inst Instance=new A099614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099615
{
public static readonly long[] Value={ 4L,9L,27L,16L,64L,256L,25L,125L,625L,3125L,36L,216L,1296L,7776L,46656L,49L,343L,2401L,16807L,117649L,823543L,64L,512L,4096L,32768L,262144L,2097152L,16777216L,81L,729L,6561L,59049L,531441L,4782969L,43046721L,387420489L,100L,1000L,10000L,100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099615Inst : IEnumerable<long>
{
public static readonly long[] Value=A099615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099615.Bytes);
public long this[int i]=>Value[i];

public static A099615Inst Instance=new A099615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099616
{
public static readonly long[] Value={ 9L,10L,15L,24L,30L,35L,40L,49L,53L,54L,61L,68L,70L,71L,80L,80L,81L,86L,86L,91L,95L,101L,101L,104L,109L,110L,114L,123L,126L,128L,131L,139L,143L,144L,145L,145L,152L,159L,163L,164L,168L,177L,180L,187L,191L,193L,201L,202L,208L,215L,217L,218L,221L,225L,227L,233L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099616Inst : IEnumerable<long>
{
public static readonly long[] Value=A099616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099616.Bytes);
public long this[int i]=>Value[i];

public static A099616Inst Instance=new A099616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099617
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,24L,15L,720L,315L,8064L,2835L,3628800L,155925L,95800320L,6081075L,87178291200L,638512875L,4184557977600L,10854718875L,6402373705728000L,1856156927625L,97316080327065600L,194896477400625L,BigInteger.Parse("1124000727777607680000"),2900518163668125L,BigInteger.Parse("9545360026665222144000") };
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
public class A099617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099617Inst Instance=new A099617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099618
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099618Inst : IEnumerable<long>
{
public static readonly long[] Value=A099618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099618.Bytes);
public long this[int i]=>Value[i];

public static A099618Inst Instance=new A099618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099619
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,10L,11L,12L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,77L,78L,80L,82L,83L,84L,85L,88L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099619Inst : IEnumerable<long>
{
public static readonly long[] Value=A099619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099619.Bytes);
public long this[int i]=>Value[i];

public static A099619Inst Instance=new A099619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099620
{
public static readonly long[] Value={ 6L,15L,35L,119L,407L,559L,1037L,1387L,2231L,3683L,4247L,6179L,7913L,8557L,10951L,14257L,18113L,19093L,24053L,27193L,28981L,34681L,38263L,44411L,54611L,59893L,61903L,66233L,69869L,74467L,96139L,104407L,113573L,119123L,138421L,142091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099620Inst : IEnumerable<long>
{
public static readonly long[] Value=A099620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099620.Bytes);
public long this[int i]=>Value[i];

public static A099620Inst Instance=new A099620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099621
{
public static readonly long[] Value={ 0L,1L,6L,31L,144L,637L,2730L,11467L,47508L,194953L,794574L,3222583L,13023192L,52491349L,211161138L,848231779L,3403688796L,13647040225L,54685016022L,219030629455L,876994213920L,3510591943981L,14050213040826L,56224387958011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099621Inst : IEnumerable<long>
{
public static readonly long[] Value=A099621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099621.Bytes);
public long this[int i]=>Value[i];

public static A099621Inst Instance=new A099621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099622
{
public static readonly long[] Value={ 0L,1L,8L,53L,316L,1785L,9744L,51997L,273092L,1417889L,7299160L,37334661L,190028748L,963565513L,4871514656L,24572321645L,123720601684L,622038982257L,3123938806632L,15674669614549L,78593250398300L,393845861293721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099622Inst : IEnumerable<long>
{
public static readonly long[] Value=A099622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099622.Bytes);
public long this[int i]=>Value[i];

public static A099622Inst Instance=new A099622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099623
{
public static readonly long[] Value={ 0L,0L,1L,6L,27L,104L,369L,1242L,4039L,12828L,40077L,123758L,379011L,1153872L,3498025L,10572354L,31884543L,96010436L,288788613L,867967830L,2607282235L,7828953720L,23501774241L,70536546986L,211674885687L,635160738924L,1905765565309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099623Inst : IEnumerable<long>
{
public static readonly long[] Value=A099623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099623.Bytes);
public long this[int i]=>Value[i];

public static A099623Inst Instance=new A099623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099624
{
public static readonly long[] Value={ 0L,0L,1L,9L,58L,318L,1591L,7503L,33976L,149436L,643261L,2724357L,11395654L,47210154L,194121811L,793526571L,3228811492L,13090123272L,52917410041L,213437246145L,859342367890L,3455021317590L,13875655896751L,55677180731079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099624Inst : IEnumerable<long>
{
public static readonly long[] Value=A099624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099624.Bytes);
public long this[int i]=>Value[i];

public static A099624Inst Instance=new A099624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099625
{
public static readonly long[] Value={ 0L,0L,1L,6L,25L,88L,281L,842L,2413L,6692L,18101L,48014L,125393L,323376L,825393L,2088850L,5248853L,13110844L,32584653L,80639446L,198844281L,488813768L,1198491913L,2931934938L,7158830781L,17450923092L,42480107365L,103283553054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099625Inst : IEnumerable<long>
{
public static readonly long[] Value=A099625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099625.Bytes);
public long this[int i]=>Value[i];

public static A099625Inst Instance=new A099625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099626
{
public static readonly long[] Value={ 0L,1L,2L,7L,18L,52L,142L,397L,1098L,3051L,8460L,23480L,65140L,180749L,501498L,1391483L,3860822L,10712348L,29722698L,82469313L,228821202L,634892599L,1761587480L,4887741040L,13561638120L,37628431801L,104404708402L,289683694927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099626Inst : IEnumerable<long>
{
public static readonly long[] Value=A099626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099626.Bytes);
public long this[int i]=>Value[i];

public static A099626Inst Instance=new A099626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099627
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,15L,16L,17L,19L,23L,31L,32L,33L,35L,39L,47L,63L,64L,65L,67L,71L,79L,95L,127L,128L,129L,131L,135L,143L,159L,191L,255L,256L,257L,259L,263L,271L,287L,319L,383L,511L,512L,513L,515L,519L,527L,543L,575L,639L,767L,1023L,1024L,1025L,1027L,1031L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099627Inst : IEnumerable<long>
{
public static readonly long[] Value=A099627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099627.Bytes);
public long this[int i]=>Value[i];

public static A099627Inst Instance=new A099627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099628
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,11L,16L,17L,19L,23L,32L,33L,35L,39L,47L,64L,65L,67L,71L,79L,95L,128L,129L,131L,135L,143L,159L,191L,256L,257L,259L,263L,271L,287L,319L,383L,512L,513L,515L,519L,527L,543L,575L,639L,767L,1024L,1025L,1027L,1031L,1039L,1055L,1087L,1151L,1279L,1535L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099628Inst : IEnumerable<long>
{
public static readonly long[] Value=A099628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099628.Bytes);
public long this[int i]=>Value[i];

public static A099628Inst Instance=new A099628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099629
{
public static readonly long[] Value={ 2L,7L,13L,97L,103L,983L,1039L,9871L,10243L,98731L,102359L,987631L,1023467L,9876413L,10234589L,98765431L,102345689L,987654103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099629Inst : IEnumerable<long>
{
public static readonly long[] Value=A099629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099629.Bytes);
public long this[int i]=>Value[i];

public static A099629Inst Instance=new A099629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099630
{
public static readonly long[] Value={ 11L,11L,101L,997L,1009L,9973L,10007L,99991L,100069L,999983L,1000003L,9999901L,10000019L,99999931L,100000007L,999999937L,1000000007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099630Inst : IEnumerable<long>
{
public static readonly long[] Value=A099630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099630.Bytes);
public long this[int i]=>Value[i];

public static A099630Inst Instance=new A099630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099631
{
public static readonly long[] Value={ 5L,8L,32L,44L,116L,184L,356L,764L,815L,1004L,1012L,1205L,1338L,1345L,1436L,2636L,2876L,3126L,3644L,5156L,5305L,5804L,6236L,7192L,7542L,7556L,8564L,9356L,9404L,10196L,10362L,10904L,11276L,11876L,13436L,16375L,17564L,17636L,20156L,25316L,25964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099631Inst : IEnumerable<long>
{
public static readonly long[] Value=A099631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099631.Bytes);
public long this[int i]=>Value[i];

public static A099631Inst Instance=new A099631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099632
{
public static readonly long[] Value={ 45L,694L,3768374L,6303735L,15913725L,20291271L,42824146L,47788894L,54424095L,141120134L,163380694L,219105494L,305034794L,404686557L,790565966L,893558445L,928608435L,1198745925L,1251276254L,1409720194L,1412229015L,1696122945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099632Inst : IEnumerable<long>
{
public static readonly long[] Value=A099632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099632.Bytes);
public long this[int i]=>Value[i];

public static A099632Inst Instance=new A099632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099633
{
public static readonly long[] Value={ 2L,5L,10L,14L,20L,25L,50L,80L,154L,200L,434L,520L,610L,815L,1205L,1345L,2680L,3200L,3560L,4669L,7330L,9290L,10130L,11705L,17630L,24410L,25090L,33385L,34205L,39754L,39785L,40870L,48470L,55979L,59090L,73165L,75470L,78035L,95990L,107680L,115685L,120230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099633Inst : IEnumerable<long>
{
public static readonly long[] Value=A099633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099633.Bytes);
public long this[int i]=>Value[i];

public static A099633Inst Instance=new A099633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099634
{
public static readonly long[] Value={ 4L,3L,4L,5L,1L,7L,4L,3L,1L,11L,1L,13L,1L,1L,4L,17L,1L,19L,1L,1L,1L,23L,1L,5L,1L,3L,1L,29L,1L,31L,4L,1L,1L,1L,1L,37L,1L,1L,1L,41L,1L,43L,1L,1L,1L,47L,1L,7L,1L,1L,1L,53L,1L,1L,1L,1L,1L,59L,1L,61L,1L,1L,4L,1L,1L,67L,1L,1L,1L,71L,1L,73L,1L,1L,1L,1L,1L,79L,1L,3L,1L,83L,1L,1L,1L,1L,1L,89L,1L,1L,1L,1L,1L,1L,1L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099634Inst : IEnumerable<long>
{
public static readonly long[] Value=A099634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099634.Bytes);
public long this[int i]=>Value[i];

public static A099634Inst Instance=new A099634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099635
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,1L,7L,2L,3L,1L,11L,1L,13L,1L,1L,2L,17L,1L,19L,1L,1L,1L,23L,1L,5L,1L,3L,1L,29L,10L,31L,2L,1L,1L,1L,1L,37L,1L,1L,1L,41L,6L,43L,1L,1L,1L,47L,1L,7L,1L,1L,1L,53L,1L,1L,1L,1L,1L,59L,10L,61L,1L,1L,2L,1L,2L,67L,1L,1L,14L,71L,1L,73L,1L,1L,1L,1L,6L,79L,1L,3L,1L,83L,12L,1L,1L,1L,1L,89L,10L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099635Inst : IEnumerable<long>
{
public static readonly long[] Value=A099635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099635.Bytes);
public long this[int i]=>Value[i];

public static A099635Inst Instance=new A099635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099636
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,1L,7L,2L,3L,1L,11L,1L,13L,1L,1L,2L,17L,1L,19L,1L,1L,1L,23L,1L,5L,1L,3L,1L,29L,10L,31L,2L,1L,1L,1L,1L,37L,1L,1L,1L,41L,6L,43L,1L,1L,1L,47L,1L,7L,1L,1L,1L,53L,1L,1L,1L,1L,1L,59L,10L,61L,1L,1L,2L,1L,2L,67L,1L,1L,14L,71L,1L,73L,1L,1L,1L,1L,6L,79L,1L,3L,1L,83L,6L,1L,1L,1L,1L,89L,10L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099636Inst : IEnumerable<long>
{
public static readonly long[] Value=A099636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099636.Bytes);
public long this[int i]=>Value[i];

public static A099636Inst Instance=new A099636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099637
{
public static readonly long[] Value={ 84L,132L,168L,228L,234L,252L,260L,264L,276L,308L,336L,340L,372L,396L,456L,468L,504L,516L,520L,528L,532L,552L,558L,564L,580L,588L,616L,644L,672L,680L,684L,702L,708L,740L,744L,756L,792L,804L,820L,828L,836L,852L,855L,868L,884L,912L,936L,948L,996L,1008L,1012L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099637Inst : IEnumerable<long>
{
public static readonly long[] Value=A099637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099637.Bytes);
public long this[int i]=>Value[i];

public static A099637Inst Instance=new A099637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099638
{
public static readonly BigInteger[] Value={ 1L,77L,7437L,741037L,74077037L,7407437037L,740741037037L,74074077037037L,7407407437037037L,740740741037037037L,BigInteger.Parse("74074074077037037037"),BigInteger.Parse("7407407407437037037037"),BigInteger.Parse("740740740741037037037037") };
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
public class A099638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A099638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A099638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A099638Inst Instance=new A099638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099639
{
public static readonly long[] Value={ 1L,66L,6216L,617716L,61732716L,6172882716L,617284382716L,61728399382716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099639Inst : IEnumerable<long>
{
public static readonly long[] Value=A099639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099639.Bytes);
public long this[int i]=>Value[i];

public static A099639Inst Instance=new A099639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A099640
{
public static readonly long[] Value={ 2L,2L,2L,19L,113L,509L,2551L,19267L,75041L,753143L,4310819L,38238461L,307379717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A099640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A099640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A099640Inst : IEnumerable<long>
{
public static readonly long[] Value=A099640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A099640.Bytes);
public long this[int i]=>Value[i];

public static A099640Inst Instance=new A099640Inst();

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