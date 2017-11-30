using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195957
{
public static readonly long[] Value={ 2L,6L,10L,16L,21L,44L,82L,144L,273L,531L,1032L,1960L,3805L,7446L,14505L,28254L,55311L,108511L,212645L,417039L,819145L,1609692L,3163058L,6217976L,12229218L,24055201L,47320658L,93104592L,183213156L,360551489L,709578685L,1396577604L,2748853048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195957Inst : IEnumerable<long>
{
public static readonly long[] Value=A195957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195957.Bytes);
public long this[int i]=>Value[i];

public static A195957Inst Instance=new A195957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195958
{
public static readonly long[] Value={ 1L,5L,16L,19L,25L,70L,105L,155L,332L,557L,1043L,1904L,3391L,6117L,11118L,20903L,37963L,69792L,127581L,235413L,434388L,799835L,1483313L,2732560L,5053827L,9336031L,17297902L,32036101L,59311429L,109934878L,203609521L,377642933L,700109674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195958Inst : IEnumerable<long>
{
public static readonly long[] Value=A195958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195958.Bytes);
public long this[int i]=>Value[i];

public static A195958Inst Instance=new A195958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195959
{
public static readonly long[] Value={ 1L,5L,21L,25L,33L,93L,92L,229L,468L,795L,1482L,2849L,5272L,10756L,20834L,38985L,77732L,152388L,300791L,600543L,1183238L,2351462L,4735415L,9484441L,19063155L,38456880L,77567644L,157185914L,319230043L,648074014L,1318778072L,2688792495L,5486829630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195959Inst : IEnumerable<long>
{
public static readonly long[] Value=A195959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195959.Bytes);
public long this[int i]=>Value[i];

public static A195959Inst Instance=new A195959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195960
{
public static readonly long[] Value={ 2L,14L,44L,70L,93L,214L,410L,998L,2123L,4591L,11034L,26330L,60901L,143300L,345175L,823118L,1988085L,4777597L,11547151L,28117721L,68374283L,166223266L,405654362L,991476600L,2422998474L,5926884201L,14512749914L,35554454454L,87151183742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195960Inst : IEnumerable<long>
{
public static readonly long[] Value=A195960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195960.Bytes);
public long this[int i]=>Value[i];

public static A195960Inst Instance=new A195960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195961
{
public static readonly long[] Value={ 1L,21L,82L,105L,92L,410L,945L,1919L,4478L,10274L,27467L,73240L,184074L,475431L,1290711L,3500703L,9203789L,24842074L,67959738L,185261546L,500164424L,1364785665L,3747581211L,10238569012L,27972042011L,76776169280L,210809165289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195961Inst : IEnumerable<long>
{
public static readonly long[] Value=A195961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195961.Bytes);
public long this[int i]=>Value[i];

public static A195961Inst Instance=new A195961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195962
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,6L,6L,1L,1L,5L,10L,5L,1L,2L,5L,16L,16L,5L,2L,1L,14L,21L,19L,21L,14L,1L,1L,21L,44L,25L,25L,44L,21L,1L,2L,29L,82L,70L,33L,70L,82L,29L,2L,1L,54L,144L,105L,93L,93L,105L,144L,54L,1L,1L,93L,273L,155L,92L,214L,92L,155L,273L,93L,1L,2L,149L,531L,332L,229L,410L,410L,229L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195962Inst : IEnumerable<long>
{
public static readonly long[] Value=A195962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195962.Bytes);
public long this[int i]=>Value[i];

public static A195962Inst Instance=new A195962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195963
{
public static readonly long[] Value={ 1L,1L,5L,21L,193L,746L,13302L,230806L,8567404L,292294619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195963Inst : IEnumerable<long>
{
public static readonly long[] Value=A195963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195963.Bytes);
public long this[int i]=>Value[i];

public static A195963Inst Instance=new A195963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195964
{
public static readonly long[] Value={ 2L,2L,5L,7L,14L,25L,35L,56L,107L,173L,284L,491L,805L,1338L,2299L,3817L,6348L,10741L,17955L,29996L,50517L,84551L,141438L,237601L,398131L,666648L,1118507L,1874589L,3140516L,5266459L,8827461L,14792378L,24799555L,41569097L,69668012L,116786117L,195757315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195964Inst : IEnumerable<long>
{
public static readonly long[] Value=A195964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195964.Bytes);
public long this[int i]=>Value[i];

public static A195964Inst Instance=new A195964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195965
{
public static readonly long[] Value={ 1L,1L,7L,21L,48L,118L,222L,527L,1370L,3336L,7717L,17897L,41296L,98631L,236602L,554717L,1304489L,3078621L,7242849L,17138388L,40496052L,95320672L,224944921L,530817100L,1251705990L,2954749967L,6970501275L,16438448824L,38788768683L,91508873268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195965Inst : IEnumerable<long>
{
public static readonly long[] Value=A195965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195965.Bytes);
public long this[int i]=>Value[i];

public static A195965Inst Instance=new A195965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195966
{
public static readonly long[] Value={ 1L,1L,14L,48L,193L,417L,804L,2745L,9547L,24176L,61074L,170047L,498749L,1412003L,3830458L,10425200L,29408888L,82593837L,229097068L,632720280L,1758152920L,4903602060L,13659767887L,37909433089L,105292824517L,292891120663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195966Inst : IEnumerable<long>
{
public static readonly long[] Value=A195966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195966.Bytes);
public long this[int i]=>Value[i];

public static A195966Inst Instance=new A195966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195967
{
public static readonly long[] Value={ 2L,2L,25L,118L,417L,746L,2906L,10899L,31616L,88860L,304443L,1013184L,3033869L,9608917L,30808108L,97784400L,307889267L,971517454L,3088012323L,9793418941L,30915299775L,97797652156L,310274504503L,981649179185L,3105621771879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195967Inst : IEnumerable<long>
{
public static readonly long[] Value=A195967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195967.Bytes);
public long this[int i]=>Value[i];

public static A195967Inst Instance=new A195967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195968
{
public static readonly long[] Value={ 1L,1L,35L,222L,804L,2906L,13302L,45127L,175176L,652860L,2507734L,9514328L,36686968L,139109262L,525936593L,1999213462L,7634702278L,29077719792L,110526633168L,420713628093L,1600708836096L,6090478119209L,23178925704297L,88214394817266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195968Inst : IEnumerable<long>
{
public static readonly long[] Value=A195968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195968.Bytes);
public long this[int i]=>Value[i];

public static A195968Inst Instance=new A195968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195969
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,5L,1L,1L,2L,1L,7L,7L,1L,2L,1L,2L,14L,21L,14L,2L,1L,1L,1L,25L,48L,48L,25L,1L,1L,2L,1L,35L,118L,193L,118L,35L,1L,2L,1L,2L,56L,222L,417L,417L,222L,56L,2L,1L,1L,1L,107L,527L,804L,746L,804L,527L,107L,1L,1L,2L,1L,173L,1370L,2745L,2906L,2906L,2745L,1370L,173L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195969Inst : IEnumerable<long>
{
public static readonly long[] Value=A195969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195969.Bytes);
public long this[int i]=>Value[i];

public static A195969Inst Instance=new A195969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195970
{
public static readonly long[] Value={ 1L,9L,24L,67L,244L,1280L,5637L,32909L,212185L,1609756L,13476199L,134461394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195970Inst : IEnumerable<long>
{
public static readonly long[] Value=A195970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195970.Bytes);
public long this[int i]=>Value[i];

public static A195970Inst Instance=new A195970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195971
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,16L,25L,39L,64L,105L,169L,272L,441L,715L,1156L,1869L,3025L,4896L,7921L,12815L,20736L,33553L,54289L,87840L,142129L,229971L,372100L,602069L,974169L,1576240L,2550409L,4126647L,6677056L,10803705L,17480761L,28284464L,45765225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195971Inst : IEnumerable<long>
{
public static readonly long[] Value=A195971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195971.Bytes);
public long this[int i]=>Value[i];

public static A195971Inst Instance=new A195971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195972
{
public static readonly long[] Value={ 3L,9L,14L,23L,43L,78L,139L,249L,450L,815L,1475L,2674L,4859L,8841L,16102L,29359L,53587L,97894L,178971L,327425L,599394L,1097871L,2011875L,3688402L,6764595L,12410585L,22775742L,41808791L,76765147L,140977582L,258949451L,475718009L,874068802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195972Inst : IEnumerable<long>
{
public static readonly long[] Value=A195972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195972.Bytes);
public long this[int i]=>Value[i];

public static A195972Inst Instance=new A195972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195973
{
public static readonly long[] Value={ 4L,14L,24L,36L,67L,134L,240L,432L,803L,1501L,2764L,5118L,9519L,17718L,32927L,61310L,114257L,213023L,397223L,741197L,1383497L,2583168L,4824204L,9012010L,16838364L,31466993L,58813148L,109939804L,205534006L,384287357L,718564103L,1343717638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195973Inst : IEnumerable<long>
{
public static readonly long[] Value=A195973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195973.Bytes);
public long this[int i]=>Value[i];

public static A195973Inst Instance=new A195973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195974
{
public static readonly long[] Value={ 5L,23L,36L,67L,133L,256L,455L,931L,1830L,3565L,7001L,13872L,27433L,54401L,108164L,215285L,428869L,855426L,1707759L,3411577L,6819860L,13640635L,27294311L,54635604L,109402661L,219127235L,438997334L,879659285L,1762952379L,3533677212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195974Inst : IEnumerable<long>
{
public static readonly long[] Value=A195974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195974.Bytes);
public long this[int i]=>Value[i];

public static A195974Inst Instance=new A195974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195975
{
public static readonly long[] Value={ 9L,43L,67L,133L,244L,519L,1072L,2225L,4456L,9098L,19066L,39689L,82372L,171498L,358146L,748911L,1567225L,3279792L,6866722L,14390098L,30170057L,63261378L,132676528L,278340227L,584041659L,1225661652L,2572438981L,5399619168L,11334969352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195975Inst : IEnumerable<long>
{
public static readonly long[] Value=A195975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195975.Bytes);
public long this[int i]=>Value[i];

public static A195975Inst Instance=new A195975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195976
{
public static readonly long[] Value={ 16L,78L,134L,256L,519L,1280L,2718L,5830L,12799L,28969L,64536L,144480L,323887L,730358L,1647281L,3720888L,8406355L,19026721L,43091379L,97668401L,221445855L,502417344L,1140305840L,2589100946L,5880051614L,13357939515L,30351874554L,68979138844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195976Inst : IEnumerable<long>
{
public static readonly long[] Value=A195976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195976.Bytes);
public long this[int i]=>Value[i];

public static A195976Inst Instance=new A195976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195977
{
public static readonly long[] Value={ 25L,139L,240L,455L,1072L,2718L,5637L,12823L,30486L,72042L,166884L,390514L,917562L,2167323L,5114140L,12071815L,28523614L,67538866L,159964100L,378996636L,898240293L,2130429190L,5054033816L,11993264778L,28464315995L,67574829560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195977Inst : IEnumerable<long>
{
public static readonly long[] Value=A195977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195977.Bytes);
public long this[int i]=>Value[i];

public static A195977Inst Instance=new A195977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195978
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,14L,14L,5L,9L,23L,24L,23L,9L,16L,43L,36L,36L,43L,16L,25L,78L,67L,67L,67L,78L,25L,39L,139L,134L,133L,133L,134L,139L,39L,64L,249L,240L,256L,244L,256L,240L,249L,64L,105L,450L,432L,455L,519L,519L,455L,432L,450L,105L,169L,815L,803L,931L,1072L,1280L,1072L,931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195978Inst : IEnumerable<long>
{
public static readonly long[] Value=A195978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195978.Bytes);
public long this[int i]=>Value[i];

public static A195978Inst Instance=new A195978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195979
{
public static readonly BigInteger[] Value={ 1L,2L,8L,53L,497L,6027L,89595L,1576682L,32047986L,738772383L,19042778713L,542704904381L,16944005908637L,575128775147734L,21086473359281088L,830481043455973053L,BigInteger.Parse("34967280863073327597"),BigInteger.Parse("1567405219938012472847"),BigInteger.Parse("74521905471659239870631"),BigInteger.Parse("3745801599865304794344662") };
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
public class A195979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195979Inst Instance=new A195979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195980
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,52L,133L,351L,948L,2610L,7298L,20672L,59192L,171059L,498275L,1461437L,4312300L,12792342L,38128354L,114126797L,342914278L,1033914760L,3127154610L,9485523742L,28848101993L,87948036401L,268724650863L,822791384597L,2524113596369L,7757247543181L,23880003051017L,73627904162143L,227347168628991L,702970760225573L,2176459051318522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195980Inst : IEnumerable<long>
{
public static readonly long[] Value=A195980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195980.Bytes);
public long this[int i]=>Value[i];

public static A195980Inst Instance=new A195980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195981
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-2L,-4L,-10L,-25L,-66L,-178L,-490L,-1370L,-3881L,-11113L,-32115L,-93542L,-274332L,-809377L,-2400641L,-7154066L,-21409915L,-64317898L,-193886665L,-586311736L,-1778101466L,-5406660260L,-16479943037L,-50344990445L,-154120149335L,-472717222756L,-1452529814867L,-4470733286364L,-13782117172530L,-42549485082664L,-131545321942331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195981Inst : IEnumerable<long>
{
public static readonly long[] Value=A195981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195981.Bytes);
public long this[int i]=>Value[i];

public static A195981Inst Instance=new A195981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195982
{
public static readonly long[] Value={ 1L,-2L,-1L,0L,-1L,-2L,-7L,-18L,-50L,-138L,-386L,-1092L,-3122L,-9004L,-26173L,-76606L,-225584L,-667880L,-1986932L,-5936754L,-17807936L,-53606646L,-161892564L,-490363820L,-1489319219L,-4534631182L,-13838799043L,-42323692348L,-129697503097L,-398183735878L,-1224576726538L,-3772166985448L,-11637362223230L,-35953168834338L,-111225021683891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195982Inst : IEnumerable<long>
{
public static readonly long[] Value=A195982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195982.Bytes);
public long this[int i]=>Value[i];

public static A195982Inst Instance=new A195982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195983
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,7L,32L,189L,1382L,12090L,123220L,1433760L,18750856L,272243150L,4344694984L,75590125814L,1423923579636L,28872306351182L,626986388773656L,14518030696953650L,357068944503961140L,9296168815245928682UL,BigInteger.Parse("255409012110904594768"),BigInteger.Parse("7385107814017356745382") };
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
public class A195983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195983.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A195983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195983Inst Instance=new A195983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195984
{
public static readonly long[] Value={ 8L,13L,22L,18L,14L,13L,11L,9L,6L,9L,7L,7L,8L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195984Inst : IEnumerable<long>
{
public static readonly long[] Value=A195984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195984.Bytes);
public long this[int i]=>Value[i];

public static A195984Inst Instance=new A195984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195985
{
public static readonly long[] Value={ 2L,5L,11L,37L,107L,337L,1061L,3343L,10559L,33343L,105517L,333337L,1054133L,3333373L,10540931L,33333359L,105409309L,333333361L,1054092869L,3333333413L,10540925639L,33333333343L,105409255363L,333333333367L,1054092553583L,3333333333383L,10540925534207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195985Inst : IEnumerable<long>
{
public static readonly long[] Value=A195985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195985.Bytes);
public long this[int i]=>Value[i];

public static A195985Inst Instance=new A195985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195986
{
public static readonly long[] Value={ 1L,4L,1L,5L,1L,4L,1L,6L,1L,4L,1L,5L,1L,4L,1L,7L,1L,4L,1L,5L,1L,4L,1L,6L,1L,4L,1L,5L,1L,4L,1L,8L,1L,4L,1L,5L,1L,4L,1L,6L,1L,4L,1L,5L,1L,4L,1L,7L,1L,4L,1L,5L,1L,4L,1L,6L,1L,4L,1L,5L,1L,4L,1L,9L,1L,4L,1L,5L,1L,4L,1L,6L,1L,4L,1L,5L,1L,4L,1L,7L,1L,4L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195986Inst : IEnumerable<long>
{
public static readonly long[] Value=A195986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195986.Bytes);
public long this[int i]=>Value[i];

public static A195986Inst Instance=new A195986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195987
{
public static readonly long[] Value={ 907L,1039L,1093L,1231L,1303L,1531L,1993L,2377L,2647L,2713L,2731L,3001L,3331L,4003L,4177L,4243L,4339L,4447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195987Inst : IEnumerable<long>
{
public static readonly long[] Value=A195987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195987.Bytes);
public long this[int i]=>Value[i];

public static A195987Inst Instance=new A195987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195988
{
public static readonly long[] Value={ 1222336487L,1259662487L,1274153897L,1494408397L,1584392531L,1586651309L,1662410923L,1817972423L,1890830857L,2062661389L,2244893621L,2332252547L,2416644757L,2461090421L,2566816313L,2570948153L,2589186937L,2709711233L,2760945133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195988Inst : IEnumerable<long>
{
public static readonly long[] Value=A195988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195988.Bytes);
public long this[int i]=>Value[i];

public static A195988Inst Instance=new A195988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195989
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,6L,1L,8L,9L,10L,1L,12L,1L,2L,3L,16L,1L,18L,1L,20L,21L,2L,1L,24L,1L,2L,27L,4L,1L,30L,1L,32L,3L,2L,1L,36L,1L,2L,3L,40L,1L,42L,1L,4L,9L,2L,1L,48L,1L,50L,3L,4L,1L,54L,11L,8L,3L,2L,1L,60L,1L,2L,63L,64L,1L,6L,1L,4L,3L,10L,1L,72L,1L,2L,3L,4L,1L,78L,1L,80L,81L,2L,1L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195989Inst : IEnumerable<long>
{
public static readonly long[] Value=A195989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195989.Bytes);
public long this[int i]=>Value[i];

public static A195989Inst Instance=new A195989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195990
{
public static readonly long[] Value={ 3L,5L,5L,7L,8L,8L,9L,9L,11L,11L,13L,16L,17L,19L,19L,21L,23L,27L,27L,27L,29L,31L,31L,32L,32L,33L,37L,37L,39L,41L,43L,45L,45L,48L,48L,51L,51L,56L,57L,61L,63L,63L,63L,64L,67L,69L,72L,72L,72L,72L,73L,75L,77L,79L,80L,80L,81L,85L,87L,88L,88L,96L,97L,99L,99L,99L,104L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195990Inst : IEnumerable<long>
{
public static readonly long[] Value=A195990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195990.Bytes);
public long this[int i]=>Value[i];

public static A195990Inst Instance=new A195990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195991
{
public static readonly long[] Value={ 8L,9L,72L,27L,9L,45L,13L,77L,48L,351L,96L,33L,117L,24L,207L,425L,216L,95L,136L,704L,345L,72L,555L,99L,741L,205L,105L,792L,203L,693L,144L,209L,272L,65L,551L,55L,496L,561L,440L,297L,64L,416L,760L,585L,360L,112L,119L,161L,235L,299L,429L,767L,120L,504L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195991Inst : IEnumerable<long>
{
public static readonly long[] Value=A195991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195991.Bytes);
public long this[int i]=>Value[i];

public static A195991Inst Instance=new A195991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195992
{
public static readonly long[] Value={ 9L,11L,73L,29L,13L,47L,17L,79L,51L,353L,99L,39L,121L,33L,211L,429L,221L,103L,143L,709L,351L,83L,561L,109L,747L,213L,117L,799L,213L,701L,157L,221L,283L,87L,561L,81L,507L,573L,453L,313L,97L,431L,773L,599L,377L,141L,149L,187L,257L,319L,447L,783L,153L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195992Inst : IEnumerable<long>
{
public static readonly long[] Value=A195992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195992.Bytes);
public long this[int i]=>Value[i];

public static A195992Inst Instance=new A195992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195993
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,11L,12L,15L,18L,19L,20L,22L,23L,27L,28L,29L,32L,36L,39L,40L,42L,43L,49L,51L,54L,55L,56L,61L,62L,63L,65L,70L,72L,74L,75L,85L,88L,91L,92L,93L,95L,96L,97L,98L,103L,104L,106L,109L,110L,113L,114L,116L,127L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195993Inst : IEnumerable<long>
{
public static readonly long[] Value=A195993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195993.Bytes);
public long this[int i]=>Value[i];

public static A195993Inst Instance=new A195993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195994
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,16L,17L,18L,18L,18L,18L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,24L,24L,24L,25L,25L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,29L,30L,30L,30L,30L,31L,32L,32L,32L,33L,33L,34L,34L,34L,35L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195994Inst : IEnumerable<long>
{
public static readonly long[] Value=A195994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195994.Bytes);
public long this[int i]=>Value[i];

public static A195994Inst Instance=new A195994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195995
{
public static readonly long[] Value={ 3L,6L,18L,9L,18L,12L,45L,10L,20L,15L,36L,84L,18L,35L,60L,21L,36L,135L,28L,54L,24L,90L,198L,20L,27L,40L,77L,126L,30L,72L,273L,54L,104L,33L,45L,168L,360L,36L,70L,135L,90L,216L,39L,120L,459L,30L,60L,88L,170L,42L,72L,270L,570L,45L,56L,108L,209L,330L,48L,180L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195995Inst : IEnumerable<long>
{
public static readonly long[] Value=A195995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195995.Bytes);
public long this[int i]=>Value[i];

public static A195995Inst Instance=new A195995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195996
{
public static readonly long[] Value={ 3L,6L,17L,9L,17L,12L,43L,11L,19L,15L,34L,81L,18L,33L,57L,21L,34L,131L,27L,51L,24L,86L,193L,22L,27L,38L,73L,121L,30L,68L,267L,51L,99L,33L,43L,162L,353L,36L,66L,129L,85L,209L,39L,114L,451L,33L,57L,83L,163L,42L,68L,262L,561L,45L,54L,102L,201L,321L,48L,172L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195996Inst : IEnumerable<long>
{
public static readonly long[] Value=A195996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195996.Bytes);
public long this[int i]=>Value[i];

public static A195996Inst Instance=new A195996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195997
{
public static readonly long[] Value={ 2L,5L,7L,8L,9L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,39L,42L,43L,45L,45L,45L,46L,48L,51L,52L,54L,54L,57L,58L,63L,63L,65L,69L,70L,72L,76L,77L,78L,80L,81L,82L,85L,90L,90L,94L,95L,99L,99L,100L,110L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195997Inst : IEnumerable<long>
{
public static readonly long[] Value=A195997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195997.Bytes);
public long this[int i]=>Value[i];

public static A195997Inst Instance=new A195997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195998
{
public static readonly long[] Value={ 3L,18L,18L,45L,10L,20L,84L,35L,60L,135L,28L,198L,77L,126L,273L,104L,45L,360L,216L,459L,88L,170L,570L,209L,330L,693L,130L,105L,36L,299L,468L,350L,55L,630L,56L,238L,464L,189L,527L,304L,63L,91L,665L,740L,297L,110L,460L,126L,550L,429L,143L,135L,90L,187L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195998Inst : IEnumerable<long>
{
public static readonly long[] Value=A195998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195998.Bytes);
public long this[int i]=>Value[i];

public static A195998Inst Instance=new A195998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195999
{
public static readonly long[] Value={ 3L,17L,17L,43L,11L,19L,81L,33L,57L,131L,27L,193L,73L,121L,267L,99L,43L,353L,209L,451L,83L,163L,561L,201L,321L,683L,123L,99L,41L,289L,457L,339L,57L,617L,59L,227L,451L,179L,513L,291L,67L,89L,649L,723L,283L,107L,443L,121L,531L,411L,137L,131L,97L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195999Inst : IEnumerable<long>
{
public static readonly long[] Value=A195999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195999.Bytes);
public long this[int i]=>Value[i];

public static A195999Inst Instance=new A195999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196000
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,10L,11L,14L,16L,17L,22L,23L,24L,25L,28L,30L,34L,35L,36L,39L,41L,43L,46L,48L,50L,53L,55L,56L,60L,63L,64L,65L,69L,74L,77L,78L,79L,80L,81L,83L,85L,86L,91L,93L,98L,99L,101L,102L,107L,108L,109L,111L,112L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196000Inst : IEnumerable<long>
{
public static readonly long[] Value=A196000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196000.Bytes);
public long this[int i]=>Value[i];

public static A196000Inst Instance=new A196000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196001
{
public static readonly long[] Value={ 4L,5L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,15L,16L,16L,17L,18L,18L,19L,20L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,33L,33L,34L,34L,35L,35L,35L,36L,36L,36L,36L,38L,38L,39L,39L,40L,40L,40L,41L,42L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196001Inst : IEnumerable<long>
{
public static readonly long[] Value=A196001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196001.Bytes);
public long this[int i]=>Value[i];

public static A196001Inst Instance=new A196001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196002
{
public static readonly long[] Value={ 9L,6L,30L,18L,14L,12L,63L,36L,27L,108L,60L,18L,44L,36L,165L,90L,28L,65L,234L,24L,45L,126L,40L,90L,72L,315L,168L,54L,119L,30L,408L,45L,216L,42L,70L,152L,63L,120L,513L,270L,36L,88L,189L,630L,72L,330L,108L,230L,180L,759L,42L,150L,396L,56L,81L,130L,275L,105L,468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196002Inst : IEnumerable<long>
{
public static readonly long[] Value=A196002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196002.Bytes);
public long this[int i]=>Value[i];

public static A196002Inst Instance=new A196002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196003
{
public static readonly long[] Value={ 11L,9L,33L,22L,19L,18L,67L,41L,33L,113L,66L,27L,51L,44L,171L,97L,38L,73L,241L,36L,55L,134L,51L,99L,82L,323L,177L,66L,129L,45L,417L,59L,226L,57L,83L,163L,77L,132L,523L,281L,54L,102L,201L,641L,88L,342L,123L,243L,194L,771L,63L,165L,409L,76L,99L,146L,289L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196003Inst : IEnumerable<long>
{
public static readonly long[] Value=A196003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196003.Bytes);
public long this[int i]=>Value[i];

public static A196003Inst Instance=new A196003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196004
{
public static readonly long[] Value={ 4L,5L,7L,9L,10L,11L,13L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,31L,33L,34L,35L,36L,38L,39L,41L,42L,45L,45L,47L,50L,51L,54L,54L,57L,60L,62L,63L,63L,66L,70L,72L,74L,75L,81L,85L,86L,90L,90L,92L,98L,99L,102L,112L,115L,116L,117L,126L,126L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196004Inst : IEnumerable<long>
{
public static readonly long[] Value=A196004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196004.Bytes);
public long this[int i]=>Value[i];

public static A196004Inst Instance=new A196004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196005
{
public static readonly long[] Value={ 9L,6L,30L,14L,63L,36L,108L,44L,165L,90L,65L,234L,40L,315L,168L,119L,408L,45L,70L,152L,513L,270L,630L,230L,759L,396L,275L,105L,154L,546L,377L,208L,434L,720L,189L,560L,55L,629L,340L,779L,297L,68L,418L,91L,99L,95L,429L,598L,700L,156L,585L,161L,187L,135L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196005Inst : IEnumerable<long>
{
public static readonly long[] Value=A196005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196005.Bytes);
public long this[int i]=>Value[i];

public static A196005Inst Instance=new A196005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196006
{
public static readonly long[] Value={ 11L,9L,33L,19L,67L,41L,113L,51L,171L,97L,73L,241L,51L,323L,177L,129L,417L,59L,83L,163L,523L,281L,641L,243L,771L,409L,289L,123L,171L,561L,393L,227L,451L,737L,211L,579L,89L,649L,363L,801L,323L,107L,443L,129L,139L,137L,459L,627L,731L,201L,619L,209L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196006Inst : IEnumerable<long>
{
public static readonly long[] Value=A196006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196006.Bytes);
public long this[int i]=>Value[i];

public static A196006Inst Instance=new A196006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196007
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,10L,12L,15L,16L,17L,21L,22L,23L,24L,25L,26L,29L,32L,36L,37L,39L,42L,45L,49L,50L,51L,54L,58L,59L,60L,61L,64L,67L,68L,71L,72L,73L,75L,77L,78L,79L,80L,84L,86L,89L,91L,92L,94L,101L,105L,106L,108L,112L,113L,114L,115L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196007Inst : IEnumerable<long>
{
public static readonly long[] Value=A196007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196007.Bytes);
public long this[int i]=>Value[i];

public static A196007Inst Instance=new A196007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196008
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,15L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,21L,22L,24L,24L,24L,25L,25L,26L,27L,27L,27L,27L,28L,30L,30L,30L,31L,32L,32L,32L,33L,33L,35L,35L,35L,35L,36L,36L,37L,38L,39L,39L,40L,40L,40L,40L,42L,42L,42L,43L,45L,45L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196008Inst : IEnumerable<long>
{
public static readonly long[] Value=A196008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196008.Bytes);
public long this[int i]=>Value[i];

public static A196008Inst Instance=new A196008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196009
{
public static readonly long[] Value={ 5L,27L,10L,9L,9L,21L,15L,32L,54L,120L,20L,24L,18L,16L,25L,81L,18L,42L,279L,30L,64L,45L,108L,27L,35L,152L,240L,27L,40L,63L,72L,135L,48L,40L,45L,96L,245L,36L,32L,50L,162L,105L,36L,84L,261L,55L,360L,45L,48L,72L,189L,60L,128L,144L,90L,65L,72L,45L,63L,105L,216L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196009Inst : IEnumerable<long>
{
public static readonly long[] Value=A196009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196009.Bytes);
public long this[int i]=>Value[i];

public static A196009Inst Instance=new A196009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196010
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,32L,126L,842L,6594L,50654L,437802L,3962082L,38901699L,398593494L,4291288911L,48518097812L,571756012282L,7011537065184L,89099102516820L,1171925227051470L,15914369767022370L,222668594799098538L,3205203680348068734L,BigInteger.Parse("47392228013770511784") };
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
public class A196010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196010Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196010.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196010.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196010Inst Instance=new A196010Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196011
{
public static readonly long[] Value={ 1L,1L,2L,25L,106L,708L,22711L,670449L,44864449L,5122273171L,1106078073333L,426788297174150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196011Inst : IEnumerable<long>
{
public static readonly long[] Value=A196011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196011.Bytes);
public long this[int i]=>Value[i];

public static A196011Inst Instance=new A196011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196012
{
public static readonly long[] Value={ 1L,1L,2L,7L,13L,16L,32L,65L,125L,211L,390L,732L,1368L,2478L,4555L,8417L,15564L,28583L,52598L,96921L,178684L,328956L,605723L,1115678L,2055336L,3785356L,6971537L,12840292L,23650713L,43560381L,80229677L,147768685L,272167135L,501285666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196012Inst : IEnumerable<long>
{
public static readonly long[] Value=A196012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196012.Bytes);
public long this[int i]=>Value[i];

public static A196012Inst Instance=new A196012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196013
{
public static readonly long[] Value={ 1L,1L,7L,25L,27L,91L,231L,455L,1135L,2693L,6041L,14257L,33349L,76941L,179553L,418345L,971503L,2261807L,5264419L,12243481L,28490729L,66295633L,154236017L,358872825L,835013523L,1942797397L,4520363539L,10517663443L,24471508585L,56938341019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196013Inst : IEnumerable<long>
{
public static readonly long[] Value=A196013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196013.Bytes);
public long this[int i]=>Value[i];

public static A196013Inst Instance=new A196013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196014
{
public static readonly long[] Value={ 1L,3L,13L,27L,106L,316L,835L,2350L,7232L,21846L,63985L,186029L,548387L,1625398L,4800819L,14129048L,41608725L,122724222L,362055916L,1067475979L,3146535362L,9276448225L,27352573231L,80649512515L,237779505381L,701041117758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196014Inst : IEnumerable<long>
{
public static readonly long[] Value=A196014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196014.Bytes);
public long this[int i]=>Value[i];

public static A196014Inst Instance=new A196014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196015
{
public static readonly long[] Value={ 1L,5L,16L,91L,316L,708L,3572L,14607L,54710L,196832L,782926L,3062632L,11714725L,44732791L,173085686L,668753382L,2573295221L,9902406595L,38178807169L,147173375542L,566944981911L,2184078533126L,8416292695545L,32431165832934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196015Inst : IEnumerable<long>
{
public static readonly long[] Value=A196015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196015.Bytes);
public long this[int i]=>Value[i];

public static A196015Inst Instance=new A196015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196016
{
public static readonly long[] Value={ 1L,9L,32L,231L,835L,3572L,22711L,100094L,517009L,2740712L,14291156L,72486659L,375604408L,1948549100L,10070403094L,52010772351L,269069912146L,1391421035119L,7193724490586L,37198028475134L,192356730926735L,994618459574872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196016Inst : IEnumerable<long>
{
public static readonly long[] Value=A196016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196016.Bytes);
public long this[int i]=>Value[i];

public static A196016Inst Instance=new A196016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196017
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,7L,7L,3L,1L,1L,5L,13L,25L,13L,5L,1L,1L,9L,16L,27L,27L,16L,9L,1L,1L,17L,32L,91L,106L,91L,32L,17L,1L,1L,31L,65L,231L,316L,316L,231L,65L,31L,1L,1L,57L,125L,455L,835L,708L,835L,455L,125L,57L,1L,1L,105L,211L,1135L,2350L,3572L,3572L,2350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196017Inst : IEnumerable<long>
{
public static readonly long[] Value=A196017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196017.Bytes);
public long this[int i]=>Value[i];

public static A196017Inst Instance=new A196017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196018
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,98L,440L,2044L,9742L,47384L,234289L,1174214L,5951877L,30459550L,157168265L,816777857L,4271248777L,22459464722L,118678530165L,629867928597L,3356148860975L,17946684482409L,96280344449069L,518058601390577L,2795121781871727L,15118502434518352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196018Inst : IEnumerable<long>
{
public static readonly long[] Value=A196018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196018.Bytes);
public long this[int i]=>Value[i];

public static A196018Inst Instance=new A196018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196019
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,1L,1L,15L,9L,1L,1L,35L,50L,14L,1L,1L,70L,207L,113L,20L,1L,1L,126L,694L,672L,217L,27L,1L,1L,210L,1986L,3215L,1690L,376L,35L,1L,1L,330L,5028L,12969L,10484L,3663L,606L,44L,1L,1L,495L,11550L,45529L,54588L,28045L,7170L,925L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196019Inst : IEnumerable<long>
{
public static readonly long[] Value=A196019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196019.Bytes);
public long this[int i]=>Value[i];

public static A196019Inst Instance=new A196019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196020
{
public static readonly long[] Value={ 1L,3L,5L,1L,7L,0L,9L,3L,11L,0L,1L,13L,5L,0L,15L,0L,0L,17L,7L,3L,19L,0L,0L,1L,21L,9L,0L,0L,23L,0L,5L,0L,25L,11L,0L,0L,27L,0L,0L,3L,29L,13L,7L,0L,1L,31L,0L,0L,0L,0L,33L,15L,0L,0L,0L,35L,0L,9L,5L,0L,37L,17L,0L,0L,0L,39L,0L,0L,0L,3L,41L,19L,11L,0L,0L,1L,43L,0L,0L,7L,0L,0L,45L,21L,0L,0L,0L,0L,47L,0L,13L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196020Inst : IEnumerable<long>
{
public static readonly long[] Value=A196020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196020.Bytes);
public long this[int i]=>Value[i];

public static A196020Inst Instance=new A196020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196021
{
public static readonly long[] Value={ 1L,1L,4L,5L,16L,22L,64L,109L,283L,486L,1189L,2174L,5097L,9528L,21904L,41549L,92022L,177043L,387715L,754910L,1624543L,3174095L,6751375L,13296454L,27962241L,55173405L,115220461L,228121892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196021Inst : IEnumerable<long>
{
public static readonly long[] Value=A196021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196021.Bytes);
public long this[int i]=>Value[i];

public static A196021Inst Instance=new A196021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196022
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,269L,4676L,106027L,2966909L,98814921L,3818572219L,167999566061L,8292669672343L,453958089569833L,27300462412168531L,1789601591598075179L,BigInteger.Parse("127031469572649790786"),BigInteger.Parse("9709396866317453042033"),BigInteger.Parse("795229841271312470470904"),BigInteger.Parse("69499103185446754949076817") };
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
public class A196022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196022Inst Instance=new A196022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196023
{
public static readonly long[] Value={ 16661L,76667L,3166613L,3466643L,7466647L,7666667L,145666541L,148666841L,152666251L,155666551L,169666961L,176666671L,181666181L,304666403L,305666503L,307666703L,308666803L,329666923L,347666743L,349666943L,373666373L,374666473L,383666383L,391666193L,397666793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196023Inst : IEnumerable<long>
{
public static readonly long[] Value=A196023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196023.Bytes);
public long this[int i]=>Value[i];

public static A196023Inst Instance=new A196023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196024
{
public static readonly long[] Value={ 1L,2L,8L,13L,21L,55L,233L,1597L,4181L,28657L,121393L,196418L,317811L,1346269L,2178309L,3524578L,9227465L,165580141L,1134903170L,1836311903L,2971215073L,20365011074L,32951280099L,53316291173L,225851433717L,2504730781961L,6557470319842L,17167680177565L,27777890035288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196024Inst : IEnumerable<long>
{
public static readonly long[] Value=A196024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196024.Bytes);
public long this[int i]=>Value[i];

public static A196024Inst Instance=new A196024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196025
{
public static readonly long[] Value={ 0L,0L,0L,2L,5L,16L,30L,63L,108L,189L,298L,483L,720L,1092L,1582L,2297L,3225L,4551L,6244L,8592L,11590L,15622L,20741L,27536L,36066L,47198L,61150L,79077L,101391L,129808L,164934L,209213L,263745L,331807L,415229L,518656L,644719L,799926L,988432L,1218979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196025Inst : IEnumerable<long>
{
public static readonly long[] Value=A196025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196025.Bytes);
public long this[int i]=>Value[i];

public static A196025Inst Instance=new A196025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196026
{
public static readonly long[] Value={ 5L,6L,7L,9L,10L,11L,12L,13L,14L,14L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,22L,23L,24L,25L,25L,25L,26L,26L,27L,28L,28L,29L,30L,30L,30L,31L,32L,32L,33L,34L,34L,35L,35L,35L,36L,36L,37L,38L,38L,38L,39L,40L,41L,42L,42L,42L,43L,44L,44L,45L,45L,46L,46L,47L,48L,48L,48L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196026Inst : IEnumerable<long>
{
public static readonly long[] Value=A196026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196026.Bytes);
public long this[int i]=>Value[i];

public static A196026Inst Instance=new A196026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196027
{
public static readonly long[] Value={ 22L,13L,10L,80L,44L,32L,26L,174L,20L,93L,66L,17L,304L,39L,160L,112L,88L,30L,470L,64L,245L,170L,52L,48L,110L,672L,95L,348L,240L,40L,186L,70L,65L,132L,469L,322L,34L,105L,96L,175L,608L,50L,154L,416L,78L,320L,126L,45L,224L,765L,522L,176L,160L,60L,91L,279L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196027Inst : IEnumerable<long>
{
public static readonly long[] Value=A196027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196027.Bytes);
public long this[int i]=>Value[i];

public static A196027Inst Instance=new A196027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196028
{
public static readonly long[] Value={ 28L,20L,18L,91L,56L,45L,40L,190L,36L,110L,84L,35L,325L,60L,182L,135L,112L,54L,496L,90L,272L,198L,80L,77L,140L,703L,126L,380L,273L,72L,220L,104L,100L,168L,506L,360L,70L,143L,135L,216L,650L,90L,196L,459L,120L,364L,170L,88L,270L,812L,570L,224L,209L,108L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196028Inst : IEnumerable<long>
{
public static readonly long[] Value=A196028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196028.Bytes);
public long this[int i]=>Value[i];

public static A196028Inst Instance=new A196028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196029
{
public static readonly long[] Value={ 5L,6L,7L,9L,11L,13L,14L,16L,17L,19L,21L,22L,23L,25L,25L,26L,29L,30L,31L,32L,34L,35L,37L,38L,38L,41L,43L,46L,47L,48L,49L,50L,53L,58L,61L,62L,64L,64L,65L,65L,70L,73L,77L,80L,80L,85L,85L,86L,94L,105L,105L,110L,110L,112L,112L,118L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196029Inst : IEnumerable<long>
{
public static readonly long[] Value=A196029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196029.Bytes);
public long this[int i]=>Value[i];

public static A196029Inst Instance=new A196029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196030
{
public static readonly long[] Value={ 22L,13L,10L,80L,32L,174L,93L,17L,304L,112L,470L,245L,170L,48L,672L,95L,70L,469L,322L,105L,175L,416L,126L,45L,765L,160L,640L,77L,770L,265L,240L,407L,286L,559L,390L,165L,115L,497L,112L,448L,221L,576L,646L,129L,203L,222L,798L,357L,437L,128L,368L,141L,621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196030Inst : IEnumerable<long>
{
public static readonly long[] Value=A196030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196030.Bytes);
public long this[int i]=>Value[i];

public static A196030Inst Instance=new A196030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196031
{
public static readonly long[] Value={ 28L,20L,18L,91L,45L,190L,110L,35L,325L,135L,496L,272L,198L,77L,703L,126L,104L,506L,360L,143L,216L,459L,170L,88L,812L,209L,693L,130L,828L,323L,299L,468L,350L,630L,464L,238L,189L,575L,187L,527L,304L,665L,740L,221L,297L,322L,902L,460L,550L,247L,493L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196031Inst : IEnumerable<long>
{
public static readonly long[] Value=A196031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196031.Bytes);
public long this[int i]=>Value[i];

public static A196031Inst Instance=new A196031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196032
{
public static readonly long[] Value={ 4L,8L,12L,16L,17L,18L,19L,20L,24L,28L,32L,33L,34L,35L,36L,40L,44L,48L,49L,50L,51L,52L,56L,60L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,88L,92L,96L,97L,98L,99L,100L,104L,108L,112L,113L,114L,115L,116L,120L,124L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196032Inst : IEnumerable<long>
{
public static readonly long[] Value=A196032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196032.Bytes);
public long this[int i]=>Value[i];

public static A196032Inst Instance=new A196032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196033
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,12L,13L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,20L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,25L,26L,27L,27L,27L,27L,28L,28L,28L,28L,29L,30L,30L,31L,32L,32L,32L,32L,33L,33L,33L,34L,35L,35L,35L,36L,36L,36L,36L,36L,36L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196033Inst : IEnumerable<long>
{
public static readonly long[] Value=A196033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196033.Bytes);
public long this[int i]=>Value[i];

public static A196033Inst Instance=new A196033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196034
{
public static readonly long[] Value={ 4L,9L,24L,8L,12L,9L,18L,12L,28L,48L,108L,16L,27L,36L,24L,20L,72L,18L,36L,117L,252L,24L,56L,72L,45L,96L,28L,36L,136L,216L,456L,27L,32L,54L,95L,120L,72L,36L,56L,84L,220L,48L,63L,99L,345L,720L,40L,144L,180L,36L,72L,105L,234L,44L,80L,324L,504L,36L,60L,168L,48L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196034Inst : IEnumerable<long>
{
public static readonly long[] Value=A196034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196034.Bytes);
public long this[int i]=>Value[i];

public static A196034Inst Instance=new A196034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196035
{
public static readonly long[] Value={ 3L,7L,21L,6L,9L,7L,14L,9L,23L,42L,101L,12L,21L,29L,18L,15L,63L,14L,28L,107L,241L,18L,46L,61L,35L,84L,21L,27L,123L,202L,441L,21L,24L,42L,81L,105L,58L,27L,43L,69L,203L,36L,49L,83L,327L,701L,30L,126L,161L,28L,56L,87L,214L,33L,63L,303L,482L,29L,45L,147L,36L,41L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196035Inst : IEnumerable<long>
{
public static readonly long[] Value=A196035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196035.Bytes);
public long this[int i]=>Value[i];

public static A196035Inst Instance=new A196035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196036
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,21L,23L,24L,27L,27L,28L,28L,29L,31L,32L,33L,35L,36L,36L,36L,37L,39L,40L,40L,43L,44L,44L,45L,45L,48L,49L,51L,52L,56L,60L,60L,61L,63L,63L,67L,68L,68L,69L,72L,72L,72L,72L,76L,77L,81L,84L,84L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196036Inst : IEnumerable<long>
{
public static readonly long[] Value=A196036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196036.Bytes);
public long this[int i]=>Value[i];

public static A196036Inst Instance=new A196036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196037
{
public static readonly long[] Value={ 4L,9L,24L,12L,9L,28L,108L,36L,117L,252L,72L,136L,456L,95L,56L,220L,99L,345L,720L,180L,105L,80L,36L,55L,65L,203L,252L,448L,63L,693L,336L,63L,189L,88L,592L,91L,432L,176L,315L,297L,161L,539L,660L,160L,260L,792L,135L,429L,308L,77L,119L,187L,767L,651L,144L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196037Inst : IEnumerable<long>
{
public static readonly long[] Value=A196037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196037.Bytes);
public long this[int i]=>Value[i];

public static A196037Inst Instance=new A196037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196038
{
public static readonly long[] Value={ 3L,7L,21L,9L,7L,23L,101L,29L,107L,241L,61L,123L,441L,81L,43L,203L,83L,327L,701L,161L,87L,63L,29L,41L,49L,181L,229L,423L,47L,667L,309L,47L,163L,67L,563L,69L,401L,147L,283L,263L,129L,501L,621L,127L,223L,749L,103L,387L,267L,61L,89L,149L,721L,603L,109L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196038Inst : IEnumerable<long>
{
public static readonly long[] Value=A196038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196038.Bytes);
public long this[int i]=>Value[i];

public static A196038Inst Instance=new A196038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196039
{
public static readonly long[] Value={ 0L,1L,4L,9L,18L,30L,50L,75L,113L,162L,231L,318L,441L,593L,798L,1058L,1399L,1824L,2379L,3066L,3948L,5042L,6422L,8124L,10264L,12884L,16138L,20120L,25027L,30994L,38312L,47168L,57955L,70974L,86733L,105676L,128516L,155850L,188644L,227783L,274541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196039Inst : IEnumerable<long>
{
public static readonly long[] Value=A196039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196039.Bytes);
public long this[int i]=>Value[i];

public static A196039Inst Instance=new A196039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196040
{
public static readonly long[] Value={ 7L,8L,9L,11L,13L,14L,15L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,26L,27L,27L,28L,28L,29L,30L,32L,33L,33L,34L,35L,36L,36L,39L,39L,40L,40L,40L,41L,42L,44L,44L,45L,45L,46L,47L,48L,48L,49L,51L,52L,54L,54L,55L,56L,56L,56L,57L,58L,60L,60L,63L,63L,63L,63L,64L,64L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196040Inst : IEnumerable<long>
{
public static readonly long[] Value=A196040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196040.Bytes);
public long this[int i]=>Value[i];

public static A196040Inst Instance=new A196040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196041
{
public static readonly long[] Value={ 36L,21L,16L,12L,132L,72L,52L,42L,36L,32L,288L,27L,153L,108L,24L,72L,63L,264L,48L,184L,45L,144L,120L,104L,84L,36L,280L,72L,180L,64L,155L,56L,396L,54L,105L,306L,252L,216L,48L,171L,80L,156L,144L,336L,126L,287L,252L,108L,189L,96L,368L,60L,90L,147L,288L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196041Inst : IEnumerable<long>
{
public static readonly long[] Value=A196041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196041.Bytes);
public long this[int i]=>Value[i];

public static A196041Inst Instance=new A196041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196042
{
public static readonly long[] Value={ 41L,27L,23L,21L,141L,82L,63L,54L,49L,46L,301L,43L,167L,123L,42L,89L,81L,282L,69L,203L,67L,164L,141L,126L,108L,63L,303L,98L,205L,92L,181L,87L,423L,86L,135L,334L,281L,246L,84L,203L,115L,189L,178L,369L,162L,321L,287L,147L,227L,138L,406L,105L,134L,189L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196042Inst : IEnumerable<long>
{
public static readonly long[] Value=A196042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196042.Bytes);
public long this[int i]=>Value[i];

public static A196042Inst Instance=new A196042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196043
{
public static readonly long[] Value={ 7L,8L,9L,11L,13L,15L,17L,19L,20L,20L,23L,25L,27L,28L,29L,31L,32L,33L,36L,39L,41L,44L,44L,45L,47L,48L,51L,52L,53L,57L,59L,63L,63L,64L,68L,71L,72L,72L,76L,81L,84L,88L,92L,93L,96L,99L,99L,104L,108L,108L,111L,117L,117L,124L,129L,132L,133L,144L,144L,148L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196043Inst : IEnumerable<long>
{
public static readonly long[] Value=A196043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196043.Bytes);
public long this[int i]=>Value[i];

public static A196043Inst Instance=new A196043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196044
{
public static readonly long[] Value={ 36L,21L,16L,12L,132L,52L,36L,288L,27L,153L,72L,504L,184L,45L,120L,780L,405L,280L,155L,56L,252L,171L,777L,532L,336L,287L,688L,189L,432L,140L,540L,76L,176L,297L,435L,792L,91L,671L,429L,308L,185L,585L,819L,416L,187L,232L,476L,207L,247L,329L,608L,340L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196044Inst : IEnumerable<long>
{
public static readonly long[] Value=A196044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196044.Bytes);
public long this[int i]=>Value[i];

public static A196044Inst Instance=new A196044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196045
{
public static readonly long[] Value={ 41L,27L,23L,21L,141L,63L,49L,301L,43L,167L,89L,521L,203L,67L,141L,801L,427L,303L,181L,87L,281L,203L,807L,563L,369L,321L,723L,227L,469L,183L,581L,127L,223L,343L,483L,841L,149L,721L,483L,367L,249L,647L,883L,483L,261L,307L,547L,287L,329L,409L,687L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196045Inst : IEnumerable<long>
{
public static readonly long[] Value=A196045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196045.Bytes);
public long this[int i]=>Value[i];

public static A196045Inst Instance=new A196045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196046
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,4L,3L,3L,4L,3L,3L,2L,3L,4L,2L,3L,3L,3L,3L,3L,2L,5L,2L,3L,3L,4L,4L,4L,3L,4L,3L,3L,3L,3L,3L,3L,3L,5L,3L,3L,3L,3L,5L,4L,2L,4L,4L,3L,3L,4L,4L,2L,3L,6L,3L,3L,4L,3L,3L,3L,4L,5L,3L,4L,3L,4L,3L,3L,3L,5L,4L,3L,3L,4L,3L,3L,3L,4L,5L,4L,3L,3L,2L,3L,4L,6L,3L,3L,3L,4L,3L,3L,4L,4L,3L,5L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196046Inst : IEnumerable<long>
{
public static readonly long[] Value=A196046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196046.Bytes);
public long this[int i]=>Value[i];

public static A196046Inst Instance=new A196046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196047
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,5L,3L,6L,7L,10L,5L,8L,6L,9L,4L,9L,7L,7L,8L,8L,11L,11L,6L,12L,9L,9L,7L,12L,10L,15L,5L,13L,10L,11L,8L,10L,8L,11L,9L,13L,9L,11L,12L,12L,12L,15L,7L,10L,13L,12L,10L,9L,10L,16L,8L,10L,13L,14L,11L,13L,16L,11L,6L,14L,14L,12L,11L,14L,12L,14L,9L,14L,11L,15L,9L,15L,12L,17L,10L,12L,14L,17L,10L,15L,12L,15L,13L,12L,13L,13L,13L,18L,16L,13L,8L,19L,11L,16L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196047Inst : IEnumerable<long>
{
public static readonly long[] Value=A196047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196047.Bytes);
public long this[int i]=>Value[i];

public static A196047Inst Instance=new A196047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196048
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,5L,5L,4L,6L,5L,6L,5L,6L,5L,6L,5L,6L,6L,6L,6L,6L,6L,5L,5L,6L,7L,7L,6L,7L,7L,7L,6L,7L,7L,8L,6L,7L,7L,7L,6L,8L,7L,8L,7L,8L,7L,7L,7L,8L,7L,8L,7L,8L,6L,8L,6L,8L,7L,9L,8L,8L,8L,8L,7L,9L,8L,8L,8L,8L,8L,7L,7L,8L,8L,8L,8L,9L,9L,8L,7L,9L,8L,9L,8L,7L,8L,9L,7L,8L,9L,8L,8L,9L,9L,9L,8L,9L,9L,10L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196048Inst : IEnumerable<long>
{
public static readonly long[] Value=A196048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196048.Bytes);
public long this[int i]=>Value[i];

public static A196048Inst Instance=new A196048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196049
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,3L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196049Inst : IEnumerable<long>
{
public static readonly long[] Value=A196049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196049.Bytes);
public long this[int i]=>Value[i];

public static A196049Inst Instance=new A196049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196050
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,5L,5L,6L,5L,6L,5L,5L,6L,5L,5L,6L,5L,6L,6L,5L,5L,6L,6L,5L,6L,5L,6L,7L,6L,6L,6L,6L,7L,6L,6L,5L,7L,7L,6L,6L,6L,5L,7L,6L,6L,7L,6L,7L,7L,5L,6L,7L,7L,6L,7L,6L,6L,8L,6L,7L,7L,6L,7L,8L,6L,6L,7L,7L,6L,7L,7L,6L,8L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,6L,7L,7L,7L,8L,6L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196050Inst : IEnumerable<long>
{
public static readonly long[] Value=A196050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196050.Bytes);
public long this[int i]=>Value[i];

public static A196050Inst Instance=new A196050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196051
{
public static readonly long[] Value={ 0L,1L,4L,4L,10L,10L,9L,9L,20L,20L,20L,18L,18L,18L,35L,16L,18L,31L,16L,32L,32L,35L,31L,28L,56L,31L,48L,29L,32L,50L,35L,25L,56L,32L,52L,44L,28L,28L,50L,46L,31L,46L,29L,52L,72L,48L,50L,40L,48L,75L,52L,46L,25L,64L,84L,42L,46L,50L,32L,67L,44L,56L,67L,36L,76L,76L,28L,48L,72L,70L,46L,59L,46L,44L,102L,42L,79L,68L,52L,62L,88L,50L,48L,62L,79L,46L,75L,71L,40L,92L,71L,67L,84L,72L,71L,54L,75L,65L,104L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196051Inst : IEnumerable<long>
{
public static readonly long[] Value=A196051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196051.Bytes);
public long this[int i]=>Value[i];

public static A196051Inst Instance=new A196051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196052
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,4L,3L,2L,4L,3L,4L,4L,4L,2L,5L,4L,4L,5L,3L,3L,5L,4L,4L,6L,5L,3L,5L,2L,5L,4L,3L,5L,6L,4L,5L,5L,5L,2L,6L,3L,4L,6L,4L,3L,6L,6L,5L,4L,5L,5L,7L,4L,6L,6L,4L,2L,6L,4L,3L,7L,6L,5L,5L,2L,4L,5L,6L,4L,7L,3L,5L,6L,6L,5L,6L,3L,6L,8L,3L,2L,7L,4L,4L,5L,5L,5L,7L,6L,5L,4L,4L,6L,7L,3L,7L,6L,6L,3L,5L,4L,6L,7L,6L,4L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196052Inst : IEnumerable<long>
{
public static readonly long[] Value=A196052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196052.Bytes);
public long this[int i]=>Value[i];

public static A196052Inst Instance=new A196052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196053
{
public static readonly long[] Value={ 0L,2L,6L,6L,10L,10L,12L,12L,14L,14L,14L,16L,16L,16L,18L,20L,16L,20L,20L,20L,20L,18L,20L,24L,22L,20L,24L,22L,20L,24L,18L,30L,22L,20L,24L,28L,24L,24L,24L,28L,20L,26L,22L,24L,28L,24L,24L,34L,26L,28L,24L,26L,30L,32L,26L,30L,28L,24L,20L,32L,28L,22L,30L,42L,28L,28L,24L,26L,28L,30L,28L,38L,26L,28L,32L,30L,28L,30L,24L,38L,36L,24L,24L,34L,28L,26L,28L,32L,34L,36L,30L,30L,26L,28L,32L,46L,28L,32L,32L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196053Inst : IEnumerable<long>
{
public static readonly long[] Value=A196053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196053.Bytes);
public long this[int i]=>Value[i];

public static A196053Inst Instance=new A196053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196054
{
public static readonly long[] Value={ 0L,1L,4L,4L,8L,8L,9L,9L,12L,12L,12L,14L,14L,14L,16L,16L,14L,19L,16L,18L,18L,16L,19L,22L,20L,19L,24L,21L,18L,23L,16L,25L,20L,18L,22L,28L,22L,22L,23L,26L,19L,26L,21L,22L,28L,24L,23L,32L,24L,27L,22L,26L,25L,34L,24L,30L,26L,23L,18L,32L,28L,20L,31L,36L,27L,27L,22L,24L,28L,30L,26L,39L,26L,28L,32L,30L,26L,31L,22L,36L,40L,23L,24L,36L,26L,26L,27L,30L,32L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196054Inst : IEnumerable<long>
{
public static readonly long[] Value=A196054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196054.Bytes);
public long this[int i]=>Value[i];

public static A196054Inst Instance=new A196054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196055
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,6L,6L,4L,4L,4L,8L,8L,8L,5L,12L,8L,10L,12L,10L,10L,5L,10L,15L,6L,10L,12L,16L,10L,12L,5L,20L,6L,10L,12L,18L,15L,15L,12L,18L,10L,19L,16L,12L,14L,12L,12L,24L,20L,14L,12L,19L,20L,21L,7L,26L,18L,12L,10L,21L,18L,6L,22L,30L,14L,14L,15L,20L,14L,22L,18L,28L,19L,18L,16L,26L,14L,22L,12L,28L,24L,12L,12L,30L,14L,19L,14L,21L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196055Inst : IEnumerable<long>
{
public static readonly long[] Value=A196055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196055.Bytes);
public long this[int i]=>Value[i];

public static A196055Inst Instance=new A196055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196056
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,2L,2L,1L,4L,1L,1L,2L,3L,2L,1L,3L,3L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,2L,4L,1L,2L,2L,2L,2L,2L,1L,3L,3L,3L,2L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,2L,2L,1L,1L,2L,1L,2L,2L,3L,1L,4L,2L,1L,3L,1L,2L,3L,2L,3L,1L,4L,1L,1L,1L,1L,2L,1L,3L,3L,1L,2L,2L,3L,1L,1L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196056Inst : IEnumerable<long>
{
public static readonly long[] Value=A196056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196056.Bytes);
public long this[int i]=>Value[i];

public static A196056Inst Instance=new A196056Inst();

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