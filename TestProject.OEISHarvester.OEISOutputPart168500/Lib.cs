using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198957
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,102L,424L,1827L,8078L,36466L,167376L,778718L,3664164L,17407068L,83375616L,402198915L,1952296598L,9528757098L,46735576816L,230227356906L,1138609205372L,5651170500612L,28138939936704L,140527262919342L,703704207921932L,3532664478314484L,17775185122527776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198957Inst : IEnumerable<long>
{
public static readonly long[] Value=A198957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198957.Bytes);
public long this[int i]=>Value[i];

public static A198957Inst Instance=new A198957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198958
{
public static readonly long[] Value={ 0L,0L,1L,6L,27L,80L,207L,432L,863L,1512L,2646L,4144L,6585L,9504L,14216L,19476L,27783L,36384L,49977L,63504L,84722L,104736L,136188L,165056L,210717L,250560L,314270L,367902L,455544L,525808L,642762L,733968L,888087L,1003608L,1201554L,1347232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198958Inst : IEnumerable<long>
{
public static readonly long[] Value=A198958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198958.Bytes);
public long this[int i]=>Value[i];

public static A198958Inst Instance=new A198958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198959
{
public static readonly BigInteger[] Value={ 2L,3L,7L,46L,2112L,4460539L,19896408170515L,BigInteger.Parse("395867058087736049315365218"),BigInteger.Parse("156710727679038987453730700439845485538142584724187516") };
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
public class A198959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198959Inst Instance=new A198959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198960
{
public static readonly long[] Value={ 2L,26L,242L,2186L,19682L,177146L,1594322L,14348906L,129140162L,1162261466L,10460353202L,94143178826L,847288609442L,7625597484986L,68630377364882L,617673396283946L,5559060566555522L,50031545098999706L,450283905890997362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198960Inst : IEnumerable<long>
{
public static readonly long[] Value=A198960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198960.Bytes);
public long this[int i]=>Value[i];

public static A198960Inst Instance=new A198960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198961
{
public static readonly long[] Value={ 3L,35L,323L,2915L,26243L,236195L,2125763L,19131875L,172186883L,1549681955L,13947137603L,125524238435L,1129718145923L,10167463313315L,91507169819843L,823564528378595L,7412080755407363L,66708726798666275L,600378541187996483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198961Inst : IEnumerable<long>
{
public static readonly long[] Value=A198961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198961.Bytes);
public long this[int i]=>Value[i];

public static A198961Inst Instance=new A198961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198962
{
public static readonly long[] Value={ 4L,44L,404L,3644L,32804L,295244L,2657204L,23914844L,215233604L,1937102444L,17433922004L,156905298044L,1412147682404L,12709329141644L,114383962274804L,1029455660473244L,9265100944259204L,83385908498332844L,750473176484995604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198962Inst : IEnumerable<long>
{
public static readonly long[] Value=A198962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198962.Bytes);
public long this[int i]=>Value[i];

public static A198962Inst Instance=new A198962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198963
{
public static readonly long[] Value={ 5L,53L,485L,4373L,39365L,354293L,3188645L,28697813L,258280325L,2324522933L,20920706405L,188286357653L,1694577218885L,15251194969973L,137260754729765L,1235346792567893L,11118121133111045L,100063090197999413L,900567811781994725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198963Inst : IEnumerable<long>
{
public static readonly long[] Value=A198963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198963.Bytes);
public long this[int i]=>Value[i];

public static A198963Inst Instance=new A198963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198964
{
public static readonly long[] Value={ 3L,31L,283L,2551L,22963L,206671L,1860043L,16740391L,150663523L,1355971711L,12203745403L,109833708631L,988503377683L,8896530399151L,80068773592363L,720618962331271L,6485570660981443L,58370135948832991L,525331223539496923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198964Inst : IEnumerable<long>
{
public static readonly long[] Value=A198964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198964.Bytes);
public long this[int i]=>Value[i];

public static A198964Inst Instance=new A198964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198965
{
public static readonly long[] Value={ 6L,62L,566L,5102L,45926L,413342L,3720086L,33480782L,301327046L,2711943422L,24407490806L,219667417262L,1977006755366L,17793060798302L,160137547184726L,1441237924662542L,12971141321962886L,116740271897665982L,1050662447078993846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198965Inst : IEnumerable<long>
{
public static readonly long[] Value=A198965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198965.Bytes);
public long this[int i]=>Value[i];

public static A198965Inst Instance=new A198965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198966
{
public static readonly long[] Value={ 7L,71L,647L,5831L,52487L,472391L,4251527L,38263751L,344373767L,3099363911L,27894275207L,251048476871L,2259436291847L,20334926626631L,183014339639687L,1647129056757191L,14824161510814727L,133417453597332551L,1200757082375992967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198966Inst : IEnumerable<long>
{
public static readonly long[] Value=A198966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198966.Bytes);
public long this[int i]=>Value[i];

public static A198966Inst Instance=new A198966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198967
{
public static readonly long[] Value={ 9L,89L,809L,7289L,65609L,590489L,5314409L,47829689L,430467209L,3874204889L,34867844009L,313810596089L,2824295364809L,25418658283289L,228767924549609L,2058911320946489L,18530201888518409L,166771816996665689L,1500946352969991209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198967Inst : IEnumerable<long>
{
public static readonly long[] Value=A198967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198967.Bytes);
public long this[int i]=>Value[i];

public static A198967Inst Instance=new A198967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198968
{
public static readonly long[] Value={ 10L,98L,890L,8018L,72170L,649538L,5845850L,52612658L,473513930L,4261625378L,38354628410L,345191655698L,3106724901290L,27960524111618L,251644717004570L,2264802453041138L,20383222077370250L,183448998696332258L,1651040988266990330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198968Inst : IEnumerable<long>
{
public static readonly long[] Value=A198968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198968.Bytes);
public long this[int i]=>Value[i];

public static A198968Inst Instance=new A198968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198969
{
public static readonly long[] Value={ 5L,49L,445L,4009L,36085L,324769L,2922925L,26306329L,236756965L,2130812689L,19177314205L,172595827849L,1553362450645L,13980262055809L,125822358502285L,1132401226520569L,10191611038685125L,91724499348166129L,825520494133495165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198969Inst : IEnumerable<long>
{
public static readonly long[] Value=A198969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198969.Bytes);
public long this[int i]=>Value[i];

public static A198969Inst Instance=new A198969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198970
{
public static readonly long[] Value={ 3L,39L,399L,3999L,39999L,399999L,3999999L,39999999L,399999999L,3999999999L,39999999999L,399999999999L,3999999999999L,39999999999999L,399999999999999L,3999999999999999L,39999999999999999L,399999999999999999L,3999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198970Inst : IEnumerable<long>
{
public static readonly long[] Value=A198970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198970.Bytes);
public long this[int i]=>Value[i];

public static A198970Inst Instance=new A198970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198971
{
public static readonly long[] Value={ 4L,49L,499L,4999L,49999L,499999L,4999999L,49999999L,499999999L,4999999999L,49999999999L,499999999999L,4999999999999L,49999999999999L,499999999999999L,4999999999999999L,49999999999999999L,499999999999999999L,4999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198971Inst : IEnumerable<long>
{
public static readonly long[] Value=A198971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198971.Bytes);
public long this[int i]=>Value[i];

public static A198971Inst Instance=new A198971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198972
{
public static readonly long[] Value={ 2L,23L,233L,2333L,23333L,233333L,2333333L,23333333L,233333333L,2333333333L,23333333333L,233333333333L,2333333333333L,23333333333333L,233333333333333L,2333333333333333L,23333333333333333L,233333333333333333L,2333333333333333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198972Inst : IEnumerable<long>
{
public static readonly long[] Value=A198972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198972.Bytes);
public long this[int i]=>Value[i];

public static A198972Inst Instance=new A198972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198973
{
public static readonly long[] Value={ 7L,79L,799L,7999L,79999L,799999L,7999999L,79999999L,799999999L,7999999999L,79999999999L,799999999999L,7999999999999L,79999999999999L,799999999999999L,7999999999999999L,79999999999999999L,799999999999999999L,7999999999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198973Inst : IEnumerable<long>
{
public static readonly long[] Value=A198973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198973.Bytes);
public long this[int i]=>Value[i];

public static A198973Inst Instance=new A198973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198974
{
public static readonly ulong[] Value={ 1L,21L,241L,2661L,29281L,322101L,3543121L,38974341L,428717761L,4715895381L,51874849201L,570623341221L,6276856753441L,69045424287861L,759499667166481L,8354496338831301L,91899459727144321L,1010894056998587541L,11119834626984462961UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198974Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A198974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198974.Bytes);
public ulong this[int i]=>Value[i];

public static A198974Inst Instance=new A198974Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198975
{
public static readonly BigInteger[] Value={ 1L,4L,1835L,53082012L,30525244435834L,BigInteger.Parse("310387893630465965693"),BigInteger.Parse("55676868201599759013090066735") };
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
public class A198975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198975Inst Instance=new A198975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198976
{
public static readonly BigInteger[] Value={ 1L,4L,34L,481L,8731L,174454L,3603244L,75251971L,1577395861L,33105096904L,695065679254L,14595390246661L,306496273473391L,6436373295247354L,135163500079092064L,2838431127851480551L,BigInteger.Parse("59607037068329713321") };
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
public class A198976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198976.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198976Inst Instance=new A198976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198977
{
public static readonly BigInteger[] Value={ 2L,34L,1835L,146286L,12662226L,1112962873L,98102456246L,8651794282083L,763087851014929L,67305520316532514L,5936469991284318525L,BigInteger.Parse("523607833526831199696"),BigInteger.Parse("46183202315902474606576"),BigInteger.Parse("4073445973766659727007243") };
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
public class A198977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198977Inst Instance=new A198977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198978
{
public static readonly BigInteger[] Value={ 5L,481L,146286L,53082012L,19622872903L,7267830860056L,2692353648978984L,997397244990907738L,BigInteger.Parse("369492074075459555844"),BigInteger.Parse("136880688981914387733120"),BigInteger.Parse("50708322978926251631508008"),BigInteger.Parse("18785221234054066344117511329") };
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
public class A198978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198978Inst Instance=new A198978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198979
{
public static readonly BigInteger[] Value={ 15L,8731L,12662226L,19622872903L,30525244435834L,47495195899845037L,BigInteger.Parse("73900197917712351603"),BigInteger.Parse("114985169155743145765664"),BigInteger.Parse("178911424288565716160545667"),BigInteger.Parse("278377620790460864731769016202") };
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
public class A198979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198979Inst Instance=new A198979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198980
{
public static readonly BigInteger[] Value={ 52L,174454L,1112962873L,7267830860056L,47495195899845037L,BigInteger.Parse("310387893630465965693"),BigInteger.Parse("2028430770889558380053172"),BigInteger.Parse("13256095277348005849607178346"),BigInteger.Parse("86630544487196927129344081838138") };
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
public class A198980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198980.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198980Inst Instance=new A198980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198981
{
public static readonly BigInteger[] Value={ 202L,3603244L,98102456246L,2692353648978984L,BigInteger.Parse("73900197917712351603"),BigInteger.Parse("2028430770889558380053172"),BigInteger.Parse("55676868201599759013090066735"),BigInteger.Parse("1528232414884966866457407229662199") };
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
public class A198981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198981.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198981Inst Instance=new A198981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198982
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,481L,1835L,481L,15L,52L,8731L,146286L,146286L,8731L,52L,202L,174454L,12662226L,53082012L,12662226L,174454L,202L,855L,3603244L,1112962873L,19622872903L,19622872903L,1112962873L,3603244L,855L,3845L,75251971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198982Inst : IEnumerable<long>
{
public static readonly long[] Value=A198982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198982.Bytes);
public long this[int i]=>Value[i];

public static A198982Inst Instance=new A198982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198983
{
public static readonly long[] Value={ 7L,5L,3L,4L,3L,4L,9L,3L,9L,2L,5L,8L,6L,6L,6L,2L,5L,2L,6L,7L,6L,9L,5L,1L,9L,9L,5L,8L,3L,1L,5L,6L,3L,3L,0L,0L,4L,9L,9L,5L,8L,8L,7L,4L,9L,7L,1L,2L,5L,9L,0L,8L,3L,5L,1L,2L,8L,2L,4L,8L,1L,9L,9L,0L,3L,5L,7L,3L,3L,5L,3L,5L,3L,3L,9L,7L,4L,7L,2L,4L,9L,5L,5L,8L,0L,7L,3L,5L,8L,2L,5L,3L,2L,1L,5L,9L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198983Inst : IEnumerable<long>
{
public static readonly long[] Value=A198983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198983.Bytes);
public long this[int i]=>Value[i];

public static A198983Inst Instance=new A198983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198984
{
public static readonly long[] Value={ 9L,2L,1L,3L,0L,6L,0L,6L,5L,8L,4L,7L,8L,0L,8L,9L,9L,3L,0L,4L,7L,8L,6L,8L,1L,2L,9L,7L,4L,7L,8L,4L,7L,4L,8L,2L,7L,5L,7L,1L,7L,9L,8L,0L,8L,3L,1L,1L,4L,4L,1L,6L,7L,1L,7L,5L,9L,2L,4L,4L,0L,0L,0L,7L,1L,8L,1L,7L,7L,1L,5L,9L,0L,8L,0L,2L,4L,7L,1L,8L,9L,9L,3L,4L,3L,0L,5L,9L,4L,4L,0L,6L,9L,7L,6L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198984Inst : IEnumerable<long>
{
public static readonly long[] Value=A198984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198984.Bytes);
public long this[int i]=>Value[i];

public static A198984Inst Instance=new A198984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198985
{
public static readonly long[] Value={ 5L,7L,4L,7L,4L,8L,0L,8L,5L,9L,3L,7L,2L,5L,4L,0L,8L,5L,7L,8L,8L,8L,3L,6L,9L,3L,6L,5L,0L,9L,0L,8L,0L,2L,4L,1L,0L,0L,1L,9L,1L,6L,9L,4L,9L,9L,3L,9L,2L,4L,4L,9L,2L,9L,6L,7L,4L,3L,8L,2L,6L,6L,3L,0L,7L,1L,7L,5L,4L,0L,3L,8L,3L,0L,9L,4L,3L,0L,5L,1L,2L,3L,4L,1L,0L,5L,4L,7L,6L,0L,9L,3L,3L,8L,0L,8L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198985Inst : IEnumerable<long>
{
public static readonly long[] Value=A198985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198985.Bytes);
public long this[int i]=>Value[i];

public static A198985Inst Instance=new A198985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198986
{
public static readonly long[] Value={ 6L,2L,6L,4L,1L,9L,2L,4L,4L,3L,8L,2L,3L,3L,8L,2L,3L,8L,2L,8L,4L,6L,0L,4L,5L,1L,5L,4L,3L,9L,7L,2L,5L,1L,1L,8L,6L,0L,0L,3L,3L,3L,2L,8L,8L,8L,3L,2L,6L,8L,4L,1L,3L,0L,5L,5L,6L,8L,1L,9L,0L,2L,6L,2L,2L,5L,1L,8L,5L,6L,9L,6L,6L,0L,6L,7L,4L,4L,0L,1L,2L,8L,9L,1L,8L,1L,0L,1L,0L,8L,0L,7L,3L,1L,7L,9L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198986Inst : IEnumerable<long>
{
public static readonly long[] Value=A198986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198986.Bytes);
public long this[int i]=>Value[i];

public static A198986Inst Instance=new A198986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198987
{
public static readonly long[] Value={ 6L,6L,8L,0L,2L,7L,8L,4L,7L,4L,5L,3L,0L,5L,4L,0L,7L,4L,5L,0L,2L,2L,2L,0L,0L,5L,6L,3L,7L,3L,9L,8L,6L,8L,5L,1L,2L,1L,5L,7L,9L,0L,2L,6L,8L,8L,8L,4L,0L,9L,1L,8L,5L,4L,6L,5L,4L,3L,7L,6L,9L,1L,1L,6L,4L,6L,9L,0L,9L,7L,0L,4L,3L,4L,0L,1L,0L,5L,4L,1L,5L,5L,4L,1L,4L,6L,8L,1L,7L,2L,3L,5L,5L,4L,3L,3L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198987Inst : IEnumerable<long>
{
public static readonly long[] Value=A198987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198987.Bytes);
public long this[int i]=>Value[i];

public static A198987Inst Instance=new A198987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198988
{
public static readonly long[] Value={ 8L,1L,8L,9L,8L,7L,3L,6L,8L,4L,4L,8L,7L,3L,3L,4L,3L,7L,7L,4L,7L,8L,2L,4L,3L,5L,5L,1L,6L,7L,7L,0L,6L,6L,4L,4L,3L,6L,9L,2L,5L,9L,8L,9L,2L,5L,4L,8L,1L,8L,5L,0L,3L,4L,8L,8L,4L,1L,2L,2L,9L,0L,2L,9L,3L,4L,8L,7L,3L,7L,2L,2L,9L,3L,4L,8L,1L,0L,7L,1L,8L,1L,4L,5L,1L,7L,8L,4L,0L,5L,2L,0L,4L,7L,3L,0L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198988Inst : IEnumerable<long>
{
public static readonly long[] Value=A198988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198988.Bytes);
public long this[int i]=>Value[i];

public static A198988Inst Instance=new A198988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198989
{
public static readonly long[] Value={ 9L,4L,6L,6L,2L,8L,5L,1L,6L,7L,6L,8L,7L,8L,1L,1L,7L,4L,9L,2L,2L,2L,5L,4L,2L,2L,9L,6L,4L,8L,4L,8L,7L,2L,4L,7L,0L,4L,1L,1L,9L,9L,9L,4L,8L,3L,6L,3L,0L,0L,8L,7L,7L,5L,0L,0L,2L,2L,0L,5L,3L,5L,4L,6L,6L,5L,3L,1L,1L,5L,9L,3L,3L,3L,6L,2L,9L,5L,6L,7L,3L,7L,3L,6L,0L,4L,1L,7L,4L,0L,0L,0L,7L,0L,0L,3L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198989Inst : IEnumerable<long>
{
public static readonly long[] Value=A198989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198989.Bytes);
public long this[int i]=>Value[i];

public static A198989Inst Instance=new A198989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198990
{
public static readonly long[] Value={ 1L,0L,5L,9L,4L,0L,8L,7L,6L,9L,0L,7L,0L,0L,3L,7L,4L,7L,8L,4L,5L,4L,1L,9L,3L,2L,2L,5L,6L,9L,2L,3L,6L,5L,3L,2L,5L,0L,6L,7L,9L,6L,1L,1L,7L,9L,2L,4L,6L,0L,8L,4L,1L,1L,2L,7L,4L,3L,5L,1L,3L,4L,5L,1L,3L,2L,9L,8L,1L,2L,6L,1L,3L,0L,5L,6L,8L,6L,3L,5L,6L,1L,1L,1L,4L,2L,4L,4L,9L,1L,4L,0L,0L,3L,3L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198990Inst : IEnumerable<long>
{
public static readonly long[] Value=A198990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198990.Bytes);
public long this[int i]=>Value[i];

public static A198990Inst Instance=new A198990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198991
{
public static readonly long[] Value={ 4L,4L,7L,9L,5L,8L,3L,0L,7L,6L,4L,7L,4L,0L,6L,8L,7L,2L,3L,0L,9L,7L,6L,4L,1L,8L,4L,0L,4L,5L,1L,8L,5L,4L,0L,2L,3L,5L,3L,8L,9L,7L,5L,3L,4L,8L,4L,0L,6L,5L,7L,1L,0L,0L,2L,3L,4L,2L,3L,1L,3L,8L,3L,0L,3L,0L,3L,7L,2L,8L,4L,0L,6L,0L,4L,2L,6L,0L,1L,4L,5L,3L,0L,7L,9L,0L,7L,1L,7L,8L,0L,9L,7L,8L,3L,7L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198991Inst : IEnumerable<long>
{
public static readonly long[] Value=A198991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198991.Bytes);
public long this[int i]=>Value[i];

public static A198991Inst Instance=new A198991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198992
{
public static readonly long[] Value={ 7L,7L,8L,4L,5L,8L,8L,9L,9L,8L,1L,9L,6L,9L,4L,6L,8L,0L,4L,5L,3L,2L,2L,4L,8L,6L,5L,8L,4L,0L,5L,8L,9L,2L,7L,5L,2L,6L,5L,8L,4L,1L,2L,6L,2L,9L,3L,0L,8L,3L,3L,6L,3L,2L,4L,3L,8L,4L,7L,7L,2L,4L,6L,9L,3L,1L,6L,6L,9L,5L,8L,7L,3L,4L,2L,6L,8L,8L,6L,8L,5L,4L,3L,2L,6L,5L,8L,1L,0L,9L,2L,5L,4L,0L,4L,6L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198992Inst : IEnumerable<long>
{
public static readonly long[] Value=A198992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198992.Bytes);
public long this[int i]=>Value[i];

public static A198992Inst Instance=new A198992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198993
{
public static readonly long[] Value={ 1L,0L,0L,8L,2L,9L,2L,1L,6L,7L,8L,8L,8L,8L,3L,5L,4L,7L,1L,4L,2L,7L,8L,0L,9L,8L,5L,3L,9L,9L,1L,6L,8L,6L,6L,4L,7L,3L,3L,4L,3L,7L,8L,4L,2L,3L,3L,7L,0L,5L,6L,4L,7L,5L,8L,9L,0L,9L,4L,7L,0L,9L,9L,4L,1L,4L,9L,0L,7L,7L,0L,2L,7L,0L,2L,1L,1L,3L,1L,6L,0L,4L,8L,7L,8L,2L,8L,5L,2L,0L,9L,5L,5L,3L,8L,6L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198993Inst : IEnumerable<long>
{
public static readonly long[] Value=A198993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198993.Bytes);
public long this[int i]=>Value[i];

public static A198993Inst Instance=new A198993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198994
{
public static readonly long[] Value={ 4L,2L,7L,2L,8L,3L,4L,3L,8L,7L,6L,8L,8L,5L,5L,3L,6L,4L,0L,0L,5L,4L,4L,7L,7L,8L,3L,5L,6L,9L,8L,1L,1L,7L,2L,4L,9L,1L,4L,0L,6L,9L,6L,7L,9L,9L,8L,9L,0L,2L,5L,1L,1L,8L,8L,9L,1L,1L,1L,1L,7L,2L,4L,8L,9L,4L,0L,8L,5L,5L,1L,4L,4L,9L,9L,3L,8L,0L,4L,3L,7L,2L,2L,6L,2L,5L,2L,7L,8L,4L,8L,7L,7L,7L,2L,7L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198994Inst : IEnumerable<long>
{
public static readonly long[] Value=A198994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198994.Bytes);
public long this[int i]=>Value[i];

public static A198994Inst Instance=new A198994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198995
{
public static readonly long[] Value={ 6L,0L,5L,5L,2L,0L,1L,2L,3L,4L,6L,2L,2L,5L,3L,5L,2L,3L,9L,5L,8L,2L,9L,0L,7L,0L,5L,9L,6L,5L,7L,4L,3L,8L,9L,7L,5L,7L,3L,8L,4L,9L,3L,0L,3L,7L,7L,2L,4L,0L,4L,8L,2L,8L,2L,3L,8L,4L,3L,5L,8L,5L,6L,0L,8L,2L,1L,2L,9L,4L,8L,5L,0L,1L,1L,2L,2L,2L,9L,1L,5L,6L,2L,8L,0L,1L,5L,4L,5L,6L,7L,2L,6L,8L,4L,0L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198995Inst : IEnumerable<long>
{
public static readonly long[] Value=A198995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198995.Bytes);
public long this[int i]=>Value[i];

public static A198995Inst Instance=new A198995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198996
{
public static readonly long[] Value={ 8L,5L,9L,8L,8L,1L,1L,7L,5L,2L,3L,2L,0L,2L,6L,4L,4L,9L,5L,7L,8L,0L,4L,6L,0L,5L,2L,6L,3L,6L,4L,2L,8L,3L,4L,2L,2L,1L,5L,5L,5L,9L,0L,9L,1L,0L,5L,3L,6L,9L,7L,1L,3L,2L,9L,2L,3L,5L,9L,7L,3L,9L,4L,9L,5L,1L,6L,3L,6L,5L,7L,4L,4L,5L,9L,1L,7L,1L,5L,4L,0L,9L,1L,1L,7L,9L,5L,3L,2L,8L,5L,8L,5L,3L,5L,4L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198996Inst : IEnumerable<long>
{
public static readonly long[] Value=A198996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198996.Bytes);
public long this[int i]=>Value[i];

public static A198996Inst Instance=new A198996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198997
{
public static readonly long[] Value={ 9L,6L,3L,3L,6L,4L,2L,1L,3L,4L,8L,2L,5L,1L,6L,6L,6L,6L,6L,0L,5L,9L,9L,9L,3L,3L,4L,7L,8L,9L,9L,4L,3L,7L,5L,2L,3L,6L,1L,3L,3L,0L,0L,4L,9L,8L,4L,2L,6L,8L,7L,7L,5L,1L,8L,9L,7L,3L,9L,8L,7L,0L,1L,5L,2L,3L,9L,2L,3L,5L,1L,5L,6L,0L,0L,5L,8L,6L,0L,6L,0L,8L,2L,7L,6L,6L,5L,8L,5L,7L,3L,7L,9L,4L,6L,4L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198997Inst : IEnumerable<long>
{
public static readonly long[] Value=A198997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198997.Bytes);
public long this[int i]=>Value[i];

public static A198997Inst Instance=new A198997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198998
{
public static readonly long[] Value={ 1L,0L,5L,7L,4L,9L,3L,6L,1L,7L,2L,6L,8L,8L,4L,0L,3L,6L,5L,4L,9L,7L,9L,5L,2L,6L,8L,3L,6L,5L,8L,5L,6L,1L,5L,0L,5L,1L,5L,1L,1L,3L,0L,6L,7L,1L,6L,3L,0L,5L,2L,1L,0L,9L,2L,9L,3L,1L,8L,6L,1L,8L,5L,3L,1L,3L,7L,0L,6L,0L,5L,2L,6L,4L,5L,7L,5L,2L,6L,6L,7L,2L,9L,8L,1L,4L,2L,7L,7L,0L,6L,8L,7L,0L,3L,8L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198998Inst : IEnumerable<long>
{
public static readonly long[] Value=A198998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198998.Bytes);
public long this[int i]=>Value[i];

public static A198998Inst Instance=new A198998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198999
{
public static readonly long[] Value={ 1L,1L,4L,4L,5L,8L,2L,7L,1L,5L,8L,1L,0L,2L,6L,2L,2L,5L,8L,7L,5L,2L,4L,8L,4L,7L,8L,6L,5L,5L,3L,2L,6L,9L,1L,6L,3L,1L,7L,5L,0L,6L,3L,0L,6L,4L,9L,6L,1L,6L,0L,6L,2L,2L,9L,9L,0L,1L,9L,0L,9L,7L,6L,1L,1L,7L,9L,6L,5L,6L,1L,5L,7L,5L,0L,6L,9L,0L,2L,6L,3L,5L,6L,9L,8L,9L,4L,2L,2L,3L,4L,4L,7L,2L,4L,2L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198999Inst : IEnumerable<long>
{
public static readonly long[] Value=A198999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198999.Bytes);
public long this[int i]=>Value[i];

public static A198999Inst Instance=new A198999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199000
{
public static readonly long[] Value={ 4L,0L,9L,1L,9L,5L,7L,0L,5L,5L,2L,8L,4L,3L,0L,3L,9L,3L,7L,1L,2L,0L,4L,0L,4L,6L,0L,6L,0L,7L,2L,6L,7L,1L,5L,0L,3L,8L,3L,1L,2L,8L,0L,4L,9L,4L,7L,8L,2L,9L,4L,7L,6L,4L,7L,6L,1L,7L,7L,7L,3L,1L,2L,6L,6L,8L,3L,1L,1L,9L,2L,4L,7L,0L,7L,1L,9L,6L,6L,6L,0L,0L,8L,8L,5L,2L,0L,6L,5L,0L,2L,2L,7L,7L,3L,2L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199000Inst : IEnumerable<long>
{
public static readonly long[] Value=A199000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199000.Bytes);
public long this[int i]=>Value[i];

public static A199000Inst Instance=new A199000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199001
{
public static readonly long[] Value={ 7L,1L,2L,0L,5L,4L,2L,4L,6L,3L,1L,4L,6L,4L,9L,9L,4L,1L,7L,2L,1L,2L,6L,8L,9L,9L,4L,5L,6L,1L,0L,4L,2L,6L,0L,4L,9L,6L,5L,7L,7L,1L,0L,1L,1L,5L,1L,6L,9L,5L,8L,0L,7L,3L,8L,3L,0L,0L,9L,8L,8L,9L,4L,8L,7L,9L,5L,0L,0L,2L,4L,2L,0L,8L,9L,7L,4L,7L,7L,6L,1L,4L,2L,7L,9L,1L,7L,4L,3L,9L,5L,6L,5L,0L,5L,9L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199001Inst : IEnumerable<long>
{
public static readonly long[] Value=A199001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199001.Bytes);
public long this[int i]=>Value[i];

public static A199001Inst Instance=new A199001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199002
{
public static readonly long[] Value={ 9L,2L,3L,5L,6L,7L,9L,0L,5L,1L,8L,7L,8L,9L,4L,5L,4L,1L,8L,5L,8L,5L,9L,2L,9L,7L,3L,9L,7L,8L,4L,1L,0L,1L,6L,3L,8L,9L,9L,0L,4L,8L,6L,4L,1L,1L,7L,7L,7L,2L,1L,0L,4L,7L,0L,7L,6L,1L,8L,0L,9L,1L,3L,8L,2L,3L,5L,1L,4L,1L,9L,7L,8L,7L,4L,4L,0L,1L,2L,4L,3L,6L,7L,8L,9L,1L,4L,8L,5L,0L,0L,6L,4L,5L,5L,3L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199002Inst : IEnumerable<long>
{
public static readonly long[] Value=A199002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199002.Bytes);
public long this[int i]=>Value[i];

public static A199002Inst Instance=new A199002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199003
{
public static readonly long[] Value={ 1L,0L,9L,7L,9L,2L,6L,6L,5L,0L,3L,7L,1L,5L,9L,9L,4L,3L,3L,1L,4L,4L,0L,9L,4L,9L,0L,9L,6L,7L,1L,0L,9L,6L,7L,0L,6L,9L,2L,0L,4L,4L,3L,7L,2L,4L,4L,0L,9L,0L,8L,1L,0L,1L,7L,7L,9L,1L,4L,0L,8L,7L,2L,1L,9L,3L,0L,5L,6L,0L,4L,1L,7L,7L,1L,5L,3L,4L,2L,7L,2L,3L,3L,7L,2L,1L,9L,3L,9L,7L,7L,5L,4L,4L,7L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199003Inst : IEnumerable<long>
{
public static readonly long[] Value=A199003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199003.Bytes);
public long this[int i]=>Value[i];

public static A199003Inst Instance=new A199003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199004
{
public static readonly long[] Value={ 1L,2L,7L,8L,9L,35L,49L,55L,75L,76L,82L,84L,115L,124L,133L,140L,144L,153L,167L,172L,177L,200L,201L,202L,203L,211L,213L,232L,235L,237L,240L,243L,245L,252L,256L,262L,276L,281L,285L,297L,305L,319L,322L,325L,331L,349L,352L,353L,374L,377L,379L,380L,399L,407L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199004Inst : IEnumerable<long>
{
public static readonly long[] Value=A199004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199004.Bytes);
public long this[int i]=>Value[i];

public static A199004Inst Instance=new A199004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199005
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,16L,6L,100L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199005Inst : IEnumerable<long>
{
public static readonly long[] Value=A199005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199005.Bytes);
public long this[int i]=>Value[i];

public static A199005Inst Instance=new A199005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199006
{
public static readonly long[] Value={ 192L,21504L,190080L,10838016L,16440L,823616L,74306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199006Inst : IEnumerable<long>
{
public static readonly long[] Value=A199006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199006.Bytes);
public long this[int i]=>Value[i];

public static A199006Inst Instance=new A199006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199007
{
public static readonly long[] Value={ 192L,21504L,190080L,10838016L,16440L,790224L,64488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199007Inst : IEnumerable<long>
{
public static readonly long[] Value=A199007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199007.Bytes);
public long this[int i]=>Value[i];

public static A199007Inst Instance=new A199007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199008
{
public static readonly long[] Value={ 6L,25L,196L,972L,9680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199008Inst : IEnumerable<long>
{
public static readonly long[] Value=A199008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199008.Bytes);
public long this[int i]=>Value[i];

public static A199008Inst Instance=new A199008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199009
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,27L,28L,30L,32L,35L,36L,40L,42L,45L,48L,49L,50L,54L,56L,60L,63L,64L,70L,72L,75L,80L,81L,84L,90L,96L,98L,100L,105L,108L,112L,120L,121L,125L,126L,128L,135L,140L,143L,144L,147L,150L,160L,162L,168L,169L,175L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199009Inst : IEnumerable<long>
{
public static readonly long[] Value=A199009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199009.Bytes);
public long this[int i]=>Value[i];

public static A199009Inst Instance=new A199009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199010
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199010Inst : IEnumerable<long>
{
public static readonly long[] Value=A199010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199010.Bytes);
public long this[int i]=>Value[i];

public static A199010Inst Instance=new A199010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199011
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,6L,4L,1L,0L,5L,10L,10L,5L,1L,0L,6L,15L,20L,15L,6L,1L,0L,7L,21L,35L,35L,21L,7L,1L,0L,8L,28L,56L,70L,56L,28L,8L,1L,0L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199011Inst : IEnumerable<long>
{
public static readonly long[] Value=A199011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199011.Bytes);
public long this[int i]=>Value[i];

public static A199011Inst Instance=new A199011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199012
{
public static readonly BigInteger[] Value={ 0L,3L,48L,1308L,96080L,23114160L,18522702240L,50214057399744L,469006445678383872L,BigInteger.Parse("15356719437883766115840"),BigInteger.Parse("1788760016178073736115859200"),BigInteger.Parse("750205198434476437912637004278784"),BigInteger.Parse("1144188684031608529784893493874665232384") };
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
public class A199012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199012Inst Instance=new A199012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199013
{
public static readonly long[] Value={ 16L,27L,30L,60L,70L,105L,220L,231L,286L,476L,627L,646L,805L,897L,1160L,1276L,1581L,1776L,1798L,2322L,2408L,2967L,3055L,3196L,3526L,4028L,4543L,5360L,5487L,6248L,6461L,6745L,7198L,7881L,7968L,9628L,9717L,10366L,10707L,10864L,11036L,14231L,15368L,15836L,16377L,19304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199013Inst : IEnumerable<long>
{
public static readonly long[] Value=A199013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199013.Bytes);
public long this[int i]=>Value[i];

public static A199013Inst Instance=new A199013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199014
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,12L,18L,27L,36L,54L,108L,1823L,3646L,5469L,7292L,10938L,16407L,21876L,32814L,49221L,65628L,98442L,196884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199014Inst : IEnumerable<long>
{
public static readonly long[] Value=A199014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199014.Bytes);
public long this[int i]=>Value[i];

public static A199014Inst Instance=new A199014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199015
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,8L,11L,13L,13L,15L,17L,19L,20L,22L,22L,24L,28L,28L,30L,30L,31L,35L,37L,37L,39L,41L,41L,43L,45L,47L,48L,52L,52L,52L,54L,54L,58L,60L,62L,64L,64L,64L,67L,69L,69L,71L,75L,75L,77L,79L,79L,83L,83L,83L,83L,87L,90L,92L,94L,94L,96L,98L,98L,98L,100L,102L,106L,108L,108L,110L,112L,112L,115L,117L,117L,117L,121L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199015Inst : IEnumerable<long>
{
public static readonly long[] Value=A199015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199015.Bytes);
public long this[int i]=>Value[i];

public static A199015Inst Instance=new A199015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199016
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,10L,12L,18L,22L,30L,37L,50L,60L,78L,94L,120L,143L,179L,213L,262L,309L,376L,440L,531L,618L,737L,855L,1012L,1167L,1372L,1575L,1840L,2104L,2442L,2783L,3214L,3649L,4193L,4746L,5430L,6126L,6980L,7853L,8914L,10002L,11311L,12660L,14274L,15934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199016Inst : IEnumerable<long>
{
public static readonly long[] Value=A199016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199016.Bytes);
public long this[int i]=>Value[i];

public static A199016Inst Instance=new A199016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199017
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,14L,16L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,31L,34L,35L,38L,40L,41L,45L,45L,48L,51L,52L,57L,60L,62L,66L,68L,71L,75L,78L,83L,86L,93L,97L,100L,107L,109L,115L,120L,124L,132L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199017Inst : IEnumerable<long>
{
public static readonly long[] Value=A199017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199017.Bytes);
public long this[int i]=>Value[i];

public static A199017Inst Instance=new A199017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199018
{
public static readonly long[] Value={ 1L,16L,181L,1996L,21961L,241576L,2657341L,29230756L,321538321L,3536921536L,38906136901L,427967505916L,4707642565081L,51784068215896L,569624750374861L,6265872254123476L,68924594795358241L,758170542748940656L,8339875970238347221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199018Inst : IEnumerable<long>
{
public static readonly long[] Value=A199018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199018.Bytes);
public long this[int i]=>Value[i];

public static A199018Inst Instance=new A199018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199019
{
public static readonly long[] Value={ 2L,32L,362L,3992L,43922L,483152L,5314682L,58461512L,643076642L,7073843072L,77812273802L,855935011832L,9415285130162L,103568136431792L,1139249500749722L,12531744508246952L,137849189590716482L,1516341085497881312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199019Inst : IEnumerable<long>
{
public static readonly long[] Value=A199019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199019.Bytes);
public long this[int i]=>Value[i];

public static A199019Inst Instance=new A199019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199020
{
public static readonly long[] Value={ 3L,43L,483L,5323L,58563L,644203L,7086243L,77948683L,857435523L,9431790763L,103749698403L,1141246682443L,12553713506883L,138090848575723L,1518999334332963L,16708992677662603L,183798919454288643L,2021788113997175083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199020Inst : IEnumerable<long>
{
public static readonly long[] Value=A199020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199020.Bytes);
public long this[int i]=>Value[i];

public static A199020Inst Instance=new A199020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199021
{
public static readonly long[] Value={ 2L,27L,302L,3327L,36602L,402627L,4428902L,48717927L,535897202L,5894869227L,64843561502L,713279176527L,7846070941802L,86306780359827L,949374583958102L,10443120423539127L,114874324658930402L,1263617571248234427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199021Inst : IEnumerable<long>
{
public static readonly long[] Value=A199021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199021.Bytes);
public long this[int i]=>Value[i];

public static A199021Inst Instance=new A199021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199022
{
public static readonly long[] Value={ 4L,54L,604L,6654L,73204L,805254L,8857804L,97435854L,1071794404L,11789738454L,129687123004L,1426558353054L,15692141883604L,172613560719654L,1898749167916204L,20886240847078254L,229748649317860804L,2527235142496468854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199022Inst : IEnumerable<long>
{
public static readonly long[] Value=A199022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199022.Bytes);
public long this[int i]=>Value[i];

public static A199022Inst Instance=new A199022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199023
{
public static readonly long[] Value={ 1L,13L,145L,1597L,17569L,193261L,2125873L,23384605L,257230657L,2829537229L,31124909521L,342374004733L,3766114052065L,41427254572717L,455699800299889L,5012697803298781L,55139675836286593L,606536434199152525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199023Inst : IEnumerable<long>
{
public static readonly long[] Value=A199023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199023.Bytes);
public long this[int i]=>Value[i];

public static A199023Inst Instance=new A199023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199024
{
public static readonly long[] Value={ 5L,65L,725L,7985L,87845L,966305L,10629365L,116923025L,1286153285L,14147686145L,155624547605L,1711870023665L,18830570260325L,207136272863585L,2278499001499445L,25063489016493905L,275698379181432965L,3032682170995762625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199024Inst : IEnumerable<long>
{
public static readonly long[] Value=A199024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199024.Bytes);
public long this[int i]=>Value[i];

public static A199024Inst Instance=new A199024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199025
{
public static readonly long[] Value={ 3L,38L,423L,4658L,51243L,563678L,6200463L,68205098L,750256083L,8252816918L,90780986103L,998590847138L,10984499318523L,120829492503758L,1329124417541343L,14620368592954778L,160824054522502563L,1769064599747528198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199025Inst : IEnumerable<long>
{
public static readonly long[] Value=A199025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199025.Bytes);
public long this[int i]=>Value[i];

public static A199025Inst Instance=new A199025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199026
{
public static readonly long[] Value={ 6L,76L,846L,9316L,102486L,1127356L,12400926L,136410196L,1500512166L,16505633836L,181561972206L,1997181694276L,21968998637046L,241658985007516L,2658248835082686L,29240737185909556L,321648109045005126L,3538129199495056396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199026Inst : IEnumerable<long>
{
public static readonly long[] Value=A199026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199026.Bytes);
public long this[int i]=>Value[i];

public static A199026Inst Instance=new A199026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199027
{
public static readonly long[] Value={ 7L,87L,967L,10647L,117127L,1288407L,14172487L,155897367L,1714871047L,18863581527L,207499396807L,2282493364887L,25107427013767L,276181697151447L,3037998668665927L,33417985355325207L,367597838908577287L,4043576227994350167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199027Inst : IEnumerable<long>
{
public static readonly long[] Value=A199027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199027.Bytes);
public long this[int i]=>Value[i];

public static A199027Inst Instance=new A199027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199028
{
public static readonly long[] Value={ 4L,49L,544L,5989L,65884L,724729L,7972024L,87692269L,964614964L,10610764609L,116718410704L,1283902517749L,14122927695244L,155352204647689L,1708874251124584L,18797616762370429L,206773784386074724L,2274511628246821969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199028Inst : IEnumerable<long>
{
public static readonly long[] Value=A199028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199028.Bytes);
public long this[int i]=>Value[i];

public static A199028Inst Instance=new A199028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199029
{
public static readonly long[] Value={ 8L,98L,1088L,11978L,131768L,1449458L,15944048L,175384538L,1929229928L,21221529218L,233436821408L,2567805035498L,28245855390488L,310704409295378L,3417748502249168L,37595233524740858L,413547568772149448L,4549023256493643938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199029Inst : IEnumerable<long>
{
public static readonly long[] Value=A199029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199029.Bytes);
public long this[int i]=>Value[i];

public static A199029Inst Instance=new A199029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199030
{
public static readonly long[] Value={ 9L,109L,1209L,13309L,146409L,1610509L,17715609L,194871709L,2143588809L,23579476909L,259374246009L,2853116706109L,31384283767209L,345227121439309L,3797498335832409L,41772481694156509L,459497298635721609L,5054470284992937709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199030Inst : IEnumerable<long>
{
public static readonly long[] Value=A199030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199030.Bytes);
public long this[int i]=>Value[i];

public static A199030Inst Instance=new A199030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199031
{
public static readonly long[] Value={ 1L,23L,287L,3455L,41471L,497663L,5971967L,71663615L,859963391L,10319560703L,123834728447L,1486016741375L,17832200896511L,213986410758143L,2567836929097727L,30814043149172735L,369768517790072831L,4437222213480873983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199031Inst : IEnumerable<long>
{
public static readonly long[] Value=A199031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199031.Bytes);
public long this[int i]=>Value[i];

public static A199031Inst Instance=new A199031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199032
{
public static readonly long[] Value={ 2L,35L,431L,5183L,62207L,746495L,8957951L,107495423L,1289945087L,15479341055L,185752092671L,2229025112063L,26748301344767L,320979616137215L,3851755393646591L,46221064723759103L,554652776685109247L,6655833320221310975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199032Inst : IEnumerable<long>
{
public static readonly long[] Value=A199032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199032.Bytes);
public long this[int i]=>Value[i];

public static A199032Inst Instance=new A199032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199033
{
public static readonly long[] Value={ 1L,4L,22L,128L,771L,4744L,29618L,186880L,1188679L,7608764L,48953224L,316283264L,2050706932L,13336273528L,86953633242L,568221290496L,3720529001823L,24403423540348L,160314652983158L,1054635453261568L,6946703172803003L,45809043607167328L,302395650703501688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199033Inst : IEnumerable<long>
{
public static readonly long[] Value=A199033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199033.Bytes);
public long this[int i]=>Value[i];

public static A199033Inst Instance=new A199033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,3L,1L,6L,15L,15L,75L,126L,71L,397L,786L,550L,3043L,5730L,3660L,20610L,39843L,26407L,149468L,288070L,188649L,1074387L,2082753L,1372608L,7852896L,15252825L,10045040L,57692788L,112347998L,74107005L,427035846L,833163180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199034Inst : IEnumerable<long>
{
public static readonly long[] Value=A199034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199034.Bytes);
public long this[int i]=>Value[i];

public static A199034Inst Instance=new A199034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199035
{
public static readonly long[] Value={ 0L,0L,3L,12L,29L,143L,877L,3516L,8987L,81112L,342188L,667215L,7467547L,32878290L,56393050L,697859958L,3145355560L,5126416780L,66563431854L,303713138234L,484994209944L,6455395706354L,29679649731124L,47028010467376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199035Inst : IEnumerable<long>
{
public static readonly long[] Value=A199035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199035.Bytes);
public long this[int i]=>Value[i];

public static A199035Inst Instance=new A199035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199036
{
public static readonly long[] Value={ 0L,3L,10L,127L,631L,8090L,59384L,617083L,5480374L,54176239L,509231783L,4993452921L,48215558259L,473249770477L,4631610073092L,45669141577218L,450616426169273L,4464671668507302L,44308975264570192L,440935402785467477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199036Inst : IEnumerable<long>
{
public static readonly long[] Value=A199036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199036.Bytes);
public long this[int i]=>Value[i];

public static A199036Inst Instance=new A199036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199037
{
public static readonly BigInteger[] Value={ 0L,12L,127L,3916L,86544L,674064L,35902575L,750625102L,5442674205L,326415070048L,6891880687104L,50123775833686L,3107281380843015L,66459989877060602L,486615013344919101L,BigInteger.Parse("30688654869734908624"),BigInteger.Parse("662760542913624114980") };
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
public class A199037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199037Inst Instance=new A199037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199038
{
public static readonly long[] Value={ 0L,29L,631L,86544L,3806692L,59029339L,7354780137L,330637303049L,5165845286283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199038Inst : IEnumerable<long>
{
public static readonly long[] Value=A199038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199038.Bytes);
public long this[int i]=>Value[i];

public static A199038Inst Instance=new A199038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199039
{
public static readonly long[] Value={ 1L,143L,8090L,674064L,59029339L,5590093696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199039Inst : IEnumerable<long>
{
public static readonly long[] Value=A199039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199039.Bytes);
public long this[int i]=>Value[i];

public static A199039Inst Instance=new A199039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199040
{
public static readonly long[] Value={ 3L,877L,59384L,35902575L,7354780137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199040Inst : IEnumerable<long>
{
public static readonly long[] Value=A199040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199040.Bytes);
public long this[int i]=>Value[i];

public static A199040Inst Instance=new A199040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199041
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,3L,0L,0L,12L,10L,12L,0L,1L,29L,127L,127L,29L,1L,3L,143L,631L,3916L,631L,143L,3L,3L,877L,8090L,86544L,86544L,8090L,877L,3L,1L,3516L,59384L,674064L,3806692L,674064L,59384L,3516L,1L,6L,8987L,617083L,35902575L,59029339L,59029339L,35902575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199041Inst : IEnumerable<long>
{
public static readonly long[] Value=A199041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199041.Bytes);
public long this[int i]=>Value[i];

public static A199041Inst Instance=new A199041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199042
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-1L,17L,-95L,175L,3775L,-63775L,533825L,108575L,-98151425L,2037293425L,-20945772575L,-111991234225L,10648024541375L,-261756393325375L,3003396413226625L,43283396332525375L,-3352997476533082625L,BigInteger.Parse("94455063540276700625"),BigInteger.Parse("-1135469395905648529375") };
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
public class A199042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199042Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199042.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199042.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199042Inst Instance=new A199042Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199043
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-2L,8L,-16L,-112L,1968L,-16896L,55680L,1243392L,-32546304L,427932672L,-1824506880L,-79446663168L,2767039739904L,-48592416374784L,243186999164928L,17201692341633024L,-744898387504988160L,16285431143888584704UL,BigInteger.Parse("-90779807638034841600") };
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
public class A199043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199043Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199043.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199043.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199043Inst Instance=new A199043Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199044
{
public static readonly BigInteger[] Value={ 1L,0L,6L,0L,74L,0L,1140L,0L,19562L,0L,357756L,0L,6824684L,0L,134166696L,0L,2697855082L,0L,55213424556L,0L,1146078241284L,0L,24067465856088L,0L,510351502965548L,0L,10911807871502232L,0L,234970037988773560L,0L,5091149074269149520L,0L,BigInteger.Parse("110912377099411850090"),0L };
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
public class A199044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199044Inst Instance=new A199044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199045
{
public static readonly ulong[] Value={ 2L,12L,112L,1120L,10112L,101120L,1002112L,10010112L,100101120L,1001011200L,10002010112L,100012122112L,1000121221120L,10001212211200L,100002002010112L,1000000210010112L,10000002100101120L,100000021001011200L,1000000210010112000L,10000000201221210112UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199045Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199045.Bytes);
public ulong this[int i]=>Value[i];

public static A199045Inst Instance=new A199045Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199046
{
public static readonly long[] Value={ 1L,7L,2L,8L,4L,6L,6L,3L,1L,8L,9L,9L,7L,1L,7L,7L,2L,2L,2L,3L,5L,6L,5L,9L,1L,8L,4L,8L,2L,7L,4L,7L,9L,4L,6L,2L,7L,5L,7L,2L,0L,3L,2L,2L,2L,5L,2L,9L,5L,0L,7L,7L,4L,5L,0L,7L,4L,7L,2L,1L,4L,4L,5L,6L,9L,2L,2L,9L,8L,4L,6L,3L,1L,5L,1L,3L,8L,8L,6L,4L,5L,1L,0L,6L,7L,8L,5L,5L,9L,1L,2L,1L,7L,9L,0L,7L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199046Inst : IEnumerable<long>
{
public static readonly long[] Value=A199046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199046.Bytes);
public long this[int i]=>Value[i];

public static A199046Inst Instance=new A199046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199047
{
public static readonly long[] Value={ 1L,0L,6L,1L,5L,4L,9L,7L,7L,4L,6L,3L,1L,3L,8L,3L,8L,2L,5L,6L,0L,2L,0L,3L,3L,4L,0L,3L,5L,1L,9L,8L,9L,9L,3L,4L,2L,0L,5L,8L,8L,7L,4L,1L,7L,8L,3L,8L,9L,2L,4L,1L,4L,8L,6L,0L,8L,4L,9L,8L,8L,9L,3L,5L,8L,0L,9L,3L,2L,5L,3L,6L,5L,8L,0L,7L,8L,0L,1L,3L,6L,8L,1L,6L,0L,5L,0L,3L,5L,5L,2L,0L,1L,0L,5L,5L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199047Inst : IEnumerable<long>
{
public static readonly long[] Value=A199047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199047.Bytes);
public long this[int i]=>Value[i];

public static A199047Inst Instance=new A199047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199048
{
public static readonly long[] Value={ 1L,9L,7L,9L,3L,2L,0L,1L,4L,6L,5L,5L,6L,2L,1L,1L,4L,6L,0L,3L,3L,5L,7L,4L,9L,7L,1L,3L,9L,8L,8L,4L,7L,4L,4L,5L,2L,1L,1L,6L,6L,4L,2L,1L,5L,0L,5L,9L,4L,1L,8L,4L,6L,6L,7L,9L,1L,4L,0L,9L,7L,5L,5L,5L,8L,1L,8L,1L,1L,9L,5L,8L,4L,1L,9L,3L,2L,6L,5L,0L,0L,7L,5L,5L,1L,5L,8L,8L,0L,8L,8L,6L,6L,3L,9L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199048Inst : IEnumerable<long>
{
public static readonly long[] Value=A199048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199048.Bytes);
public long this[int i]=>Value[i];

public static A199048Inst Instance=new A199048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199049
{
public static readonly long[] Value={ 1L,4L,1L,8L,3L,1L,0L,0L,9L,1L,6L,2L,2L,5L,2L,5L,0L,4L,5L,6L,9L,1L,9L,4L,9L,6L,0L,0L,8L,0L,3L,7L,4L,8L,2L,3L,9L,8L,7L,4L,7L,3L,3L,8L,7L,1L,5L,0L,3L,0L,4L,5L,6L,6L,1L,4L,3L,6L,9L,8L,3L,6L,8L,8L,5L,4L,8L,6L,4L,1L,9L,7L,7L,4L,5L,6L,5L,4L,9L,0L,8L,3L,2L,4L,4L,1L,8L,4L,8L,3L,8L,6L,0L,2L,5L,4L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199049Inst : IEnumerable<long>
{
public static readonly long[] Value=A199049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199049.Bytes);
public long this[int i]=>Value[i];

public static A199049Inst Instance=new A199049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199050
{
public static readonly long[] Value={ 2L,1L,5L,9L,4L,7L,8L,2L,9L,6L,9L,7L,4L,1L,1L,6L,0L,1L,8L,2L,6L,8L,9L,2L,3L,8L,7L,8L,5L,2L,4L,6L,8L,9L,0L,0L,9L,2L,9L,0L,4L,7L,3L,6L,2L,4L,8L,0L,8L,4L,3L,6L,6L,7L,3L,1L,0L,5L,5L,8L,9L,2L,8L,8L,0L,1L,0L,2L,8L,9L,1L,3L,3L,4L,9L,1L,8L,2L,7L,5L,7L,1L,4L,6L,3L,4L,1L,3L,1L,8L,3L,7L,0L,2L,2L,1L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199050Inst : IEnumerable<long>
{
public static readonly long[] Value=A199050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199050.Bytes);
public long this[int i]=>Value[i];

public static A199050Inst Instance=new A199050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199051
{
public static readonly long[] Value={ 1L,1L,0L,2L,4L,4L,0L,9L,9L,2L,7L,8L,2L,4L,7L,4L,5L,0L,2L,9L,0L,0L,5L,1L,2L,3L,2L,6L,9L,5L,8L,5L,7L,9L,1L,1L,5L,6L,4L,4L,2L,2L,5L,6L,9L,1L,4L,6L,4L,3L,4L,4L,8L,9L,0L,7L,6L,6L,8L,5L,2L,3L,7L,9L,8L,9L,4L,1L,3L,6L,3L,8L,1L,2L,7L,7L,3L,5L,7L,8L,6L,7L,0L,0L,8L,0L,5L,9L,3L,6L,5L,3L,8L,3L,1L,6L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199051Inst : IEnumerable<long>
{
public static readonly long[] Value=A199051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199051.Bytes);
public long this[int i]=>Value[i];

public static A199051Inst Instance=new A199051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199052
{
public static readonly long[] Value={ 1L,3L,9L,8L,4L,0L,3L,0L,6L,8L,9L,5L,6L,7L,0L,4L,2L,8L,1L,9L,1L,3L,6L,2L,1L,0L,7L,0L,1L,0L,0L,3L,3L,0L,8L,6L,9L,9L,2L,9L,2L,5L,4L,1L,2L,5L,1L,2L,3L,2L,2L,0L,9L,0L,4L,8L,2L,2L,7L,3L,3L,7L,6L,6L,8L,4L,7L,7L,1L,7L,9L,8L,3L,3L,7L,9L,6L,0L,2L,2L,4L,7L,0L,0L,9L,9L,0L,4L,2L,9L,7L,6L,8L,1L,8L,5L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199052Inst : IEnumerable<long>
{
public static readonly long[] Value=A199052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199052.Bytes);
public long this[int i]=>Value[i];

public static A199052Inst Instance=new A199052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199053
{
public static readonly long[] Value={ 3L,9L,5L,8L,0L,9L,2L,3L,4L,4L,6L,9L,1L,3L,7L,8L,3L,7L,5L,8L,2L,5L,4L,7L,9L,9L,4L,3L,4L,0L,5L,2L,1L,8L,9L,2L,5L,2L,3L,5L,7L,9L,4L,8L,7L,5L,1L,2L,6L,5L,5L,7L,7L,0L,9L,3L,7L,9L,1L,5L,1L,6L,5L,3L,6L,3L,6L,5L,2L,8L,5L,8L,6L,7L,4L,8L,6L,5L,4L,0L,4L,5L,7L,4L,0L,3L,0L,5L,1L,1L,4L,2L,7L,0L,4L,0L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199053Inst : IEnumerable<long>
{
public static readonly long[] Value=A199053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199053.Bytes);
public long this[int i]=>Value[i];

public static A199053Inst Instance=new A199053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199054
{
public static readonly long[] Value={ 1L,9L,4L,6L,8L,7L,7L,7L,4L,4L,6L,7L,0L,6L,8L,2L,9L,0L,8L,3L,3L,5L,4L,7L,3L,5L,4L,6L,6L,9L,7L,7L,2L,3L,8L,6L,1L,8L,8L,1L,5L,9L,2L,3L,4L,1L,2L,9L,4L,2L,8L,9L,9L,9L,1L,3L,7L,3L,1L,9L,5L,9L,9L,7L,7L,7L,1L,2L,3L,9L,0L,9L,2L,4L,6L,1L,9L,9L,5L,4L,9L,1L,6L,9L,6L,4L,6L,8L,6L,8L,3L,4L,1L,6L,6L,2L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199054Inst : IEnumerable<long>
{
public static readonly long[] Value=A199054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199054.Bytes);
public long this[int i]=>Value[i];

public static A199054Inst Instance=new A199054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199055
{
public static readonly long[] Value={ 3L,0L,6L,7L,5L,5L,3L,5L,4L,1L,3L,7L,7L,5L,3L,0L,0L,7L,0L,1L,1L,6L,5L,1L,6L,3L,4L,7L,3L,3L,3L,6L,0L,1L,4L,7L,8L,3L,9L,0L,9L,6L,1L,9L,0L,2L,7L,0L,1L,9L,8L,4L,5L,7L,0L,9L,0L,6L,8L,2L,0L,2L,0L,1L,6L,0L,2L,4L,1L,5L,1L,1L,8L,4L,1L,3L,1L,8L,1L,3L,2L,9L,5L,8L,2L,5L,5L,6L,2L,4L,2L,4L,6L,7L,4L,5L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199055Inst : IEnumerable<long>
{
public static readonly long[] Value=A199055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199055.Bytes);
public long this[int i]=>Value[i];

public static A199055Inst Instance=new A199055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199056
{
public static readonly long[] Value={ 2L,1L,3L,1L,0L,4L,7L,7L,6L,4L,0L,5L,6L,3L,5L,5L,7L,1L,0L,0L,0L,1L,1L,3L,3L,6L,9L,5L,3L,5L,8L,5L,5L,3L,8L,8L,7L,1L,6L,9L,6L,5L,8L,2L,1L,6L,7L,7L,7L,6L,2L,1L,4L,8L,1L,1L,0L,6L,6L,9L,0L,2L,9L,9L,1L,0L,1L,9L,6L,2L,6L,3L,2L,9L,5L,7L,4L,2L,0L,2L,9L,4L,8L,2L,7L,1L,0L,7L,2L,2L,7L,9L,3L,3L,0L,4L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199056Inst : IEnumerable<long>
{
public static readonly long[] Value=A199056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199056.Bytes);
public long this[int i]=>Value[i];

public static A199056Inst Instance=new A199056Inst();

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