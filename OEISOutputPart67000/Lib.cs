using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A127357
{
public static readonly long[] Value={ 1L,2L,-5L,-28L,-11L,230L,559L,-952L,-6935L,-5302L,51811L,151340L,-163619L,-1689298L,-1906025L,11391632L,39937489L,-22649710L,-404736821L,-605626252L,2431378885L,10313394038L,-1255621889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127357Inst : IEnumerable<long>
{
public static readonly long[] Value=A127357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127357.Bytes);
public long this[int i]=>Value[i];

public static A127357Inst Instance=new A127357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127358
{
public static readonly long[] Value={ 1L,3L,8L,21L,54L,138L,350L,885L,2230L,5610L,14088L,35346L,88596L,221952L,555738L,1391061L,3480870L,8708610L,21783680L,54483510L,136254964L,340729788L,852000828L,2130354786L,5326563004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127358Inst : IEnumerable<long>
{
public static readonly long[] Value=A127358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127358.Bytes);
public long this[int i]=>Value[i];

public static A127358Inst Instance=new A127358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127359
{
public static readonly long[] Value={ 1L,4L,14L,48L,162L,544L,1820L,6080L,20290L,67680L,225684L,752448L,2508468L,8362176L,27875064L,92919168L,309734850L,1032458080L,3441543140L,11471842880L,38239537852L,127465249344L,424884399624L,1416281802368L,4720940242612L,15736469278144L,52454901060680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127359Inst : IEnumerable<long>
{
public static readonly long[] Value=A127359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127359.Bytes);
public long this[int i]=>Value[i];

public static A127359Inst Instance=new A127359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127360
{
public static readonly long[] Value={ 1L,5L,22L,95L,406L,1730L,7360L,31295L,133030L,565430L,2403172L,10213670L,43408444L,184486580L,784069252L,3332296895L,14162266630L,60189642830L,255806000260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127360Inst : IEnumerable<long>
{
public static readonly long[] Value=A127360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127360.Bytes);
public long this[int i]=>Value[i];

public static A127360Inst Instance=new A127360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127361
{
public static readonly long[] Value={ 1L,-1L,4L,-7L,22L,-46L,130L,-295L,790L,-1870L,4864L,-11782L,30148L,-73984L,187534L,-463687L,1168870L,-2902870L,7293640L,-18161170L,45541492L,-113576596L,284470564L,-710118262L,1777323772L,-4439253196L,11105933440L,-27749232700L,69403169200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127361Inst : IEnumerable<long>
{
public static readonly long[] Value=A127361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127361.Bytes);
public long this[int i]=>Value[i];

public static A127361Inst Instance=new A127361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127362
{
public static readonly long[] Value={ 1L,-2L,8L,-24L,84L,-272L,920L,-3040L,10180L,-33840L,112968L,-376224L,1254696L,-4181088L,13939248L,-46459584L,154873860L,-516229040L,1720795880L,-5735921440L,19119861304L,-63732624672L,212442552528L,-708140901184L,2360471473384L,-7868234639072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127362Inst : IEnumerable<long>
{
public static readonly long[] Value=A127362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127362.Bytes);
public long this[int i]=>Value[i];

public static A127362Inst Instance=new A127362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127363
{
public static readonly long[] Value={ 1L,-3L,14L,-57L,246L,-1038L,4424L,-18777L,79846L,-339258L,1442004L,-6128202L,26045436L,-110691948L,470442924L,-1999378137L,8497365126L,-36113785698L,153483619604L,-652305322542L,2772297736276L,-11782265148228L,50074627320864L,-212817165231882L,904472953925596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127363Inst : IEnumerable<long>
{
public static readonly long[] Value=A127363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127363.Bytes);
public long this[int i]=>Value[i];

public static A127363Inst Instance=new A127363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127364
{
public static readonly long[] Value={ 1693333L,14251277L,17306687L,18067739L,25852399L,29126567L,55781581L,62333321L,113347009L,173863769L,204308891L,211281809L,247612801L,256102939L,267030149L,267670129L,277108457L,291010691L,298502489L,337176617L,365570923L,370598051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127364Inst : IEnumerable<long>
{
public static readonly long[] Value=A127364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127364.Bytes);
public long this[int i]=>Value[i];

public static A127364Inst Instance=new A127364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127365
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,2L,2L,-3L,-3L,4L,4L,-5L,-5L,6L,6L,-7L,-7L,8L,8L,-9L,-9L,10L,10L,-11L,-11L,12L,12L,-13L,-13L,14L,14L,-15L,-15L,16L,16L,-17L,-17L,18L,18L,-19L,-19L,20L,20L,-21L,-21L,22L,22L,-23L,-23L,24L,24L,-25L,-25L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127365Inst : IEnumerable<long>
{
public static readonly long[] Value=A127365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127365.Bytes);
public long this[int i]=>Value[i];

public static A127365Inst Instance=new A127365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127366
{
public static readonly long[] Value={ 0L,2L,1L,4L,6L,3L,8L,5L,10L,12L,7L,14L,9L,16L,11L,18L,20L,13L,22L,15L,24L,17L,26L,19L,28L,30L,21L,32L,23L,34L,25L,36L,27L,38L,29L,40L,42L,31L,44L,33L,46L,35L,48L,37L,50L,39L,52L,41L,54L,56L,43L,58L,45L,60L,47L,62L,49L,64L,51L,66L,53L,68L,55L,70L,72L,57L,74L,59L,76L,61L,78L,63L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127366Inst : IEnumerable<long>
{
public static readonly long[] Value=A127366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127366.Bytes);
public long this[int i]=>Value[i];

public static A127366Inst Instance=new A127366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127367
{
public static readonly long[] Value={ 0L,2L,1L,5L,3L,7L,4L,10L,6L,12L,8L,14L,9L,17L,11L,19L,13L,21L,15L,23L,16L,26L,18L,28L,20L,30L,22L,32L,24L,34L,25L,37L,27L,39L,29L,41L,31L,43L,33L,45L,35L,47L,36L,50L,38L,52L,40L,54L,42L,56L,44L,58L,46L,60L,48L,62L,49L,65L,51L,67L,53L,69L,55L,71L,57L,73L,59L,75L,61L,77L,63L,79L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127367Inst : IEnumerable<long>
{
public static readonly long[] Value=A127367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127367.Bytes);
public long this[int i]=>Value[i];

public static A127367Inst Instance=new A127367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127384
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,62L,179L,543L,1705L,5482L,18056L,60634L,206824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127384Inst : IEnumerable<long>
{
public static readonly long[] Value=A127384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127384.Bytes);
public long this[int i]=>Value[i];

public static A127384Inst Instance=new A127384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127385
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,23L,71L,226L,743L,2500L,8570L,29828L,105116L,374308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127385Inst : IEnumerable<long>
{
public static readonly long[] Value=A127385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127385.Bytes);
public long this[int i]=>Value[i];

public static A127385Inst Instance=new A127385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127386
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,27L,79L,244L,784L,2597L,8805L,30407L,106565L,377977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127386Inst : IEnumerable<long>
{
public static readonly long[] Value=A127386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127386.Bytes);
public long this[int i]=>Value[i];

public static A127386Inst Instance=new A127386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127387
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,5L,4L,22L,21L,20L,18L,17L,14L,15L,19L,13L,12L,16L,11L,10L,9L,64L,63L,62L,59L,58L,54L,55L,61L,50L,49L,57L,48L,46L,45L,37L,38L,39L,41L,40L,51L,52L,60L,36L,35L,56L,34L,32L,31L,42L,43L,53L,28L,29L,47L,33L,27L,26L,44L,30L,25L,24L,23L,196L,195L,194L,190L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127387Inst : IEnumerable<long>
{
public static readonly long[] Value=A127387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127387.Bytes);
public long this[int i]=>Value[i];

public static A127387Inst Instance=new A127387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127388
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,22L,21L,16L,20L,18L,17L,23L,24L,25L,27L,26L,28L,29L,33L,36L,35L,30L,34L,32L,31L,37L,38L,39L,41L,40L,51L,52L,60L,64L,63L,56L,62L,59L,58L,42L,43L,53L,54L,55L,47L,61L,50L,49L,44L,57L,48L,46L,45L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127388Inst : IEnumerable<long>
{
public static readonly long[] Value=A127388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127388.Bytes);
public long this[int i]=>Value[i];

public static A127388Inst Instance=new A127388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127389
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,4L,10L,23L,56L,138L,344L,870L,2220L,5716L,14828L,38717L,101682L,268416L,711810L,1895432L,5066030L,13586082L,36547534L,98593064L,266661162L,722953814L,1964358938L,5348367006L,14589803090L,39870312218L,109136843138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127389Inst : IEnumerable<long>
{
public static readonly long[] Value=A127389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127389.Bytes);
public long this[int i]=>Value[i];

public static A127389Inst Instance=new A127389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127390
{
public static readonly long[] Value={ 13L,180L,2460L,18060L,332640L,3548160L,37837800L,311351040L,3455131680L,32639967360L,479785466160L,3379449593520L,44734582292400L,527257688958000L,3493634344200000L,31840983413038800L,408373247583100800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127390Inst : IEnumerable<long>
{
public static readonly long[] Value=A127390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127390.Bytes);
public long this[int i]=>Value[i];

public static A127390Inst Instance=new A127390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127391
{
public static readonly long[] Value={ 0L,2L,0L,0L,0L,-4L,0L,0L,0L,10L,0L,0L,0L,-20L,0L,0L,0L,36L,0L,0L,0L,-64L,0L,0L,0L,110L,0L,0L,0L,-180L,0L,0L,0L,288L,0L,0L,0L,-452L,0L,0L,0L,692L,0L,0L,0L,-1044L,0L,0L,0L,1554L,0L,0L,0L,-2276L,0L,0L,0L,3296L,0L,0L,0L,-4724L,0L,0L,0L,6696L,0L,0L,0L,-9408L,0L,0L,0L,13108L,0L,0L,0L,-18112L,0L,0L,0L,24850L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127391Inst : IEnumerable<long>
{
public static readonly long[] Value=A127391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127391.Bytes);
public long this[int i]=>Value[i];

public static A127391Inst Instance=new A127391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127392
{
public static readonly long[] Value={ 2L,-4L,10L,-20L,36L,-64L,110L,-180L,288L,-452L,692L,-1044L,1554L,-2276L,3296L,-4724L,6696L,-9408L,13108L,-18112L,24850L,-33864L,45844L,-61696L,82564L,-109892L,145536L,-191828L,251684L,-328804L,427802L,-554408L,715808L,-920896L,1180660L,-1508736L,1921896L,-2440740L,3090612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127392Inst : IEnumerable<long>
{
public static readonly long[] Value=A127392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127392.Bytes);
public long this[int i]=>Value[i];

public static A127392Inst Instance=new A127392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127393
{
public static readonly long[] Value={ 4L,-16L,56L,-160L,404L,-944L,2072L,-4320L,8648L,-16720L,31360L,-57312L,102364L,-179104L,307672L,-519808L,864960L,-1419456L,2299832L,-3682400L,5831784L,-9141808L,14194200L,-21842368L,33329700L,-50456352L,75813240L,-113107872L,167616832L,-246811504L,361218392L,-525598496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127393Inst : IEnumerable<long>
{
public static readonly long[] Value=A127393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127393.Bytes);
public long this[int i]=>Value[i];

public static A127393Inst Instance=new A127393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127394
{
public static readonly long[] Value={ 4L,18L,88L,460L,2544L,14776L,89632L,565392L,3695680L,24959776L,173752704L,1244125888L,9146568448L,68933546880L,531838104064L,4195358822656L,33800254620672L,277843218452992L,2328182040156160L,19870770461838336L,172610363453599744L,1525013813211609088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127394Inst : IEnumerable<long>
{
public static readonly long[] Value=A127394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127394.Bytes);
public long this[int i]=>Value[i];

public static A127394Inst Instance=new A127394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127395
{
public static readonly BigInteger[] Value={ 0L,0L,12L,20736L,1186099200L,4863092981760000L,BigInteger.Parse("2405722022408355840000000"),BigInteger.Parse("210982363040448544794759659520000000"),BigInteger.Parse("4417663598633083951292726052200194139750400000000"),BigInteger.Parse("28285349218442861392592006529041874362190858603724800000000000000"),BigInteger.Parse("68815738101453790475316164980880834884596607113691790965601206272000000000000000000") };
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
public class A127395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127395Inst Instance=new A127395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127396
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,13L,30L,60L,125L,256L,513L,1049L,2082L,4214L,8401L,16771L,33427L,66550L,132405L,262865L,522296L,1036033L,2055256L,4075039L,8078110L,16008485L,31720903L,62847087L,124501149L,246638355L,488559079L,967785236L,1917099175L,3797688543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127396Inst : IEnumerable<long>
{
public static readonly long[] Value=A127396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127396.Bytes);
public long this[int i]=>Value[i];

public static A127396Inst Instance=new A127396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127397
{
public static readonly long[] Value={ 0L,1L,3L,5L,4L,12L,13L,14L,2L,6L,10L,15L,17L,8L,19L,30L,34L,47L,53L,11L,16L,9L,7L,18L,31L,33L,48L,52L,29L,20L,44L,37L,27L,22L,42L,39L,25L,24L,40L,41L,23L,26L,38L,43L,21L,28L,36L,45L,55L,66L,59L,62L,63L,58L,67L,54L,46L,35L,65L,56L,69L,75L,50L,71L,57L,64L,61L,60L,68L,32L,49L,51L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127397Inst : IEnumerable<long>
{
public static readonly long[] Value=A127397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127397.Bytes);
public long this[int i]=>Value[i];

public static A127397Inst Instance=new A127397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127398
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,16L,25L,27L,16L,8L,16L,25L,32L,25L,27L,49L,64L,81L,100L,64L,27L,25L,16L,25L,49L,64L,81L,100L,81L,49L,64L,81L,64L,49L,64L,81L,64L,49L,64L,81L,64L,49L,64L,81L,64L,49L,64L,81L,100L,121L,125L,121L,125L,121L,125L,121L,100L,81L,100L,121L,125L,144L,125L,121L,128L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127398Inst : IEnumerable<long>
{
public static readonly long[] Value=A127398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127398.Bytes);
public long this[int i]=>Value[i];

public static A127398Inst Instance=new A127398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127399
{
public static readonly long[] Value={ 2L,6L,4L,6L,7L,7L,8L,11L,9L,11L,12L,14L,13L,17L,16L,19L,20L,20L,23L,23L,23L,27L,27L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127399Inst : IEnumerable<long>
{
public static readonly long[] Value=A127399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127399.Bytes);
public long this[int i]=>Value[i];

public static A127399Inst Instance=new A127399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127432
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,4L,4L,5L,3L,7L,5L,5L,5L,5L,6L,8L,5L,4L,8L,8L,5L,9L,6L,6L,8L,8L,7L,9L,7L,9L,10L,9L,4L,10L,9L,8L,12L,7L,7L,11L,9L,9L,9L,12L,9L,13L,11L,7L,9L,12L,10L,12L,9L,9L,12L,12L,13L,13L,8L,10L,13L,14L,6L,12L,12L,12L,17L,10L,11L,14L,12L,12L,9L,14L,11L,16L,13L,12L,14L,13L,9L,16L,16L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127432Inst : IEnumerable<long>
{
public static readonly long[] Value=A127432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127432.Bytes);
public long this[int i]=>Value[i];

public static A127432Inst Instance=new A127432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127433
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,4L,6L,4L,8L,5L,9L,7L,8L,8L,12L,9L,12L,9L,12L,13L,13L,14L,14L,14L,15L,17L,18L,13L,19L,18L,20L,21L,20L,22L,21L,22L,23L,20L,25L,22L,27L,23L,25L,26L,29L,29L,33L,27L,33L,29L,37L,32L,33L,33L,36L,33L,40L,34L,37L,37L,40L,37L,42L,38L,40L,41L,45L,37L,47L,42L,46L,45L,48L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127433Inst : IEnumerable<long>
{
public static readonly long[] Value=A127433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127433.Bytes);
public long this[int i]=>Value[i];

public static A127433Inst Instance=new A127433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127434
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,4L,6L,4L,6L,7L,6L,7L,9L,8L,10L,10L,10L,9L,12L,10L,12L,15L,11L,14L,14L,14L,16L,17L,15L,16L,20L,16L,19L,21L,19L,20L,23L,19L,22L,25L,23L,27L,26L,25L,27L,31L,29L,28L,33L,29L,29L,37L,33L,34L,37L,33L,35L,37L,38L,36L,42L,38L,41L,43L,36L,41L,46L,42L,43L,47L,44L,46L,49L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127434Inst : IEnumerable<long>
{
public static readonly long[] Value=A127434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127434.Bytes);
public long this[int i]=>Value[i];

public static A127434Inst Instance=new A127434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127435
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,37L,41L,67L,127L,131L,151L,157L,181L,211L,241L,251L,257L,271L,281L,307L,397L,401L,421L,431L,467L,491L,557L,571L,577L,647L,691L,701L,751L,761L,827L,907L,911L,937L,947L,967L,1061L,1097L,1151L,1277L,1291L,1307L,1321L,1367L,1567L,1571L,1861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127435Inst : IEnumerable<long>
{
public static readonly long[] Value=A127435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127435.Bytes);
public long this[int i]=>Value[i];

public static A127435Inst Instance=new A127435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127436
{
public static readonly long[] Value={ 2L,5L,17L,37L,101L,257L,1297L,1601L,4357L,15877L,16901L,22501L,24337L,32401L,44101L,57601L,62501L,65537L,72901L,78401L,93637L,156817L,160001L,176401L,184901L,217157L,240101L,309137L,324901L,331777L,417317L,476101L,490001L,562501L,577601L,682277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127436Inst : IEnumerable<long>
{
public static readonly long[] Value=A127436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127436.Bytes);
public long this[int i]=>Value[i];

public static A127436Inst Instance=new A127436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127437
{
public static readonly long[] Value={ 2L,5L,11L,13L,19L,23L,29L,37L,53L,59L,61L,67L,83L,101L,107L,131L,139L,149L,163L,173L,179L,181L,197L,211L,227L,269L,293L,317L,347L,349L,373L,379L,389L,419L,421L,443L,461L,467L,491L,509L,523L,541L,547L,557L,563L,587L,613L,619L,653L,659L,661L,677L,701L,709L,757L,773L,787L,797L,821L,827L,829L,853L,859L,877L,883L,907L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127437Inst : IEnumerable<long>
{
public static readonly long[] Value=A127437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127437.Bytes);
public long this[int i]=>Value[i];

public static A127437Inst Instance=new A127437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127438
{
public static readonly long[] Value={ 0L,3L,8L,4L,13L,8L,5L,26L,17L,50L,6L,39L,72L,69L,70L,72L,41L,87L,101L,27L,108L,56L,181L,43L,46L,109L,157L,249L,152L,26L,238L,137L,271L,100L,404L,318L,111L,450L,320L,9L,297L,104L,429L,435L,530L,478L,114L,75L,443L,186L,570L,479L,429L,172L,84L,21L,699L,563L,621L,256L,376L,474L,119L,686L,301L,295L,583L,914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127438Inst : IEnumerable<long>
{
public static readonly long[] Value=A127438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127438.Bytes);
public long this[int i]=>Value[i];

public static A127438Inst Instance=new A127438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127439
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,4L,2L,1L,2L,2L,4L,2L,2L,1L,2L,2L,4L,2L,4L,2L,1L,2L,2L,4L,2L,4L,2L,2L,1L,2L,2L,4L,2L,4L,2L,4L,2L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,2L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,2L,1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127439Inst : IEnumerable<long>
{
public static readonly long[] Value=A127439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127439.Bytes);
public long this[int i]=>Value[i];

public static A127439Inst Instance=new A127439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127440
{
public static readonly long[] Value={ -2L,0L,1L,-1L,2L,-2L,1L,0L,1L,-2L,1L,-1L,2L,0L,-1L,-1L,1L,-1L,1L,1L,0L,-2L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,1L,0L,0L,-1L,-1L,2L,0L,-1L,-1L,0L,0L,1L,0L,1L,-2L,1L,0L,0L,1L,-1L,-1L,1L,1L,-1L,1L,0L,-2L,1L,-1L,2L,-1L,0L,1L,-2L,0L,1L,1L,-2L,0L,1L,-1L,2L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127440Inst : IEnumerable<long>
{
public static readonly long[] Value=A127440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127440.Bytes);
public long this[int i]=>Value[i];

public static A127440Inst Instance=new A127440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127441
{
public static readonly long[] Value={ 3L,7L,8L,13L,23L,24L,31L,113L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127441Inst : IEnumerable<long>
{
public static readonly long[] Value=A127441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127441.Bytes);
public long this[int i]=>Value[i];

public static A127441Inst Instance=new A127441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127442
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-2L,0L,1L,-2L,0L,1L,1L,-2L,0L,1L,-1L,1L,-2L,0L,1L,-1L,2L,1L,-2L,0L,1L,-1L,2L,-2L,1L,-2L,0L,1L,-1L,2L,-2L,1L,1L,-2L,0L,1L,-1L,2L,-2L,1L,0L,1L,-2L,0L,1L,-1L,2L,-2L,1L,0L,1L,1L,-2L,0L,1L,-1L,2L,-2L,1L,0L,1L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127442Inst : IEnumerable<long>
{
public static readonly long[] Value=A127442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127442.Bytes);
public long this[int i]=>Value[i];

public static A127442Inst Instance=new A127442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127443
{
public static readonly long[] Value={ 3L,5L,7L,13L,23L,37L,47L,83L,97L,107L,127L,167L,197L,257L,313L,383L,397L,457L,463L,587L,653L,673L,677L,827L,863L,967L,1013L,1063L,1093L,1237L,1567L,1637L,1783L,1787L,1847L,1877L,1913L,2267L,2273L,2393L,2633L,2707L,2777L,2837L,2927L,2953L,3023L,3037L,3257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127443Inst : IEnumerable<long>
{
public static readonly long[] Value=A127443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127443.Bytes);
public long this[int i]=>Value[i];

public static A127443Inst Instance=new A127443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127444
{
public static readonly long[] Value={ 1L,2L,-2L,2L,-2L,0L,3L,-4L,0L,1L,2L,-2L,0L,1L,-1L,4L,-6L,0L,1L,-1L,2L,2L,-2L,0L,1L,-1L,2L,-2L,4L,-6L,0L,2L,-1L,2L,-2L,1L,3L,-4L,0L,1L,-1L,2L,-2L,1L,0L,4L,-6L,0L,2L,-2L,2L,-2L,1L,0L,1L,2L,-2L,0L,1L,-1L,2L,-2L,1L,0L,1L,-2L,6L,-10L,0L,3L,-2L,4L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127444Inst : IEnumerable<long>
{
public static readonly long[] Value=A127444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127444.Bytes);
public long this[int i]=>Value[i];

public static A127444Inst Instance=new A127444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127445
{
public static readonly long[] Value={ 1L,3L,0L,4L,2L,0L,7L,0L,3L,0L,6L,2L,3L,4L,0L,12L,4L,0L,0L,5L,0L,8L,2L,3L,4L,5L,6L,0L,15L,0L,9L,0L,5L,0L,7L,0L,13L,8L,0L,4L,5L,0L,7L,8L,0L,18L,4L,9L,8L,0L,0L,7L,0L,9L,0L,12L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,28L,8L,9L,0L,15L,0L,7L,0L,0L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127445Inst : IEnumerable<long>
{
public static readonly long[] Value=A127445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127445.Bytes);
public long this[int i]=>Value[i];

public static A127445Inst Instance=new A127445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127446
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,3L,4L,4L,0L,4L,5L,0L,0L,0L,5L,6L,6L,6L,0L,0L,6L,7L,0L,0L,0L,0L,0L,7L,8L,8L,0L,8L,0L,0L,0L,8L,9L,0L,9L,0L,0L,0L,0L,0L,9L,10L,10L,0L,0L,10L,0L,0L,0L,0L,10L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,12L,12L,12L,12L,0L,12L,0L,0L,0L,0L,0L,12L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L,14L,14L,0L,0L,0L,0L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127446Inst : IEnumerable<long>
{
public static readonly long[] Value=A127446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127446.Bytes);
public long this[int i]=>Value[i];

public static A127446Inst Instance=new A127446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127447
{
public static readonly long[] Value={ 1L,4L,0L,6L,3L,0L,12L,0L,4L,0L,10L,5L,5L,5L,0L,24L,6L,0L,0L,6L,0L,14L,7L,7L,7L,7L,7L,0L,32L,0L,16L,0L,8L,0L,8L,0L,27L,18L,0L,9L,9L,0L,9L,9L,0L,40L,10L,20L,10L,0L,0L,10L,0L,10L,0L,22L,11L,11L,11L,11L,11L,11L,11L,11L,11L,0L,72L,12L,12L,0L,24L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127447Inst : IEnumerable<long>
{
public static readonly long[] Value=A127447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127447.Bytes);
public long this[int i]=>Value[i];

public static A127447Inst Instance=new A127447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127512
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-2L,-1L,0L,0L,0L,0L,-1L,-4L,-6L,-4L,-1L,1L,5L,10L,10L,5L,1L,-1L,-6L,-15L,-20L,-15L,-6L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127512Inst : IEnumerable<long>
{
public static readonly long[] Value=A127512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127512.Bytes);
public long this[int i]=>Value[i];

public static A127512Inst Instance=new A127512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127513
{
public static readonly long[] Value={ 1L,-1L,-5L,-5L,-21L,11L,-53L,-53L,-53L,459L,-565L,-565L,-4661L,3531L,19915L,19915L,-45621L,-45621L,-307765L,-307765L,740811L,2837963L,-1356341L,-1356341L,-1356341L,32198091L,32198091L,32198091L,-236237365L,-773108277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127513Inst : IEnumerable<long>
{
public static readonly long[] Value=A127513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127513.Bytes);
public long this[int i]=>Value[i];

public static A127513Inst Instance=new A127513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127514
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-2L,-1L,1L,-3L,-3L,0L,1L,-4L,-6L,0L,-1L,1L,-5L,-10L,0L,-5L,1L,1L,-6L,-15L,0L,-15L,6L,-1L,1L,-7L,-21L,0L,-35L,21L,-7L,0L,1L,-8L,-28L,0L,-70L,56L,-28L,0L,0L,1L,-9L,-36L,0L,-126L,126L,-84L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127514Inst : IEnumerable<long>
{
public static readonly long[] Value=A127514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127514.Bytes);
public long this[int i]=>Value[i];

public static A127514Inst Instance=new A127514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127515
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,8L,6L,9L,14L,10L,11L,12L,15L,17L,16L,18L,29L,22L,20L,23L,40L,13L,21L,19L,26L,28L,44L,27L,25L,31L,35L,24L,36L,32L,37L,38L,49L,48L,42L,41L,30L,33L,45L,61L,43L,56L,51L,64L,34L,72L,63L,66L,46L,55L,68L,50L,67L,52L,39L,53L,74L,93L,54L,87L,75L,59L,71L,62L,60L,73L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127515Inst : IEnumerable<long>
{
public static readonly long[] Value=A127515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127515.Bytes);
public long this[int i]=>Value[i];

public static A127515Inst Instance=new A127515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127516
{
public static readonly long[] Value={ 1L,3L,11L,61L,137L,1019L,2143L,761L,7129L,7309L,7561L,85691L,88001L,89849L,1555153L,3169211L,1073857L,31456013L,31870133L,6465133L,150520187L,757839553L,10061458909L,3397059023L,65452148557L,66115706837L,66731868097L,67123970717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127516Inst : IEnumerable<long>
{
public static readonly long[] Value=A127516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127516.Bytes);
public long this[int i]=>Value[i];

public static A127516Inst Instance=new A127516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127517
{
public static readonly long[] Value={ 1L,2L,6L,30L,60L,420L,840L,280L,2520L,2520L,2520L,27720L,27720L,27720L,471240L,942480L,314160L,9110640L,9110640L,1822128L,41908944L,209544720L,2724081360L,908027120L,17252515280L,17252515280L,17252515280L,17252515280L,465817912560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127517Inst : IEnumerable<long>
{
public static readonly long[] Value=A127517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127517.Bytes);
public long this[int i]=>Value[i];

public static A127517Inst Instance=new A127517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127518
{
public static readonly long[] Value={ 1L,3L,8L,10L,2L,7L,4L,5L,6L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,21L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,43L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,56L,58L,59L,60L,61L,63L,62L,64L,65L,66L,67L,68L,71L,69L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127518Inst : IEnumerable<long>
{
public static readonly long[] Value=A127518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127518.Bytes);
public long this[int i]=>Value[i];

public static A127518Inst Instance=new A127518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127519
{
public static readonly long[] Value={ 1L,4L,35L,187L,247L,1849L,2059L,2227L,789L,7381L,83711L,86021L,1145993L,1171733L,1195757L,2436559L,42142223L,14274301L,275295799L,55835135L,56540567L,19093197L,444316699L,1347822955L,34052522467L,309447273803L,312536252003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127519Inst : IEnumerable<long>
{
public static readonly long[] Value=A127519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127519.Bytes);
public long this[int i]=>Value[i];

public static A127519Inst Instance=new A127519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127520
{
public static readonly long[] Value={ 1L,3L,24L,120L,120L,840L,840L,840L,280L,2520L,27720L,27720L,360360L,360360L,360360L,720720L,12252240L,4084080L,77597520L,15519504L,15519504L,5173168L,118982864L,356948592L,8923714800L,80313433200L,80313433200L,80313433200L,2329089562800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127520Inst : IEnumerable<long>
{
public static readonly long[] Value=A127520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127520.Bytes);
public long this[int i]=>Value[i];

public static A127520Inst Instance=new A127520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127521
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,6L,10L,12L,14L,16L,8L,13L,17L,19L,11L,18L,21L,23L,25L,27L,29L,15L,22L,26L,30L,32L,34L,36L,38L,40L,20L,28L,33L,37L,41L,43L,24L,35L,42L,45L,47L,49L,51L,53L,55L,57L,31L,44L,48L,52L,56L,59L,61L,63L,65L,67L,69L,71L,39L,50L,58L,62L,66L,70L,73L,75L,77L,79L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127521Inst : IEnumerable<long>
{
public static readonly long[] Value=A127521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127521.Bytes);
public long this[int i]=>Value[i];

public static A127521Inst Instance=new A127521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127522
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,8L,6L,13L,7L,9L,17L,10L,14L,11L,24L,12L,15L,18L,16L,33L,19L,25L,20L,39L,21L,26L,22L,34L,23L,27L,49L,28L,35L,29L,40L,30L,36L,31L,61L,32L,37L,41L,38L,50L,42L,75L,43L,51L,44L,62L,45L,52L,46L,91L,47L,53L,48L,63L,54L,76L,55L,64L,56L,99L,57L,65L,58L,77L,59L,66L,60L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127522Inst : IEnumerable<long>
{
public static readonly long[] Value=A127522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127522.Bytes);
public long this[int i]=>Value[i];

public static A127522Inst Instance=new A127522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127523
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,2L,2L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,2L,0L,0L,0L,2L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127523Inst : IEnumerable<long>
{
public static readonly long[] Value=A127523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127523.Bytes);
public long this[int i]=>Value[i];

public static A127523Inst Instance=new A127523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127524
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,11L,12L,20L,25L,42L,43L,81L,82L,150L,192L,287L,288L,563L,564L,982L,1277L,2182L,2183L,3658L,3785L,7108L,8659L,13101L,13102L,27827L,27828L,47768L,61025L,102355L,105689L,170882L,170883L,329651L,421547L,606283L,606284L,1193038L,1193039L,2158117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127524Inst : IEnumerable<long>
{
public static readonly long[] Value=A127524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127524.Bytes);
public long this[int i]=>Value[i];

public static A127524Inst Instance=new A127524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127525
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,12L,13L,24L,33L,60L,61L,142L,143L,289L,447L,699L,700L,1558L,1559L,3518L,5375L,8977L,8978L,17179L,20305L,40471L,54808L,98182L,98183L,242068L,242069L,477002L,695051L,1183654L,1510612L,2629806L,2629807L,5057173L,7928654L,12366025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127525Inst : IEnumerable<long>
{
public static readonly long[] Value=A127525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127525.Bytes);
public long this[int i]=>Value[i];

public static A127525Inst Instance=new A127525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127526
{
public static readonly long[] Value={ 15L,30L,91L,229L,612L,1593L,4183L,10942L,28659L,75021L,196420L,514225L,1346271L,3524574L,9227467L,24157813L,63245988L,165580137L,433494439L,1134903166L,2971215075L,7778742045L,20365011076L,53316291169L,139583862447L,365435296158L,956722026043L,2504730781957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127526Inst : IEnumerable<long>
{
public static readonly long[] Value=A127526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127526.Bytes);
public long this[int i]=>Value[i];

public static A127526Inst Instance=new A127526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127527
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,2L,2L,2L,0L,3L,4L,0L,0L,0L,2L,2L,4L,2L,0L,0L,4L,6L,0L,0L,0L,0L,0L,2L,4L,4L,0L,3L,0L,0L,0L,4L,6L,0L,4L,0L,0L,0L,0L,0L,3L,4L,8L,0L,0L,2L,0L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127527Inst : IEnumerable<long>
{
public static readonly long[] Value=A127527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127527.Bytes);
public long this[int i]=>Value[i];

public static A127527Inst Instance=new A127527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127544
{
public static readonly long[] Value={ 30L,490L,3010L,12310L,715220L,831820L,1741630L,2323520L,7089500L,13848650L,26543660L,92669720L,133230930L,271248950L,541946240L,1844349560L,2841940500L,4351078600L,4835271870L,5371315400L,10015581680L,18440293320L,37027355200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127544Inst : IEnumerable<long>
{
public static readonly long[] Value=A127544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127544.Bytes);
public long this[int i]=>Value[i];

public static A127544Inst Instance=new A127544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127545
{
public static readonly long[] Value={ 42L,420L,462L,882L,1050L,1092L,1302L,1428L,1722L,1932L,2142L,2268L,2310L,2688L,2730L,3360L,3528L,3822L,4158L,4242L,4788L,5418L,5502L,5880L,6090L,6132L,6300L,6552L,6762L,7308L,7350L,7560L,8232L,8820L,8862L,9240L,9282L,10038L,10332L,10458L,10500L,10710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127545Inst : IEnumerable<long>
{
public static readonly long[] Value=A127545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127545.Bytes);
public long this[int i]=>Value[i];

public static A127545Inst Instance=new A127545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127546
{
public static readonly long[] Value={ 2L,6L,14L,38L,98L,258L,674L,1766L,4622L,12102L,31682L,82946L,217154L,568518L,1488398L,3896678L,10201634L,26708226L,69923042L,183060902L,479259662L,1254718086L,3284894594L,8599965698L,22515002498L,58945041798L,154320122894L,404015326886L,1057725857762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127546Inst : IEnumerable<long>
{
public static readonly long[] Value=A127546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127546.Bytes);
public long this[int i]=>Value[i];

public static A127546Inst Instance=new A127546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127547
{
public static readonly long[] Value={ 4L,17L,30L,43L,56L,69L,82L,95L,108L,121L,134L,147L,160L,173L,186L,199L,212L,225L,238L,251L,264L,277L,290L,303L,316L,329L,342L,355L,368L,381L,394L,407L,420L,433L,446L,459L,472L,485L,498L,511L,524L,537L,550L,563L,576L,589L,602L,615L,628L,641L,654L,667L,680L,693L,706L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127547Inst : IEnumerable<long>
{
public static readonly long[] Value=A127547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127547.Bytes);
public long this[int i]=>Value[i];

public static A127547Inst Instance=new A127547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127548
{
public static readonly long[] Value={ 1L,1L,0L,1L,4L,19L,112L,771L,6088L,54213L,537392L,5867925L,69975308L,904788263L,12607819040L,188341689287L,3002539594128L,50878366664393L,913161208490016L,17304836525709097L,345279674107957524L,7235298537356113339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127548Inst : IEnumerable<long>
{
public static readonly long[] Value=A127548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127548.Bytes);
public long this[int i]=>Value[i];

public static A127548Inst Instance=new A127548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127549
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,3L,6L,7L,3L,6L,4L,3L,3L,5L,8L,2L,9L,0L,6L,3L,8L,3L,9L,5L,1L,6L,0L,2L,6L,4L,1L,7L,8L,2L,4L,7L,6L,3L,9L,6L,6L,8L,9L,7L,7L,1L,8L,0L,3L,2L,5L,6L,3L,4L,0L,2L,1L,0L,1L,2L,4L,4L,4L,2L,1L,4L,4L,5L,6L,4L,7L,3L,1L,7L,7L,6L,2L,7L,2L,2L,4L,3L,6L,9L,5L,3L,2L,2L,0L,1L,7L,2L,3L,8L,3L,2L,8L,1L,7L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127549Inst : IEnumerable<long>
{
public static readonly long[] Value=A127549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127549.Bytes);
public long this[int i]=>Value[i];

public static A127549Inst Instance=new A127549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127550
{
public static readonly long[] Value={ 3L,1L,9L,4L,5L,1L,3L,2L,4L,2L,7L,3L,6L,1L,9L,3L,3L,1L,2L,8L,9L,0L,9L,8L,1L,0L,5L,3L,4L,5L,0L,5L,5L,1L,7L,8L,4L,3L,8L,3L,9L,7L,4L,3L,9L,3L,1L,9L,7L,1L,1L,8L,1L,9L,3L,8L,2L,6L,7L,1L,9L,6L,9L,3L,3L,5L,4L,6L,9L,1L,2L,2L,5L,3L,6L,4L,2L,7L,6L,2L,6L,7L,5L,9L,5L,7L,8L,7L,6L,9L,8L,6L,5L,6L,1L,4L,7L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127550Inst : IEnumerable<long>
{
public static readonly long[] Value=A127550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127550.Bytes);
public long this[int i]=>Value[i];

public static A127550Inst Instance=new A127550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127551
{
public static readonly long[] Value={ 5L,1L,4L,1L,0L,3L,8L,1L,4L,1L,8L,4L,1L,2L,7L,4L,2L,2L,3L,6L,7L,9L,7L,3L,7L,8L,1L,1L,9L,9L,8L,3L,1L,7L,4L,0L,9L,2L,8L,3L,3L,0L,6L,7L,3L,9L,1L,1L,3L,5L,3L,4L,2L,0L,7L,2L,1L,1L,0L,2L,1L,0L,5L,6L,2L,5L,0L,6L,5L,6L,4L,3L,0L,4L,1L,7L,2L,5L,5L,6L,2L,1L,9L,9L,1L,2L,2L,7L,5L,9L,9L,5L,9L,1L,3L,0L,3L,5L,9L,7L,4L,4L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127551Inst : IEnumerable<long>
{
public static readonly long[] Value=A127551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127551.Bytes);
public long this[int i]=>Value[i];

public static A127551Inst Instance=new A127551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127552
{
public static readonly long[] Value={ 3L,1L,9L,6L,4L,4L,7L,1L,9L,3L,3L,8L,6L,1L,6L,8L,7L,1L,1L,1L,3L,8L,6L,8L,6L,2L,9L,5L,4L,0L,2L,0L,7L,5L,1L,7L,0L,8L,1L,9L,3L,4L,3L,1L,0L,9L,5L,0L,6L,2L,2L,9L,6L,9L,8L,6L,8L,3L,5L,7L,2L,6L,6L,9L,2L,9L,9L,9L,7L,4L,2L,6L,6L,8L,7L,5L,8L,1L,3L,0L,2L,1L,7L,7L,0L,1L,3L,0L,2L,7L,7L,0L,4L,1L,4L,2L,0L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127552Inst : IEnumerable<long>
{
public static readonly long[] Value=A127552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127552.Bytes);
public long this[int i]=>Value[i];

public static A127552Inst Instance=new A127552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127553
{
public static readonly BigInteger[] Value={ 1L,2L,18L,96L,15000L,6480L,84707280L,41287680L,21427701120L,56700000000L,94121726392108800L,2483144294400L,BigInteger.Parse("11159820050604594969600"),BigInteger.Parse("24625709514114508800"),BigInteger.Parse("620634514500000000000"),BigInteger.Parse("359450793240158011392000") };
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
public class A127553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127553Inst Instance=new A127553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127554
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,7L,10L,19L,19L,19L,19L,28L,37L,37L,55L,55L,37L,46L,46L,73L,73L,64L,82L,100L,100L,118L,109L,100L,127L,127L,145L,118L,163L,145L,154L,172L,172L,154L,181L,181L,199L,172L,226L,208L,253L,226L,262L,262L,253L,271L,235L,271L,262L,280L,325L,325L,307L,343L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127554Inst : IEnumerable<long>
{
public static readonly long[] Value=A127554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127554.Bytes);
public long this[int i]=>Value[i];

public static A127554Inst Instance=new A127554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127555
{
public static readonly long[] Value={ 4L,1L,6L,4L,3L,9L,3L,9L,2L,0L,3L,1L,3L,5L,4L,9L,0L,5L,3L,4L,1L,3L,2L,3L,9L,8L,2L,8L,7L,4L,3L,1L,2L,1L,9L,7L,4L,1L,3L,3L,3L,3L,6L,9L,1L,9L,2L,6L,2L,3L,0L,1L,1L,8L,9L,1L,9L,7L,6L,3L,6L,7L,6L,9L,0L,2L,6L,4L,9L,3L,0L,8L,8L,6L,1L,7L,5L,2L,8L,7L,1L,9L,2L,4L,2L,9L,6L,3L,1L,1L,3L,8L,9L,4L,6L,3L,6L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127555Inst : IEnumerable<long>
{
public static readonly long[] Value=A127555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127555.Bytes);
public long this[int i]=>Value[i];

public static A127555Inst Instance=new A127555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127556
{
public static readonly long[] Value={ 4L,1L,6L,3L,6L,6L,3L,5L,1L,4L,7L,3L,3L,2L,9L,1L,2L,7L,7L,0L,4L,7L,3L,6L,8L,7L,8L,3L,7L,9L,4L,6L,0L,1L,1L,3L,5L,8L,0L,5L,7L,6L,4L,4L,9L,7L,4L,6L,3L,7L,4L,3L,9L,6L,9L,1L,5L,9L,0L,3L,6L,9L,5L,1L,4L,8L,8L,9L,8L,3L,6L,6L,8L,4L,4L,8L,0L,3L,1L,3L,7L,5L,7L,8L,0L,5L,3L,7L,9L,7L,1L,6L,5L,3L,8L,4L,7L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127556Inst : IEnumerable<long>
{
public static readonly long[] Value=A127556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127556.Bytes);
public long this[int i]=>Value[i];

public static A127556Inst Instance=new A127556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127557
{
public static readonly long[] Value={ 5L,0L,1L,8L,8L,6L,5L,6L,5L,7L,3L,7L,7L,3L,7L,8L,2L,3L,3L,7L,1L,4L,1L,5L,6L,2L,8L,3L,1L,8L,1L,1L,3L,6L,8L,6L,8L,1L,3L,3L,8L,9L,4L,1L,7L,7L,1L,4L,7L,9L,8L,0L,0L,5L,7L,1L,0L,3L,8L,2L,7L,6L,1L,9L,8L,0L,4L,1L,2L,6L,4L,7L,8L,3L,6L,2L,0L,2L,4L,8L,2L,0L,2L,4L,6L,5L,5L,7L,9L,5L,9L,7L,7L,9L,6L,2L,0L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127557Inst : IEnumerable<long>
{
public static readonly long[] Value=A127557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127557.Bytes);
public long this[int i]=>Value[i];

public static A127557Inst Instance=new A127557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127558
{
public static readonly long[] Value={ 2L,9L,0L,0L,0L,6L,9L,4L,9L,2L,6L,9L,1L,7L,9L,8L,0L,1L,4L,4L,2L,3L,7L,1L,3L,5L,8L,1L,4L,0L,8L,7L,8L,4L,9L,1L,2L,0L,4L,8L,7L,4L,8L,2L,8L,7L,5L,9L,7L,5L,7L,3L,4L,7L,7L,9L,8L,4L,2L,5L,9L,3L,4L,4L,6L,1L,5L,1L,6L,0L,6L,4L,5L,0L,8L,6L,1L,3L,6L,3L,8L,3L,5L,5L,3L,0L,0L,3L,0L,9L,5L,0L,0L,9L,6L,7L,2L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127558Inst : IEnumerable<long>
{
public static readonly long[] Value=A127558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127558.Bytes);
public long this[int i]=>Value[i];

public static A127558Inst Instance=new A127558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127559
{
public static readonly long[] Value={ 7L,3L,4L,0L,0L,0L,3L,5L,3L,9L,8L,2L,2L,7L,9L,8L,5L,0L,2L,9L,7L,3L,9L,1L,8L,4L,6L,1L,5L,9L,2L,7L,6L,9L,4L,9L,1L,1L,2L,4L,7L,3L,4L,1L,2L,2L,3L,9L,9L,1L,6L,1L,1L,5L,8L,1L,5L,8L,2L,6L,1L,8L,9L,2L,4L,0L,3L,1L,3L,6L,2L,0L,9L,5L,9L,1L,6L,3L,9L,3L,0L,9L,5L,9L,1L,7L,9L,4L,0L,9L,5L,2L,7L,0L,5L,4L,2L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127559Inst : IEnumerable<long>
{
public static readonly long[] Value=A127559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127559.Bytes);
public long this[int i]=>Value[i];

public static A127559Inst Instance=new A127559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127736
{
public static readonly long[] Value={ 1L,7L,21L,46L,85L,141L,217L,316L,441L,595L,781L,1002L,1261L,1561L,1905L,2296L,2737L,3231L,3781L,4390L,5061L,5797L,6601L,7476L,8425L,9451L,10557L,11746L,13021L,14385L,15841L,17392L,19041L,20791L,22645L,24606L,26677L,28861L,31161L,33580L,36121L,38787L,41581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127736Inst : IEnumerable<long>
{
public static readonly long[] Value=A127736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127736.Bytes);
public long this[int i]=>Value[i];

public static A127736Inst Instance=new A127736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127737
{
public static readonly long[] Value={ 1L,3L,4L,3L,7L,9L,3L,7L,13L,16L,3L,7L,13L,21L,25L,3L,7L,13L,21L,31L,36L,3L,7L,13L,21L,31L,43L,49L,3L,7L,13L,21L,31L,43L,57L,64L,3L,7L,13L,21L,31L,43L,57L,73L,81L,3L,7L,13L,21L,31L,43L,57L,73L,91L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127737Inst : IEnumerable<long>
{
public static readonly long[] Value=A127737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127737.Bytes);
public long this[int i]=>Value[i];

public static A127737Inst Instance=new A127737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127738
{
public static readonly long[] Value={ 1L,3L,2L,5L,5L,3L,7L,8L,7L,4L,9L,11L,11L,9L,5L,11L,14L,15L,14L,11L,6L,13L,17L,19L,19L,17L,13L,7L,15L,20L,23L,24L,23L,20L,15L,8L,17L,23L,27L,29L,29L,27L,23L,17L,9L,19L,26L,31L,34L,35L,34L,31L,26L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127738Inst : IEnumerable<long>
{
public static readonly long[] Value=A127738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127738.Bytes);
public long this[int i]=>Value[i];

public static A127738Inst Instance=new A127738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127739
{
public static readonly long[] Value={ 1L,3L,3L,6L,6L,6L,10L,10L,10L,10L,15L,15L,15L,15L,15L,21L,21L,21L,21L,21L,21L,28L,28L,28L,28L,28L,28L,28L,36L,36L,36L,36L,36L,36L,36L,36L,45L,45L,45L,45L,45L,45L,45L,45L,45L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,66L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127739Inst : IEnumerable<long>
{
public static readonly long[] Value=A127739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127739.Bytes);
public long this[int i]=>Value[i];

public static A127739Inst Instance=new A127739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127740
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,15L,20L,28L,40L,60L,75L,100L,135L,185L,260L,312L,402L,522L,684L,906L,1218L,1421L,1785L,2254L,2863L,3661L,4718L,6139L,7016L,8640L,10680L,13256L,16528L,20712L,26104L,33120L,37260L,45153L,54873L,66888L,81801L,100395L,123696L,153063L,190323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127740Inst : IEnumerable<long>
{
public static readonly long[] Value=A127740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127740.Bytes);
public long this[int i]=>Value[i];

public static A127740Inst Instance=new A127740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127741
{
public static readonly ulong[] Value={ 1L,6L,30L,148L,755L,4044L,22841L,136056L,853452L,5625950L,38885297L,281170080L,2122313505L,16688829122L,136457754030L,1158155642512L,10186602918035L,92711977180164L,871936904575985L,8462913158427580L,84668764368102012L,872196382566014506L,9241557859113581689UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127741Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A127741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127741.Bytes);
public ulong this[int i]=>Value[i];

public static A127741Inst Instance=new A127741Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127742
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,4L,1L,3L,1L,14L,10L,4L,6L,3L,4L,1L,42L,28L,10L,4L,15L,12L,1L,8L,6L,5L,1L,132L,84L,28L,20L,42L,30L,12L,6L,20L,24L,4L,10L,10L,6L,1L,429L,264L,84L,56L,25L,126L,84L,60L,15L,12L,56L,60L,24L,24L,1L,25L,40L,10L,12L,15L,7L,1L,1430L,858L,264L,168L,140L,396L,252L,168L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127742Inst : IEnumerable<long>
{
public static readonly long[] Value=A127742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127742.Bytes);
public long this[int i]=>Value[i];

public static A127742Inst Instance=new A127742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127743
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,5L,3L,1L,22L,16L,9L,4L,1L,92L,60L,31L,14L,5L,1L,426L,252L,120L,52L,20L,6L,1L,2146L,1160L,510L,209L,80L,27L,7L,1L,11624L,5776L,2348L,904L,335L,116L,35L,8L,1L,67146L,30832L,11610L,4184L,1481L,507L,161L,44L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127743Inst : IEnumerable<long>
{
public static readonly long[] Value=A127743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127743.Bytes);
public long this[int i]=>Value[i];

public static A127743Inst Instance=new A127743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127744
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,5L,17L,38L,86L,365L,1530L,11770L,249015L,14102902L,5358889889L,19563802359728L,3359230167951553969L,BigInteger.Parse("181335944930584275675827047"),BigInteger.Parse("54416647690014492928933662292768842690"),BigInteger.Parse("6605721238793689879501639879905020611382966457124063495"),BigInteger.Parse("360539645288616164606228883801608423987740093330992456820074646988075733781755269") };
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
public class A127744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127744Inst Instance=new A127744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127745
{
public static readonly long[] Value={ 0L,0L,0L,1L,8L,50L,294L,1717L,10194L,62284L,394346L,2597266L,17827166L,127575414L,951411752L,7386583917L,59623674472L,499648882838L,4340548090590L,39033489125836L,362871600781796L,3482858492844510L,34471940635650958L,351444263328831458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127745Inst : IEnumerable<long>
{
public static readonly long[] Value=A127745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127745.Bytes);
public long this[int i]=>Value[i];

public static A127745Inst Instance=new A127745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127746
{
public static readonly long[] Value={ 2L,13L,107L,1009L,10007L,100049L,1000033L,10000169L,100000007L,1000000007L,10000000207L,100000000237L,1000000000091L,10000000000313L,100000000000261L,1000000000000273L,10000000000000079L,100000000000000049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127746Inst : IEnumerable<long>
{
public static readonly long[] Value=A127746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127746.Bytes);
public long this[int i]=>Value[i];

public static A127746Inst Instance=new A127746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127747
{
public static readonly long[] Value={ 13L,149L,1237L,12689L,345689L,1235789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127747Inst : IEnumerable<long>
{
public static readonly long[] Value=A127747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127747.Bytes);
public long this[int i]=>Value[i];

public static A127747Inst Instance=new A127747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127748
{
public static readonly long[] Value={ 97L,983L,9871L,98731L,986543L,9875321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127748Inst : IEnumerable<long>
{
public static readonly long[] Value=A127748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127748.Bytes);
public long this[int i]=>Value[i];

public static A127748Inst Instance=new A127748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127749
{
public static readonly long[] Value={ 1L,0L,3L,0L,-3L,5L,0L,3L,-5L,7L,0L,0L,0L,-7L,9L,0L,-3L,5L,0L,-9L,11L,0L,0L,0L,0L,0L,-11L,13L,0L,3L,-5L,7L,0L,0L,-13L,15L,0L,0L,0L,0L,0L,0L,0L,-15L,17L,0L,0L,0L,-7L,9L,0L,0L,0L,-17L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-19L,21L,0L,-3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127749Inst : IEnumerable<long>
{
public static readonly long[] Value=A127749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127749.Bytes);
public long this[int i]=>Value[i];

public static A127749Inst Instance=new A127749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127750
{
public static readonly long[] Value={ 1L,3L,2L,5L,2L,4L,2L,7L,2L,4L,2L,6L,2L,4L,2L,9L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,11L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,10L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,13L,2L,4L,2L,6L,2L,4L,2L,8L,2L,4L,2L,6L,2L,4L,2L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127750Inst : IEnumerable<long>
{
public static readonly long[] Value=A127750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127750.Bytes);
public long this[int i]=>Value[i];

public static A127750Inst Instance=new A127750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127751
{
public static readonly long[] Value={ 1L,0L,4L,0L,-4L,7L,0L,4L,-7L,10L,0L,0L,0L,-10L,13L,0L,-4L,7L,0L,-13L,16L,0L,0L,0L,0L,0L,-16L,19L,0L,4L,-7L,10L,0L,0L,-19L,22L,0L,0L,0L,0L,0L,0L,0L,-22L,25L,0L,0L,0L,-10L,13L,0L,0L,0L,-25L,28L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-28L,31L,0L,-4L,7L,0L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127751Inst : IEnumerable<long>
{
public static readonly long[] Value=A127751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127751.Bytes);
public long this[int i]=>Value[i];

public static A127751Inst Instance=new A127751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127816
{
public static readonly long[] Value={ 5L,34L,213L,68L,4021227877L,7L,121129L,14L,69L,26L,767L,51L,6191L,22L,201L,20L,1919L,33L,169L,44L,39L,1778L,1926049L,174L,2673413L,50L,63L,451L,1257243481237L,93L,851L,316L,183L,14809L,1969L,38L,1362959L,1826L,177L,289L,65L,87L,5567L,1252L,57L,1651L,6403249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127816Inst : IEnumerable<long>
{
public static readonly long[] Value=A127816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127816.Bytes);
public long this[int i]=>Value[i];

public static A127816Inst Instance=new A127816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127817
{
public static readonly long[] Value={ 2L,7L,6L,5L,38L,723L,74L,2592842671511L,11L,3827L,14L,717L,34L,59035L,21L,259L,152L,237L,62L,626131L,30L,169L,58L,25L,56L,1921L,39L,361L,65L,49L,63010L,287L,48L,55L,46L,63L,932L,3786791L,69L,69637L,230L,221L,6707L,1057L,57L,4907L,253L,681L,148L,393217991L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127817Inst : IEnumerable<long>
{
public static readonly long[] Value=A127817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127817.Bytes);
public long this[int i]=>Value[i];

public static A127817Inst Instance=new A127817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127818
{
public static readonly long[] Value={ 3L,14L,7L,6L,35L,94L,993L,46L,22963573117L,11L,15084115509707L,22L,21L,86L,99985L,24L,221819L,82L,327L,1996L,28039L,26L,169L,38L,39L,74L,24257L,36L,10191082613L,65L,49L,34L,4739L,66L,99965L,188L,171L,62L,3753219157L,60L,3961L,58L,87L,76L,28315L,159L,10441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127818Inst : IEnumerable<long>
{
public static readonly long[] Value=A127818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127818.Bytes);
public long this[int i]=>Value[i];

public static A127818Inst Instance=new A127818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127819
{
public static readonly long[] Value={ 2L,3L,118L,7L,39L,155L,38L,9L,14L,18659L,13L,8153L,92L,1317L,106L,35L,26L,49L,34L,57L,68L,253L,327L,1271L,28L,27L,94L,1633L,46L,161L,415L,1141L,44L,909589L,86L,161015L,119L,1293L,82L,673279L,129L,577679L,4578L,77L,164L,65L,74L,3589L,76L,147L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127819Inst : IEnumerable<long>
{
public static readonly long[] Value=A127819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127819.Bytes);
public long this[int i]=>Value[i];

public static A127819Inst Instance=new A127819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127820
{
public static readonly long[] Value={ 11L,5L,15L,10L,7L,21L,25L,34L,549L,134L,120593747L,13L,20395L,26L,1713L,20L,203L,57L,49L,62L,1707L,122L,55L,30L,793L,118L,45L,58L,1921L,38L,1853L,56L,339L,110L,4223L,42L,85L,106L,1689L,52L,841L,642L,4475L,70L,51L,551L,11683L,147L,168061L,94L,129L,623L,1243895L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127820Inst : IEnumerable<long>
{
public static readonly long[] Value=A127820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127820.Bytes);
public long this[int i]=>Value[i];

public static A127820Inst Instance=new A127820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127821
{
public static readonly long[] Value={ 2L,11L,5L,51L,44L,7L,15L,371285L,10L,74853L,158L,13757837L,17L,5805311L,22L,2181L,38L,25L,30L,9667L,74L,87L,146L,23441L,88L,19629779L,35L,45L,70L,235433L,46L,55L,34L,309L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127821Inst : IEnumerable<long>
{
public static readonly long[] Value=A127821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127821.Bytes);
public long this[int i]=>Value[i];

public static A127821Inst Instance=new A127821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127822
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127822Inst : IEnumerable<long>
{
public static readonly long[] Value=A127822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127822.Bytes);
public long this[int i]=>Value[i];

public static A127822Inst Instance=new A127822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127823
{
public static readonly BigInteger[] Value={ 1L,1L,10L,325L,22150L,2586250L,461242900L,116651486125L,39713286199150L,17511670912894750L,9709015945443877900UL,BigInteger.Parse("6610669330703494665250"),BigInteger.Parse("5422712627276230973347900"),BigInteger.Parse("5274585355686671613655544500") };
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
public class A127823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127823Inst Instance=new A127823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127824
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,5L,32L,10L,64L,3L,20L,21L,128L,6L,40L,42L,256L,12L,13L,80L,84L,85L,512L,24L,26L,160L,168L,170L,1024L,48L,52L,53L,320L,336L,340L,341L,2048L,17L,96L,104L,106L,113L,640L,672L,680L,682L,4096L,34L,35L,192L,208L,212L,213L,226L,227L,1280L,1344L,1360L,1364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127824Inst : IEnumerable<long>
{
public static readonly long[] Value=A127824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127824.Bytes);
public long this[int i]=>Value[i];

public static A127824Inst Instance=new A127824Inst();

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