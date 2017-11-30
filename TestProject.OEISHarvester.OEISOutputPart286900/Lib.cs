using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A229835
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,5L,5L,4L,6L,5L,7L,6L,7L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,6L,7L,10L,9L,6L,8L,6L,10L,8L,9L,7L,7L,10L,10L,9L,8L,7L,10L,7L,10L,3L,7L,12L,8L,10L,6L,8L,9L,6L,10L,8L,11L,7L,11L,8L,7L,9L,8L,12L,10L,8L,12L,7L,9L,10L,10L,8L,11L,10L,7L,10L,9L,14L,9L,9L,9L,8L,10L,10L,9L,7L,8L,9L,9L,8L,10L,9L,10L,10L,9L,7L,8L,7L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229835Inst : IEnumerable<long>
{
public static readonly long[] Value=A229835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229835.Bytes);
public long this[int i]=>Value[i];

public static A229835Inst Instance=new A229835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229836
{
public static readonly long[] Value={ 0L,2L,6L,45L,415L,4693L,65010L,1073640L,20669837L,454793822L,11259684418L,309761863916L,9373389023182L,309374515194621L,11059527891811334L,425655578031419604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229836Inst : IEnumerable<long>
{
public static readonly long[] Value=A229836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229836.Bytes);
public long this[int i]=>Value[i];

public static A229836Inst Instance=new A229836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229837
{
public static readonly long[] Value={ 1L,3L,1L,7L,9L,0L,2L,1L,5L,1L,4L,5L,4L,4L,0L,3L,8L,9L,4L,8L,6L,0L,0L,0L,8L,8L,4L,4L,2L,4L,9L,2L,3L,1L,8L,3L,7L,9L,7L,4L,9L,0L,1L,2L,4L,5L,7L,9L,2L,7L,8L,3L,9L,9L,2L,8L,4L,0L,4L,6L,1L,1L,9L,6L,9L,9L,7L,6L,4L,6L,1L,0L,7L,7L,5L,6L,1L,3L,9L,4L,8L,2L,6L,1L,1L,9L,5L,3L,6L,4L,6L,8L,3L,4L,3L,9L,2L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229837Inst : IEnumerable<long>
{
public static readonly long[] Value=A229837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229837.Bytes);
public long this[int i]=>Value[i];

public static A229837Inst Instance=new A229837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229838
{
public static readonly long[] Value={ 3L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,24L,25L,27L,29L,31L,32L,33L,35L,37L,39L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,56L,57L,59L,61L,63L,64L,65L,67L,69L,71L,72L,73L,75L,77L,79L,80L,81L,83L,85L,87L,88L,89L,91L,93L,95L,96L,97L,99L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229838Inst : IEnumerable<long>
{
public static readonly long[] Value=A229838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229838.Bytes);
public long this[int i]=>Value[i];

public static A229838Inst Instance=new A229838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229839
{
public static readonly long[] Value={ 8L,15L,16L,21L,24L,30L,32L,35L,40L,42L,45L,48L,55L,56L,60L,63L,64L,65L,70L,72L,75L,77L,80L,84L,88L,90L,91L,96L,99L,104L,105L,110L,112L,117L,119L,120L,126L,128L,130L,133L,135L,136L,140L,143L,144L,147L,150L,152L,153L,154L,160L,165L,168L,171L,175L,176L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229839Inst : IEnumerable<long>
{
public static readonly long[] Value=A229839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229839.Bytes);
public long this[int i]=>Value[i];

public static A229839Inst Instance=new A229839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229904
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,4L,2L,1L,2L,2L,2L,2L,4L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,1L,4L,2L,2L,4L,2L,2L,2L,2L,2L,2L,1L,2L,2L,4L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229904Inst : IEnumerable<long>
{
public static readonly long[] Value=A229904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229904.Bytes);
public long this[int i]=>Value[i];

public static A229904Inst Instance=new A229904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229905
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,10L,30L,26L,78L,156L,278L,722L,1827L,3140L,7800L,5810L,21016L,40260L,76104L,173836L,394492L,520775L,1376090L,3080882L,6887040L,12734023L,28266044L,44217698L,114969792L,211934801L,464129402L,354151217L,1360414116L,2644465928L,5134476403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229905Inst : IEnumerable<long>
{
public static readonly long[] Value=A229905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229905.Bytes);
public long this[int i]=>Value[i];

public static A229905Inst Instance=new A229905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229906
{
public static readonly long[] Value={ 289L,298L,388L,469L,478L,496L,559L,568L,586L,595L,649L,658L,667L,676L,685L,694L,748L,766L,775L,784L,793L,838L,847L,856L,865L,874L,892L,928L,946L,955L,964L,973L,982L,1099L,1189L,1198L,1288L,1369L,1378L,1387L,1396L,1468L,1477L,1486L,1495L,1558L,1576L,1585L,1594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229906Inst : IEnumerable<long>
{
public static readonly long[] Value=A229906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229906.Bytes);
public long this[int i]=>Value[i];

public static A229906Inst Instance=new A229906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229907
{
public static readonly long[] Value={ 5L,11L,191L,821L,2081L,3461L,5651L,25301L,34841L,88811L,122201L,171161L,301991L,739391L,1410971L,1468631L,2990831L,3741161L,5074871L,5527001L,8926451L,17186591L,21872441L,47615831L,66714671L,76384661L,87607361L,122033201L,132574061L,204335771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229907Inst : IEnumerable<long>
{
public static readonly long[] Value=A229907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229907.Bytes);
public long this[int i]=>Value[i];

public static A229907Inst Instance=new A229907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229908
{
public static readonly long[] Value={ 2L,13L,13L,37L,113L,113L,137L,1237L,1373L,1733L,1733L,11317L,11731L,12713L,19973L,91733L,113173L,113371L,113371L,173347L,991733L,1123379L,1134673L,1137991L,1237199L,2333719L,7433719L,11133719L,11399173L,11399173L,11791733L,37914713L,97433719L,113217397L,113217397L,113337199L,113337199L,113337199L,1113371999L,1113371999L,1113991733L,1139917321L,1139917321L,1139917333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229908Inst : IEnumerable<long>
{
public static readonly long[] Value=A229908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229908.Bytes);
public long this[int i]=>Value[i];

public static A229908Inst Instance=new A229908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229909
{
public static readonly long[] Value={ 1L,2080L,8038045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229909Inst : IEnumerable<long>
{
public static readonly long[] Value=A229909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229909.Bytes);
public long this[int i]=>Value[i];

public static A229909Inst Instance=new A229909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229910
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,4L,2L,4L,4L,2L,4L,8L,6L,10L,8L,14L,4L,4L,12L,8L,6L,20L,24L,16L,16L,12L,26L,8L,16L,14L,12L,24L,14L,32L,10L,20L,18L,40L,48L,44L,4L,30L,16L,32L,18L,14L,18L,56L,8L,60L,40L,12L,40L,64L,64L,72L,20L,40L,32L,36L,80L,22L,44L,24L,72L,22L,36L,86L,32L,84L,88L,40L,24L,28L,94L,104L,28L,76L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229910Inst : IEnumerable<long>
{
public static readonly long[] Value=A229910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229910.Bytes);
public long this[int i]=>Value[i];

public static A229910Inst Instance=new A229910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229911
{
public static readonly long[] Value={ 1L,4L,0L,8L,2L,4L,8L,3L,4L,6L,0L,1L,8L,7L,4L,7L,8L,4L,4L,1L,8L,3L,1L,9L,6L,2L,4L,9L,5L,6L,4L,8L,5L,9L,4L,4L,8L,0L,2L,8L,7L,8L,9L,1L,3L,6L,4L,1L,7L,0L,9L,5L,3L,4L,6L,0L,5L,2L,8L,6L,2L,6L,5L,3L,9L,1L,0L,5L,6L,6L,5L,3L,3L,6L,6L,1L,1L,5L,3L,8L,1L,6L,2L,8L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229911Inst : IEnumerable<long>
{
public static readonly long[] Value=A229911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229911.Bytes);
public long this[int i]=>Value[i];

public static A229911Inst Instance=new A229911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229912
{
public static readonly long[] Value={ 0L,3L,3L,10L,21L,55L,136L,351L,903L,2346L,6105L,15931L,41616L,108811L,284635L,744810L,1949325L,5102415L,13356696L,34965703L,91537215L,239640778L,627376753L,1642475955L,4300029216L,11257576275L,29472642291L,77160257866L,202007981253L,528863443111L,1384581955240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229912Inst : IEnumerable<long>
{
public static readonly long[] Value=A229912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229912.Bytes);
public long this[int i]=>Value[i];

public static A229912Inst Instance=new A229912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229913
{
public static readonly long[] Value={ 2L,4L,4L,8L,6L,7L,8L,9L,10L,12L,16L,6L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229913Inst : IEnumerable<long>
{
public static readonly long[] Value=A229913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229913.Bytes);
public long this[int i]=>Value[i];

public static A229913Inst Instance=new A229913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229914
{
public static readonly long[] Value={ 1L,3L,7L,16L,33L,63L,117L,202L,344L,566L,908L,1419L,2206L,3334L,4988L,7378L,10778L,15535L,22281L,31547L,44405L,62011L,85939L,118281L,162136L,220494L,298531L,402163L,539181L,719301L,956287L,1265022L,1667973L,2190934L,2867470L,3739797L,4864163L,6303461L,8146863L,10499087L,13493267L,17293169L,22111954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229914Inst : IEnumerable<long>
{
public static readonly long[] Value=A229914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229914.Bytes);
public long this[int i]=>Value[i];

public static A229914Inst Instance=new A229914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229915
{
public static readonly long[] Value={ 1L,3L,5L,10L,14L,26L,34L,57L,76L,116L,150L,227L,284L,408L,520L,718L,895L,1226L,1508L,2018L,2487L,3248L,3968L,5160L,6235L,7970L,9653L,12179L,14630L,18367L,21924L,27241L,32506L,39985L,47492L,58203L,68752L,83613L,98730L,119269L,140224L,168799L,197758L,236753L,277052L,329867L,384852L,457006L,531500L,628338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229915Inst : IEnumerable<long>
{
public static readonly long[] Value=A229915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229915.Bytes);
public long this[int i]=>Value[i];

public static A229915Inst Instance=new A229915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229916
{
public static readonly long[] Value={ 1L,4L,10L,25L,55L,109L,211L,371L,651L,1092L,1767L,2775L,4383L,6666L,9990L,14806L,21695L,31265L,44852L,63365L,89132L,124250L,171560L,235140L,321661L,435670L,587219L,787663L,1051669L,1396309L,1848190L,2432288L,3192615L,4174278L,5435945L,7054030L,9134731L,11779666L,15152584L,19436993L,24867486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229916Inst : IEnumerable<long>
{
public static readonly long[] Value=A229916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229916.Bytes);
public long this[int i]=>Value[i];

public static A229916Inst Instance=new A229916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229917
{
public static readonly long[] Value={ 1L,4L,7L,16L,22L,46L,58L,107L,140L,227L,287L,464L,563L,851L,1067L,1530L,1866L,2661L,3198L,4428L,5361L,7185L,8613L,11524L,13639L,17839L,21272L,27359L,32300L,41369L,48512L,61311L,72105L,89904L,105226L,130834L,152164L,187297L,218356L,266444L,309125L,375995L,434670L,525045L,607329L,728256L,839874L,1004938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229917Inst : IEnumerable<long>
{
public static readonly long[] Value=A229917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229917.Bytes);
public long this[int i]=>Value[i];

public static A229917Inst Instance=new A229917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229918
{
public static readonly BigInteger[] Value={ 2L,5L,29L,961L,1061329L,1292942940721L,BigInteger.Parse("1919252026700932310361841"),BigInteger.Parse("4228845073866683906973727166841825390255402119281"),BigInteger.Parse("20530699713334053449042480498993532340748805163335394099953181550394504111546117863646046977966961") };
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
public class A229918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229918Inst Instance=new A229918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229919
{
public static readonly BigInteger[] Value={ 1L,2L,12L,396L,437580L,533035889100L,BigInteger.Parse("791248706534500395281100"),BigInteger.Parse("1743421009870075512394843637096042899735399505100") };
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
public class A229919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A229919.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A229919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A229919Inst Instance=new A229919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229936
{
public static readonly long[] Value={ 0L,0L,0L,3L,12L,45L,126L,343L,848L,2034L,4700L,10648L,23652L,51935L,112798L,243120L,520592L,1109063L,2352366L,4971426L,10473220L,22003464L,46115300L,96440127L,201288792L,419381450L,872351896L,1811858058L,3757992280L,7784495839L,16105959240L,33285784442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229936Inst : IEnumerable<long>
{
public static readonly long[] Value=A229936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229936.Bytes);
public long this[int i]=>Value[i];

public static A229936Inst Instance=new A229936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229937
{
public static readonly long[] Value={ 1L,4L,8L,14L,16L,21L,22L,25L,26L,28L,32L,35L,38L,42L,44L,49L,50L,52L,55L,56L,62L,64L,69L,70L,74L,76L,81L,82L,84L,87L,88L,91L,93L,94L,98L,100L,104L,110L,112L,115L,117L,118L,121L,122L,124L,128L,133L,134L,138L,140L,143L,145L,146L,148L,152L,155L,158L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229937Inst : IEnumerable<long>
{
public static readonly long[] Value=A229937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229937.Bytes);
public long this[int i]=>Value[i];

public static A229937Inst Instance=new A229937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229938
{
public static readonly long[] Value={ 4L,3L,5L,9L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229938Inst : IEnumerable<long>
{
public static readonly long[] Value=A229938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229938.Bytes);
public long this[int i]=>Value[i];

public static A229938Inst Instance=new A229938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229939
{
public static readonly long[] Value={ 2L,8L,2L,7L,4L,3L,3L,3L,8L,8L,2L,3L,0L,8L,1L,3L,9L,1L,4L,6L,1L,6L,3L,7L,9L,0L,4L,4L,9L,5L,1L,5L,5L,2L,5L,9L,5L,7L,7L,7L,4L,5L,2L,4L,5L,9L,4L,3L,7L,5L,9L,5L,2L,3L,8L,8L,7L,7L,4L,5L,0L,1L,3L,3L,0L,7L,7L,0L,3L,4L,7L,6L,5L,6L,5L,7L,5L,8L,8L,0L,9L,8L,7L,6L,5L,2L,3L,1L,3L,4L,2L,8L,0L,7L,9L,0L,5L,3L,6L,1L,1L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229939Inst : IEnumerable<long>
{
public static readonly long[] Value=A229939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229939.Bytes);
public long this[int i]=>Value[i];

public static A229939Inst Instance=new A229939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229940
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229940Inst : IEnumerable<long>
{
public static readonly long[] Value=A229940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229940.Bytes);
public long this[int i]=>Value[i];

public static A229940Inst Instance=new A229940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229941
{
public static readonly long[] Value={ 3L,7L,42L,3L,8L,24L,3L,9L,18L,3L,10L,15L,3L,12L,12L,4L,5L,20L,4L,6L,12L,4L,8L,8L,5L,5L,10L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229941Inst : IEnumerable<long>
{
public static readonly long[] Value=A229941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229941.Bytes);
public long this[int i]=>Value[i];

public static A229941Inst Instance=new A229941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229942
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,4L,3L,2L,3L,4L,3L,3L,4L,4L,3L,2L,4L,6L,4L,2L,3L,4L,4L,4L,4L,5L,4L,2L,4L,6L,4L,2L,4L,6L,5L,4L,4L,4L,3L,2L,5L,8L,5L,3L,4L,4L,4L,4L,5L,6L,4L,2L,5L,8L,5L,2L,4L,6L,5L,4L,4L,4L,4L,4L,6L,9L,6L,2L,3L,4L,4L,4L,6L,8L,5L,2L,5L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229942Inst : IEnumerable<long>
{
public static readonly long[] Value=A229942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229942.Bytes);
public long this[int i]=>Value[i];

public static A229942Inst Instance=new A229942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229943
{
public static readonly long[] Value={ 1L,0L,5L,3L,4L,9L,7L,9L,4L,2L,3L,8L,6L,8L,3L,1L,2L,7L,5L,7L,2L,0L,1L,6L,4L,6L,0L,9L,0L,5L,3L,4L,9L,7L,9L,4L,2L,3L,8L,6L,8L,3L,1L,2L,7L,5L,7L,2L,0L,1L,6L,4L,6L,0L,9L,0L,5L,3L,4L,9L,7L,9L,4L,2L,3L,8L,6L,8L,3L,1L,2L,7L,5L,7L,2L,0L,1L,6L,4L,6L,0L,9L,0L,5L,3L,4L,9L,7L,9L,4L,2L,3L,8L,6L,8L,3L,1L,2L,7L,5L,7L,2L,0L,1L,6L,4L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229943Inst : IEnumerable<long>
{
public static readonly long[] Value=A229943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229943.Bytes);
public long this[int i]=>Value[i];

public static A229943Inst Instance=new A229943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229944
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,2L,5L,0L,1L,0L,6L,3L,1L,2L,7L,0L,1L,0L,8L,4L,1L,2L,9L,0L,1L,0L,3L,10L,5L,0L,1L,2L,0L,11L,0L,0L,1L,0L,0L,12L,6L,4L,1L,2L,3L,13L,0L,0L,1L,0L,0L,14L,7L,0L,1L,2L,0L,15L,0L,5L,1L,0L,3L,16L,8L,0L,1L,2L,0L,4L,17L,0L,0L,0L,1L,0L,0L,0L,18L,9L,6L,0L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229944Inst : IEnumerable<long>
{
public static readonly long[] Value=A229944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229944.Bytes);
public long this[int i]=>Value[i];

public static A229944Inst Instance=new A229944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229945
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,5L,1L,2L,3L,5L,6L,1L,2L,3L,5L,7L,1L,2L,3L,4L,5L,7L,8L,1L,2L,3L,5L,7L,9L,1L,2L,3L,5L,7L,10L,1L,2L,3L,5L,7L,11L,1L,2L,3L,4L,5L,6L,7L,11L,12L,1L,2L,3L,5L,7L,11L,13L,1L,2L,3L,5L,7L,11L,13L,14L,1L,2L,3L,5L,7L,11L,13L,15L,1L,2L,3L,4L,5L,7L,8L,11L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229945Inst : IEnumerable<long>
{
public static readonly long[] Value=A229945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229945.Bytes);
public long this[int i]=>Value[i];

public static A229945Inst Instance=new A229945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229946
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,3L,0L,2L,1L,5L,0L,3L,2L,7L,0L,2L,1L,5L,3L,6L,5L,11L,0L,3L,2L,7L,5L,9L,8L,15L,0L,2L,1L,5L,3L,6L,5L,11L,7L,12L,11L,15L,14L,22L,0L,3L,2L,7L,5L,9L,8L,15L,11L,14L,13L,19L,17L,22L,21L,30L,0L,2L,1L,5L,3L,6L,5L,11L,7L,12L,11L,15L,14L,22L,15L,19L,18L,25L,23L,29L,28L,33L,32L,42L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229946Inst : IEnumerable<long>
{
public static readonly long[] Value=A229946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229946.Bytes);
public long this[int i]=>Value[i];

public static A229946Inst Instance=new A229946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229947
{
public static readonly long[] Value={ 11L,13L,17L,19L,29L,31L,41L,43L,47L,59L,61L,71L,73L,79L,89L,101L,103L,107L,109L,131L,137L,139L,149L,151L,163L,167L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,239L,241L,251L,257L,269L,271L,281L,283L,311L,313L,317L,331L,347L,349L,359L,373L,379L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229947Inst : IEnumerable<long>
{
public static readonly long[] Value=A229947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229947.Bytes);
public long this[int i]=>Value[i];

public static A229947Inst Instance=new A229947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229948
{
public static readonly long[] Value={ 1L,0L,6L,7L,8L,7L,1L,0L,9L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229948Inst : IEnumerable<long>
{
public static readonly long[] Value=A229948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229948.Bytes);
public long this[int i]=>Value[i];

public static A229948Inst Instance=new A229948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229949
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,6L,5L,6L,3L,8L,9L,8L,3L,8L,7L,12L,5L,12L,9L,8L,3L,12L,15L,12L,3L,8L,9L,16L,9L,20L,9L,10L,3L,12L,15L,12L,3L,12L,15L,24L,9L,16L,9L,8L,3L,16L,21L,24L,5L,12L,9L,16L,7L,24L,15L,12L,3L,16L,27L,16L,3L,12L,11L,24L,9L,16L,9L,16L,9L,36L,25L,18L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229949Inst : IEnumerable<long>
{
public static readonly long[] Value=A229949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229949.Bytes);
public long this[int i]=>Value[i];

public static A229949Inst Instance=new A229949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229950
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,3L,3L,5L,6L,8L,8L,10L,11L,13L,13L,15L,16L,19L,20L,23L,25L,28L,28L,31L,33L,36L,37L,40L,41L,44L,45L,49L,52L,56L,57L,61L,64L,68L,69L,73L,75L,79L,81L,85L,88L,92L,92L,96L,99L,104L,107L,112L,115L,120L,122L,127L,131L,136L,137L,142L,146L,151L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229950Inst : IEnumerable<long>
{
public static readonly long[] Value=A229950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229950.Bytes);
public long this[int i]=>Value[i];

public static A229950Inst Instance=new A229950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229951
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,2L,1L,2L,0L,2L,1L,3L,1L,3L,2L,3L,0L,3L,2L,3L,1L,3L,1L,3L,1L,4L,3L,4L,1L,4L,3L,4L,1L,4L,2L,4L,2L,4L,3L,4L,0L,4L,3L,5L,3L,5L,3L,5L,2L,5L,4L,5L,1L,5L,4L,5L,2L,5L,3L,5L,3L,5L,3L,5L,1L,6L,5L,6L,4L,6L,4L,6L,2L,6L,5L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229951Inst : IEnumerable<long>
{
public static readonly long[] Value=A229951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229951.Bytes);
public long this[int i]=>Value[i];

public static A229951Inst Instance=new A229951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229984
{
public static readonly long[] Value={ 3L,5L,0L,7L,8L,7L,3L,9L,5L,5L,1L,7L,1L,9L,2L,4L,8L,2L,8L,4L,1L,5L,0L,5L,8L,7L,0L,1L,4L,0L,6L,6L,5L,9L,5L,3L,3L,8L,0L,3L,0L,9L,3L,4L,0L,7L,1L,9L,6L,5L,4L,7L,4L,7L,4L,9L,1L,3L,4L,6L,1L,6L,1L,1L,1L,8L,0L,4L,8L,3L,2L,0L,7L,8L,5L,2L,7L,5L,8L,9L,8L,5L,1L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229984Inst : IEnumerable<long>
{
public static readonly long[] Value=A229984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229984.Bytes);
public long this[int i]=>Value[i];

public static A229984Inst Instance=new A229984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229985
{
public static readonly long[] Value={ 1L,1L,1L,9L,9L,9L,3L,4L,0L,9L,9L,7L,2L,9L,5L,8L,7L,4L,0L,9L,1L,4L,2L,8L,3L,2L,4L,8L,2L,6L,0L,9L,5L,3L,2L,2L,9L,9L,6L,3L,8L,0L,1L,7L,0L,2L,8L,1L,5L,5L,2L,5L,0L,7L,0L,5L,8L,8L,5L,1L,0L,7L,5L,4L,8L,6L,6L,5L,4L,1L,5L,4L,6L,4L,6L,4L,2L,7L,4L,9L,8L,8L,2L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229985Inst : IEnumerable<long>
{
public static readonly long[] Value=A229985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229985.Bytes);
public long this[int i]=>Value[i];

public static A229985Inst Instance=new A229985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229986
{
public static readonly long[] Value={ 3L,6L,6L,8L,0L,3L,4L,6L,5L,5L,6L,2L,7L,6L,8L,0L,7L,7L,6L,6L,6L,1L,4L,8L,5L,5L,7L,0L,4L,1L,6L,0L,1L,5L,5L,9L,1L,4L,6L,3L,6L,5L,4L,1L,4L,0L,6L,7L,5L,5L,7L,2L,1L,9L,8L,4L,9L,8L,0L,6L,6L,7L,4L,1L,0L,1L,2L,8L,8L,1L,1L,9L,5L,9L,1L,8L,5L,6L,1L,0L,2L,0L,3L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229986Inst : IEnumerable<long>
{
public static readonly long[] Value=A229986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229986.Bytes);
public long this[int i]=>Value[i];

public static A229986Inst Instance=new A229986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229987
{
public static readonly long[] Value={ 1L,4L,0L,1L,2L,8L,4L,1L,1L,9L,2L,2L,8L,4L,2L,9L,8L,8L,4L,2L,5L,9L,6L,2L,5L,6L,6L,9L,8L,7L,9L,6L,5L,5L,0L,4L,0L,9L,1L,1L,8L,7L,4L,2L,4L,8L,7L,5L,4L,8L,2L,4L,1L,1L,2L,4L,1L,8L,1L,8L,5L,5L,5L,7L,3L,7L,5L,0L,0L,5L,2L,6L,8L,1L,6L,8L,3L,3L,2L,4L,0L,1L,5L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229987Inst : IEnumerable<long>
{
public static readonly long[] Value=A229987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229987.Bytes);
public long this[int i]=>Value[i];

public static A229987Inst Instance=new A229987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229988
{
public static readonly long[] Value={ 4L,8L,3L,6L,0L,6L,0L,3L,0L,9L,2L,5L,2L,8L,9L,0L,8L,8L,9L,3L,9L,9L,2L,6L,3L,5L,0L,8L,5L,5L,9L,3L,9L,4L,8L,0L,7L,9L,0L,4L,2L,3L,5L,9L,0L,1L,6L,3L,2L,0L,8L,0L,4L,0L,6L,0L,9L,1L,1L,7L,8L,4L,4L,8L,6L,2L,1L,3L,7L,7L,2L,6L,4L,6L,0L,9L,6L,8L,4L,5L,2L,8L,2L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229988Inst : IEnumerable<long>
{
public static readonly long[] Value=A229988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229988.Bytes);
public long this[int i]=>Value[i];

public static A229988Inst Instance=new A229988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229989
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,7L,7L,7L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,13L,14L,14L,14L,15L,16L,16L,16L,17L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229989Inst : IEnumerable<long>
{
public static readonly long[] Value=A229989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229989.Bytes);
public long this[int i]=>Value[i];

public static A229989Inst Instance=new A229989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229990
{
public static readonly long[] Value={ 1L,3L,4L,8L,12L,19L,20L,24L,28L,31L,40L,44L,48L,52L,55L,64L,67L,68L,71L,72L,84L,91L,92L,99L,100L,104L,108L,111L,115L,120L,127L,128L,131L,132L,140L,148L,151L,152L,155L,160L,171L,175L,180L,184L,187L,188L,204L,208L,211L,220L,224L,231L,232L,235L,239L,244L,248L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229990Inst : IEnumerable<long>
{
public static readonly long[] Value=A229990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229990.Bytes);
public long this[int i]=>Value[i];

public static A229990Inst Instance=new A229990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229991
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,17L,19L,20L,22L,26L,28L,29L,33L,34L,35L,41L,43L,45L,49L,52L,55L,56L,57L,60L,61L,64L,69L,72L,75L,81L,83L,85L,86L,89L,90L,91L,93L,94L,98L,104L,105L,109L,113L,116L,120L,122L,123L,124L,129L,134L,138L,139L,140L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229991Inst : IEnumerable<long>
{
public static readonly long[] Value=A229991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229991.Bytes);
public long this[int i]=>Value[i];

public static A229991Inst Instance=new A229991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229992
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,10L,12L,13L,14L,16L,17L,20L,21L,25L,26L,28L,29L,31L,33L,35L,39L,41L,43L,44L,45L,49L,51L,52L,57L,60L,64L,67L,69L,70L,81L,83L,85L,89L,90L,91L,97L,98L,104L,109L,113L,116L,118L,120L,131L,134L,136L,140L,142L,144L,145L,148L,152L,157L,171L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229992Inst : IEnumerable<long>
{
public static readonly long[] Value=A229992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229992.Bytes);
public long this[int i]=>Value[i];

public static A229992Inst Instance=new A229992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229993
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,10L,13L,14L,17L,20L,26L,28L,29L,33L,35L,41L,43L,45L,49L,52L,57L,60L,64L,69L,81L,83L,85L,89L,90L,91L,98L,104L,109L,113L,116L,120L,134L,140L,142L,144L,148L,152L,171L,173L,176L,178L,182L,190L,201L,202L,204L,206L,209L,212L,215L,225L,230L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229993Inst : IEnumerable<long>
{
public static readonly long[] Value=A229993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229993.Bytes);
public long this[int i]=>Value[i];

public static A229993Inst Instance=new A229993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229994
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,3L,2L,1L,7L,1L,8L,1L,9L,1L,10L,5L,2L,1L,11L,1L,12L,4L,3L,1L,13L,1L,14L,7L,2L,1L,15L,5L,3L,1L,16L,1L,17L,1L,18L,9L,2L,1L,19L,1L,20L,5L,4L,1L,21L,7L,3L,1L,22L,11L,2L,1L,23L,1L,24L,8L,3L,1L,25L,1L,26L,13L,2L,1L,27L,1L,28L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229994Inst : IEnumerable<long>
{
public static readonly long[] Value=A229994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229994.Bytes);
public long this[int i]=>Value[i];

public static A229994Inst Instance=new A229994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229995
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,3L,0L,1L,1L,0L,5L,0L,5L,0L,1L,1L,0L,7L,0L,13L,0L,7L,0L,1L,1L,0L,9L,0L,25L,0L,25L,0L,9L,0L,1L,1L,0L,11L,0L,41L,0L,63L,0L,41L,0L,11L,0L,1L,1L,0L,13L,0L,61L,0L,129L,0L,129L,0L,61L,0L,13L,0L,1L,1L,0L,15L,0L,85L,0L,231L,0L,321L,0L,231L,0L,85L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229995Inst : IEnumerable<long>
{
public static readonly long[] Value=A229995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229995.Bytes);
public long this[int i]=>Value[i];

public static A229995Inst Instance=new A229995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229996
{
public static readonly long[] Value={ 1L,10L,65L,130L,260L,340L,1105L,1972L,2210L,4420L,8840L,9860L,15650L,20737L,32045L,41474L,44200L,51272L,55250L,64090L,75140L,82948L,103685L,128180L,207370L,207553L,221000L,256360L,352529L,414740L,415106L,512720L,532100L,705058L,759025L,813800L,829480L,830212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229996Inst : IEnumerable<long>
{
public static readonly long[] Value=A229996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229996.Bytes);
public long this[int i]=>Value[i];

public static A229996Inst Instance=new A229996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229997
{
public static readonly long[] Value={ 1L,5L,10L,17L,26L,25L,50L,65L,82L,13L,122L,85L,170L,125L,52L,257L,290L,205L,362L,221L,500L,305L,530L,325L,626L,425L,730L,425L,842L,130L,962L,1025L,1220L,725L,260L,697L,1370L,905L,1700L,169L,1682L,1250L,1850L,1037L,2132L,1325L,2210L,1285L,2402L,313L,2900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229997Inst : IEnumerable<long>
{
public static readonly long[] Value=A229997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229997.Bytes);
public long this[int i]=>Value[i];

public static A229997Inst Instance=new A229997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229998
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,8L,9L,1L,11L,6L,13L,7L,3L,16L,17L,9L,19L,10L,21L,11L,23L,12L,25L,13L,27L,14L,29L,3L,31L,32L,33L,17L,7L,18L,37L,19L,39L,4L,41L,21L,43L,22L,45L,23L,47L,24L,49L,5L,51L,26L,53L,27L,55L,28L,57L,29L,59L,3L,61L,31L,63L,64L,1L,33L,67L,2L,69L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229998Inst : IEnumerable<long>
{
public static readonly long[] Value=A229998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229998.Bytes);
public long this[int i]=>Value[i];

public static A229998Inst Instance=new A229998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A229999
{
public static readonly long[] Value={ 1L,13L,68L,170L,289L,377L,1160L,2105L,2900L,4930L,9425L,10946L,19594L,20740L,33680L,51850L,45385L,52625L,69716L,84200L,83522L,88145L,107848L,143140L,269620L,208520L,226577L,273650L,353800L,458354L,521300L,540985L,568226L,884500L,760328L,832745L,876265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A229999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A229999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A229999Inst : IEnumerable<long>
{
public static readonly long[] Value=A229999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A229999.Bytes);
public long this[int i]=>Value[i];

public static A229999Inst Instance=new A229999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230048
{
public static readonly long[] Value={ 1L,2L,7L,11L,13L,14L,19L,21L,22L,26L,31L,35L,37L,38L,41L,42L,47L,55L,59L,61L,62L,67L,69L,70L,73L,74L,79L,82L,87L,91L,93L,94L,97L,103L,107L,109L,110L,115L,118L,122L,127L,131L,133L,134L,137L,138L,143L,145L,146L,151L,155L,157L,158L,161L,167L,173L,174L,179L,181L,182L,185L,186L,191L,193L,194L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230048Inst : IEnumerable<long>
{
public static readonly long[] Value=A230048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230048.Bytes);
public long this[int i]=>Value[i];

public static A230048Inst Instance=new A230048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230049
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,8L,1L,0L,1L,36L,27L,1L,0L,1L,120L,378L,64L,1L,0L,1L,330L,3654L,2080L,125L,1L,0L,1L,792L,27405L,45760L,7875L,216L,1L,0L,1L,1716L,169911L,766480L,333375L,23436L,343L,1L,0L,1L,3432L,906192L,10424128L,10668000L,1703016L,58996L,512L,1L,0L,1L,6435L,4272048L,119877472L,275234400L,93240126L,6784540L,131328L,729L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230049Inst : IEnumerable<long>
{
public static readonly long[] Value=A230049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230049.Bytes);
public long this[int i]=>Value[i];

public static A230049Inst Instance=new A230049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230050
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,65L,564L,6191L,82050L,1295263L,23764278L,499547080L,11892550569L,317112508944L,9392408105655L,306739296397827L,10973970687363844L,427724034697254939L,18073023112616933860UL,BigInteger.Parse("824247511186225346295"),BigInteger.Parse("40415810147764633887442"),BigInteger.Parse("2123162727678797736474583") };
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
public class A230050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230050Inst Instance=new A230050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230051
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40319L,362863L,3628550L,39913170L,478947480L,6226179960L,87164597520L,1307440134000L,20918580896069L,355608034188517L,6400803479701178L,121612584595293870L,2432198062707745560L,BigInteger.Parse("51075033128533094520"),BigInteger.Parse("1123625953230764250960") };
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
public class A230051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230051Inst Instance=new A230051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230052
{
public static readonly long[] Value={ 1824L,1876L,1888L,2000L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230052Inst : IEnumerable<long>
{
public static readonly long[] Value=A230052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230052.Bytes);
public long this[int i]=>Value[i];

public static A230052Inst Instance=new A230052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230053
{
public static readonly long[] Value={ 1L,3L,9L,3L,2L,0L,3L,9L,2L,9L,6L,8L,5L,6L,7L,6L,8L,5L,9L,1L,8L,4L,2L,4L,6L,2L,6L,0L,3L,2L,5L,3L,6L,8L,2L,4L,2L,6L,5L,7L,4L,8L,1L,2L,1L,7L,5L,1L,5L,6L,1L,7L,8L,7L,8L,9L,7L,4L,2L,8L,1L,6L,3L,1L,8L,8L,0L,3L,2L,4L,0L,1L,2L,5L,7L,5L,0L,3L,6L,6L,3L,0L,6L,7L,8L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230053Inst : IEnumerable<long>
{
public static readonly long[] Value=A230053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230053.Bytes);
public long this[int i]=>Value[i];

public static A230053Inst Instance=new A230053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230054
{
public static readonly long[] Value={ 2L,2L,76L,159L,426L,406309L,4902342L,186306983L,21138699322L,111681723264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230054Inst : IEnumerable<long>
{
public static readonly long[] Value=A230054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230054.Bytes);
public long this[int i]=>Value[i];

public static A230054Inst Instance=new A230054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230055
{
public static readonly BigInteger[] Value={ 1L,14L,181L,2360L,32010L,456720L,6881160L,109546009L,1841298059L,32629877967L,608572228291L,11923667699474L,244964063143590L,5267496652725480L,118348438201424761L,2773714509551524351L,BigInteger.Parse("67705791536824698266"),BigInteger.Parse("1718769199589362743761"),BigInteger.Parse("45314525515737783596251") };
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
public class A230055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230055Inst Instance=new A230055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230056
{
public static readonly BigInteger[] Value={ 1L,4L,9L,30L,132L,720L,4680L,35280L,302400L,2903040L,30844800L,359251200L,4550515200L,62270208000L,915372057600L,14384418048000L,240612083712000L,4268249137152000L,80029671321600000L,1581386305314816000L,BigInteger.Parse("32844177110384640000"),BigInteger.Parse("715273190403932160000"),BigInteger.Parse("16298010552775311360000") };
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
public class A230056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230056Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230056.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230056Inst Instance=new A230056Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230057
{
public static readonly long[] Value={ 1L,-4L,-12L,-4L,-12L,-24L,-12L,-32L,-12L,-4L,-72L,-48L,-12L,-56L,-96L,-24L,-12L,-72L,-12L,-80L,-72L,-32L,-144L,-96L,-12L,-124L,-168L,-4L,-96L,-120L,-72L,-128L,-12L,-48L,-216L,-192L,-12L,-152L,-240L,-56L,-72L,-168L,-96L,-176L,-144L,-24L,-288L,-192L,-12L,-228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230057Inst : IEnumerable<long>
{
public static readonly long[] Value=A230057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230057.Bytes);
public long this[int i]=>Value[i];

public static A230057Inst Instance=new A230057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230058
{
public static readonly long[] Value={ 5L,14L,17L,19L,22L,31L,33L,36L,38L,47L,50L,52L,55L,64L,67L,70L,79L,82L,84L,87L,96L,98L,101L,103L,112L,115L,117L,120L,129L,131L,132L,134L,143L,146L,148L,151L,160L,162L,165L,167L,176L,179L,181L,184L,193L,196L,199L,208L,211L,213L,216L,225L,227L,230L,232L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230058Inst : IEnumerable<long>
{
public static readonly long[] Value=A230058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230058.Bytes);
public long this[int i]=>Value[i];

public static A230058Inst Instance=new A230058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230059
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,4L,5L,6L,8L,10L,11L,14L,16L,18L,21L,24L,26L,30L,33L,36L,40L,44L,47L,52L,56L,60L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230059Inst : IEnumerable<long>
{
public static readonly long[] Value=A230059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230059.Bytes);
public long this[int i]=>Value[i];

public static A230059Inst Instance=new A230059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230060
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,11L,15L,18L,20L,28L,30L,35L,42L,45L,54L,60L,63L,66L,77L,78L,88L,90L,102L,105L,114L,117L,126L,130L,138L,150L,162L,165L,174L,175L,186L,198L,204L,210L,221L,222L,234L,245L,246L,247L,258L,264L,266L,270L,282L,294L,306L,315L,318L,330L,342L,351L,354L,366L,368L,378L,385L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230060Inst : IEnumerable<long>
{
public static readonly long[] Value=A230060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230060.Bytes);
public long this[int i]=>Value[i];

public static A230060Inst Instance=new A230060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230061
{
public static readonly BigInteger[] Value={ 2L,3L,43L,58787L,4861946401453L,BigInteger.Parse("337485502510215975556783793455058624701"),BigInteger.Parse("4180080073556524734514695828170907458428751314321"),BigInteger.Parse("1000134600800354781929399250536541864362461089950801"),BigInteger.Parse("944973797977428207852605870454939596837230758234904051") };
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
public class A230061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230061.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230061Inst Instance=new A230061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230062
{
public static readonly BigInteger[] Value={ 0L,9L,45L,15129L,14082255L,114228452529L,5392746297039195L,BigInteger.Parse("1669550033290419884241"),BigInteger.Parse("3264068813720842706362349013"),BigInteger.Parse("40741287160388602906800646716513609") };
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
public class A230062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230062Inst Instance=new A230062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230063
{
public static readonly long[] Value={ 0L,9L,45L,441L,3645L,31329L,266805L,2277081L,19424205L,165714129L,1413721125L,12060652041L,102890947005L,877775988609L,7488419962005L,63884675998521L,545008403548845L,4649536929125169L,39665798745571845L,338394040998364521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230063Inst : IEnumerable<long>
{
public static readonly long[] Value=A230063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230063.Bytes);
public long this[int i]=>Value[i];

public static A230063Inst Instance=new A230063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230192
{
public static readonly long[] Value={ 1L,1L,0L,5L,5L,5L,0L,4L,2L,7L,5L,2L,0L,9L,0L,8L,9L,3L,7L,0L,9L,6L,0L,9L,0L,1L,3L,9L,9L,5L,3L,9L,2L,5L,6L,5L,9L,7L,0L,0L,4L,9L,6L,9L,4L,6L,9L,1L,1L,6L,3L,6L,2L,8L,9L,3L,1L,4L,6L,0L,0L,3L,4L,3L,7L,2L,0L,6L,3L,4L,1L,7L,1L,4L,0L,3L,2L,5L,9L,8L,2L,1L,7L,3L,9L,8L,1L,1L,9L,1L,0L,4L,6L,9L,5L,7L,3L,9L,3L,9L,1L,4L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230192Inst : IEnumerable<long>
{
public static readonly long[] Value=A230192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230192.Bytes);
public long this[int i]=>Value[i];

public static A230192Inst Instance=new A230192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230193
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,15L,18L,21L,22L,24L,27L,30L,33L,36L,39L,42L,44L,45L,48L,51L,54L,55L,57L,60L,63L,66L,69L,72L,75L,77L,78L,81L,84L,87L,88L,90L,93L,96L,99L,102L,105L,108L,110L,111L,114L,117L,120L,121L,123L,126L,129L,132L,135L,138L,141L,143L,144L,147L,150L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230193Inst : IEnumerable<long>
{
public static readonly long[] Value=A230193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230193.Bytes);
public long this[int i]=>Value[i];

public static A230193Inst Instance=new A230193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230194
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,3L,3L,3L,4L,3L,6L,5L,3L,3L,3L,5L,4L,4L,4L,2L,9L,10L,9L,7L,5L,12L,8L,2L,8L,6L,6L,7L,9L,4L,3L,10L,11L,2L,4L,6L,10L,9L,11L,9L,4L,10L,17L,9L,1L,4L,7L,6L,6L,6L,2L,5L,14L,13L,7L,5L,14L,6L,3L,5L,4L,12L,11L,14L,5L,2L,16L,11L,5L,9L,6L,8L,11L,23L,15L,3L,23L,18L,17L,9L,8L,20L,5L,10L,14L,3L,14L,15L,16L,9L,8L,24L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230194Inst : IEnumerable<long>
{
public static readonly long[] Value=A230194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230194.Bytes);
public long this[int i]=>Value[i];

public static A230194Inst Instance=new A230194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230195
{
public static readonly long[] Value={ 24L,30L,36L,42L,48L,54L,60L,66L,84L,96L,114L,120L,126L,150L,156L,198L,210L,270L,294L,330L,336L,390L,420L,462L,504L,510L,546L,570L,630L,714L,726L,756L,810L,840L,924L,930L,1008L,1014L,1056L,1134L,1386L,1428L,1554L,1638L,1680L,1716L,1734L,1848L,1890L,1950L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230195Inst : IEnumerable<long>
{
public static readonly long[] Value=A230195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230195.Bytes);
public long this[int i]=>Value[i];

public static A230195Inst Instance=new A230195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230196
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,1L,2L,2L,1L,2L,3L,2L,3L,2L,3L,3L,4L,3L,3L,4L,4L,4L,5L,3L,5L,5L,5L,5L,5L,5L,6L,6L,6L,5L,7L,6L,7L,7L,6L,7L,8L,7L,8L,7L,8L,8L,9L,8L,8L,9L,9L,9L,10L,8L,10L,10L,10L,10L,10L,10L,11L,11L,11L,10L,12L,11L,12L,12L,11L,12L,13L,12L,13L,12L,13L,13L,14L,13L,13L,14L,14L,14L,15L,13L,15L,15L,15L,15L,15L,15L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230196Inst : IEnumerable<long>
{
public static readonly long[] Value=A230196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230196.Bytes);
public long this[int i]=>Value[i];

public static A230196Inst Instance=new A230196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230197
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,4L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,5L,6L,6L,6L,6L,6L,5L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,8L,9L,9L,9L,9L,10L,10L,9L,10L,10L,10L,11L,11L,11L,10L,11L,11L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230197Inst : IEnumerable<long>
{
public static readonly long[] Value=A230197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230197.Bytes);
public long this[int i]=>Value[i];

public static A230197Inst Instance=new A230197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230198
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,4L,4L,4L,3L,4L,4L,4L,5L,5L,5L,5L,4L,5L,5L,6L,6L,6L,6L,6L,5L,6L,7L,7L,7L,7L,7L,7L,6L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,9L,10L,10L,10L,10L,10L,11L,11L,10L,11L,11L,11L,11L,12L,12L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230198Inst : IEnumerable<long>
{
public static readonly long[] Value=A230198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230198.Bytes);
public long this[int i]=>Value[i];

public static A230198Inst Instance=new A230198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230199
{
public static readonly long[] Value={ 2L,3L,5L,7L,2L,2L,5L,7L,10L,11L,7L,11L,13L,14L,16L,19L,22L,23L,19L,20L,5L,7L,8L,7L,8L,10L,13L,14L,11L,16L,17L,13L,17L,16L,17L,14L,17L,19L,20L,20L,25L,19L,22L,23L,28L,29L,7L,8L,10L,13L,14L,8L,13L,13L,14L,17L,19L,22L,16L,17L,19L,23L,20L,23L,22L,25L,22L,23L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230199Inst : IEnumerable<long>
{
public static readonly long[] Value=A230199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230199.Bytes);
public long this[int i]=>Value[i];

public static A230199Inst Instance=new A230199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230200
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,0L,3L,5L,8L,9L,9L,45L,63L,72L,98L,245L,392L,441L,81L,162L,0L,0L,0L,3L,4L,16L,28L,32L,27L,72L,81L,48L,112L,100L,125L,0L,108L,180L,216L,196L,441L,64L,256L,243L,648L,729L,0L,0L,0L,0L,0L,0L,45L,108L,144L,405L,720L,1152L,0L,225L,675L,1575L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230200Inst : IEnumerable<long>
{
public static readonly long[] Value=A230200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230200.Bytes);
public long this[int i]=>Value[i];

public static A230200Inst Instance=new A230200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230201
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,30L,32L,34L,36L,40L,42L,44L,46L,48L,50L,54L,58L,60L,64L,66L,68L,70L,72L,78L,80L,84L,90L,92L,94L,96L,98L,100L,102L,106L,108L,110L,114L,118L,120L,126L,128L,130L,132L,136L,138L,140L,144L,150L,156L,160L,162L,166L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230201Inst : IEnumerable<long>
{
public static readonly long[] Value=A230201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230201.Bytes);
public long this[int i]=>Value[i];

public static A230201Inst Instance=new A230201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230202
{
public static readonly long[] Value={ 1999L,2999L,4999L,8999L,13999L,25999L,32999L,35999L,41999L,49999L,52999L,56999L,59999L,70999L,71999L,73999L,77999L,79999L,85999L,94999L,98999L,100999L,101999L,104999L,107999L,133999L,134999L,136999L,137999L,139999L,143999L,157999L,161999L,164999L,172999L,179999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230202Inst : IEnumerable<long>
{
public static readonly long[] Value=A230202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230202.Bytes);
public long this[int i]=>Value[i];

public static A230202Inst Instance=new A230202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230203
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,17L,19L,21L,23L,25L,26L,27L,29L,31L,33L,35L,37L,38L,39L,41L,43L,45L,47L,49L,51L,52L,53L,55L,56L,57L,59L,61L,62L,63L,65L,67L,69L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,93L,95L,97L,99L,101L,103L,104L,105L,107L,109L,111L,112L,113L,115L,116L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230203Inst : IEnumerable<long>
{
public static readonly long[] Value=A230203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230203.Bytes);
public long this[int i]=>Value[i];

public static A230203Inst Instance=new A230203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230204
{
public static readonly long[] Value={ 1L,-2L,0L,1L,0L,1L,-2L,2L,0L,0L,0L,0L,-2L,0L,-1L,-2L,2L,0L,3L,0L,0L,2L,2L,-2L,0L,-2L,0L,-2L,-2L,0L,0L,0L,0L,1L,0L,0L,2L,2L,0L,1L,-2L,2L,-2L,0L,0L,0L,0L,0L,-2L,0L,2L,0L,-2L,0L,0L,2L,0L,0L,-2L,0L,1L,-2L,0L,-2L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,2L,-2L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230204Inst : IEnumerable<long>
{
public static readonly long[] Value=A230204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230204.Bytes);
public long this[int i]=>Value[i];

public static A230204Inst Instance=new A230204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230205
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,2L,2L,0L,1L,-2L,-2L,-1L,0L,0L,0L,2L,0L,0L,2L,0L,-2L,0L,0L,1L,0L,0L,-2L,2L,1L,-2L,0L,0L,0L,-2L,0L,0L,-2L,0L,2L,2L,0L,0L,0L,0L,4L,0L,1L,0L,-2L,0L,0L,-2L,0L,-1L,-2L,-2L,0L,0L,0L,2L,-2L,0L,0L,0L,2L,2L,2L,0L,0L,2L,0L,-2L,0L,0L,0L,2L,0L,-1L,-4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230205Inst : IEnumerable<long>
{
public static readonly long[] Value=A230205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230205.Bytes);
public long this[int i]=>Value[i];

public static A230205Inst Instance=new A230205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230206
{
public static readonly long[] Value={ -1L,3L,-3L,1L,-1L,2L,0L,-2L,1L,-1L,1L,2L,-2L,-1L,1L,-1L,0L,3L,0L,-3L,0L,1L,-1L,-1L,3L,3L,-3L,-3L,1L,1L,-1L,-2L,2L,6L,0L,-6L,-2L,2L,1L,-1L,-3L,0L,8L,6L,-6L,-8L,0L,3L,1L,-1L,-4L,-3L,8L,14L,0L,-14L,-8L,3L,4L,1L,-1L,-5L,-7L,5L,22L,14L,-14L,-22L,-5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230206Inst : IEnumerable<long>
{
public static readonly long[] Value=A230206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230206.Bytes);
public long this[int i]=>Value[i];

public static A230206Inst Instance=new A230206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230207
{
public static readonly long[] Value={ 1L,-4L,6L,-4L,1L,1L,-3L,2L,2L,-3L,1L,1L,-2L,-1L,4L,-1L,-2L,1L,1L,-1L,-3L,3L,3L,-3L,-1L,1L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,1L,1L,-4L,-4L,6L,6L,-4L,-4L,1L,1L,1L,2L,-3L,-8L,2L,12L,2L,-8L,-3L,2L,1L,1L,3L,-1L,-11L,-6L,14L,14L,-6L,-11L,-1L,3L,1L,1L,4L,2L,-12L,-17L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230207Inst : IEnumerable<long>
{
public static readonly long[] Value=A230207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230207.Bytes);
public long this[int i]=>Value[i];

public static A230207Inst Instance=new A230207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230256
{
public static readonly long[] Value={ 1L,-1L,0L,4L,-6L,1L,11L,-19L,4L,31L,-50L,11L,77L,-122L,28L,173L,-273L,62L,370L,-573L,130L,751L,-1149L,261L,1461L,-2214L,498L,2750L,-4125L,923L,5022L,-7472L,1663L,8936L,-13202L,2919L,15551L,-22817L,5019L,26521L,-38681L,8467L,44417L,-64438L,14035L,73197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230256Inst : IEnumerable<long>
{
public static readonly long[] Value=A230256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230256.Bytes);
public long this[int i]=>Value[i];

public static A230256Inst Instance=new A230256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230257
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,4L,4L,4L,3L,4L,4L,4L,4L,5L,5L,5L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,5L,6L,6L,7L,7L,7L,7L,7L,7L,6L,7L,8L,8L,8L,8L,8L,8L,8L,7L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,10L,11L,11L,11L,11L,11L,11L,12L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230257Inst : IEnumerable<long>
{
public static readonly long[] Value=A230257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230257.Bytes);
public long this[int i]=>Value[i];

public static A230257Inst Instance=new A230257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230258
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,3L,2L,3L,3L,2L,3L,4L,3L,5L,3L,5L,5L,6L,5L,5L,6L,6L,7L,8L,5L,8L,8L,8L,8L,8L,8L,10L,10L,10L,8L,11L,10L,11L,11L,10L,12L,13L,12L,13L,11L,13L,13L,14L,13L,14L,15L,15L,15L,16L,13L,16L,16L,16L,17L,17L,17L,18L,18L,18L,16L,19L,18L,20L,20L,19L,20L,21L,20L,21L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230258Inst : IEnumerable<long>
{
public static readonly long[] Value=A230258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230258.Bytes);
public long this[int i]=>Value[i];

public static A230258Inst Instance=new A230258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230259
{
public static readonly long[] Value={ 2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,3L,1L,3L,2L,2L,1L,2L,1L,2L,8L,3L,5L,3L,3L,4L,1L,7L,1L,5L,4L,2L,2L,2L,1L,2L,1L,4L,1L,3L,7L,3L,2L,4L,5L,4L,1L,5L,2L,3L,3L,2L,2L,6L,2L,4L,1L,15L,1L,11L,10L,2L,5L,2L,3L,7L,3L,3L,1L,3L,1L,3L,2L,2L,1L,2L,17L,2L,5L,4L,7L,3L,5L,4L,4L,2L,2L,2L,1L,2L,5L,2L,8L,2L,4L,2L,2L,2L,1L,2L,8L,7L,5L,7L,4L,4L,1L,4L,4L,2L,2L,2L,1L,2L,17L,5L,14L,7L,2L,7L,3L,14L,6L,6L,1L,6L,3L,10L,3L,4L,3L,23L,3L,7L,12L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230259Inst : IEnumerable<long>
{
public static readonly long[] Value=A230259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230259.Bytes);
public long this[int i]=>Value[i];

public static A230259Inst Instance=new A230259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230260
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,0L,1L,2L,2L,1L,3L,1L,1L,2L,2L,0L,2L,1L,1L,2L,3L,3L,2L,2L,2L,2L,3L,3L,1L,0L,3L,2L,2L,4L,4L,2L,4L,3L,2L,2L,5L,3L,2L,4L,3L,2L,3L,3L,1L,4L,5L,3L,4L,2L,5L,5L,5L,5L,3L,2L,4L,3L,2L,2L,5L,2L,5L,5L,5L,7L,4L,2L,4L,2L,4L,5L,4L,1L,4L,5L,5L,8L,5L,4L,4L,4L,5L,4L,4L,4L,6L,5L,3L,8L,4L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230260Inst : IEnumerable<long>
{
public static readonly long[] Value=A230260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230260.Bytes);
public long this[int i]=>Value[i];

public static A230260Inst Instance=new A230260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230261
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,4L,3L,3L,4L,4L,3L,3L,4L,1L,5L,4L,3L,5L,5L,5L,4L,6L,4L,5L,5L,3L,3L,5L,4L,4L,2L,6L,8L,5L,4L,6L,7L,5L,5L,7L,6L,5L,7L,4L,6L,6L,3L,6L,5L,7L,6L,4L,6L,7L,6L,2L,7L,6L,2L,5L,5L,3L,7L,7L,5L,7L,9L,6L,7L,4L,6L,6L,4L,3L,9L,7L,4L,9L,9L,6L,5L,10L,8L,5L,9L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230261Inst : IEnumerable<long>
{
public static readonly long[] Value=A230261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230261.Bytes);
public long this[int i]=>Value[i];

public static A230261Inst Instance=new A230261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230262
{
public static readonly long[] Value={ 1L,3L,-1L,11L,-2L,1L,25L,-3L,1L,0L,137L,-4L,3L,1L,-1L,49L,-5L,2L,1L,-1L,0L,363L,-6L,5L,2L,-3L,-1L,1L,761L,-7L,3L,5L,-1L,-1L,1L,0L,7129L,-8L,7L,5L,0L,-4L,1L,1L,-1L,7381L,-9L,4L,7L,1L,-1L,-1L,1L,-1L,0L,83711L,-10L,9L,28L,49L,-29L,-5L,8L,1L,-5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230262Inst : IEnumerable<long>
{
public static readonly long[] Value=A230262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230262.Bytes);
public long this[int i]=>Value[i];

public static A230262Inst Instance=new A230262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230263
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,1L,3L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,0L,2L,0L,0L,2L,1L,0L,0L,2L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,3L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230263Inst : IEnumerable<long>
{
public static readonly long[] Value=A230263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230263.Bytes);
public long this[int i]=>Value[i];

public static A230263Inst Instance=new A230263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230264
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,3L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230264Inst : IEnumerable<long>
{
public static readonly long[] Value=A230264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230264.Bytes);
public long this[int i]=>Value[i];

public static A230264Inst Instance=new A230264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230265
{
public static readonly BigInteger[] Value={ 2L,12L,720L,30240L,1209600L,6842880L,1307674368000L,74724249600L,1524374691840000L,5109094217170944000L,BigInteger.Parse("802857662698291200000"),BigInteger.Parse("287777551824322560000"),BigInteger.Parse("1693824136731743669452800000"),BigInteger.Parse("186134520519971831808000000") };
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
public class A230265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230265Inst Instance=new A230265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230266
{
public static readonly long[] Value={ 0L,2L,2L,6L,2L,36L,2L,94L,128L,476L,2L,2044L,2L,6600L,12200L,21326L,2L,114180L,2L,420196L,611400L,1377272L,2L,6880524L,5162552L,20385176L,27057260L,93466916L,2L,449091204L,2L,1191408430L,1752427686L,4596497100L,8832507602L,27711558964L,2L,69735250200L,98612948480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230266Inst : IEnumerable<long>
{
public static readonly long[] Value=A230266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230266.Bytes);
public long this[int i]=>Value[i];

public static A230266Inst Instance=new A230266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230267
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,9L,12L,16L,17L,23L,26L,30L,35L,41L,44L,52L,57L,63L,70L,78L,83L,93L,100L,108L,117L,127L,134L,146L,155L,165L,176L,188L,197L,211L,222L,234L,247L,261L,272L,288L,301L,315L,330L,346L,359L,377L,392L,408L,425L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230267Inst : IEnumerable<long>
{
public static readonly long[] Value=A230267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230267.Bytes);
public long this[int i]=>Value[i];

public static A230267Inst Instance=new A230267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230268
{
public static readonly BigInteger[] Value={ 0L,0L,28L,5734L,5524854L,28716109350L,810027275568580L,BigInteger.Parse("124090541934393885346") };
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
public class A230268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A230268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A230268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A230268Inst Instance=new A230268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230269
{
public static readonly long[] Value={ 0L,0L,2L,8L,30L,108L,386L,1376L,4902L,17460L,62186L,221480L,788814L,2809404L,10005842L,35636336L,126920694L,452034756L,1609945658L,5733906488L,20421610782L,72732645324L,259041157538L,922588763264L,3285848604870L,11702723341140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230269Inst : IEnumerable<long>
{
public static readonly long[] Value=A230269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230269.Bytes);
public long this[int i]=>Value[i];

public static A230269Inst Instance=new A230269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A230270
{
public static readonly long[] Value={ 0L,2L,28L,258L,2318L,19996L,173042L,1495602L,12923884L,111679970L,965051522L,8339221132L,72061022634L,622694890854L,5380841364452L,46497015154242L,401790774458110L,3471961070277860L,30001967293824306L,259253494870328354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A230270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A230270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A230270Inst : IEnumerable<long>
{
public static readonly long[] Value=A230270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A230270.Bytes);
public long this[int i]=>Value[i];

public static A230270Inst Instance=new A230270Inst();

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