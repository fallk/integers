using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A266462
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,20L,41L,82L,166L,334L,667L,1336L,2682L,5360L,10724L,21467L,42936L,85876L,171786L,343574L,687184L,1374427L,2748852L,5497766L,10995706L,21991402L,43982908L,87966150L,175932383L,351864964L,703730584L,1407461288L,2814923196L,5629847656L,11259695532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266462Inst : IEnumerable<long>
{
public static readonly long[] Value=A266462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266462.Bytes);
public long this[int i]=>Value[i];

public static A266462Inst Instance=new A266462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266463
{
public static readonly long[] Value={ 2L,4L,12L,66L,735L,18808L,1231170L,223521350L,119000455681L,193166954325425L,983670413713595700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266463Inst : IEnumerable<long>
{
public static readonly long[] Value=A266463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266463.Bytes);
public long this[int i]=>Value[i];

public static A266463Inst Instance=new A266463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266464
{
public static readonly long[] Value={ 2L,4L,7L,12L,19L,29L,42L,59L,80L,106L,137L,174L,217L,267L,324L,389L,462L,544L,635L,736L,847L,969L,1102L,1247L,1404L,1574L,1757L,1954L,2165L,2391L,2632L,2889L,3162L,3452L,3759L,4084L,4427L,4789L,5170L,5571L,5992L,6434L,6897L,7382L,7889L,8419L,8972L,9549L,10150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266464Inst : IEnumerable<long>
{
public static readonly long[] Value=A266464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266464.Bytes);
public long this[int i]=>Value[i];

public static A266464Inst Instance=new A266464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266465
{
public static readonly long[] Value={ 2L,5L,12L,29L,67L,147L,303L,590L,1090L,1922L,3253L,5311L,8400L,12918L,19377L,28425L,40873L,57722L,80196L,109776L,148240L,197703L,260666L,340063L,439318L,562401L,713894L,899055L,1123895L,1395251L,1720873L,2109508L,2570998L,3116374L,3757967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266465Inst : IEnumerable<long>
{
public static readonly long[] Value=A266465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266465.Bytes);
public long this[int i]=>Value[i];

public static A266465Inst Instance=new A266465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266466
{
public static readonly long[] Value={ 2L,6L,19L,66L,232L,794L,2574L,7797L,22058L,58469L,146027L,345578L,779240L,1682359L,3492869L,6999952L,13585959L,25610002L,47004982L,84187248L,147421139L,252829908L,425319569L,702767285L,1141951244L,1826839569L,2880058656L,4478585700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266466Inst : IEnumerable<long>
{
public static readonly long[] Value=A266466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266466.Bytes);
public long this[int i]=>Value[i];

public static A266466Inst Instance=new A266466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266467
{
public static readonly long[] Value={ 2L,7L,28L,137L,735L,4074L,22128L,113677L,544142L,2417707L,9991874L,38585111L,139969744L,479482160L,1558677189L,4829461991L,14318767180L,40765225229L,111787710303L,296081929163L,759290568963L,1889449601320L,4571408444209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266467Inst : IEnumerable<long>
{
public static readonly long[] Value=A266467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266467.Bytes);
public long this[int i]=>Value[i];

public static A266467Inst Instance=new A266467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266468
{
public static readonly long[] Value={ 2L,8L,39L,261L,2090L,18808L,175180L,1595005L,13720886L,109830369L,814603355L,5605474331L,35922351069L,215377645103L,1213816837380L,6458765687442L,32580784869691L,156385330035183L,716642920656832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266468Inst : IEnumerable<long>
{
public static readonly long[] Value=A266468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266468.Bytes);
public long this[int i]=>Value[i];

public static A266468Inst Instance=new A266468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266469
{
public static readonly long[] Value={ 2L,9L,52L,463L,5371L,77320L,1231170L,20115063L,319006954L,4768598707L,66353854322L,856330630443L,10262183989448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266469Inst : IEnumerable<long>
{
public static readonly long[] Value=A266469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266469.Bytes);
public long this[int i]=>Value[i];

public static A266469Inst Instance=new A266469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266470
{
public static readonly long[] Value={ 2L,2L,3L,2L,4L,4L,2L,5L,7L,5L,2L,6L,12L,12L,6L,2L,7L,19L,29L,19L,7L,2L,8L,28L,66L,67L,29L,8L,2L,9L,39L,137L,232L,147L,42L,9L,2L,10L,52L,261L,735L,794L,303L,59L,10L,2L,11L,67L,463L,2090L,4074L,2574L,590L,80L,11L,2L,12L,84L,775L,5371L,18808L,22128L,7797L,1090L,106L,12L,2L,13L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266470Inst : IEnumerable<long>
{
public static readonly long[] Value=A266470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266470.Bytes);
public long this[int i]=>Value[i];

public static A266470Inst Instance=new A266470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266471
{
public static readonly long[] Value={ 5L,12L,29L,66L,137L,261L,463L,775L,1237L,1898L,2817L,4064L,5721L,7883L,10659L,14173L,18565L,23992L,30629L,38670L,48329L,59841L,73463L,89475L,108181L,129910L,155017L,183884L,216921L,254567L,297291L,345593L,400005L,461092L,529453L,605722L,690569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266471Inst : IEnumerable<long>
{
public static readonly long[] Value=A266471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266471.Bytes);
public long this[int i]=>Value[i];

public static A266471Inst Instance=new A266471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266472
{
public static readonly long[] Value={ 6L,19L,67L,232L,735L,2090L,5371L,12645L,27639L,56726L,110334L,204903L,365538L,629531L,1050952L,1706538L,2703140L,4187021L,6355333L,9470138L,13875377L,20017232L,28468369L,39956595L,55398509L,75938776L,102995704L,138313857L,184024492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266472Inst : IEnumerable<long>
{
public static readonly long[] Value=A266472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266472.Bytes);
public long this[int i]=>Value[i];

public static A266472Inst Instance=new A266472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266473
{
public static readonly long[] Value={ 7L,29L,147L,794L,4074L,18808L,77320L,285494L,959672L,2975483L,8605341L,23428725L,60497931L,149066593L,352233950L,801471439L,1762213254L,3755124007L,7774777259L,15675004492L,30833594755L,59276323572L,111542905766L,205731574732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266473Inst : IEnumerable<long>
{
public static readonly long[] Value=A266473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266473.Bytes);
public long this[int i]=>Value[i];

public static A266473Inst Instance=new A266473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266474
{
public static readonly long[] Value={ 8L,42L,303L,2574L,22128L,175180L,1231170L,7652503L,42460424L,212971589L,977395362L,4147719749L,16420984346L,61103700814L,215040758842L,719522481940L,2299243641848L,7043942786447L,20758083457211L,59015575393057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266474Inst : IEnumerable<long>
{
public static readonly long[] Value=A266474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266474.Bytes);
public long this[int i]=>Value[i];

public static A266474Inst Instance=new A266474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266475
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,6L,5L,5L,5L,7L,6L,6L,6L,10L,7L,8L,8L,8L,7L,7L,9L,11L,7L,8L,9L,9L,10L,9L,11L,15L,8L,9L,8L,12L,12L,10L,9L,12L,13L,10L,14L,10L,10L,11L,15L,16L,9L,10L,10L,11L,16L,13L,9L,13L,11L,12L,17L,13L,18L,13L,11L,21L,10L,11L,19L,12L,12L,11L,20L,17L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266475Inst : IEnumerable<long>
{
public static readonly long[] Value=A266475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266475.Bytes);
public long this[int i]=>Value[i];

public static A266475Inst Instance=new A266475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266476
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,1L,2L,3L,4L,1L,2L,1L,2L,3L,3L,4L,1L,1L,5L,4L,2L,3L,2L,4L,2L,1L,5L,5L,6L,1L,2L,3L,6L,3L,1L,4L,1L,5L,6L,3L,2L,1L,7L,7L,8L,4L,2L,2L,8L,3L,5L,4L,1L,4L,1L,5L,6L,1L,9L,7L,1L,5L,6L,8L,1L,2L,2L,2L,9L,6L,10L,7L,1L,3L,3L,3L,1L,4L,10L,3L,7L,5L,1L,6L,11L,7L,8L,4L,8L,2L,1L,9L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266476Inst : IEnumerable<long>
{
public static readonly long[] Value=A266476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266476.Bytes);
public long this[int i]=>Value[i];

public static A266476Inst Instance=new A266476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266477
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,2L,2L,0L,1L,3L,2L,1L,0L,1L,4L,2L,2L,2L,0L,1L,5L,4L,2L,1L,1L,1L,1L,6L,6L,2L,3L,1L,2L,0L,2L,8L,7L,4L,4L,1L,2L,1L,0L,2L,1L,10L,8L,6L,6L,3L,2L,1L,3L,0L,1L,0L,2L,12L,13L,6L,6L,3L,7L,1L,2L,1L,1L,1L,1L,0L,1L,1L,15L,15L,9L,11L,3L,6L,2L,5L,3L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266477Inst : IEnumerable<long>
{
public static readonly long[] Value=A266477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266477.Bytes);
public long this[int i]=>Value[i];

public static A266477Inst Instance=new A266477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266478
{
public static readonly long[] Value={ 1L,0L,2L,5L,31L,136L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266478Inst : IEnumerable<long>
{
public static readonly long[] Value=A266478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266478.Bytes);
public long this[int i]=>Value[i];

public static A266478Inst Instance=new A266478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266479
{
public static readonly long[] Value={ 0L,2L,2L,6L,3L,20L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266479Inst : IEnumerable<long>
{
public static readonly long[] Value=A266479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266479.Bytes);
public long this[int i]=>Value[i];

public static A266479Inst Instance=new A266479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266480
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,15L,18L,21L,24L,28L,32L,36L,40L,45L,50L,56L,64L,72L,84L,96L,108L,120L,135L,150L,165L,180L,200L,220L,240L,264L,288L,312L,336L,364L,405L,450L,495L,540L,600L,660L,720L,792L,864L,936L,1008L,1092L,1176L,1260L,1365L,1470L,1575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266480Inst : IEnumerable<long>
{
public static readonly long[] Value=A266480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266480.Bytes);
public long this[int i]=>Value[i];

public static A266480Inst Instance=new A266480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266481
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,993L,25501L,857773L,35850795L,1795564865L,104972371417L,7022842421301L,529428563641759L,44421725002096225L,4106744812439019765L,BigInteger.Parse("414834196219620026333"),BigInteger.Parse("45462732300569936279251"),BigInteger.Parse("5373006006732947705188737"),BigInteger.Parse("681229881246574750274962225"),BigInteger.Parse("92237589983019368975021777125"),BigInteger.Parse("13283769418970268811752725081607"),BigInteger.Parse("2027649185923009220298941142143201"),BigInteger.Parse("326999803592314489529958494308640461"),BigInteger.Parse("55558592280735155060861740192416874125") };
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
public class A266481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266481Inst Instance=new A266481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266482
{
public static readonly BigInteger[] Value={ 1L,1L,7L,118L,3373L,139096L,7565779L,513277024L,41820455065L,3982842285184L,434457816912991L,53434112376345856L,7317518431787267653L,BigInteger.Parse("1104465712210096168960"),BigInteger.Parse("182183636400541105459627"),BigInteger.Parse("32609250878782525222260736"),BigInteger.Parse("6295153043394143761311198769"),BigInteger.Parse("1303848990485145459272159297536"),BigInteger.Parse("288415207140946760926622987982775"),BigInteger.Parse("67863051757810284274576363569872896"),BigInteger.Parse("16924929956887283486906002826128780381"),BigInteger.Parse("4459845456377312896416211474995205636096") };
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
public class A266482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266482Inst Instance=new A266482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266483
{
public static readonly BigInteger[] Value={ 1L,1L,9L,205L,8033L,456561L,34307545L,3219222301L,363018204225L,47866764942721L,7230829461286121L,1231746006983485005L,BigInteger.Parse("233652055492688836129"),BigInteger.Parse("48852757000944980067505"),BigInteger.Parse("11163401061821489604439737"),BigInteger.Parse("2768164393136241898192002781"),BigInteger.Parse("740339555234437428570144337025"),BigInteger.Parse("212438189627800855103688740374401"),BigInteger.Parse("65104233055709355841104275116309705"),BigInteger.Parse("21223353839635626633833547837080498509"),BigInteger.Parse("7333306933167926737746819644785091452641") };
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
public class A266483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266483Inst Instance=new A266483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266484
{
public static readonly BigInteger[] Value={ 1L,1L,11L,316L,15741L,1140376L,109350271L,13100626176L,1886686497401L,317762099341696L,61318533545522451L,13343942849386863616UL,BigInteger.Parse("3233753469962945660341"),BigInteger.Parse("863794149132594286734336"),BigInteger.Parse("252178372791563562485494151"),BigInteger.Parse("79890921514691257167186558976"),BigInteger.Parse("27298165065421976828646695794161"),BigInteger.Parse("10007689235634878438090676073824256"),BigInteger.Parse("3918413783588692571816707646546345371"),BigInteger.Parse("1631982989611299844119224469019967225856"),BigInteger.Parse("720447625733586591482575137323090206302701") };
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
public class A266484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266484Inst Instance=new A266484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266485
{
public static readonly BigInteger[] Value={ 1L,1L,9L,193L,6929L,356001L,24004825L,2012327521L,202156421409L,23701550853313L,3179302948594601L,480443117415138945L,BigInteger.Parse("80788534008942735409"),BigInteger.Parse("14965275494082095616097"),BigInteger.Parse("3028424508967743713615481"),BigInteger.Parse("664790043100841638943719201"),BigInteger.Parse("157352199248412053285546165825"),BigInteger.Parse("39950540529265571984889165180801"),BigInteger.Parse("10830877380135708660866040332928841"),BigInteger.Parse("3122931260561996112629450841975721537"),BigInteger.Parse("954295119605498820582898590882294309201"),BigInteger.Parse("308072983118017949662843148184536037793825") };
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
public class A266485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266485Inst Instance=new A266485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266486
{
public static readonly BigInteger[] Value={ 1L,1L,13L,415L,22321L,1721101L,174252997L,21935478979L,3308902366945L,582483654850105L,117302814498577501L,BigInteger.Parse("26610247617703733479"),BigInteger.Parse("6716634535536518884177"),BigInteger.Parse("1867456548257171896034245"),BigInteger.Parse("567177496490226897535216405"),BigInteger.Parse("186852683125922747089699211851"),BigInteger.Parse("66371163246016212237620717414593"),BigInteger.Parse("25287323016605747194753141853886961"),BigInteger.Parse("10287301449354981886046538248627595565"),BigInteger.Parse("4450859089975905722184296672608494825775"),BigInteger.Parse("2040775907870521098252331495354110194770801") };
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
public class A266486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266486Inst Instance=new A266486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266487
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,31L,-559L,14541L,-496811L,21081859L,-1070585055L,63366015673L,-4285932328819L,326248732427751L,-27610580638457807L,2572239828612623365L,BigInteger.Parse("-261621661000490429211"),BigInteger.Parse("28849626308051995285771"),BigInteger.Parse("-3428690784657696770593471"),BigInteger.Parse("436924188109882619766249201"),BigInteger.Parse("-59432725217403244945921112675"),BigInteger.Parse("8595527924368773785463788378287"),BigInteger.Parse("-1317123285394547040368548520041839"),BigInteger.Parse("213171869078193696050387803319525821"),BigInteger.Parse("-36338236299957647745418230431675850763"),BigInteger.Parse("6507698606647750492700809995200106342675"),BigInteger.Parse("-1221579456277487714539848255959245396739999") };
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
public class A266487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266487Inst Instance=new A266487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266488
{
public static readonly long[] Value={ 1L,1L,0L,1L,4L,0L,1L,12L,42L,0L,1L,24L,216L,752L,0L,1L,40L,660L,5440L,19360L,0L,1L,60L,1560L,22320L,178920L,654912L,0L,1L,84L,3150L,68320L,916440L,7316064L,27546736L,0L,1L,112L,5712L,173600L,3432800L,44693376L,359051392L,1388207872L,0L,1L,144L,9576L,387072L,10493280L,197261568L,2536797312L,20605529088L,81621893376L,0L,1L,180L,15120L,782880L,27735120L,702777600L,12845683200L,164732083200L,1355581612800L,5488951731200L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266488Inst : IEnumerable<long>
{
public static readonly long[] Value=A266488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266488.Bytes);
public long this[int i]=>Value[i];

public static A266488Inst Instance=new A266488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266489
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,132L,2180L,49098L,1428602L,51861128L,2290563882L,120711239660L,7471093468410L,535933804067208L,44060201848627588L,4111355981400939334L,BigInteger.Parse("431786985294905499210"),BigInteger.Parse("50663195235220478779600"),BigInteger.Parse("6598130071439135197135148"),BigInteger.Parse("948275969180128193372319072"),BigInteger.Parse("149616545823954331322891664338"),BigInteger.Parse("25794482347497414602697490580980"),BigInteger.Parse("4838842400288250170248755274833588") };
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
public class A266489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266489Inst Instance=new A266489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266490
{
public static readonly BigInteger[] Value={ 1L,1L,4L,20L,126L,972L,8876L,93580L,1119328L,14986944L,222184136L,3614288272L,64022264176L,1226914925840L,25295189791296L,558317369479616L,13136590271813856L,328243850207690432L,8680766764223956416L,BigInteger.Parse("242245419192494844096"),BigInteger.Parse("7113910552105144027136"),BigInteger.Parse("219304957649505551899136"),BigInteger.Parse("7081169542830272102170752"),BigInteger.Parse("238996807468258679150596352") };
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
public class A266490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266490Inst Instance=new A266490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266491
{
public static readonly long[] Value={ 0L,1L,4L,6L,4L,5L,12L,14L,8L,9L,20L,22L,12L,13L,28L,30L,16L,17L,36L,38L,20L,21L,44L,46L,24L,25L,52L,54L,28L,29L,60L,62L,32L,33L,68L,70L,36L,37L,76L,78L,40L,41L,84L,86L,44L,45L,92L,94L,48L,49L,100L,102L,52L,53L,108L,110L,56L,57L,116L,118L,60L,61L,124L,126L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266491Inst : IEnumerable<long>
{
public static readonly long[] Value=A266491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266491.Bytes);
public long this[int i]=>Value[i];

public static A266491Inst Instance=new A266491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266492
{
public static readonly long[] Value={ 1L,0L,1L,4L,187L,7400L,573865L,58849205L,8029423880L,1380758051751L,292145368826808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266492Inst : IEnumerable<long>
{
public static readonly long[] Value=A266492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266492.Bytes);
public long this[int i]=>Value[i];

public static A266492Inst Instance=new A266492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266493
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,4L,9L,1L,0L,1L,25L,187L,44L,1L,0L,1L,133L,8088L,7400L,265L,1L,0L,4L,1094L,475606L,3488445L,573865L,1854L,1L,0L,13L,9358L,34126530L,2418377365L,3542542406L,58849205L,14833L,1L,0L,43L,101927L,2913831633L,2055719492942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266493Inst : IEnumerable<long>
{
public static readonly long[] Value=A266493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266493.Bytes);
public long this[int i]=>Value[i];

public static A266493Inst Instance=new A266493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266494
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,13L,43L,126L,324L,778L,1793L,3987L,8829L,19834L,45595L,108018L,262830L,649760L,1616712L,4017230L,9918783L,24298995L,59106475L,143053466L,345488182L,834978806L,2023884376L,4926308771L,12044390596L,29559301171L,72735281708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266494Inst : IEnumerable<long>
{
public static readonly long[] Value=A266494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266494.Bytes);
public long this[int i]=>Value[i];

public static A266494Inst Instance=new A266494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266495
{
public static readonly long[] Value={ 2L,4L,25L,133L,1094L,9358L,101927L,1164886L,16185022L,224916371L,3516365203L,53601466944L,875619141848L,13926085250073L,231472156648357L,3765127321086759L,63122767580658121L,1041182791473840225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266495Inst : IEnumerable<long>
{
public static readonly long[] Value=A266495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266495.Bytes);
public long this[int i]=>Value[i];

public static A266495Inst Instance=new A266495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266496
{
public static readonly long[] Value={ 9L,187L,8088L,475606L,34126530L,2913831633L,286927411662L,31264307869299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266496Inst : IEnumerable<long>
{
public static readonly long[] Value=A266496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266496.Bytes);
public long this[int i]=>Value[i];

public static A266496Inst Instance=new A266496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266497
{
public static readonly long[] Value={ 1L,3L,9L,27L,79L,225L,627L,1717L,4633L,12341L,32501L,84737L,218959L,561263L,1428287L,3610671L,9072367L,22668285L,56345835L,139382713L,343242533L,841713531L,2055944117L,5003148987L,12132552115L,29323810757L,70651867863L,169719163521L,406541986857L,971192810019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266497Inst : IEnumerable<long>
{
public static readonly long[] Value=A266497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266497.Bytes);
public long this[int i]=>Value[i];

public static A266497Inst Instance=new A266497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266498
{
public static readonly long[] Value={ 2L,3L,4L,7L,13L,22L,38L,66L,115L,198L,344L,595L,1031L,1786L,3093L,5357L,9279L,16071L,27836L,48213L,83508L,144640L,250524L,433920L,751571L,1301759L,2254713L,3905278L,6764140L,11715834L,20292419L,35147501L,60877257L,105442502L,182631770L,316327505L,547895310L,948982514L,1643685930L,2846947542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266498Inst : IEnumerable<long>
{
public static readonly long[] Value=A266498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266498.Bytes);
public long this[int i]=>Value[i];

public static A266498Inst Instance=new A266498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266499
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,8L,1L,5L,1L,11L,6L,5L,1L,48L,7L,9L,21L,39L,1L,104L,1L,143L,27L,20L,45L,457L,1L,32L,58L,620L,1L,549L,1L,363L,514L,65L,1L,4302L,118L,858L,207L,926L,1L,4080L,437L,5171L,382L,181L,1L,20398L,1L,251L,4287L,20582L,1212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266499Inst : IEnumerable<long>
{
public static readonly long[] Value=A266499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266499.Bytes);
public long this[int i]=>Value[i];

public static A266499Inst Instance=new A266499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266500
{
public static readonly long[] Value={ 0L,0L,4L,12L,1708L,159860L,171320524L,365118796448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266500Inst : IEnumerable<long>
{
public static readonly long[] Value=A266500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266500.Bytes);
public long this[int i]=>Value[i];

public static A266500Inst Instance=new A266500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266501
{
public static readonly long[] Value={ 1L,2L,12L,500L,63828L,33394572L,68548156212L,562584834624864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266501Inst : IEnumerable<long>
{
public static readonly long[] Value=A266501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266501.Bytes);
public long this[int i]=>Value[i];

public static A266501Inst Instance=new A266501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266502
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266502Inst : IEnumerable<long>
{
public static readonly long[] Value=A266502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266502.Bytes);
public long this[int i]=>Value[i];

public static A266502Inst Instance=new A266502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266503
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,15L,105L,735L,4095L,26775L,162855L,1105335L,7187895L,51126075L,356831475L,2676468795L,19890931515L,156769986555L,1232704469115L,10178240218875L,84190426730235L,725667326178795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266503Inst : IEnumerable<long>
{
public static readonly long[] Value=A266503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266503.Bytes);
public long this[int i]=>Value[i];

public static A266503Inst Instance=new A266503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266504
{
public static readonly long[] Value={ 2L,2L,1L,3L,4L,8L,9L,19L,22L,46L,53L,111L,128L,268L,309L,647L,746L,1562L,1801L,3771L,4348L,9104L,10497L,21979L,25342L,53062L,61181L,128103L,147704L,309268L,356589L,746639L,860882L,1802546L,2078353L,4351731L,5017588L,10506008L,12113529L,25363747L,29244646L,61233502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266504Inst : IEnumerable<long>
{
public static readonly long[] Value=A266504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266504.Bytes);
public long this[int i]=>Value[i];

public static A266504Inst Instance=new A266504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266505
{
public static readonly long[] Value={ -1L,1L,3L,5L,5L,11L,13L,27L,31L,65L,75L,157L,181L,379L,437L,915L,1055L,2209L,2547L,5333L,6149L,12875L,14845L,31083L,35839L,75041L,86523L,181165L,208885L,437371L,504293L,1055907L,1217471L,2549185L,2939235L,6154277L,7095941L,14857739L,17131117L,35869755L,41358175L,86597249L,99847467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266505Inst : IEnumerable<long>
{
public static readonly long[] Value=A266505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266505.Bytes);
public long this[int i]=>Value[i];

public static A266505Inst Instance=new A266505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266506
{
public static readonly long[] Value={ 2L,-1L,2L,1L,1L,3L,3L,5L,4L,5L,8L,11L,9L,13L,19L,27L,22L,31L,46L,65L,53L,75L,111L,157L,128L,181L,268L,379L,309L,437L,647L,915L,746L,1055L,1562L,2209L,1801L,2547L,3771L,5333L,4348L,6149L,9104L,12875L,10497L,14845L,21979L,31083L,25342L,35839L,53062L,75041L,61181L,86523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266506Inst : IEnumerable<long>
{
public static readonly long[] Value=A266506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266506.Bytes);
public long this[int i]=>Value[i];

public static A266506Inst Instance=new A266506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266507
{
public static readonly long[] Value={ 2L,8L,46L,268L,1562L,9104L,53062L,309268L,1802546L,10506008L,61233502L,356895004L,2080136522L,12123924128L,70663408246L,411856525348L,2400475743842L,13990997937704L,81545511882382L,475282073356588L,2770146928257146L,16145599496186288L,94103450048860582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266507Inst : IEnumerable<long>
{
public static readonly long[] Value=A266507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266507.Bytes);
public long this[int i]=>Value[i];

public static A266507Inst Instance=new A266507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266508
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10101L,101011L,1010101L,10101011L,101010101L,1010101011L,10101010101L,101010101011L,1010101010101L,10101010101011L,101010101010101L,1010101010101011L,10101010101010101L,101010101010101011L,1010101010101010101L,10101010101010101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266508Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A266508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266508.Bytes);
public ulong this[int i]=>Value[i];

public static A266508Inst Instance=new A266508Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266509
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,3L,1L,1L,3L,3L,5L,5L,7L,7L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,5L,5L,11L,11L,17L,17L,23L,23L,29L,29L,35L,35L,41L,41L,31L,31L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,5L,5L,11L,11L,17L,17L,23L,23L,29L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266509Inst : IEnumerable<long>
{
public static readonly long[] Value=A266509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266509.Bytes);
public long this[int i]=>Value[i];

public static A266509Inst Instance=new A266509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266510
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,7L,10L,11L,12L,15L,18L,23L,28L,35L,42L,43L,44L,47L,50L,55L,60L,67L,74L,79L,84L,95L,106L,123L,140L,155L,170L,171L,172L,175L,178L,183L,188L,195L,202L,207L,212L,223L,234L,251L,268L,283L,298L,303L,308L,319L,330L,347L,364L,387L,410L,439L,468L,503L,538L,579L,620L,651L,682L,683L,684L,687L,690L,695L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266510Inst : IEnumerable<long>
{
public static readonly long[] Value=A266510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266510.Bytes);
public long this[int i]=>Value[i];

public static A266510Inst Instance=new A266510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266511
{
public static readonly long[] Value={ 0L,2L,12L,8L,36L,16L,60L,26L,84L,34L,132L,46L,168L,56L,180L,74L,240L,82L,252L,94L,324L,106L,372L,118L,420L,134L,432L,142L,492L,146L,540L,158L,600L,166L,648L,178L,660L,194L,720L,202L,780L,214L,816L,226L,840L,254L,912L,262L,1020L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266511Inst : IEnumerable<long>
{
public static readonly long[] Value=A266511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266511.Bytes);
public long this[int i]=>Value[i];

public static A266511Inst Instance=new A266511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266512
{
public static readonly BigInteger[] Value={ 2L,3L,47L,5L,18713L,7L,12003179L,17L,1480028129L,13L,1542186111157L,41280160361347L,660287401247633L,10421030292115097L,3112462738414697093L,996689250471604163L,BigInteger.Parse("258406392900394343851") };
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
public class A266512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266512Inst Instance=new A266512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266513
{
public static readonly BigInteger[] Value={ 0L,1L,11L,110L,2402L,128967L,16767653L,5436906668L,4406952731948L,8819634719356421L,BigInteger.Parse("43329348004927734247"),BigInteger.Parse("522235268182347360718818"),BigInteger.Parse("15436131339319739257518081878"),BigInteger.Parse("1117847654274955574635482276231683"),BigInteger.Parse("198163274851163063009517020867737770265") };
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
public class A266513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266513Inst Instance=new A266513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266514
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266514Inst : IEnumerable<long>
{
public static readonly long[] Value=A266514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266514.Bytes);
public long this[int i]=>Value[i];

public static A266514Inst Instance=new A266514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266515
{
public static readonly BigInteger[] Value={ 1L,11L,100L,1101111L,10000L,11110111111L,1000000L,111111011111111L,100000000L,1111111101111111111L,10000000000L,BigInteger.Parse("11111111110111111111111"),1000000000000L,BigInteger.Parse("111111111111011111111111111"),100000000000000L,BigInteger.Parse("1111111111111101111111111111111"),10000000000000000L };
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
public class A266515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266515Inst Instance=new A266515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266516
{
public static readonly long[] Value={ 1L,3L,4L,111L,16L,1983L,64L,32511L,256L,523263L,1024L,8384511L,4096L,134201343L,16384L,2147418111L,65536L,34359476223L,262144L,549754765311L,1048576L,8796088827903L,4194304L,140737471578111L,16777216L,2251799746576383L,67108864L,36028796750528511L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266516Inst : IEnumerable<long>
{
public static readonly long[] Value=A266516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266516.Bytes);
public long this[int i]=>Value[i];

public static A266516Inst Instance=new A266516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266517
{
public static readonly long[] Value={ 5L,11L,239L,4073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266517Inst : IEnumerable<long>
{
public static readonly long[] Value=A266517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266517.Bytes);
public long this[int i]=>Value[i];

public static A266517Inst Instance=new A266517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266518
{
public static readonly BigInteger[] Value={ 1L,2L,18L,200L,3290L,61992L,1480248L,39402792L,1229123610L,42349478600L,1640551617848L,69364811821032L,3222214209737432L,161656803984848200L,8772238289222220600L,BigInteger.Parse("509677254444910662000"),BigInteger.Parse("31677425399312755814970"),BigInteger.Parse("2092539622373193784503240") };
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
public class A266518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266518Inst Instance=new A266518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266519
{
public static readonly BigInteger[] Value={ 1L,15L,683L,62038L,9342629L,2100483216L,658746323647L,274730459045232L,147034646085347145L,BigInteger.Parse("98233150285382861440"),BigInteger.Parse("80135799180812308488851"),BigInteger.Parse("78391682820973752124219392"),BigInteger.Parse("90580896598669336052642926957"),BigInteger.Parse("122061249780317702369474934804480"),BigInteger.Parse("189729092979696204185243101261174695"),BigInteger.Parse("336959230406443195042628708778757175296"),BigInteger.Parse("678101445794980815528276151098815880395921") };
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
public class A266519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266519Inst Instance=new A266519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266520
{
public static readonly BigInteger[] Value={ 4L,65L,3252L,319422L,51147492L,12057585792L,3922351554132L,1682965461982320L,921043932965502660L,BigInteger.Parse("626381920753520549760"),BigInteger.Parse("518386843395242486312436"),BigInteger.Parse("513135100084662037473481728"),BigInteger.Parse("598802670522558079363471420836"),BigInteger.Parse("813678320999818358850938259419136"),BigInteger.Parse("1273853548265201707125719549854268820"),BigInteger.Parse("2276462439285471707026207820594795624448") };
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
public class A266520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266520Inst Instance=new A266520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266521
{
public static readonly long[] Value={ 1L,2L,1L,15L,28L,18L,4L,683L,1278L,933L,316L,42L,62038L,117440L,92680L,38240L,8272L,752L,9342629L,17880090L,14855385L,6881640L,1880340L,288048L,19360L,2100483216L,4054752672L,3490688496L,1743156480L,547098240L,108228192L,12523584L,654912L,658746323647L,1279910119670L,1130161189549L,594323331364L,204256939502L,47125635760L,7147508032L,652959872L,27546736L,274730459045232L,536368375356928L,482514140459520L,263340552849920L,96404466197760L,24628940050176L,4404380994048L,533057051648L,39701769216L,1388207872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266521Inst : IEnumerable<long>
{
public static readonly long[] Value=A266521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266521.Bytes);
public long this[int i]=>Value[i];

public static A266521Inst Instance=new A266521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266522
{
public static readonly BigInteger[] Value={ 1L,2L,22L,432L,12220L,451480L,20591784L,1117635008L,70348179472L,5037843612960L,404453425948000L,35977638091065088L,3512312454013520832L,BigInteger.Parse("373346162796913784192"),BigInteger.Parse("42922941487808176036480"),BigInteger.Parse("5307003951337894697856000"),BigInteger.Parse("702183042248318469458657536"),BigInteger.Parse("98997224309112273722486891008"),BigInteger.Parse("14815674464782854979394204308992"),BigInteger.Parse("2345767767928443601985964232355840"),BigInteger.Parse("391750020994050554579656281189760000"),BigInteger.Parse("68820978855281989513379320801711429632") };
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
public class A266522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266522Inst Instance=new A266522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266523
{
public static readonly BigInteger[] Value={ 1L,3L,54L,1737L,80460L,4866075L,363195144L,32252007249L,3320837109648L,388974074329395L,51071746190248800L,7429243977263853657L,BigInteger.Parse("1185973466659967427264"),BigInteger.Parse("206128694834273499148107"),BigInteger.Parse("38747184998101320725389440"),BigInteger.Parse("7832602778214436587234950625"),BigInteger.Parse("1694328566956587966290832896256"),BigInteger.Parse("390523839870137752804243701312099"),BigInteger.Parse("95545779571238219801892087161845248"),BigInteger.Parse("24730355203857044123269648640967753705"),BigInteger.Parse("6751503716745494652518864431722119040000"),BigInteger.Parse("1938877409334089151858199776112230794503803") };
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
public class A266523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266523Inst Instance=new A266523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266524
{
public static readonly BigInteger[] Value={ 1L,4L,100L,4464L,286816L,24053120L,2488967136L,306383969920L,43726697867008L,7098711727021056L,1291743506952832000L,BigInteger.Parse("260410631081389420544"),BigInteger.Parse("57609344863582419640320"),BigInteger.Parse("13875489289115958335143936"),BigInteger.Parse("3614364399291754755286614016"),BigInteger.Parse("1012444950785630853817442304000"),BigInteger.Parse("303479487751656117544078504493056"),BigInteger.Parse("96925825525767333731669511270563840"),BigInteger.Parse("32859305845564004294368688506268024832"),BigInteger.Parse("11784943093649049136596829229809817092096"),BigInteger.Parse("4458038385946160559288726139220234076160000"),BigInteger.Parse("1773928724624151210275576625473634276174987264"),BigInteger.Parse("740706616375525604793089813921394696991733186560") };
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
public class A266524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266524Inst Instance=new A266524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266525
{
public static readonly BigInteger[] Value={ 1L,5L,160L,9135L,750400L,80441425L,10638828000L,1673678753075L,305252823558400L,63325918470124125L,14724939203560768000UL,BigInteger.Parse("3793154255510116564375"),BigInteger.Parse("1072236911373050595840000"),BigInteger.Parse("329985748809343574149723625"),BigInteger.Parse("109830285822698899619230720000"),BigInteger.Parse("39309730439858456963398059166875"),BigInteger.Parse("15055402080033663459327206195200000"),BigInteger.Parse("6143747797144623366547686616298003125"),BigInteger.Parse("2661215654340427415860408455902822400000"),BigInteger.Parse("1219479030123689259752174147774198563109375"),BigInteger.Parse("589404548968234611551047396687998740070400000"),BigInteger.Parse("299658512455145134987556717044427762586006890625"),BigInteger.Parse("159865819819818837465659104892463315321094144000000") };
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
public class A266525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266525Inst Instance=new A266525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266526
{
public static readonly BigInteger[] Value={ 1L,4L,42L,752L,19360L,654912L,27546736L,1388207872L,81621893376L,5488951731200L,415721105434624L,35026876903256064L,3250356630453317632L,BigInteger.Parse("329437813126362185728"),BigInteger.Parse("36214170617862339840000"),BigInteger.Parse("4291812357982293898231808"),BigInteger.Parse("545518054282041342531076096"),BigInteger.Parse("74032137722410904128877494272"),BigInteger.Parse("10684317262536125210489796296704"),BigInteger.Parse("1634019721630446295055397683200000") };
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
public class A266526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266526Inst Instance=new A266526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266527
{
public static readonly BigInteger[] Value={ 1L,5L,11L,131L,3421L,56209L,1049105L,18561659L,334918459L,5997328339L,107703879581L,1932077585345L,34673771913121L,622167861459451L,11164539354582251L,200338227165577379L,3594932551574173405L,BigInteger.Parse("64508386001097153649"),BigInteger.Parse("1157556438367284595889") };
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
public class A266527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A266527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A266527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A266527Inst Instance=new A266527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266528
{
public static readonly long[] Value={ 8L,1L,8L,3L,1L,2L,11L,5L,1L,1L,42L,1L,2L,11L,3L,21L,1L,3L,2L,5L,2L,3L,3L,1L,7L,1L,3L,1L,22L,4L,1L,2L,1L,2L,8L,1L,1L,3L,5L,13L,2L,2L,1L,1L,2L,27L,3L,3L,2L,1L,2L,1L,7L,6L,3L,5L,1L,2L,7L,2L,5L,15L,1L,17L,1L,13L,4L,1L,2L,2L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266528Inst : IEnumerable<long>
{
public static readonly long[] Value=A266528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266528.Bytes);
public long this[int i]=>Value[i];

public static A266528Inst Instance=new A266528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266529
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,3L,1L,1L,3L,3L,5L,5L,7L,7L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,5L,5L,11L,11L,17L,17L,19L,19L,21L,21L,39L,39L,49L,49L,31L,31L,1L,1L,3L,3L,5L,5L,7L,7L,5L,5L,11L,11L,17L,17L,15L,15L,5L,5L,11L,11L,17L,17L,19L,19L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266529Inst : IEnumerable<long>
{
public static readonly long[] Value=A266529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266529.Bytes);
public long this[int i]=>Value[i];

public static A266529Inst Instance=new A266529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266530
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,7L,10L,11L,12L,15L,18L,23L,28L,35L,42L,43L,44L,47L,50L,55L,60L,67L,74L,79L,84L,95L,106L,123L,140L,155L,170L,171L,172L,175L,178L,183L,188L,195L,202L,207L,212L,223L,234L,251L,268L,283L,298L,303L,308L,319L,330L,347L,364L,383L,402L,423L,444L,483L,522L,571L,620L,651L,682L,683L,684L,687L,690L,695L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266530Inst : IEnumerable<long>
{
public static readonly long[] Value=A266530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266530.Bytes);
public long this[int i]=>Value[i];

public static A266530Inst Instance=new A266530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266531
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,8L,6L,18L,15L,16L,7L,25L,21L,81L,32L,10L,36L,27L,162L,45L,64L,11L,49L,30L,324L,63L,729L,128L,12L,50L,33L,625L,75L,1458L,105L,256L,13L,72L,35L,648L,90L,2916L,135L,225L,512L,14L,98L,39L,1250L,99L,5832L,165L,441L,405L,1024L,17L,100L,42L,1296L,117L,11664L,189L,450L,567L,59049L,2048L,19L,121L,51L,2401L,126L,15625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266531Inst : IEnumerable<long>
{
public static readonly long[] Value=A266531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266531.Bytes);
public long this[int i]=>Value[i];

public static A266531Inst Instance=new A266531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266532
{
public static readonly long[] Value={ 0L,1L,4L,7L,16L,19L,28L,37L,58L,61L,70L,79L,100L,109L,130L,151L,196L,199L,208L,217L,238L,247L,268L,289L,334L,343L,364L,385L,430L,451L,496L,541L,634L,637L,646L,655L,676L,685L,706L,727L,772L,781L,802L,823L,868L,889L,934L,979L,1072L,1081L,1102L,1123L,1168L,1189L,1234L,1279L,1372L,1393L,1438L,1483L,1576L,1621L,1714L,1807L,1996L,1999L,2008L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266532Inst : IEnumerable<long>
{
public static readonly long[] Value=A266532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266532.Bytes);
public long this[int i]=>Value[i];

public static A266532Inst Instance=new A266532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266533
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,9L,9L,21L,3L,9L,9L,21L,9L,21L,21L,45L,3L,9L,9L,21L,9L,21L,21L,45L,9L,21L,21L,45L,21L,45L,45L,93L,3L,9L,9L,21L,9L,21L,21L,45L,9L,21L,21L,45L,21L,45L,45L,93L,9L,21L,21L,45L,21L,45L,45L,93L,21L,45L,45L,93L,45L,93L,93L,189L,3L,9L,9L,21L,9L,21L,21L,45L,9L,21L,21L,45L,21L,45L,45L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266533Inst : IEnumerable<long>
{
public static readonly long[] Value=A266533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266533.Bytes);
public long this[int i]=>Value[i];

public static A266533Inst Instance=new A266533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266534
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,10L,13L,16L,21L,24L,29L,36L,37L,40L,43L,46L,53L,58L,65L,74L,83L,96L,107L,120L,133L,136L,143L,150L,157L,168L,179L,190L,209L,226L,247L,258L,271L,286L,299L,314L,327L,334L,349L,364L,381L,406L,417L,434L,455L,470L,493L,514L,533L,562L,583L,608L,631L,646L,661L,680L,703L,736L,761L,782L,807L,836L,857L,892L,927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266534Inst : IEnumerable<long>
{
public static readonly long[] Value=A266534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266534.Bytes);
public long this[int i]=>Value[i];

public static A266534Inst Instance=new A266534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266535
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,15L,23L,35L,43L,47L,55L,67L,83L,103L,127L,155L,171L,175L,183L,195L,211L,231L,255L,283L,315L,351L,391L,435L,483L,535L,591L,651L,683L,687L,695L,707L,723L,743L,767L,795L,827L,863L,903L,947L,995L,1047L,1103L,1163L,1227L,1295L,1367L,1443L,1523L,1607L,1695L,1787L,1883L,1983L,2087L,2195L,2307L,2423L,2543L,2667L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266535Inst : IEnumerable<long>
{
public static readonly long[] Value=A266535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266535.Bytes);
public long this[int i]=>Value[i];

public static A266535Inst Instance=new A266535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266536
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,10L,13L,16L,21L,24L,29L,36L,39L,42L,45L,50L,57L,62L,71L,80L,91L,102L,111L,124L,137L,144L,151L,158L,167L,178L,189L,206L,223L,242L,261L,276L,293L,310L,327L,344L,359L,368L,385L,402L,423L,448L,467L,486L,509L,526L,547L,570L,595L,630L,655L,688L,717L,742L,763L,782L,809L,844L,871L,896L,921L,954L,977L,1016L,1059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266536Inst : IEnumerable<long>
{
public static readonly long[] Value=A266536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266536.Bytes);
public long this[int i]=>Value[i];

public static A266536Inst Instance=new A266536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266537
{
public static readonly long[] Value={ 0L,2L,0L,6L,0L,10L,2L,0L,0L,14L,0L,0L,0L,18L,6L,0L,0L,22L,0L,2L,0L,0L,0L,26L,10L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,34L,14L,6L,0L,0L,0L,38L,0L,0L,2L,0L,0L,0L,0L,42L,18L,0L,0L,0L,0L,0L,0L,46L,0L,10L,0L,0L,0L,0L,0L,50L,22L,0L,0L,0L,0L,0L,0L,54L,0L,0L,6L,0L,0L,0L,0L,58L,26L,14L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266537Inst : IEnumerable<long>
{
public static readonly long[] Value=A266537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266537.Bytes);
public long this[int i]=>Value[i];

public static A266537Inst Instance=new A266537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266538
{
public static readonly long[] Value={ 0L,2L,4L,10L,12L,18L,28L,42L,44L,50L,60L,74L,92L,114L,140L,170L,172L,178L,188L,202L,220L,242L,268L,298L,332L,370L,412L,458L,508L,562L,620L,682L,684L,690L,700L,714L,732L,754L,780L,810L,844L,882L,924L,970L,1020L,1074L,1132L,1194L,1260L,1330L,1404L,1482L,1564L,1650L,1740L,1834L,1932L,2034L,2140L,2250L,2364L,2482L,2604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266538Inst : IEnumerable<long>
{
public static readonly long[] Value=A266538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266538.Bytes);
public long this[int i]=>Value[i];

public static A266538Inst Instance=new A266538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266539
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,3L,1L,1L,3L,3L,5L,5L,7L,7L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,11L,11L,13L,13L,15L,15L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,11L,11L,13L,13L,15L,15L,17L,17L,19L,19L,21L,21L,23L,23L,25L,25L,27L,27L,29L,29L,31L,31L,1L,1L,3L,3L,5L,5L,7L,7L,9L,9L,11L,11L,13L,13L,15L,15L,17L,17L,19L,19L,21L,21L,23L,23L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266539Inst : IEnumerable<long>
{
public static readonly long[] Value=A266539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266539.Bytes);
public long this[int i]=>Value[i];

public static A266539Inst Instance=new A266539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266540
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,7L,10L,11L,12L,15L,18L,23L,28L,35L,42L,43L,44L,47L,50L,55L,60L,67L,74L,83L,92L,103L,114L,127L,140L,155L,170L,171L,172L,175L,178L,183L,188L,195L,202L,211L,220L,231L,242L,255L,268L,283L,298L,315L,332L,351L,370L,391L,412L,435L,458L,483L,508L,535L,562L,591L,620L,651L,682L,683L,684L,687L,690L,695L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266540Inst : IEnumerable<long>
{
public static readonly long[] Value=A266540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266540.Bytes);
public long this[int i]=>Value[i];

public static A266540Inst Instance=new A266540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266541
{
public static readonly long[] Value={ 2L,3L,5L,12L,36L,176L,1688L,48167L,4283651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266541Inst : IEnumerable<long>
{
public static readonly long[] Value=A266541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266541.Bytes);
public long this[int i]=>Value[i];

public static A266541Inst Instance=new A266541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266542
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,11L,13L,16L,20L,23L,27L,32L,36L,41L,47L,52L,58L,65L,71L,78L,86L,93L,101L,110L,118L,127L,137L,146L,156L,167L,177L,188L,200L,211L,223L,236L,248L,261L,275L,288L,302L,317L,331L,346L,362L,377L,393L,410L,426L,443L,461L,478L,496L,515L,533L,552L,572L,591L,611L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266542Inst : IEnumerable<long>
{
public static readonly long[] Value=A266542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266542.Bytes);
public long this[int i]=>Value[i];

public static A266542Inst Instance=new A266542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266543
{
public static readonly long[] Value={ 2L,4L,6L,12L,16L,27L,36L,57L,76L,114L,149L,213L,276L,379L,485L,645L,811L,1051L,1304L,1652L,2021L,2511L,3034L,3709L,4431L,5338L,6311L,7510L,8795L,10352L,12020L,14010L,16142L,18653L,21340L,24469L,27813L,31669L,35786L,40492L,45507L,51196L,57252L,64073L,71324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266543Inst : IEnumerable<long>
{
public static readonly long[] Value=A266543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266543.Bytes);
public long this[int i]=>Value[i];

public static A266543Inst Instance=new A266543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266544
{
public static readonly long[] Value={ 2L,4L,8L,16L,36L,58L,110L,196L,363L,695L,1157L,2023L,3446L,5755L,9485L,14901L,23156L,35568L,53350L,79575L,114919L,165223L,233650L,327246L,453231L,618603L,836533L,1122433L,1490044L,1967385L,2565448L,3329153L,4284884L,5482977L,6970961L,8800503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266544Inst : IEnumerable<long>
{
public static readonly long[] Value=A266544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266544.Bytes);
public long this[int i]=>Value[i];

public static A266544Inst Instance=new A266544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266545
{
public static readonly long[] Value={ 2L,5L,11L,27L,58L,176L,366L,1062L,2571L,7345L,17540L,47970L,109375L,272134L,595031L,1359839L,2827311L,6072251L,12027150L,24388681L,46416427L,89575530L,164016985L,303788687L,537614351L,959313275L,1647205384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266545Inst : IEnumerable<long>
{
public static readonly long[] Value=A266545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266545.Bytes);
public long this[int i]=>Value[i];

public static A266545Inst Instance=new A266545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266546
{
public static readonly long[] Value={ 2L,5L,13L,36L,110L,366L,1688L,5312L,24921L,101495L,417118L,1673507L,6081357L,22843019L,72935735L,238112928L,734665224L,2185350505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266546Inst : IEnumerable<long>
{
public static readonly long[] Value=A266546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266546.Bytes);
public long this[int i]=>Value[i];

public static A266546Inst Instance=new A266546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266547
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,4L,5L,4L,2L,2L,4L,6L,6L,4L,2L,2L,5L,8L,12L,8L,5L,2L,2L,5L,11L,16L,16L,11L,5L,2L,2L,6L,13L,27L,36L,27L,13L,6L,2L,2L,6L,16L,36L,58L,58L,36L,16L,6L,2L,2L,7L,20L,57L,110L,176L,110L,57L,20L,7L,2L,2L,7L,23L,76L,196L,366L,366L,196L,76L,23L,7L,2L,2L,8L,27L,114L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266547Inst : IEnumerable<long>
{
public static readonly long[] Value=A266547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266547.Bytes);
public long this[int i]=>Value[i];

public static A266547Inst Instance=new A266547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266548
{
public static readonly long[] Value={ 71L,2L,2L,5L,2L,3767L,3L,7L,7L,2L,3L,23L,53L,13L,17L,13L,2L,3L,2L,7L,2L,23L,11L,2L,17L,2L,7L,5L,2L,2L,3L,19L,257L,8039L,13L,2L,2L,59L,3L,5L,17L,3L,2L,61L,2L,3L,3L,37L,313L,2L,631L,17L,5L,3L,17L,2L,17L,2L,7L,97L,2L,47L,3L,29L,2L,2L,31L,47L,2L,7L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266548Inst : IEnumerable<long>
{
public static readonly long[] Value=A266548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266548.Bytes);
public long this[int i]=>Value[i];

public static A266548Inst Instance=new A266548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266549
{
public static readonly long[] Value={ 0L,1L,1L,3L,6L,25L,86L,414L,1975L,10479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266549Inst : IEnumerable<long>
{
public static readonly long[] Value=A266549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266549.Bytes);
public long this[int i]=>Value[i];

public static A266549Inst Instance=new A266549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266550
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,23L,47L,95L,191L,383L,767L,1535L,3071L,6143L,12287L,24575L,49151L,98303L,196607L,393215L,786431L,1572863L,3145727L,6291455L,12582911L,25165823L,50331647L,100663295L,201326591L,402653183L,805306367L,1610612735L,3221225471L,6442450943L,12884901887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266550Inst : IEnumerable<long>
{
public static readonly long[] Value=A266550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266550.Bytes);
public long this[int i]=>Value[i];

public static A266550Inst Instance=new A266550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266551
{
public static readonly long[] Value={ 7L,10L,2L,16L,3L,22L,4L,3L,5L,34L,6L,40L,7L,5L,8L,52L,9L,58L,10L,7L,11L,70L,12L,5L,13L,9L,14L,88L,15L,94L,16L,11L,17L,7L,18L,112L,19L,13L,20L,124L,21L,130L,22L,15L,23L,142L,24L,7L,25L,17L,26L,160L,27L,11L,28L,19L,29L,178L,30L,184L,31L,21L,32L,13L,33L,202L,34L,23L,35L,214L,36L,220L,37L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266551Inst : IEnumerable<long>
{
public static readonly long[] Value=A266551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266551.Bytes);
public long this[int i]=>Value[i];

public static A266551Inst Instance=new A266551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266552
{
public static readonly long[] Value={ 2L,3L,10L,5L,16L,8L,4L,2L,4L,2L,5L,16L,8L,4L,2L,6L,3L,10L,5L,16L,8L,4L,2L,7L,22L,11L,34L,17L,52L,26L,13L,40L,20L,10L,5L,16L,8L,4L,2L,8L,4L,2L,9L,3L,10L,5L,16L,8L,4L,2L,10L,5L,16L,8L,4L,2L,11L,34L,17L,52L,26L,13L,40L,20L,10L,5L,16L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266552Inst : IEnumerable<long>
{
public static readonly long[] Value=A266552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266552.Bytes);
public long this[int i]=>Value[i];

public static A266552Inst Instance=new A266552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266553
{
public static readonly long[] Value={ 1L,0L,0L,5L,9L,1L,7L,1L,9L,6L,9L,9L,8L,6L,7L,3L,4L,6L,8L,4L,4L,4L,0L,1L,3L,9L,8L,3L,5L,5L,4L,2L,5L,5L,6L,5L,6L,3L,9L,0L,6L,1L,5L,6L,5L,5L,0L,0L,6L,9L,3L,2L,1L,1L,4L,0L,0L,9L,8L,0L,5L,1L,5L,7L,4L,0L,8L,1L,4L,6L,8L,7L,0L,3L,4L,2L,9L,9L,4L,6L,3L,2L,7L,7L,1L,9L,6L,7L,0L,8L,1L,7L,0L,8L,8L,4L,1L,4L,6L,8L,7L,3L,5L,4L,1L,1L,1L,0L,0L,2L,2L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266553Inst : IEnumerable<long>
{
public static readonly long[] Value=A266553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266553.Bytes);
public long this[int i]=>Value[i];

public static A266553Inst Instance=new A266553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266554
{
public static readonly long[] Value={ 9L,8L,9L,9L,7L,5L,6L,5L,3L,3L,3L,3L,4L,1L,7L,0L,9L,4L,1L,7L,5L,3L,9L,6L,4L,8L,3L,0L,5L,8L,8L,6L,9L,2L,0L,0L,2L,0L,8L,2L,4L,7L,1L,5L,1L,4L,3L,0L,7L,4L,5L,3L,0L,5L,1L,2L,8L,5L,5L,3L,8L,6L,2L,4L,2L,3L,7L,7L,4L,6L,4L,2L,9L,5L,9L,6L,1L,6L,7L,5L,7L,4L,2L,7L,5L,6L,6L,8L,7L,7L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266554Inst : IEnumerable<long>
{
public static readonly long[] Value=A266554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266554.Bytes);
public long this[int i]=>Value[i];

public static A266554Inst Instance=new A266554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266555
{
public static readonly long[] Value={ 9L,9L,1L,7L,1L,8L,3L,2L,1L,6L,3L,2L,8L,2L,2L,1L,9L,6L,9L,9L,9L,5L,4L,7L,4L,8L,2L,7L,6L,5L,7L,9L,3L,3L,3L,9L,8L,6L,7L,8L,5L,9L,7L,6L,0L,5L,7L,3L,0L,5L,0L,7L,9L,2L,4L,7L,0L,7L,6L,5L,9L,9L,3L,4L,0L,9L,5L,0L,2L,3L,7L,9L,3L,4L,2L,1L,7L,6L,1L,9L,0L,9L,3L,0L,9L,1L,2L,3L,8L,8L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266555Inst : IEnumerable<long>
{
public static readonly long[] Value=A266555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266555.Bytes);
public long this[int i]=>Value[i];

public static A266555Inst Instance=new A266555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266556
{
public static readonly long[] Value={ 1L,0L,1L,8L,4L,6L,9L,9L,2L,9L,9L,2L,0L,9L,9L,2L,9L,1L,2L,1L,7L,0L,6L,5L,9L,0L,4L,9L,3L,7L,6L,6L,7L,2L,1L,7L,2L,3L,0L,8L,6L,1L,0L,1L,9L,0L,5L,6L,4L,0L,7L,4L,9L,2L,0L,3L,8L,0L,0L,7L,0L,5L,7L,3L,6L,7L,5L,4L,7L,6L,1L,9L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266556Inst : IEnumerable<long>
{
public static readonly long[] Value=A266556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266556.Bytes);
public long this[int i]=>Value[i];

public static A266556Inst Instance=new A266556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266557
{
public static readonly long[] Value={ 1L,0L,1L,9L,1L,1L,0L,2L,3L,3L,3L,2L,9L,3L,8L,3L,8L,5L,3L,7L,2L,2L,1L,6L,4L,7L,0L,4L,9L,8L,6L,2L,9L,7L,5L,1L,3L,5L,1L,3L,4L,8L,1L,3L,7L,2L,8L,4L,0L,9L,9L,6L,0L,4L,4L,5L,9L,6L,4L,1L,4L,9L,4L,6L,7L,6L,5L,5L,4L,2L,8L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266557Inst : IEnumerable<long>
{
public static readonly long[] Value=A266557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266557.Bytes);
public long this[int i]=>Value[i];

public static A266557Inst Instance=new A266557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266558
{
public static readonly long[] Value={ 9L,5L,0L,3L,3L,1L,2L,4L,8L,4L,5L,3L,2L,8L,8L,8L,6L,6L,5L,1L,4L,2L,3L,3L,8L,4L,1L,0L,1L,5L,3L,3L,1L,2L,7L,1L,5L,9L,7L,5L,6L,6L,4L,0L,3L,4L,5L,6L,1L,7L,3L,0L,4L,0L,8L,6L,1L,0L,8L,8L,8L,8L,1L,1L,6L,2L,2L,9L,7L,8L,4L,9L,1L,7L,7L,3L,4L,4L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266558Inst : IEnumerable<long>
{
public static readonly long[] Value=A266558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266558.Bytes);
public long this[int i]=>Value[i];

public static A266558Inst Instance=new A266558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266559
{
public static readonly long[] Value={ 9L,3L,8L,6L,8L,9L,4L,4L,5L,5L,9L,6L,0L,1L,2L,5L,8L,5L,1L,5L,2L,9L,6L,5L,7L,8L,1L,3L,2L,0L,6L,7L,6L,7L,1L,8L,3L,3L,3L,2L,5L,8L,7L,6L,8L,5L,2L,1L,8L,3L,5L,0L,0L,9L,8L,6L,6L,3L,9L,0L,7L,1L,6L,3L,4L,2L,4L,0L,5L,8L,8L,3L,7L,3L,8L,0L,1L,5L,1L,1L,7L,0L,8L,6L,7L,6L,4L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266559Inst : IEnumerable<long>
{
public static readonly long[] Value=A266559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266559.Bytes);
public long this[int i]=>Value[i];

public static A266559Inst Instance=new A266559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266560
{
public static readonly long[] Value={ 1L,3L,3L,8L,6L,4L,4L,7L,5L,4L,2L,4L,1L,5L,3L,6L,2L,9L,9L,5L,5L,8L,0L,4L,6L,9L,5L,8L,8L,7L,3L,2L,5L,5L,1L,4L,2L,5L,4L,2L,0L,9L,2L,5L,3L,7L,0L,6L,2L,7L,4L,2L,4L,8L,0L,2L,3L,4L,0L,6L,2L,0L,9L,4L,5L,8L,9L,7L,9L,5L,3L,1L,5L,2L,8L,5L,1L,9L,6L,4L,8L,4L,5L,5L,2L,4L,5L,2L,9L,3L,1L,3L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266560Inst : IEnumerable<long>
{
public static readonly long[] Value=A266560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266560.Bytes);
public long this[int i]=>Value[i];

public static A266560Inst Instance=new A266560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A266561
{
public static readonly long[] Value={ 1L,14L,104L,546L,2275L,8008L,24752L,68952L,176358L,419900L,940576L,1998724L,4056234L,7904456L,14858000L,27041560L,47805615L,82317690L,138389160L,227613750L,366913365L,580610160L,903171360L,1382805840L,2086129500L,3104160696L,4559958144L,6618272584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A266561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A266561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A266561Inst : IEnumerable<long>
{
public static readonly long[] Value=A266561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A266561.Bytes);
public long this[int i]=>Value[i];

public static A266561Inst Instance=new A266561Inst();

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